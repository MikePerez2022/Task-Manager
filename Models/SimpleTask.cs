using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    class SimpleTask : Task
    {
        public SimpleTask(string name, string description) : base(name, description) { }
    }
}
