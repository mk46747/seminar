namespace NannyApp.Presentation
{
    partial class ReviewForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReviewCommentTextBox = new System.Windows.Forms.TextBox();
            this.ReviewScoreNumeric = new System.Windows.Forms.NumericUpDown();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveReviewButton = new System.Windows.Forms.Button();
            this.cooperationId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewScoreNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReviewCommentTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReviewScoreNumeric, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BackButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SaveReviewButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Review score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReviewCommentTextBox
            // 
            this.ReviewCommentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReviewCommentTextBox.Location = new System.Drawing.Point(93, 41);
            this.ReviewCommentTextBox.Name = "ReviewCommentTextBox";
            this.ReviewCommentTextBox.Size = new System.Drawing.Size(266, 20);
            this.ReviewCommentTextBox.TabIndex = 2;
            // 
            // ReviewScoreNumeric
            // 
            this.ReviewScoreNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReviewScoreNumeric.Location = new System.Drawing.Point(93, 7);
            this.ReviewScoreNumeric.Name = "ReviewScoreNumeric";
            this.ReviewScoreNumeric.Size = new System.Drawing.Size(266, 20);
            this.ReviewScoreNumeric.TabIndex = 3;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Location = new System.Drawing.Point(3, 74);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(84, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // SaveReviewButton
            // 
            this.SaveReviewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveReviewButton.Location = new System.Drawing.Point(93, 74);
            this.SaveReviewButton.Name = "SaveReviewButton";
            this.SaveReviewButton.Size = new System.Drawing.Size(266, 23);
            this.SaveReviewButton.TabIndex = 5;
            this.SaveReviewButton.Text = "Save review";
            this.SaveReviewButton.UseVisualStyleBackColor = true;
            this.SaveReviewButton.Click += new System.EventHandler(this.SaveReview);
            // 
            // cooperationId
            // 
            this.cooperationId.AutoSize = true;
            this.cooperationId.Location = new System.Drawing.Point(0, 0);
            this.cooperationId.Name = "cooperationId";
            this.cooperationId.Size = new System.Drawing.Size(0, 13);
            this.cooperationId.TabIndex = 1;
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 104);
            this.Controls.Add(this.cooperationId);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReviewForm";
            this.Text = "Review";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewScoreNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReviewCommentTextBox;
        private System.Windows.Forms.NumericUpDown ReviewScoreNumeric;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveReviewButton;
        private System.Windows.Forms.Label cooperationId;
    }
}