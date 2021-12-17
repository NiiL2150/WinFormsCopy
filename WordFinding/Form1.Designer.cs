namespace WordFinding
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.buttonDirectory = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 12);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(401, 23);
            this.textBoxPath.TabIndex = 0;
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(257, 41);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(75, 23);
            this.buttonFile.TabIndex = 1;
            this.buttonFile.Text = "File";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 69);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(401, 354);
            this.textBoxResult.TabIndex = 2;
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(12, 40);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(239, 23);
            this.textBoxString.TabIndex = 3;
            // 
            // buttonDirectory
            // 
            this.buttonDirectory.Location = new System.Drawing.Point(338, 41);
            this.buttonDirectory.Name = "buttonDirectory";
            this.buttonDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonDirectory.TabIndex = 4;
            this.buttonDirectory.Text = "Directory";
            this.buttonDirectory.UseVisualStyleBackColor = true;
            this.buttonDirectory.Click += new System.EventHandler(this.buttonDirectory_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 426);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(81, 15);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "Occurences: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonDirectory);
            this.Controls.Add(this.textBoxString);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.textBoxPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.Button buttonDirectory;
        private System.Windows.Forms.Label labelCount;
    }
}
