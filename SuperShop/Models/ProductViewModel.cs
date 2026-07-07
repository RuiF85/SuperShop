using Microsoft.AspNetCore.Http;
using SuperShop.Data.Entitis;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SuperShop.Models
{
    public class ProductViewModel : Product    // herdar Produto
    {
        [Display(Name = "Image")]    // diplay para mudar o nome
        public IFormFile ImageFile { get; set; }  //para qualquer tipo de ficheiro pdf etc
    }
}
