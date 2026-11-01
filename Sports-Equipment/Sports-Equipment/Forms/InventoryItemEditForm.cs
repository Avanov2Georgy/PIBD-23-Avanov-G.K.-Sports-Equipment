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
using Sports_Equipment.Entities.Enums;
using Sports_Equipment.Repositories;

namespace Sports_Equipment.Forms
{
    public partial class InventoryItemEditForm : Form
    {
        private readonly IInventoryItemRepository _inventoryRepository;
        private int? _itemId;

        public InventoryItemEditForm(IInventoryItemRepository inventoryRepository)
        {
            InitializeComponent();
            _inventoryRepository = inventoryRepository ?? throw new ArgumentNullException(nameof(inventoryRepository));

            // Заполняем ComboBox значениями обычного перечисления (Тип)
            ComboBoxType.DataSource = Enum.GetValues(typeof(InventoryType));

            // Заполняем CheckedListBox значениями флагового перечисления (Состояние)
            foreach (var condition in Enum.GetValues(typeof(InventoryCondition)))
            {
                CheckedListBoxCondition.Items.Add(condition);
            }
        }

        public int InventoryItemId
        {
            set
            {
                _itemId = value;
                LoadItemData(value);
            }
        }

        private void LoadItemData(int id)
        {
            var item = _inventoryRepository.ReadInventoryItemById(id);
            if (item != null)
            {
                TextBoxName.Text = item.Name;
                TextBoxSize.Text = item.Size;
                ComboBoxType.SelectedItem = item.Type;

                // Восстанавливаем галочки для флагов
                for (int i = 0; i < CheckedListBoxCondition.Items.Count; i++)
                {
                    var enumValue = (InventoryCondition)CheckedListBoxCondition.Items[i];
                    if ((item.Condition & enumValue) == enumValue)
                    {
                        CheckedListBoxCondition.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void ButtonSave_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TextBoxName.Text) || string.IsNullOrWhiteSpace(TextBoxSize.Text))
                    throw new Exception("Заполните текстовые поля (Название и Размер)!");

                if (ComboBoxType.SelectedItem == null)
                    throw new Exception("Выберите тип инвентаря!");

                // Собираем выбранные флаги обратно в одно значение
                InventoryCondition condition = InventoryCondition.None;
                foreach (var checkedItem in CheckedListBoxCondition.CheckedItems)
                {
                    condition |= (InventoryCondition)checkedItem;
                }

                if (condition == InventoryCondition.None)
                    throw new Exception("Выберите хотя бы одно состояние инвентаря!");

                int currentId = _itemId ?? 0;
                var item = InventoryItem.CreateEntity(currentId, TextBoxName.Text, (InventoryType)ComboBoxType.SelectedItem, TextBoxSize.Text, condition);

                if (_itemId.HasValue)
                {
                    _inventoryRepository.UpdateInventoryItem(item);
                }
                else
                {
                    _inventoryRepository.CreateInventoryItem(item);
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
