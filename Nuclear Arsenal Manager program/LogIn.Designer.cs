namespace Nuclear_Arsenal_Manager_program
{
    partial class LogIn
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.securityQuestionLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.securityQuestionTexBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.logInLabel = new System.Windows.Forms.Label();
            this.verifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(419, 66);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "STRATEGIC ARMS READINESS MANAGEMENT SYSTEM";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(173, 129);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.PasswordChar = '#';
            this.idTextBox.Size = new System.Drawing.Size(190, 22);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.UseSystemPasswordChar = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(173, 161);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(190, 22);
            this.passwordTextBox.TabIndex = 2;
            // 
            // positionComboBox
            // 
            this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "Regular",
            "Site Director",
            "Administrator"});
            this.positionComboBox.Location = new System.Drawing.Point(173, 193);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(190, 24);
            this.positionComboBox.TabIndex = 4;
            // 
            // securityQuestionLabel
            // 
            this.securityQuestionLabel.AutoSize = true;
            this.securityQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityQuestionLabel.Location = new System.Drawing.Point(91, 279);
            this.securityQuestionLabel.Name = "securityQuestionLabel";
            this.securityQuestionLabel.Size = new System.Drawing.Size(262, 16);
            this.securityQuestionLabel.TabIndex = 5;
            this.securityQuestionLabel.Text = "INSERT CUSTOM SECURITY QUESTION";
            this.securityQuestionLabel.Visible = false;
            // 
            // logInButton
            // 
            this.logInButton.AutoSize = true;
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(185, 334);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 30);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "LOG IN";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Visible = false;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(50, 433);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(344, 39);
            this.warningLabel.TabIndex = 7;
            this.warningLabel.Text = "AUTHORIZED PERSONNEL ONLY\r\nALL ACCESS IS LOGGED AND MONITORED\r\nUNAUTHORIZED ACCES" +
    "S OR FAILED LOG IN WILL BE DETECTED";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // securityQuestionTexBox
            // 
            this.securityQuestionTexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.securityQuestionTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityQuestionTexBox.Location = new System.Drawing.Point(128, 306);
            this.securityQuestionTexBox.Name = "securityQuestionTexBox";
            this.securityQuestionTexBox.Size = new System.Drawing.Size(189, 22);
            this.securityQuestionTexBox.TabIndex = 8;
            this.securityQuestionTexBox.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(81, 131);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 16);
            this.idLabel.TabIndex = 9;
            this.idLabel.Text = "ID";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(81, 163);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 16);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(81, 196);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(70, 16);
            this.positionLabel.TabIndex = 11;
            this.positionLabel.Text = "POSITION";
            // 
            // logInLabel
            // 
            this.logInLabel.AutoSize = true;
            this.logInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel.Location = new System.Drawing.Point(181, 75);
            this.logInLabel.Name = "logInLabel";
            this.logInLabel.Size = new System.Drawing.Size(82, 25);
            this.logInLabel.TabIndex = 12;
            this.logInLabel.Text = "LOG IN";
            // 
            // verifyButton
            // 
            this.verifyButton.AutoSize = true;
            this.verifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyButton.Location = new System.Drawing.Point(183, 227);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(79, 30);
            this.verifyButton.TabIndex = 13;
            this.verifyButton.Text = "VERIFY";
            this.verifyButton.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 481);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.logInLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.securityQuestionTexBox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.securityQuestionLabel);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.titleLabel);
            this.MaximumSize = new System.Drawing.Size(460, 520);
            this.MinimumSize = new System.Drawing.Size(460, 520);
            this.Name = "LogIn";
            this.Text = "Strategic Arms Readiness Management System";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Label securityQuestionLabel;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.TextBox securityQuestionTexBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label logInLabel;
        private System.Windows.Forms.Button verifyButton;
    }
}

