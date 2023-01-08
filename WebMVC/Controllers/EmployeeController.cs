using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class EmployeeController : Controller
    {
        private static List<EmployeeViewModel> _employeeViewModels = new List<EmployeeViewModel>()
        {
            new EmployeeViewModel(1, "Aldi Rifaldi", "aldi@gmail.com", "Developer", 2),
            new EmployeeViewModel(2, "Cristiano Ronaldo", "ronaldo@gmail.com", "Developer", 4),
            new EmployeeViewModel(3, "Neymar Jr", "neymar@gmail.com", "Developer", 5),
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
        public IActionResult Save([Bind("Id, EmployeeName, Email, Position, Experience")] EmployeeViewModel employee)
        {
            _employeeViewModels.Add(employee);
            return Redirect("List");
        }

        public IActionResult List()
        {
            return View(_employeeViewModels);
        }

        public IActionResult Edit(int? id)
        {
            EmployeeViewModel employee = _employeeViewModels.Find(x => x.Id.Equals(id));
            return View(employee);
        }

        public IActionResult Update(int id, [Bind("Id, EmployeeName, Email, Position, Experience")] EmployeeViewModel employee)
        {
            //hhapus data lama
            EmployeeViewModel empleyeeOld = _employeeViewModels.Find(x => x.Id.Equals(id));
            _employeeViewModels.Remove(empleyeeOld);
                        
            _employeeViewModels.Add(employee);
            return Redirect("List");
        }

        public IActionResult Details(int id) 
        {
            EmployeeViewModel employee = (
                from p in _employeeViewModels
                where p.Id == id
                select p).SingleOrDefault(new EmployeeViewModel()); 
            return View(employee);        
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            EmployeeViewModel employee = _employeeViewModels.Find(x => x.Id.Equals(id));
            _employeeViewModels.Remove(employee);

            return Redirect("List");
        }

    }
}
