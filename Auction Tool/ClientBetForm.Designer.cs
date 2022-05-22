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
            this.sumaNoua_pan = new System.Windows.Forms.Panel();
            this.sumaNoua_tb = new System.Windows.Forms.TextBox();
            this.sumaNoua = new System.Windows.Forms.Label();
            this.currentSum = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sumaDisp = new System.Windows.Forms.Label();
            this.sumaNoua_pan.SuspendLayout();
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
            // sumaNoua_pan
            // 
            this.sumaNoua_pan.Controls.Add(this.sumaNoua_tb);
            this.sumaNoua_pan.Controls.Add(this.sumaNoua);
            this.sumaNoua_pan.Location = new System.Drawing.Point(17, 82);
            this.sumaNoua_pan.Name = "sumaNoua_pan";
            this.sumaNoua_pan.Size = new System.Drawing.Size(310, 50);
            this.sumaNoua_pan.TabIndex = 3;
            // 
            // sumaNoua_tb
            // 
            this.sumaNoua_tb.Location = new System.Drawing.Point(6, 24);
            this.sumaNoua_tb.Name = "sumaNoua_tb";
            this.sumaNoua_tb.Size = new System.Drawing.Size(271, 22);
            this.sumaNoua_tb.TabIndex = 2;
            // 
            // sumaNoua
            // 
            this.sumaNoua.AutoSize = true;
            this.sumaNoua.Location = new System.Drawing.Point(3, 5);
            this.sumaNoua.Name = "sumaNoua";
            this.sumaNoua.Size = new System.Drawing.Size(129, 16);
            this.sumaNoua.TabIndex = 1;
            this.sumaNoua.Text = "Noua sumă propusă";
            // 
            // currentSum
            // 
            this.currentSum.AutoSize = true;
            this.currentSum.Location = new System.Drawing.Point(20, 41);
            this.currentSum.Name = "currentSum";
            this.currentSum.Size = new System.Drawing.Size(149, 16);
            this.currentSum.TabIndex = 4;
            this.currentSum.Text = "Sumă propusă anterior: ";
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
            // sumaDisp
            // 
            this.sumaDisp.AutoSize = true;
            this.sumaDisp.Location = new System.Drawing.Point(20, 57);
            this.sumaDisp.Name = "sumaDisp";
            this.sumaDisp.Size = new System.Drawing.Size(159, 16);
            this.sumaDisp.TabIndex = 6;
            this.sumaDisp.Text = "Sumă disponibilă (buget):";
            // 
            // ClientBetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 197);
            this.Controls.Add(this.sumaDisp);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.currentSum);
            this.Controls.Add(this.sumaNoua_pan);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientBetForm";
            this.sumaNoua_pan.ResumeLayout(false);
            this.sumaNoua_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel sumaNoua_pan;
        private System.Windows.Forms.TextBox sumaNoua_tb;
        private System.Windows.Forms.Label sumaNoua;
        private System.Windows.Forms.Label currentSum;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label sumaDisp;
    }
}