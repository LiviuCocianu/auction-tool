
namespace Auction_Tool {
    partial class CreateClientForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateClientForm));
            this.creeaza_title = new System.Windows.Forms.Label();
            this.numePrenum_pan = new System.Windows.Forms.Panel();
            this.prenumeClient_tb = new System.Windows.Forms.TextBox();
            this.prenumeClient = new System.Windows.Forms.Label();
            this.numeClient_tb = new System.Windows.Forms.TextBox();
            this.numeClient = new System.Windows.Forms.Label();
            this.numarLicitatie_pan = new System.Windows.Forms.Panel();
            this.numarLicitatieInfo = new System.Windows.Forms.Label();
            this.numarLicitatie_tb = new System.Windows.Forms.TextBox();
            this.numarLicitatie = new System.Windows.Forms.Label();
            this.sumaDisp_pan = new System.Windows.Forms.Panel();
            this.sumaDispInfo = new System.Windows.Forms.Label();
            this.sumaDisp_tb = new System.Windows.Forms.TextBox();
            this.sumaDisp = new System.Windows.Forms.Label();
            this.salveazaIst_ckb = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.numePrenum_pan.SuspendLayout();
            this.numarLicitatie_pan.SuspendLayout();
            this.sumaDisp_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // creeaza_title
            // 
            this.creeaza_title.AutoSize = true;
            this.creeaza_title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creeaza_title.Location = new System.Drawing.Point(19, 14);
            this.creeaza_title.Name = "creeaza_title";
            this.creeaza_title.Size = new System.Drawing.Size(156, 19);
            this.creeaza_title.TabIndex = 0;
            this.creeaza_title.Text = "Creează un client nou";
            // 
            // numePrenum_pan
            // 
            this.numePrenum_pan.Controls.Add(this.prenumeClient_tb);
            this.numePrenum_pan.Controls.Add(this.prenumeClient);
            this.numePrenum_pan.Controls.Add(this.numeClient_tb);
            this.numePrenum_pan.Controls.Add(this.numeClient);
            this.numePrenum_pan.Location = new System.Drawing.Point(17, 45);
            this.numePrenum_pan.Name = "numePrenum_pan";
            this.numePrenum_pan.Size = new System.Drawing.Size(371, 47);
            this.numePrenum_pan.TabIndex = 1;
            // 
            // prenumeClient_tb
            // 
            this.prenumeClient_tb.Location = new System.Drawing.Point(174, 21);
            this.prenumeClient_tb.Name = "prenumeClient_tb";
            this.prenumeClient_tb.Size = new System.Drawing.Size(163, 20);
            this.prenumeClient_tb.TabIndex = 3;
            // 
            // prenumeClient
            // 
            this.prenumeClient.AutoSize = true;
            this.prenumeClient.Location = new System.Drawing.Point(171, 4);
            this.prenumeClient.Name = "prenumeClient";
            this.prenumeClient.Size = new System.Drawing.Size(49, 13);
            this.prenumeClient.TabIndex = 2;
            this.prenumeClient.Text = "Prenume";
            // 
            // numeClient_tb
            // 
            this.numeClient_tb.Location = new System.Drawing.Point(9, 21);
            this.numeClient_tb.Name = "numeClient_tb";
            this.numeClient_tb.Size = new System.Drawing.Size(131, 20);
            this.numeClient_tb.TabIndex = 1;
            // 
            // numeClient
            // 
            this.numeClient.AutoSize = true;
            this.numeClient.Location = new System.Drawing.Point(6, 4);
            this.numeClient.Name = "numeClient";
            this.numeClient.Size = new System.Drawing.Size(35, 13);
            this.numeClient.TabIndex = 0;
            this.numeClient.Text = "Nume";
            // 
            // numarLicitatie_pan
            // 
            this.numarLicitatie_pan.Controls.Add(this.numarLicitatieInfo);
            this.numarLicitatie_pan.Controls.Add(this.numarLicitatie_tb);
            this.numarLicitatie_pan.Controls.Add(this.numarLicitatie);
            this.numarLicitatie_pan.Location = new System.Drawing.Point(17, 91);
            this.numarLicitatie_pan.Name = "numarLicitatie_pan";
            this.numarLicitatie_pan.Size = new System.Drawing.Size(371, 47);
            this.numarLicitatie_pan.TabIndex = 4;
            // 
            // numarLicitatieInfo
            // 
            this.numarLicitatieInfo.AutoSize = true;
            this.numarLicitatieInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numarLicitatieInfo.Location = new System.Drawing.Point(131, 4);
            this.numarLicitatieInfo.Name = "numarLicitatieInfo";
            this.numarLicitatieInfo.Size = new System.Drawing.Size(37, 13);
            this.numarLicitatieInfo.TabIndex = 2;
            this.numarLicitatieInfo.Text = "[ Info ]";
            this.numarLicitatieInfo.Click += new System.EventHandler(this.numarLicitatieInfo_Click);
            // 
            // numarLicitatie_tb
            // 
            this.numarLicitatie_tb.Location = new System.Drawing.Point(9, 21);
            this.numarLicitatie_tb.Name = "numarLicitatie_tb";
            this.numarLicitatie_tb.Size = new System.Drawing.Size(328, 20);
            this.numarLicitatie_tb.TabIndex = 1;
            // 
            // numarLicitatie
            // 
            this.numarLicitatie.AutoSize = true;
            this.numarLicitatie.Location = new System.Drawing.Point(6, 4);
            this.numarLicitatie.Name = "numarLicitatie";
            this.numarLicitatie.Size = new System.Drawing.Size(129, 13);
            this.numarLicitatie.TabIndex = 0;
            this.numarLicitatie.Text = "Număr personal în licitație";
            // 
            // sumaDisp_pan
            // 
            this.sumaDisp_pan.Controls.Add(this.sumaDispInfo);
            this.sumaDisp_pan.Controls.Add(this.sumaDisp_tb);
            this.sumaDisp_pan.Controls.Add(this.sumaDisp);
            this.sumaDisp_pan.Location = new System.Drawing.Point(17, 137);
            this.sumaDisp_pan.Name = "sumaDisp_pan";
            this.sumaDisp_pan.Size = new System.Drawing.Size(371, 47);
            this.sumaDisp_pan.TabIndex = 5;
            // 
            // sumaDispInfo
            // 
            this.sumaDispInfo.AutoSize = true;
            this.sumaDispInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sumaDispInfo.Location = new System.Drawing.Point(136, 4);
            this.sumaDispInfo.Name = "sumaDispInfo";
            this.sumaDispInfo.Size = new System.Drawing.Size(37, 13);
            this.sumaDispInfo.TabIndex = 2;
            this.sumaDispInfo.Text = "[ Info ]";
            this.sumaDispInfo.Click += new System.EventHandler(this.sumaDispInfo_Click);
            // 
            // sumaDisp_tb
            // 
            this.sumaDisp_tb.Location = new System.Drawing.Point(9, 21);
            this.sumaDisp_tb.Name = "sumaDisp_tb";
            this.sumaDisp_tb.Size = new System.Drawing.Size(328, 20);
            this.sumaDisp_tb.TabIndex = 1;
            // 
            // sumaDisp
            // 
            this.sumaDisp.AutoSize = true;
            this.sumaDisp.Location = new System.Drawing.Point(6, 4);
            this.sumaDisp.Name = "sumaDisp";
            this.sumaDisp.Size = new System.Drawing.Size(133, 13);
            this.sumaDisp.TabIndex = 0;
            this.sumaDisp.Text = "Sumă disponibilă declarată";
            // 
            // salveazaIst_ckb
            // 
            this.salveazaIst_ckb.AutoSize = true;
            this.salveazaIst_ckb.Checked = true;
            this.salveazaIst_ckb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.salveazaIst_ckb.Location = new System.Drawing.Point(26, 193);
            this.salveazaIst_ckb.Name = "salveazaIst_ckb";
            this.salveazaIst_ckb.Size = new System.Drawing.Size(131, 17);
            this.salveazaIst_ckb.TabIndex = 1;
            this.salveazaIst_ckb.Text = "Salvează istoric licitații";
            this.salveazaIst_ckb.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Creează";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.creeazaClient_btn_Click);
            // 
            // CreateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salveazaIst_ckb);
            this.Controls.Add(this.sumaDisp_pan);
            this.Controls.Add(this.numarLicitatie_pan);
            this.Controls.Add(this.numePrenum_pan);
            this.Controls.Add(this.creeaza_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateClientForm";
            this.numePrenum_pan.ResumeLayout(false);
            this.numePrenum_pan.PerformLayout();
            this.numarLicitatie_pan.ResumeLayout(false);
            this.numarLicitatie_pan.PerformLayout();
            this.sumaDisp_pan.ResumeLayout(false);
            this.sumaDisp_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creeaza_title;
        private System.Windows.Forms.Panel numePrenum_pan;
        private System.Windows.Forms.Label numeClient;
        private System.Windows.Forms.TextBox prenumeClient_tb;
        private System.Windows.Forms.Label prenumeClient;
        private System.Windows.Forms.TextBox numeClient_tb;
        private System.Windows.Forms.Panel numarLicitatie_pan;
        private System.Windows.Forms.Label numarLicitatieInfo;
        private System.Windows.Forms.TextBox numarLicitatie_tb;
        private System.Windows.Forms.Label numarLicitatie;
        private System.Windows.Forms.Panel sumaDisp_pan;
        private System.Windows.Forms.Label sumaDispInfo;
        private System.Windows.Forms.TextBox sumaDisp_tb;
        private System.Windows.Forms.Label sumaDisp;
        private System.Windows.Forms.CheckBox salveazaIst_ckb;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button button1;
    }
}