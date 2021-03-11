using System;
using System.Collections.Generic;
using System.Text;

namespace Training.LeetCode.februari.week2
{
    public static class IntegerToRoman
    {
        
        public static string Convert(int num)
        {
            return IntToRoman(num);
        }
        private static string IntToRoman(int num)
        {
            string roman = String.Empty;

            while (num > 0)
            {
                if (num >= 1000)
                {
                    num -= 1000;
                    roman += "M";
                    continue;
                }
                else if (num >= 500)
                {
                    if (num >=900)
                    {
                        num -= 900;
                        roman += "CM";
                        continue;
                    }
                    else if (num >= 800)
                    {
                        num -= 800;
                        roman += "DCCC";
                        continue;
                    }
                    else if (num >= 700)
                    {
                        num -= 700;
                        roman += "DCC";
                        continue;
                    }
                    else if (num >= 600)
                    {
                        num -= 600;
                        roman += "DC";
                        continue;
                    }
                    else if (num >= 500)
                    {
                        num -= 500;
                        roman += "D";
                        continue;
                    }
                }
                else if (num >= 100)
                {
                    // 400, 300, 200, 100
                    if (num >= 400)
                    {
                        num -= 400;
                        roman += "CD";
                        continue;
                    }
                    else if (num >= 300)
                    {
                        num -= 300;
                        roman += "CCC";
                        continue;
                    }
                    else if (num >= 200)
                    {
                        num -= 200;
                        roman += "CC";
                        continue;
                    }
                    else if (num >= 100)
                    {
                        num -= 100;
                        roman += "C";
                        continue;
                    }
                }
                else if (num >= 50)
                {
                    // 90, 80, 70, 60, 50
                    if (num >= 90)
                    {
                        num -= 90;
                        roman += "XC";
                        continue;
                    }
                    else if (num >= 80)
                    {
                        num -= 80;
                        roman += "LXXX";
                        continue;
                    }
                    else if (num >= 70)
                    {
                        num -= 70;
                        roman += "LXX";
                        continue;
                    }
                    else if (num >= 60)
                    {
                        num -= 60;
                        roman += "LX";
                        continue;
                    }
                    else if (num >= 50)
                    {
                        num -= 50;
                        roman += "L";
                        continue;
                    }
                }
                else if (num >= 10)
                {
                    // 40 30 20 10
                    if (num >= 40)
                    {
                        num -= 40;
                        roman += "XL";
                        continue;
                    }
                    else if (num >= 30)
                    {
                        num -= 30;
                        roman += "XXX";
                        continue;
                    }
                    else if (num >= 20)
                    {
                        num -= 20;
                        roman += "XX";
                        continue;
                    }
                    else if (num >= 10)
                    {
                        num -= 10;
                        roman += "X";
                        continue;
                    }
                }
                else if (num >= 5)
                {
                    // 9 8 7 6 5
                    if (num >= 9)
                    {
                        num -= 9;
                        roman += "IX";
                        continue;
                    }
                    else if (num >= 8)
                    {
                        num -= 8;
                        roman += "VIII";
                        continue;
                    }
                    else if (num >= 7)
                    {
                        num -= 7;
                        roman += "VII";
                        continue;
                    }
                    else if (num >= 6)
                    {
                        num -= 6;
                        roman += "VI";
                        continue;
                    }
                    else if (num >= 5)
                    {
                        num -= 5;
                        roman += "V";
                        continue;
                    }
                }
                else if (num >= 0)
                {
                    // 4, 3 , 2, 1
                    if (num >= 4)
                    {
                        num -= 4;
                        roman += "IV";
                        continue;
                    }
                    else if (num >= 3)
                    {
                        num -= 3;
                        roman += "III";
                        continue;
                    }
                    else if (num >= 2)
                    {
                        num -= 2;
                        roman += "II";
                        continue;
                    }
                    else if (num >= 1)
                    {
                        num -= 1;
                        roman += "I";
                        continue;
                    }
                }
            }

            return roman;
        }
    }
}
