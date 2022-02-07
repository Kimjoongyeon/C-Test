
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
            this.AmVacPlease = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.okVac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AmTitle
            // 
            this.AmTitle.AutoSize = true;
            this.AmTitle.BackColor = System.Drawing.Color.White;
            this.AmTitle.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AmTitle.Location = new System.Drawing.Point(113, 36);
            this.AmTitle.Name = "AmTitle";
            this.AmTitle.Size = new System.Drawing.Size(164, 21);
            this.AmTitle.TabIndex = 0;
            this.AmTitle.Text = "(오전) 반차신청";
            // 
            // AmVacPlease
            // 
            this.AmVacPlease.BackColor = System.Drawing.SystemColors.Window;
            this.AmVacPlease.Location = new System.Drawing.Point(46, 92);
            this.AmVacPlease.Multiline = true;
            this.AmVacPlease.Name = "AmVacPlease";
            this.AmVacPlease.Size = new System.Drawing.Size(294, 141);
            this.AmVacPlease.TabIndex = 3;
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
            // okVac
            // 
            this.okVac.Location = new System.Drawing.Point(83, 289);
            this.okVac.Name = "okVac";
            this.okVac.Size = new System.Drawing.Size(75, 23);
            this.okVac.TabIndex = 5;
            this.okVac.Text = "확인";
            this.okVac.UseVisualStyleBackColor = true;
            // 
            // VacAmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 393);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.okVac);
            this.Controls.Add(this.AmVacPlease);
            this.Controls.Add(this.AmTitle);
            this.Name = "VacAmRegister";
            this.Text = "VacAmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmTitle;
        private System.Windows.Forms.TextBox AmVacPlease;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button okVac;
    }
}