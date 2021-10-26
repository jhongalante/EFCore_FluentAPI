using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_FluentAPI.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal Preco { get; set; }
        public bool Estoque { get; set; }
    }
}
