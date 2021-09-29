using System;
using System.Collections.Generic;
using System.Linq;
using ejemvcxamarin.Data;
using ejemvcxamarin.Models;

namespace ejemvcxamarin.Repositories
{
    public class RepositoryDoctores
    {
        DoctorContext context;

        public RepositoryDoctores(DoctorContext context)
        {

            this.context = context;
        }

        public List<Doctor> GetDoctores()
        {
            return this.context.Doctores.ToList();
        }

        public Doctor BuscarDoctor(int doctor_no)
        {
            return this.context.Doctores.SingleOrDefault(z => z.doctor_no == doctor_no);
        }

        public List<Doctor> BuscarEspecialidad(String especialidad)
        {
            return this.context.Doctores.Where(z => z.Especialidad == especialidad).ToList();
        }

    }
}
