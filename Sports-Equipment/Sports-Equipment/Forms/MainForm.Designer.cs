namespace Sports_Equipment.Forms
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            DirectoriesToolStripMenuItem = new ToolStripMenuItem();
            ClientsToolStripMenuItem = new ToolStripMenuItem();
            TariffsToolStripMenuItem = new ToolStripMenuItem();
            InventoryToolStripMenuItem = new ToolStripMenuItem();
            OperationsToolStripMenuItem = new ToolStripMenuItem();
            RentalsToolStripMenuItem = new ToolStripMenuItem();
            ReportsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { DirectoriesToolStripMenuItem, OperationsToolStripMenuItem, ReportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(861, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // DirectoriesToolStripMenuItem
            // 
            DirectoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ClientsToolStripMenuItem, TariffsToolStripMenuItem, InventoryToolStripMenuItem });
            DirectoriesToolStripMenuItem.Name = "DirectoriesToolStripMenuItem";
            DirectoriesToolStripMenuItem.Size = new Size(117, 24);
            DirectoriesToolStripMenuItem.Text = "Справочники";
            // 
            // ClientsToolStripMenuItem
            // 
            ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            ClientsToolStripMenuItem.Size = new Size(168, 26);
            ClientsToolStripMenuItem.Text = "Клиенты";
            ClientsToolStripMenuItem.Click += ClientsToolStripMenuItem_Click;
            // 
            // TariffsToolStripMenuItem
            // 
            TariffsToolStripMenuItem.Name = "TariffsToolStripMenuItem";
            TariffsToolStripMenuItem.Size = new Size(168, 26);
            TariffsToolStripMenuItem.Text = "Тарифы";
            TariffsToolStripMenuItem.Click += TariffsToolStripMenuItem_Click;
            // 
            // InventoryToolStripMenuItem
            // 
            InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem";
            InventoryToolStripMenuItem.Size = new Size(168, 26);
            InventoryToolStripMenuItem.Text = "Инвентарь";
            InventoryToolStripMenuItem.Click += InventoryToolStripMenuItem_Click;
            // 
            // OperationsToolStripMenuItem
            // 
            OperationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RentalsToolStripMenuItem });
            OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem";
            OperationsToolStripMenuItem.Size = new Size(95, 24);
            OperationsToolStripMenuItem.Text = "Операции";
            // 
            // RentalsToolStripMenuItem
            // 
            RentalsToolStripMenuItem.Name = "RentalsToolStripMenuItem";
            RentalsToolStripMenuItem.Size = new Size(222, 26);
            RentalsToolStripMenuItem.Text = "Выдача инвентаря";
            RentalsToolStripMenuItem.Click += RentalsToolStripMenuItem_Click;
            // 
            // ReportsToolStripMenuItem
            // 
            ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            ReportsToolStripMenuItem.Size = new Size(73, 24);
            ReportsToolStripMenuItem.Text = "Отчеты";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 504);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учет проката спортинвентаря";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem DirectoriesToolStripMenuItem;
        private ToolStripMenuItem ClientsToolStripMenuItem;
        private ToolStripMenuItem TariffsToolStripMenuItem;
        private ToolStripMenuItem InventoryToolStripMenuItem;
        private ToolStripMenuItem OperationsToolStripMenuItem;
        private ToolStripMenuItem RentalsToolStripMenuItem;
        private ToolStripMenuItem ReportsToolStripMenuItem;
    }
}