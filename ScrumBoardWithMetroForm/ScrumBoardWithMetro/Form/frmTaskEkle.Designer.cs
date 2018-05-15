namespace ScrumBoardWithMetro
{
    partial class frmTaskEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskEkle));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbStorys = new MetroFramework.Controls.MetroComboBox();
            this.btnTaskEkle = new MetroFramework.Controls.MetroTile();
            this.dtpDeadLine = new MetroFramework.Controls.MetroDateTime();
            this.rtbDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTask_Header = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(3, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Story Name";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // cbStorys
            // 
            this.cbStorys.FormattingEnabled = true;
            this.cbStorys.ItemHeight = 23;
            this.cbStorys.Location = new System.Drawing.Point(111, 67);
            this.cbStorys.Name = "cbStorys";
            this.cbStorys.Size = new System.Drawing.Size(200, 29);
            this.cbStorys.TabIndex = 1;
            this.cbStorys.UseSelectable = true;
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.ActiveControl = null;
            this.btnTaskEkle.Location = new System.Drawing.Point(23, 282);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(288, 46);
            this.btnTaskEkle.TabIndex = 10;
            this.btnTaskEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaskEkle.TileImage = ((System.Drawing.Image)(resources.GetObject("btnTaskEkle.TileImage")));
            this.btnTaskEkle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTaskEkle.UseSelectable = true;
            this.btnTaskEkle.UseTileImage = true;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // dtpDeadLine
            // 
            this.dtpDeadLine.Location = new System.Drawing.Point(111, 164);
            this.dtpDeadLine.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDeadLine.Name = "dtpDeadLine";
            this.dtpDeadLine.Size = new System.Drawing.Size(200, 29);
            this.dtpDeadLine.TabIndex = 7;
            // 
            // rtbDescription
            // 
            // 
            // 
            // 
            this.rtbDescription.CustomButton.Image = null;
            this.rtbDescription.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.rtbDescription.CustomButton.Name = "";
            this.rtbDescription.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.rtbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rtbDescription.CustomButton.TabIndex = 1;
            this.rtbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rtbDescription.CustomButton.UseSelectable = true;
            this.rtbDescription.CustomButton.Visible = false;
            this.rtbDescription.Lines = new string[0];
            this.rtbDescription.Location = new System.Drawing.Point(111, 199);
            this.rtbDescription.MaxLength = 32767;
            this.rtbDescription.Multiline = true;
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.PasswordChar = '\0';
            this.rtbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rtbDescription.SelectedText = "";
            this.rtbDescription.SelectionLength = 0;
            this.rtbDescription.SelectionStart = 0;
            this.rtbDescription.ShortcutsEnabled = true;
            this.rtbDescription.Size = new System.Drawing.Size(200, 77);
            this.rtbDescription.TabIndex = 9;
            this.rtbDescription.UseSelectable = true;
            this.rtbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rtbDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(26, 168);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Deadline";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel3.Location = new System.Drawing.Point(8, 226);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 25);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Description";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // txtAuthor
            // 
            // 
            // 
            // 
            this.txtAuthor.CustomButton.Image = null;
            this.txtAuthor.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtAuthor.CustomButton.Name = "";
            this.txtAuthor.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuthor.CustomButton.TabIndex = 1;
            this.txtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuthor.CustomButton.UseSelectable = true;
            this.txtAuthor.CustomButton.Visible = false;
            this.txtAuthor.Lines = new string[0];
            this.txtAuthor.Location = new System.Drawing.Point(111, 133);
            this.txtAuthor.MaxLength = 32767;
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PasswordChar = '\0';
            this.txtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.SelectionLength = 0;
            this.txtAuthor.SelectionStart = 0;
            this.txtAuthor.ShortcutsEnabled = true;
            this.txtAuthor.Size = new System.Drawing.Size(200, 25);
            this.txtAuthor.TabIndex = 5;
            this.txtAuthor.UseSelectable = true;
            this.txtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel4.Location = new System.Drawing.Point(37, 133);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 25);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Author";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel5.Location = new System.Drawing.Point(8, 102);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Task Name";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // txtTask_Header
            // 
            // 
            // 
            // 
            this.txtTask_Header.CustomButton.Image = null;
            this.txtTask_Header.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtTask_Header.CustomButton.Name = "";
            this.txtTask_Header.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTask_Header.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTask_Header.CustomButton.TabIndex = 1;
            this.txtTask_Header.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTask_Header.CustomButton.UseSelectable = true;
            this.txtTask_Header.CustomButton.Visible = false;
            this.txtTask_Header.Lines = new string[] {
        "Kısa Başlık"};
            this.txtTask_Header.Location = new System.Drawing.Point(111, 102);
            this.txtTask_Header.MaxLength = 32767;
            this.txtTask_Header.Multiline = true;
            this.txtTask_Header.Name = "txtTask_Header";
            this.txtTask_Header.PasswordChar = '\0';
            this.txtTask_Header.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTask_Header.SelectedText = "";
            this.txtTask_Header.SelectionLength = 0;
            this.txtTask_Header.SelectionStart = 0;
            this.txtTask_Header.ShortcutsEnabled = true;
            this.txtTask_Header.Size = new System.Drawing.Size(200, 25);
            this.txtTask_Header.TabIndex = 3;
            this.txtTask_Header.Text = "Kısa Başlık";
            this.txtTask_Header.UseSelectable = true;
            this.txtTask_Header.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTask_Header.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // frmTaskEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 356);
            this.Controls.Add(this.txtTask_Header);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.dtpDeadLine);
            this.Controls.Add(this.btnTaskEkle);
            this.Controls.Add(this.cbStorys);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "frmTaskEkle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Add Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbStorys;
        private MetroFramework.Controls.MetroTile btnTaskEkle;
        private MetroFramework.Controls.MetroDateTime dtpDeadLine;
        private MetroFramework.Controls.MetroTextBox rtbDescription;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtAuthor;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtTask_Header;
    }
}