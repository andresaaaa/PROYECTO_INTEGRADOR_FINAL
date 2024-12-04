
namespace PROYECTO_INTEGRADOR_FINAL.Vista
{
    partial class Administrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            toolStrip3 = new ToolStrip();
            Show_Results = new PictureBox();
            View_Questions = new PictureBox();
            Add = new PictureBox();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Show_Results).BeginInit();
            ((System.ComponentModel.ISupportInitialize)View_Questions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Add).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip3
            // 
            toolStrip3.BackColor = SystemColors.ActiveCaption;
            toolStrip3.ImageScalingSize = new Size(20, 20);
            toolStrip3.Location = new Point(0, 0);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(807, 25);
            toolStrip3.TabIndex = 3;
            toolStrip3.Text = "toolStrip3";
            // 
            // Show_Results
            // 
            Show_Results.BackColor = Color.Transparent;
            Show_Results.BackgroundImageLayout = ImageLayout.None;
            Show_Results.Image = (Image)resources.GetObject("Show_Results.Image");
            Show_Results.Location = new Point(138, 249);
            Show_Results.Name = "Show_Results";
            Show_Results.Size = new Size(125, 62);
            Show_Results.SizeMode = PictureBoxSizeMode.Zoom;
            Show_Results.TabIndex = 5;
            Show_Results.TabStop = false;
            Show_Results.Click += Show_Result_Click;
            // 
            // View_Questions
            // 
            View_Questions.BackColor = Color.Transparent;
            View_Questions.Image = (Image)resources.GetObject("View_Questions.Image");
            View_Questions.Location = new Point(535, 249);
            View_Questions.Name = "View_Questions";
            View_Questions.Size = new Size(125, 62);
            View_Questions.SizeMode = PictureBoxSizeMode.Zoom;
            View_Questions.TabIndex = 9;
            View_Questions.TabStop = false;
            View_Questions.Click += pictureBox7_Click;
            // 
            // Add
            // 
            Add.BackColor = Color.Transparent;
            Add.BackgroundImageLayout = ImageLayout.None;
            Add.Image = (Image)resources.GetObject("Add.Image");
            Add.Location = new Point(333, 249);
            Add.Name = "Add";
            Add.Size = new Size(125, 62);
            Add.SizeMode = PictureBoxSizeMode.Zoom;
            Add.TabIndex = 8;
            Add.TabStop = false;
            Add.Click += pictureBox8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(138, 323);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 12;
            label1.Text = "Ver Resultados";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
            label8.Location = new Point(537, 323);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 16;
            label8.Text = "Ver preguntas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.White;
            label9.Location = new Point(333, 323);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 22;
            label9.Text = "Añadir Persona";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Uighur", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(170, 82);
            label10.Name = "label10";
            label10.Size = new Size(387, 53);
            label10.TabIndex = 24;
            label10.Text = "MENU DE ADMINISTRADOR";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(138, 385);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 450);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 26;
            label2.Text = "Cerrar Sesion";
            // 
            // Administrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(807, 566);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(View_Questions);
            Controls.Add(Add);
            Controls.Add(Show_Results);
            Controls.Add(toolStrip3);
            ForeColor = Color.White;
            Name = "Administrator";
            Text = "Administrator";
            Load += Administrator_Load;
            ((System.ComponentModel.ISupportInitialize)Show_Results).EndInit();
            ((System.ComponentModel.ISupportInitialize)View_Questions).EndInit();
            ((System.ComponentModel.ISupportInitialize)Add).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton nuevoToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton guardarToolStripButton;
        private ToolStripButton imprimirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton cortarToolStripButton;
        private ToolStripButton copiarToolStripButton;
        private ToolStripButton pegarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ayudaToolStripButton;
        private ToolStrip toolStrip2;
        private ToolStrip toolStrip3;
        private Label label1;
        private Label label8;
        private Label label9;
        public PictureBox View_Questions;
        private Label label10;
        public PictureBox Show_Results;
        public PictureBox Add;
        private Label label2;
        public PictureBox pictureBox1;
    }
}