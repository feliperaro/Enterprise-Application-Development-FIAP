using System;
using Fiap.Aula01.Exemplo01.Models;

namespace Fiap.Aula01.Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um aluno e atribuir um nome
            Aluno aluno = new Aluno();

            aluno.Rm = 86373; // Set
            Console.WriteLine(aluno.Rm); // Get

            aluno.Nome = "Felipe";
            Console.WriteLine(aluno.Nome);

            // Ler o nome, preço e qtd do produto
            Console.WriteLine("Digite o nome do produto");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o preço");
            decimal preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade");
            int qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a marca");
            string marca = Console.ReadLine();

            // Instanciar um produto e atribuir os valores
            Produto produto = new Eletronico(nome, marca);

            produto.Nome = nome;
            produto.Preco = preco;
            produto.Quantidade = qtd;

            // Exibir os valores do produto
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Preço: {produto.Preco}");
            Console.WriteLine($"Quantidade: {produto.Quantidade}");

            // ler o juros 
            Console.WriteLine("Digite o juros");
            decimal juros = decimal.Parse(Console.ReadLine());

            // atualizar o preco
            produto.AtualizarPrecoComJuros(juros);

            // exibir o novo preço
            Console.WriteLine($"Novo Preço: {produto.Preco}");

            // Ler o cupom e exibir o valor do desconto
            Console.WriteLine("Digite seu cupom de desconto");
            string cupom = Console.ReadLine();

            decimal valorComDesconto = produto.CalcularDesconto(cupom);
            // exibir o novo preço
            Console.WriteLine($"Preço com Cupom de desconto: {valorComDesconto}");

            // Exibe produto
            Console.WriteLine(produto);
        }
    }
}
