using Biblioteca.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Biblioteca.NH.Mappings
{
    public class RevistaMap : ClassMap<Revista>
    {
        public RevistaMap()
        {
            Id(x => x.ID);
            Map(x => x.Nome);
            Map(x => x.Numero);
            Map(x => x.DataPublicacao);
            Map(x => x.Genero);
            Map(x => x.PalavraChave);
            Map(x => x.Sinopse);
            Table("Revistas");
        }
    }
}
