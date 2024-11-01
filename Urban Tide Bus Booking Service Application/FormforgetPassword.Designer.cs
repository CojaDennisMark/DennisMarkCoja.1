namespace Urban_Tide_Bus_Booking_Service_Application
{
    partial class FormforgetPassword
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
            this.label2titlepassword = new System.Windows.Forms.Label();
            this.label1titleusername = new System.Windows.Forms.Label();
            this.textBoxCNIC = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2titlepassword
            // 
            this.label2titlepassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2titlepassword.AutoSize = true;
            this.label2titlepassword.BackColor = System.Drawing.Color.Transparent;
            this.label2titlepassword.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2titlepassword.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2titlepassword.Location = new System.Drawing.Point(35, 172);
            this.label2titlepassword.Name = "label2titlepassword";
            this.label2titlepassword.Size = new System.Drawing.Size(215, 45);
            this.label2titlepassword.TabIndex = 35;
            this.label2titlepassword.Text = "Date of Birth:";
            // 
            // label1titleusername
            // 
            this.label1titleusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1titleusername.AutoSize = true;
            this.label1titleusername.BackColor = System.Drawing.Color.Transparent;
            this.label1titleusername.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1titleusername.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1titleusername.Location = new System.Drawing.Point(148, 61);
            this.label1titleusername.Name = "label1titleusername";
            this.label1titleusername.Size = new System.Drawing.Size(102, 45);
            this.label1titleusername.TabIndex = 36;
            this.label1titleusername.Text = "CNIC:";
            this.label1titleusername.Click += new System.EventHandler(this.label1titleusername_Click);
            // 
            // textBoxCNIC
            // 
            this.textBoxCNIC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCNIC.BackColor = System.Drawing.Color.White;
            this.textBoxCNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCNIC.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCNIC.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxCNIC.Location = new System.Drawing.Point(256, 69);
            this.textBoxCNIC.Multiline = true;
            this.textBoxCNIC.Name = "textBoxCNIC";
            this.textBoxCNIC.Size = new System.Drawing.Size(380, 37);
            this.textBoxCNIC.TabIndex = 34;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNext.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(256, 274);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(380, 65);
            this.buttonNext.TabIndex = 39;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.button2guest_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(256, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 65);
            this.button1.TabIndex = 40;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(256, 191);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(380, 20);
            this.dateTimePickerDOB.TabIndex = 41;
            // 
            // FormforgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label2titlepassword);
            this.Controls.Add(this.label1titleusername);
            this.Controls.Add(this.textBoxCNIC);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormforgetPassword";
            this.Text = "FormforgetPassword";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FormforgetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2titlepassword;
        private System.Windows.Forms.Label label1titleusername;
        private System.Windows.Forms.TextBox textBoxCNIC;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
    }
}