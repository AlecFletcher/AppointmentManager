
namespace AlecFletcherC969
{
    partial class AppointmentListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.appointmentDG = new System.Windows.Forms.DataGridView();
            this.modifyAppointment_button = new System.Windows.Forms.Button();
            this.deleteAppointment_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.search_Textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDG)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDG
            // 
            this.appointmentDG.AllowUserToAddRows = false;
            this.appointmentDG.AllowUserToDeleteRows = false;
            this.appointmentDG.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.appointmentDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.appointmentDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDG.Location = new System.Drawing.Point(12, 65);
            this.appointmentDG.MultiSelect = false;
            this.appointmentDG.Name = "appointmentDG";
            this.appointmentDG.ReadOnly = true;
            this.appointmentDG.RowHeadersVisible = false;
            this.appointmentDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDG.Size = new System.Drawing.Size(776, 278);
            this.appointmentDG.TabIndex = 0;
            // 
            // modifyAppointment_button
            // 
            this.modifyAppointment_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyAppointment_button.Location = new System.Drawing.Point(390, 349);
            this.modifyAppointment_button.Name = "modifyAppointment_button";
            this.modifyAppointment_button.Size = new System.Drawing.Size(196, 47);
            this.modifyAppointment_button.TabIndex = 1;
            this.modifyAppointment_button.Text = "Modify Appointment";
            this.modifyAppointment_button.UseVisualStyleBackColor = true;
            this.modifyAppointment_button.Click += new System.EventHandler(this.modifyAppointment_button_Click);
            // 
            // deleteAppointment_button
            // 
            this.deleteAppointment_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAppointment_button.Location = new System.Drawing.Point(592, 349);
            this.deleteAppointment_button.Name = "deleteAppointment_button";
            this.deleteAppointment_button.Size = new System.Drawing.Size(196, 47);
            this.deleteAppointment_button.TabIndex = 2;
            this.deleteAppointment_button.Text = "Delete Appointment";
            this.deleteAppointment_button.UseVisualStyleBackColor = true;
            this.deleteAppointment_button.Click += new System.EventHandler(this.deleteAppointment_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(659, 432);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(129, 34);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(713, 33);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 26);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_Textbox
            // 
            this.search_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_Textbox.Location = new System.Drawing.Point(563, 35);
            this.search_Textbox.Name = "search_Textbox";
            this.search_Textbox.Size = new System.Drawing.Size(144, 22);
            this.search_Textbox.TabIndex = 5;
            // 
            // AppointmentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.search_Textbox);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.deleteAppointment_button);
            this.Controls.Add(this.modifyAppointment_button);
            this.Controls.Add(this.appointmentDG);
            this.Name = "AppointmentListForm";
            this.Text = "View Appointments";
            this.Load += new System.EventHandler(this.AppointmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentDG;
        private System.Windows.Forms.Button modifyAppointment_button;
        private System.Windows.Forms.Button deleteAppointment_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_Textbox;
    }
}