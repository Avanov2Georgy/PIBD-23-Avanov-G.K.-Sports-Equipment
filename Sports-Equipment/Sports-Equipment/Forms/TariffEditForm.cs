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
    public partial class TariffEditForm : Form
    {
        private readonly ITariffRepository _tariffRepository; // Внедрение репозитория через конструктор
        private int? _tariffId; // Хранит ID редактируемой записи. Если null — создается новая запись.

        public TariffEditForm(ITariffRepository tariffRepository)
        {
            InitializeComponent();
            _tariffRepository = tariffRepository ?? throw new ArgumentNullException(nameof(tariffRepository));
        }

        public int TariffId // Свойство для передачи ID из формы списка при редактировании.
        {
            set
            {
                _tariffId = value;
                LoadTariffData(value);
            }
        }

        private void LoadTariffData(int id) // Загрузка данных тарифа в поля формы при редактировании.
        {
            var tariff = _tariffRepository.ReadTariffById(id);
            if (tariff != null)
            {
                TextBoxName.Text = tariff.Name;
                NumericUpDownPrice.Value = tariff.Price;
            }
        }

        private void ButtonSave_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TextBoxName.Text)) // Валидация
                {
                    throw new Exception("Название тарифа не может быть пустым!");
                }

                int currentId = _tariffId ?? 0; // Если _tariffId == null (создание), передаем 0. Иначе передаем реальный ID.
                var tariff = Tariff.CreateEntity(currentId, TextBoxName.Text, NumericUpDownPrice.Value); // Создаем сущность через статический метод

                // Вызываем Update или Create в зависимости от режима работы формы
                if (_tariffId.HasValue)
                {
                    _tariffRepository.UpdateTariff(tariff);
                }
                else
                {
                    _tariffRepository.CreateTariff(tariff);
                }

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
