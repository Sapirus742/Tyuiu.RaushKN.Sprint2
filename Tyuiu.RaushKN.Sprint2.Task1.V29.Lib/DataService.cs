using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RaushKN.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (a <= c); 
            res[1] = (c >= d) & (a == d);
            res[2] = (d <= b) || (d == c);
            res[3] = (a > c) && (c != b);
            res[4] = !(b > c);
            res[5] = (b > d) ^ (a <= c);

            return res;

        }
    }
}
