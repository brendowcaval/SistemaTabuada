// Autor : Brendow Cavalcante
// Data : 23/12/2022
using SistemaTabuada.Models;



Operacoes op = new Operacoes();
bool sistema = true;


while(sistema == true)
{
    Console.Clear();
    Console.WriteLine("        -  CONSULTE A TABUADA  -  \n");
    Console.WriteLine("Escolha o tipo de operação: ");
    Console.WriteLine("1-Adição");
    Console.WriteLine("2-Subtração");
    Console.WriteLine("3-Multiplicação");
    Console.WriteLine("4-Divisão");
    Console.WriteLine("5-Encerrar Sistema");

    int respostaUsuario = Convert.ToInt32(Console.ReadLine());

    switch(respostaUsuario)
    {
       case 1:
            Console.Clear();
            Console.WriteLine("Digite o numero que deseja consultar na tabuada:  ");
            double valorDesejado = Convert.ToDouble(Console.ReadLine());
            op.numeroTabuada = valorDesejado;
            op.adicao();
            Console.Clear();
            break;
       case 2:
            Console.Clear();
            Console.WriteLine("Digite o numero que deseja consultar na tabuada:  ");
            double valorDesejado2 = Convert.ToDouble(Console.ReadLine());
            op.numeroTabuada = valorDesejado2;
            op.subtracao();
            Console.Clear();
            break;
       case 3:
            Console.Clear();
            Console.WriteLine("Digite o numero que deseja consultar na tabuada:  ");
            double valorDesejado3 = Convert.ToDouble(Console.ReadLine());
            op.numeroTabuada = valorDesejado3;
            op.multiplicacao();
            Console.Clear();
            break;
       case 4:
            Console.Clear();
            Console.WriteLine("Digite o numero que deseja consultar na tabuada:  ");
            double valorDesejado4 = Convert.ToDouble(Console.ReadLine());
            op.numeroTabuada = valorDesejado4;
            op.divisao();
            Console.Clear();
            break;
       case 5:
            Console.Clear();
            Console.WriteLine("Sistema Encerrado!");
            sistema = false;
            break;


    }


}