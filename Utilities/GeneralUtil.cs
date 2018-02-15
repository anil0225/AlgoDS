using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class GeneralUtil
    {
        public static int[] Exchange(int[] input, int pos1, int pos2) {
            var temp = input[pos1];
            input[pos1] = input[pos2];
            input[pos2] = temp;
            return input;
        }
    }
}
