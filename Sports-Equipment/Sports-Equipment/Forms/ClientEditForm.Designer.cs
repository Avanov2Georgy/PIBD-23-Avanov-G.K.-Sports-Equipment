namespace Sports_Equipment.Forms
{
    partial class ClientEditForm
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
            TextBoxFullName = new TextBox();
            TextBoxPhone = new TextBox();
            TextBoxDocument = new TextBox();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 20);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "ФИО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 20);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Телефон:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 20);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Документ:";
            // 
            // TextBoxFullName
            // 
            TextBoxFullName.Location = new Point(12, 67);
            TextBoxFullName.Name = "TextBoxFullName";
            TextBoxFullName.Size = new Size(125, 27);
            TextBoxFullName.TabIndex = 3;
            // 
            // TextBoxPhone
            // 
            TextBoxPhone.Location = new Point(162, 67);
            TextBoxPhone.Name = "TextBoxPhone";
            TextBoxPhone.Size = new Size(125, 27);
            TextBoxPhone.TabIndex = 4;
            // 
            // TextBoxDocument
            // 
            TextBoxDocument.Location = new Point(313, 67);
            TextBoxDocument.Name = "TextBoxDocument";
            TextBoxDocument.Size = new Size(125, 27);
            TextBoxDocument.TabIndex = 5;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(12, 395);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(125, 43);
            ButtonSave.TabIndex = 6;
            ButtonSave.Text = "Сохранить";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(162, 395);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(125, 43);
            ButtonCancel.TabIndex = 7;
            ButtonCancel.Text = "Отмена";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ClientEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(TextBoxDocument);
            Controls.Add(TextBoxPhone);
            Controls.Add(TextBoxFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClientEditForm";
            Text = "ClientEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextBoxFullName;
        private TextBox TextBoxPhone;
        private TextBox TextBoxDocument;
        private Button ButtonSave;
        private Button ButtonCancel;
    }
}