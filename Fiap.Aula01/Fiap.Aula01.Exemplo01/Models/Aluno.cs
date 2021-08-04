using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.Exemplo01.Models
{
    class Aluno
    {
        // Atributos (Fields)
        private string _nome;
        private int _rm;

        // Getters e Setters (Propriedades)
        public string Turma { get; set; }

        public int Rm
        {
            get { return _rm; }
            set { _rm = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

    }
}
