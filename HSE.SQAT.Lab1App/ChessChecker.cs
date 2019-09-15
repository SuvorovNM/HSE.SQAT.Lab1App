using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSE.SQAT.Lab1App
{
    public class ChessChecker
    {
        public static bool SearchForStrikingQueens(sbyte FirstX, sbyte FirstY, sbyte SecondX, sbyte SecondY)
        {
            if (FirstX > 8 || FirstX <= 0 || SecondX > 8 || SecondX <= 0 || FirstY > 8 || FirstY <= 0 || SecondY > 8 || SecondY <= 0)
            {
                throw new ArgumentException();
            }
            if (FirstX==SecondX && FirstY == SecondY)
            {
                throw new ArgumentException("Позиции ферзей одинаковы!");
            }
            if (FirstX == SecondX || FirstY == SecondY || Math.Abs(FirstX - SecondX) == Math.Abs(FirstY - SecondY))
            {
                return true;
            }
            else return false;
        }
    }
}
