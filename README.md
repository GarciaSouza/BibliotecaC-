# Biblioteca

## Biblioteca.Domain
Projeto ClassLibrary em C# .Net 4.6 que contempla classes de Entidades e interfaces de  Repositório para essas Entidades.
## Biblioteca.NH
Projeto ClassLibrary em C# .Net 4.6 que utiliza o Framework NHibernate e FluentNHibernate para mapear e construir Repositório para as Entidades da camada Domain.
## Biblioteca.Web
Projeto ASP.NET MVC 5 em C# .Net 4.6 que utiliza o Framework SimpleInjector e as camadas Domain e NH, onde é apresentado um simples CRUD para as Entidades Livro e Revista.
## Biblioteca.WebCore
Projeto ASP.NET Core em C# .Net 4.6 que também se utiliza do Framework SimpleInjector e as camadas Domain e NH, o qual expõe uma API RESTfull para as Entidades Livro e Revista.
## Configuração necessária para funcionar o projeto:
* Configurar no arquivo hibernate.cfg.xml tanto no Projeto Biblioteca.Web quanto Biblioteca.WebCore o endereço do banco MDF.
