
namespace Auction_Tool {
    partial class CreateEditClientForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditClientForm));
            this.title = new System.Windows.Forms.Label();
            this.firstLastName_pan = new System.Windows.Forms.Panel();
            this.lastName_tb = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName_tb = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.auctionNumber_pan = new System.Windows.Forms.Panel();
            this.auctionNumberInfo = new System.Windows.Forms.Label();
            this.auctionNumber_tb = new System.Windows.Forms.TextBox();
            this.auctionNumber = new System.Windows.Forms.Label();
            this.clientBudget_pan = new System.Windows.Forms.Panel();
            this.clientBudgetInfo = new System.Windows.Forms.Label();
            this.clientBudget_tb = new System.Windows.Forms.TextBox();
            this.clientBudget = new System.Windows.Forms.Label();
            this.saveHistory_ckb = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.submit_btn = new System.Windows.Forms.Button();
            this.firstLastName_pan.SuspendLayout();
            this.auctionNumber_pan.SuspendLayout();
            this.clientBudget_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(25, 17);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(192, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Creează un client nou";
            // 
            // firstLastName_pan
            // 
            this.firstLastName_pan.Controls.Add(this.lastName_tb);
            this.firstLastName_pan.Controls.Add(this.lastName);
            this.firstLastName_pan.Controls.Add(this.firstName_tb);
            this.firstLastName_pan.Controls.Add(this.firstName);
            this.firstLastName_pan.Location = new System.Drawing.Point(23, 55);
            this.firstLastName_pan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstLastName_pan.Name = "numePrenum_pan";
            this.firstLastName_pan.Size = new System.Drawing.Size(495, 58);
            this.firstLastName_pan.TabIndex = 1;
            // 
            // lastName_tb
            // 
            this.lastName_tb.Location = new System.Drawing.Point(232, 26);
            this.lastName_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastName_tb.Name = "prenumeClient_tb";
            this.lastName_tb.Size = new System.Drawing.Size(216, 22);
            this.lastName_tb.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(228, 5);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastName.Name = "prenumeClient";
            this.lastName.Size = new System.Drawing.Size(61, 16);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Prenume";
            // 
            // firstName_tb
            // 
            this.firstName_tb.Location = new System.Drawing.Point(12, 26);
            this.firstName_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstName_tb.Name = "numeClient_tb";
            this.firstName_tb.Size = new System.Drawing.Size(173, 22);
            this.firstName_tb.TabIndex = 1;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(8, 5);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstName.Name = "numeClient";
            this.firstName.Size = new System.Drawing.Size(43, 16);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "Nume";
            // 
            // auctionNumber_pan
            // 
            this.auctionNumber_pan.Controls.Add(this.auctionNumberInfo);
            this.auctionNumber_pan.Controls.Add(this.auctionNumber_tb);
            this.auctionNumber_pan.Controls.Add(this.auctionNumber);
            this.auctionNumber_pan.Location = new System.Drawing.Point(23, 112);
            this.auctionNumber_pan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.auctionNumber_pan.Name = "auctionNumber_pan";
            this.auctionNumber_pan.Size = new System.Drawing.Size(495, 58);
            this.auctionNumber_pan.TabIndex = 4;
            // 
            // auctionNumberInfo
            // 
            this.auctionNumberInfo.AutoSize = true;
            this.auctionNumberInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auctionNumberInfo.Location = new System.Drawing.Point(175, 5);
            this.auctionNumberInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.auctionNumberInfo.Name = "auctionNumberInfo";
            this.auctionNumberInfo.Size = new System.Drawing.Size(42, 16);
            this.auctionNumberInfo.TabIndex = 2;
            this.auctionNumberInfo.Text = "[ Info ]";
            this.auctionNumberInfo.Click += new System.EventHandler(this.auctionNumberInfo_Click);
            // 
            // auctionNumber_tb
            // 
            this.auctionNumber_tb.Location = new System.Drawing.Point(12, 26);
            this.auctionNumber_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.auctionNumber_tb.Name = "auctionNumber_tb";
            this.auctionNumber_tb.Size = new System.Drawing.Size(436, 22);
            this.auctionNumber_tb.TabIndex = 1;
            // 
            // auctionNumber
            // 
            this.auctionNumber.AutoSize = true;
            this.auctionNumber.Location = new System.Drawing.Point(8, 5);
            this.auctionNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.auctionNumber.Name = "auctionNumber";
            this.auctionNumber.Size = new System.Drawing.Size(160, 16);
            this.auctionNumber.TabIndex = 0;
            this.auctionNumber.Text = "Număr personal în licitație";
            // 
            // clientBudget_pan
            // 
            this.clientBudget_pan.Controls.Add(this.clientBudgetInfo);
            this.clientBudget_pan.Controls.Add(this.clientBudget_tb);
            this.clientBudget_pan.Controls.Add(this.clientBudget);
            this.clientBudget_pan.Location = new System.Drawing.Point(23, 169);
            this.clientBudget_pan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientBudget_pan.Name = "clientBudget_pan";
            this.clientBudget_pan.Size = new System.Drawing.Size(495, 58);
            this.clientBudget_pan.TabIndex = 5;
            // 
            // clientBudgetInfo
            // 
            this.clientBudgetInfo.AutoSize = true;
            this.clientBudgetInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientBudgetInfo.Location = new System.Drawing.Point(181, 5);
            this.clientBudgetInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientBudgetInfo.Name = "clientBudgetInfo";
            this.clientBudgetInfo.Size = new System.Drawing.Size(42, 16);
            this.clientBudgetInfo.TabIndex = 2;
            this.clientBudgetInfo.Text = "[ Info ]";
            this.clientBudgetInfo.Click += new System.EventHandler(this.clientBudgetInfo_Click);
            // 
            // clientBudget_tb
            // 
            this.clientBudget_tb.Location = new System.Drawing.Point(12, 26);
            this.clientBudget_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientBudget_tb.Name = "clientBudget_tb";
            this.clientBudget_tb.Size = new System.Drawing.Size(436, 22);
            this.clientBudget_tb.TabIndex = 1;
            // 
            // clientBudget
            // 
            this.clientBudget.AutoSize = true;
            this.clientBudget.Location = new System.Drawing.Point(8, 5);
            this.clientBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientBudget.Name = "clientBudget";
            this.clientBudget.Size = new System.Drawing.Size(171, 16);
            this.clientBudget.TabIndex = 0;
            this.clientBudget.Text = "Sumă disponibilă declarată";
            // 
            // saveHistory_ckb
            // 
            this.saveHistory_ckb.AutoSize = true;
            this.saveHistory_ckb.Checked = true;
            this.saveHistory_ckb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveHistory_ckb.Location = new System.Drawing.Point(35, 238);
            this.saveHistory_ckb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveHistory_ckb.Name = "saveHistory_ckb";
            this.saveHistory_ckb.Size = new System.Drawing.Size(163, 20);
            this.saveHistory_ckb.TabIndex = 1;
            this.saveHistory_ckb.Text = "Salvează istoric licitații";
            this.saveHistory_ckb.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(255, 235);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(217, 28);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Creează";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // CreateEditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 279);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.saveHistory_ckb);
            this.Controls.Add(this.clientBudget_pan);
            this.Controls.Add(this.auctionNumber_pan);
            this.Controls.Add(this.firstLastName_pan);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CreateEditClientForm";
            this.firstLastName_pan.ResumeLayout(false);
            this.firstLastName_pan.PerformLayout();
            this.auctionNumber_pan.ResumeLayout(false);
            this.auctionNumber_pan.PerformLayout();
            this.clientBudget_pan.ResumeLayout(false);
            this.clientBudget_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel firstLastName_pan;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox lastName_tb;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox firstName_tb;
        private System.Windows.Forms.Panel auctionNumber_pan;
        private System.Windows.Forms.Label auctionNumberInfo;
        private System.Windows.Forms.TextBox auctionNumber_tb;
        private System.Windows.Forms.Label auctionNumber;
        private System.Windows.Forms.Panel clientBudget_pan;
        private System.Windows.Forms.Label clientBudgetInfo;
        private System.Windows.Forms.TextBox clientBudget_tb;
        private System.Windows.Forms.Label clientBudget;
        private System.Windows.Forms.CheckBox saveHistory_ckb;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button submit_btn;
    }
}