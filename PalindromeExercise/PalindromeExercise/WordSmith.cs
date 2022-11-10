
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {

        //Hello
        public bool IsAPalindrome(string p)
        {
            string empty = "";
            for(int i =p.Length-1;i>=0;i--)
            {
                empty = empty + p[i];


            }

            if (empty == p)
            {
                return true;
            }
            else
            {
                return false;
            }

        }










    }
}
