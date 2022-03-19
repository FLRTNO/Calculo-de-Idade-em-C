using System;
using static System.Console;

namespace calculo_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WriteLine("Que tal calcular a sua idade? Primeiro:");
            Pessoa usuario = new Pessoa(); //dei "vida" a classe pessoa com o new + nome da classe 
            WriteLine("Como devemos lhe chamar?");
            usuario.Nome = ReadLine();
            WriteLine("Agora, Nos diga agora o ano em que você nasceu :)");
            usuario.AnoNascimento = int.Parse(ReadLine());
            usuario.exibirDados();
        
        }
    }
}
