using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTabuada.Models
{
    public class Operacoes
    {
        public double numeroTabuada { get; set; }


        public void adicao()
        {
            for (int contador = 1; contador < 11; contador++)
            {
                Console.WriteLine($"{numeroTabuada} + {contador} = {numeroTabuada + contador}");
            }

            Console.WriteLine("digite qualquer tecla para voltar!");
            Console.ReadLine();
        }

        public void subtracao()
        {
            for (int contador = 1; contador < 11; contador++)
            {
                Console.WriteLine($"{numeroTabuada} - {contador} = {numeroTabuada - contador}");
            }

            Console.WriteLine("digite qualquer tecla para voltar!");
            Console.ReadLine();
        }

        public void multiplicacao()
        {
            for (int contador = 1; contador < 11; contador++)
            {
                Console.WriteLine($"{numeroTabuada} * {contador} = {numeroTabuada * contador}");
            }

            Console.WriteLine("digite qualquer tecla para voltar!");
            Console.ReadLine();
        }

        public void divisao()
        {
            for (int contador = 1; contador < 11; contador++)
            {
                Console.WriteLine($"{numeroTabuada} / {contador} = {numeroTabuada / contador}");
            }

            Console.WriteLine("digite qualquer tecla para voltar!");
            Console.ReadLine();
        }



        
    }
}