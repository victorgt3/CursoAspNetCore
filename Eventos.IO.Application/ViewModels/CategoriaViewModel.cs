using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Application.ViewModels
{
    public class CategoriaViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public SelectList Categorias()
        {
            return new SelectList(LitarCategorias(), "Id", "Nome");
        }
        public List<CategoriaViewModel> LitarCategorias()
        {
            var categoriasList = new List<CategoriaViewModel>()
            {
                new CategoriaViewModel() { Id = new Guid("b89eb8be-45b9-4b08-8a07-f1c495e1e673"), Nome = "Congresso" },
                new CategoriaViewModel() { Id = new Guid("8593168c-353e-4c4f-9c56-1a04a9db665b"), Nome = "Meetup" },
                new CategoriaViewModel() { Id = new Guid("f4ccf46e-7fe4-4b9d-a225-977efb391092"), Nome = "Workshop" }
            };

            return categoriasList;
        }
    }
}
