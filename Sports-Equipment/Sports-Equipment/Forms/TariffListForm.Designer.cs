namespace Sports_Equipment
{
    partial class TariffListForm
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
            DataGridViewTariffs = new DataGridView();
            ButtonAdd = new Button();
            ButtonEdit = new Button();
            ButtonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTariffs).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewTariffs
            // 
            DataGridViewTariffs.AllowUserToAddRows = false;
            DataGridViewTariffs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTariffs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTariffs.Location = new Point(12, 12);
            DataGridViewTariffs.Name = "DataGridViewTariffs";
            DataGridViewTariffs.ReadOnly = true;
            DataGridViewTariffs.RowHeadersWidth = 51;
            DataGridViewTariffs.Size = new Size(520, 230);
            DataGridViewTariffs.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(12, 400);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(135, 38);
            ButtonAdd.TabIndex = 1;
            ButtonAdd.Text = "Добавить";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(176, 400);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(132, 38);
            ButtonEdit.TabIndex = 2;
            ButtonEdit.Text = "Редактировать";
            ButtonEdit.UseVisualStyleBackColor = true;
            ButtonEdit.Click += ButtonEdit_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(343, 400);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(120, 38);
            ButtonDelete.TabIndex = 3;
            ButtonDelete.Text = "Удалить";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // TariffListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonEdit);
            Controls.Add(ButtonAdd);
            Controls.Add(DataGridViewTariffs);
            Name = "TariffListForm";
            Text = "TariffListForm";
            ((System.ComponentModel.ISupportInitialize)DataGridViewTariffs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewTariffs;
        private Button ButtonAdd;
        private Button ButtonEdit;
        private Button ButtonDelete;
    }
}