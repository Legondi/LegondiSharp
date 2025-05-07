using System;

namespace Legondi
{

    public static class Tabuada
    {

        public static void TabuadaSimples()
        {

            int i;
            float num1, num2, result;


            Console.WriteLine("Num1: ");
            num1 = float.Parse(Console.ReadLine());


            for (i = 1; i <= 10; i++)
            {

                num2 = i;
                result = num1 * num2;

                Console.WriteLine(num1 + "x" + i + "=" + result);

            }


        }


    }

    public static class Pass
    {

        public static void ConfirmPass()
        {

            string pass;
            bool val = true;

            do
            {
                Console.WriteLine("digite sua senha");
                pass = Console.ReadLine();
                //Console.WriteLine(pass);

                if (pass != "1234")
                {

                    Console.WriteLine("Senha incorreta");

                }
                else
                {

                    Console.WriteLine("Acesso Correto");
                    val = false;
                }

            }
            while (val == true);

        }

    }

    public static class Decrescente
    {

        public static void TesteDecresente()
        {

            int i;



            Console.WriteLine("Num: ");
            i = int.Parse(Console.ReadLine());


            for (; i >= 0; i--)
            {

                Console.WriteLine(i);


            }

        }

    }

}