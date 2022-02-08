
namespace VactionPage
{
    partial class VacWaitList
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVacOk = new System.Windows.Forms.Label();
            this.lbVacList = new System.Windows.Forms.Label();
            this.lbapp = new System.Windows.Forms.Label();
            this.lbAddVac = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNo = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbVacTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.laReason = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(757, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(197, 36);
            this.lbTitle.TabIndex = 32;
            this.lbTitle.Text = "결재대기리스트";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbVacOk);
            this.panel1.Controls.Add(this.lbVacList);
            this.panel1.Controls.Add(this.lbapp);
            this.panel1.Controls.Add(this.lbAddVac);
            this.panel1.Location = new System.Drawing.Point(25, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 453);
            this.panel1.TabIndex = 33;
            // 
            // lbVacOk
            // 
            this.lbVacOk.AutoSize = true;
            this.lbVacOk.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbVacOk.Location = new System.Drawing.Point(23, 360);
            this.lbVacOk.Name = "lbVacOk";
            this.lbVacOk.Size = new System.Drawing.Size(129, 19);
            this.lbVacOk.TabIndex = 3;
            this.lbVacOk.Text = "휴가결재승인";
            // 
            // lbVacList
            // 
            this.lbVacList.AutoSize = true;
            this.lbVacList.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbVacList.Location = new System.Drawing.Point(47, 140);
            this.lbVacList.Name = "lbVacList";
            this.lbVacList.Size = new System.Drawing.Size(89, 19);
            this.lbVacList.TabIndex = 2;
            this.lbVacList.Text = "휴가현황";
            this.lbVacList.Click += new System.EventHandler(this.lbVacList_Click);
            // 
            // lbapp
            // 
            this.lbapp.AutoSize = true;
            this.lbapp.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbapp.Location = new System.Drawing.Point(13, 254);
            this.lbapp.Name = "lbapp";
            this.lbapp.Size = new System.Drawing.Size(149, 19);
            this.lbapp.TabIndex = 1;
            this.lbapp.Text = "결재대기리스트";
            // 
            // lbAddVac
            // 
            this.lbAddVac.AutoSize = true;
            this.lbAddVac.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAddVac.Location = new System.Drawing.Point(47, 37);
            this.lbAddVac.Name = "lbAddVac";
            this.lbAddVac.Size = new System.Drawing.Size(89, 19);
            this.lbAddVac.TabIndex = 0;
            this.lbAddVac.Text = "휴가요청";
            this.lbAddVac.Click += new System.EventHandler(this.lbAddVac_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbId.Location = new System.Drawing.Point(815, 68);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(59, 16);
            this.lbId.TabIndex = 34;
            this.lbId.Text = "이름ㅇ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.laReason);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.lbVacTime);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.lbNo);
            this.panel2.Location = new System.Drawing.Point(258, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 55);
            this.panel2.TabIndex = 35;
            // 
            // lbNo
            // 
            this.lbNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNo.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNo.Location = new System.Drawing.Point(0, 0);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(108, 55);
            this.lbNo.TabIndex = 0;
            this.lbNo.Text = "번호";
            this.lbNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbName.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbName.Location = new System.Drawing.Point(105, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(156, 55);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "아이디";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVacTime
            // 
            this.lbVacTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbVacTime.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbVacTime.Location = new System.Drawing.Point(623, 0);
            this.lbVacTime.Name = "lbVacTime";
            this.lbVacTime.Size = new System.Drawing.Size(250, 55);
            this.lbVacTime.TabIndex = 2;
            this.lbVacTime.Text = "휴가";
            this.lbVacTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDate
            // 
            this.lbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDate.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDate.Location = new System.Drawing.Point(859, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(258, 55);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "날짜";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laReason
            // 
            this.laReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laReason.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.laReason.Location = new System.Drawing.Point(257, 0);
            this.laReason.Name = "laReason";
            this.laReason.Size = new System.Drawing.Size(370, 55);
            this.laReason.TabIndex = 4;
            this.laReason.Text = "휴가사유";
            this.laReason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VacWaitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1456, 654);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.Name = "VacWaitList";
            this.Text = "VacWaitList";
            this.Load += new System.EventHandler(this.VacWaitList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbVacOk;
        private System.Windows.Forms.Label lbVacList;
        private System.Windows.Forms.Label lbapp;
        private System.Windows.Forms.Label lbAddVac;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbVacTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label laReason;
    }
}