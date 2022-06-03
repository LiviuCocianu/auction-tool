
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
            this.submit_btn = new System.Windows.Forms.Button();
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
            this.searchTitle.Location = new System.Drawing.Point(25, 17);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(188, 24);
            this.searchTitle.TabIndex = 2;
            this.searchTitle.Text = "Caută articol după ID";
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(31, 215);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(123, 32);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Caută";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.search_btn_Click);
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
            this.searchElem_lv.Location = new System.Drawing.Point(31, 57);
            this.searchElem_lv.Margin = new System.Windows.Forms.Padding(4);
            this.searchElem_lv.MultiSelect = false;
            this.searchElem_lv.Name = "searchElem_lv";
            this.searchElem_lv.Size = new System.Drawing.Size(372, 118);
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
            this.selectedId.Location = new System.Drawing.Point(27, 185);
            this.selectedId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedId.Name = "selectedId";
            this.selectedId.Size = new System.Drawing.Size(73, 16);
            this.selectedId.TabIndex = 8;
            this.selectedId.Text = "ID selectat:";
            // 
            // EditByIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 263);
            this.Controls.Add(this.selectedId);
            this.Controls.Add(this.searchElem_lv);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.searchTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditByIdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchTitle;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListView searchElem_lv;
        private System.Windows.Forms.ColumnHeader searchElem_lv_ID;
        private System.Windows.Forms.ColumnHeader searchElem_lv_name;
        private System.Windows.Forms.Label selectedId;
    }
}