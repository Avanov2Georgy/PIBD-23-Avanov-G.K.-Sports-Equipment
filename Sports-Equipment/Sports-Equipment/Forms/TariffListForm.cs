using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports_Equipment.Repositories;
using Sports_Equipment.Forms;
using Unity;

namespace Sports_Equipment
{
    public partial class TariffListForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly ITariffRepository _tariffRepository;

        public TariffListForm(IUnityContainer container, ITariffRepository tariffRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _tariffRepository = tariffRepository ?? throw new ArgumentNullException(nameof(tariffRepository));

            this.Load += TariffListForm_Load;
        }

        private void TariffListForm_Load(object? sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            DataGridViewTariffs.DataSource = _tariffRepository.ReadTariffs();

            if (DataGridViewTariffs.Columns["Id"] != null)
                DataGridViewTariffs.Columns["Id"].Visible = false;
        }

        private void ButtonAdd_Click(object? sender, EventArgs e)
        {
            _container.Resolve<TariffEditForm>().ShowDialog();
            LoadList();
        }

        private void ButtonEdit_Click(object? sender, EventArgs e)
        {
            if (DataGridViewTariffs.SelectedRows.Count < 1)
            {
                MessageBox.Show("Пожалуйста, выберите тариф для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(DataGridViewTariffs.SelectedRows[0].Cells["Id"].Value);
            var editForm = _container.Resolve<TariffEditForm>();
            editForm.TariffId = id;
            editForm.ShowDialog();

            LoadList();
        }

        private void ButtonDelete_Click(object? sender, EventArgs e)
        {
            if (DataGridViewTariffs.SelectedRows.Count < 1)
            {
                MessageBox.Show("Пожалуйста, выберите тариф для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(DataGridViewTariffs.SelectedRows[0].Cells["Id"].Value);

            if (MessageBox.Show("Вы уверены, что хотите удалить этот тариф?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _tariffRepository.DeleteTariff(id);
                LoadList();
            }
        }
    }
}
