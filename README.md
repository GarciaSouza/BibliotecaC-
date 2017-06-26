# Biblioteca

## Biblioteca.Domain
Projeto ClassLibrary em C# .Net 4.6 que contempla classes de Entidades e interfaces de  Reposit�rio para essas Entidades.
## Biblioteca.NH
Projeto ClassLibrary em C# .Net 4.6 que utiliza o Framework NHibernate e FluentNHibernate para mapear e construir Reposit�rio para as Entidades da camada Domain.
## Biblioteca.Web
Projeto ASP.NET MVC 5 em C# .Net 4.6 que utiliza o Framework SimpleInjector e as camadas Domain e NH, onde � apresentado um simples CRUD para as Entidades Livro e Revista.
## Biblioteca.WebCore
Projeto ASP.NET Core em C# .Net 4.6 que tamb�m se utiliza do Framework SimpleInjector e as camadas Domain e NH, o qual exp�e uma API RESTfull para as Entidades Livro e Revista.
## Configura��o necess�ria para funcionar o projeto:
* Configurar no arquivo hibernate.cfg.xml tanto no Projeto Biblioteca.Web quanto Biblioteca.WebCore o endere�o do banco MDF.
