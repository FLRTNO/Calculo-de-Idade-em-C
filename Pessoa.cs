using System;
using static System.Console;

namespace calculo_idade
{
    public class Pessoa
    {
        private int anoNascimento;
        public int AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }
        
        private String nome;
        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        
        public void exibirDados()
        {
           //pega o valor da PROPRIEDADE e não da variavel que ela representa!
            WriteLine($"Nome:{this.Nome}");
            WriteLine($"Ano de Nascimento {this.AnoNascimento}");
            /*Por ser uma função privada o calcularIdade() só podera ser usado pelo proprio objeto (idade)
            aqui \/ o objeto retornará o valor da função*/
            int idade = this.calcularIdade();
            WriteLine($"Sua idade é: {idade} ");

        }

        private int calcularIdade()
        {
            // datetime now -> pega a data atual do sistema
            DateTime data = DateTime.Now;
            int ano = data.Year; 
            //a propriedade Year devolve a idade atual 
            int idade = ano - this.AnoNascimento;
            //retorna o valor da função calcularIdade() para quem efetuar a chamada 
            return idade; 
            
        } 
    }
}