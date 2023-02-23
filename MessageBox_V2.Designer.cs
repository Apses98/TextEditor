namespace TextEditor
{
    partial class MessageBox_V2_form
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
            this.mainMessage = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DontSaveButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMessage
            // 
            this.mainMessage.AutoSize = true;
            this.mainMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMessage.Location = new System.Drawing.Point(44, 62);
            this.mainMessage.Name = "mainMessage";
            this.mainMessage.Size = new System.Drawing.Size(57, 20);
            this.mainMessage.TabIndex = 0;
            this.mainMessage.Text = "label1";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(265, 124);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DontSaveButton
            // 
            this.DontSaveButton.Location = new System.Drawing.Point(184, 124);
            this.DontSaveButton.Name = "DontSaveButton";
            this.DontSaveButton.Size = new System.Drawing.Size(75, 23);
            this.DontSaveButton.TabIndex = 1;
            this.DontSaveButton.Text = "Don\'t Save";
            this.DontSaveButton.UseVisualStyleBackColor = true;
            this.DontSaveButton.Click += new System.EventHandler(this.DontSaveButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(103, 124);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MessageBox_V2_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 156);
            this.ControlBox = false;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.DontSaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.mainMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(365, 195);
            this.MinimumSize = new System.Drawing.Size(365, 195);
            this.Name = "MessageBox_V2_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMessage;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DontSaveButton;
        private System.Windows.Forms.Button saveButton;
    }
}