using System;
using System.Collections.Generic;

namespace Dominio
{

    public abstract class Pessoa
    {
        public virtual int ID { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Endereco { get; set; }
        public virtual string Cep { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual Status Status { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual IEnumerable<Grupo> Grupos { get; set; }
        public virtual IEnumerable<Telefone> Telefones { get; set; }

        public Pessoa()
        {
            this.Grupos = new List<Grupo>();
            this.Telefones = new List<Telefone>();
        }

        public virtual void AdicionarTelefone(Telefone telefone)
        {
            ((IList<Telefone>)this.Telefones).Add(telefone);
        }

        public virtual void AdicionarGrupo(Grupo grupo)
        {
            ((IList<Grupo>)this.Grupos).Add(grupo);
        }
    }
}
