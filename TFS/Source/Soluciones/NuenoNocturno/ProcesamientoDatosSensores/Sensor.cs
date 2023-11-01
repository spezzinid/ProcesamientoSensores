using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcesamientoDatosSensores
{
    public class Sensor
    {
        public short Index { get; set; }
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public string Zone { get; set; }
        public decimal Value { get; set; }
    }
}
