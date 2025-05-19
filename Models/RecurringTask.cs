using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    class RecurringTask : Task
    {
        public RecurringTask(string name, string description) : base(name, description) { }
    }
}
