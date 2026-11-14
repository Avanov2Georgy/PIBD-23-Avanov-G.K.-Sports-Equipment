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
        private readonly IUnityContainer _container; // IoC-контейнер для создания формы добавления выдачи
        private readonly IRentalRepository _rentalRepository;  // Репозиторий операций

        // Конструктор с внедрением зависимостей.
        public RentalListForm(IUnityContainer container, IRentalRepository rentalRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _rentalRepository = rentalRepository ?? throw new ArgumentNullException(nameof(rentalRepository));

            this.Load += RentalListForm_Load; // Программная привязка события загрузки
        }

        private void RentalListForm_Load(object? sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList() // Обновление данных в таблице из репозитория.
        {
            DataGridViewRentals.DataSource = _rentalRepository.ReadRentals();

            // Скрываем служебные колонки (Id и внешние ключи), чтобы пользователь видел только понятные данные
            if (DataGridViewRentals.Columns["Id"] != null) DataGridViewRentals.Columns["Id"].Visible = false;
            if (DataGridViewRentals.Columns["ClientId"] != null) DataGridViewRentals.Columns["ClientId"].Visible = false;
            if (DataGridViewRentals.Columns["TariffId"] != null) DataGridViewRentals.Columns["TariffId"].Visible = false;
            if (DataGridViewRentals.Columns["RentalItems"] != null) DataGridViewRentals.Columns["RentalItems"].Visible = false;
        }

        private void ButtonAdd_Click(object? sender, EventArgs e) //форма добавления
        {
            _container.Resolve<RentalAddForm>().ShowDialog(); // Контейнер сам создаст RentalAddForm и внедрит в неё все 4 репозитория
            LoadList(); // Обновляем список после закрытия формы
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (DataGridViewRentals.SelectedRows.Count < 1)
            {
                MessageBox.Show("Пожалуйста, выберите выдачу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(DataGridViewRentals.SelectedRows[0].Cells["Id"].Value);

            if (MessageBox.Show("Вы уверены, что хотите удалить эту выдачу?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _rentalRepository.DeleteRental(id);
                LoadList();
            }
        }
    }
}
