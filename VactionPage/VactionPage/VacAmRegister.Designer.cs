
namespace VactionPage
{
    partial class VacAmRegister
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
            this.AmTitle = new System.Windows.Forms.Label();
            this.txReason = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txDate = new System.Windows.Forms.TextBox();
            this.txId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AmTitle
            // 
            this.AmTitle.AutoSize = true;
            this.AmTitle.BackColor = System.Drawing.Color.White;
            this.AmTitle.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AmTitle.Location = new System.Drawing.Point(114, 40);
            this.AmTitle.Name = "AmTitle";
            this.AmTitle.Size = new System.Drawing.Size(164, 21);
            this.AmTitle.TabIndex = 0;
            this.AmTitle.Text = "(오전) 반차신청";
            // 
            // txReason
            // 
            this.txReason.BackColor = System.Drawing.SystemColors.Window;
            this.txReason.Location = new System.Drawing.Point(51, 122);
            this.txReason.Multiline = true;
            this.txReason.Name = "txReason";
            this.txReason.Size = new System.Drawing.Size(294, 141);
            this.txReason.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(83, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "확인";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txDate
            // 
            this.txDate.BackColor = System.Drawing.SystemColors.Window;
            this.txDate.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txDate.Location = new System.Drawing.Point(51, 80);
            this.txDate.Multiline = true;
            this.txDate.Name = "txDate";
            this.txDate.ReadOnly = true;
            this.txDate.Size = new System.Drawing.Size(294, 29);
            this.txDate.TabIndex = 7;
            this.txDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txId
            // 
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txId.Location = new System.Drawing.Point(275, 329);
            this.txId.Margin = new System.Windows.Forms.Padding(1);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(39, 14);
            this.txId.TabIndex = 9;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.White;
            this.lbId.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbId.Location = new System.Drawing.Point(169, 9);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 21);
            this.lbId.TabIndex = 11;
            this.lbId.Text = ".";
            // 
            // VacAmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 393);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.txDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txReason);
            this.Controls.Add(this.AmTitle);
            this.Name = "VacAmRegister";
            this.Text = "VacAmRegister";
            this.Load += new System.EventHandler(this.VacAmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmTitle;
        private System.Windows.Forms.TextBox txReason;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txDate;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label lbId;
    }
}