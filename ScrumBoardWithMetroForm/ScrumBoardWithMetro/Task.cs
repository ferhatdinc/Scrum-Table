using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardWithMetro
{
    public class Task
    {
        public string Task_DeadLine { get; set; }
        public int TaskLocationX { get; set; }
        public int TaskLocationY { get; set; }
        public string Task_Author { get; set; }
        public int Task_Status { get; set; }
        public string Task_Description { get; set; }
        public int Story_ID { get; set; }
        public string Task_BackColor { get; set; }
        public string Task_Header { get; set; }

    }
}
