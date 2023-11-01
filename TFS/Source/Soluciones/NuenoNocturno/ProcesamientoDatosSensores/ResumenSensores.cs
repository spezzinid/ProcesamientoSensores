using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcesamientoDatosSensores
{
    public class ResumenSensores
    {
        public string IdSensorMayorValor { get; set; }
        public decimal ValorMedio { get; set; }
        public decimal ValorMedioZ1 { get; set; }
        public decimal ValorMedioZ2 { get; set; }
        public decimal ValorMedioZ3 { get; set; }
        public decimal ValorMedioZ4 { get; set; }
        public int CantSensoresActivos { get; set; }
    }
}
