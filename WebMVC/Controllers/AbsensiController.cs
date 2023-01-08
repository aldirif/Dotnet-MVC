using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class AbsensiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private static List<AbsensiViewModel> _absensiViewModels = new List<AbsensiViewModel>()
        {
            new AbsensiViewModel(1, 1, DateTime.Now, DateTime.Now.AddHours(9), "Manchester", "Bootcamp"),
            new AbsensiViewModel(2, 2, new DateTime(2023, 1, 8, 08, 00, 0), new DateTime(2023, 1, 8, 17, 00, 0), "Manchester", "Bootcamp"),
            new AbsensiViewModel(3, 3, new DateTime(2023, 1, 8, 08, 00, 0), new DateTime(2023, 1, 8, 17, 00, 0), "Manchester", "Bootcamp"),
        };

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Id, EmployeeId, AbsentStartDate, AbsentEndDate, Location, Description")] AbsensiViewModel absensi)
        {
            _absensiViewModels.Add(absensi);
            return Redirect("List");
        }

        public IActionResult List()
        {
            return View(_absensiViewModels);
        }

        public IActionResult Edit(int? id)
        {
            AbsensiViewModel model = _absensiViewModels.Find(x => x.Id.Equals(id));
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(int id, [Bind("Id, EmployeeId, AbsenStartDate, AbsenEndDate, Location, Description")] AbsensiViewModel absensi)
        {
            AbsensiViewModel absensiOld = _absensiViewModels.Find(x => x.Id.Equals(id));
            _absensiViewModels.Remove(absensiOld);

            _absensiViewModels.Add(absensi);
            return Redirect("List");
        }

        public IActionResult Details(int id)
        {
            AbsensiViewModel absensi = (
                from p in _absensiViewModels
                where p.Id.Equals(id)
                select p).SingleOrDefault(new AbsensiViewModel());
            return View(absensi);
        }

        public IActionResult Delete(int? id)
        {
            AbsensiViewModel absensi = _absensiViewModels.Find(x => x.Id.Equals(id));
            _absensiViewModels.Remove(absensi);
            return Redirect("/Absensi/List");
        }
    }
}
