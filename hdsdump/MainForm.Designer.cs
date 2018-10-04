namespace hdsdump
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textOutputFile = new System.Windows.Forms.TextBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(78, 12);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(221, 22);
            this.textURL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output File:";
            // 
            // textOutputFile
            // 
            this.textOutputFile.Location = new System.Drawing.Point(78, 40);
            this.textOutputFile.Name = "textOutputFile";
            this.textOutputFile.Size = new System.Drawing.Size(221, 22);
            this.textOutputFile.TabIndex = 3;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(224, 68);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 4;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 105);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.textOutputFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "hdsdump";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOutputFile;
        private System.Windows.Forms.Button buttonDownload;
    }
}