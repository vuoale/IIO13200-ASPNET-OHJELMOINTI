using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLotto
/// </summary>
public static class BLLotto
{
    static Random rnd = new Random();

    public static List<int> arvoSuomi()
    {      
        List<int> numerot = new List<int>();
        numerot = Enumerable.Range(1, 39).OrderBy(x => rnd.Next()).Take(7).ToList();
        return numerot;
    }

    public static List<int> arvoViking()
    {
        List<int> numerot = new List<int>();
        numerot = Enumerable.Range(1, 48).OrderBy(x => rnd.Next()).Take(6).ToList();
        return numerot;
    }
}