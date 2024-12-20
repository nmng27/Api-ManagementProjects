using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_To_Do_List.Model.EmployeerModel
{
    public class EmployeerModel
    {
        [Required]
        [Key]
        [Column(name:"employeer_id")]    
        private int id {  get; set; }
        [Required]
        [Column(name:"employeer_name")]
        private string name { get; set; }
        [Required]
        [Column(name: "employeer_email")]
        private string email { get; set; }
        [Required]
        [Column(name: "employeer_address")]
        private string address { get; set; }
        [Required]
        [Column(name: "employeer_phone")]
        private string phone {  get; set; }
        [Required]
        [Column(name: "employeer_job")]
        private string job { get; set; }
        [Required]
        [Column(name: "employeer_department")]
        private string department { get; set; }
        [Required]
        [Column(name: "employeer_date_of_birth")]
        private DateOnly date_of_birth { get; set; }
        [Required]
        [Column(name: "employeer_is_active")]
        private bool is_active { get; set; }

    }
}
