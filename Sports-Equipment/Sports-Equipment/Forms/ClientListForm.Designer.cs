namespace Sports_Equipment
{
    partial class ClientListForm
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
            DataGridViewClients = new DataGridView();
            ButtonAdd = new Button();
            ButtonEdit = new Button();
            ButtonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewClients
            // 
            DataGridViewClients.AllowUserToAddRows = false;
            DataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewClients.Location = new Point(12, 12);
            DataGridViewClients.Name = "DataGridViewClients";
            DataGridViewClients.ReadOnly = true;
            DataGridViewClients.RowHeadersWidth = 51;
            DataGridViewClients.Size = new Size(518, 206);
            DataGridViewClients.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(12, 396);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(130, 42);
            ButtonAdd.TabIndex = 1;
            ButtonAdd.Text = "Добавить";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(161, 396);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(144, 42);
            ButtonEdit.TabIndex = 2;
            ButtonEdit.Text = "Редактировать";
            ButtonEdit.UseVisualStyleBackColor = true;
            ButtonEdit.Click += ButtonEdit_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(336, 396);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(132, 42);
            ButtonDelete.TabIndex = 3;
            ButtonDelete.Text = "Удалить";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ClientListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonEdit);
            Controls.Add(ButtonAdd);
            Controls.Add(DataGridViewClients);
            Name = "ClientListForm";
            Text = "ClientListForm";
            ((System.ComponentModel.ISupportInitialize)DataGridViewClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewClients;
        private Button ButtonAdd;
        private Button ButtonEdit;
        private Button ButtonDelete;
    }
}