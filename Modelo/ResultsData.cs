using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INTEGRADOR_FINAL.Modelo
{
    internal class ResultsData
    {
        public DataTable Information {  get; set; }

        public ResultsData()
        {
            Information = new DataTable();
            DataColumn cedula = new DataColumn("Cedula", typeof(string));
            DataColumn Nombre = new DataColumn("Nombre", typeof(string));
            DataColumn Email = new DataColumn("Email", typeof(string));
            DataColumn Semester = new DataColumn("Semester", typeof(int));
            DataColumn Age = new DataColumn("Age", typeof(int));
            DataColumn Phone = new DataColumn("Phone", typeof(long));
            DataColumn FacultyName = new DataColumn("FacultyName", typeof(string));
            DataColumn ProgramName = new DataColumn("ProgramName", typeof(string));
            DataColumn DocumentType = new DataColumn("DocumentType", typeof(string));
            DataColumn DocumentNumber = new DataColumn("DocumentNumber", typeof(string));
            DataColumn BirthDate = new DataColumn("BirthDate", typeof(string));
            DataColumn Gender = new DataColumn("Gender", typeof(string));
            DataColumn Stratum = new DataColumn("Stratum", typeof(string));
            DataColumn Department = new DataColumn("Department", typeof(string));
            DataColumn Municipality = new DataColumn("Municipality", typeof(string));

            Information.Columns.Add(cedula);
            Information.Columns.Add(Nombre);
            Information.Columns.Add(Email);
            Information.Columns.Add(Semester);
            Information.Columns.Add(Age);
            Information.Columns.Add(Phone);
            Information.Columns.Add(FacultyName);
            Information.Columns.Add(ProgramName);
            Information.Columns.Add(DocumentType);
            Information.Columns.Add(DocumentNumber);
            Information.Columns.Add(BirthDate);
            Information.Columns.Add(Gender);
            Information.Columns.Add(Stratum);
            Information.Columns.Add(Department);
            Information.Columns.Add(Municipality);
        }

        public void LoadData()
        {
            try
            {
                using (StreamReader reader = new StreamReader("PersonData.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] lines = reader.ReadLine().Split(',');

                        DataRow row = Information.NewRow();
                        row[0] = lines[0];
                        row[1] = lines[1];
                        row[2] = lines[2];
                        row[3] = lines[3];
                        row[4] = lines[4];
                        row[5] = lines[5];
                        row[6] = lines[6];
                        row[7] = lines[7];
                        row[8] = lines[8];
                        row[9] = lines[9];
                        row[10] = lines[10];
                        row[11] = lines[11];
                        row[12] = lines[12];
                        row[13] = lines[13];
                        row[14] = lines[14];
                        Information.Rows.Add(row);


                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, nameof(LoadData));
            }



        }
        public void SyncData()
        {
            try
            {
                string rows = "";
                foreach (DataRow row in Information.Rows)
                {
                    rows += $"{row[0]},{row[1]},{row[2]},{row[3]},{row[4]},{row[5]},{row[6]},{row[7]},{row[8]},{row[9]}" +
                        $",{row[10]},{row[11]},{row[12]},{row[13]},{row[14]},{Environment.NewLine}";
                }
                using (StreamWriter writer = new StreamWriter("Persona.txt", false))
                {
                    writer.WriteLine(rows);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, nameof(SyncData));
            }
        }
    }
}
