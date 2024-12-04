
namespace PROYECTO_INTEGRADOR_FINAL.Vista
{
    partial class View_Questions
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
            components = new System.ComponentModel.Container();
            ShowDataGrid = new DataGridView();
            QuestionbindingSource = new BindingSource(components);
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ShowDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuestionbindingSource).BeginInit();
            SuspendLayout();
            // 
            // ShowDataGrid
            // 
            ShowDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowDataGrid.Location = new Point(44, 27);
            ShowDataGrid.Name = "ShowDataGrid";
            ShowDataGrid.RowHeadersWidth = 50;
            ShowDataGrid.Size = new Size(968, 377);
            ShowDataGrid.TabIndex = 1;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(44, 465);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(125, 62);
            BackButton.TabIndex = 36;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // View_Questions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 581);
            Controls.Add(BackButton);
            Controls.Add(ShowDataGrid);
            Name = "View_Questions";
            Text = "View_Questions";
            Load += View_Questions_Load;
            ((System.ComponentModel.ISupportInitialize)ShowDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuestionbindingSource).EndInit();
            ResumeLayout(false);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        public DataGridView ShowDataGrid;
        private BindingSource QuestionbindingSource;
        public Button Sync_Button;
        public Button Delete_Button;
        public Button Edit_Button;
        public Button BackButton;
        public Button Add_Questions;
    }
}