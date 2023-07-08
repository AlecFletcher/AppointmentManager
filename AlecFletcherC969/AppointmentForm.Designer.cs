
namespace AlecFletcherC969
{
    partial class AppointmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerDG = new System.Windows.Forms.DataGridView();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.location_textbox = new System.Windows.Forms.TextBox();
            this.contact_textbox = new System.Windows.Forms.TextBox();
            this.type_textbox = new System.Windows.Forms.TextBox();
            this.url_textbox = new System.Windows.Forms.TextBox();
            this.startDate_timePicker = new System.Windows.Forms.DateTimePicker();
            this.endDate_timePicker = new System.Windows.Forms.DateTimePicker();
            this.title_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.location_label = new System.Windows.Forms.Label();
            this.contact_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.url_label = new System.Windows.Forms.Label();
            this.startDate_label = new System.Windows.Forms.Label();
            this.endDate_label = new System.Windows.Forms.Label();
            this.addAppointment_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDG)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDG
            // 
            this.customerDG.AllowUserToAddRows = false;
            this.customerDG.AllowUserToDeleteRows = false;
            this.customerDG.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customerDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.customerDG.Location = new System.Drawing.Point(12, 45);
            this.customerDG.MultiSelect = false;
            this.customerDG.Name = "customerDG";
            this.customerDG.ReadOnly = true;
            this.customerDG.RowHeadersVisible = false;
            this.customerDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDG.Size = new System.Drawing.Size(651, 168);
            this.customerDG.TabIndex = 0;
            // 
            // title_textbox
            // 
            this.title_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_textbox.Location = new System.Drawing.Point(12, 247);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(143, 26);
            this.title_textbox.TabIndex = 1;
            // 
            // description_textbox
            // 
            this.description_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_textbox.Location = new System.Drawing.Point(12, 314);
            this.description_textbox.Multiline = true;
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(303, 104);
            this.description_textbox.TabIndex = 2;
            // 
            // location_textbox
            // 
            this.location_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_textbox.Location = new System.Drawing.Point(325, 317);
            this.location_textbox.Name = "location_textbox";
            this.location_textbox.Size = new System.Drawing.Size(143, 26);
            this.location_textbox.TabIndex = 3;
            // 
            // contact_textbox
            // 
            this.contact_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_textbox.Location = new System.Drawing.Point(169, 247);
            this.contact_textbox.Name = "contact_textbox";
            this.contact_textbox.Size = new System.Drawing.Size(143, 26);
            this.contact_textbox.TabIndex = 4;
            // 
            // type_textbox
            // 
            this.type_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_textbox.Location = new System.Drawing.Point(325, 247);
            this.type_textbox.Name = "type_textbox";
            this.type_textbox.Size = new System.Drawing.Size(143, 26);
            this.type_textbox.TabIndex = 5;
            // 
            // url_textbox
            // 
            this.url_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_textbox.Location = new System.Drawing.Point(325, 392);
            this.url_textbox.Name = "url_textbox";
            this.url_textbox.Size = new System.Drawing.Size(143, 26);
            this.url_textbox.TabIndex = 6;
            // 
            // startDate_timePicker
            // 
            this.startDate_timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate_timePicker.Location = new System.Drawing.Point(486, 249);
            this.startDate_timePicker.Name = "startDate_timePicker";
            this.startDate_timePicker.Size = new System.Drawing.Size(177, 26);
            this.startDate_timePicker.TabIndex = 7;
            // 
            // endDate_timePicker
            // 
            this.endDate_timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate_timePicker.Location = new System.Drawing.Point(486, 314);
            this.endDate_timePicker.Name = "endDate_timePicker";
            this.endDate_timePicker.Size = new System.Drawing.Size(177, 26);
            this.endDate_timePicker.TabIndex = 8;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(12, 220);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(45, 24);
            this.title_label.TabIndex = 9;
            this.title_label.Text = "Title";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(12, 287);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(104, 24);
            this.description_label.TabIndex = 10;
            this.description_label.Text = "Description";
            // 
            // location_label
            // 
            this.location_label.AutoSize = true;
            this.location_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_label.Location = new System.Drawing.Point(325, 290);
            this.location_label.Name = "location_label";
            this.location_label.Size = new System.Drawing.Size(81, 24);
            this.location_label.TabIndex = 11;
            this.location_label.Text = "Location";
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_label.Location = new System.Drawing.Point(165, 220);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(73, 24);
            this.contact_label.TabIndex = 12;
            this.contact_label.Text = "Contact";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_label.Location = new System.Drawing.Point(321, 220);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(53, 24);
            this.type_label.TabIndex = 13;
            this.type_label.Text = "Type";
            // 
            // url_label
            // 
            this.url_label.AutoSize = true;
            this.url_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_label.Location = new System.Drawing.Point(321, 365);
            this.url_label.Name = "url_label";
            this.url_label.Size = new System.Drawing.Size(46, 24);
            this.url_label.TabIndex = 14;
            this.url_label.Text = "URL";
            // 
            // startDate_label
            // 
            this.startDate_label.AutoSize = true;
            this.startDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate_label.Location = new System.Drawing.Point(482, 223);
            this.startDate_label.Name = "startDate_label";
            this.startDate_label.Size = new System.Drawing.Size(147, 24);
            this.startDate_label.TabIndex = 15;
            this.startDate_label.Text = "Start Date / Time";
            // 
            // endDate_label
            // 
            this.endDate_label.AutoSize = true;
            this.endDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate_label.Location = new System.Drawing.Point(482, 290);
            this.endDate_label.Name = "endDate_label";
            this.endDate_label.Size = new System.Drawing.Size(146, 24);
            this.endDate_label.TabIndex = 16;
            this.endDate_label.Text = "End Date / Time";
            // 
            // addAppointment_button
            // 
            this.addAppointment_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointment_button.Location = new System.Drawing.Point(257, 450);
            this.addAppointment_button.Name = "addAppointment_button";
            this.addAppointment_button.Size = new System.Drawing.Size(164, 61);
            this.addAppointment_button.TabIndex = 17;
            this.addAppointment_button.Text = "Add Appointment";
            this.addAppointment_button.UseVisualStyleBackColor = true;
            this.addAppointment_button.Click += new System.EventHandler(this.addAppointment_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer";
            // 
            // cancel_Button
            // 
            this.cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Button.Location = new System.Drawing.Point(571, 476);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(92, 35);
            this.cancel_Button.TabIndex = 19;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 523);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAppointment_button);
            this.Controls.Add(this.endDate_label);
            this.Controls.Add(this.startDate_label);
            this.Controls.Add(this.url_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.contact_label);
            this.Controls.Add(this.location_label);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.endDate_timePicker);
            this.Controls.Add(this.startDate_timePicker);
            this.Controls.Add(this.url_textbox);
            this.Controls.Add(this.type_textbox);
            this.Controls.Add(this.contact_textbox);
            this.Controls.Add(this.location_textbox);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.title_textbox);
            this.Controls.Add(this.customerDG);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.Shown += new System.EventHandler(this.AppointmentForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.customerDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDG;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.TextBox location_textbox;
        private System.Windows.Forms.TextBox contact_textbox;
        private System.Windows.Forms.TextBox type_textbox;
        private System.Windows.Forms.TextBox url_textbox;
        private System.Windows.Forms.DateTimePicker startDate_timePicker;
        private System.Windows.Forms.DateTimePicker endDate_timePicker;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label location_label;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label url_label;
        private System.Windows.Forms.Label startDate_label;
        private System.Windows.Forms.Label endDate_label;
        private System.Windows.Forms.Button addAppointment_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_Button;
    }
}