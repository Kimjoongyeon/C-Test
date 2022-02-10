
namespace VactionPage
{
    partial class VactionApproveForm
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
            this.txNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txNo
            // 
            this.txNo.Location = new System.Drawing.Point(79, 206);
            this.txNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txNo.Multiline = true;
            this.txNo.Name = "txNo";
            this.txNo.Size = new System.Drawing.Size(380, 35);
            this.txNo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 46);
            this.label4.TabIndex = 45;
            this.label4.Text = "휴가 승인하기";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblId.Location = new System.Drawing.Point(75, 181);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 20);
            this.lblId.TabIndex = 46;
            this.lblId.Text = "번호";
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(106, 288);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(153, 38);
            this.btnApprove.TabIndex = 47;
            this.btnApprove.Text = "승인하기";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 288);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 38);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "취소하기";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // VactionApproveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 381);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txNo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VactionApproveForm";
            this.Text = "VactionApproveForm";
            this.Load += new System.EventHandler(this.VactionApproveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnCancel;
    }
}