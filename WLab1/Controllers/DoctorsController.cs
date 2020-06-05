using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WLab1.Data;
using WLab1.Models;
using WLab1.Forms;

namespace WLab1.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoctorsController(ApplicationDbContext context) => _context = context;

        public async Task<IActionResult> Index() => View(await _context.Doctors.ToListAsync());

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var doctor = await _context.Doctors
                .SingleOrDefaultAsync(m => m.Id == id);

            if (doctor == null) return NotFound();

            return View(doctor);
        }

        public IActionResult Create() => View(new DoctorsForm());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DoctorsForm model)
        {
            if (ModelState.IsValid)
            {
                var doctor = new Doctor
                {
                    Name = model.Name,
                    Speciality = model.Speciality
                };

                _context.Doctors.Add(doctor);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(model);

        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return this.NotFound();

            var doctor = await this._context.Doctors
                .SingleOrDefaultAsync(m => m.Id == id);

            if (doctor == null) return NotFound();

            var model = new DoctorsForm
            {
                Name = doctor.Name,
                Speciality = doctor.Speciality
            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, DoctorsForm model)
        {
            if (id == null) return NotFound();

            var doctor = await _context.Doctors
                .SingleOrDefaultAsync(m => m.Id == id);

            if (doctor == null) return NotFound();

            if (ModelState.IsValid)
            {
                doctor.Name = model.Name;
                doctor.Speciality = model.Speciality;

                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var doctor = await _context.Doctors
                .SingleOrDefaultAsync(m => m.Id == id);

            if (doctor == null) return NotFound();

            return View(doctor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctor = await _context.Doctors.SingleOrDefaultAsync(m => m.Id == id);
            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorExists(int id) => _context.Doctors.Any(e => e.Id == id);
    }
}