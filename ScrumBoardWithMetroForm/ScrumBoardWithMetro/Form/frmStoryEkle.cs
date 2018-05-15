using ScrumBoardWithMetro.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumBoardWithMetro
{
    public partial class frmStoryEkle : MetroFramework.Forms.MetroForm
    {
        public frmStoryEkle()
        {
            InitializeComponent();
        }

        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            Button PB = new Button();
            List<PictureBoxInfo> Datas = SQLHelper.Select();
            Story StoryPass = new Story();
            frmMain frm = frmMain.GetInstance;
            Random Rnd = new Random();
            PB.BackColor = Color.FromArgb(Rnd.Next(0, 256), Rnd.Next(0, 256), Rnd.Next(0, 256));
            foreach (MetroFramework.Controls.MetroPanel Panel in frm.Controls.OfType<MetroFramework.Controls.MetroPanel>())
            {
                if (Panel.Name == "panel5")
                {
                    foreach (MetroFramework.Controls.MetroPanel Panels in Panel.Controls.OfType<MetroFramework.Controls.MetroPanel>())
                    {
                        if (Panels.Name == "pnlStory")
                        {
                            Panels.Refresh();
                            PB.Location = SQLHelper.GetLastRow(); //9,9
                        }
                    }
                }
            }
            if (Datas.Count == 0)
            {
                StoryPass.StoryLocationX = PB.Location.X+5;
            }
            else
                StoryPass.StoryLocationX = PB.Location.X;

            StoryPass.StoryLocationY = PB.Location.Y;
            StoryPass.Story_Color = PB.BackColor.GetHashCode().ToString();
            StoryPass.Story_Description = txtDescription.Text;
            StoryPass.Story_Name = txtStory_Name.Text;
            StoryPass.Story_AddDate = DateTime.Now.Date.ToString("dd/MM/yy");
            StoryPass.Story_Author = txtStoryAuthor.Text;
            SQLHelper.InsertStory(StoryPass);
            frm.RefreshEvent();
            this.Close();
            
        }
    }
}

