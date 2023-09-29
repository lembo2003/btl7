namespace BTL7
{
    partial class loginchange_form
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
            this.username_lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newpw_txt = new System.Windows.Forms.TextBox();
            this.chang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // username_lb
            // 
            this.username_lb.AutoSize = true;
            this.username_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lb.Location = new System.Drawing.Point(180, 44);
            this.username_lb.Name = "username_lb";
            this.username_lb.Size = new System.Drawing.Size(0, 20);
            this.username_lb.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // newpw_txt
            // 
            this.newpw_txt.Location = new System.Drawing.Point(180, 84);
            this.newpw_txt.Name = "newpw_txt";
            this.newpw_txt.Size = new System.Drawing.Size(163, 20);
            this.newpw_txt.TabIndex = 4;
            // 
            // chang
            // 
            this.chang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chang.Location = new System.Drawing.Point(152, 122);
            this.chang.Name = "chang";
            this.chang.Size = new System.Drawing.Size(75, 23);
            this.chang.TabIndex = 5;
            this.chang.Text = "Đổi";
            this.chang.UseVisualStyleBackColor = true;
            this.chang.Click += new System.EventHandler(this.chang_Click);
            // 
            // loginchange_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 166);
            this.ControlBox = false;
            this.Controls.Add(this.chang);
            this.Controls.Add(this.newpw_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username_lb);
            this.Controls.Add(this.label1);
            this.Name = "loginchange_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi thông tin";
            this.Load += new System.EventHandler(this.loginchange_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username_lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newpw_txt;
        private System.Windows.Forms.Button chang;
    }
}