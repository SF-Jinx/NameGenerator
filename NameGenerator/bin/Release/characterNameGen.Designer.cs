namespace NameGenerator
{
    partial class characterNameGen
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
            this.generateFilenameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCharacterName = new System.Windows.Forms.TextBox();
            this.textBoxFrameX = new System.Windows.Forms.TextBox();
            this.textBoxFrameY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonPlayer = new System.Windows.Forms.RadioButton();
            this.radioButtonEnemy = new System.Windows.Forms.RadioButton();
            this.radioButtonNPC = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateFilenameButton
            // 
            this.generateFilenameButton.Location = new System.Drawing.Point(12, 86);
            this.generateFilenameButton.Name = "generateFilenameButton";
            this.generateFilenameButton.Size = new System.Drawing.Size(199, 32);
            this.generateFilenameButton.TabIndex = 0;
            this.generateFilenameButton.Text = "Generate Filename!";
            this.generateFilenameButton.UseVisualStyleBackColor = true;
            this.generateFilenameButton.Click += new System.EventHandler(this.generateFilenameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frame size";
            // 
            // textBoxCharacterName
            // 
            this.textBoxCharacterName.Location = new System.Drawing.Point(100, 6);
            this.textBoxCharacterName.Name = "textBoxCharacterName";
            this.textBoxCharacterName.Size = new System.Drawing.Size(111, 20);
            this.textBoxCharacterName.TabIndex = 1;
            // 
            // textBoxFrameX
            // 
            this.textBoxFrameX.Location = new System.Drawing.Point(118, 32);
            this.textBoxFrameX.Name = "textBoxFrameX";
            this.textBoxFrameX.Size = new System.Drawing.Size(33, 20);
            this.textBoxFrameX.TabIndex = 4;
            // 
            // textBoxFrameY
            // 
            this.textBoxFrameY.Location = new System.Drawing.Point(178, 32);
            this.textBoxFrameY.Name = "textBoxFrameY";
            this.textBoxFrameY.Size = new System.Drawing.Size(33, 20);
            this.textBoxFrameY.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "x:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "y:";
            // 
            // radioButtonPlayer
            // 
            this.radioButtonPlayer.AutoSize = true;
            this.radioButtonPlayer.Location = new System.Drawing.Point(12, 63);
            this.radioButtonPlayer.Name = "radioButtonPlayer";
            this.radioButtonPlayer.Size = new System.Drawing.Size(54, 17);
            this.radioButtonPlayer.TabIndex = 8;
            this.radioButtonPlayer.TabStop = true;
            this.radioButtonPlayer.Text = "Player";
            this.radioButtonPlayer.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnemy
            // 
            this.radioButtonEnemy.AutoSize = true;
            this.radioButtonEnemy.Location = new System.Drawing.Point(72, 63);
            this.radioButtonEnemy.Name = "radioButtonEnemy";
            this.radioButtonEnemy.Size = new System.Drawing.Size(57, 17);
            this.radioButtonEnemy.TabIndex = 9;
            this.radioButtonEnemy.TabStop = true;
            this.radioButtonEnemy.Text = "Enemy";
            this.radioButtonEnemy.UseVisualStyleBackColor = true;
            // 
            // radioButtonNPC
            // 
            this.radioButtonNPC.AutoSize = true;
            this.radioButtonNPC.Location = new System.Drawing.Point(135, 63);
            this.radioButtonNPC.Name = "radioButtonNPC";
            this.radioButtonNPC.Size = new System.Drawing.Size(47, 17);
            this.radioButtonNPC.TabIndex = 10;
            this.radioButtonNPC.TabStop = true;
            this.radioButtonNPC.Text = "NPC";
            this.radioButtonNPC.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(217, 6);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(112, 102);
            this.label5.TabIndex = 11;
            this.label5.Text = "Drag and Drop \r\nfiles into this \r\nwindow to avoid \r\nhaving to select \r\nthem in a " +
    "dialog \r\nbox";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // characterNameGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 130);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonNPC);
            this.Controls.Add(this.radioButtonEnemy);
            this.Controls.Add(this.radioButtonPlayer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFrameY);
            this.Controls.Add(this.textBoxFrameX);
            this.Controls.Add(this.textBoxCharacterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateFilenameButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "characterNameGen";
            this.Text = "Character Name Gen.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateFilenameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCharacterName;
        private System.Windows.Forms.TextBox textBoxFrameX;
        private System.Windows.Forms.TextBox textBoxFrameY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonPlayer;
        private System.Windows.Forms.RadioButton radioButtonEnemy;
        private System.Windows.Forms.RadioButton radioButtonNPC;
        private System.Windows.Forms.Label label5;
    }
}

