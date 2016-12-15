using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Octokit;
using System.Threading.Tasks;

public partial class GithubAPI : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtGithubUser_TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtGithubUser.Text))
            UpdateRepoList();
        else
            ddlGithubRepo.Items.Clear();
    }

    protected void btnGetData_Click(object sender, EventArgs e)
    {
        GetData();
    }

    protected async void UpdateRepoList()
    {
        ddlGithubRepo.Items.Clear();
        lblMessages.Text = "";
        try
        {
            List<string> repos = await GetReposForUser(txtGithubUser.Text);
            if (repos != null && repos.Count > 0)
            {
                ddlGithubRepo.DataSource = repos;
                ddlGithubRepo.DataBind();
            }
        }
        catch (Exception)
        {
            lblMessages.Text = "User '" + txtGithubUser.Text + "' does not exist.";
        }
    }

    protected async void GetData()
    {
        divCommits.InnerHtml = "";
        divLanguages.InnerHtml = "";
        divFollowers.InnerHtml = "";
        lblMessages.Text = "";

        try
        {
            // Commits
            List<GitHubCommit> commits = await GetCommits(txtGithubUser.Text, ddlGithubRepo.Text);
            if (commits != null && commits.Count > 0)
            {
                foreach (GitHubCommit c in commits)
                {
                    divCommits.InnerHtml += string.Format("{0} -- {1} pushed a commit: <a href='{2}'>{3}</a><br/>",
                                                            c.Commit.Author.Date.DateTime.ToShortDateString(), c.Commit.Author.Name, c.HtmlUrl, c.Commit.Message);
                }
            }

            // Programming languages
            List<RepositoryLanguage> languages = await GetLanguages(txtGithubUser.Text, ddlGithubRepo.Text);
            if (languages != null && languages.Count > 0)
            {
                foreach (RepositoryLanguage l in languages)
                {
                    divLanguages.InnerHtml += string.Format("{0}<br/>", l.Name);
                }
            }

            // Followers
            List<User> followers = await GetFollowers(txtGithubUser.Text);
            if (followers != null && followers.Count > 0)
            {
                foreach (User u in followers)
                {
                    divFollowers.InnerHtml += string.Format("<a href='{0}'>{1}</a><br/>", u.HtmlUrl, u.Login);
                }
            }
        }
        catch (Exception)
        {
            lblMessages.Text = "Failed loading stuff from Github! Probably API rate limit exceeded for your IP...";
        }
    }

    /// <summary>
    /// Gets repositories for user
    /// </summary>
    public static async Task<List<string>> GetReposForUser(string username)
    {
        try
        {
            var client = new GitHubClient(new ProductHeaderValue("demo"));
            var repos = await client.Repository.GetAllForUser(username);
            List<string> repoNames = new List<string>();

            if (repos != null && repos.Count > 0)
            {
                foreach (var r in repos)
                {
                    repoNames.Add(r.Name);
                }
                return repoNames;
            }
        }
        catch (Exception)
        {
            throw;
        }
        return null;
    }

    /// <summary>
    /// Gets commits for user/repo
    /// </summary>
    public static async Task<List<GitHubCommit>> GetCommits(string user, string repo)
    {
        try
        {
            var client = new GitHubClient(new ProductHeaderValue("demo"));
            var commits = await client.Repository.Commit.GetAll(user, repo);
            List<GitHubCommit> commitList = new List<GitHubCommit>();

            if (commits != null && commits.Count > 0)
            {
                for (int i = 0; i < commits.Count; i++)
                {
                    if (i == 6) // Take only latest (6) commits
                        break;
                    commitList.Add(commits[i]);
                }
                return commitList;
            }
        }
        catch (Exception)
        {
            throw;
        }
        return null;
    }

    /// <summary>
    /// Gets programming languages used in the repo
    /// </summary>
    public static async Task<List<RepositoryLanguage>> GetLanguages(string user, string repo)
    {
        try
        {
            var client = new GitHubClient(new ProductHeaderValue("demo"));
            var languages = await client.Repository.GetAllLanguages(user, repo);
            List<RepositoryLanguage> languageList = new List<RepositoryLanguage>();

            if (languages != null && languages.Count > 0)
            {
                foreach (RepositoryLanguage l in languages)
                {
                    languageList.Add(l);
                }
                return languageList;
            }
        }
        catch (Exception)
        {
            throw;
        }
        return null;
    }

    /// <summary>
    /// Gets followers for user
    /// </summary>
    public static async Task<List<User>> GetFollowers(string user)
    {
        try
        {
            var client = new GitHubClient(new ProductHeaderValue("demo"));
            var followers = await client.User.Followers.GetAll(user);
            List<User> followerNames = new List<User>();

            if (followers != null && followers.Count > 0)
            {
                foreach (User u in followers)
                {
                    followerNames.Add(u);
                }
                return followerNames;
            }
        }
        catch (Exception)
        {
            throw;
        }
        return null;
    }
}