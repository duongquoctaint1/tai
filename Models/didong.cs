using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace cuahangdidong.Models
{
    public class didong
    {

        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ChứVụ { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime NgàyPhátHành { get; set; }
        [Range(1, 100000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal GíaBán { get; set; }
        [RegularExpression(@"^[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string ThểLoại { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        public string SốLượng { get; set; }
      

    }
}