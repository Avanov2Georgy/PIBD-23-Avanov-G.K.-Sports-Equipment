using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Equipment.Entities.Enums
{
    [Flags] // значения можно комбинировать через побитовое
    public enum InventoryCondition
    {
        None = 0,
        Good = 1,          // Хорошее
        NeedsRepair = 2,   // Требует ремонта
        Broken = 4         // Сломано
    }
}
