
namespace ClientApp {
    partial class ClientForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.Windows.Forms.Button clearButton;
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobCalendar = new System.Windows.Forms.MonthCalendar();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.dataList = new System.Windows.Forms.ListView();
            this.submitButton = new System.Windows.Forms.Button();
            this.getDataButton = new System.Windows.Forms.Button();
            clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.Location = new System.Drawing.Point(222, 288);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(113, 23);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear";
            clearButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(22, 234);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(81, 15);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(15, 261);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(88, 15);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone Number";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(108, 38);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(227, 23);
            this.nameTextbox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(64, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 23);
            this.textBox1.TabIndex = 5;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(30, 73);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(73, 15);
            this.dobLabel.TabIndex = 1;
            this.dobLabel.Text = "Date of Birth";
            // 
            // dobCalendar
            // 
            this.dobCalendar.Location = new System.Drawing.Point(108, 64);
            this.dobCalendar.MaxSelectionCount = 1;
            this.dobCalendar.Name = "dobCalendar";
            this.dobCalendar.ShowToday = false;
            this.dobCalendar.TabIndex = 5;
            this.dobCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.dobCalendar_DateSelected);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(108, 230);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(227, 23);
            this.emailTextbox.TabIndex = 6;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(108, 258);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(227, 23);
            this.phoneTextbox.TabIndex = 7;
            // 
            // dataList
            // 
            this.dataList.HideSelection = false;
            this.dataList.Location = new System.Drawing.Point(341, 38);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(432, 243);
            this.dataList.TabIndex = 8;
            this.dataList.UseCompatibleStateImageBehavior = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(108, 288);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(108, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(341, 287);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(432, 23);
            this.getDataButton.TabIndex = 11;
            this.getDataButton.Text = "Get Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 349);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.dobCalendar);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.MonthCalendar dobCalendar;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.ListView dataList;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.Button getDataButton;
    }
}

