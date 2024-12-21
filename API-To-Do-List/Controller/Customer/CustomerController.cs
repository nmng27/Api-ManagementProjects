using API_To_Do_List.Database;
using Microsoft.AspNetCore.Mvc;
using API_To_Do_List.ViewModel.Customer;
using API_To_Do_List.Model.CustomerModel;
using Microsoft.EntityFrameworkCore;
namespace API_To_Do_List.Controller.Customer
{
    [ApiController]
    [Route("/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomerController(AppDbContext context)
        {
            _context = context;
        }

        // Create customer
        [HttpPost("/create")]
        public async Task<IActionResult> Create([FromBody] ustomerViewModel model)
        {
            try
            {
                
                if(model != null)
                {
                    CustomerModel new_customer = new CustomerModel(model);
                    _context.Add(new_customer);
                    await _context.SaveChangesAsync();
                    return (Ok());
;
                }
                else
                {
                    return BadRequest();
                }
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        // Deletinh an user
        [HttpDelete]
        [Route("deleting/{id}")]
       public async Task<IActionResult> Deleting(int id)
        {
            try
            {
                CustomerModel aux = _context.Customer.Where(x => x.id == id).FirstOrDefault();
                if (aux != null) {
                    _context.Customer.Remove(aux);
                    await _context.SaveChangesAsync();
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            } catch(Exception ex)
            {
                return BadRequest();
            }
        }

        // Getting By Id 
        [HttpGet]
        [Route("/searching/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                CustomerModel aux = _context.Customer.Where(X => X.id == id).FirstOrDefault();
                if (aux != null) {
                    return (Ok());
                }
                else
                {
                    return NotFound();
                }
            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/listing")]
        public async Task<IActionResult> listing()
        {
            try
            {
                List<CustomerModel> lista = _context.Customer.ToList();
                return Ok();
            } catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch]
        [Route("/updating/{id}")]
        public async Task<IActionResult> Updating(int id, [FromBody] CustomerModel model)
        {
            try
            {
                var searching_customer = _context.Customer.Where(X => X.id.Equals(id)).FirstOrDefault();
                searching_customer.name = model.name;
                searching_customer.doc = model.doc;
                searching_customer.doc = model.doc;
                searching_customer.data = model.data;
                searching_customer.phone = model.phone;
                searching_customer.commercialAddress = model.commercialAddress;
                searching_customer.active = model.active;
                searching_customer.sector = model.sector;

                _context.Customer.Update(searching_customer);
                await _context.SaveChangesAsync();
                return Ok();
            } catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            

        }



    }
}
