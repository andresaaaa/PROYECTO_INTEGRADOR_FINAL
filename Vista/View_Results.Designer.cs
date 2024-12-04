namespace PROYECTO_INTEGRADOR_FINAL.Vista
{
    partial class View_Results
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
            PersonbindingSource = new BindingSource(components);
            ShowDataGrid = new DataGridView();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PersonbindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShowDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ShowDataGrid
            // 
            ShowDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowDataGrid.Location = new Point(42, 25);
            ShowDataGrid.Name = "ShowDataGrid";
            ShowDataGrid.RowHeadersWidth = 51;
            ShowDataGrid.Size = new Size(968, 377);
            ShowDataGrid.TabIndex = 0;
            ShowDataGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(42, 445);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(125, 62);
            BackButton.TabIndex = 32;
            BackButton.TabStop = false;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // View_Results
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 562);
            Controls.Add(BackButton);
            Controls.Add(ShowDataGrid);
            Name = "View_Results";
            Text = "View_Results";
            Load += View_Results_Load;
            ((System.ComponentModel.ISupportInitialize)PersonbindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShowDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView ShowDataGrid;
        public BindingSource PersonbindingSource;
        public Button BackButton;
        public Button Edit_Button;
        public Button Delete_Button;
        public Button Sync_Button;
    }
}