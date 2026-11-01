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
    public partial class ClientEditForm : Form
    {
        private readonly IClientRepository _clientRepository;

        // Если null - создаем нового, если есть число - редактируем
        private int? _clientId;

        // Внедряем репозиторий через конструктор
        public ClientEditForm(IClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
        }

        // Свойство, которое мы вызываем из ClientListForm
        public int ClientId
        {
            set
            {
                _clientId = value;
                LoadClientData(value);
            }
        }

        // Заполняем поля данными при редактировании
        private void LoadClientData(int id)
        {
            var client = _clientRepository.ReadClientById(id);
            if (client != null)
            {
                TextBoxFullName.Text = client.FullName;
                TextBoxPhone.Text = client.Phone;
                TextBoxDocument.Text = client.Document;
            }
        }

        // Кнопка "Сохранить"
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // ПРОВЕРКА НА ПУСТЫЕ ПОЛЯ 
                if (string.IsNullOrWhiteSpace(TextBoxFullName.Text) ||
                    string.IsNullOrWhiteSpace(TextBoxPhone.Text) ||
                    string.IsNullOrWhiteSpace(TextBoxDocument.Text))
                {
                    throw new Exception("Заполните все поля!");
                }

                // Если ID нет - передаем 0 (создание). Если есть - передаем ID (редактирование).
                int currentId = _clientId ?? 0;

                // Создаем объект через статический метод
                var client = Client.CreateEntity(currentId, TextBoxFullName.Text, TextBoxPhone.Text, TextBoxDocument.Text);

                if (_clientId.HasValue)
                {
                    _clientRepository.UpdateClient(client);
                }
                else
                {
                    _clientRepository.CreateClient(client);
                }

                // Закрываем форму после сохранения
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка "Отмена"
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}