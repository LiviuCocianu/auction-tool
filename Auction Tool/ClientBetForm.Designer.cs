namespace Auction_Tool {
    partial class ClientBetForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientBetForm));
            this.title = new System.Windows.Forms.Label();
            this.newBid_pan = new System.Windows.Forms.Panel();
            this.newBid_tb = new System.Windows.Forms.TextBox();
            this.newBid = new System.Windows.Forms.Label();
            this.currentBid = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.clientBudget = new System.Windows.Forms.Label();
            this.newBid_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(19, 14);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(275, 24);
            this.title.TabIndex = 1;
            this.title.Text = "Setează suma propusă de client";
            // 
            // newBid_pan
            // 
            this.newBid_pan.Controls.Add(this.newBid_tb);
            this.newBid_pan.Controls.Add(this.newBid);
            this.newBid_pan.Location = new System.Drawing.Point(17, 82);
            this.newBid_pan.Name = "sumaNoua_pan";
            this.newBid_pan.Size = new System.Drawing.Size(310, 50);
            this.newBid_pan.TabIndex = 3;
            // 
            // newBid_tb
            // 
            this.newBid_tb.Location = new System.Drawing.Point(6, 24);
            this.newBid_tb.Name = "sumaNoua_tb";
            this.newBid_tb.Size = new System.Drawing.Size(271, 22);
            this.newBid_tb.TabIndex = 2;
            // 
            // newBid
            // 
            this.newBid.AutoSize = true;
            this.newBid.Location = new System.Drawing.Point(3, 5);
            this.newBid.Name = "sumaNoua";
            this.newBid.Size = new System.Drawing.Size(129, 16);
            this.newBid.TabIndex = 1;
            this.newBid.Text = "Noua sumă propusă";
            // 
            // currentBid
            // 
            this.currentBid.AutoSize = true;
            this.currentBid.Location = new System.Drawing.Point(20, 41);
            this.currentBid.Name = "currentSum";
            this.currentBid.Size = new System.Drawing.Size(149, 16);
            this.currentBid.TabIndex = 4;
            this.currentBid.Text = "Sumă propusă anterior: ";
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(23, 146);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(100, 30);
            this.submit_btn.TabIndex = 5;
            this.submit_btn.Text = "Setează";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // clientBudget
            // 
            this.clientBudget.AutoSize = true;
            this.clientBudget.Location = new System.Drawing.Point(20, 57);
            this.clientBudget.Name = "clientBudget";
            this.clientBudget.Size = new System.Drawing.Size(159, 16);
            this.clientBudget.TabIndex = 6;
            this.clientBudget.Text = "Sumă disponibilă (buget):";
            // 
            // ClientBetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 197);
            this.Controls.Add(this.clientBudget);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.currentBid);
            this.Controls.Add(this.newBid_pan);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientBetForm";
            this.newBid_pan.ResumeLayout(false);
            this.newBid_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel newBid_pan;
        private System.Windows.Forms.TextBox newBid_tb;
        private System.Windows.Forms.Label newBid;
        private System.Windows.Forms.Label currentBid;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label clientBudget;
    }
}