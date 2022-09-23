using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClienteWebOData.Data;
using EjercitoOData.Models;

namespace ClienteWebOData.Controllers
{
    public class EjercitosController : Controller
    { 
        private readonly ClienteWebODataContext _context;

        public EjercitosController(ClienteWebODataContext context)
        {
            _context = context;
        }

        // GET: Ejercitos
        public async Task<IActionResult> Index()
        {
            var ejercitos = _context.GetEjercitos();
            return View(ejercitos);
        }

        // GET: Ejercitos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ejercito = _context.Find(id);
            if (ejercito == null)
            {
                return NotFound();
            }

            return View(ejercito);
        }

        // GET: Ejercitos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ejercitos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,FechaNacimiento,FuerzaCombate,Ubicacion")] Ejercito ejercito)
        {
            if (ModelState.IsValid)
            {
                _context.Anadir(ejercito);
            }
            return RedirectToAction("Index");
        }

        private bool EjercitoExists(int id)
        {
            return _context.Find(id) != null;
        }
    }
}
