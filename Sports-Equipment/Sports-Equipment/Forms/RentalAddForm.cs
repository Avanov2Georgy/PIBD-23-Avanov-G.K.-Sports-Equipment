using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports_Equipment.Entities;
using Sports_Equipment.Repositories;

namespace Sports_Equipment.Forms
{
    public partial class RentalAddForm : Form
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly IClientRepository _clientRepository;
        private readonly ITariffRepository _tariffRepository;
        private readonly IInventoryItemRepository _inventoryRepository;

        public RentalAddForm(
            IRentalRepository rentalRepository,
            IClientRepository clientRepository,
            ITariffRepository tariffRepository,
            IInventoryItemRepository inventoryRepository)
        {
            InitializeComponent();
            _rentalRepository = rentalRepository ?? throw new ArgumentNullException(nameof(rentalRepository));
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _tariffRepository = tariffRepository ?? throw new ArgumentNullException(nameof(tariffRepository));
            _inventoryRepository = inventoryRepository ?? throw new ArgumentNullException(nameof(inventoryRepository));

            this.Load += RentalAddForm_Load;
        }

        private void RentalAddForm_Load(object? sender, EventArgs e)
        {
            // 1. Заполняем ComboBox клиентов
            ComboBoxClient.DataSource = _clientRepository.ReadClients();
            ComboBoxClient.DisplayMember = "FullName";
            ComboBoxClient.ValueMember = "Id";

            // 2. Заполняем ComboBox тарифов
            ComboBoxTariff.DataSource = _tariffRepository.ReadTariffs();
            ComboBoxTariff.DisplayMember = "Name";
            ComboBoxTariff.ValueMember = "Id";

            // 3. Настраиваем таблицу для выбора инвентаря
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            DataGridViewItems.Columns.Clear();

            // Создаем колонку с выпадающим списком
            DataGridViewComboBoxColumn inventoryColumn = new DataGridViewComboBoxColumn();
            inventoryColumn.HeaderText = "Инвентарь";
            inventoryColumn.DataSource = _inventoryRepository.ReadInventoryItems();
            inventoryColumn.DisplayMember = "Name"; // Показываем название
            inventoryColumn.ValueMember = "Id";     // Сохраняем ID
            inventoryColumn.Name = "InventoryColumn"; // Имя для доступа из кода

            DataGridViewItems.Columns.Add(inventoryColumn);
        }

        private void ButtonSave_Click(object? sender, EventArgs e)
        {
            try
            {
                // ВАЛИДАЦИЯ
                if (ComboBoxClient.SelectedItem == null)
                    throw new Exception("Не выбран клиент.");

                if (ComboBoxTariff.SelectedItem == null)
                    throw new Exception("Не выбран тариф.");

                if (DataGridViewItems.Rows.Count == 0 || DataGridViewItems.Rows[0].IsNewRow)
                    throw new Exception("Добавьте хотя бы один инвентарь в таблицу.");

                int clientId = (int)ComboBoxClient.SelectedValue!;
                int tariffId = (int)ComboBoxTariff.SelectedValue!;
                DateTime issueDate = DateTimePickerIssue.Value;

                // Собираем список инвентаря (связь многие-ко-многим)
                var rentalItems = new List<RentalItem>();

                foreach (DataGridViewRow row in DataGridViewItems.Rows)
                {
                    if (row.IsNewRow) continue; // Пропускаем пустую последнюю строку

                    var selectedValue = row.Cells["InventoryColumn"].Value;
                    if (selectedValue != null)
                    {
                        int inventoryItemId = (int)selectedValue;
                        // Создаем объект связи (Id=0, RentalId=0, InventoryItemId=выбранный)
                        rentalItems.Add(RentalItem.CreateEntity(0, 0, inventoryItemId));
                    }
                }

                if (rentalItems.Count == 0)
                    throw new Exception("Выберите инвентарь в таблице.");

                // Создаем операцию
                // TotalCost пока ставим 0 
                var rental = Rental.CreateEntity(0, clientId, tariffId, issueDate, null, 0);

                // Прикрепляем список инвентаря к операции
                rental.SetRentalItems(rentalItems);

                // Сохраняем (пока в заглушку)
                _rentalRepository.CreateRental(rental);

                MessageBox.Show("Выдача успешно оформлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
