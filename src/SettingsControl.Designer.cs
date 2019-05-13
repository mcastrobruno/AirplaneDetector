namespace VisionApiCar
{
    partial class SettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSubscriptionKey = new System.Windows.Forms.Label();
            this.tbSubscriptionKey = new System.Windows.Forms.TextBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSubscriptionKey
            // 
            this.lblSubscriptionKey.AutoSize = true;
            this.lblSubscriptionKey.Location = new System.Drawing.Point(0, 0);
            this.lblSubscriptionKey.Name = "lblSubscriptionKey";
            this.lblSubscriptionKey.Size = new System.Drawing.Size(86, 13);
            this.lblSubscriptionKey.TabIndex = 0;
            this.lblSubscriptionKey.Text = "Subscription Key";
            // 
            // tbSubscriptionKey
            // 
            this.tbSubscriptionKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubscriptionKey.Location = new System.Drawing.Point(3, 16);
            this.tbSubscriptionKey.Name = "tbSubscriptionKey";
            this.tbSubscriptionKey.Size = new System.Drawing.Size(284, 20);
            this.tbSubscriptionKey.TabIndex = 1;
            // 
            // cbRegion
            // 
            this.cbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(3, 55);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(284, 21);
            this.cbRegion.TabIndex = 2;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(3, 39);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(95, 13);
            this.lblRegion.TabIndex = 3;
            this.lblRegion.Text = "Região do Serviço";
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.tbSubscriptionKey);
            this.Controls.Add(this.lblSubscriptionKey);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(290, 82);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubscriptionKey;
        private System.Windows.Forms.TextBox tbSubscriptionKey;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label lblRegion;
    }
}
