using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INTEGRADOR_FINAL.Vista
{
    internal class Login_Designer 
    {
        public TextBox UserBox { get; set; }
        public TextBox PasswordBox { get; set; }
        public TextBox IDBox { get; set; }
        public string Role { get; set; }
        public RadioButton Estudent { get; set; }
        public RadioButton Administrator { get; set; }
        public Button Sing_in_Button { get; set; }
        public Button Register_account_Button { get; set; }
        public Label Text1 { get; set; }
        public Label Text5 { get; set; }
        public PictureBox BackGround { get; set; }
        public ErrorProvider ErrorProvider {  get; set; }



        public Login_Designer(Control padre)
        {
            ErrorProvider = new ErrorProvider();
            BackGround = CreatePictureBox("Background", "User.png", padre);
            padre.BackgroundImage = System.Drawing.Image.FromFile("BackGround.jpg");
            padre.BackgroundImageLayout = ImageLayout.Stretch;

            Text1 = CreateLabel2("TittleLabel", "INICIAR SESION", new Size(560, 60), 35, new Point(95, 30), padre);
            Text5 = CreateLabel("SubTittle", "Bienvenido al registro de datos", new Size(210, 20), 10, new Point(205, 110), padre);

            IDBox = CreateTextBox("IDBox", "N.Documento", new Size(320, 35), new Point(155, 310), padre);
            UserBox = CreateTextBox("UserBox", "Usuario o correo", new Size(320, 35), new Point(155, 360), padre);
            PasswordBox = CreateTextBox("PasswordBox", "Contraseña", new Size(320, 35), new Point(155, 410), padre);
            PasswordBox.PasswordChar = '*';

            Sing_in_Button = CreateButton("Sing_inbutton", "INICIAR", new Size(320, 50), new Point(155, 470), padre);
            Register_account_Button = CreateButton("Create_button", "REGISTRAR", new Size(320, 50), new Point(155, 520), padre);

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
                BackColor = Color.Transparent,
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
        public Label CreateLabel(string name, string text, Size size, int FontSize, Point point, Control padre)
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
        public PictureBox CreatePictureBox(string name, string ruta, Control padre)
        {
            return new PictureBox()
            {
                Name = name,
                Size = new Size(100, 100),
                Location = new Point(260, 175),
                Parent = padre,
                Image = System.Drawing.Image.FromFile(ruta),
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
