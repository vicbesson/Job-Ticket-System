using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment05_B_VictorBesson.DataTables
{
    public class _IT_Specialty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpecialtyID { get; set; }
        [MaxLength(25), MinLength(1)]
        [Required]
        public string Specialty { get; set; }

        public virtual ICollection<_RequestType> RequestTypes { get; set; }
        public virtual ICollection<_IT_Member> IT_Staff { get; set; }
    }
}
