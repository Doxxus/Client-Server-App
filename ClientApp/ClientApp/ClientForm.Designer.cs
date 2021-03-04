
namespace ClientApp
{
    partial class ClientForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.email_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dob_label = new System.Windows.Forms.Label();
            this.dob_calendar = new System.Windows.Forms.MonthCalendar();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(22, 234);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(81, 15);
            this.email_label.TabIndex = 2;
            this.email_label.Text = "Email Address";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(15, 261);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(88, 15);
            this.phone_label.TabIndex = 3;
            this.phone_label.Text = "Phone Number";
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(108, 38);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(227, 23);
            this.textbox.TabIndex = 4;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(64, 41);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(39, 15);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 23);
            this.textBox1.TabIndex = 5;
            // 
            // dob_label
            // 
            this.dob_label.AutoSize = true;
            this.dob_label.Location = new System.Drawing.Point(30, 73);
            this.dob_label.Name = "dob_label";
            this.dob_label.Size = new System.Drawing.Size(73, 15);
            this.dob_label.TabIndex = 1;
            this.dob_label.Text = "Date of Birth";
            // 
            // dob_calendar
            // 
            this.dob_calendar.Location = new System.Drawing.Point(108, 64);
            this.dob_calendar.MaxSelectionCount = 1;
            this.dob_calendar.Name = "dob_calendar";
            this.dob_calendar.TabIndex = 5;
            this.dob_calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.dob_calendar_DateSelected);
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(108, 230);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(227, 23);
            this.email_textbox.TabIndex = 6;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(108, 258);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(227, 23);
            this.phone_textbox.TabIndex = 7;
            // 
            // ClientForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.dob_calendar);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.dob_label);
            this.Controls.Add(this.name_label);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dob_label;
        private System.Windows.Forms.MonthCalendar dob_calendar;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
    }
}

