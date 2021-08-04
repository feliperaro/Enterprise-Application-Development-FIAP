using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exemplo01.Models
{
    class Eletronico : Produto
    {
        // Propriedades
        public string Marca { get; set; }
        public bool Garantia { get; set; }
        public double ConsumoEnergia { get; set; }

        public Eletronico(string nome, string marca) : base(nome)
        {
            Marca = marca;
        }

        // Métodos 
        // Sobrescrever (override) -> mesmo método do pai implementado na classe filha
        // Modificar/Adicionar um comportamento (implementação)
        public override decimal CalcularDesconto()
        {
            // Modificar o comportamento do método pai, realizando um desconto de 7%
            return Preco * 0.93m;
        }

        public override decimal CalcularDesconto(string cupom)
        {
            if (cupom == "FIAP30")
            {
                return Preco * 0.7m; // 30% de desconto
            }

            return base.CalcularDesconto(cupom); // chamando o método CalcularDesconto (cupom) do Produto
        }

        public override void AtualizarPrecoComJuros(decimal juros)
        {
            Preco += Preco * juros / 100;
        }

        public override string ToString()
        {
            return base.ToString() + $", Marca: {Marca}, Garantia: {Garantia}, ConsumoEnergia: {ConsumoEnergia}"; ;
        }
    }
}
