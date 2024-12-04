using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PROYECTO_INTEGRADOR_FINAL.Modelo
{
    internal class PersonaLoguinData
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Role {  get; set; }

        public static List<PersonaLoguinData> List = new List<PersonaLoguinData>();

        public PersonaLoguinData() { }
        public PersonaLoguinData(int Id, string user, string password, string role)
        {
            ID = Id;
            User = user;
            Password = password;
            Role = role;
        }



        public void Sync()
        {
            List.Clear(); 
            if (!File.Exists("LoguinData.txt")) return;

            using (StreamReader reader = new StreamReader("LoguinData.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] datos = line.Split(',');
                        if (datos.Length == 4)
                        {
                            List.Add(new PersonaLoguinData(
                                Convert.ToInt32(datos[0]),
                                datos[1],
                                datos[2],
                                datos[3]
                            ));
                        }
                    }
                }
            }
        }
        public string Read()
        {
            return List.ToString();
        }

        public void Update()
        {
            int index = List.FindIndex(d => d.User == this.User);
            if (index != 1)
            {
                List[index] = this;
            }
        }
        public void Delete()
        {
            if (!List.Contains(this))
            {
                List.Remove(this);
                add();
            }
        }

        public void add()
        {
            List.Add(this);
            using (StreamWriter writer = new StreamWriter("LoguinData.txt", true))
            {
                writer.WriteLine(ToString());
            }
        }

        public override string ToString()
        {
            return $"{ID},{User},{Password},{Role}";
        }
    }
}

