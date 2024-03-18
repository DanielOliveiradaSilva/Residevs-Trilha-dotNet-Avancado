using System.Security.Cryptography.X509Certificates;

namespace AulaDotentModuloAvancado
{
    public class Lampada
    {  
        string Ligada;
         public Lampada(){
            Ligada ="ligada";
        }
        public void Desligado(){
            Ligada = "desligada";
        }
        public void Ligado(){
            Ligada = "ligada";
        }

        public void imprimir(){
            if (Ligada == "ligada"){
                Console.WriteLine("Lâmpada ligada!");
            }
            else{
                Console.WriteLine("Lâmpada desligada!");
            }
        }
    }
}