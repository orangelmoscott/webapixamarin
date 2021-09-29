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
    public class EmpleadosController : Controller
    {
        RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Empleado>> Get()
        {
            return this.repo.GetEmpleados();
        }

        [HttpGet("{id}")]
        public ActionResult<Empleado> Get(int id)
        {
            return this.repo.BuscarEmpleado(id);
        }



        [HttpGet("{oficio}/{departamento}")]
        public ActionResult<List<Empleado>> GetEmpleados(String oficio, int departamento)
        {
            return this.repo.GetEmpleados(oficio, departamento);
        }




        [Route("[action]/{salario}")]
        [HttpGet]
        public ActionResult<List<Empleado>> GetEmpleadosSalario(int salario)
        {
            return this.repo.GetEmpleadosSalario(salario);
        }
    }
}
