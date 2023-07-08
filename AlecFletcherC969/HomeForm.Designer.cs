
namespace AlecFletcherC969
{
    partial class HomeForm
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
            this.calendarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.monthlyView_radiobutton = new System.Windows.Forms.RadioButton();
            this.weeklyview_radiobutton = new System.Windows.Forms.RadioButton();
            this.mainControls_groupbox = new System.Windows.Forms.GroupBox();
            this.reports_Button = new System.Windows.Forms.Button();
            this.modifyAppointment_button = new System.Windows.Forms.Button();
            this.addAppointment_button = new System.Windows.Forms.Button();
            this.modifyCustomer_button = new System.Windows.Forms.Button();
            this.addCustomer_button = new System.Windows.Forms.Button();
            this.month_label = new System.Windows.Forms.Label();
            this.mainControls_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarContainer
            // 
            this.calendarContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.calendarContainer.Location = new System.Drawing.Point(12, 83);
            this.calendarContainer.Name = "calendarContainer";
            this.calendarContainer.Size = new System.Drawing.Size(1101, 552);
            this.calendarContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(54, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(211, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(363, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tuesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(507, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wednesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(676, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thursday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(847, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(994, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Saturday";
            // 
            // monthlyView_radiobutton
            // 
            this.monthlyView_radiobutton.AutoSize = true;
            this.monthlyView_radiobutton.Checked = true;
            this.monthlyView_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyView_radiobutton.Location = new System.Drawing.Point(12, 15);
            this.monthlyView_radiobutton.Name = "monthlyView_radiobutton";
            this.monthlyView_radiobutton.Size = new System.Drawing.Size(132, 24);
            this.monthlyView_radiobutton.TabIndex = 8;
            this.monthlyView_radiobutton.TabStop = true;
            this.monthlyView_radiobutton.Text = "Monthly View";
            this.monthlyView_radiobutton.UseVisualStyleBackColor = true;
            this.monthlyView_radiobutton.CheckedChanged += new System.EventHandler(this.monthlyView_radiobutton_CheckedChanged);
            // 
            // weeklyview_radiobutton
            // 
            this.weeklyview_radiobutton.AutoSize = true;
            this.weeklyview_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyview_radiobutton.Location = new System.Drawing.Point(181, 15);
            this.weeklyview_radiobutton.Name = "weeklyview_radiobutton";
            this.weeklyview_radiobutton.Size = new System.Drawing.Size(127, 24);
            this.weeklyview_radiobutton.TabIndex = 9;
            this.weeklyview_radiobutton.Text = "Weekly View";
            this.weeklyview_radiobutton.UseVisualStyleBackColor = true;
            this.weeklyview_radiobutton.CheckedChanged += new System.EventHandler(this.weeklyview_radiobutton_CheckedChanged);
            // 
            // mainControls_groupbox
            // 
            this.mainControls_groupbox.Controls.Add(this.reports_Button);
            this.mainControls_groupbox.Controls.Add(this.modifyAppointment_button);
            this.mainControls_groupbox.Controls.Add(this.addAppointment_button);
            this.mainControls_groupbox.Controls.Add(this.modifyCustomer_button);
            this.mainControls_groupbox.Controls.Add(this.addCustomer_button);
            this.mainControls_groupbox.Location = new System.Drawing.Point(1122, 62);
            this.mainControls_groupbox.Name = "mainControls_groupbox";
            this.mainControls_groupbox.Size = new System.Drawing.Size(243, 343);
            this.mainControls_groupbox.TabIndex = 14;
            this.mainControls_groupbox.TabStop = false;
            // 
            // reports_Button
            // 
            this.reports_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.reports_Button.Location = new System.Drawing.Point(8, 276);
            this.reports_Button.Name = "reports_Button";
            this.reports_Button.Size = new System.Drawing.Size(232, 60);
            this.reports_Button.TabIndex = 16;
            this.reports_Button.Text = "View / Generate Reports";
            this.reports_Button.UseVisualStyleBackColor = true;
            this.reports_Button.Click += new System.EventHandler(this.reports_Button_Click);
            // 
            // modifyAppointment_button
            // 
            this.modifyAppointment_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modifyAppointment_button.Location = new System.Drawing.Point(6, 210);
            this.modifyAppointment_button.Name = "modifyAppointment_button";
            this.modifyAppointment_button.Size = new System.Drawing.Size(232, 60);
            this.modifyAppointment_button.TabIndex = 15;
            this.modifyAppointment_button.Text = "View Appointments";
            this.modifyAppointment_button.UseVisualStyleBackColor = true;
            this.modifyAppointment_button.Click += new System.EventHandler(this.modifyAppointment_button_Click);
            // 
            // addAppointment_button
            // 
            this.addAppointment_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addAppointment_button.Location = new System.Drawing.Point(6, 144);
            this.addAppointment_button.Name = "addAppointment_button";
            this.addAppointment_button.Size = new System.Drawing.Size(232, 60);
            this.addAppointment_button.TabIndex = 14;
            this.addAppointment_button.Text = "Add Appointment";
            this.addAppointment_button.UseVisualStyleBackColor = true;
            this.addAppointment_button.Click += new System.EventHandler(this.addAppointment_button_Click);
            // 
            // modifyCustomer_button
            // 
            this.modifyCustomer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modifyCustomer_button.Location = new System.Drawing.Point(6, 78);
            this.modifyCustomer_button.Name = "modifyCustomer_button";
            this.modifyCustomer_button.Size = new System.Drawing.Size(232, 60);
            this.modifyCustomer_button.TabIndex = 12;
            this.modifyCustomer_button.Text = "View Customer List";
            this.modifyCustomer_button.UseVisualStyleBackColor = true;
            this.modifyCustomer_button.Click += new System.EventHandler(this.modifyCustomer_button_Click);
            // 
            // addCustomer_button
            // 
            this.addCustomer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.addCustomer_button.Location = new System.Drawing.Point(6, 12);
            this.addCustomer_button.Name = "addCustomer_button";
            this.addCustomer_button.Size = new System.Drawing.Size(232, 60);
            this.addCustomer_button.TabIndex = 11;
            this.addCustomer_button.Text = "Add Customer";
            this.addCustomer_button.UseVisualStyleBackColor = true;
            this.addCustomer_button.Click += new System.EventHandler(this.addCustomer_button_Click);
            // 
            // month_label
            // 
            this.month_label.AutoSize = true;
            this.month_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_label.Location = new System.Drawing.Point(514, 8);
            this.month_label.Name = "month_label";
            this.month_label.Size = new System.Drawing.Size(95, 33);
            this.month_label.TabIndex = 15;
            this.month_label.Text = "Month";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 647);
            this.Controls.Add(this.month_label);
            this.Controls.Add(this.mainControls_groupbox);
            this.Controls.Add(this.weeklyview_radiobutton);
            this.Controls.Add(this.monthlyView_radiobutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendarContainer);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.mainControls_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel calendarContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton monthlyView_radiobutton;
        private System.Windows.Forms.RadioButton weeklyview_radiobutton;
        private System.Windows.Forms.GroupBox mainControls_groupbox;
        private System.Windows.Forms.Button modifyAppointment_button;
        private System.Windows.Forms.Button addAppointment_button;
        private System.Windows.Forms.Button modifyCustomer_button;
        private System.Windows.Forms.Button addCustomer_button;
        private System.Windows.Forms.Label month_label;
        private System.Windows.Forms.Button reports_Button;
    }
}