
namespace AlecFletcherC969
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.eventGroupBox = new System.Windows.Forms.GroupBox();
            this.reportDG = new System.Windows.Forms.DataGridView();
            this.uniqueAppointments_radioButton = new System.Windows.Forms.RadioButton();
            this.consultantSchedule_radioButton = new System.Windows.Forms.RadioButton();
            this.customerAppointments_radioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.eventGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDG)).BeginInit();
            this.SuspendLayout();
            // 
            // eventGroupBox
            // 
            this.eventGroupBox.Controls.Add(this.reportDG);
            this.eventGroupBox.Location = new System.Drawing.Point(12, 102);
            this.eventGroupBox.Name = "eventGroupBox";
            this.eventGroupBox.Size = new System.Drawing.Size(425, 382);
            this.eventGroupBox.TabIndex = 0;
            this.eventGroupBox.TabStop = false;
            // 
            // reportDG
            // 
            this.reportDG.AllowUserToAddRows = false;
            this.reportDG.AllowUserToDeleteRows = false;
            this.reportDG.AllowUserToResizeColumns = false;
            this.reportDG.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reportDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.reportDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportDG.DefaultCellStyle = dataGridViewCellStyle15;
            this.reportDG.Location = new System.Drawing.Point(6, 16);
            this.reportDG.MultiSelect = false;
            this.reportDG.Name = "reportDG";
            this.reportDG.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.reportDG.RowHeadersVisible = false;
            this.reportDG.RowTemplate.Height = 26;
            this.reportDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportDG.Size = new System.Drawing.Size(413, 353);
            this.reportDG.TabIndex = 0;
            // 
            // uniqueAppointments_radioButton
            // 
            this.uniqueAppointments_radioButton.AutoSize = true;
            this.uniqueAppointments_radioButton.Checked = true;
            this.uniqueAppointments_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniqueAppointments_radioButton.Location = new System.Drawing.Point(12, 12);
            this.uniqueAppointments_radioButton.Name = "uniqueAppointments_radioButton";
            this.uniqueAppointments_radioButton.Size = new System.Drawing.Size(181, 24);
            this.uniqueAppointments_radioButton.TabIndex = 1;
            this.uniqueAppointments_radioButton.TabStop = true;
            this.uniqueAppointments_radioButton.Text = "Unique Appointments";
            this.uniqueAppointments_radioButton.UseVisualStyleBackColor = true;
            this.uniqueAppointments_radioButton.CheckedChanged += new System.EventHandler(this.uniqueAppointments_radioButton_CheckedChanged);
            // 
            // consultantSchedule_radioButton
            // 
            this.consultantSchedule_radioButton.AutoSize = true;
            this.consultantSchedule_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultantSchedule_radioButton.Location = new System.Drawing.Point(256, 12);
            this.consultantSchedule_radioButton.Name = "consultantSchedule_radioButton";
            this.consultantSchedule_radioButton.Size = new System.Drawing.Size(175, 24);
            this.consultantSchedule_radioButton.TabIndex = 2;
            this.consultantSchedule_radioButton.Text = "Consultant Schedule";
            this.consultantSchedule_radioButton.UseVisualStyleBackColor = true;
            this.consultantSchedule_radioButton.CheckedChanged += new System.EventHandler(this.consultantSchedule_radioButton_CheckedChanged);
            // 
            // customerAppointments_radioButton
            // 
            this.customerAppointments_radioButton.AutoSize = true;
            this.customerAppointments_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAppointments_radioButton.Location = new System.Drawing.Point(104, 52);
            this.customerAppointments_radioButton.Name = "customerAppointments_radioButton";
            this.customerAppointments_radioButton.Size = new System.Drawing.Size(219, 24);
            this.customerAppointments_radioButton.TabIndex = 3;
            this.customerAppointments_radioButton.Text = "Appointments by Customer";
            this.customerAppointments_radioButton.UseVisualStyleBackColor = true;
            this.customerAppointments_radioButton.CheckedChanged += new System.EventHandler(this.customerAppointments_radioButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(324, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerAppointments_radioButton);
            this.Controls.Add(this.consultantSchedule_radioButton);
            this.Controls.Add(this.uniqueAppointments_radioButton);
            this.Controls.Add(this.eventGroupBox);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.eventGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox eventGroupBox;
        private System.Windows.Forms.DataGridView reportDG;
        private System.Windows.Forms.RadioButton uniqueAppointments_radioButton;
        private System.Windows.Forms.RadioButton consultantSchedule_radioButton;
        private System.Windows.Forms.RadioButton customerAppointments_radioButton;
        private System.Windows.Forms.Button button1;
    }
}