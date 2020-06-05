using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WLab1.Data;
using WLab1.Forms;
using WLab1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WLab1.Controllers
{
    public class WardsController : Controller
    {
        private readonly ApplicationDbContext context;

        public WardsController(ApplicationDbContext context) => this.context = context;

        public async Task<IActionResult> Index(int? hospitalId)
        {
            if (hospitalId == null) return View(await context.Wards.ToListAsync());

            var hospital = await context.Hospitals
                .SingleOrDefaultAsync(x => x.Id == hospitalId);

            if (hospital == null) return NotFound();

            ViewBag.Hospital = hospital;
            var wards = await context.Wards
                .Include(w => w.Hospital)
                .Where(x => x.HospitalId == hospitalId)
                .ToListAsync();

            return View(wards);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var ward = await context.Wards
                .Include(w => w.Hospital)
                .SingleOrDefaultAsync(m => m.Id == id);

            if (ward == null) return NotFound();

            return View(ward);
        }

        public async Task<IActionResult> Create(int? hospitalId)
        {
            if (hospitalId == null) return NotFound();

            var hospital = await context.Hospitals
                .SingleOrDefaultAsync(x => x.Id == hospitalId);

            if (hospital == null) return NotFound();

            ViewBag.Hospital = hospital;
            return View(new WardCreateForm());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int? hospitalId, WardCreateForm model)
        {
            if (hospitalId == null) return NotFound();

            var hospital = await context.Hospitals
                .SingleOrDefaultAsync(x => x.Id == hospitalId);

            if (hospital == null) return NotFound();

            if (ModelState.IsValid)
            {
                var ward = new Ward
                {
                    HospitalId = hospital.Id,
                    Name = model.Name
                };

                context.Add(ward);
                await context.SaveChangesAsync();
                return RedirectToAction("Index", new { hospitalId = hospital.Id });
            }

            ViewBag.Hospital = hospital;
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var ward = await context.Wards.SingleOrDefaultAsync(m => m.Id == id);

            if (ward == null) return NotFound();

            var model = new WardEditForm
            {
                Name = ward.Name
            };

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, WardEditForm model)
        {
            if (id == null) return NotFound();

            var ward = await context.Wards.SingleOrDefaultAsync(m => m.Id == id);

            if (ward == null) return NotFound();

            if (ModelState.IsValid)
            {
                ward.Name = model.Name;
                await context.SaveChangesAsync();
                return RedirectToAction("Index", new { hospitalId = ward.HospitalId });
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var ward = await context.Wards
                .Include(w => w.Hospital)
                .Include(w => w.WardStaffs)
                .SingleOrDefaultAsync(m => m.Id == id);

            if (ward == null) return NotFound();

            return View(ward);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ward = await context.Wards.SingleOrDefaultAsync(m => m.Id == id);
            context.Wards.Remove(ward);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", new { hospitalId = ward.HospitalId });
        }
    }
}
