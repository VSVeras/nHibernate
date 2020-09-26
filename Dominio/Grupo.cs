using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Grupo
    {
        public virtual int ID { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual IEnumerable<Pessoa> Pessoas { get; set; }

        public Grupo()
        {
            this.Pessoas = new List<Pessoa>();
        }
    }
}
