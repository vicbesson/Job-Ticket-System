using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment05_B_VictorBesson.DataTables
{
    public class _IT_Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffID { get; set; }

        [MaxLength(50), MinLength(1)]
        [Index(IsUnique = true)]
        [Required]
        public string UserName { get; set; }

        [MaxLength(50), MinLength(1)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50), MinLength(1)]
        [Required]
        public string LastName { get; set; }

        public int SpecialtyID { get; set; }
        public virtual _IT_Specialty _IT_Specialty { get; set; }

        [Required]
        public bool Admin { get; set; }

        [MaxLength(35), MinLength(1)]
        [Required]
        public string Country { get; set; }

        [MaxLength(35), MinLength(1)]
        [Required]
        public string City { get; set; }

        [MaxLength(62), MinLength(1)]
        [Required]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime HiredDate { get; set; }

        public virtual ICollection<_Request> Requests { get; set; }
    }
}
