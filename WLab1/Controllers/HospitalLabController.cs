using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WLab1.Data;
using WLab1.Forms;
using WLab1.Models;

namespace WLab1.Controllers
{
    public class HospitalLabsController : Controller
    {
        private readonly ApplicationDbContext context;

        public HospitalLabsController(ApplicationDbContext context) => this.context = context;

        public async Task<IActionResult> Index(int? hospitalId)
        {
            if (hospitalId == null) return NotFound();

            var hospital = await context.Hospitals
                .SingleOrDefaultAsync(x => x.Id == hospitalId);

            if (hospital == null) return NotFound();

            var items = await context.HospitalLabs
                .Include(h => h.Hospital)
                .Include(h => h.Lab)
                .Where(x => x.HospitalId == hospital.Id)
                .ToListAsync();

            ViewBag.Hospital = hospital;
            return View(items);
        }

        public async Task<IActionResult> Create(int? hospitalId)
        {
            if (hospitalId == null) return NotFound();

            var hospital = await context.Hospitals
                .SingleOrDefaultAsync(x => x.Id == hospitalId);

            if (hospital == null) return NotFound();

            ViewBag.Hospital = hospital;
            ViewData["LabId"] = new SelectList(context.Labs, "Id", "Name");
            return View(new HospitalLabCreateForm());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int? hospitalId, HospitalLabCreateForm model)
        {
            if (hospitalId == null) return NotFound();

            var hospital = await context.Hospitals
                .SingleOrDefaultAsync(x => x.Id == hospitalId);

            if (hospital == null) return NotFound();

            if (ModelState.IsValid)
            {
                var hospitalLab = new HospitalLab
                {
                    HospitalId = hospital.Id,
                    LabId = model.LabId
                };

                context.Add(hospitalLab);
                await context.SaveChangesAsync();
                return RedirectToAction("Index", new { hospitalId = hospital.Id });
            }

            ViewBag.Hospital = hospital;
            ViewData["LabId"] = new SelectList(context.Labs, "Id", "Name", model.LabId);
            return View(model);
        }

        public async Task<IActionResult> Delete(int? hospitalId, int? labId)
        {
            if (hospitalId == null || labId == null) return NotFound();

            var hospitalLab = await context.HospitalLabs
                .Include(h => h.Hospital)
                .Include(h => h.Lab)
                .SingleOrDefaultAsync(m => m.HospitalId == hospitalId && m.LabId == labId);

            if (hospitalLab == null) return NotFound();

            return View(hospitalLab);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int hospitalId, int labId)
        {
            var hospitalLab = await context.HospitalLabs.SingleOrDefaultAsync(m => m.HospitalId == hospitalId && m.LabId == labId);
            context.HospitalLabs.Remove(hospitalLab);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", new { hospitalId });
        }
    }
}
