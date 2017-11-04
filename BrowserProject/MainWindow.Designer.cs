namespace BrowserProject
{
    partial class MyBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBrowser));
            this.textbox_URL = new System.Windows.Forms.TextBox();
            this.Button_GO = new System.Windows.Forms.Button();
            this.button_BACK = new System.Windows.Forms.Button();
            this.button_FWD = new System.Windows.Forms.Button();
            this.button_SET_HOME_PAGE = new System.Windows.Forms.Button();
            this.button_HISTORY = new System.Windows.Forms.Button();
            this.button_ADD_TO_FAVORITES = new System.Windows.Forms.Button();
            this.button_SEE_YOUR_FAVORITES = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_DELETE_FAVORITE = new System.Windows.Forms.Button();
            this.button_EDIT_FAVORITE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MyListOfFavorites = new System.Windows.Forms.ListBox();
            this.main_HTML_Area = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_VISIT_A_FAVORITE = new System.Windows.Forms.Button();
            this.Close_TAB = new System.Windows.Forms.Button();
            this.GO_TO_HOME_PAGE = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.main_HTML_Area.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_URL
            // 
            this.textbox_URL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_URL.Location = new System.Drawing.Point(171, 14);
            this.textbox_URL.Name = "textbox_URL";
            this.textbox_URL.Size = new System.Drawing.Size(470, 27);
            this.textbox_URL.TabIndex = 0;
            this.textbox_URL.Text = "http://";
            // 
            // Button_GO
            // 
            this.Button_GO.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_GO.Image = ((System.Drawing.Image)(resources.GetObject("Button_GO.Image")));
            this.Button_GO.Location = new System.Drawing.Point(654, 7);
            this.Button_GO.Name = "Button_GO";
            this.Button_GO.Size = new System.Drawing.Size(50, 40);
            this.Button_GO.TabIndex = 1;
            this.Button_GO.UseVisualStyleBackColor = true;
            this.Button_GO.Click += new System.EventHandler(this.Button_GO_Click);
            // 
            // button_BACK
            // 
            this.button_BACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_BACK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BACK.Image = ((System.Drawing.Image)(resources.GetObject("button_BACK.Image")));
            this.button_BACK.Location = new System.Drawing.Point(23, 7);
            this.button_BACK.Name = "button_BACK";
            this.button_BACK.Size = new System.Drawing.Size(50, 40);
            this.button_BACK.TabIndex = 2;
            this.button_BACK.UseVisualStyleBackColor = true;
            // 
            // button_FWD
            // 
            this.button_FWD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_FWD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FWD.Image = ((System.Drawing.Image)(resources.GetObject("button_FWD.Image")));
            this.button_FWD.Location = new System.Drawing.Point(93, 7);
            this.button_FWD.Name = "button_FWD";
            this.button_FWD.Size = new System.Drawing.Size(50, 40);
            this.button_FWD.TabIndex = 3;
            this.button_FWD.UseVisualStyleBackColor = true;
            // 
            // button_SET_HOME_PAGE
            // 
            this.button_SET_HOME_PAGE.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SET_HOME_PAGE.Image = ((System.Drawing.Image)(resources.GetObject("button_SET_HOME_PAGE.Image")));
            this.button_SET_HOME_PAGE.Location = new System.Drawing.Point(728, 7);
            this.button_SET_HOME_PAGE.Name = "button_SET_HOME_PAGE";
            this.button_SET_HOME_PAGE.Size = new System.Drawing.Size(50, 40);
            this.button_SET_HOME_PAGE.TabIndex = 4;
            this.button_SET_HOME_PAGE.UseVisualStyleBackColor = true;
            this.button_SET_HOME_PAGE.Click += new System.EventHandler(this.button_SET_HOME_PAGE_Click);
            // 
            // button_HISTORY
            // 
            this.button_HISTORY.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HISTORY.Image = ((System.Drawing.Image)(resources.GetObject("button_HISTORY.Image")));
            this.button_HISTORY.Location = new System.Drawing.Point(802, 7);
            this.button_HISTORY.Name = "button_HISTORY";
            this.button_HISTORY.Size = new System.Drawing.Size(50, 40);
            this.button_HISTORY.TabIndex = 5;
            this.button_HISTORY.UseVisualStyleBackColor = true;
            this.button_HISTORY.Click += new System.EventHandler(this.button_HISTORY_Click);
            // 
            // button_ADD_TO_FAVORITES
            // 
            this.button_ADD_TO_FAVORITES.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ADD_TO_FAVORITES.Image = ((System.Drawing.Image)(resources.GetObject("button_ADD_TO_FAVORITES.Image")));
            this.button_ADD_TO_FAVORITES.Location = new System.Drawing.Point(950, 7);
            this.button_ADD_TO_FAVORITES.Name = "button_ADD_TO_FAVORITES";
            this.button_ADD_TO_FAVORITES.Size = new System.Drawing.Size(50, 40);
            this.button_ADD_TO_FAVORITES.TabIndex = 6;
            this.button_ADD_TO_FAVORITES.UseVisualStyleBackColor = true;
            this.button_ADD_TO_FAVORITES.Click += new System.EventHandler(this.button_ADD_TO_FAVORITES_Click);
            // 
            // button_SEE_YOUR_FAVORITES
            // 
            this.button_SEE_YOUR_FAVORITES.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SEE_YOUR_FAVORITES.Image = ((System.Drawing.Image)(resources.GetObject("button_SEE_YOUR_FAVORITES.Image")));
            this.button_SEE_YOUR_FAVORITES.Location = new System.Drawing.Point(876, 7);
            this.button_SEE_YOUR_FAVORITES.Name = "button_SEE_YOUR_FAVORITES";
            this.button_SEE_YOUR_FAVORITES.Size = new System.Drawing.Size(50, 40);
            this.button_SEE_YOUR_FAVORITES.TabIndex = 7;
            this.button_SEE_YOUR_FAVORITES.UseVisualStyleBackColor = true;
            this.button_SEE_YOUR_FAVORITES.Click += new System.EventHandler(this.button_SEE_YOUR_FAVORITES_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Favorites";
            // 
            // button_DELETE_FAVORITE
            // 
            this.button_DELETE_FAVORITE.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DELETE_FAVORITE.Image = ((System.Drawing.Image)(resources.GetObject("button_DELETE_FAVORITE.Image")));
            this.button_DELETE_FAVORITE.Location = new System.Drawing.Point(12, 448);
            this.button_DELETE_FAVORITE.Name = "button_DELETE_FAVORITE";
            this.button_DELETE_FAVORITE.Size = new System.Drawing.Size(46, 41);
            this.button_DELETE_FAVORITE.TabIndex = 11;
            this.button_DELETE_FAVORITE.UseVisualStyleBackColor = true;
            this.button_DELETE_FAVORITE.Click += new System.EventHandler(this.button_DELETE_FAVORITE_Click);
            // 
            // button_EDIT_FAVORITE
            // 
            this.button_EDIT_FAVORITE.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EDIT_FAVORITE.Image = ((System.Drawing.Image)(resources.GetObject("button_EDIT_FAVORITE.Image")));
            this.button_EDIT_FAVORITE.Location = new System.Drawing.Point(64, 448);
            this.button_EDIT_FAVORITE.Name = "button_EDIT_FAVORITE";
            this.button_EDIT_FAVORITE.Size = new System.Drawing.Size(41, 41);
            this.button_EDIT_FAVORITE.TabIndex = 12;
            this.button_EDIT_FAVORITE.UseVisualStyleBackColor = true;
            this.button_EDIT_FAVORITE.Click += new System.EventHandler(this.button_EDIT_FAVORITE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Back";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(716, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Set homePage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Go";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Forward";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(807, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "History";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Delete";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(943, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Add favorite";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(876, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Favorites";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Edit";
            // 
            // MyListOfFavorites
            // 
            this.MyListOfFavorites.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyListOfFavorites.FormattingEnabled = true;
            this.MyListOfFavorites.ItemHeight = 20;
            this.MyListOfFavorites.Location = new System.Drawing.Point(12, 98);
            this.MyListOfFavorites.Name = "MyListOfFavorites";
            this.MyListOfFavorites.Size = new System.Drawing.Size(145, 344);
            this.MyListOfFavorites.TabIndex = 22;
            // 
            // main_HTML_Area
            // 
            this.main_HTML_Area.Controls.Add(this.tabPage1);
            this.main_HTML_Area.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_HTML_Area.Location = new System.Drawing.Point(171, 98);
            this.main_HTML_Area.Name = "main_HTML_Area";
            this.main_HTML_Area.SelectedIndex = 0;
            this.main_HTML_Area.Size = new System.Drawing.Size(865, 344);
            this.main_HTML_Area.TabIndex = 23;
            this.main_HTML_Area.SelectedIndexChanged += new System.EventHandler(this.main_HTML_Area_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(857, 314);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_VISIT_A_FAVORITE
            // 
            this.button_VISIT_A_FAVORITE.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_VISIT_A_FAVORITE.Location = new System.Drawing.Point(111, 448);
            this.button_VISIT_A_FAVORITE.Name = "button_VISIT_A_FAVORITE";
            this.button_VISIT_A_FAVORITE.Size = new System.Drawing.Size(46, 41);
            this.button_VISIT_A_FAVORITE.TabIndex = 24;
            this.button_VISIT_A_FAVORITE.Text = "Visit";
            this.button_VISIT_A_FAVORITE.UseVisualStyleBackColor = true;
            this.button_VISIT_A_FAVORITE.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close_TAB
            // 
            this.Close_TAB.Location = new System.Drawing.Point(175, 63);
            this.Close_TAB.Name = "Close_TAB";
            this.Close_TAB.Size = new System.Drawing.Size(75, 23);
            this.Close_TAB.TabIndex = 25;
            this.Close_TAB.Text = "Close Tab";
            this.Close_TAB.UseVisualStyleBackColor = true;
            this.Close_TAB.Click += new System.EventHandler(this.Close_TAB_Click);
            // 
            // GO_TO_HOME_PAGE
            // 
            this.GO_TO_HOME_PAGE.Location = new System.Drawing.Point(1021, 8);
            this.GO_TO_HOME_PAGE.Name = "GO_TO_HOME_PAGE";
            this.GO_TO_HOME_PAGE.Size = new System.Drawing.Size(77, 40);
            this.GO_TO_HOME_PAGE.TabIndex = 26;
            this.GO_TO_HOME_PAGE.Text = "HomePage";
            this.GO_TO_HOME_PAGE.UseVisualStyleBackColor = true;
            this.GO_TO_HOME_PAGE.Click += new System.EventHandler(this.GO_TO_HOME_PAGE_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1015, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Go to Home Page";
            // 
            // MyBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 530);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GO_TO_HOME_PAGE);
            this.Controls.Add(this.Close_TAB);
            this.Controls.Add(this.button_VISIT_A_FAVORITE);
            this.Controls.Add(this.main_HTML_Area);
            this.Controls.Add(this.MyListOfFavorites);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_EDIT_FAVORITE);
            this.Controls.Add(this.button_DELETE_FAVORITE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_SEE_YOUR_FAVORITES);
            this.Controls.Add(this.button_ADD_TO_FAVORITES);
            this.Controls.Add(this.button_HISTORY);
            this.Controls.Add(this.button_SET_HOME_PAGE);
            this.Controls.Add(this.button_FWD);
            this.Controls.Add(this.button_BACK);
            this.Controls.Add(this.Button_GO);
            this.Controls.Add(this.textbox_URL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBrowser";
            this.Text = "Firefox Junior";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.main_HTML_Area.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_URL;
        private System.Windows.Forms.Button Button_GO;
        private System.Windows.Forms.Button button_BACK;
        private System.Windows.Forms.Button button_FWD;
        private System.Windows.Forms.Button button_SET_HOME_PAGE;
        private System.Windows.Forms.Button button_HISTORY;
        private System.Windows.Forms.Button button_ADD_TO_FAVORITES;
        private System.Windows.Forms.Button button_SEE_YOUR_FAVORITES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_DELETE_FAVORITE;
        private System.Windows.Forms.Button button_EDIT_FAVORITE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox MyListOfFavorites;
        private System.Windows.Forms.TabControl main_HTML_Area;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_VISIT_A_FAVORITE;
        private System.Windows.Forms.Button Close_TAB;
        private System.Windows.Forms.Button GO_TO_HOME_PAGE;
        private System.Windows.Forms.Label label11;
    }
}

