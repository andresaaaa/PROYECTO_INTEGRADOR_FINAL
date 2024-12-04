using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace PROYECTO_INTEGRADOR_FINAL.Modelo
{
    internal class QuestionsData
    {
        public int ID {  get; set; }
        public string Name {  get; set; }
        public string Question { get; set; }
        public string Answer {  get; set; }

        public static List<QuestionsData> questionsDatas = new List<QuestionsData>();

        public QuestionsData() { }
        public QuestionsData(string name,int iD,string question,string answer)
        {
            Name = name;
            ID = iD;
            Question = question;
            Answer = answer;
        }

        
        public void Create()
        {
            questionsDatas.Add(this);
        }

        public void Read()
        {
            questionsDatas.ToString();
        }

        public void Update()
        {

        }

        public void Delete()
        {
            if (!questionsDatas.Contains(this))
            {
                questionsDatas.Remove(this);
                add();
            }
        }
        public void add()
        {
            questionsDatas.Add(this);
            using (StreamWriter writer = new StreamWriter("PersonAnswers.txt", true))
            {
                writer.WriteLine(ToString());
            }
        }
        public override string ToString()
        {
            return $"{Name},{ID},{Question},{Answer}";
        }
    }
}
