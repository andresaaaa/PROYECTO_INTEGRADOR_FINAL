using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PROYECTO_INTEGRADOR_FINAL.Modelo
{
    internal class Persona
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Semester { get; set; }
        public int Age { get; set; }
        public long PhoneNumber { get; set; }
        public string FacultyName { get; set; }
        public string ProgramName { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string SocioeconomicStratum { get; set; }
        public string Department { get; set; }
        public string Municipality {  get; set; }

        public List<Persona> PersonList = new List<Persona>();

        public Persona() { }
        public Persona(string firstName, string lastName, string email, int semester, 
            int age, long phoneNumber, string facultyName, string programName, string documentType, 
            string documentNumber, DateTime birthDate, string gender, string socioeconomicStratum, string department,string municipality)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Semester = semester;
            Age = age;
            PhoneNumber = phoneNumber;
            FacultyName = facultyName;
            ProgramName = programName;
            DocumentType = documentType;
            DocumentNumber = documentNumber;
            BirthDate = birthDate;
            Gender = gender;
            SocioeconomicStratum = socioeconomicStratum;
            Department = department;
            Municipality = municipality; 
        }
        public void Sync()
        {
            PersonList.Clear();
            if (!File.Exists("PersonData.txt")) return;

            using (StreamReader reader = new StreamReader("PersonData.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] datos = line.Split(',');
                        if (datos.Length == 15)
                        {
                            PersonList.Add(new Persona(
                                datos[0],
                                datos[1],
                                datos[2],
                                Convert.ToInt32(datos[3]),
                                Convert.ToInt32(datos[4]),
                                Convert.ToInt32(datos[5]),
                                datos[6],
                                datos[7],
                                datos[8],
                                datos[9],
                                Convert.ToDateTime(datos[10]),
                                datos[11],
                                datos[12],
                                datos[13],
                                datos[14]
                            ));
                        }
                    }
                }
            }
        }
        public void Create()
        {
            PersonList.Add(this);
        }

        public void Read()
        {
            PersonList.ToString();
        }

        public void Update()
        {

        }

        public void Delete()
        {
            if (!PersonList.Contains(this))
            {
                PersonList.Remove(this);
                add();
            }
        }
        public void add()
        {
            PersonList.Add(this);
            using (StreamWriter writer = new StreamWriter("PersonData.txt", true))
            {
                writer.WriteLine(ToString());
            }
        }
        public override string ToString()
        {
            return $"{FirstName},{LastName},{Email},{Semester},{Age},{PhoneNumber},{FacultyName},{ProgramName}," +
                   $"{DocumentType},{DocumentNumber},{BirthDate}," +
                   $"{Gender},{SocioeconomicStratum},{Department},{Municipality},";
        }
    }
}
