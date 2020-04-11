using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHomeWork.Model_Data
{
    class Work_Plan_Model
    {
        public DateTime CreationDate { get; set; } = DateTime.Now; // Поле для даты создания и задание текущего времени с помощью структуры DateTime.Now;

        private bool _TaskDone;
        private string _text;

        public bool TaskDone

        {
            get { return _TaskDone; }

            set { _TaskDone = value; }
        }

        public string Text

        {
            get { return _text; }

            set { _text = value; }
        }

        
    }
}
