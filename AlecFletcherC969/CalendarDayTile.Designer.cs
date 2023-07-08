
namespace AlecFletcherC969
{
    partial class CalendarDayTile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayNum_label = new System.Windows.Forms.Label();
            this.appointmentNum_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayNum_label
            // 
            this.dayNum_label.AutoSize = true;
            this.dayNum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dayNum_label.Location = new System.Drawing.Point(0, 0);
            this.dayNum_label.Name = "dayNum_label";
            this.dayNum_label.Size = new System.Drawing.Size(40, 24);
            this.dayNum_label.TabIndex = 0;
            this.dayNum_label.Text = "day";
            // 
            // appointmentNum_label
            // 
            this.appointmentNum_label.AutoSize = true;
            this.appointmentNum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.appointmentNum_label.Location = new System.Drawing.Point(5, 51);
            this.appointmentNum_label.Name = "appointmentNum_label";
            this.appointmentNum_label.Size = new System.Drawing.Size(145, 24);
            this.appointmentNum_label.TabIndex = 1;
            this.appointmentNum_label.Text = "X Appointments";
            // 
            // CalendarDayTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.appointmentNum_label);
            this.Controls.Add(this.dayNum_label);
            this.Name = "CalendarDayTile";
            this.Size = new System.Drawing.Size(151, 104);
            this.Load += new System.EventHandler(this.CalendarDayTile_Load);
            this.Click += new System.EventHandler(this.CalendarDayTile_Click);
            this.MouseEnter += new System.EventHandler(this.CalendarDayTile_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CalendarDayTile_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayNum_label;
        private System.Windows.Forms.Label appointmentNum_label;
    }
}
