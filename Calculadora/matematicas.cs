using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class matematicas
    {
        public static int suma(int sumando1, int sumando2)
        {
            return sumando1 - sumando2; 
            //Aqui le cambie el signo de + a menos para ver si detecta esta parte el github 
        }
        public static int resta(int restando1, int restando2)
        {
            return restando1 - restando2;
        }
        public static int division(int dividendo, int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("No se puede dividir entre CERO");

            return dividendo / divisor;
        }
        public static int multiplicacion (int mult1, int mult2)
        {
            return mult1 * mult2;
        }
        //Comentario para comprobar la segunda version

        
    }
}
