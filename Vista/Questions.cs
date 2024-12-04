using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using PROYECTO_INTEGRADOR_FINAL.Modelo;
using System.Diagnostics;
using PROYECTO_INTEGRADOR_FINAL.Controlador;

namespace PROYECTO_INTEGRADOR_FINAL.Vista
{
    public partial class Questions : Form
    {
        public Panel panel { get; set; }
        public Label QuestionLabel { get; set; }
        public RadioButton OptionA { get; set; }
        public RadioButton OptionB { get; set; }
        public RadioButton OptionC { get; set; }
        public RadioButton OptionD { get; set; }
        public Button NextButton { get; set; }
        public Button PrevButton { get; set; }
        public Button EndButton { get; set; }
        public Button StartButton { get; set; }
        public Button Save { get; set; }
        public TextBox Navegator { get; set; }
        public List<string[]> questionsList = new List<string[]>();
        public string[] selectedAnswers;


        public int currentQuestionIndex = 0;
        public Questions()
        {
            InitializeComponent();
        }
        private void Questions_Load(object sender, EventArgs e)
        {
            ControlsDesigner();
            QuestionsData questionsData = new QuestionsData();
            Questions_Controller questions_Controller = new Questions_Controller(this, questionsData);
        }

        private void ControlsDesigner()
        {
            
            panel = CreatePanel("Panel", this);
            panel.BackColor = Color.Gray;
            QuestionLabel = CreateLabel("QuestionLabel", new Size(500, 140), 14, new Point(0, 30), panel);

            OptionA = CreateRadioButton("OptionA", new Size(350, 40), new Point(10, 180), panel);
            OptionB = CreateRadioButton("Optionb", new Size(350, 40), new Point(10, 255), panel);
            OptionC = CreateRadioButton("Optionc", new Size(350, 40), new Point(10, 320), panel);
            OptionD = CreateRadioButton("Optiond", new Size(350, 40), new Point(10, 380), panel);

            StartButton = CreateButton("StratButton", new Size(50, 40), new Point(50, 480), panel);
            StartButton.BackgroundImage = System.Drawing.Image.FromFile("next2.png");
            StartButton.BackgroundImageLayout = ImageLayout.Zoom;

            NextButton = CreateButton("NextButton", new Size(50, 40), new Point(230, 480), panel);
            NextButton.BackgroundImage = System.Drawing.Image.FromFile("next.png");
            NextButton.BackgroundImageLayout = ImageLayout.Zoom;

            Navegator = CreateTextBox("NavegationBox", new Size(80, 40), new Point(150, 480), panel);



            PrevButton = CreateButton("PrevButton", new Size(50, 40), new Point(100, 480), panel);
            PrevButton.BackgroundImage = System.Drawing.Image.FromFile("next - copia.png");
            PrevButton.BackgroundImageLayout = ImageLayout.Zoom;

            EndButton = CreateButton("EndButton", new Size(50, 40), new Point(280, 480), panel);
            EndButton.BackgroundImage = System.Drawing.Image.FromFile("next2 - copia.png");
            EndButton.BackgroundImageLayout = ImageLayout.Zoom;

            Save = CreateButton("EndButton", new Size(80, 40), new Point(150, 540), panel);
            Save.Text="Finalizar";

            panel.Controls.Add(QuestionLabel);
            panel.Controls.Add(OptionA);
            panel.Controls.Add(OptionB);
            panel.Controls.Add(OptionC);
            panel.Controls.Add(OptionD);
            panel.Controls.Add(StartButton);
            panel.Controls.Add(NextButton);
            panel.Controls.Add(Navegator);
            panel.Controls.Add(PrevButton);
            panel.Controls.Add(EndButton);
            NextButton.Click += NextButton_Click;
            AddQuestions();

            PrevButton.Click += PrevButton_Click;
            StartButton.Click += StartButton_Click;
            EndButton.Click += EndButton_Click;
            Save.Click += Save_Click;


        }

        private void Save_Click(object? sender, EventArgs e)
        {
        }

        private void EndButton_Click(object? sender, EventArgs e)
        {
        }

        private void StartButton_Click(object? sender, EventArgs e)
        {
        }

        private void PrevButton_Click(object? sender, EventArgs e)
        {
        }

        private void NextButton_Click(object? sender, EventArgs e)
        {
        }



        private Panel CreatePanel(string name, Control parent)
        {
            return new Panel
            {
                Name = name,
                Parent = parent,
                BackColor = Color.Transparent,
                Size = new Size(parent.Height, 600),
                Location = new Point(90, 40),


            };
        }

        public Label CreateLabel(string name, Size size, int fontSize, Point point, Control parent)
        {
            return new Label
            {
                Name = name,
                Size = size,
                Location = point,
                Text = "hola",
                Parent = parent,
                Font = new System.Drawing.Font("Arial", fontSize),
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.Fixed3D,
            };
        }

        public RadioButton CreateRadioButton(string name, Size size, Point point, Control parent)
        {
            return new RadioButton
            {
                Name = name,
                Size = size,
                Text = "pregunta",
                Location = point,
                Parent = parent,
                Font = new System.Drawing.Font("Arial", 12)
            };
        }

        public Button CreateButton(string name, Size size, Point point, Control parent)
        {
            return new Button
            {
                Name = name,
                Size = size,
                Location = point,
                Parent = parent,
                Font = new System.Drawing.Font("Arial", 10),
                BackColor = Color.LightGray,
            };
        }

        public TextBox CreateTextBox(string name, Size size, Point point, Control parent)
        {
            return new TextBox
            {
                Name = name,
                Size = size,
                Location = point,
                Parent = parent,
                Font = new System.Drawing.Font("Arial", 12),
                Multiline = true,
            };
        }

        public void AddQuestions()
        {
        }
        private void DisplayQuestion(string[] data)
        {

        }

        private void SaveAnswers()
        {

        }

        private void RestoredAnswers()
        {
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }


}

