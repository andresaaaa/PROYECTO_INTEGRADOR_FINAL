using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INTEGRADOR_FINAL.Modelo
{
    internal class Municipality
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int Departament { get; set; }

        public Municipality(int code, string name, int departament)
        {
            Code = code;
            Name = name;
            Departament = departament;
        }

        public override string ToString()
        {

            return $"{Name}";
        }
    }
}
