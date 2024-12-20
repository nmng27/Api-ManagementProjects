using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using API_To_Do_List.Model.Project;
using API_To_Do_List.Model.Usuario;
namespace API_To_Do_List.Model.activities
{
    public class Activitie
    {
        [Key]
        private int _id;
        private string _activity_name;
        private string _objectives;
        private DateOnly _date_of_start;
        private bool _done;
        [ForeignKey("project_id")]
        private Project project;
        [ForeignKey("user_id")]
        private User user {  get; set; }

        public int getId() {  return _id; }
        public void setId(int id) { this._id = id; }


        public string getName(string name) {return _activity_name;}
        public void setName(string activity_name) { this._activity_name = activity_name;}

        public string getObjectives() {return _objectives;}
        public void setObjectives(string objectives) {this._objectives = objectives;}

        public DateOnly getDateOfStart() {return _date_of_start;}
        public DateOnly setDateOfStart(DateOnly date_of_start) {this._date_of_start = date_of_start;}

        public bool isDone() {return _done;}
        public void setDone(bool done) {this._done = done;}

    }
}
