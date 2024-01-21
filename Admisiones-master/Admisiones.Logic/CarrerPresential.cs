using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admisiones.Logic
{
    public class CarrerPresential : Carrer
    {

        public override decimal GetValueSemesterEfectiveToPay()
        {
            return ValorSemestre * 0.90m;
        }

        public override decimal GetValueSemesterTargetToPay()
        {
            return ValorSemestre * 0.95m;
        }

        public override decimal GetValueSemesterToPay()
        {
            return ValorSemestre;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Valor del Semestre ... {GetValueSemesterToPay(), 20:C2}\n\t" +
                   $"============= Descuentos =====================\n\t" +
                   $"Pago en efectivo.......{GetValueSemesterEfectiveToPay(), 20:c2}\n\t" +
                   $"Pago con tarjeta.......{GetValueSemesterTargetToPay(), 20:C2}\n\t";
        }
    }
}
