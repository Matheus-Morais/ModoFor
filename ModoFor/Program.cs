using System;

class ModoFor
{
    public static void Main(string[] args)
    {
        do
        {
            string strDecimal = "";
            int intDecimal = 0;
            string strRomano = "";
            string strConta = "";


            while (true)
            {
                Console.WriteLine();
                Console.Write("Insira um numero até 3999:");
                strDecimal = Console.ReadLine();

                try
                {
                    intDecimal = Convert.ToInt32(strDecimal);
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Não é possível converter caracteres!");
                    continue;
                }

                if (intDecimal > 0 & intDecimal <= 3999)
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("Número inválido!");
            }

            int[] valoresDecimais = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] valoresRomanos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < valoresDecimais.Length; i++)
            {
                while (intDecimal >= valoresDecimais[i])
                {
                    strRomano += valoresRomanos[i];
                    intDecimal -= valoresDecimais[i];
                    strConta += "+" + valoresDecimais[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Numero em romanos: " + strRomano);

            Console.WriteLine();
            Console.WriteLine(strConta);

            Console.WriteLine();
            Console.Write("Converter outro numero(s/n): ");

        } while (Console.ReadLine() == "s");
    }
}