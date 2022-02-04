
namespace Vaction_Select
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.plTop = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.plView = new System.Windows.Forms.Panel();
            this.plTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.White;
            this.plTop.Controls.Add(this.Title);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(800, 80);
            this.plTop.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("돋움", 34F);
            this.Title.Location = new System.Drawing.Point(241, 19);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(297, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "une 휴가일정";
            // 
            // plView
            // 
            this.plView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plView.Location = new System.Drawing.Point(0, 80);
            this.plView.Name = "plView";
            this.plView.Size = new System.Drawing.Size(800, 370);
            this.plView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plView);
            this.Controls.Add(this.plTop);
            this.Name = "Form1";
            this.Text = "웹브라우저";
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Panel plView;
        private System.Windows.Forms.Label Title;
    }
}

