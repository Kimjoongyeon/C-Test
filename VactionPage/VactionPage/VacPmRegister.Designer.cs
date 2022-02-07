
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
            this.PmVacPlease = new System.Windows.Forms.TextBox();
            this.okVac = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PmTitle
            // 
            this.PmTitle.AutoSize = true;
            this.PmTitle.BackColor = System.Drawing.Color.White;
            this.PmTitle.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PmTitle.Location = new System.Drawing.Point(110, 43);
            this.PmTitle.Name = "PmTitle";
            this.PmTitle.Size = new System.Drawing.Size(164, 21);
            this.PmTitle.TabIndex = 1;
            this.PmTitle.Text = "(오후) 반차신청";
            // 
            // PmVacPlease
            // 
            this.PmVacPlease.BackColor = System.Drawing.SystemColors.Window;
            this.PmVacPlease.Location = new System.Drawing.Point(40, 100);
            this.PmVacPlease.Multiline = true;
            this.PmVacPlease.Name = "PmVacPlease";
            this.PmVacPlease.Size = new System.Drawing.Size(294, 141);
            this.PmVacPlease.TabIndex = 2;
            // 
            // okVac
            // 
            this.okVac.Location = new System.Drawing.Point(81, 290);
            this.okVac.Name = "okVac";
            this.okVac.Size = new System.Drawing.Size(75, 23);
            this.okVac.TabIndex = 3;
            this.okVac.Text = "확인";
            this.okVac.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // VacPmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 393);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.okVac);
            this.Controls.Add(this.PmVacPlease);
            this.Controls.Add(this.PmTitle);
            this.Name = "VacPmRegister";
            this.Text = "VacPmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PmTitle;
        private System.Windows.Forms.TextBox PmVacPlease;
        private System.Windows.Forms.Button okVac;
        private System.Windows.Forms.Button btnCancel;
    }
}