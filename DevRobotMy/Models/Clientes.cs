using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevRobotMy.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Clientes()
        {
        }

        public Clientes(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
