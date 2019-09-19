using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSE.SQAT.Lab1App
{
    public class ChessChecker
    {
        public static bool SearchForStrikingQueens(sbyte firstX, sbyte firstY, sbyte secondX, sbyte secondY)
        {
            if (firstX > 8 || firstX <= 0 || secondX > 8 || secondX <= 0 || firstY > 8 || firstY <= 0 || secondY > 8 || secondY <= 0)
            {
                throw new ArgumentException();
            }
            if (firstX==secondX && firstY == secondY)
            {
                throw new ArgumentException("Позиции ферзей одинаковы!");
            }
            if (firstX == secondX || firstY == secondY || Math.Abs(firstX - secondX) == Math.Abs(firstY - secondY))
            {
                return true;
            }
            else return false;
        }
    }
}
