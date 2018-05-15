namespace ScrumBoardWithMetro
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDeleteDB = new MetroFramework.Controls.MetroTile();
            this.btnTaskEkle = new MetroFramework.Controls.MetroTile();
            this.btnStoryEkle = new MetroFramework.Controls.MetroTile();
            this.pnlStory = new MetroFramework.Controls.MetroPanel();
            this.panel5 = new MetroFramework.Controls.MetroPanel();
            this.pnlNotStarted = new MetroFramework.Controls.MetroPanel();
            this.pnlDone = new MetroFramework.Controls.MetroPanel();
            this.pnlInProgress = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.btnHelp = new MetroFramework.Controls.MetroTile();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.ActiveControl = null;
            this.btnDeleteDB.Location = new System.Drawing.Point(648, 367);
            this.btnDeleteDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(120, 115);
            this.btnDeleteDB.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDeleteDB.TabIndex = 2;
            this.btnDeleteDB.Text = "Delete All";
            this.btnDeleteDB.TileImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteDB.TileImage")));
            this.btnDeleteDB.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteDB.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnDeleteDB.UseSelectable = true;
            this.btnDeleteDB.UseTileImage = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.ActiveControl = null;
            this.btnTaskEkle.Location = new System.Drawing.Point(648, 238);
            this.btnTaskEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(120, 115);
            this.btnTaskEkle.TabIndex = 1;
            this.btnTaskEkle.Text = "Add Task";
            this.btnTaskEkle.TileImage = ((System.Drawing.Image)(resources.GetObject("btnTaskEkle.TileImage")));
            this.btnTaskEkle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTaskEkle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnTaskEkle.UseSelectable = true;
            this.btnTaskEkle.UseTileImage = true;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.ActiveControl = null;
            this.btnStoryEkle.ForeColor = System.Drawing.Color.White;
            this.btnStoryEkle.Location = new System.Drawing.Point(648, 111);
            this.btnStoryEkle.Margin = new System.Windows.Forms.Padding(0);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.PaintTileCount = false;
            this.btnStoryEkle.Size = new System.Drawing.Size(120, 115);
            this.btnStoryEkle.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnStoryEkle.TabIndex = 0;
            this.btnStoryEkle.Text = "Add Story";
            this.btnStoryEkle.TileImage = ((System.Drawing.Image)(resources.GetObject("btnStoryEkle.TileImage")));
            this.btnStoryEkle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStoryEkle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnStoryEkle.UseSelectable = true;
            this.btnStoryEkle.UseTileImage = true;
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // pnlStory
            // 
            this.pnlStory.AutoSize = true;
            this.pnlStory.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlStory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlStory.BackgroundImage")));
            this.pnlStory.HorizontalScrollbarBarColor = true;
            this.pnlStory.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlStory.HorizontalScrollbarSize = 10;
            this.pnlStory.Location = new System.Drawing.Point(0, 0);
            this.pnlStory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStory.Name = "pnlStory";
            this.pnlStory.Size = new System.Drawing.Size(150, 585);
            this.pnlStory.TabIndex = 0;
            this.pnlStory.UseCustomBackColor = true;
            this.pnlStory.VerticalScrollbarBarColor = true;
            this.pnlStory.VerticalScrollbarHighlightOnWheel = false;
            this.pnlStory.VerticalScrollbarSize = 10;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pnlNotStarted);
            this.panel5.Controls.Add(this.pnlDone);
            this.panel5.Controls.Add(this.pnlInProgress);
            this.panel5.Controls.Add(this.pnlStory);
            this.panel5.HorizontalScrollbarBarColor = true;
            this.panel5.HorizontalScrollbarHighlightOnWheel = false;
            this.panel5.HorizontalScrollbarSize = 10;
            this.panel5.Location = new System.Drawing.Point(35, 111);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 585);
            this.panel5.TabIndex = 10;
            this.panel5.UseCustomBackColor = true;
            this.panel5.VerticalScrollbarBarColor = true;
            this.panel5.VerticalScrollbarHighlightOnWheel = false;
            this.panel5.VerticalScrollbarSize = 10;
            // 
            // pnlNotStarted
            // 
            this.pnlNotStarted.AllowDrop = true;
            this.pnlNotStarted.AutoSize = true;
            this.pnlNotStarted.BackColor = System.Drawing.Color.Silver;
            this.pnlNotStarted.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlNotStarted.BackgroundImage")));
            this.pnlNotStarted.HorizontalScrollbarBarColor = true;
            this.pnlNotStarted.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlNotStarted.HorizontalScrollbarSize = 10;
            this.pnlNotStarted.Location = new System.Drawing.Point(150, 0);
            this.pnlNotStarted.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNotStarted.Name = "pnlNotStarted";
            this.pnlNotStarted.Size = new System.Drawing.Size(150, 585);
            this.pnlNotStarted.TabIndex = 1;
            this.pnlNotStarted.UseCustomBackColor = true;
            this.pnlNotStarted.VerticalScrollbarBarColor = true;
            this.pnlNotStarted.VerticalScrollbarHighlightOnWheel = false;
            this.pnlNotStarted.VerticalScrollbarSize = 10;
            this.pnlNotStarted.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.pnlNotStarted.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // pnlDone
            // 
            this.pnlDone.AllowDrop = true;
            this.pnlDone.AutoSize = true;
            this.pnlDone.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDone.BackgroundImage")));
            this.pnlDone.HorizontalScrollbarBarColor = true;
            this.pnlDone.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDone.HorizontalScrollbarSize = 10;
            this.pnlDone.Location = new System.Drawing.Point(450, 0);
            this.pnlDone.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(150, 585);
            this.pnlDone.TabIndex = 3;
            this.pnlDone.UseCustomBackColor = true;
            this.pnlDone.VerticalScrollbarBarColor = true;
            this.pnlDone.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDone.VerticalScrollbarSize = 10;
            this.pnlDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.pnlDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // pnlInProgress
            // 
            this.pnlInProgress.AllowDrop = true;
            this.pnlInProgress.AutoSize = true;
            this.pnlInProgress.BackColor = System.Drawing.Color.Yellow;
            this.pnlInProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInProgress.BackgroundImage")));
            this.pnlInProgress.HorizontalScrollbarBarColor = true;
            this.pnlInProgress.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlInProgress.HorizontalScrollbarSize = 10;
            this.pnlInProgress.Location = new System.Drawing.Point(300, 0);
            this.pnlInProgress.Margin = new System.Windows.Forms.Padding(0);
            this.pnlInProgress.Name = "pnlInProgress";
            this.pnlInProgress.Size = new System.Drawing.Size(150, 585);
            this.pnlInProgress.TabIndex = 2;
            this.pnlInProgress.UseCustomBackColor = true;
            this.pnlInProgress.VerticalScrollbarBarColor = true;
            this.pnlInProgress.VerticalScrollbarHighlightOnWheel = false;
            this.pnlInProgress.VerticalScrollbarSize = 10;
            this.pnlInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.pnlInProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.metroTile1.ForeColor = System.Drawing.Color.DarkRed;
            this.metroTile1.Location = new System.Drawing.Point(35, 71);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(150, 37);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "STORY";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.metroTile2.ForeColor = System.Drawing.Color.DarkRed;
            this.metroTile2.Location = new System.Drawing.Point(185, 71);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(0);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(150, 37);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "NOT STARTED";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(164)))), ((int)(((byte)(136)))));
            this.metroTile3.ForeColor = System.Drawing.Color.DarkRed;
            this.metroTile3.Location = new System.Drawing.Point(335, 71);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(0);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(150, 37);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile3.TabIndex = 5;
            this.metroTile3.Text = "IN PROGRESS";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(163)))));
            this.metroTile4.ForeColor = System.Drawing.Color.DarkRed;
            this.metroTile4.Location = new System.Drawing.Point(485, 71);
            this.metroTile4.Margin = new System.Windows.Forms.Padding(0);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(150, 37);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile4.TabIndex = 6;
            this.metroTile4.Text = "DONE";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.UseCustomBackColor = true;
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTile5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroTile5.Location = new System.Drawing.Point(276, 19);
            this.metroTile5.Margin = new System.Windows.Forms.Padding(0);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(231, 45);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile5.TabIndex = 7;
            this.metroTile5.Text = "SCRUM BOARD";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile5.UseCustomBackColor = true;
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(0, -1);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(771, 17);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile6.TabIndex = 8;
            this.metroTile6.UseSelectable = true;
            // 
            // btnHelp
            // 
            this.btnHelp.ActiveControl = null;
            this.btnHelp.Location = new System.Drawing.Point(648, 495);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(120, 115);
            this.btnHelp.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Help";
            this.btnHelp.TileImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.TileImage")));
            this.btnHelp.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnHelp.UseSelectable = true;
            this.btnHelp.UseTileImage = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(812, 716);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnDeleteDB);
            this.Controls.Add(this.btnTaskEkle);
            this.Controls.Add(this.btnStoryEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.RightToLeftLayout = true;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnDeleteDB;
        private MetroFramework.Controls.MetroTile btnTaskEkle;
        private MetroFramework.Controls.MetroTile btnStoryEkle;
        private MetroFramework.Controls.MetroPanel pnlStory;
        private MetroFramework.Controls.MetroPanel panel5;
        private MetroFramework.Controls.MetroPanel pnlInProgress;
        private MetroFramework.Controls.MetroPanel pnlNotStarted;
        private MetroFramework.Controls.MetroPanel pnlDone;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile btnHelp;
    }
}

