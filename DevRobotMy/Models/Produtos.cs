using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevRobotMy.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Peso { get; set; }
        public string Cor { get; set; }

        public Produtos()
        {
        }

        public Produtos(int id, string nome, string peso, string cor)
        {
            Id = id;
            Nome = nome;
            Peso = peso;
            Cor = cor;
        }
    }
}
