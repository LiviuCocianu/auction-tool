
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
            this.auctionNo_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.auctionNumber = new System.Windows.Forms.Label();
            this.auctionNoGuide_pb = new System.Windows.Forms.PictureBox();
            this.auctionNumber_tb = new System.Windows.Forms.TextBox();
            this.clientBudget_pan = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.clientBudget = new System.Windows.Forms.Label();
            this.budgeGuide_pb = new System.Windows.Forms.PictureBox();
            this.clientBudget_tb = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.submit_btn = new System.Windows.Forms.Button();
            this.firstLastName_pan.SuspendLayout();
            this.auctionNumber_pan.SuspendLayout();
            this.auctionNo_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionNoGuide_pb)).BeginInit();
            this.clientBudget_pan.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgeGuide_pb)).BeginInit();
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
            this.firstLastName_pan.Margin = new System.Windows.Forms.Padding(4);
            this.firstLastName_pan.Name = "firstLastName_pan";
            this.firstLastName_pan.Size = new System.Drawing.Size(495, 58);
            this.firstLastName_pan.TabIndex = 1;
            // 
            // lastName_tb
            // 
            this.lastName_tb.Location = new System.Drawing.Point(232, 26);
            this.lastName_tb.Margin = new System.Windows.Forms.Padding(4);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(216, 22);
            this.lastName_tb.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(228, 5);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(61, 16);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Prenume";
            // 
            // firstName_tb
            // 
            this.firstName_tb.Location = new System.Drawing.Point(12, 26);
            this.firstName_tb.Margin = new System.Windows.Forms.Padding(4);
            this.firstName_tb.Name = "firstName_tb";
            this.firstName_tb.Size = new System.Drawing.Size(173, 22);
            this.firstName_tb.TabIndex = 1;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(8, 5);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(43, 16);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "Nume";
            // 
            // auctionNumber_pan
            // 
            this.auctionNumber_pan.Controls.Add(this.auctionNo_pan);
            this.auctionNumber_pan.Controls.Add(this.auctionNumber_tb);
            this.auctionNumber_pan.Location = new System.Drawing.Point(23, 112);
            this.auctionNumber_pan.Margin = new System.Windows.Forms.Padding(4);
            this.auctionNumber_pan.Name = "auctionNumber_pan";
            this.auctionNumber_pan.Size = new System.Drawing.Size(495, 58);
            this.auctionNumber_pan.TabIndex = 4;
            // 
            // auctionNo_pan
            // 
            this.auctionNo_pan.Controls.Add(this.auctionNumber);
            this.auctionNo_pan.Controls.Add(this.auctionNoGuide_pb);
            this.auctionNo_pan.Location = new System.Drawing.Point(6, 0);
            this.auctionNo_pan.Margin = new System.Windows.Forms.Padding(0);
            this.auctionNo_pan.Name = "auctionNo_pan";
            this.auctionNo_pan.Size = new System.Drawing.Size(442, 25);
            this.auctionNo_pan.TabIndex = 4;
            // 
            // auctionNumber
            // 
            this.auctionNumber.AutoSize = true;
            this.auctionNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.auctionNumber.Location = new System.Drawing.Point(4, 0);
            this.auctionNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.auctionNumber.Name = "auctionNumber";
            this.auctionNumber.Size = new System.Drawing.Size(160, 24);
            this.auctionNumber.TabIndex = 0;
            this.auctionNumber.Text = "Număr personal în licitație";
            this.auctionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // auctionNoGuide_pb
            // 
            this.auctionNoGuide_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auctionNoGuide_pb.Image = global::Auction_Tool.Properties.Resources.guide_button;
            this.auctionNoGuide_pb.InitialImage = global::Auction_Tool.Properties.Resources.guide_button;
            this.auctionNoGuide_pb.Location = new System.Drawing.Point(171, 3);
            this.auctionNoGuide_pb.Name = "auctionNoGuide_pb";
            this.auctionNoGuide_pb.Size = new System.Drawing.Size(18, 18);
            this.auctionNoGuide_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auctionNoGuide_pb.TabIndex = 3;
            this.auctionNoGuide_pb.TabStop = false;
            this.auctionNoGuide_pb.Click += new System.EventHandler(this.auctionNumberInfo_Click);
            // 
            // auctionNumber_tb
            // 
            this.auctionNumber_tb.Location = new System.Drawing.Point(12, 26);
            this.auctionNumber_tb.Margin = new System.Windows.Forms.Padding(4);
            this.auctionNumber_tb.Name = "auctionNumber_tb";
            this.auctionNumber_tb.Size = new System.Drawing.Size(436, 22);
            this.auctionNumber_tb.TabIndex = 1;
            // 
            // clientBudget_pan
            // 
            this.clientBudget_pan.Controls.Add(this.flowLayoutPanel1);
            this.clientBudget_pan.Controls.Add(this.clientBudget_tb);
            this.clientBudget_pan.Location = new System.Drawing.Point(23, 169);
            this.clientBudget_pan.Margin = new System.Windows.Forms.Padding(4);
            this.clientBudget_pan.Name = "clientBudget_pan";
            this.clientBudget_pan.Size = new System.Drawing.Size(495, 58);
            this.clientBudget_pan.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.clientBudget);
            this.flowLayoutPanel1.Controls.Add(this.budgeGuide_pb);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(442, 25);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // clientBudget
            // 
            this.clientBudget.AutoSize = true;
            this.clientBudget.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientBudget.Location = new System.Drawing.Point(4, 0);
            this.clientBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientBudget.Name = "clientBudget";
            this.clientBudget.Size = new System.Drawing.Size(94, 24);
            this.clientBudget.TabIndex = 0;
            this.clientBudget.Text = "Buget declarat";
            this.clientBudget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // budgeGuide_pb
            // 
            this.budgeGuide_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.budgeGuide_pb.Image = global::Auction_Tool.Properties.Resources.guide_button;
            this.budgeGuide_pb.InitialImage = global::Auction_Tool.Properties.Resources.guide_button;
            this.budgeGuide_pb.Location = new System.Drawing.Point(105, 3);
            this.budgeGuide_pb.Name = "budgeGuide_pb";
            this.budgeGuide_pb.Size = new System.Drawing.Size(18, 18);
            this.budgeGuide_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.budgeGuide_pb.TabIndex = 4;
            this.budgeGuide_pb.TabStop = false;
            this.budgeGuide_pb.Click += new System.EventHandler(this.clientBudgetInfo_Click);
            // 
            // clientBudget_tb
            // 
            this.clientBudget_tb.Location = new System.Drawing.Point(12, 26);
            this.clientBudget_tb.Margin = new System.Windows.Forms.Padding(4);
            this.clientBudget_tb.Name = "clientBudget_tb";
            this.clientBudget_tb.Size = new System.Drawing.Size(436, 22);
            this.clientBudget_tb.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(35, 235);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(4);
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
            this.Controls.Add(this.clientBudget_pan);
            this.Controls.Add(this.auctionNumber_pan);
            this.Controls.Add(this.firstLastName_pan);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateEditClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.firstLastName_pan.ResumeLayout(false);
            this.firstLastName_pan.PerformLayout();
            this.auctionNumber_pan.ResumeLayout(false);
            this.auctionNumber_pan.PerformLayout();
            this.auctionNo_pan.ResumeLayout(false);
            this.auctionNo_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auctionNoGuide_pb)).EndInit();
            this.clientBudget_pan.ResumeLayout(false);
            this.clientBudget_pan.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgeGuide_pb)).EndInit();
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
        private System.Windows.Forms.TextBox auctionNumber_tb;
        private System.Windows.Forms.Label auctionNumber;
        private System.Windows.Forms.Panel clientBudget_pan;
        private System.Windows.Forms.TextBox clientBudget_tb;
        private System.Windows.Forms.Label clientBudget;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.PictureBox auctionNoGuide_pb;
        private System.Windows.Forms.FlowLayoutPanel auctionNo_pan;
        private System.Windows.Forms.PictureBox budgeGuide_pb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}