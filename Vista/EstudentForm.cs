using PROYECTO_INTEGRADOR_FINAL.Controlador;
using PROYECTO_INTEGRADOR_FINAL.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_INTEGRADOR_FINAL.Vista
{
    public partial class View_Principal : Form
    {
        public SplitContainer SplitContainer;
        public TextBox FirstNameBox { get; set; }
        public TextBox LastNameBox { get; set; }
        public ComboBox StratumCoBox { get; set; }
        public ComboBox DocumentTypeBox { get; set; }
        public TextBox DocumentNumberBox { get; set; }
        public ComboBox municipalityCoBox { get; set; }
        public ComboBox DepartamentCoBox { get; set; }
        public ComboBox FacultyNameBox { get; set; }
        public ComboBox ProgramNameBox { get; set; }
        public string Gender { get; set; }
        public NumericUpDown SemesterBox { get; set; }
        public NumericUpDown AgeBox { get; set; }
        public TextBox PhoneNumberBox { get; set; }
        public TextBox EmailBox { get; set; }
        public TextBox AddressBox { get; set; }
        public DateTimePicker BirthDateBox { get; set; }
        public Button SubmitButton { get; set; }
        public RadioButton MaleRadio { get; set; }
        public RadioButton FemaleRadio { get; set; }
        public RadioButton OtherRadio { get; private set; }
        public Label SectionLabel { get; set; }
        public Label TitleLabel { get; set; }
        public View_Principal()
        {
            InitializeComponent();
        }

        private void View_Principal_Load(object sender, EventArgs e)
        {
            View_Designer(this);
        }
        public void View_Designer(Control parent)
        {

            TitleLabel = CreateLabel("TitleLabel", "Formulario de Información", new Size(300, 30), new Point(200, 40), parent);

            CreateLabel("FirstNameLabel", "estrato socioeconómico", new Size(100, 20), new Point(20, 100), parent);
            StratumCoBox = CreateComboBox("Stratum", new Size(180, 22), new Point(470, 100), parent);

            SectionLabel = CreateLabel("SectionLabel", "Nombre completo", new Size(200, 20), new Point(20, 160), parent);

            FirstNameBox = CreateTextBox("FirstNameBox","Nombres", new Size(100, 70), new Point(20, 200), parent);
            LastNameBox = CreateTextBox("LastNameBox","Apellidos", new Size(100, 70), new Point(135, 200), parent);


            CreateLabel("BirthDateLabel", "Fecha de Nacimiento", new Size(190, 20), new Point(470, 160), parent);
            BirthDateBox = CreateDateTimePicker("BirthDateBox", new Size(180, 20), new Point(470, 200), parent);



            CreateLabel("PhoneNumberLabel", "Teléfono", new Size(100, 20), new Point(20, 280), parent);
            PhoneNumberBox = CreateTextBox("PhoneNumberBox","Telefono", new Size(180, 40), new Point(20, 320), parent);

            CreateLabel("EmailLabel", "Correo Electrónico", new Size(100, 20), new Point(250, 280), parent);
            EmailBox = CreateTextBox("EmailBox","Correo", new Size(180, 20), new Point(250, 320), parent);

            CreateLabel("AddressLabel", "Edad", new Size(100, 20), new Point(470, 280), parent);
            AgeBox = CreateNumericUpDown("Age", new Size(180, 20), new Point(470, 320), parent);
            AgeBox.Maximum = 50;



            CreateLabel("BirthPlaceLabel", "Lugar de Nacimiento", new Size(190, 20), new Point(20, 380), parent);
            municipalityCoBox = CreateComboBox("MunicipalityBox", new Size(100, 70), new Point(135, 420), parent);
            DepartamentCoBox = CreateComboBox("DepartamentBox", new Size(100, 70), new Point(20, 420), parent);

            CreateLabel("DocumentTypeLabel", "Tipo de Documento", new Size(170, 20), new Point(250, 380), parent);
            DocumentTypeBox = CreateComboBox("DocumentTypeBox", new Size(180, 20), new Point(250, 420), parent);

            CreateLabel("DocumentNumberLabel", "Número de Documento", new Size(200, 20), new Point(470, 380), parent);
            DocumentNumberBox = CreateTextBox("DocumentNumberBox","N. Documento", new Size(180, 20), new Point(470, 420), parent);



            CreateLabel("FacultyNameLabel", "Facultad", new Size(190, 20), new Point(20, 480), parent);
            FacultyNameBox = CreateComboBox("FacultyNameBox", new Size(180, 20), new Point(20, 520), parent);

            CreateLabel("ProgramNameLabel", "Programa", new Size(100, 20), new Point(250, 480), parent);
            ProgramNameBox = CreateComboBox("ProgramNameBox", new Size(180, 20), new Point(250, 520), parent);

            CreateLabel("SemesterLabel", "Semestre", new Size(100, 20), new Point(470, 480), parent);
            SemesterBox = CreateNumericUpDown("SemesterBox", new Size(180, 20), new Point(470, 520), parent);

            CreateLabel("GenderLabel", "Género", new Size(100, 20), new Point(20, 580), parent);
            MaleRadio = CreateRadioButton("MaleRadio", "Masculino", new Size(90, 40), new Point(20, 610), parent);
            FemaleRadio = CreateRadioButton("FemaleRadio", "Femenino", new Size(90, 40), new Point(130, 610), parent);
            OtherRadio = CreateRadioButton("OtherRadio", "Otro", new Size(90, 40), new Point(240, 610), parent);

            SubmitButton = CreateButton("SubmitButton", "Enviar", new Size(100, 40), new Point(250, 650), parent);
            Persona persona = new Persona();
            EstudentForm_controller estudentForm_Controller = new EstudentForm_controller(this, persona);
        }
        private NumericUpDown CreateNumericUpDown(string name, Size size, Point location, Control parent)
        {
            return new NumericUpDown()
            {
                Name = name,
                Size = size,
                Location = location,
                Parent = parent,
                Maximum = 10,
            };
        }

        public DateTimePicker CreateDateTimePicker(string name, Size size, Point location, Control parent)
        {
            return new DateTimePicker()
            {
                Name = name,
                Size = size,
                Location = location,
                Parent = parent,
            };
        }
        public Label CreateLabel(string name, string text, Size size, Point location, Control parent)
        {
            return new Label()
            {
                Name = name,
                Text = text,
                Size = size,
                Location = location,
                Parent = parent,
                Font = new Font("Book antiqua", 10)
            };
        }

        public TextBox CreateTextBox(string name, string text, Size size, Point location, Control parent)
        {
            return new TextBox()
            {
                Name = name,
                Size = size,
                Location = location,
                Parent = parent,
                PlaceholderText = text
            };
        }

        public ComboBox CreateComboBox(string name, Size size, Point location, Control parent)
        {
            return new ComboBox()
            {
                Name = name,
                Size = size,
                Location = location,
                Parent = parent,
            };
        }
        public RadioButton CreateRadioButton(string name, string text, Size size, Point location, Control parent)
        {
            return new RadioButton()
            {
                Name = name,
                Text = text,
                Location = location,
                Parent = parent,
                Size = size,
            };
        }

        public Button CreateButton(string name, string text, Size size, Point location, Control parent)
        {
            return new Button()
            {
                Name = name,
                Text = text,
                Size = size,
                Location = location,
                Parent = parent
            };
        }
    }
}
