using System;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Domain.Entities
{
    public class Livro
    {
        [Key]
        [Display(Name = "ID")]
        public virtual int ID { get; set; }

        [Display(Name = "ISBN")]
        public virtual String ISBN { get; set; }

        [Display(Name = "Título")]
        public virtual String Titulo { get; set; }

        [Display(Name = "Autor")]
        public virtual String Autor { get; set; }

        [Display(Name = "Publicação")]
        public virtual DateTime DataPublicacao { get; set; }

        [Display(Name = "Versão")]
        public virtual String Versao { get; set; }

        [Display(Name = "Gênero")]
        public virtual String Genero { get; set; }

        [Display(Name = "Palavras Chave")]
        public virtual String PalavraChave { get; set; }

        [Display(Name = "Sinopse")]
        public virtual String Sinopse { get; set; }
    }
}
