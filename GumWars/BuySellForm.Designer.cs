namespace GumWars
{
    partial class BuySellForm
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
            this.label1 = new System.Windows.Forms.Label();
            this._cmbBuyOrSell = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtQuantity = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this._btnCommit = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buy/Sell";
            // 
            // _cmbBuyOrSell
            // 
            this._cmbBuyOrSell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbBuyOrSell.FormattingEnabled = true;
            this._cmbBuyOrSell.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this._cmbBuyOrSell.Location = new System.Drawing.Point(79, 16);
            this._cmbBuyOrSell.Name = "_cmbBuyOrSell";
            this._cmbBuyOrSell.Size = new System.Drawing.Size(121, 21);
            this._cmbBuyOrSell.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // _txtQuantity
            // 
            this._txtQuantity.Location = new System.Drawing.Point(79, 51);
            this._txtQuantity.Name = "_txtQuantity";
            this._txtQuantity.Size = new System.Drawing.Size(79, 20);
            this._txtQuantity.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 128);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(339, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _lblStatus
            // 
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(12, 17);
            this._lblStatus.Text = "_";
            // 
            // _btnCommit
            // 
            this._btnCommit.Location = new System.Drawing.Point(125, 87);
            this._btnCommit.Name = "_btnCommit";
            this._btnCommit.Size = new System.Drawing.Size(75, 23);
            this._btnCommit.TabIndex = 5;
            this._btnCommit.Text = "Do it!";
            this._btnCommit.UseVisualStyleBackColor = true;
            this._btnCommit.Click += new System.EventHandler(this._btnCommit_Click);
            // 
            // BuySellForm
            // 
            this.AcceptButton = this._btnCommit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 150);
            this.Controls.Add(this._btnCommit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cmbBuyOrSell);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuySellForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuySellForm";
            this.Load += new System.EventHandler(this.BuySellForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cmbBuyOrSell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtQuantity;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _lblStatus;
        private System.Windows.Forms.Button _btnCommit;
    }
}