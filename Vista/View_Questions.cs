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
    public partial class View_Questions : Form
    {
        public BindingSource BindingSource { get; set; }
        public TextBox NavegatorBox { get; set; }
        public View_Questions()
        {
           
            InitializeComponent();
            BindingSource = new BindingSource();
            NavegatorBox = new TextBox();


            ShowQuestions showQuestions = new ShowQuestions();
            Administrator administrator = new Administrator();
            ShowQuestions_controller showQuestions_Controller = new ShowQuestions_controller(showQuestions, this,administrator);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void View_Questions_Load(object sender, EventArgs e)
        {

        }

        private void Update_Questions_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {

        }
    }
}
