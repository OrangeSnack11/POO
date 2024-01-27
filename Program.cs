using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caneta c1 = new Caneta();
            c1.modelo = "Bic";
            c1.cor = "Verde";

            c1.Escrever();

        }

        public class Caneta
        {
            public string modelo = "";
            public string cor = "";
            private float ponta = 0.5f;
            protected int carga = 50;
            protected bool tampada = false;

            public void Escrever()
            {
                if (tampada == false)
                {
                Console.WriteLine("estou escrvendo...");
                Console.WriteLine("continuo escrevendo...");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("A caneta está tampada");
                    Console.Read();
                }
            }

            public void Rabiscar()
            {
                if (tampada == false)
                {
                    Console.WriteLine("estou rabiscando...");
                    Console.WriteLine("continuo rabiscando");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("a caneta está tampada.");
                    Console.Read();
                }

            }

            public void Tampar()
            {
                tampada = true;
            }

            private void destampar()
            {
                tampada = false;
            }
        }
    }
}
