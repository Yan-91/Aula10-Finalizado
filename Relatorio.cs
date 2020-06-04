using System;

namespace Aula_10
{
    public class Relatorio
    {
        public DateTime data { get; set; }

       public virtual void MostrarRelatorio(){
	   Console.WriteLine("Mostrando relatório geral");
       }
    }
}