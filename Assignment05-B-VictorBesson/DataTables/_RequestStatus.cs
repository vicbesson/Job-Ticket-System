using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment05_B_VictorBesson.DataTables
{
    public class _RequestStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestStatusID { get; set; }
        [MaxLength(20), MinLength(1)]
        [Required]
        public string RequestStatus { get; set; }

        public virtual ICollection<_Request> Requests { get; set; }
    }
}
