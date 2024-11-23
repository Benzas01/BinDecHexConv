using System;
using System.Text;

public class Binary
{
    public static int ConvertToDec(string number)
    {
        int timeswhat = 0;
        int numberdec = 0;
        for(int i = number.Length-1; i >= 0;i--)
        {
            char numberSpec = number[i];
            double numbernum = char.GetNumericValue(numberSpec);
            double numberval = numbernum * Math.Pow(2, timeswhat);
            numberdec += Convert.ToInt32(numberval);
            timeswhat++;
        }
        return numberdec;
    }
    public static string ConverToBin(string number)
    {
        StringBuilder BinNum = new StringBuilder();
        int numvalue = int.Parse(number);
        if(numvalue == 1)
        {
            return "1";
        }
        else if(numvalue == 0)
        {
            return "0";
        }
        while (numvalue != 1)
        {
            int longdiv = numvalue % 2;
            BinNum.Insert(0,longdiv);
            numvalue -= (numvalue / 2)+longdiv;
        }
        BinNum.Insert(0, 1);
        return BinNum.ToString();
    }
}
