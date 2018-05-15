using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using ScrumBoardWithMetro.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Windows;

namespace ScrumBoardWithMetro
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        private static frmMain Instance; //Singleton
        public frmMain()
        {
            InitializeComponent();
            SQLHelper.SQLStart("Data Source=FERHAT\\SQLEXPRESS;Initial Catalog=ScrumTableDB; Integrated Security=True");
        }
        public static frmMain GetInstance
        {
            get
            {
                if (Instance == null || Instance.IsDisposed)
                {
                    Instance = new frmMain(); 
                }
                return Instance;
            }
        }

        Button MouseDownPB;
        void panel_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (MetroFramework.Controls.MetroPanel)sender;
            if (((MetroFramework.Controls.MetroPanel)sender) == pnlNotStarted)
            {
                SQLHelper.UpdateTask((int)(MouseDownPB.Tag), 0);
            }
            else if (((Panel)sender) == pnlInProgress)
            {
                SQLHelper.UpdateTask((int)(MouseDownPB.Tag), 1);
            }
            else if (((Panel)sender) == pnlDone)
            {
                SQLHelper.UpdateTask((int)(MouseDownPB.Tag), 2);
            }
        }
        void AllPB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                 MouseDownPB = (sender as Button);
                ((Button)sender).DoDragDrop(((Button)sender), DragDropEffects.Move);
            }
            string[] R;
            if (e.Button == MouseButtons.Right)
            {
                int SenderValue = (int)((Button)sender).Tag;
                R = SQLHelper.GetTaskInfo(SenderValue, 0).Split('/');
                switch (R[5])
                {
                    case "0":
                        Status = "Başlanmadı(Not Started)";
                        break;
                    case "1":
                        Status = "İşlemde(In Progress)";
                        break;
                    case "2":
                        Status = "Bitirildi!(Done!)";
                        break;
                    default:
                        break;
                }
                MetroMessageBox.Show(this, "" + R[0] + "\n" + R[1] + "\n" + R[3] + "\n Task Durumu : " + Status + "\n" + R[6] + "\n" + R[7], "TASK BİLGİLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        public void RefreshEvent()
        {
            ClearPanelEvent();
            List<PictureBoxInfo> Datas = SQLHelper.Select();
            foreach (PictureBoxInfo PBDatas in Datas)
            {
                Button PB = new Button();
                PB.Margin = new Padding(0);
                PB.Font = new Font("segoe script", 10, FontStyle.Regular);
                PB.Size = PBDatas.PB_Size;
                PB.MouseDown += Story_RightClicked;
                PB.BackColor = Color.FromArgb(Int32.Parse(PBDatas.PB_BackColor));
                pnlStory.Controls.Add(PB);
                PB.Location = PBDatas.PB_Location;
                PB.Tag = PBDatas.Story_ID;
                PB.Text = "Name:"+PBDatas.Story_Name+"\nDate:"+PBDatas.Story_AddDate+ "\nDesc:" + PBDatas.Story_Description;
                PB.ForeColor = Color.Black;
            }

            List<PictureBoxInfo> Datam = SQLHelper.SelectTask();
            foreach (PictureBoxInfo PBData in Datam)
            {
                Button PB = new Button();
                PB.Margin = new Padding(0);
                PB.Font = new Font("segoe script", 10, FontStyle.Regular);
                PB.Size = PBData.PB_Size;
                PB.BackColor = Color.FromArgb(Int32.Parse(PBData.PB_BackColor));
                PB.Tag = PBData.Task_ID;
                PB.DragDrop += panel_DragDrop;
                PB.MouseDown += AllPB_MouseDown;
                PB.Text = PBData.Task_Header;
                PB.ForeColor = Color.Black;
                switch (PBData.Task_Status)
                {
                    case 0:
                        pnlNotStarted.Controls.Add(PB);
                     
                        break;
                    case 1:
                        pnlInProgress.Controls.Add(PB);
                        
                        break;
                    case 2:
                        pnlDone.Controls.Add(PB);
              
                        break;
                    default:
                        break;
                }
                PB.Location = PBData.PB_Location;
            }
            pnlNotStarted.Size = new Size(pnlNotStarted.Size.Width, panel5.Size.Height);
            pnlInProgress.Size = new Size(pnlNotStarted.Size.Width, panel5.Size.Height);
            pnlDone.Size = new Size(pnlNotStarted.Size.Width, panel5.Size.Height);
        }

        public void ClearPanelEvent()
        {
            pnlStory.Controls.Clear();
            pnlNotStarted.Controls.Clear();
            pnlInProgress.Controls.Clear();
            pnlDone.Controls.Clear();
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        string Status;
        
        private void Story_RightClicked(object sender, MouseEventArgs e)
        {
            string[] R;
            if (e.Button == MouseButtons.Right)
            {
                int SenderValue = (int)((Button)sender).Tag;
                R = SQLHelper.GetTaskInfo(0, SenderValue).Split('/');
                MetroMessageBox.Show(this, "" + R[0] + "\n" + R[2] + "\n" + R[8] + "\n" + R[9] + "\n", "STORY BİLGİLERİ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            frmStoryEkle frm = new frmStoryEkle();
            frm.Show();
        }

        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            frmTaskEkle frm = new frmTaskEkle();
            frm.Show();
        }
        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
            DialogResult Ans=MetroMessageBox.Show(this, "\n\nVeri Tabanı Silinsin Mi?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (Ans == DialogResult.Yes)
            {
                SQLHelper.DeleteAllDB();
                RefreshEvent();
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            RefreshEvent();
           
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Uygulama Projelerde İş Paylaşılımını Ve Projeye Genel Bir Bakış Yapabilmeyi Sağlamaktadır.\nUygulamanın Kullanımı Oldukça Basittir Buttonlardan Story Ve Task Ekleyebilirsiniz.\nBir Task Ekleyebilmek İçin Öncelikle Bir Story Eklenmedilir.\nTask Detaylarını Görüntülemek İçin Task Üstüne Mouse İle Sağ Tık Yapabilirsiniz.\nBize Ulaşın : scrumboard@scrumboard.com\nTeşekkür Ederiz.", "YARDIM BÖLÜMÜNE HOŞ GELDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
