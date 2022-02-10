
namespace VactionPage
{
    partial class AdminPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbapp = new System.Windows.Forms.Label();
            this.lbVacOk = new System.Windows.Forms.Label();
            this.lbVacList = new System.Windows.Forms.Label();
            this.lbAddVac = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.vacListView = new System.Windows.Forms.DataGridView();
            this.lbId = new System.Windows.Forms.Label();
            this.goApproveForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacListView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbapp);
            this.panel1.Controls.Add(this.lbVacOk);
            this.panel1.Controls.Add(this.lbVacList);
            this.panel1.Controls.Add(this.lbAddVac);
            this.panel1.Location = new System.Drawing.Point(24, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 566);
            this.panel1.TabIndex = 16;
            // 
            // lbapp
            // 
            this.lbapp.AutoSize = true;
            this.lbapp.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbapp.Location = new System.Drawing.Point(16, 318);
            this.lbapp.Name = "lbapp";
            this.lbapp.Size = new System.Drawing.Size(178, 24);
            this.lbapp.TabIndex = 4;
            this.lbapp.Text = "결재대기리스트";
            this.lbapp.Click += new System.EventHandler(this.lbapp_Click);
            // 
            // lbVacOk
            // 
            this.lbVacOk.AutoSize = true;
            this.lbVacOk.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbVacOk.Location = new System.Drawing.Point(26, 450);
            this.lbVacOk.Name = "lbVacOk";
            this.lbVacOk.Size = new System.Drawing.Size(154, 24);
            this.lbVacOk.TabIndex = 3;
            this.lbVacOk.Text = "휴가결재승인";
            // 
            // lbVacList
            // 
            this.lbVacList.AutoSize = true;
            this.lbVacList.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbVacList.Location = new System.Drawing.Point(54, 175);
            this.lbVacList.Name = "lbVacList";
            this.lbVacList.Size = new System.Drawing.Size(106, 24);
            this.lbVacList.TabIndex = 2;
            this.lbVacList.Text = "휴가현황";
            this.lbVacList.Click += new System.EventHandler(this.lbVacList_Click);
            // 
            // lbAddVac
            // 
            this.lbAddVac.AutoSize = true;
            this.lbAddVac.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAddVac.Location = new System.Drawing.Point(54, 46);
            this.lbAddVac.Name = "lbAddVac";
            this.lbAddVac.Size = new System.Drawing.Size(106, 24);
            this.lbAddVac.TabIndex = 0;
            this.lbAddVac.Text = "휴가요청";
            this.lbAddVac.Click += new System.EventHandler(this.lbAddVac_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(717, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(156, 46);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "휴가승인";
            // 
            // vacListView
            // 
            this.vacListView.BackgroundColor = System.Drawing.Color.White;
            this.vacListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacListView.Location = new System.Drawing.Point(314, 156);
            this.vacListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vacListView.Name = "vacListView";
            this.vacListView.RowHeadersWidth = 51;
            this.vacListView.RowTemplate.Height = 23;
            this.vacListView.Size = new System.Drawing.Size(958, 566);
            this.vacListView.TabIndex = 38;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbId.Location = new System.Drawing.Point(728, 88);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(72, 20);
            this.lbId.TabIndex = 37;
            this.lbId.Text = "이름ㅇ";
            // 
            // goApproveForm
            // 
            this.goApproveForm.BackColor = System.Drawing.Color.White;
            this.goApproveForm.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goApproveForm.Location = new System.Drawing.Point(1067, 88);
            this.goApproveForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goApproveForm.Name = "goApproveForm";
            this.goApproveForm.Size = new System.Drawing.Size(203, 56);
            this.goApproveForm.TabIndex = 39;
            this.goApproveForm.Text = "휴가승인 선택하기";
            this.goApproveForm.UseVisualStyleBackColor = false;
            this.goApproveForm.Click += new System.EventHandler(this.goApproveForm_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.ClientSize = new System.Drawing.Size(1373, 852);
            this.Controls.Add(this.goApproveForm);
            this.Controls.Add(this.vacListView);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminPage";
            this.Text = "adminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbVacList;
        private System.Windows.Forms.Label lbAddVac;
        private System.Windows.Forms.Label lbVacOk;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView vacListView;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbapp;
        private System.Windows.Forms.Button goApproveForm;
    }
}