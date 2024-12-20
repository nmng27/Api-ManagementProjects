using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API_To_Do_List.Model.Contrato;
namespace API_To_Do_List.Model.Project
{
    public class Project
    {
        [Key]
        private int _id;
        private string _project_name { get; set; }
        private DateOnly _date_kickoff { get; set; }
        private string _description {  get; set; }
        private int _project_duration_month {  get; set; }
        private bool _support {  get; set; }
        private bool _is_guarantee {  get; set; }
        private bool _is_finished {  get; set; }
        [ForeignKey("contract_id")]
        private Contract contract { get; set; }


    }
}
