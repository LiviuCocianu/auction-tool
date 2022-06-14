namespace Auction_Tool {
    partial class AuctionTimer {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.timer_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer_label
            // 
            this.timer_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timer_label.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.Location = new System.Drawing.Point(0, 0);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(118, 28);
            this.timer_label.TabIndex = 0;
            this.timer_label.Text = "00:00:00";
            this.timer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuctionTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.timer_label);
            this.Name = "AuctionTimer";
            this.Size = new System.Drawing.Size(118, 28);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timer_label;
    }
}
