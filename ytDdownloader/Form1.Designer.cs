namespace ytDdownloader
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVideoId = new System.Windows.Forms.TextBox();
            this.btnGetVideoInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFormats = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Id:";
            // 
            // txtVideoId
            // 
            this.txtVideoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVideoId.Location = new System.Drawing.Point(73, 17);
            this.txtVideoId.Name = "txtVideoId";
            this.txtVideoId.Size = new System.Drawing.Size(230, 20);
            this.txtVideoId.TabIndex = 1;
            // 
            // btnGetVideoInfo
            // 
            this.btnGetVideoInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetVideoInfo.Location = new System.Drawing.Point(309, 17);
            this.btnGetVideoInfo.Name = "btnGetVideoInfo";
            this.btnGetVideoInfo.Size = new System.Drawing.Size(96, 23);
            this.btnGetVideoInfo.TabIndex = 2;
            this.btnGetVideoInfo.Text = "Get Video Info";
            this.btnGetVideoInfo.UseVisualStyleBackColor = true;
            this.btnGetVideoInfo.Click += new System.EventHandler(this.btnGetVideoInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available formats:";
            // 
            // cmbFormats
            // 
            this.cmbFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormats.FormattingEnabled = true;
            this.cmbFormats.Location = new System.Drawing.Point(114, 47);
            this.cmbFormats.Name = "cmbFormats";
            this.cmbFormats.Size = new System.Drawing.Size(111, 21);
            this.cmbFormats.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(231, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFormats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetVideoInfo);
            this.Controls.Add(this.txtVideoId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVideoId;
        private System.Windows.Forms.Button btnGetVideoInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFormats;
        private System.Windows.Forms.Button button1;
    }
}

