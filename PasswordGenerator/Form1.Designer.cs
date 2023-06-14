﻿namespace PasswordGenerator
{
    partial class Form1
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
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.symbolsLabel = new System.Windows.Forms.Label();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.uppercaseLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.symbolsCB = new System.Windows.Forms.CheckBox();
            this.numbersCB = new System.Windows.Forms.CheckBox();
            this.uppercaseCB = new System.Windows.Forms.CheckBox();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.textBox = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.scrollBarValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.AutoSize = true;
            this.passwordLengthLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLengthLabel.Location = new System.Drawing.Point(60, 30);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Size = new System.Drawing.Size(149, 21);
            this.passwordLengthLabel.TabIndex = 0;
            this.passwordLengthLabel.Text = " Password Length:";
            // 
            // symbolsLabel
            // 
            this.symbolsLabel.AutoSize = true;
            this.symbolsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbolsLabel.Location = new System.Drawing.Point(71, 70);
            this.symbolsLabel.Name = "symbolsLabel";
            this.symbolsLabel.Size = new System.Drawing.Size(138, 21);
            this.symbolsLabel.TabIndex = 1;
            this.symbolsLabel.Text = "Include Symbols:";
            // 
            // numbersLabel
            // 
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numbersLabel.Location = new System.Drawing.Point(64, 110);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(145, 21);
            this.numbersLabel.TabIndex = 2;
            this.numbersLabel.Text = "Include Numbers:";
            this.numbersLabel.Click += new System.EventHandler(this.numbersLabel_Click);
            // 
            // uppercaseLabel
            // 
            this.uppercaseLabel.AutoSize = true;
            this.uppercaseLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uppercaseLabel.Location = new System.Drawing.Point(54, 150);
            this.uppercaseLabel.Name = "uppercaseLabel";
            this.uppercaseLabel.Size = new System.Drawing.Size(155, 21);
            this.uppercaseLabel.TabIndex = 3;
            this.uppercaseLabel.Text = "Include Uppercase:";
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateButton.Location = new System.Drawing.Point(250, 225);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 50);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(100, 290);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(60, 21);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Result:";
            // 
            // symbolsCB
            // 
            this.symbolsCB.AutoSize = true;
            this.symbolsCB.Location = new System.Drawing.Point(215, 74);
            this.symbolsCB.Name = "symbolsCB";
            this.symbolsCB.Size = new System.Drawing.Size(88, 17);
            this.symbolsCB.TabIndex = 6;
            this.symbolsCB.Text = " (e.g. @#$%)";
            this.symbolsCB.UseVisualStyleBackColor = true;
            // 
            // numbersCB
            // 
            this.numbersCB.AutoSize = true;
            this.numbersCB.Location = new System.Drawing.Point(215, 114);
            this.numbersCB.Name = "numbersCB";
            this.numbersCB.Size = new System.Drawing.Size(86, 17);
            this.numbersCB.TabIndex = 7;
            this.numbersCB.Text = " (e.g. 12345)";
            this.numbersCB.UseVisualStyleBackColor = true;
            // 
            // uppercaseCB
            // 
            this.uppercaseCB.AutoSize = true;
            this.uppercaseCB.Location = new System.Drawing.Point(215, 154);
            this.uppercaseCB.Name = "uppercaseCB";
            this.uppercaseCB.Size = new System.Drawing.Size(98, 17);
            this.uppercaseCB.TabIndex = 8;
            this.uppercaseCB.Text = " (e.g. ABCDEF)";
            this.uppercaseCB.UseVisualStyleBackColor = true;
            // 
            // hScrollBar
            // 
            this.hScrollBar.LargeChange = 1;
            this.hScrollBar.Location = new System.Drawing.Point(212, 31);
            this.hScrollBar.Maximum = 16;
            this.hScrollBar.Minimum = 4;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(160, 20);
            this.hScrollBar.TabIndex = 1;
            this.hScrollBar.Value = 4;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(167, 290);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(269, 22);
            this.textBox.TabIndex = 9;
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyButton.Location = new System.Drawing.Point(442, 289);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(60, 25);
            this.copyButton.TabIndex = 10;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            // 
            // scrollBarValue
            // 
            this.scrollBarValue.AutoSize = true;
            this.scrollBarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scrollBarValue.Location = new System.Drawing.Point(375, 34);
            this.scrollBarValue.Name = "scrollBarValue";
            this.scrollBarValue.Size = new System.Drawing.Size(36, 16);
            this.scrollBarValue.TabIndex = 11;
            this.scrollBarValue.Text = "Size:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.scrollBarValue);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.uppercaseCB);
            this.Controls.Add(this.numbersCB);
            this.Controls.Add(this.symbolsCB);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.uppercaseLabel);
            this.Controls.Add(this.numbersLabel);
            this.Controls.Add(this.symbolsLabel);
            this.Controls.Add(this.passwordLengthLabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.Label symbolsLabel;
        private System.Windows.Forms.Label numbersLabel;
        private System.Windows.Forms.Label uppercaseLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.CheckBox symbolsCB;
        private System.Windows.Forms.CheckBox numbersCB;
        private System.Windows.Forms.CheckBox uppercaseCB;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Label scrollBarValue;
    }
}

