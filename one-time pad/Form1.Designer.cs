namespace one_time_pad
{
    partial class MainWindow
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
            this.EncodeRadio = new System.Windows.Forms.RadioButton();
            this.DecodeRadio = new System.Windows.Forms.RadioButton();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.OriginalBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CodeButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ManualModeToggle = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EncodeRadio
            // 
            this.EncodeRadio.AutoSize = true;
            this.EncodeRadio.Location = new System.Drawing.Point(58, 11);
            this.EncodeRadio.Name = "EncodeRadio";
            this.EncodeRadio.Size = new System.Drawing.Size(62, 17);
            this.EncodeRadio.TabIndex = 0;
            this.EncodeRadio.TabStop = true;
            this.EncodeRadio.Text = "Encode";
            this.EncodeRadio.UseVisualStyleBackColor = true;
            this.EncodeRadio.CheckedChanged += new System.EventHandler(this.EncodeRadio_CheckedChanged);
            // 
            // DecodeRadio
            // 
            this.DecodeRadio.AutoSize = true;
            this.DecodeRadio.Location = new System.Drawing.Point(126, 11);
            this.DecodeRadio.Name = "DecodeRadio";
            this.DecodeRadio.Size = new System.Drawing.Size(63, 17);
            this.DecodeRadio.TabIndex = 1;
            this.DecodeRadio.TabStop = true;
            this.DecodeRadio.Text = "Decode";
            this.DecodeRadio.UseVisualStyleBackColor = true;
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(80, 35);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(202, 20);
            this.KeyBox.TabIndex = 2;
            // 
            // OriginalBox
            // 
            this.OriginalBox.Location = new System.Drawing.Point(80, 61);
            this.OriginalBox.Name = "OriginalBox";
            this.OriginalBox.Size = new System.Drawing.Size(202, 20);
            this.OriginalBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Key:";
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(80, 87);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(202, 20);
            this.CodeBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Original:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Code:";
            // 
            // CodeButton
            // 
            this.CodeButton.Location = new System.Drawing.Point(207, 113);
            this.CodeButton.Name = "CodeButton";
            this.CodeButton.Size = new System.Drawing.Size(75, 23);
            this.CodeButton.TabIndex = 8;
            this.CodeButton.Text = "Text";
            this.CodeButton.UseVisualStyleBackColor = true;
            this.CodeButton.Click += new System.EventHandler(this.CodeButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(126, 113);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ManualModeToggle
            // 
            this.ManualModeToggle.AutoSize = true;
            this.ManualModeToggle.Location = new System.Drawing.Point(195, 12);
            this.ManualModeToggle.Name = "ManualModeToggle";
            this.ManualModeToggle.Size = new System.Drawing.Size(87, 17);
            this.ManualModeToggle.TabIndex = 10;
            this.ManualModeToggle.Text = "Random Key";
            this.ManualModeToggle.UseVisualStyleBackColor = true;
            this.ManualModeToggle.CheckedChanged += new System.EventHandler(this.ManualModeToggle_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mode:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 148);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ManualModeToggle);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CodeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OriginalBox);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.DecodeRadio);
            this.Controls.Add(this.EncodeRadio);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 186);
            this.MinimumSize = new System.Drawing.Size(310, 186);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One-Time Pad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton EncodeRadio;
        private System.Windows.Forms.RadioButton DecodeRadio;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.TextBox OriginalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CodeButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox ManualModeToggle;
        private System.Windows.Forms.Label label4;
    }
}

