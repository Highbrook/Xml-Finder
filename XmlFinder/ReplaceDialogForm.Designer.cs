namespace XmlFinder
{
    partial class ReplaceDialogForm
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
            this.replaceAllCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceSelectedCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // replaceAllCheckBox
            // 
            this.replaceAllCheckBox.AutoSize = true;
            this.replaceAllCheckBox.Location = new System.Drawing.Point(15, 340);
            this.replaceAllCheckBox.Name = "replaceAllCheckBox";
            this.replaceAllCheckBox.Size = new System.Drawing.Size(120, 17);
            this.replaceAllCheckBox.TabIndex = 20;
            this.replaceAllCheckBox.Text = "Replace in ALL files";
            this.replaceAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceSelectedCheckBox
            // 
            this.replaceSelectedCheckBox.AutoSize = true;
            this.replaceSelectedCheckBox.Location = new System.Drawing.Point(15, 317);
            this.replaceSelectedCheckBox.Name = "replaceSelectedCheckBox";
            this.replaceSelectedCheckBox.Size = new System.Drawing.Size(138, 17);
            this.replaceSelectedCheckBox.TabIndex = 21;
            this.replaceSelectedCheckBox.Text = "Replace in Selected file";
            this.replaceSelectedCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceButton
            // 
            this.replaceButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.replaceButton.Location = new System.Drawing.Point(15, 52);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(108, 20);
            this.replaceButton.TabIndex = 19;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(15, 26);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(442, 20);
            this.replaceTextBox.TabIndex = 18;
            // 
            // replaceLabel
            // 
            this.replaceLabel.AutoSize = true;
            this.replaceLabel.Location = new System.Drawing.Point(12, 9);
            this.replaceLabel.Name = "replaceLabel";
            this.replaceLabel.Size = new System.Drawing.Size(72, 13);
            this.replaceLabel.TabIndex = 17;
            this.replaceLabel.Text = "Replace with:";
            // 
            // ReplaceDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 373);
            this.Controls.Add(this.replaceAllCheckBox);
            this.Controls.Add(this.replaceSelectedCheckBox);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.replaceTextBox);
            this.Controls.Add(this.replaceLabel);
            this.Name = "ReplaceDialogForm";
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox replaceAllCheckBox;
        private System.Windows.Forms.CheckBox replaceSelectedCheckBox;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.Label replaceLabel;
    }
}