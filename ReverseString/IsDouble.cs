using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class IsDouble
    {
        int[] intArray;
        public bool VerifyDouble(int[] checkArray)
        {
            for (int i = 0; i < checkArray.Length; i++)
            {
                for (int j = 0; j < checkArray.Length; j++)
                {
                    if (i * 2 == checkArray[j])
                    {
                        Messages.HasDouble();
                        return true;
                    }
                }
            }
            Messages.NoDouble();
            return false;
        }
    }
}
