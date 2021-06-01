using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment05_B_VictorBesson.DataTables
{
    public class _Request
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestID { get; set; }

        public int UserID { get; set; }
        public virtual _User _User { get; set; }

        public int RequestTypeID { get; set; }
        public virtual _RequestType _RequestType { get; set; }
        [Required]
        public string RequestDescription { get; set; }
        [Required]
        public DateTime RequestCreated { get; set; }

        public DateTime? RequestAccepted { get; set; }

        public DateTime? RequestCompleted { get; set; }

        [Required]
        public int PriorityID { get; set; }
        public virtual _Priority _Priority { get; set; }

        public int? StaffID { get; set; }
        public virtual _IT_Member _IT_Member { get; set; }

        public int RequestStatusID { get; set; }
        public virtual _RequestStatus _RequestStatus { get; set; }
    }
}
