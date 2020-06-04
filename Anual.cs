using System;

namespace Aula_10
{
    public class Anual : Relatorio
    {
    
       public override void MostrarRelatorio(){
           base.MostrarRelatorio();
           Console.WriteLine("Mostrando relatoório por ano");
              } 
   
      
    }
}