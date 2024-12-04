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
    public partial class View_Results : Form
    {


        public TextBox NavegatorBox { get; set; }
        public Label LabelText { get; set; }
        public PictureBox EditPicturePicBox { get; set; }
        public PictureBox DeletePicturePicBox { get; set; }
        public PictureBox UpdatePicturePicBox { get; set; }
        public View_Results()
        {
            InitializeComponent();
            CreateComponents();
     

            NavegatorBox = CreateTextBox("NavegationBox", new Size(80, 40), new Point(150, 480), this);

            ResultsData resultsData = new ResultsData();
            Administrator administrator = new Administrator();
            Show_PersonalDates show_PersonalDates = new Show_PersonalDates(resultsData, this, administrator);

        }

        private void View_Results_Load(object sender, EventArgs e)
        {

        }

        private void CreateComponents()
        {
            //ShowDataGrid = CreateDataGruidView("ShowDataGrid", new System.Drawing.Size(800, 300), new System.Drawing.Point(20, 20), this);
        }

        //public DataGridView CreateDataGruidView(string name, Size size, Point point, Control padre)
        //{
        //    DataGridView gridView = new DataGridView()
        //    {
        //        ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize,
        //        Location = point,
        //        Name = "dataGridView1",
        //        RowHeadersWidth = 51,
        //        AutoGenerateColumns = true,
        //        Size = size,
        //        Parent = padre,
        //        ReadOnly = true,
        //    };
        //    gridView.RowTemplate.Height = 24;

        //    return gridView;
        //}
        public TextBox CreateTextBox(string name, Size size, Point point, Control padre)
        {
            return new TextBox()
            {
                Name = name,
                Location = point,
                Parent = padre,
                Font = new Font("Book Antiqua", 10),
                Multiline = true,
                ReadOnly = true

            };
        }
        public PictureBox CreatePictureBox(string name, Size size, Point point, Control padre)
        {
            return new PictureBox()
            {
                Name = name,
                Location = point,
                Parent = padre,
                Font = new Font("Book Antiqua", 10),

            };
        }

        public Label CreateLabel(string name, string text, Size size, Point point, Control padre)
        {
            return new Label()
            {
                Name = name,
                Text = text,
                Location = point,
                Parent = padre,
                Font = new Font("Book Antiqua", 10),
            };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void Save_Dates_Click(object sender, EventArgs e)
        {

        }
        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Dates_Click(object sender, EventArgs e)
        {

        }
    }
}
