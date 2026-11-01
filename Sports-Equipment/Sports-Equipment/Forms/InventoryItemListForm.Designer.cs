namespace Sports_Equipment
{
    partial class InventoryItemListForm
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
            DataGridViewInventory = new DataGridView();
            ButtonAdd = new Button();
            ButtonEdit = new Button();
            ButtonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInventory).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewInventory
            // 
            DataGridViewInventory.AllowUserToAddRows = false;
            DataGridViewInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewInventory.Location = new Point(12, 34);
            DataGridViewInventory.Name = "DataGridViewInventory";
            DataGridViewInventory.ReadOnly = true;
            DataGridViewInventory.RowHeadersWidth = 51;
            DataGridViewInventory.Size = new Size(508, 221);
            DataGridViewInventory.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(23, 388);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(129, 40);
            ButtonAdd.TabIndex = 1;
            ButtonAdd.Text = "Добавить";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(181, 388);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(128, 40);
            ButtonEdit.TabIndex = 2;
            ButtonEdit.Text = "Редактировать";
            ButtonEdit.UseVisualStyleBackColor = true;
            ButtonEdit.Click += ButtonEdit_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(343, 388);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(119, 40);
            ButtonDelete.TabIndex = 3;
            ButtonDelete.Text = "Удалить";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // InventoryItemListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonEdit);
            Controls.Add(ButtonAdd);
            Controls.Add(DataGridViewInventory);
            Name = "InventoryItemListForm";
            Text = "InventoryItemListForm";
            ((System.ComponentModel.ISupportInitialize)DataGridViewInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewInventory;
        private Button ButtonAdd;
        private Button ButtonEdit;
        private Button ButtonDelete;
    }
}