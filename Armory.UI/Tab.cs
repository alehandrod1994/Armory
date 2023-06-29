using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.UI
{
    public class Tab
    {
        public Tab(int number, string name, Panel panel)
        {
            if (number < 0)
            {
                throw new ArgumentNullException(nameof(name), "Номер вкладки не может быть меньше нуля.");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Название вкладки не может быть пустым.");
            }

            if (panel is null)
            {
                throw new ArgumentNullException(nameof(name), "Вкладка не может быть пустой.");
            }

            Number = number;
            Name = name;
            Panel = panel;
        }

        public int Number { get; }
        public string Name { get; }
        public Panel Panel { get; }
    }
}
