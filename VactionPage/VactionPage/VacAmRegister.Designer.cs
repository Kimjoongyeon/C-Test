
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
            this.txEvent = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AmTitle
            // 
            this.AmTitle.AutoSize = true;
            this.AmTitle.BackColor = System.Drawing.Color.White;
            this.AmTitle.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AmTitle.Location = new System.Drawing.Point(116, 46);
            this.AmTitle.Name = "AmTitle";
            this.AmTitle.Size = new System.Drawing.Size(212, 27);
            this.AmTitle.TabIndex = 0;
            this.AmTitle.Text = "(오전) 반차신청";
            // 
            // txEvent
            // 
            this.txEvent.BackColor = System.Drawing.SystemColors.Window;
            this.txEvent.Location = new System.Drawing.Point(58, 153);
            this.txEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txEvent.Multiline = true;
            this.txEvent.Name = "txEvent";
            this.txEvent.Size = new System.Drawing.Size(335, 175);
            this.txEvent.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 361);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(95, 361);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "확인";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txDate
            // 
            this.txDate.BackColor = System.Drawing.SystemColors.Window;
            this.txDate.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txDate.Location = new System.Drawing.Point(58, 100);
            this.txDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txDate.Multiline = true;
            this.txDate.Name = "txDate";
            this.txDate.ReadOnly = true;
            this.txDate.Size = new System.Drawing.Size(335, 35);
            this.txDate.TabIndex = 7;
            this.txDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VacAmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 491);
            this.Controls.Add(this.txDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txEvent);
            this.Controls.Add(this.AmTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VacAmRegister";
            this.Text = "VacAmRegister";
            this.Load += new System.EventHandler(this.VacAmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmTitle;
        private System.Windows.Forms.TextBox txEvent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txDate;
    }
}