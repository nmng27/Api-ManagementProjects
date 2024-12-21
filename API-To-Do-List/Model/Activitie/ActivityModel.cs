using API_To_Do_List.ViewModel.Activity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_To_Do_List.Model.Activitie
{
    public class ActivityModel
    {
        [Required]
        [Column("activity_id")]
        [Key]

        private int id {  get; set; }
        [Required]
        [Column(name:"activity_name")]
        private string name {  get; set; }
        [Required]
        [Column(name: "activity_description")]
        private string desc {  get; set; }
        [Required]
        [Column(name:"activity_date_start")]
        private DateOnly dateStart { get; set; }

        [Required]
        [Column(name: "activity_date_end")]
        private DateOnly dateFinish { get; set; }
        [Required]
        [Column(name:"activity_satisfation")]
        private string satisfation { get; set; }
        [Required]
        [Column("project_id")]
        [ForeignKey("project_id")]
        private int projectid {  set; get; }
        [ForeignKey("employeer_id")]
        private int employeer_id;

        public ActivityModel() { }
        public ActivityModel(int id, string name, string desc, DateOnly dateStart, DateOnly dateFinish, string satisfation, int projectidd, int employeer_id)        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.dateStart = dateStart;
            this.dateFinish = dateFinish;
            this.satisfation = satisfation;
            this.projectid = projectid;
            this.employeer_id = employeer_id;
        }   


        public ActivityModel(ActivityViewModel model)
        {
            this.id = model.id;
            this.name = model.name;
            this.desc = model.desc;
            this.dateStart = model.date_start;
            this.dateFinish = model.date_end;
            this.satisfation = model.satisfation;
            this.projectid = model.projectId;
        }
    }
}
