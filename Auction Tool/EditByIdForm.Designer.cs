
namespace Auction_Tool {
    partial class EditByIdForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditByIdForm));
            this.searchTitle = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchElem_lv = new System.Windows.Forms.ListView();
            this.searchElem_lv_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchElem_lv_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTitle
            // 
            this.searchTitle.AutoSize = true;
            this.searchTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle.Location = new System.Drawing.Point(19, 14);
            this.searchTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(152, 19);
            this.searchTitle.TabIndex = 2;
            this.searchTitle.Text = "Caută articol după ID";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(23, 175);
            this.search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(92, 26);
            this.search_btn.TabIndex = 6;
            this.search_btn.Text = "Caută articol";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // searchElem_lv
            // 
            this.searchElem_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.searchElem_lv_ID,
            this.searchElem_lv_name});
            this.searchElem_lv.HideSelection = false;
            this.searchElem_lv.Location = new System.Drawing.Point(23, 46);
            this.searchElem_lv.MultiSelect = false;
            this.searchElem_lv.Name = "searchElem_lv";
            this.searchElem_lv.Size = new System.Drawing.Size(280, 97);
            this.searchElem_lv.TabIndex = 7;
            this.searchElem_lv.UseCompatibleStateImageBehavior = false;
            this.searchElem_lv.View = System.Windows.Forms.View.Details;
            this.searchElem_lv.Click += new System.EventHandler(this.searchElement_lv_Click);
            // 
            // searchElem_lv_ID
            // 
            this.searchElem_lv_ID.Text = "ID";
            this.searchElem_lv_ID.Width = 40;
            // 
            // searchElem_lv_name
            // 
            this.searchElem_lv_name.Text = "Nume articol";
            this.searchElem_lv_name.Width = 235;
            // 
            // selectedId
            // 
            this.selectedId.AutoSize = true;
            this.selectedId.Location = new System.Drawing.Point(20, 150);
            this.selectedId.Name = "selectedId";
            this.selectedId.Size = new System.Drawing.Size(61, 13);
            this.selectedId.TabIndex = 8;
            this.selectedId.Text = "ID selectat:";
            // 
            // EditByIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 214);
            this.Controls.Add(this.selectedId);
            this.Controls.Add(this.searchElem_lv);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.searchTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditByIdForm";
            this.Text = "Caută articol";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchTitle;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListView searchElem_lv;
        private System.Windows.Forms.ColumnHeader searchElem_lv_ID;
        private System.Windows.Forms.ColumnHeader searchElem_lv_name;
        private System.Windows.Forms.Label selectedId;
    }
}