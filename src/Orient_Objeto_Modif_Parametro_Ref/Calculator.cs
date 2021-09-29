using System;
using System.Collections.Generic;
using System.Text;

namespace Orient_Objeto_Modif_Parametro_Ref
{
    class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
}
