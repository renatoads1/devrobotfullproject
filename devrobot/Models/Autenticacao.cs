using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace devrobot.Models
{
    public class Autenticacao
    {
        [Key]
        public int Id { get; set; }
        public string  User { get; set; }
        public string Senha { get; set; }
    }
}
