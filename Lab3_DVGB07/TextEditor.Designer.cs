namespace Lab3_DVGB07
{
    partial class TextEditor
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.charSpaceBox = new System.Windows.Forms.TextBox();
            this.charNoSpaceBox = new System.Windows.Forms.TextBox();
            this.wordsBox = new System.Windows.Forms.TextBox();
            this.rowsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.AcceptsReturn = true;
            this.textBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(263, 54);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(506, 335);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.TextBox_ifChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name:";
            // 
            // FileName
            // 
            this.FileName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(347, 23);
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Size = new System.Drawing.Size(287, 24);
            this.FileName.TabIndex = 2;
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(61, 71);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(123, 37);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open Files";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenFilesButton);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(61, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SavingFileButton);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(61, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Save as";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SavingFileButton);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(61, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Exit File";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ExitButton);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(646, 395);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 37);
            this.button5.TabIndex = 7;
            this.button5.Text = "New Text";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NewTextButton);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "OpenFileDialog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status Bar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Char with space:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Char with no space:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Words:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rows:";
            // 
            // charSpaceBox
            // 
            this.charSpaceBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.charSpaceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charSpaceBox.Location = new System.Drawing.Point(169, 457);
            this.charSpaceBox.Name = "charSpaceBox";
            this.charSpaceBox.ReadOnly = true;
            this.charSpaceBox.Size = new System.Drawing.Size(156, 22);
            this.charSpaceBox.TabIndex = 13;
            // 
            // charNoSpaceBox
            // 
            this.charNoSpaceBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.charNoSpaceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charNoSpaceBox.Location = new System.Drawing.Point(545, 455);
            this.charNoSpaceBox.Name = "charNoSpaceBox";
            this.charNoSpaceBox.ReadOnly = true;
            this.charNoSpaceBox.Size = new System.Drawing.Size(156, 22);
            this.charNoSpaceBox.TabIndex = 14;
            // 
            // wordsBox
            // 
            this.wordsBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.wordsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsBox.Location = new System.Drawing.Point(169, 497);
            this.wordsBox.Name = "wordsBox";
            this.wordsBox.ReadOnly = true;
            this.wordsBox.Size = new System.Drawing.Size(156, 22);
            this.wordsBox.TabIndex = 15;
            // 
            // rowsBox
            // 
            this.rowsBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rowsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsBox.Location = new System.Drawing.Point(545, 497);
            this.rowsBox.Name = "rowsBox";
            this.rowsBox.ReadOnly = true;
            this.rowsBox.Size = new System.Drawing.Size(156, 22);
            this.rowsBox.TabIndex = 16;
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.rowsBox);
            this.Controls.Add(this.wordsBox);
            this.Controls.Add(this.charNoSpaceBox);
            this.Controls.Add(this.charSpaceBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Name = "TextEditor";
            this.Text = "TextEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEditor_CloseSave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox charSpaceBox;
        private System.Windows.Forms.TextBox charNoSpaceBox;
        private System.Windows.Forms.TextBox wordsBox;
        private System.Windows.Forms.TextBox rowsBox;
    }
}