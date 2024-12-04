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
    public partial class Administrator : Form
    {

        public Administrator()
        {
            InitializeComponent();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("Background.jpg");
            pictureBox1.BackgroundImage = Image.FromFile("Log out.png");
            View_Questions view_Questions = new View_Questions();
            ResultsData resultsData = new ResultsData();
            View_Results view_Results = new View_Results();
            View_Principal view_Principal = new View_Principal();
            Menu_Controller menu_Controller = new Menu_Controller(view_Results, view_Questions, resultsData, this, view_Principal);

        }

        public void Show_Result_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOla");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        Loguin loguin = new Loguin();
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
          this.Hide();
            loguin.ShowDialog();
            this.Close();
        }
    }
}
