using System;
using System.Collections.Generic;

namespace ProjectDDD.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public DateTime Inclusao { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && (DateTime.Now.Year - cliente.Inclusao.Year >= 5);
        }
    }
}
