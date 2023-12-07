// Number Checking algoriths...

using System;
using System.Text;

internal sealed class CheckNumbers
{
    internal static string CheckNumber(in int data)
    {
        StringBuilder sb = new StringBuilder();
        return sb.ToString();
    }

    // Check for Palindrome:
    private static bool isPalindromeNumber(in int data)
    {
        int xerox = data;
        int rev = 0;

        while (xerox > 0)
        {
            int d = xerox % 10;
            rev = rev * 10 + d;
            xerox /= 10;
        }

        if (rev == data)
            return true;
        else
            return false;
    }

    // Check for Duck:
    private static bool isDuckNumber(int data)
    {
        while (data > 0)
        {
            int d = data % 10;
            data /= 10;

            if (d == 0)
            return true;
        }

        return false;
    }

    // Check for Even:
    private static bool isEvenNumber(in int data)
    {
        if (data % 2 == 0)
            return true;
        else
            return false;
    }

    // Check for Prime:
    private static bool isPrimeNumber(in int data)
    {
        for (int i = 2; i <= data / 2; i++)
            if (data % i == 0)
                return false;

        return true;
    }

    // Check for Harshad:
    private static bool isHarshadNumber(in int data)
    {
        int xerox = data;
        int sum = 0;

        while (xerox > 0)
        {
            int d = xerox % 10;
            sum += d;
            xerox /= 10;
        }

        if (data % sum == 0)
            return true;
        else
            return false;
    }

    // Check for Armstrong:
    private static bool isArmstrongNumber(in int data)
    {
        int xerox = data;
        int sum = 0;

        while (xerox > 0)
        {
            int d = xerox % 10;
            sum += (int)Math.Pow(d, 3);
            xerox /= 10;
        }

        if (sum == data)
            return true;
        else
            return false;
    }

    // Check for Neon:
    private static bool isNeonNumber(in int data)
    {
        int square = (int)Math.Pow(data, 2);
        int sum = 0;

        while (square > 0)
        {
            int d = square % 10;
            sum += d;
            square /= 10;
        }

        if (sum == data)
            return true;
        else
            return false;
    }
}