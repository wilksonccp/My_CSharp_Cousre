using System.Net.NetworkInformation;

namespace System;

public static class StringExtension
{
    public static string Cut(this string input, int count)
    {
        if(input.Length <= count)
        {
            return input;
        }
        else
        {
            return input.Substring(0, count) + "...";
        }
    }
}
