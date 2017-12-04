namespace GasPumpApplication
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Settingsbtn = new MetroFramework.Controls.MetroTile();
            this.RepView = new MetroFramework.Controls.MetroTile();
            this.Pumpsbtn = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.metroPanel1.Controls.Add(this.Settingsbtn);
            this.metroPanel1.Controls.Add(this.RepView);
            this.metroPanel1.Controls.Add(this.Pumpsbtn);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(745, 485);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Settingsbtn
            // 
            this.Settingsbtn.ActiveControl = null;
            this.Settingsbtn.Location = new System.Drawing.Point(471, 176);
            this.Settingsbtn.Name = "Settingsbtn";
            this.Settingsbtn.Size = new System.Drawing.Size(153, 133);
            this.Settingsbtn.TabIndex = 4;
            this.Settingsbtn.Text = "Settings";
            this.Settingsbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Settingsbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("Settingsbtn.TileImage")));
            this.Settingsbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Settingsbtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Settingsbtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Settingsbtn.UseSelectable = true;
            this.Settingsbtn.UseTileImage = true;
            this.Settingsbtn.Click += new System.EventHandler(this.Settingsbtn_Click);
            // 
            // RepView
            // 
            this.RepView.ActiveControl = null;
            this.RepView.Location = new System.Drawing.Point(121, 176);
            this.RepView.Name = "RepView";
            this.RepView.Size = new System.Drawing.Size(153, 133);
            this.RepView.TabIndex = 4;
            this.RepView.Text = "Reports/Views";
            this.RepView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RepView.TileImage = ((System.Drawing.Image)(resources.GetObject("RepView.TileImage")));
            this.RepView.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RepView.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.RepView.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.RepView.UseSelectable = true;
            this.RepView.UseTileImage = true;
            this.RepView.Click += new System.EventHandler(this.RepView_Click);
            // 
            // Pumpsbtn
            // 
            this.Pumpsbtn.ActiveControl = null;
            this.Pumpsbtn.Location = new System.Drawing.Point(299, 176);
            this.Pumpsbtn.Name = "Pumpsbtn";
            this.Pumpsbtn.Size = new System.Drawing.Size(153, 133);
            this.Pumpsbtn.TabIndex = 4;
            this.Pumpsbtn.Text = "Pumps";
            this.Pumpsbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pumpsbtn.TileImage = ((System.Drawing.Image)(resources.GetObject("Pumpsbtn.TileImage")));
            this.Pumpsbtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pumpsbtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Pumpsbtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Pumpsbtn.UseSelectable = true;
            this.Pumpsbtn.UseTileImage = true;
            this.Pumpsbtn.Click += new System.EventHandler(this.Pumpsbtn_Click_1);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 545);
            this.Controls.Add(this.metroPanel1);
            this.Name = "MainMenuForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Text = "Main Menu";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile Settingsbtn;
        private MetroFramework.Controls.MetroTile RepView;
        private MetroFramework.Controls.MetroTile Pumpsbtn;
    }
}