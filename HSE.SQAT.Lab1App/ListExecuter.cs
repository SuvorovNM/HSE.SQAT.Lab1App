using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSE.SQAT.Lab1App
{
    public class ListExecuter
    {
        private static List<string> TransformStringToList(string inputLine)
        {
            if (inputLine.Length == 0) return null;
            var createdList = new List<string>();
            createdList = inputLine.Split(',').ToList();
            return createdList;
        }
        public static List<string> DeleteEverySecondElement(string inputLine)
        {
            var inputList = TransformStringToList(inputLine);
            if (inputList==null) return null;
            if (inputList.Count == 1) return inputList;
            int count = inputList.Count / 2;
            for (int i = 1; i <= count; i++)
            {
                inputList.RemoveAt(i);
            }
            return inputList;
        }
    }
}
