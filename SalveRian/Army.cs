using System;
using System.Collections.Generic;
using System.Text;

namespace SalveRian
{
    public class Army
    {
        public int SaveSoldier(int soldiers)
        {
            int resultado = 0;
            int morto = 2;

            for (int i = 2; i <= soldiers; i++)
            {
                resultado = (morto + resultado) % i;
            }
            return (resultado+1);
        }
    }
}
