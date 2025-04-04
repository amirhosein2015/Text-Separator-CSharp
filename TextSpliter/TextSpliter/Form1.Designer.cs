
namespace TextSpliter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Open = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.numSplitSize = new System.Windows.Forms.NumericUpDown();
            this.Run = new System.Windows.Forms.Button();
            this.Relpace = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmbDirection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAlignment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitSize)).BeginInit();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.LightBlue;
            this.Open.ForeColor = System.Drawing.Color.MediumBlue;
            this.Open.Location = new System.Drawing.Point(163, 74);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(169, 80);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open File";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFilePath.Location = new System.Drawing.Point(365, 93);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(251, 38);
            this.txtFilePath.TabIndex = 1;
            // 
            // numSplitSize
            // 
            this.numSplitSize.Location = new System.Drawing.Point(442, 200);
            this.numSplitSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numSplitSize.Name = "numSplitSize";
            this.numSplitSize.Size = new System.Drawing.Size(120, 38);
            this.numSplitSize.TabIndex = 2;
            this.numSplitSize.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run.ForeColor = System.Drawing.Color.MediumBlue;
            this.Run.Location = new System.Drawing.Point(981, 299);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(347, 188);
            this.Run.TabIndex = 3;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Relpace
            // 
            this.Relpace.BackColor = System.Drawing.Color.LightBlue;
            this.Relpace.ForeColor = System.Drawing.Color.MediumBlue;
            this.Relpace.Location = new System.Drawing.Point(618, 312);
            this.Relpace.Name = "Relpace";
            this.Relpace.Size = new System.Drawing.Size(161, 83);
            this.Relpace.TabIndex = 4;
            this.Relpace.Text = "Change";
            this.Relpace.UseVisualStyleBackColor = false;
            this.Relpace.Click += new System.EventHandler(this.Relpace_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(404, 299);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(181, 38);
            this.txtFind.TabIndex = 5;
            this.txtFind.Text = "^p";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(404, 366);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(181, 38);
            this.txtReplace.TabIndex = 6;
            this.txtReplace.Text = "  ^p";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.LightBlue;
            this.Save.ForeColor = System.Drawing.Color.MediumBlue;
            this.Save.Location = new System.Drawing.Point(175, 694);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(157, 61);
            this.Save.TabIndex = 7;
            this.Save.Text = "OutPut";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.BackColor = System.Drawing.SystemColors.Menu;
            this.txtOutputPath.Location = new System.Drawing.Point(355, 704);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(251, 38);
            this.txtOutputPath.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Split by word count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Find And Replace :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(896, 546);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(511, 36);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // cmbDirection
            // 
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Items.AddRange(new object[] {
            "Left to Right",
            "Right to Left"});
            this.cmbDirection.Location = new System.Drawing.Point(346, 478);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(270, 39);
            this.cmbDirection.TabIndex = 12;
            this.cmbDirection.Text = "Right to Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Direction :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Alignment :";
            // 
            // cmbAlignment
            // 
            this.cmbAlignment.FormattingEnabled = true;
            this.cmbAlignment.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Justify",
            "Center"});
            this.cmbAlignment.Location = new System.Drawing.Point(355, 582);
            this.cmbAlignment.Name = "cmbAlignment";
            this.cmbAlignment.Size = new System.Drawing.Size(270, 39);
            this.cmbAlignment.TabIndex = 15;
            this.cmbAlignment.Text = "Right";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(1095, 785);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 34);
            this.label5.TabIndex = 16;
            this.label5.Text = "Create By: Abdollah Mohajeri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(890, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total number of words: ";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordCount.Location = new System.Drawing.Point(1206, 106);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(57, 39);
            this.lblWordCount.TabIndex = 18;
            this.lblWordCount.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1897, 1133);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAlignment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDirection);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.Relpace);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.numSplitSize);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.Open);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text Divider";
            ((System.ComponentModel.ISupportInitialize)(this.numSplitSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.NumericUpDown numSplitSize;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Relpace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cmbDirection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAlignment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWordCount;
    }
}

