using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports_Equipment.Forms;
using Sports_Equipment.Repositories;
using Unity;

namespace Sports_Equipment
{
    public partial class RentalListForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly IRentalRepository _rentalRepository;

        public RentalListForm(IUnityContainer container, IRentalRepository rentalRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _rentalRepository = rentalRepository ?? throw new ArgumentNullException(nameof(rentalRepository));

            this.Load += RentalListForm_Load;
        }

        private void RentalListForm_Load(object? sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            DataGridViewRentals.DataSource = _rentalRepository.ReadRentals();

            // Скрываем служебные колонки
            if (DataGridViewRentals.Columns["Id"] != null) DataGridViewRentals.Columns["Id"].Visible = false;
            if (DataGridViewRentals.Columns["ClientId"] != null) DataGridViewRentals.Columns["ClientId"].Visible = false;
            if (DataGridViewRentals.Columns["TariffId"] != null) DataGridViewRentals.Columns["TariffId"].Visible = false;
            if (DataGridViewRentals.Columns["RentalItems"] != null) DataGridViewRentals.Columns["RentalItems"].Visible = false;
        }

        private void ButtonAdd_Click(object? sender, EventArgs e)
        {
            _container.Resolve<RentalAddForm>().ShowDialog();
            LoadList();
        }
    }
}
