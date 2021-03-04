
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
            this.fNameTextbox = new System.Windows.Forms.TextBox();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobCalendar = new System.Windows.Forms.MonthCalendar();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.dataList = new System.Windows.Forms.ListView();
            this.submitButton = new System.Windows.Forms.Button();
            this.getDataButton = new System.Windows.Forms.Button();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.feedbackTextBox = new System.Windows.Forms.TextBox();
            clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.Location = new System.Drawing.Point(221, 295);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(113, 23);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear";
            clearButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(21, 241);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(81, 15);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(14, 268);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(88, 15);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone Number";
            // 
            // fNameTextbox
            // 
            this.fNameTextbox.Location = new System.Drawing.Point(107, 15);
            this.fNameTextbox.Name = "fNameTextbox";
            this.fNameTextbox.Size = new System.Drawing.Size(227, 23);
            this.fNameTextbox.TabIndex = 4;
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(38, 18);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(64, 15);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "First Name";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(29, 80);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(73, 15);
            this.dobLabel.TabIndex = 1;
            this.dobLabel.Text = "Date of Birth";
            // 
            // dobCalendar
            // 
            this.dobCalendar.Location = new System.Drawing.Point(107, 71);
            this.dobCalendar.MaxSelectionCount = 1;
            this.dobCalendar.Name = "dobCalendar";
            this.dobCalendar.ShowToday = false;
            this.dobCalendar.TabIndex = 5;
            this.dobCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.dobCalendar_DateSelected);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(107, 237);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(227, 23);
            this.emailTextbox.TabIndex = 6;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(107, 265);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(227, 23);
            this.phoneTextbox.TabIndex = 7;
            // 
            // dataList
            // 
            this.dataList.HideSelection = false;
            this.dataList.Location = new System.Drawing.Point(340, 12);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(432, 277);
            this.dataList.TabIndex = 8;
            this.dataList.UseCompatibleStateImageBehavior = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(107, 295);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(108, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(340, 295);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(432, 23);
            this.getDataButton.TabIndex = 11;
            this.getDataButton.Text = "Get Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(39, 49);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lNameLabel.TabIndex = 12;
            this.lNameLabel.Text = "Last Name";
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(107, 46);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(227, 23);
            this.lNameTextBox.TabIndex = 13;
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Location = new System.Drawing.Point(107, 326);
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.ReadOnly = true;
            this.feedbackTextBox.Size = new System.Drawing.Size(665, 23);
            this.feedbackTextBox.TabIndex = 14;
            // 
            // ClientForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.feedbackTextBox);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.dobCalendar);
            this.Controls.Add(this.fNameTextbox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.fNameLabel);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox fNameTextbox;
        private System.Windows.Forms.Label fNameLabel;
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
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox feedbackTextBox;
    }
}

