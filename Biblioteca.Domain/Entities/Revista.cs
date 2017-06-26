using System;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Domain.Entities
{
    public class Revista
    {
        [Key]
        [Display(Name = "ID")]
        public virtual int ID { get; set; }

        [Display(Name = "Nome")]
        public virtual String Nome { get; set; }

        [Display(Name = "Número")]
        public virtual int Numero { get; set; }

        [Display(Name = "Publicação")]
        public virtual DateTime DataPublicacao { get; set; }

        [Display(Name = "Gênero")]
        public virtual String Genero { get; set; }

        [Display(Name = "Palavras Chave")]
        public virtual String PalavraChave { get; set; }

        [Display(Name = "Sinopse")]
        public virtual String Sinopse { get; set; }
    }
}
