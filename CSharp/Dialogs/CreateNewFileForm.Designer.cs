namespace MultiPageTiffDemo
{
    partial class CreateNewFileForm
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
            this.fileVersionGroupBox = new System.Windows.Forms.GroupBox();
            this.bigTiffRadioButton = new System.Windows.Forms.RadioButton();
            this.standardTiffRadioButton = new System.Windows.Forms.RadioButton();
            this.fileFormatGroupBox = new System.Windows.Forms.GroupBox();
            this.bigEndianRadioButton = new System.Windows.Forms.RadioButton();
            this.littleEndianRadioButton = new System.Windows.Forms.RadioButton();
            this.cancelButton1 = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.fileVersionGroupBox.SuspendLayout();
            this.fileFormatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileVersionGroupBox
            // 
            this.fileVersionGroupBox.Controls.Add(this.bigTiffRadioButton);
            this.fileVersionGroupBox.Controls.Add(this.standardTiffRadioButton);
            this.fileVersionGroupBox.Location = new System.Drawing.Point(121, 6);
            this.fileVersionGroupBox.Name = "fileVersionGroupBox";
            this.fileVersionGroupBox.Size = new System.Drawing.Size(107, 70);
            this.fileVersionGroupBox.TabIndex = 0;
            this.fileVersionGroupBox.TabStop = false;
            this.fileVersionGroupBox.Text = "File version";
            // 
            // bigTiffRadioButton
            // 
            this.bigTiffRadioButton.AutoSize = true;
            this.bigTiffRadioButton.Location = new System.Drawing.Point(6, 42);
            this.bigTiffRadioButton.Name = "bigTiffRadioButton";
            this.bigTiffRadioButton.Size = new System.Drawing.Size(65, 17);
            this.bigTiffRadioButton.TabIndex = 2;
            this.bigTiffRadioButton.Text = "Big TIFF";
            this.bigTiffRadioButton.UseVisualStyleBackColor = true;
            // 
            // standardTiffRadioButton
            // 
            this.standardTiffRadioButton.AutoSize = true;
            this.standardTiffRadioButton.Checked = true;
            this.standardTiffRadioButton.Location = new System.Drawing.Point(6, 19);
            this.standardTiffRadioButton.Name = "standardTiffRadioButton";
            this.standardTiffRadioButton.Size = new System.Drawing.Size(93, 17);
            this.standardTiffRadioButton.TabIndex = 1;
            this.standardTiffRadioButton.TabStop = true;
            this.standardTiffRadioButton.Text = "Standard TIFF";
            this.standardTiffRadioButton.UseVisualStyleBackColor = true;
            // 
            // fileFormatGroupBox
            // 
            this.fileFormatGroupBox.Controls.Add(this.bigEndianRadioButton);
            this.fileFormatGroupBox.Controls.Add(this.littleEndianRadioButton);
            this.fileFormatGroupBox.Location = new System.Drawing.Point(8, 6);
            this.fileFormatGroupBox.Name = "fileFormatGroupBox";
            this.fileFormatGroupBox.Size = new System.Drawing.Size(107, 70);
            this.fileFormatGroupBox.TabIndex = 1;
            this.fileFormatGroupBox.TabStop = false;
            this.fileFormatGroupBox.Text = "File format";
            // 
            // bigEndianRadioButton
            // 
            this.bigEndianRadioButton.AutoSize = true;
            this.bigEndianRadioButton.Location = new System.Drawing.Point(6, 42);
            this.bigEndianRadioButton.Name = "bigEndianRadioButton";
            this.bigEndianRadioButton.Size = new System.Drawing.Size(75, 17);
            this.bigEndianRadioButton.TabIndex = 2;
            this.bigEndianRadioButton.Text = "Big endian";
            this.bigEndianRadioButton.UseVisualStyleBackColor = true;
            // 
            // littleEndianRadioButton
            // 
            this.littleEndianRadioButton.AutoSize = true;
            this.littleEndianRadioButton.Checked = true;
            this.littleEndianRadioButton.Location = new System.Drawing.Point(6, 19);
            this.littleEndianRadioButton.Name = "littleEndianRadioButton";
            this.littleEndianRadioButton.Size = new System.Drawing.Size(82, 17);
            this.littleEndianRadioButton.TabIndex = 1;
            this.littleEndianRadioButton.TabStop = true;
            this.littleEndianRadioButton.Text = "Little endian";
            this.littleEndianRadioButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton1
            // 
            this.cancelButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton1.Location = new System.Drawing.Point(121, 82);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(75, 23);
            this.cancelButton1.TabIndex = 5;
            this.cancelButton1.Text = "Cancel";
            this.cancelButton1.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(40, 82);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CreateNewFileForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton1;
            this.ClientSize = new System.Drawing.Size(237, 120);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.fileFormatGroupBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fileVersionGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(243, 145);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(243, 145);
            this.Name = "CreateNewFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new file";
            this.fileVersionGroupBox.ResumeLayout(false);
            this.fileVersionGroupBox.PerformLayout();
            this.fileFormatGroupBox.ResumeLayout(false);
            this.fileFormatGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fileVersionGroupBox;
        private System.Windows.Forms.RadioButton bigTiffRadioButton;
        private System.Windows.Forms.RadioButton standardTiffRadioButton;
        private System.Windows.Forms.GroupBox fileFormatGroupBox;
        private System.Windows.Forms.RadioButton bigEndianRadioButton;
        private System.Windows.Forms.RadioButton littleEndianRadioButton;
        private System.Windows.Forms.Button cancelButton1;
        private System.Windows.Forms.Button okButton;
    }
}