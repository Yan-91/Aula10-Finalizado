using System;

namespace Aula_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensal mes = new Mensal();
            mes.MostrarRelatorio();
            System.Console.WriteLine("Digite a data do relatório Mensal:");  
            mes.data = DateTime.Parse(Console.ReadLine());

            Anual ano = new Anual();
            ano.MostrarRelatorio();

            System.Console.WriteLine("Digite a data do relatório Anual:");
            ano.data = DateTime.Parse(Console.ReadLine());
        }
    }
}
