namespace Sports_Equipment.Forms
{
    partial class InventoryItemEditForm
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
            TextBoxName = new TextBox();
            TextBoxSize = new TextBox();
            ComboBoxType = new ComboBox();
            label4 = new Label();
            CheckedListBoxCondition = new CheckedListBox();
            ButtonSave = new Button();
            ButtonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 32);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Размер:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 32);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Тип:";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(12, 76);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(125, 27);
            TextBoxName.TabIndex = 3;
            // 
            // TextBoxSize
            // 
            TextBoxSize.Location = new Point(195, 76);
            TextBoxSize.Name = "TextBoxSize";
            TextBoxSize.Size = new Size(125, 27);
            TextBoxSize.TabIndex = 4;
            // 
            // ComboBoxType
            // 
            ComboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxType.FormattingEnabled = true;
            ComboBoxType.Location = new Point(380, 75);
            ComboBoxType.Name = "ComboBoxType";
            ComboBoxType.Size = new Size(151, 28);
            ComboBoxType.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(616, 32);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 6;
            label4.Text = "Состояние:";
            // 
            // CheckedListBoxCondition
            // 
            CheckedListBoxCondition.FormattingEnabled = true;
            CheckedListBoxCondition.Location = new Point(591, 76);
            CheckedListBoxCondition.Name = "CheckedListBoxCondition";
            CheckedListBoxCondition.Size = new Size(150, 114);
            CheckedListBoxCondition.TabIndex = 7;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(17, 396);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(130, 42);
            ButtonSave.TabIndex = 8;
            ButtonSave.Text = "Сохранить";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(173, 396);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(124, 42);
            ButtonCancel.TabIndex = 9;
            ButtonCancel.Text = "Отмена";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // InventoryItemEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(CheckedListBoxCondition);
            Controls.Add(label4);
            Controls.Add(ComboBoxType);
            Controls.Add(TextBoxSize);
            Controls.Add(TextBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InventoryItemEditForm";
            Text = "InventoryItemEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextBoxName;
        private TextBox TextBoxSize;
        private ComboBox ComboBoxType;
        private Label label4;
        private CheckedListBox CheckedListBoxCondition;
        private Button ButtonSave;
        private Button ButtonCancel;
    }
}