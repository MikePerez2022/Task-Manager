using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    class Task
    {
        private string name;
        private string description;

        public Task(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
