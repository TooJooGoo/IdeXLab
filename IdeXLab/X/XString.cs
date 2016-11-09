// ----------------------------------------------------
// COPYRIGHT (C) <TJG> ALL RIGHTS RESERVED. SEE THE LIC
// ENSE FILE FOR THE FULL LICENSE GOVERNING THIS CODE. 
// ----------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

public class XString
{
    public static bool Eq(string a, string b)
    {
        return string.Equals(a, b, StringComparison.InvariantCultureIgnoreCase);
    }

    public static bool StartsWith(string str, string prefix)
    {
        return str.StartsWith(prefix, StringComparison.InvariantCultureIgnoreCase);
    }

    internal static void ParseAssoc(string input, out string left, out string right, string delim="=")
    {
        if(!string.IsNullOrEmpty(input))
        {
            var i = input.IndexOf(delim);
            if(i > 0)
            {
                left = input.Substring(0, i).Trim();
                right = input.Substring(i+ 1).Trim();
                return;
            }
        }
        left = "";
        right = "";
    }
    internal static void ParseAssocRight(string input, out string right, string delim = "=")
    {
        if (!string.IsNullOrEmpty(input))
        {
            var i = input.IndexOf(delim);
            if (i > 0)
            {
                right = input.Substring(i + 1).Trim();
                return;
            }
        }
        right = "";
    }
    internal static string AssocGetRight(string input, string delim = "=")
    {
        if (!string.IsNullOrEmpty(input))
        {
            var i = input.IndexOf(delim);
            if (i > 0)
            {
                return input.Substring(i + 1).Trim();
            }
        }
        return "";
    }

    public static string[] SplitIntoLines(string input)
    {
        var parts = input.Split('\n').Where(x => !string.IsNullOrEmpty(x))
            .Select(x => x.Trim()).ToArray();
        return parts;
    }

    public static IEnumerable<KeyValuePair<string, string>> ToDict(string input
    , char delim1 = '\n', char delim2 = '=')
    {
        var look = input.Split(delim1).Where(part => part.Trim() != "").ToLookup(
            x => x.Substring(0, x.IndexOf(delim2)).Trim(),
            x => x.Substring(x.IndexOf(delim2) + 1).Trim());
        var dict = look.ToDictionary(
            x => x.Key,
            x => x.ElementAt(0));
        return dict;
    }
}
