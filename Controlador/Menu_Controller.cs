using PROYECTO_INTEGRADOR_FINAL.Modelo;
using PROYECTO_INTEGRADOR_FINAL.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;

namespace PROYECTO_INTEGRADOR_FINAL.Controlador
{
    internal class Menu_Controller
    {
        Administrator administrator_View;
        View_Results View_Results;
        View_Questions View_Questions;
        ResultsData ResultsData;
        View_Principal View_Principal;
        
        
        public Menu_Controller(View_Results view_Results,View_Questions view_Questions, ResultsData resultsData, Administrator administrator_View,View_Principal view_Principal)
        {
            View_Results = view_Results;
            ResultsData = resultsData;
            View_Principal = view_Principal;


            administrator_View.Show_Results.Click += Show_Results_Click;
            administrator_View.View_Questions.Click += View_Questions_Click;
            administrator_View.Add.Click += Add_Click;
            administrator_View.pictureBox1.Click += PictureBox1_Click;
        }

        private void PictureBox1_Click(object? sender, EventArgs e)
        {
     
          
        
        }

        private void Add_Click(object? sender, EventArgs e)
        {
            View_Principal view_Principal =new View_Principal();
            view_Principal.ShowDialog();
            
        }

        private void View_Questions_Click(object? sender, EventArgs e)
        {
            View_Questions view_Questions = new View_Questions();
            view_Questions.ShowDialog();

        }

        private void Show_Results_Click(object? sender, EventArgs e)
        {
            View_Results view_Results = new View_Results();
            view_Results.ShowDialog();
        }
    }
}
