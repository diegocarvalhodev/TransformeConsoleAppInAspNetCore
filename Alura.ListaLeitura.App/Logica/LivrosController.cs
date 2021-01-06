using Alura.ListaLeitura.App.HTML;
using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Logica
{
    public class LivrosController
    {
        public string Detalhes(int id)
        {
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }

        private static string CarregaLista(IEnumerable<Livro> livros)
        {
            var conteudoDoArquivo = HtmlUtils.CarregaArquivoHtml("para-ler");

            foreach (var livro in livros)
            {
                conteudoDoArquivo = conteudoDoArquivo
                    .Replace("##NOVO-ITEM##", $"<li>{livro.Titulo} - {livro.Autor}</li>##NOVO-ITEM##");
            }

            return conteudoDoArquivo = conteudoDoArquivo.Replace("##NOVO-ITEM##", "");
        }

        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();
            //string conteudoDoArquivo = CarregaLista(_repo.ParaLer.Livros);
            var html = new ViewResult { ViewName = "lista" };
            return html;
        }

        public static Task Lendo(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.Lendo.ToString());
        }

        public static Task Lidos(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.Lendo.ToString());
        }

    }
}
