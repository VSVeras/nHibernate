
namespace Dominio
{
    public class Telefone
    {
        public virtual int ID { get; set; }
        public virtual int CodigoDDD { get; set; }
        public virtual int Numero { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
