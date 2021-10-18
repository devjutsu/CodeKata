using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class DivisibleBy5
    {
        public const string DivisibleByFive = "^(0|1(10)*(0|11)(01*01|01*00(10)*(0|11))*1)+$";

        // State machine scheme: https://imgur.com/a/h3khX2N
        /*
        ^ // string start
        0* // preceding zeros
        (0 // following zeros
        |1( // get to 1
            // short loop on 1
           (10) // loop 3-1
          |( // long loop on 1
            (0|11) get to 2
          (01*01)* loop 4-3-2
          (01*00) 4-3-1
        ))* // loop 1
        (0|11) // get to 2
        (01*01)* // loop 4-3-2
        1)+ // get to 0
        $ // string end
        */
        //public const string DivisibleByFive = "^0*(0|1((10)|((0|11)(01*01)*(01*00)))*(0|11)(01*01)*1)+$";
    }
}
