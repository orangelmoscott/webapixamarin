using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ejemvcxamarin.Models;
using ejemvcxamarin.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ejemvcxamarin.Controllers
{
    [Route("api/[controller]")]
    public class DoctoresController : Controller
    {
        RepositoryDoctores repo;

        public DoctoresController(RepositoryDoctores repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Doctor>> Get()
        {
            return this.repo.GetDoctores();
        }

        [HttpGet("{doctor_no}")]
        public ActionResult<Doctor> Get(int doctor_no)
        {
            return this.repo.BuscarDoctor(doctor_no);
        }

        [HttpGet("[action]/{especialidad}")]
        public ActionResult<List<Doctor>> BuscarEspecialidad(String especialidad)
        {
            return this.repo.BuscarEspecialidad(especialidad);
        }
    }
}
