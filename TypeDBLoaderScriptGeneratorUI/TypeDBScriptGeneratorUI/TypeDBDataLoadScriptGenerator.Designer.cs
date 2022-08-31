namespace TypeDBScriptGeneratorUI
{
    partial class frmTypeDBLoadScriptGenerator
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
            this.txtTypeSQLTemplate = new System.Windows.Forms.TextBox();
            this.lblTypeSQLTemplate = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.cmdOk = new System.Windows.Forms.Button();
            this.lblTags = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.lblValues = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtStringFormats = new System.Windows.Forms.TextBox();
            this.lblStringFormattingNeeded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTypeSQLTemplate
            // 
            this.txtTypeSQLTemplate.Location = new System.Drawing.Point(268, 29);
            this.txtTypeSQLTemplate.Multiline = true;
            this.txtTypeSQLTemplate.Name = "txtTypeSQLTemplate";
            this.txtTypeSQLTemplate.Size = new System.Drawing.Size(505, 93);
            this.txtTypeSQLTemplate.TabIndex = 0;
            // 
            // lblTypeSQLTemplate
            // 
            this.lblTypeSQLTemplate.AutoSize = true;
            this.lblTypeSQLTemplate.Location = new System.Drawing.Point(124, 32);
            this.lblTypeSQLTemplate.Name = "lblTypeSQLTemplate";
            this.lblTypeSQLTemplate.Size = new System.Drawing.Size(127, 15);
            this.lblTypeSQLTemplate.TabIndex = 8;
            this.lblTypeSQLTemplate.Text = "Enter TypeQL Template";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(268, 140);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(505, 23);
            this.txtFileName.TabIndex = 1;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(194, 143);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(57, 15);
            this.lblFilePath.TabIndex = 9;
            this.lblFilePath.Text = "FileName";
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(268, 320);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(505, 23);
            this.cmdOk.TabIndex = 4;
            this.cmdOk.Text = "Click To Generate Script";
            this.cmdOk.UseVisualStyleBackColor = true;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(61, 181);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(190, 15);
            this.lblTags.TabIndex = 10;
            this.lblTags.Text = "Enter the list of Tags to be replaced";
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(268, 181);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(505, 23);
            this.txtTags.TabIndex = 11;
            // 
            // lblValues
            // 
            this.lblValues.AutoSize = true;
            this.lblValues.Location = new System.Drawing.Point(12, 227);
            this.lblValues.Name = "lblValues";
            this.lblValues.Size = new System.Drawing.Size(239, 15);
            this.lblValues.TabIndex = 12;
            this.lblValues.Text = "Enter the Position of the columns in CSV file";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 23);
            this.textBox1.TabIndex = 13;
            // 
            // txtStringFormats
            // 
            this.txtStringFormats.Location = new System.Drawing.Point(268, 264);
            this.txtStringFormats.Name = "txtStringFormats";
            this.txtStringFormats.Size = new System.Drawing.Size(505, 23);
            this.txtStringFormats.TabIndex = 14;
            // 
            // lblStringFormattingNeeded
            // 
            this.lblStringFormattingNeeded.AutoSize = true;
            this.lblStringFormattingNeeded.Location = new System.Drawing.Point(61, 264);
            this.lblStringFormattingNeeded.Name = "lblStringFormattingNeeded";
            this.lblStringFormattingNeeded.Size = new System.Drawing.Size(185, 15);
            this.lblStringFormattingNeeded.TabIndex = 15;
            this.lblStringFormattingNeeded.Text = "Enter if String Formatting  needed";
            // 
            // frmTypeDBLoadScriptGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStringFormattingNeeded);
            this.Controls.Add(this.txtStringFormats);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValues);
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblTypeSQLTemplate);
            this.Controls.Add(this.txtTypeSQLTemplate);
            this.Name = "frmTypeDBLoadScriptGenerator";
            this.Text = "TypeDBDataLoadScriptGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTypeSQLTemplate;
        private Label lblTypeSQLTemplate;
        private TextBox txtFileName;
        private Label lblFilePath;
        private Button cmdOk;
        private Label lblTags;
        private TextBox txtTags;
        private Label lblValues;
        private TextBox textBox1;
        private TextBox txtStringFormats;
        private Label lblStringFormattingNeeded;
    }
}