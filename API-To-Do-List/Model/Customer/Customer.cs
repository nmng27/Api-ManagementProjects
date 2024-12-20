using System.ComponentModel.DataAnnotations;

namespace API_To_Do_List.Model.Cliente
{
    public class Customer
    {
        [Key]
        private int _id { get; set; };
        private int _enterprise_registration { get; set; };
        private string _name { get; set; };
        private string _commercial_address { get; set; };
        private DateOnly _opening_date { get; set; };
        private string _sector { get; set; };
        private bool _is_open { get; set; };

        public Customer() { }
        public Customer(int id, int enterprise_registration, string name, string commercial_address, DateOnly opening_date, string sector, bool is_open)
        {
            _id = id;
            _enterprise_registration = enterprise_registration;
            _name = name;
            _commercial_address = commercial_address;
            _opening_date = opening_date;
            _sector = sector;
            _is_open = is_open;
        }


        


    }
}
