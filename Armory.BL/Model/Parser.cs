using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.BL.Model
{
    public abstract class Parser
    {
        public static int? ParseInt(string value)
        {
            // TODO: Удаление лишних пробелов.

            if (int.TryParse(value, out int result))
            {
                return result;
            }

            return null;
        }

        public static double? ParseDouble(string value)
        {
            // TODO: Удаление лишних пробелов.

            if (double.TryParse(value, out double result))
            {
                return result;
            }

            return null;
        }

        public static DateTime? ParseDateTime(string value)
        {
            // TODO: Удаление лишних пробелов.

            if (DateTime.TryParse(value, out DateTime result))
            {
                return result;
            }

            return null;
        }
    }
}
