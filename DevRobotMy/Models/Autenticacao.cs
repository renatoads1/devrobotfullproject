using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevRobotMy.Models
{
    public class Autenticacao
    {
        public int Id { get; set; }
        public string  user { get; set; }
        public string  senha { get; set; }
        public string NomeEmpresa { get; set; }

        public Autenticacao()
        {
        }

        public Autenticacao(int id, string user, string senha, string nomeEmpresa)
        {
            Id = id;
            this.user = user;
            this.senha = senha;
            NomeEmpresa = nomeEmpresa;
        }
    }
}
