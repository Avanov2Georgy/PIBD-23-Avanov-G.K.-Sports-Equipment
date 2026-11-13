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
    public partial class InventoryItemListForm : Form
    {
        private readonly IUnityContainer _container; // IoC-контейнер для создания других форм
        private readonly IInventoryItemRepository _inventoryRepository; // Репозиторий для работы с данными инвентаря 

        // Конструктор с внедрением зависимостей (IoC-контейнер и репозиторий).
        public InventoryItemListForm(IUnityContainer container, IInventoryItemRepository inventoryRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _inventoryRepository = inventoryRepository ?? throw new ArgumentNullException(nameof(inventoryRepository));

            this.Load += InventoryItemListForm_Load; // Программная привязка события загрузки формы
        }

        // Заполняем таблицу данными.
        private void InventoryItemListForm_Load(object? sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList() // Метод обновления данных в DataGridView.
        {
            DataGridViewInventory.DataSource = _inventoryRepository.ReadInventoryItems(); // Привязываем данные из репозитория (заглушки) к таблице

            if (DataGridViewInventory.Columns["Id"] != null)  // Скрываем колонку Id (первичный ключ), чтобы не путать пользователя
                DataGridViewInventory.Columns["Id"].Visible = false;
        }

        private void ButtonAdd_Click(object? sender, EventArgs e) //добавляем
        {
            _container.Resolve<InventoryItemEditForm>().ShowDialog(); // Контейнер сам создает форму и внедряет в нее зависимости
            LoadList(); // Обновляем таблицу после закрытия формы
        }

        private void ButtonEdit_Click(object? sender, EventArgs e) //редактируем
        {
            if (DataGridViewInventory.SelectedRows.Count < 1) // Проверка: выбрана ли строка в таблице
            {
                MessageBox.Show("Пожалуйста, выберите инвентарь для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(DataGridViewInventory.SelectedRows[0].Cells["Id"].Value); // Получаем ID выбранной строки

            // Открываем форму редактирования и передаем туда ID
            var editForm = _container.Resolve<InventoryItemEditForm>();
            editForm.InventoryItemId = id;
            editForm.ShowDialog();

            LoadList(); // Обновляем таблицу после закрытия
        }

        private void ButtonDelete_Click(object? sender, EventArgs e)
        {
            if (DataGridViewInventory.SelectedRows.Count < 1) // Проверка: выбрана ли строка
            {
                MessageBox.Show("Пожалуйста, выберите инвентарь для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(DataGridViewInventory.SelectedRows[0].Cells["Id"].Value);

            // Запрос подтверждения удаления
            if (MessageBox.Show("Вы уверены, что хотите удалить этот инвентарь?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _inventoryRepository.DeleteInventoryItem(id);
                LoadList(); // Обновляем таблицу после удаления
            }
        }
    }
}