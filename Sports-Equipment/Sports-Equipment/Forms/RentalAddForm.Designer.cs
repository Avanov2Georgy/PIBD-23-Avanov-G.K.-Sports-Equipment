namespace Sports_Equipment.Forms
{
    partial class RentalAddForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ComboBoxClient = new ComboBox();
            ComboBoxTariff = new ComboBox();
            DateTimePickerIssue = new DateTimePicker();
            DataGridViewItems = new DataGridView();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 36);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Клиент:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 36);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Тариф:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 36);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Дата выдачи:";
            // 
            // ComboBoxClient
            // 
            ComboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxClient.FormattingEnabled = true;
            ComboBoxClient.Location = new Point(12, 73);
            ComboBoxClient.Name = "ComboBoxClient";
            ComboBoxClient.Size = new Size(151, 28);
            ComboBoxClient.TabIndex = 3;
            // 
            // ComboBoxTariff
            // 
            ComboBoxTariff.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTariff.FormattingEnabled = true;
            ComboBoxTariff.Location = new Point(222, 73);
            ComboBoxTariff.Name = "ComboBoxTariff";
            ComboBoxTariff.Size = new Size(151, 28);
            ComboBoxTariff.TabIndex = 4;
            // 
            // DateTimePickerIssue
            // 
            DateTimePickerIssue.Location = new Point(417, 74);
            DateTimePickerIssue.Name = "DateTimePickerIssue";
            DateTimePickerIssue.Size = new Size(250, 27);
            DateTimePickerIssue.TabIndex = 5;
            // 
            // DataGridViewItems
            // 
            DataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewItems.Location = new Point(12, 140);
            DataGridViewItems.Name = "DataGridViewItems";
            DataGridViewItems.RowHeadersWidth = 51;
            DataGridViewItems.Size = new Size(662, 227);
            DataGridViewItems.TabIndex = 6;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(21, 396);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(129, 42);
            ButtonSave.TabIndex = 7;
            ButtonSave.Text = "Сохранить";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(176, 396);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(126, 42);
            ButtonCancel.TabIndex = 8;
            ButtonCancel.Text = "Отмена";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // RentalAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(DataGridViewItems);
            Controls.Add(DateTimePickerIssue);
            Controls.Add(ComboBoxTariff);
            Controls.Add(ComboBoxClient);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RentalAddForm";
            Text = "RentalAddForm";
            ((System.ComponentModel.ISupportInitialize)DataGridViewItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox ComboBoxClient;
        private ComboBox ComboBoxTariff;
        private DateTimePicker DateTimePickerIssue;
        private DataGridView DataGridViewItems;
        private Button ButtonSave;
        private Button ButtonCancel;
    }
}