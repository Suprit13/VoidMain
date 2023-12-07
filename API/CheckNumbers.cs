// Number Checking algoriths...

using System;
using System.Text;

namespace VoidMainAPI
{
    internal sealed class CheckNumbers
    {
        internal static string CheckNumber(in int data)
        {
            StringBuilder sb = new();
            string[] checkArr = { "Palindrome", "Duck", "Even", "Prime", "Harshad", "Armstrong", "Neon" };

            DoStringOperations(sb, checkArr[0], IsPalindromeNumber(in data));
            DoStringOperations(sb, checkArr[1], IsDuckNumber(data));
            DoStringOperations(sb, checkArr[2], IsEvenNumber(in data));
            DoStringOperations(sb, checkArr[3], IsPrimeNumber(in data));
            DoStringOperations(sb, checkArr[4], IsHarshadNumber(in data));
            DoStringOperations(sb, checkArr[5], IsArmstrongNumber(in data));
            DoStringOperations(sb, checkArr[6], IsNeonNumber(in data));

            return sb.ToString();
        }

        private static void DoStringOperations(StringBuilder sb, string txt, in bool checkedVal)
        {
            if (checkedVal)
                sb.Append($"{txt}: True\n");
            else
                sb.Append($"{txt}: False\n");
        }

        // Check for Palindrome:
        private static bool IsPalindromeNumber(in int data)
        {
            int copy = data;
            int reverse = 0;

            while (copy > 0)
            {
                int digit = copy % 10;
                reverse = reverse * 10 + digit;
                copy /= 10;
            }

            if (reverse == data)
                return true;
            else
                return false;
        }

        // Check for Duck:
        private static bool IsDuckNumber(int data)
        {
            while (data > 0)
            {
                int digit = data % 10;
                data /= 10;

                if (digit == 0)
                    return true;
            }

            return false;
        }

        // Check for Even:
        private static bool IsEvenNumber(in int data)
        {
            if (data % 2 == 0)
                return true;
            else
                return false;
        }

        // Check for Prime:
        private static bool IsPrimeNumber(in int data)
        {
            for (int i = 2; i <= data / 2; i++)
                if (data % i == 0)
                    return false;

            return true;
        }

        // Check for Harshad:
        private static bool IsHarshadNumber(in int data)
        {
            int xerox = data;
            int sum = 0;

            while (xerox > 0)
            {
                int digit = xerox % 10;
                sum += digit;
                xerox /= 10;
            }

            if (data % sum == 0)
                return true;
            else
                return false;
        }

        // Check for Armstrong:
        private static bool IsArmstrongNumber(in int data)
        {
            int xerox = data;
            int sum = 0;

            while (xerox > 0)
            {
                int digit = xerox % 10;
                sum += (int)Math.Pow(digit, 3);
                xerox /= 10;
            }

            if (sum == data)
                return true;
            else
                return false;
        }

        // Check for Neon:
        private static bool IsNeonNumber(in int data)
        {
            int square = (int)Math.Pow(data, 2);
            int sum = 0;

            while (square > 0)
            {
                int digit = square % 10;
                sum += digit;
                square /= 10;
            }

            if (sum == data)
                return true;
            else
                return false;
        }
    }
}
