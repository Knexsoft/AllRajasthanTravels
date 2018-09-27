using AllRajasthan.DAL.EntityModel;
using AllRajasthan.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;


namespace AllRajasthan.CMS.Controllers
{
    public class PackageController : Controller
    {
        private readonly IBaseRepository<Package> _package;

            public PackageController(IBaseRepository<Package> package)
        {
            _package = package;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var PKG = _package.All;
            return View(PKG);
        }

        public IActionResult Detail()
        {
            return Ok();
        }

        public IActionResult Create()
        {
            var Pkg = new Package();
            return View(Pkg);
        }
        [HttpPost]
        public IActionResult Create(Package package)
        {
            
Guid id = Guid.NewGuid();
            if (!ModelState.IsValid)
            {
                _package.Add(package);
            }

            return RedirectToAction("Index");
        }
    }
}
