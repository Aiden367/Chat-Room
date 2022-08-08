namespace Messenger
{
    partial class sendMessageFrame
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
            this.displayedText = new System.Windows.Forms.TextBox();
            this.sendMessageTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayedText
            // 
            this.displayedText.Location = new System.Drawing.Point(3, 67);
            this.displayedText.Multiline = true;
            this.displayedText.Name = "displayedText";
            this.displayedText.Size = new System.Drawing.Size(712, 395);
            this.displayedText.TabIndex = 0;
            // 
            // sendMessageTextBox
            // 
            this.sendMessageTextBox.Location = new System.Drawing.Point(12, 482);
            this.sendMessageTextBox.Name = "sendMessageTextBox";
            this.sendMessageTextBox.Size = new System.Drawing.Size(579, 23);
            this.sendMessageTextBox.TabIndex = 1;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(612, 482);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(91, 23);
            this.sendMessageButton.TabIndex = 2;
            this.sendMessageButton.Text = "send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            // 
            // sendMessageFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 517);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.sendMessageTextBox);
            this.Controls.Add(this.displayedText);
            this.Name = "sendMessageFrame";
            this.Text = "Send Message";
            this.Load += new System.EventHandler(this.sendMessageFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox displayedText;
        private TextBox sendMessageTextBox;
        private Button sendMessageButton;
    }
}
