using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuantasVecesCabe
{
    internal class Operacion
    {
        private int num1 = 0;
        private int num2 = 0;
        private int resultado = 0;

        public void setNum1 ()
        {
            try
            {
                do
                {
                    Console.Write("\nNumero 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    if (num1 < 1000)
                    {
                        Console.WriteLine("\nNúmero incorrecto vuelva a intentar");
                    }

                } while (num1 < 1000);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void setNum2 ()
        {
            try
            {
                do
                {
                    Console.Write("\nNumero 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    if (num2 > 100)
                    {
                        Console.WriteLine("\nNúmero incorrecto vuelva a intentar");
                    }

                } while (num2 > 100);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public int Calculo() 
        {
            return resultado = num1 / num2;
        }
    }
}
