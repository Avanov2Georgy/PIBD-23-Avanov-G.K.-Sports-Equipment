using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Sports_Equipment.Forms
{
    public partial class MainForm : Form
    {
        private readonly IUnityContainer _container;

        // Внедряем контейнер через конструктор
        public MainForm(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        // Клик по меню "Клиенты"
        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<ClientListForm>().ShowDialog();
        }

        // Клик по меню "Тарифы"
        private void TariffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<TariffListForm>().ShowDialog();
        }

        // Клик по меню "Инвентарь"
        private void InventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<InventoryItemListForm>().ShowDialog();
        }

        // Клик по меню "Выдача инвентаря"
        private void RentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<RentalListForm>().ShowDialog();
        }
    }
}
