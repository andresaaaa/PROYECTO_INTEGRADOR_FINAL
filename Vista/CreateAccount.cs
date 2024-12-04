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
    public partial class CreateAccount : Form
    {
        public TextBox UserBox { get; set; }
        public TextBox PasswordBox { get; set; }
        public TextBox IDBox { get; set; }
        public string Role {  get; set; }
        public Button Cancel_Button { get; set; }
        public Button Create_account_Button { get; set; }
        public Label Text1 { get; set; }
        public Label Text2 { get; set; }
        public Label Text3 { get; set; }
        public Label Text4 { get; set; }
        public PictureBox BackGround { get; set; }
        public RadioButton Estudent { get; set; }
        public RadioButton Administrator { get; set; }
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(@"C:\\Users\\ASUS\\source\\repos\\Proyecto_Integrado\\Components\\Background.Jpg");
            BackGround = CreatePictureBox("BackImagen", @"C:\\Users\\ASUS\\source\\repos\\Proyecto_Integrado\\Components\\Login.Png", this);
            BackgroundImage = System.Drawing.Image.FromFile(@"C:\\Users\\ASUS\\source\\repos\\Proyecto_Integrado\\Components\\Background.Jpg");
            BackgroundImageLayout = ImageLayout.Stretch;

            Text1 = CreateLabel2("TittleLabel", "Crear Cuenta", new Size(390, 60), 35, new Point(125, 30), this);
            //Text2 = CreateLabel("IDLabel", "ID", new Size(110, 20), new Point(20, 180), this);
            //Text3 = CreateLabel("NameleLabel", "Usuario", new Size(110, 20), new Point(20, 280), this);
            //Text4 = CreateLabel("CarrerleLabel", "Contraseña", new Size(110, 20), new Point(20, 380), this);

            IDBox = CreateTextBox("IDBox", "N.Documento", new Size(320, 35), new Point(155, 310), this);
            UserBox = CreateTextBox("UserBox", "Usuario o correo", new Size(320, 35), new Point(155, 360), this);
            PasswordBox = CreateTextBox("PasswordBox", "Contraseña", new Size(320, 35), new Point(155, 410), this);
            PasswordBox.PasswordChar = '*';

            Create_account_Button = CreateButton("Sing_inbutton", "Registrar", new Size(320, 50), new Point(155, 520), this);
            Cancel_Button = CreateButton("Create_button", "Salir", new Size(320, 50), new Point(155, 570), this); 

            Estudent = CreateRadioButton("Estudent", "Estudiante", new Size(140, 40), new Point(155, 460), this);
            Administrator = CreateRadioButton("Estudent","Administrador", new Size(165, 40), new Point(310, 460), this);

            Modelo.PersonaLoguinData personLoguinData = new Modelo.PersonaLoguinData();
            Controlador.CreateAccount_Controller controller = new Controlador.CreateAccount_Controller(personLoguinData,this);

            Estudent.CheckedChanged += Estudent_CheckedChanged;
            Administrator.CheckedChanged += Administrator_CheckedChanged;
        }

        private void Administrator_CheckedChanged(object? sender, EventArgs e)
        {
            Role = "Administrador";
        }

        private void Estudent_CheckedChanged(object? sender, EventArgs e)
        {
            Role = "Estudiante";
        }

        public Button CreateButton(string name, string text, Size size, Point point, Control padre)
        {
            return new Button()
            {
                Name = name,
                Text = text,
                Size = size,
                Location = point,
                Parent = padre,
                Font = new Font("Book Antiqua", 10),
            };
        }
        public Label CreateLabel2(string name, string text, Size size, int FontSize, Point point, Control padre)
        {
            return new Label()
            {
                Name = name,
                Text = text,
                Size = size,
                Location = point,
                Parent = padre,
                Font = new Font("Book Antiqua", FontSize),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
            };
        }

        public TextBox CreateTextBox(string name, string text, Size size, Point point, Control padre)
        {
            return new TextBox()
            {
                Name = name,
                PlaceholderText = text,
                Size = size,
                Location = point,
                Parent = padre,
                Font = new Font("Book Antiqua", 10),
                Multiline = true

            };
        }

        public Label CreateLabel(string name, string text, Size size, Point point, Control padre)
        {
            return new Label()
            {
                Name = name,
                Text = text,
                Size = size,
                Location = point,
                Parent = padre,
                Font = new Font("Book Antiqua", 12),
            };
        }
        public PictureBox CreatePictureBox(string name, string ruta, Control padre)
        {
            return new PictureBox()
            {
                Name = name,
                Size = new Size(100, 100),
                Location = new Point(260, 175),
                Parent = padre,
                Image = Image.FromFile(ruta),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
            };
        }
        public RadioButton CreateRadioButton(string name, string text, Size size, Point point, Control padre)
        {
            return new RadioButton()
            {
                Name = name,
                Text = text,
                Size = size,
                Location = point,
                Parent = padre,
                Font = new Font("Book Antiqua", 12),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
            };
        }
    }
}
