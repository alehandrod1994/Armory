using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory.BL.Model
{
    public interface ICommand
    {
        void Add(ArmoryContext db);
        void Change(ArmoryContext db, int id);
        void Remove(ArmoryContext db, int id);
        void Import(ArmoryContext db);
    }
}
