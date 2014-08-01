namespace NameGenerator
{
    partial class mapNameGen
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
            this.createTestFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTestFileButton
            // 
            this.createTestFileButton.Location = new System.Drawing.Point(64, 41);
            this.createTestFileButton.Name = "createTestFileButton";
            this.createTestFileButton.Size = new System.Drawing.Size(152, 48);
            this.createTestFileButton.TabIndex = 0;
            this.createTestFileButton.Text = "Create test file";
            this.createTestFileButton.UseVisualStyleBackColor = true;
            this.createTestFileButton.Click += new System.EventHandler(this.createTestFileButton_Click);
            // 
            // mapNameGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.createTestFileButton);
            this.Name = "mapNameGen";
            this.Text = "mapNameGen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createTestFileButton;
    }
}