using System;
using System.IO;
using System.Text;

namespace laba8
{
    class Program
    {
        String s = String.Empty;
        static void Main(string[] args)
        {
            Program my = new Program();
            int i;

            do
            {
                Console.WriteLine("1 Зашифровать\n2 Расшифровать\n3 Выход");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        my.Enc();
                        break;
                    case 2:
                        my.Dec();
                        break;
                    case 3:
                        Console.WriteLine("Выход");
                        return;
                    default:
                        Console.WriteLine("Вы ввели не тот символ.");
                        break;
                }

                Console.Write("\n\n\t\t\tНажмите любую клавишу...");
                Console.ReadLine();
                Console.Clear();
            }
            while ( i != 3);

        }
        void Enc()
        {
            Console.WriteLine("Введите слово,которое нужно зашифровать:");
            s = Console.ReadLine();
            string abc = "abcdefghijklmnopqrstuvwxyz";
            //abc алфавит
            Console.WriteLine("Укажите длину сдвига");
            int len = Convert.ToInt32(Console.ReadLine());
            // len - число сдвигов в сторону
            int a;
            string code = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                int pos;
                char c = s[i];
                pos = abc.IndexOf(c);
                a = pos + len;
                code += abc[a];
            }
            Console.WriteLine(code);
            Console.ReadLine();
        }

        void Dec()
        {
            Console.WriteLine("Введите слово,которое нужно расшифровать:");
            s = Console.ReadLine();
            string abc = "abcdefghijklmnopqrstuvwxyz";
            //abc наш алфавит
            Console.WriteLine("Укажите длину сдвига");
            int len = Convert.ToInt32(Console.ReadLine());
            // len - число сдвигов в сторону
            int a;
            string code = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                int pos;
                char c = s[i];
                pos = abc.IndexOf(c);
                a = pos - len;
                code += abc[a];
            }
            Console.WriteLine(code);
            Console.ReadLine();
        }
    }
}
