using API_To_Do_List.ViewModel.Project;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_To_Do_List.Model.ProjectModel
{
    [Table(name:"TB_PROJECTS")]
    public class ProjectModel
    {
        [Required]
        [Column(name:"project_id")]
        private int id {  get; set; }
        [Required]
        [Column(name:"project_name")]
        private string name { get; set; }
        [Required]
        [Column(name:"project_type")]
        private string type { get; set; }
        [Required]
        [Column(name:"project_description")]
        private string description { get; set; }
        [Required]
        [Column(name:"project_is_suport")]
        private bool support { get; set; }
        [Required]
        [Column(name:"project_garanted")]
        private bool garanted { get; set; }
        [Required]
        [Column("contract_id")]
        [ForeignKey("contract_id")]
        private int contract_id { get; set; }

        public ProjectModel() { }
        public ProjectModel(int id, string name, string type, string description, bool support, bool garanted, int contract_id)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.description = description;
            this.support = support;
            this.garanted = garanted;
            this.contract_id = contract_id;
        }

        public ProjectModel(ProjectViewModel model)
        {
            this.id = model.id;
            this.name = model.name;
            this.type = model.type;
            this.description = model.description;
            this.support = model.support;
            this.garanted = model.guaranted;
            this.contract_id = model.foreignkey;
        }
    }
}
