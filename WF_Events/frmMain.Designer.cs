namespace WF_Events
{
    partial class frmMain
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
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.pnlDrivers = new System.Windows.Forms.Panel();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.btnGaiMeasure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(12, 415);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(109, 23);
            this.btnAddDriver.TabIndex = 0;
            this.btnAddDriver.Text = "Add Driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // pnlDrivers
            // 
            this.pnlDrivers.AutoScroll = true;
            this.pnlDrivers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrivers.Location = new System.Drawing.Point(12, 12);
            this.pnlDrivers.Name = "pnlDrivers";
            this.pnlDrivers.Size = new System.Drawing.Size(351, 397);
            this.pnlDrivers.TabIndex = 1;
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(369, 12);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(419, 426);
            this.rtbResult.TabIndex = 2;
            this.rtbResult.Text = "";
            // 
            // btnGaiMeasure
            // 
            this.btnGaiMeasure.Location = new System.Drawing.Point(254, 415);
            this.btnGaiMeasure.Name = "btnGaiMeasure";
            this.btnGaiMeasure.Size = new System.Drawing.Size(109, 23);
            this.btnGaiMeasure.TabIndex = 3;
            this.btnGaiMeasure.Text = "Gai Measure";
            this.btnGaiMeasure.UseVisualStyleBackColor = true;
            this.btnGaiMeasure.Click += new System.EventHandler(this.btnGaiMeasure_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGaiMeasure);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.pnlDrivers);
            this.Controls.Add(this.btnAddDriver);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Panel pnlDrivers;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Button btnGaiMeasure;
    }
}

