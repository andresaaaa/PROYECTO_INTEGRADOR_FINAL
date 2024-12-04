using PROYECTO_INTEGRADOR_FINAL.Modelo;
using PROYECTO_INTEGRADOR_FINAL.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INTEGRADOR_FINAL.Controlador
{
    internal class Show_PersonalDates
    {
        ResultsData ResultsData;
        View_Results View_Results;
        Administrator Administrator_View;

        public Show_PersonalDates(ResultsData resultsData, View_Results view_Results, Administrator administrator_View)
        {
            ResultsData = resultsData;
            View_Results = view_Results;
            Administrator_View = administrator_View;
            view_Results.Load += View_Results_Load;
            view_Results.BackButton.Click += Back_Click;
            
        }
        private void Back_Click(object? sender, EventArgs e)
        {
            View_Results.Hide();
            View_Results.Close();

        }
        private void View_Results_Load(object? sender, EventArgs e)
        {
            ResultsData.LoadData();

            View_Results.PersonbindingSource.DataSource = ResultsData.Information;
            View_Results.ShowDataGrid.DataSource = View_Results.PersonbindingSource;

            DisplayCounter();
        }

        private void DisplayCounter()
        {
            int total = View_Results.PersonbindingSource.Count;
            View_Results.NavegatorBox.Text = $"{Convert.ToString((View_Results.PersonbindingSource.IndexOf(View_Results.PersonbindingSource.Current)) + 1)}/{Convert.ToString(total)}";
        }
    }
}
