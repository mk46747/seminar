namespace NannyApp.Presentation
{
    partial class MainNannyForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.offersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewParentOffersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewNannyOffersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // offersToolStripMenuItem
            // 
            this.offersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOfferToolStripMenuItem,
            this.viewParentOffersToolStripMenuItem,
            this.viewNannyOffersToolStripMenuItem});
            this.offersToolStripMenuItem.Name = "offersToolStripMenuItem";
            this.offersToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.offersToolStripMenuItem.Text = "Offers";
            // 
            // createOfferToolStripMenuItem
            // 
            this.createOfferToolStripMenuItem.Name = "createOfferToolStripMenuItem";
            this.createOfferToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.createOfferToolStripMenuItem.Text = "Create offer";
            // 
            // viewParentOffersToolStripMenuItem
            // 
            this.viewParentOffersToolStripMenuItem.Name = "viewParentOffersToolStripMenuItem";
            this.viewParentOffersToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewParentOffersToolStripMenuItem.Text = "View parent offers";
            // 
            // viewNannyOffersToolStripMenuItem
            // 
            this.viewNannyOffersToolStripMenuItem.Name = "viewNannyOffersToolStripMenuItem";
            this.viewNannyOffersToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewNannyOffersToolStripMenuItem.Text = "View nanny offers";
            // 
            // MainNannyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 267);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainNannyForm";
            this.Text = "MainNannyForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem offersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOfferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewParentOffersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewNannyOffersToolStripMenuItem;
    }
}