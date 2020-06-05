using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WLab1.Data;
using WLab1.Forms;
using WLab1.Models;


namespace WLab1.Controllers
{
    public class HospitalsController : Controller
    {
        private readonly ApplicationDbContext context;

        public HospitalsController(ApplicationDbContext con) => context = con;

        public async Task<IActionResult> Index() => View(await context.Hospitals.ToListAsync());

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var hospital = await context.Hospitals
                .Include(x => x.Phones)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (hospital == null) return NotFound();

            return View(hospital);
        }

        public IActionResult Create() => View(new HospitalCreateForm());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HospitalCreateForm model)
        {
            if (this.ModelState.IsValid)
            {
                var hospital = new Hospital
                {
                    Name = model.Name,
                    Address = model.Address,
                    Phones = new Collection<HospitalPhone>()
                };
                if (model.Phones != null)
                {
                    var phoneId = 1;
                    foreach (var phone in model.Phones.Split(',').Select(x => x.Trim()).Where(x => !string.IsNullOrEmpty(x)))
                    {
                        hospital.Phones.Add(new HospitalPhone
                        {
                            PhoneId = phoneId++,
                            Number = phone
                        });
                    }
                }

                context.Hospitals.Add(hospital);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var hospital = await this.context.Hospitals
                .Include(x => x.Phones)
                .SingleOrDefaultAsync(m => m.Id == id);

            if (hospital == null) return NotFound();

            var model = new HospitalEditForm
            {
                Name = hospital.Name,
                Address = hospital.Address,
                Phones = string.Join(", ", hospital.Phones.OrderBy(x => x.PhoneId).Select(x => x.Number))
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, HospitalEditForm model)
        {
            if (id == null) return NotFound();

            var hospital = await this.context.Hospitals
                .Include(x => x.Phones)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (hospital == null) return NotFound();

            if (ModelState.IsValid)
            {
                hospital.Name = model.Name;
                hospital.Address = model.Address;
                var phoneId = hospital.Phones.Any() ? hospital.Phones.Max(x => x.PhoneId) + 1 : 1;
                hospital.Phones.Clear();
                if (model.Phones != null)
                {
                    foreach (var phone in model.Phones.Split(',').Select(x => x.Trim()).Where(x => !string.IsNullOrEmpty(x)))
                    {
                        hospital.Phones.Add(new HospitalPhone
                        {
                            PhoneId = phoneId++,
                            Number = phone
                        });
                    }
                }

                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var hospital = await context.Hospitals
                .SingleOrDefaultAsync(m => m.Id == id);

            if (hospital == null) return NotFound();

            return View(hospital);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hospital = await context.Hospitals.SingleOrDefaultAsync(m => m.Id == id);
            context.Hospitals.Remove(hospital);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
