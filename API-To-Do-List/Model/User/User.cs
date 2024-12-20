namespace API_To_Do_List.Model.Usuario
{
    public class User
    {
        private int _id;
        private string _name;
        private string _email;
        private DateOnly _date_of_birth;
        private string _job;
        private string _department;
        private string _password;
        private bool _active;

        public User() { }

        public User(int id, string name, string email, DateOnly date_of_birth, string job, string department, string password, bool active)
        {
            this._id = id;
            this._name = name;
            this._email = email;
            this._date_of_birth = date_of_birth;
            this._job = job;
            this._department = department;
            this._password = password;
            this._active = active;
        }

        // Getters and setters

        //usuario

        public int getId() { return _id; }
        public void setId(int id) {  this._id = id; }
       

        //name

        public string getName() { return _name; }
        public void setName(string name) { this._name = name; }

        // email
        public string getEmail(string email) { return _email; }
        public void setEmail(string email) { this._email = email; }

        
        // date_of_birth
        public DateOnly getDate_of_birth() { return _date_of_birth; }
        public void setDate_of_birth(DateOnly date_of_birth) { this._date_of_birth= date_of_birth; }

        // job
        public string getJob() { return _job; }
        public void setJob(string job) {  this._job = job; }

        // department
        public string getDepartment() { return _department; }
        public void setDepartment(string department) {  this._department = department; }

        // password
        public string getPassword() { return _password; }
        public string setPassword(string password) { this._password = password; }
        

        // active
        public bool isActive() { return _active; }
        public void setActive(bool active) { this._active = active; }
    }
}
