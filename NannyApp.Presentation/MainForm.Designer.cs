namespace NannyApp.Presentation
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NannyOffersList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParentOffersList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loginButton = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cooperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cooperations = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giving services";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(432, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Looking for services";
            // 
            // NannyOffersList
            // 
            this.NannyOffersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.username,
            this.city,
            this.Price,
            this.deadline});
            this.NannyOffersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NannyOffersList.HoverSelection = true;
            this.NannyOffersList.Location = new System.Drawing.Point(27, 78);
            this.NannyOffersList.Name = "NannyOffersList";
            this.NannyOffersList.Size = new System.Drawing.Size(377, 203);
            this.NannyOffersList.TabIndex = 3;
            this.NannyOffersList.UseCompatibleStateImageBehavior = false;
            this.NannyOffersList.View = System.Windows.Forms.View.Details;
            this.NannyOffersList.Click += new System.EventHandler(this.ShowNannyOffer);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // username
            // 
            this.username.Text = "Username";
            this.username.Width = 75;
            // 
            // city
            // 
            this.city.Text = "City";
            this.city.Width = 71;
            // 
            // Price
            // 
            this.Price.Text = "Price per hour";
            this.Price.Width = 95;
            // 
            // deadline
            // 
            this.deadline.Text = "Deadline";
            // 
            // ParentOffersList
            // 
            this.ParentOffersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ParentOffersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ParentOffersList.Location = new System.Drawing.Point(435, 78);
            this.ParentOffersList.Name = "ParentOffersList";
            this.ParentOffersList.Size = new System.Drawing.Size(373, 203);
            this.ParentOffersList.TabIndex = 4;
            this.ParentOffersList.UseCompatibleStateImageBehavior = false;
            this.ParentOffersList.View = System.Windows.Forms.View.Details;
            this.ParentOffersList.Click += new System.EventHandler(this.ShowParentOffer);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "City";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "Price per hour";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 4;
            this.columnHeader4.Text = "Deadline";
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 0;
            this.columnHeader5.Text = "Id";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.Location = new System.Drawing.Point(27, 309);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(781, 58);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login or create account";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.ShowLoginForm);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.offersToolStripMenuItem,
            this.cooperationsToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(847, 24);
            this.menu.TabIndex = 6;
            this.menu.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "My profile";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.ShowMyProfile);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.Logout);
            // 
            // offersToolStripMenuItem
            // 
            this.offersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOfferToolStripMenuItem});
            this.offersToolStripMenuItem.Name = "offersToolStripMenuItem";
            this.offersToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.offersToolStripMenuItem.Text = "Offers";
            // 
            // addOfferToolStripMenuItem
            // 
            this.addOfferToolStripMenuItem.Name = "addOfferToolStripMenuItem";
            this.addOfferToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addOfferToolStripMenuItem.Text = "Add offer";
            this.addOfferToolStripMenuItem.Click += new System.EventHandler(this.ShowOfferForm);
            // 
            // cooperationsToolStripMenuItem
            // 
            this.cooperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cooperations});
            this.cooperationsToolStripMenuItem.Name = "cooperationsToolStripMenuItem";
            this.cooperationsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.cooperationsToolStripMenuItem.Text = "Cooperations";
            // 
            // Cooperations
            // 
            this.Cooperations.Name = "Cooperations";
            this.Cooperations.Size = new System.Drawing.Size(158, 22);
            this.Cooperations.Text = "My Coperations";
            this.Cooperations.Click += new System.EventHandler(this.ShowMyCooperations);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeLabel.Location = new System.Drawing.Point(24, 24);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 16);
            this.welcomeLabel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 386);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.ParentOffersList);
            this.Controls.Add(this.NannyOffersList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "StartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView NannyOffersList;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader deadline;
        private System.Windows.Forms.ListView ParentOffersList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOfferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cooperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Cooperations;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}