using Alura.ListaLeitura.App.Negocio;
using System.Collections.Generic;

namespace Alura.ListaLeitura.App.Repositorio
{
    interface ILivroRepositorio
    {
        Negocio.ListaLeitura ParaLer { get; }
        Negocio.ListaLeitura Lendo { get; }
        Negocio.ListaLeitura Lidos { get; }
        IEnumerable<Livro> Todos { get; }
        void Incluir(Livro livro);
    }
}
