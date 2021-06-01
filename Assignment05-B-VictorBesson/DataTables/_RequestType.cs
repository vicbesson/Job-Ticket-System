using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment05_B_VictorBesson.DataTables
{
    public class _RequestType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestTypeID { get; set; }
        [MaxLength(25), MinLength(1)]
        [Required]
        public string RequestType { get; set; }

        public int SpecialtyID { get; set; }
        public virtual _IT_Specialty _IT_Specialty { get; set; }

        public virtual ICollection<_Request> Requests { get; set; }
    }
}
