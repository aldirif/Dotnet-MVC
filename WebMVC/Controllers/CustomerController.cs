using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class CustomerController : Controller
    {
        private static List<CustomerViewModel> _customerViewModels = new List<CustomerViewModel>()
        {
            new CustomerViewModel(1, "Aldi Rifaldi", "aldi@gmail.com", "Manchester", "United Kingdom"),
            new CustomerViewModel(2, "Cristiano Ronaldo", "ronaldo@gmail.com", "Manchester", "United Kingdom"),
            new CustomerViewModel(3, "Neymar Jr", "neymar@gmail.com", "Manchester", "United Kingdom"),
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Id, StudentName, Email, City, Country")] CustomerViewModel customer)
        {
            _customerViewModels.Add(customer);
            return Redirect("List");
        }

        public IActionResult List()
        {
            return View(_customerViewModels);
        }

        public IActionResult Edit(int? id)
        {
            CustomerViewModel student = _customerViewModels.Find(x => x.Id.Equals(id));
            return View(student);
        }

        public IActionResult Update(int id, [Bind("Id, StudentName, Email, City, Country")] CustomerViewModel customer)
        {
            //hhapus data lama
            CustomerViewModel customerOld = _customerViewModels.Find(x => x.Id.Equals(id));
            _customerViewModels.Remove(customerOld);

            _customerViewModels.Add(customer);
            return Redirect("List");
        }

        public IActionResult Details(int id) 
        {
            CustomerViewModel customer = (
                from p in _customerViewModels
                where p.Id == id
                select p).SingleOrDefault(new CustomerViewModel()); 
            return View(customer);        
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            CustomerViewModel customer = _customerViewModels.Find(x => x.Id.Equals(id));
            _customerViewModels.Remove(customer);

            return Redirect("List");
        }

    }
}
