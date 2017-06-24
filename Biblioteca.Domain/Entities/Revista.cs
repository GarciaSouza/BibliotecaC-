using System;

namespace Biblioteca.Domain.Entities
{
    public class Revista
    {
        public virtual int ID { get; set; }

        public virtual String Nome { get; set; }

        public virtual uint Numero { get; set; }
        
        public virtual DateTime DataPublicacao { get; set; }

        public virtual String Genero { get; set; }

        public virtual String PalavraChave { get; set; }

        public virtual String Sinopse { get; set; }
    }
}
