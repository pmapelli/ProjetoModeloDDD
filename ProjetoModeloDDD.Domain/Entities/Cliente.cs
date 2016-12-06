
using System;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string email { get; set; }
        public DateTime DataCadstro { get; set; }
        public bool Ativo { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadstro.Year >= 5;
        }

    }
}
