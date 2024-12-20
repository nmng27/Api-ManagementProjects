using Microsoft.EntityFrameworkCore;
namespace API_To_Do_List.ViewModel.Contract
{
    public class ContractViewModel
    {
        public int id;
        public string name;
        public string type;
        public string description;
        public string objective;
        public int customer_id;
    }
}
