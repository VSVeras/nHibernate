using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Departamento
    {
        public virtual int ID { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual IEnumerable<Pessoa> Pessoas { get; set; }

        public Departamento()
        {
            this.Pessoas = new List<Pessoa>();
        }
    }
}
