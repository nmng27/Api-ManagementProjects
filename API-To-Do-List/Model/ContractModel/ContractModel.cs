using API_To_Do_List.ViewModel.Contract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace API_To_Do_List.Model.ContractModel
{
    public class ContractModel
    {
        [Required]
        [Column(name:"contract_id")]
        private int id {get;set;}
        [Required]
        [Column("contract_name")]
        private string name {get;set;}
        [Required]
        [Column(name: "contract_type")]
        private string type { get;set;}
        [Required]
        [Column(name:"contract_description")]
        private string description {get;set;}
        [Required]
        [Column(name: "contract_objective")]
        private string objective;
        [Required]
        [Column(name:"customer_id")]
        [ForeignKey("customer_id")]
        private int customerId;

        public ContractModel() { }
        public ContractModel(int id, string name, string type, string description, string objective,int customer)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.description = description;
            this.objective = objective;
            this.customerId = customer;

        }

        public ContractModel(ContractViewModel view)
        {
            this.id =view.id;
            this.name =view.name;   
            this.type =view.type;
            this.description =view.description;
            this.objective =view.objective;
            this.customerId = view.customer_id;
        }
    }
}
