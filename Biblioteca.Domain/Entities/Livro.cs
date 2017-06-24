using System;

namespace Biblioteca.Domain.Entities
{
    public class Livro
    {
        public virtual int ID { get; set; }

        public virtual String ISBN { get; set; }

        public virtual String Titulo { get; set; }

        public virtual String Autor { get; set; }

        public virtual DateTime DataPublicacao { get; set; }

        public virtual String Versao { get; set; }

        public virtual String Genero { get; set; }

        public virtual String PalavraChave { get; set; }

        public virtual String Sinopse { get; set; }
    }
}
