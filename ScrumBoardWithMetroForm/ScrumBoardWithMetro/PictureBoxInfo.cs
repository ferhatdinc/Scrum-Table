using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardWithMetro.Forms
{
    public class PictureBoxInfo
    {
        public Point PB_Location { get; set; }
        public Size PB_Size { get; set; }
        public string PB_BackColor { get; set; }
        public int Story_ID { get; set; }
        public int Story_Task_Count { get; set; }
        public int Task_ID { get; set; }
        public int Task_Status { get; set; }
        public string Story_Description { get; set; }
        public string Task_DeadLine { get; set; }
        public string Task_Author { get; set; }
        public string Story_AddDate { get; set; }
        public string Story_Name { get; set; }
        public string Task_Header { get; set; }
        public string Story_Author { get; set; }


    }
}
