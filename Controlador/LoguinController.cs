using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using PROYECTO_INTEGRADOR_FINAL.Modelo;
using PROYECTO_INTEGRADOR_FINAL.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_INTEGRADOR_FINAL.Controlador
{
    internal class LoguinController
    {
        PersonaLoguinData Data;
        Vista.Loguin Login;
        Vista.Login_Designer Designer;
        View_Principal Formulario = new View_Principal();
        Administrator Administrator = new Administrator();
        public static List<PersonaLoguinData> List = new List<PersonaLoguinData>();
        public static bool check = true;

        public LoguinController(PersonaLoguinData loguinData, Loguin login, Login_Designer designer)
        {
            Data = loguinData;
            Login = login;
            Designer = designer;

            Data.Sync();
            List = PersonaLoguinData.List;

            //UserText = Designer.UserBox.Text;
            //PasswordText = Designer.PasswordBox.Text;
            Designer.Sing_in_Button.Click += Sing_in_Button_Click;
            Designer.Register_account_Button.Click += Register_account_Button_Click;

        }

        private void Register_account_Button_Click(object sender, EventArgs e)
        {

            CreateAccount CreateAccount = new CreateAccount();
            CreateAccount.Show();

        }

        private void Sing_in_Button_Click(object sender, EventArgs e)
        {
            CreateAccount CreateAccount = new CreateAccount();
            try
            {

                int ID = Convert.ToInt32(Designer.IDBox.Text.Trim());
                string User = Designer.UserBox.Text.Trim();
                string Password = Designer.PasswordBox.Text.Trim();
                Data.Sync();

                bool userFound = false;

                foreach (var item in List)
                {
                    if (item.ID == ID && item.User == User && item.Password == Password && item.Role == "Estudiante")
                    {
                        userFound = true;
                        if (true)
                        {
                            MessageBox.Show($"¡Bienvenido, {User}!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login.Hide();
                            Formulario.ShowDialog();
                            Login.Close();

                            break;
                        }

                    }
                    else if (item.ID == ID && item.User == User && item.Password == Password && item.Role == "Administrador")
                    {
                        userFound = true;
                        if (true)
                        {
                            MessageBox.Show($"¡Bienvenido, {User}!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Login.Hide();
                            Administrator.ShowDialog();
                            Login.Close();
                            check = true;

                            break;
                        }
                    }
                }
                if (!userFound)
                {
                    MessageBox.Show("ID, usuario o contraseña incorrectos. Por favor, inténtalo nuevamente.", "Inicio de sesión fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                VerifyError();
            }


        }

        public void VerifyError() 
        {
           
            ErrorProvider errorProvider = Designer.ErrorProvider;


            if (string.IsNullOrWhiteSpace(Designer.UserBox.Text) )
            {
                errorProvider.SetError(Designer.UserBox, "llenar el espacio.");
                return;
            }
            else if (Regex.IsMatch(Designer.UserBox.Text, @"\d"))
            {
                errorProvider.SetError(Designer.UserBox, "El ID debe ser un número entero válido.");
                return;
            }
            else
            {
                errorProvider.SetError(Designer.UserBox, "");
            }


            if (string.IsNullOrWhiteSpace(Designer.IDBox.Text))
            {
                errorProvider.SetError(Designer.IDBox, "llenar el espacio.");
                return; 
            }else if (!int.TryParse(Designer.IDBox.Text.Trim(), out _))
            {
                errorProvider.SetError(Designer.IDBox, "El ID debe ser un número entero válido.");
                return;
            }
            else
            {
                errorProvider.SetError(Designer.IDBox, "");
            }


            if (string.IsNullOrWhiteSpace(Designer.PasswordBox.Text))
            {
                errorProvider.SetError(Designer.PasswordBox, "llenar el espacio.");
                return;
            }
            else
            {
                errorProvider.SetError(Designer.PasswordBox, "");
            }

        }
    }
}
