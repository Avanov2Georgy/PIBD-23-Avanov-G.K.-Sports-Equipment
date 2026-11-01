namespace Sports_Equipment
{
    partial class RentalListForm
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
            DataGridViewRentals = new DataGridView();
            ButtonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRentals).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewRentals
            // 
            DataGridViewRentals.AllowUserToAddRows = false;
            DataGridViewRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewRentals.Location = new Point(27, 24);
            DataGridViewRentals.Name = "DataGridViewRentals";
            DataGridViewRentals.ReadOnly = true;
            DataGridViewRentals.RowHeadersWidth = 51;
            DataGridViewRentals.Size = new Size(501, 213);
            DataGridViewRentals.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(27, 384);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(164, 41);
            ButtonAdd.TabIndex = 1;
            ButtonAdd.Text = "Оформить выдачу";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // RentalListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonAdd);
            Controls.Add(DataGridViewRentals);
            Name = "RentalListForm";
            Text = "RentalListForm";
            ((System.ComponentModel.ISupportInitialize)DataGridViewRentals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewRentals;
        private Button ButtonAdd;
    }
}