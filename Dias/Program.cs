using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento(dd/mm/yyyy)");
            string input = Console.ReadLine();
            DateTime dataNascimento;
            if (DateTime.TryParseExact(input, "dd/MM/yyyy", null,
                System.Globalization.DateTimeStyles.None, out dataNascimento))
            {

                DateTime dataAtual = DateTime.Now;
                TimeSpan diferenca = dataAtual - dataNascimento;
                int diasVivos = (int)diferenca.TotalDays;

                Console.WriteLine($"Você está vivo há {diasVivos} dias.");
            }
            else
            {
                Console.WriteLine("Data de nascimento inválida. Por favor," +
                    " use o formato dd/mm/yyyy.");
            }
        }
    }
}