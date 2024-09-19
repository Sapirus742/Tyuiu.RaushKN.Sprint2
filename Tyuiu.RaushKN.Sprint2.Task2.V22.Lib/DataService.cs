using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RaushKN.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 3) && (y >= 3) && (x <= 5) && (y <= 7)) res = true;
            else
            {
                if ((x >= 4) && (y >= 8) && (x <= 6) && (y <= 11)) res = true;
                else
                {
                    if (x == 3 & y == 11) res = true;
                    else
                    {
                        if ((x == 5) && (y >= 12) && (y <= 13)) res = true;
                        else
                        {
                            if ((x >= 4) && (x <= 10) && (y == 14)) res = true;
                            else
                            {
                                if ((x >= 6) && (x <= 12) && (y >= 5) && (y <= 7)) res = true;
                                else
                                {
                                    if ((x >= 9) && (x <= 12) && (y >= 3) && (y <= 4)) res = true;
                                    else
                                    {
                                        if ((x == 13) && (y >= 6) && (y <= 8)) res = true;
                                        else
                                        {
                                            if ((x >= 9) && (x <= 10) && (y >= 8) && (y <= 9)) res = true;
                                            else
                                            {
                                                if ((x == 12) && (y >= 8) && (y <= 11)) res = true;
                                                else res = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return res;
        }
    }
}
