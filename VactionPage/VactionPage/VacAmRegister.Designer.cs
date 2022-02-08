﻿
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
            this.SuspendLayout();
            // 
            // AmTitle
            // 
            this.AmTitle.AutoSize = true;
            this.AmTitle.BackColor = System.Drawing.Color.White;
            this.AmTitle.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AmTitle.Location = new System.Drawing.Point(262, 92);
            this.AmTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.AmTitle.Name = "AmTitle";
            this.AmTitle.Size = new System.Drawing.Size(401, 53);
            this.AmTitle.TabIndex = 0;
            this.AmTitle.Text = "(오전) 반차신청";
            // 
            // txReason
            // 
            this.txReason.BackColor = System.Drawing.SystemColors.Window;
            this.txReason.Location = new System.Drawing.Point(131, 305);
            this.txReason.Margin = new System.Windows.Forms.Padding(8);
            this.txReason.Multiline = true;
            this.txReason.Name = "txReason";
            this.txReason.Size = new System.Drawing.Size(750, 346);
            this.txReason.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(579, 722);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(193, 58);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(213, 722);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 58);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "확인";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txDate
            // 
            this.txDate.BackColor = System.Drawing.SystemColors.Window;
            this.txDate.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txDate.Location = new System.Drawing.Point(131, 200);
            this.txDate.Margin = new System.Windows.Forms.Padding(8);
            this.txDate.Multiline = true;
            this.txDate.Name = "txDate";
            this.txDate.ReadOnly = true;
            this.txDate.Size = new System.Drawing.Size(750, 66);
            this.txDate.TabIndex = 7;
            this.txDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txId
            // 
            this.txId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txId.Location = new System.Drawing.Point(708, 822);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(100, 35);
            this.txId.TabIndex = 9;
            // 
            // VacAmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 982);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.txDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txReason);
            this.Controls.Add(this.AmTitle);
            this.Margin = new System.Windows.Forms.Padding(8);
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
    }
}