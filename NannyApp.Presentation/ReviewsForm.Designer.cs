namespace NannyApp.Presentation
{
    partial class ReviewsForm
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
        ////////////////////////
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BackButton = new System.Windows.Forms.Button();
            this.ReviewsListView = new System.Windows.Forms.ListView();
            this.ParentColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReviewScoreColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BackButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReviewsListView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 279);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Location = new System.Drawing.Point(3, 248);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(436, 19);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ReviewsListView
            // 
            this.ReviewsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ParentColumnHeader,
            this.ReviewScoreColumnHeader});
            this.ReviewsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReviewsListView.Location = new System.Drawing.Point(3, 3);
            this.ReviewsListView.Name = "ReviewsListView";
            this.ReviewsListView.Size = new System.Drawing.Size(436, 231);
            this.ReviewsListView.TabIndex = 1;
            this.ReviewsListView.UseCompatibleStateImageBehavior = false;
            this.ReviewsListView.View = System.Windows.Forms.View.Details;
            // 
            // ParentColumnHeader
            // 
            this.ParentColumnHeader.Text = "Grade";
            this.ParentColumnHeader.Width = 88;
            // 
            // ReviewScoreColumnHeader
            // 
            this.ReviewScoreColumnHeader.Text = "Review";
            this.ReviewScoreColumnHeader.Width = 342;
            // 
            // ReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 279);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReviewsForm";
            this.Text = "Reviews";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView ReviewsListView;
        private System.Windows.Forms.ColumnHeader ParentColumnHeader;
        private System.Windows.Forms.ColumnHeader ReviewScoreColumnHeader;
    }
}