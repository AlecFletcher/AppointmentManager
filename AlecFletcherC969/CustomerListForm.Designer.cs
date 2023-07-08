
namespace AlecFletcherC969
{
    partial class CustomerListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerDG = new System.Windows.Forms.DataGridView();
            this.modify_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.search_Textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerDG)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDG
            // 
            this.customerDG.AllowUserToAddRows = false;
            this.customerDG.AllowUserToDeleteRows = false;
            this.customerDG.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customerDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.customerDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDG.Location = new System.Drawing.Point(12, 73);
            this.customerDG.MultiSelect = false;
            this.customerDG.Name = "customerDG";
            this.customerDG.ReadOnly = true;
            this.customerDG.RowHeadersVisible = false;
            this.customerDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDG.ShowEditingIcon = false;
            this.customerDG.Size = new System.Drawing.Size(705, 252);
            this.customerDG.TabIndex = 0;
            // 
            // modify_button
            // 
            this.modify_button.Location = new System.Drawing.Point(12, 331);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(89, 37);
            this.modify_button.TabIndex = 1;
            this.modify_button.Text = "Modify";
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.modify_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(107, 331);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(89, 37);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(628, 401);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(89, 37);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(628, 42);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(89, 25);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_Textbox
            // 
            this.search_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_Textbox.Location = new System.Drawing.Point(478, 43);
            this.search_Textbox.Name = "search_Textbox";
            this.search_Textbox.Size = new System.Drawing.Size(144, 22);
            this.search_Textbox.TabIndex = 6;
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.search_Textbox);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.modify_button);
            this.Controls.Add(this.customerDG);
            this.Name = "CustomerListForm";
            this.Text = "CustomerListForm";
            this.Load += new System.EventHandler(this.CustomerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView customerDG;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_Textbox;
    }
}