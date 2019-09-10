using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string start;
            string way = Environment.CurrentDirectory;
            double finish = 0;
            int index = 0;


            if (File.Exists(way + "\\input.txt") == false)
            {
                FileStream FileInput = File.Create(way + "\\input.txt");
                FileInput.Close();
            }

            FileStream fstream = File.OpenRead(way + "\\input.txt");
            StreamReader SR = new StreamReader(fstream);
            start = SR.ReadLine();
            SR.Close();
            fstream.Close();

            Console.WriteLine("Программа для перевода чисел (из двоичной в десятичную c 12-ой разрядностью) системы счисления." +
               "\n\nВаше число записаное в файле 'input.txt' - " + start);
            Console.ReadLine();

            for (int i = start.Length - 1; i >= 0; i--)
            {
                finish += Convert.ToInt32(Convert.ToString(start[index])) * Math.Pow(2, i);
                index++;
            }

            Console.WriteLine("Ваш результат сохраненный в файл 'output.txt' - " + finish + "\n");
            Console.ReadLine();

            if (File.Exists(way + "\\output.txt") == false)
            {
                FileStream FileOutput = File.Create(way + "\\output.txt");
                FileOutput.Close();
            }


            FileStream stream = new FileStream(way + "\\output.txt", FileMode.Create);
            StreamWriter SW = new StreamWriter(stream);
            SW.Write(finish);
            SW.Close();
            stream.Close();

        }
    }
}
