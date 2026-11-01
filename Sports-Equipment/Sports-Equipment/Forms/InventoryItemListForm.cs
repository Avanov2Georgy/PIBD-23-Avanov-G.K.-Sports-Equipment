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
        private readonly IUnityContainer _container;
        private readonly IInventoryItemRepository _inventoryRepository;

        public InventoryItemListForm(IUnityContainer container, IInventoryItemRepository inventoryRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _inventoryRepository = inventoryRepository ?? throw new ArgumentNullException(nameof(inventoryRepository));

            this.Load += InventoryItemListForm_Load;
        }

        private void InventoryItemListForm_Load(object? sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            DataGridViewInventory.DataSource = _inventoryRepository.ReadInventoryItems();

            if (DataGridViewInventory.Columns["Id"] != null)
                DataGridViewInventory.Columns["Id"].Visible = false;
        }

        private void ButtonAdd_Click(object? sender, EventArgs e)
        {
            _container.Resolve<InventoryItemEditForm>().ShowDialog();
            LoadList();
        }

        private void ButtonEdit_Click(object? sender, EventArgs e)
        {
            if (DataGridViewInventory.SelectedRows.Count < 1)
            {
                MessageBox.Show("Пожалуйста, выберите инвентарь для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(DataGridViewInventory.SelectedRows[0].Cells["Id"].Value);
            var editForm = _container.Resolve<InventoryItemEditForm>();
            editForm.InventoryItemId = id;
            editForm.ShowDialog();

            LoadList();
        }

        private void ButtonDelete_Click(object? sender, EventArgs e)
        {
            if (DataGridViewInventory.SelectedRows.Count < 1)
            {
                MessageBox.Show("Пожалуйста, выберите инвентарь для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(DataGridViewInventory.SelectedRows[0].Cells["Id"].Value);

            if (MessageBox.Show("Вы уверены, что хотите удалить этот инвентарь?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _inventoryRepository.DeleteInventoryItem(id);
                LoadList();
            }
        }
    }
}