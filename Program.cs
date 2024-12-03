using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }
    static double Soma (double primeiroValor, double segundoValor){
      return primeiroValor + segundoValor;
    }
    static double Subtracao (double primeiroValor, double segundoValor) {
      return primeiroValor - segundoValor;
    }
    static double Divisao (double primeiroValor, double segundoValor) {
      return primeiroValor / segundoValor;
    }
    static double Multiplicacao (double primeiroValor, double segundoValor) {
      return primeiroValor * segundoValor;
    }
    static void Menu() {
      Console.Clear();

      Console.WriteLine("CALCULADORA COM C#");
      
      Console.WriteLine("Digite o primeiro valor:");

      double primValor = double.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      double segValor = double.Parse(Console.ReadLine());

      Console.WriteLine("Agora escolha qual operação você deseja efetuar com esses valores: \n + (Somar) \n - (Subtrair) \n / (Dividir) \n * (Multiplicar) \n Digite o operador desejado: ");
      double resultado = 0;
      char opcao = char.Parse(Console.ReadLine());
      switch(opcao) {
        case '+':
          resultado = Soma(primValor, segValor); break;
        case '-' :
          resultado = Subtracao(primValor, segValor); break;
        case '/':
          resultado = Divisao(primValor, segValor); break;
        case '*':
          resultado = Multiplicacao(primValor, segValor); break;
        default:
          Console.WriteLine("Opção inválida"); return;

      }
      Console.WriteLine($"Resultado: {resultado}");
    }

      
  }
}