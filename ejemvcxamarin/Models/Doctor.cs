using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ejemvcxamarin.Models
{
    [Table("DOCTOR")]
    public class Doctor
    {
        [Key]
        [Column("HOSPITAL_COD")]
        public int hospital_cod { get; set; }
        [Column("DOCTOR_NO")]
        public int doctor_no { get; set; }
        [Column("APELLIDO")]
        public String apellido { get; set; }
        [Column("ESPECIALIDAD")]
        public String Especialidad { get; set; }
    }
}
