using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMatematica
{
    public class LibreriaMatematica
    {

        public static bool EsPar(int numero)
        {
            return Convert.ToBoolean((numero % 2 == 0 ? true : false));
        }


        public static bool EsPrimo(int numero)
        {
            int sumatorio = 0;
            for (int contador = 1; contador < numero + 1; contador++)
            {
                if (contador % 2 == 0)
                {
                    sumatorio++;
                }
            }

                if (sumatorio != 2)
                {
                    return false;
                }else
                {
                    return true;
                }

            
        }           
    }
}
