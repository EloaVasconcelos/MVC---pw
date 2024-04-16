using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Reflection;

namespace Projeto3ds.Models
{
    [Table("Lanche")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        // Virtual pois pertence a outra classe 

       // [ForeingKey] // Não precisa declarar 
        public virtual Categoria CategoriaId { get; set; }


        [MaxLength(200), MinLength(20)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string DescrCurta { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(350), MinLength(15)]
        public string DescrDetalhada { get; set; }



        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display (Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "Tamanho Inválido")]
        public string Nome { get; set; } // 



        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string LanchePreferido { get; set; }


        // Virtual pois pertence a outra classe 
        // PROPRIEDADE DE NAVEGAÇÃO 

        public virtual Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Acrescente uma imagem")]
        public string ImgMini { get; set; }

        [Required(ErrorMessage = "Acrescente uma imagem")]
        public string ImgUrl { get; set; }

        [Range(1,999.99)] //formato americano com o ponto para separar as casas
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public decimal Preco { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        public bool EmEstoque { get; set; }


    }

}
