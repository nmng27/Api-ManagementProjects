using API_To_Do_List.Model.Cliente;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_To_Do_List.Model.Contrato
{
    public class Contract
    {
        [Key]
        private int _id { get; set; }
        private string _contract_name { get; set; }
        private DateOnly _date_hiring { get; set; }
        private string _contract_type { get;set }
        private bool _active { get; set; }
        [ForeignKey("customer_id")]
        private Customer customer { get; set; }

        public Contract(int id, string contract_name, DateOnly date_hiring, string contract_type, bool active)
        {
            _id = id;
            _contract_name = contract_name;
            _date_hiring = date_hiring;
            _contract_type = contract_type;
            _active = active;
        }

        public Contract() { }

    }
}
