
namespace AlecFletcherC969
{
    partial class WeeklyCalendarTile
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
            this.day_label = new System.Windows.Forms.Label();
            this.appointments_controlbox = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_label.Location = new System.Drawing.Point(3, 0);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(42, 24);
            this.day_label.TabIndex = 0;
            this.day_label.Text = "Day";
            // 
            // appointments_controlbox
            // 
            this.appointments_controlbox.Location = new System.Drawing.Point(0, 27);
            this.appointments_controlbox.Name = "appointments_controlbox";
            this.appointments_controlbox.Size = new System.Drawing.Size(151, 215);
            this.appointments_controlbox.TabIndex = 1;
            this.appointments_controlbox.MouseEnter += new System.EventHandler(this.appointments_controlbox_MouseEnter);
            this.appointments_controlbox.MouseLeave += new System.EventHandler(this.appointments_controlbox_MouseLeave);
            // 
            // WeeklyCalendarTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.appointments_controlbox);
            this.Controls.Add(this.day_label);
            this.Name = "WeeklyCalendarTile";
            this.Size = new System.Drawing.Size(151, 245);
            this.Load += new System.EventHandler(this.WeeklyCalendarTile_Load);
            this.MouseEnter += new System.EventHandler(this.WeeklyCalendarTile_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.WeeklyCalendarTile_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.FlowLayoutPanel appointments_controlbox;
    }
}
