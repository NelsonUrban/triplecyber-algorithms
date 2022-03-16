using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrypleCyber
{
    public class CommonMethod
    {
        public CommonMethod()
        {

        }
        public void ShowResult (List<int> list)
        {
            list.ForEach(delegate (int number)
            {
                Console.WriteLine("This is your Result :"  + number);
            });

        }
    }
}
