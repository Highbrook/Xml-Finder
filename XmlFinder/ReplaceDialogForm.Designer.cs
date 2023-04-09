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
            this.replaceButton = new System.Windows.Forms.Button();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.replaceLabel = new System.Windows.Forms.Label();
            this.replaceSelectedRadioButton = new System.Windows.Forms.RadioButton();
            this.replaceAllRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
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
            this.replaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
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
            // replaceSelectedRadioButton
            // 
            this.replaceSelectedRadioButton.AutoSize = true;
            this.replaceSelectedRadioButton.Location = new System.Drawing.Point(15, 317);
            this.replaceSelectedRadioButton.Name = "replaceSelectedRadioButton";
            this.replaceSelectedRadioButton.Size = new System.Drawing.Size(137, 17);
            this.replaceSelectedRadioButton.TabIndex = 22;
            this.replaceSelectedRadioButton.Text = "Replace in Selected file";
            this.replaceSelectedRadioButton.UseVisualStyleBackColor = true;
            this.replaceSelectedRadioButton.CheckedChanged += new System.EventHandler(this.ReplaceSelectedRadioButton_CheckedChanged);
            // 
            // replaceAllRadioButton
            // 
            this.replaceAllRadioButton.AutoSize = true;
            this.replaceAllRadioButton.Checked = true;
            this.replaceAllRadioButton.Location = new System.Drawing.Point(15, 340);
            this.replaceAllRadioButton.Name = "replaceAllRadioButton";
            this.replaceAllRadioButton.Size = new System.Drawing.Size(119, 17);
            this.replaceAllRadioButton.TabIndex = 23;
            this.replaceAllRadioButton.TabStop = true;
            this.replaceAllRadioButton.Text = "Replace in ALL files";
            this.replaceAllRadioButton.UseVisualStyleBackColor = true;
            this.replaceAllRadioButton.CheckedChanged += new System.EventHandler(this.ReplaceAllRadioButton_CheckedChanged);
            // 
            // ReplaceDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 373);
            this.Controls.Add(this.replaceAllRadioButton);
            this.Controls.Add(this.replaceSelectedRadioButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.replaceTextBox);
            this.Controls.Add(this.replaceLabel);
            this.Name = "ReplaceDialogForm";
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.Label replaceLabel;
        private System.Windows.Forms.RadioButton replaceSelectedRadioButton;
        private System.Windows.Forms.RadioButton replaceAllRadioButton;
    }
}