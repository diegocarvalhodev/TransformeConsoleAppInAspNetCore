using System.Collections.Generic;
using Alura.ListaLeitura.App.Negocio;

namespace Alura.ListaLeitura.App.Repositorio
{
    public class LivroRepositorioFake : ILivroRepositorio
    {
        private Negocio.ListaLeitura _paraLer;
        private Negocio.ListaLeitura _lendo;
        private Negocio.ListaLeitura _lidos;

        public LivroRepositorioFake()
        {
            var l1 = new Livro { Titulo = "O Iluminado", Autor = "Stephen King" };
            var l2 = new Livro { Titulo = "It, a coisa", Autor = "Stephen King" };
            var l3 = new Livro { Titulo = "Carrie, a estranha", Autor = "Stephen King" };
            var l4 = new Livro { Titulo = "Sob a Redoma", Autor = "Stephen King" };
            var l5 = new Livro { Titulo = "Cemiterio Maldito", Autor = "Stephen King" };
            var l6 = new Livro { Titulo = "A Escolha dos Tres - Torre Negra 2", Autor = "Stephen King" };
            var l7 = new Livro { Titulo = "O Pistoleiro - Torre Negra 1", Autor = "Stephen King" };
            var l8 = new Livro { Titulo = "Terras Devastadas - Torre Negra 3", Autor = "Stephen King" };
            var l9 = new Livro { Titulo = "O Mago e o Vidro - Torre Negra 4", Autor = "Stephen King" };
            var l10 = new Livro { Titulo = "Lobos de Calla - Torre Negra 5", Autor = "Stephen King" };
            var l11 = new Livro { Titulo = "A Danca da Morte", Autor = "Stephen King" };
            var l12 = new Livro { Titulo = "Sombras da Noite", Autor = "Stephen King" };

            this._paraLer = new Negocio.ListaLeitura("Para Ler", l1, l4, l5, l12);
            this._lendo = new Negocio.ListaLeitura("Lendo", l3, l11);
            this._lidos = new Negocio.ListaLeitura("Lidos", l2, l6, l7, l9, l8, l10);
        }

        public Negocio.ListaLeitura ParaLer => _paraLer;
        public Negocio.ListaLeitura Lendo => _lendo;
        public Negocio.ListaLeitura Lidos => _lidos;

        public IEnumerable<Livro> Todos => throw new System.NotImplementedException();

        public void Incluir(Livro livro)
        {
            throw new System.NotImplementedException();
        }
    }
}
