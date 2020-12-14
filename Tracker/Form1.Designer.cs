namespace Tracker
{
    partial class Tracker
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
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnStartUpdate = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.grvTimeCaptureHistory = new System.Windows.Forms.DataGridView();
            this.lblProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvTimeCaptureHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 49);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(442, 108);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "";
            // 
            // btnStartUpdate
            // 
            this.btnStartUpdate.BackColor = System.Drawing.Color.Green;
            this.btnStartUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnStartUpdate.Location = new System.Drawing.Point(461, 49);
            this.btnStartUpdate.Name = "btnStartUpdate";
            this.btnStartUpdate.Size = new System.Drawing.Size(135, 108);
            this.btnStartUpdate.TabIndex = 1;
            this.btnStartUpdate.Text = "Start/Update";
            this.btnStartUpdate.UseVisualStyleBackColor = false;
            this.btnStartUpdate.Click += new System.EventHandler(this.btnStartUpdate_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.ForeColor = System.Drawing.Color.Transparent;
            this.btnStop.Location = new System.Drawing.Point(602, 49);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(135, 108);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grvTimeCaptureHistory
            // 
            this.grvTimeCaptureHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTimeCaptureHistory.Location = new System.Drawing.Point(12, 177);
            this.grvTimeCaptureHistory.Name = "grvTimeCaptureHistory";
            this.grvTimeCaptureHistory.RowTemplate.Height = 24;
            this.grvTimeCaptureHistory.Size = new System.Drawing.Size(725, 288);
            this.grvTimeCaptureHistory.TabIndex = 3;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(12, 9);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 17);
            this.lblProgress.TabIndex = 4;
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 478);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.grvTimeCaptureHistory);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStartUpdate);
            this.Controls.Add(this.txtMessage);
            this.Name = "Tracker";
            this.Text = "Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.grvTimeCaptureHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button btnStartUpdate;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DataGridView grvTimeCaptureHistory;
        private System.Windows.Forms.Label lblProgress;
    }
}

