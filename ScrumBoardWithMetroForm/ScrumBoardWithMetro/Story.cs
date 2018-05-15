using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoardWithMetro
{
    public class Story
    {
        public string Story_Description { get; set; }
        public int StoryLocationX { get; set; }
        public int StoryLocationY { get; set; }
        public string Story_Color { get; set; }
        public string Story_Name{ get; set; }
        public string Story_AddDate { get; set; }
        public string Story_Author{ get; set; }
    }
}
