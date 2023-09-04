namespace AudioLoopBackPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            btnBrowse = new Button();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(483, 27);
            txtName.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(501, 31);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(84, 187);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(125, 27);
            txtFrom.TabIndex = 2;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(84, 220);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(125, 27);
            txtTo.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 427);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(btnBrowse);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private Button btnBrowse;
        private TextBox txtFrom;
        private TextBox txtTo;
    }
}