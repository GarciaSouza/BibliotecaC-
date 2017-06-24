using Biblioteca.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Biblioteca.NH.Mappings
{
    public class LivroMap : ClassMap<Livro>
    {
        public LivroMap()
        {
            Id(x => x.ID);
            Map(x => x.ISBN);
            Map(x => x.Titulo);
            Map(x => x.Autor);
            Map(x => x.DataPublicacao);
            Map(x => x.Versao);
            Map(x => x.Genero);
            Map(x => x.PalavraChave);
            Map(x => x.Sinopse);
            Table("Livros");
        }
    }
}
