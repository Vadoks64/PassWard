
namespace PassWard
{
    partial class Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titlelabel = new System.Windows.Forms.Label();
            this.urpassLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.genereateBtn = new System.Windows.Forms.Button();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.copiedlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numChtrs = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.websitetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PassWard.Properties.Resources.lock_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titlelabel.ForeColor = System.Drawing.Color.White;
            this.titlelabel.Location = new System.Drawing.Point(54, 23);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(91, 28);
            this.titlelabel.TabIndex = 1;
            this.titlelabel.Text = "Passward";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urpassLabel
            // 
            this.urpassLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.urpassLabel.AutoSize = true;
            this.urpassLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.urpassLabel.ForeColor = System.Drawing.Color.White;
            this.urpassLabel.Location = new System.Drawing.Point(54, 125);
            this.urpassLabel.Name = "urpassLabel";
            this.urpassLabel.Size = new System.Drawing.Size(247, 32);
            this.urpassLabel.TabIndex = 2;
            this.urpassLabel.Text = "Your New Password:";
            this.urpassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passLabel
            // 
            this.passLabel.AutoEllipsis = true;
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passLabel.ForeColor = System.Drawing.Color.White;
            this.passLabel.Location = new System.Drawing.Point(54, 157);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(236, 28);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password will appear here";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passLabel.Click += new System.EventHandler(this.passLabel_Click);
            // 
            // genereateBtn
            // 
            this.genereateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.genereateBtn.FlatAppearance.BorderSize = 0;
            this.genereateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genereateBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genereateBtn.ForeColor = System.Drawing.Color.White;
            this.genereateBtn.Location = new System.Drawing.Point(587, 414);
            this.genereateBtn.Name = "genereateBtn";
            this.genereateBtn.Size = new System.Drawing.Size(157, 51);
            this.genereateBtn.TabIndex = 4;
            this.genereateBtn.Text = "Generate";
            this.genereateBtn.UseVisualStyleBackColor = true;
            this.genereateBtn.Click += new System.EventHandler(this.genereateBtn_Click);
            // 
            // CopyBtn
            // 
            this.CopyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.CopyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.CopyBtn.FlatAppearance.BorderSize = 0;
            this.CopyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopyBtn.ForeColor = System.Drawing.Color.White;
            this.CopyBtn.Location = new System.Drawing.Point(89, 199);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(167, 32);
            this.CopyBtn.TabIndex = 5;
            this.CopyBtn.Text = "Copy to Clipboard";
            this.CopyBtn.UseVisualStyleBackColor = false;
            this.CopyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // copiedlabel
            // 
            this.copiedlabel.AutoSize = true;
            this.copiedlabel.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copiedlabel.ForeColor = System.Drawing.Color.White;
            this.copiedlabel.Location = new System.Drawing.Point(113, 234);
            this.copiedlabel.Name = "copiedlabel";
            this.copiedlabel.Size = new System.Drawing.Size(115, 15);
            this.copiedlabel.TabIndex = 6;
            this.copiedlabel.Text = "Copied to clipboard!";
            this.copiedlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.copiedlabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number of Characters:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numChtrs
            // 
            this.numChtrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.numChtrs.ForeColor = System.Drawing.Color.White;
            this.numChtrs.Location = new System.Drawing.Point(250, 291);
            this.numChtrs.Name = "numChtrs";
            this.numChtrs.Size = new System.Drawing.Size(27, 31);
            this.numChtrs.TabIndex = 15;
            this.numChtrs.Text = "8";
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(54, 414);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(157, 51);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // websitetxt
            // 
            this.websitetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.websitetxt.ForeColor = System.Drawing.Color.White;
            this.websitetxt.Location = new System.Drawing.Point(533, 128);
            this.websitetxt.Name = "websitetxt";
            this.websitetxt.Size = new System.Drawing.Size(211, 31);
            this.websitetxt.TabIndex = 17;
            this.websitetxt.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Website used:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(779, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.websitetxt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.numChtrs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.copiedlabel);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.genereateBtn);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.urpassLabel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label urpassLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button genereateBtn;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Label copiedlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numChtrs;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox websitetxt;
        private System.Windows.Forms.Label label1;
    }
}

