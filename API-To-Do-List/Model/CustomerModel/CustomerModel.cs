using API_To_Do_List.ViewModel.Customer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_To_Do_List.Model.CustomerModel
{
    [Table("tb_customers")]
    public class CustomerModel
    {
        [Required]
        [Key]
        [Column(name:"customer_id")]
        public int id {  get; set; }
        [Required]
        [Column(name:"customer_name")]
        public string name {  get; set; }
        [Required]
        [Column(name: "enterprise_registration_doc")]
        public int doc {  get; set; }
        [Required]
        [Column(name: "opening_date")]
        public DateOnly data;
        [Required]
        [Column(name:"enterprise_sector")]
        public string sector {  get; set; }
        [Required]
        [Column(name:"enterprise_phone")]
        public int phone {  get; set; }
        [Required]
        [Column(name: "commercial_email_address")]
        public string commercialAddress {  get; set; }
        [Required]
        [Column(name: "is_active")]
        public bool active {  get; set; }

        public CustomerModel(int id, string name, int doc, DateOnly data, string sector, int phone, string commercialAddress, bool active)
        {
            this.id = id;
            this.name = name;
            this.doc = doc;
            this.data = data;
            this.sector = sector;
            this.phone = phone;
            this.commercialAddress = commercialAddress;
            this.active = active;
        }

        public CustomerModel(ustomerViewModel model)
        {
            this.id = model.id;
            this.name = model.name;
            this.doc = model.doc;
            this.data = model.dtae;
            this.sector= model.sector;
            this.phone = model.phone;
            this.commercialAddress = model.commercial_adrres;
            this.active = model.active;
        }
    }   
}
