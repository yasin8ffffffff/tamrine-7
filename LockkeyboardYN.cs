//////////////یاسین منعم//////////////////
Using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digikala1.process
{
    class LockKeyboard
    {
        private string input;
        public string lockKeyboardYN()
        {
            Console.WriteLine("Do you want to countinue?  press y for Stop press n");
            do
            {
                input = Console.ReadKey(true).KeyChar.ToString();

            } while (input.ToLower() != "y" && input.ToLower() != "n");

            return input;
        }
    }
}
