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
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void Loguin_Load(object sender, EventArgs e)
        {
            Login_Designer login_Designer = new Login_Designer(this);
            Vista.Loguin login = new Vista.Loguin();
            Modelo.PersonaLoguinData loguinData = new Modelo.PersonaLoguinData();
            Controlador.LoguinController loguinController = new Controlador.LoguinController(loguinData, this, login_Designer);
        }
    }
}
