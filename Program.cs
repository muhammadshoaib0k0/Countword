using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countword
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int count = 1 , len=0;
            Console.WriteLine("Enter a string :  ");
            str = Console.ReadLine();

            while (len<=str.Length-1)
            {    // use single ' ' quation not use double quation " "
                if(str[len]==' ' || str[len]=='\n' || str[len]=='\t')
                {
                    count++;
                }
                len++;
            }
            Console.WriteLine("total no of words are : " + count);
            Console.ReadLine();
        }
    }
}
