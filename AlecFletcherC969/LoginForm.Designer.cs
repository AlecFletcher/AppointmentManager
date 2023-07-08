
namespace AlecFletcherC969
{
    partial class LoginForm
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
            this.login_button = new System.Windows.Forms.Button();
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.login_button.Location = new System.Drawing.Point(124, 291);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(85, 38);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.connect_Button_Click);
            // 
            // username_TextBox
            // 
            this.username_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_TextBox.Location = new System.Drawing.Point(78, 103);
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(183, 26);
            this.username_TextBox.TabIndex = 1;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_TextBox.Location = new System.Drawing.Point(78, 185);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(183, 26);
            this.password_TextBox.TabIndex = 2;
            this.password_TextBox.UseSystemPasswordChar = true;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(74, 76);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(97, 24);
            this.username_label.TabIndex = 3;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(74, 158);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(92, 24);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 450);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.username_TextBox);
            this.Controls.Add(this.login_button);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox username_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
    }
}

