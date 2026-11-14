using Sports_Equipment.Forms;
using Sports_Equipment.Repositories;
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

namespace Sports_Equipment
{
    public partial class ClientListForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly IClientRepository _clientRepository;

        // Внедряем зависимости через конструктор
        public ClientListForm(IUnityContainer container, IClientRepository clientRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));

            // Программная привязка события загрузки формы
            this.Load += ClientListForm_Load;
        }

        // Метод, который срабатывает при открытии формы
        private void ClientListForm_Load(object? sender, EventArgs e)
        {
            LoadList();
        }

        // Метод для обновления данных в таблице
        private void LoadList()
        {
            DataGridViewClients.DataSource = _clientRepository.ReadClients();

            // Скрываем колонку Id, если она есть
            if (DataGridViewClients.Columns["Id"] != null)
            {
                DataGridViewClients.Columns["Id"].Visible = false;
            }
        }

        // Кнопка "Добавить"
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Открываем форму редактирования через контейнер (в режиме создания)
            _container.Resolve<ClientEditForm>().ShowDialog();
            LoadList(); // Обновляем таблицу после закрытия
        }

        // Кнопка "Редактировать"
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (DataGridViewClients.SelectedRows.Count < 1)
            {
                MessageBox.Show("Пожалуйста, выберите клиента для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем ID выбранной строки
            int id = Convert.ToInt32(DataGridViewClients.SelectedRows[0].Cells["Id"].Value);

            // Открываем форму и передаем в нее ID
            var editForm = _container.Resolve<ClientEditForm>();
            editForm.ClientId = id;
            editForm.ShowDialog();

            LoadList();
        }

        // Кнопка "Удалить"
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (DataGridViewClients.SelectedRows.Count < 1)
            {
                MessageBox.Show("Пожалуйста, выберите клиента для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(DataGridViewClients.SelectedRows[0].Cells["Id"].Value);

            // Спрашиваем подтверждение
            if (MessageBox.Show("Вы уверены, что хотите удалить этого клиента?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _clientRepository.DeleteClient(id);
                LoadList();
            }
        }
    }
}