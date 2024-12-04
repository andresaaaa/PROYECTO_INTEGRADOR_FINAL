using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INTEGRADOR_FINAL.Modelo
{
    internal class Departament
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public static List<Municipality> ListMunicipality { get; set; }
        public static List<Departament> Listdepartaments = new List<Departament>();

        public Departament() { Sync(); }
        public Departament(int code, string name)
        {
            Code = code;
            Name = name;
            Sync();
        }
        public void Sync()
        {
            using (StreamReader leer = new StreamReader("Departamentos.txt"))
            {

                while (leer.EndOfStream)
                {
                    string dpt = leer.ReadToEnd();
                    if (!string.IsNullOrWhiteSpace(dpt))
                    {
                        string[] datos = dpt.Split(',');
                        if (datos.Length == 1)
                        {
                            Listdepartaments.Add(new Departament
                            (
                                Convert.ToInt32(datos[0]),
                                datos[1]
                            )
                            );
                        }
                    }
                }

            };
        }
    }
}
