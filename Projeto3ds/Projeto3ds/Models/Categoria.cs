using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto3ds.Models
{

    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Nome da Categoria")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Tamanho Inválido")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = "Acrescente uma descrição")]
        [MaxLength(350), MinLength(15)]
        public string Descricao { get; set; }

        //Criando um lista para os tipos de lanche 
        // PROPRIEDADE DE NAVEGAÇÃO 
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public List <Lanche> Lanche { get; set; } 

    }
}

// FK  = não precisa colocar - deu erro 
// 