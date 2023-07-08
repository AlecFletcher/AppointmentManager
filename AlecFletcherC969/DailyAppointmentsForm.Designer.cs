
namespace AlecFletcherC969
{
    partial class DailyAppointmentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.appointmentsDG = new System.Windows.Forms.DataGridView();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDG)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsDG
            // 
            this.appointmentsDG.AllowUserToAddRows = false;
            this.appointmentsDG.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.appointmentsDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentsDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.appointmentsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.appointmentsDG.DefaultCellStyle = dataGridViewCellStyle6;
            this.appointmentsDG.Location = new System.Drawing.Point(12, 63);
            this.appointmentsDG.MultiSelect = false;
            this.appointmentsDG.Name = "appointmentsDG";
            this.appointmentsDG.ReadOnly = true;
            this.appointmentsDG.RowHeadersVisible = false;
            this.appointmentsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentsDG.Size = new System.Drawing.Size(477, 388);
            this.appointmentsDG.TabIndex = 0;
            // 
            // close_button
            // 
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.close_button.Location = new System.Drawing.Point(382, 480);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(107, 41);
            this.close_button.TabIndex = 1;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // DailyAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 533);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.appointmentsDG);
            this.Name = "DailyAppointmentsForm";
            this.Text = "DailyAppointmentsForm";
            this.Load += new System.EventHandler(this.DailyAppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentsDG;
        private System.Windows.Forms.Button close_button;
    }
}