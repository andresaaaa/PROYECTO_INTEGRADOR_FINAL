using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INTEGRADOR_FINAL.Modelo
{
    internal class ShowQuestions
    {
        public DataTable Questions { get; set; }
        public ShowQuestions()
        {
            Questions = new DataTable();
            DataColumn Name = new DataColumn("Nombre", typeof(string));
            DataColumn ID = new DataColumn("ID", typeof(int));
            DataColumn Question = new DataColumn("Preguntas", typeof(string));
            DataColumn Answer = new DataColumn("Respuesta1", typeof(string));
            Questions.Columns.Add(Name);
            Questions.Columns.Add(ID);
            Questions.Columns.Add(Question);
            Questions.Columns.Add(Answer);
        }
        public void LoadData()
        {
            try
            {
                using (StreamReader reader = new StreamReader("PersonAnswers.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] lines = line.Split(',');

                       
                        if (lines.Length >= 4)
                        {
                            DataRow row = Questions.NewRow();
                            row[0] = lines[0].Trim();
                            row[1] = Convert.ToInt32(lines[1].Trim()); 
                            row[2] = lines[2].Trim(); 
                            row[3] = lines[3].Trim(); 
                            Questions.Rows.Add(row);
                        }
                        
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
                foreach (DataRow row in Questions.Rows)
                {
                    rows += $"{row[0]},{row[1]},{row[2]},{row[3]},{Environment.NewLine}";
                }
                using (StreamWriter writer = new StreamWriter("PersonAnswers.txt", false))
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
