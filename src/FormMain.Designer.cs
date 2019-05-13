namespace VisionApiCar
{
    partial class FormMain
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
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.pBoxImage = new System.Windows.Forms.PictureBox();
            this.txtAnalyseResult = new System.Windows.Forms.RichTextBox();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.settings = new VisionApiCar.SettingsControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImagePath
            // 
            this.txtImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImagePath.Enabled = false;
            this.txtImagePath.Location = new System.Drawing.Point(4, 5);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(613, 20);
            this.txtImagePath.TabIndex = 0;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectPath.Location = new System.Drawing.Point(619, 5);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(24, 20);
            this.btnSelectPath.TabIndex = 1;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.BtnSelectPath_Click);
            // 
            // pBoxImage
            // 
            this.pBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxImage.Location = new System.Drawing.Point(4, 133);
            this.pBoxImage.Name = "pBoxImage";
            this.pBoxImage.Size = new System.Drawing.Size(639, 241);
            this.pBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBoxImage.TabIndex = 2;
            this.pBoxImage.TabStop = false;
            // 
            // txtAnalyseResult
            // 
            this.txtAnalyseResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAnalyseResult.Location = new System.Drawing.Point(0, 413);
            this.txtAnalyseResult.Name = "txtAnalyseResult";
            this.txtAnalyseResult.Size = new System.Drawing.Size(649, 268);
            this.txtAnalyseResult.TabIndex = 3;
            this.txtAnalyseResult.Text = "";
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalysis.Location = new System.Drawing.Point(568, 104);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(75, 23);
            this.btnAnalysis.TabIndex = 4;
            this.btnAnalysis.Text = "Analisar";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.BtnAnalysis_ClickAsync);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(4, 31);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(290, 82);
            this.settings.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Logs:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.txtAnalyseResult);
            this.Controls.Add(this.pBoxImage);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtImagePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.PictureBox pBoxImage;
        private System.Windows.Forms.RichTextBox txtAnalyseResult;
        private System.Windows.Forms.Button btnAnalysis;
        private SettingsControl settings;
        private System.Windows.Forms.Label label1;
    }
}

