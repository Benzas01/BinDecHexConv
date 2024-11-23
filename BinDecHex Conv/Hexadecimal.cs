using System;
using System.Text;

public class Hexadecimal
{
    const string NumArray = "0123456789ABCDEF";
    public static int ConvertToDec(string number)
    {
        int sum = 0;
        char[] Nums = NumArray.ToCharArray();
        int timeswhat = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            char numberSpec = number[i];
            double numbernum = NumArray.IndexOf(number[i]);
            double numberval = numbernum * Math.Pow(16, timeswhat);
            sum += Convert.ToInt32(numberval);
            timeswhat++;
        }
        return sum;
    }
}