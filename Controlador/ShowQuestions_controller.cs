using PROYECTO_INTEGRADOR_FINAL.Modelo;
using PROYECTO_INTEGRADOR_FINAL.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_INTEGRADOR_FINAL.Controlador
{
    internal class ShowQuestions_controller
    {
        ShowQuestions ShowQuestions;
        View_Questions View_Questions;
        Administrator Administrator;

        public ShowQuestions_controller(ShowQuestions showQuestions, View_Questions view_Questions,Administrator administrator)
        {
            ShowQuestions = showQuestions;
            View_Questions = view_Questions;
            Administrator = administrator;

            view_Questions.Load += View_Questions_Load;
            view_Questions.BackButton.Click+= Back_Click;
        }

        private void Back_Click(object? sender, EventArgs e)
        {
            View_Questions.Hide();
            View_Questions.Close();
        }

        private void View_Questions_Load(object? sender, EventArgs e)
        {
           ShowQuestions.LoadData();
           View_Questions.BindingSource.DataSource = ShowQuestions.Questions;
           View_Questions.ShowDataGrid.DataSource = View_Questions.BindingSource;
           DisplayCounter();
           View_Questions.ShowDataGrid.RowTemplate.Height =1500;
           foreach (DataGridViewColumn columna in View_Questions.ShowDataGrid.Columns)
           {
                columna.Width = 500;
           }





        }
        private void DisplayCounter()
        {
            int total = View_Questions.BindingSource.Count;
            View_Questions.NavegatorBox.Text = $"{Convert.ToString((View_Questions.BindingSource.IndexOf(View_Questions.BindingSource.Current)) + 1)}/{Convert.ToString(total)}";
        }


    }
}
