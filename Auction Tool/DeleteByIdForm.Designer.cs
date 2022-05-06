namespace Auction_Tool {
    partial class DeleteByIdForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteByIdForm));
            this.idLabel = new System.Windows.Forms.Label();
            this.deleteTitle = new System.Windows.Forms.Label();
            this.id_num = new System.Windows.Forms.NumericUpDown();
            this.delete_btn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.id_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(26, 60);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(59, 16);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID articol";
            // 
            // deleteTitle
            // 
            this.deleteTitle.AutoSize = true;
            this.deleteTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTitle.Location = new System.Drawing.Point(25, 17);
            this.deleteTitle.Name = "deleteTitle";
            this.deleteTitle.Size = new System.Drawing.Size(191, 24);
            this.deleteTitle.TabIndex = 1;
            this.deleteTitle.Text = "Șterge articol după ID";
            // 
            // id_num
            // 
            this.id_num.Location = new System.Drawing.Point(29, 79);
            this.id_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.id_num.Name = "id_num";
            this.id_num.Size = new System.Drawing.Size(239, 22);
            this.id_num.TabIndex = 2;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(29, 124);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(122, 32);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Șterge articol";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DeleteByIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 177);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.id_num);
            this.Controls.Add(this.deleteTitle);
            this.Controls.Add(this.idLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteByIdForm";
            this.Text = "Șterge articol";
            ((System.ComponentModel.ISupportInitialize)(this.id_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label deleteTitle;
        private System.Windows.Forms.NumericUpDown id_num;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}