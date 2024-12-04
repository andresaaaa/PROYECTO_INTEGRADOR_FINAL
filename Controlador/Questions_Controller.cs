using PROYECTO_INTEGRADOR_FINAL.Modelo;
using PROYECTO_INTEGRADOR_FINAL.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace PROYECTO_INTEGRADOR_FINAL.Controlador
{
    internal class Questions_Controller
    {
        Questions Questions_view;
        QuestionsData QuestionsData;
        public static List<QuestionsData> List;

        public Questions_Controller(Questions questions_view, QuestionsData questionsData)
        {
            Questions_view = questions_view;
            QuestionsData = questionsData;

            
            Questions_view.NextButton.Click += NextButton_Click;
            Questions_view.PrevButton.Click += PrevButton_Click;
            Questions_view.StartButton.Click += StartButton_Click;
            Questions_view.EndButton.Click += EndButton_Click;
            Questions_view.Save.Click += Save_Click;
            questions_view.FormClosing += Questions_view_FormClosing;
            AddQuestions();
        }

        private void Questions_view_FormClosing(object? sender, FormClosingEventArgs e)
        {
            
                Questions_view.Hide();
                Loguin loguin = new Loguin();
                loguin.ShowDialog();
            
        }

        private void EndButton_Click(object? sender, EventArgs e)
        {
            SaveAnswers();
            if (Questions_view.questionsList.Count > 0)
            {
                Questions_view.currentQuestionIndex = Questions_view.questionsList.Count - 1;
                DisplayQuestion(Questions_view.questionsList[Questions_view.currentQuestionIndex]);
                RestoredAnswers();
            }

        }

        private void StartButton_Click(object? sender, EventArgs e)
        {
            SaveAnswers();
            if (Questions_view.questionsList.Count > 0)
            {
                Questions_view.currentQuestionIndex = 0;
                DisplayQuestion(Questions_view.questionsList[Questions_view.currentQuestionIndex]);
                RestoredAnswers();
            }
        }

        private void PrevButton_Click(object? sender, EventArgs e)
        {
            SaveAnswers();
            if (Questions_view.currentQuestionIndex > 0)
            {
                Questions_view.currentQuestionIndex--;
                DisplayQuestion(Questions_view.questionsList[Questions_view.currentQuestionIndex]);
                RestoredAnswers();
            }
        }

        private void NextButton_Click(object? sender, EventArgs e)
        {
            SaveAnswers();
            if (Questions_view.currentQuestionIndex < Questions_view.questionsList.Count - 1)
            {
                Questions_view.currentQuestionIndex++;
                DisplayQuestion(Questions_view.questionsList[Questions_view.currentQuestionIndex]);
                RestoredAnswers();
            }
        }

        private void Save_Click(object? sender, EventArgs e)
        {

            int ID = 0;
            string Name = "";
            foreach (var item in Controlador.EstudentForm_controller.List)
            {
                ID = Convert.ToInt32(item.DocumentNumber.ToString());
                Name = item.FirstName;
            };

            for (int i = 0; i < Questions_view.questionsList.Count; i++)
            {
                string selectedAnswer = Questions_view.selectedAnswers[i];
                string questionText = Questions_view.questionsList[i][0];
                if (!string.IsNullOrEmpty(selectedAnswer))
                {
                    QuestionsData questionData = new QuestionsData(Name,ID, questionText, selectedAnswer);
                    questionData.add();
                }

            }
            MessageBox.Show("Respuestas guardadas exitosamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void AddQuestions()
        {
            using (StreamReader reader = new StreamReader("Questions.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {

                        string[] data = line.Split(',');
                        if (data.Length == 5)
                        {
                            Questions_view.questionsList.Add(data);
                        }
                        else
                        {
                            MessageBox.Show("El archivo contiene una línea mal formada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }


            if (Questions_view.questionsList.Count > 0)
            {
                DisplayQuestion(Questions_view.questionsList[Questions_view.currentQuestionIndex]);
            }

            if (Questions_view.questionsList.Count > 0)
            {
                Questions_view.selectedAnswers = new string[Questions_view.questionsList.Count];
                for (int i = 0; i < Questions_view.selectedAnswers.Length; i++)
                {
                    Questions_view.selectedAnswers[i] = null;
                }
                DisplayQuestion(Questions_view.questionsList[Questions_view.currentQuestionIndex]);
            }
        }
        private void DisplayQuestion(string[] data)
        {
            if (data.Length == 5)
            {
                Questions_view.QuestionLabel.Text = data[0];
                Questions_view.OptionA.Text = data[1];
                Questions_view.OptionB.Text = data[2];
                Questions_view.OptionC.Text = data[3];
                Questions_view.OptionD.Text = data[4];


            }
            Questions_view.Navegator.Text = $"{Questions_view.currentQuestionIndex + 1}/10";
        }
        private void SaveAnswers()
        {
            if (Questions_view.OptionA.Checked)
            {
                Questions_view.selectedAnswers[Questions_view.currentQuestionIndex] = Questions_view.OptionA.Text;
            }
            else if (Questions_view.OptionB.Checked)
            {
                Questions_view.selectedAnswers[Questions_view.currentQuestionIndex] = Questions_view.OptionB.Text;
            }
            else if (Questions_view.OptionC.Checked)
            {
                Questions_view.selectedAnswers[Questions_view.currentQuestionIndex] = Questions_view.OptionC.Text;
            }
            else if (Questions_view.OptionD.Checked)
            {
                Questions_view.selectedAnswers[Questions_view.currentQuestionIndex] = Questions_view.OptionD.Text;
            }
            else
            {
                Questions_view.selectedAnswers[Questions_view.currentQuestionIndex] = null;
            }
        }
        private void RestoredAnswers()
        {
            string answer = Questions_view.selectedAnswers[Questions_view.currentQuestionIndex];

            Questions_view.OptionA.Checked = (answer == Questions_view.OptionA.Text);
            Questions_view.OptionB.Checked = (answer == Questions_view.OptionB.Text);
            Questions_view.OptionC.Checked = (answer == Questions_view.OptionC.Text);
            Questions_view.OptionD.Checked = (answer == Questions_view.OptionD.Text);

        }
    }
}
