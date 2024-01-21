using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admisiones.Logic
{
    public abstract class Carrer
    {

        public Carrer()
        {
            UIdCareer = Guid.NewGuid().ToString();
        }
        public string? UIdCareer { get; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal ValorSemestre { get; set; }
        public TipoCarreras TipoCarrera { get; set; }

        public abstract decimal GetValueSemesterToPay();
        public abstract decimal GetValueSemesterEfectiveToPay();
        public abstract decimal GetValueSemesterTargetToPay();
        public override string ToString()
        {
            return $"ID:\t{UIdCareer}\n\t" +
                   $"Name: ...........{Name, 20}\n\t" +
                   $"Tipo:Carrera.....{TipoCarrera, 20}\n\t" +
                   $"TotalSemestre....{ValorSemestre, 20:C2}\n\t";
        }


    }

    public enum TipoCarreras
    {
        Presencial,
        Ejecutivo,
        Online
    }
}
