namespace Messenger
{
    partial class RegisterFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterFrame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerUsernameLabel = new System.Windows.Forms.Label();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.registerPasswordLabel = new System.Windows.Forms.Label();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registerUserButton = new System.Windows.Forms.Button();
            this.alreadyRegisteredLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 249);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // registerUsernameLabel
            // 
            this.registerUsernameLabel.AutoSize = true;
            this.registerUsernameLabel.Location = new System.Drawing.Point(92, 257);
            this.registerUsernameLabel.Name = "registerUsernameLabel";
            this.registerUsernameLabel.Size = new System.Drawing.Size(90, 15);
            this.registerUsernameLabel.TabIndex = 1;
            this.registerUsernameLabel.Text = "Enter Username";
            // 
            // registerUsername
            // 
            this.registerUsername.Location = new System.Drawing.Point(92, 275);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(175, 23);
            this.registerUsername.TabIndex = 2;
            this.registerUsername.TextChanged += new System.EventHandler(this.RegisterUsername_TextChanged);
            // 
            // registerPasswordLabel
            // 
            this.registerPasswordLabel.AutoSize = true;
            this.registerPasswordLabel.Location = new System.Drawing.Point(92, 349);
            this.registerPasswordLabel.Name = "registerPasswordLabel";
            this.registerPasswordLabel.Size = new System.Drawing.Size(87, 15);
            this.registerPasswordLabel.TabIndex = 3;
            this.registerPasswordLabel.Text = "Enter Password";
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(92, 367);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.Size = new System.Drawing.Size(175, 23);
            this.registerPasswordTextBox.TabIndex = 4;
            this.registerPasswordTextBox.TextChanged += new System.EventHandler(this.registerPasswordTextBox_TextChanged);
            // 
            // registerUserButton
            // 
            this.registerUserButton.Location = new System.Drawing.Point(92, 424);
            this.registerUserButton.Name = "registerUserButton";
            this.registerUserButton.Size = new System.Drawing.Size(175, 37);
            this.registerUserButton.TabIndex = 5;
            this.registerUserButton.Text = "Register Account";
            this.registerUserButton.UseVisualStyleBackColor = true;
            this.registerUserButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // alreadyRegisteredLabel
            // 
            this.alreadyRegisteredLabel.AutoSize = true;
            this.alreadyRegisteredLabel.Location = new System.Drawing.Point(115, 492);
            this.alreadyRegisteredLabel.Name = "alreadyRegisteredLabel";
            this.alreadyRegisteredLabel.Size = new System.Drawing.Size(105, 15);
            this.alreadyRegisteredLabel.TabIndex = 7;
            this.alreadyRegisteredLabel.Text = "Already Registered";
            this.alreadyRegisteredLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegisterFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.alreadyRegisteredLabel);
            this.Controls.Add(this.registerUserButton);
            this.Controls.Add(this.registerPasswordTextBox);
            this.Controls.Add(this.registerPasswordLabel);
            this.Controls.Add(this.registerUsername);
            this.Controls.Add(this.registerUsernameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegisterFrame";
            this.Size = new System.Drawing.Size(358, 611);
            this.Load += new System.EventHandler(this.RegisterFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label registerUsernameLabel;
        private TextBox registerUsername;
        private Label registerPasswordLabel;
        private TextBox registerPasswordTextBox;
        private Button registerUserButton;
        private Label alreadyRegisteredLabel;
    }
}
