namespace GumWars
{
    partial class LoanSharkForm
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
            this._lblWelcomeMessage = new System.Windows.Forms.Label();
            this._lblAmount = new System.Windows.Forms.Label();
            this._txtAmount = new System.Windows.Forms.TextBox();
            this._btnAction = new System.Windows.Forms.Button();
            this._lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblWelcomeMessage
            // 
            this._lblWelcomeMessage.AutoSize = true;
            this._lblWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblWelcomeMessage.Location = new System.Drawing.Point(12, 18);
            this._lblWelcomeMessage.Name = "_lblWelcomeMessage";
            this._lblWelcomeMessage.Size = new System.Drawing.Size(41, 13);
            this._lblWelcomeMessage.TabIndex = 0;
            this._lblWelcomeMessage.Text = "label1";
            // 
            // _lblAmount
            // 
            this._lblAmount.AutoSize = true;
            this._lblAmount.Location = new System.Drawing.Point(12, 71);
            this._lblAmount.Name = "_lblAmount";
            this._lblAmount.Size = new System.Drawing.Size(43, 13);
            this._lblAmount.TabIndex = 1;
            this._lblAmount.Text = "Amount";
            // 
            // _txtAmount
            // 
            this._txtAmount.Location = new System.Drawing.Point(12, 87);
            this._txtAmount.Name = "_txtAmount";
            this._txtAmount.Size = new System.Drawing.Size(110, 20);
            this._txtAmount.TabIndex = 2;
            // 
            // _btnAction
            // 
            this._btnAction.Location = new System.Drawing.Point(12, 133);
            this._btnAction.Name = "_btnAction";
            this._btnAction.Size = new System.Drawing.Size(75, 23);
            this._btnAction.TabIndex = 3;
            this._btnAction.Text = "Action";
            this._btnAction.UseVisualStyleBackColor = true;
            this._btnAction.Click += new System.EventHandler(this._btnAction_Click);
            // 
            // _lblWarning
            // 
            this._lblWarning.AutoSize = true;
            this._lblWarning.Location = new System.Drawing.Point(12, 43);
            this._lblWarning.Name = "_lblWarning";
            this._lblWarning.Size = new System.Drawing.Size(35, 13);
            this._lblWarning.TabIndex = 4;
            this._lblWarning.Text = "label1";
            // 
            // LoanSharkForm
            // 
            this.AcceptButton = this._btnAction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 175);
            this.Controls.Add(this._lblWarning);
            this.Controls.Add(this._btnAction);
            this.Controls.Add(this._txtAmount);
            this.Controls.Add(this._lblAmount);
            this.Controls.Add(this._lblWelcomeMessage);
            this.Name = "LoanSharkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoanSharkForm";
            this.Load += new System.EventHandler(this.LoanSharkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblWelcomeMessage;
        private System.Windows.Forms.Label _lblAmount;
        private System.Windows.Forms.TextBox _txtAmount;
        private System.Windows.Forms.Button _btnAction;
        private System.Windows.Forms.Label _lblWarning;
    }
}