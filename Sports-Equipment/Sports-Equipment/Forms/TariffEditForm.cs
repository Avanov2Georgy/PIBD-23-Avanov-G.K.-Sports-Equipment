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
        private readonly ITariffRepository _tariffRepository;
        private int? _tariffId;

        public TariffEditForm(ITariffRepository tariffRepository)
        {
            InitializeComponent();
            _tariffRepository = tariffRepository ?? throw new ArgumentNullException(nameof(tariffRepository));
        }

        public int TariffId
        {
            set
            {
                _tariffId = value;
                LoadTariffData(value);
            }
        }

        private void LoadTariffData(int id)
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
                if (string.IsNullOrWhiteSpace(TextBoxName.Text))
                {
                    throw new Exception("Название тарифа не может быть пустым!");
                }

                int currentId = _tariffId ?? 0;
                var tariff = Tariff.CreateEntity(currentId, TextBoxName.Text, NumericUpDownPrice.Value);

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
