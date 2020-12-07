using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC_01.Models
{
    public class Categoria
    {
        public int Id{get;set;}
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="O campo é obrigatório!")]
        public string descricao { get; set; }
        //public List<Produto> Produtos { get; set; }
    }

}
