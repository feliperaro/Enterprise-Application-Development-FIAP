using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exemplo01.Models
{
    // Classe abstrata -> não pode ser instanciada e PODE ter métodos abstratos, sem implementação
    abstract class Produto
    {
        // Prpriedades (Getters e Setters)
        // prop -> tab tab (Cria uma propriedade)
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        // Métodos
        public void Vender()
        {
            Quantidade--;
        }

        //Sobrecarga do método Vender que recebe a qtd
        public void Vender(int qnt)
        {
            Quantidade -= qnt;
        }

        // palavra virtual, método pode ser modificado nas classes filhas
        public virtual decimal CalcularDesconto()
        {
            // Retornar o Preço com 5% de desconto
            return Preco * 0.95m;
        }

        // Sobrecarga do método CalcularDesconto
        public decimal CalcularDesconto(decimal porcentagem)
        {
            return Preco - Preco * porcentagem / 100;
        }

        public virtual decimal CalcularDesconto(string cupom)
        {
            if (cupom == "FIAP50")
            {
                return Preco * 0.5m;
            }

            return Preco;
        }

        // Método abstrato, sem implementação
        public abstract void AtualizarPrecoComJuros(decimal juros);

        public override string ToString()
        {
            return $"Nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}";
        }

        public Produto(string nome)
        {
            Nome = nome;
        }
    }
}
