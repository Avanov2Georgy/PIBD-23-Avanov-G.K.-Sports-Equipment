namespace Sports_Equipment.Forms
{
    partial class TariffEditForm
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
            TextBoxName = new TextBox();
            label2 = new Label();
            NumericUpDownPrice = new NumericUpDown();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(12, 61);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(125, 27);
            TextBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 27);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Цена:";
            // 
            // NumericUpDownPrice
            // 
            NumericUpDownPrice.DecimalPlaces = 2;
            NumericUpDownPrice.Location = new Point(199, 62);
            NumericUpDownPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumericUpDownPrice.Name = "NumericUpDownPrice";
            NumericUpDownPrice.Size = new Size(150, 27);
            NumericUpDownPrice.TabIndex = 3;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(20, 388);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(117, 38);
            ButtonSave.TabIndex = 4;
            ButtonSave.Text = "Сохранить";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(172, 388);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(121, 38);
            ButtonCancel.TabIndex = 5;
            ButtonCancel.Text = "Отмена";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // TariffEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(NumericUpDownPrice);
            Controls.Add(label2);
            Controls.Add(TextBoxName);
            Controls.Add(label1);
            Name = "TariffEditForm";
            Text = "TariffEditForm";
            ((System.ComponentModel.ISupportInitialize)NumericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxName;
        private Label label2;
        private NumericUpDown NumericUpDownPrice;
        private Button ButtonSave;
        private Button ButtonCancel;
    }
}