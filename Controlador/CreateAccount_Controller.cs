using PROYECTO_INTEGRADOR_FINAL.Modelo;
using PROYECTO_INTEGRADOR_FINAL.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INTEGRADOR_FINAL.Controlador
{
    internal class CreateAccount_Controller
    {

        PersonaLoguinData PersonLoguinData;
        CreateAccount CreateAccount;
        public static List<PersonaLoguinData> List;

        public CreateAccount_Controller(PersonaLoguinData personLoguinData, CreateAccount createAccount)
        {
            PersonLoguinData = personLoguinData;
            CreateAccount = createAccount;

            PersonLoguinData.Sync();
            List = PersonaLoguinData.List;

            CreateAccount.Cancel_Button.Click += Cancel_Button_Click;
            CreateAccount.Create_account_Button.Click += Create_account_Button_Click;
        }

        private void Create_account_Button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CreateAccount.IDBox.Text);
            string username = CreateAccount.UserBox.Text;
            string password = CreateAccount.PasswordBox.Text;
            string role = CreateAccount.Role;


            bool exists = List.Any(p => p.ID == id || p.User.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (exists)
            {
                MessageBox.Show("El usuario o ID ya existe. Por favor, utiliza un ID o nombre de usuario diferente.",
                                "Error al crear cuenta",
                                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {

                PersonaLoguinData person = new PersonaLoguinData(id, username, password,role);
                person.add();
                MessageBox.Show("¡Cuenta creada exitosamente!", "Cuenta creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            CreateAccount.Close();
        }
    }
}
