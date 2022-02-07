
namespace VactionPage
{
    partial class VacPmRegister
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
            this.PmTitle = new System.Windows.Forms.Label();
            this.txEvent = new System.Windows.Forms.TextBox();
            this.okVac = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PmTitle
            // 
            this.PmTitle.AutoSize = true;
            this.PmTitle.BackColor = System.Drawing.Color.White;
            this.PmTitle.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PmTitle.Location = new System.Drawing.Point(126, 54);
            this.PmTitle.Name = "PmTitle";
            this.PmTitle.Size = new System.Drawing.Size(212, 27);
            this.PmTitle.TabIndex = 1;
            this.PmTitle.Text = "(오후) 반차신청";
            // 
            // txEvent
            // 
            this.txEvent.BackColor = System.Drawing.SystemColors.Window;
            this.txEvent.Location = new System.Drawing.Point(50, 165);
            this.txEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txEvent.Multiline = true;
            this.txEvent.Name = "txEvent";
            this.txEvent.Size = new System.Drawing.Size(335, 175);
            this.txEvent.TabIndex = 2;
            // 
            // okVac
            // 
            this.okVac.Location = new System.Drawing.Point(93, 362);
            this.okVac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okVac.Name = "okVac";
            this.okVac.Size = new System.Drawing.Size(86, 29);
            this.okVac.TabIndex = 3;
            this.okVac.Text = "확인";
            this.okVac.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 362);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txDate
            // 
            this.txDate.BackColor = System.Drawing.SystemColors.Window;
            this.txDate.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txDate.Location = new System.Drawing.Point(50, 107);
            this.txDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txDate.Multiline = true;
            this.txDate.Name = "txDate";
            this.txDate.ReadOnly = true;
            this.txDate.Size = new System.Drawing.Size(335, 35);
            this.txDate.TabIndex = 8;
            this.txDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VacPmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 491);
            this.Controls.Add(this.txDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.okVac);
            this.Controls.Add(this.txEvent);
            this.Controls.Add(this.PmTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VacPmRegister";
            this.Text = "VacPmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PmTitle;
        private System.Windows.Forms.TextBox txEvent;
        private System.Windows.Forms.Button okVac;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txDate;
    }
}