
namespace VactionPage
{
    partial class UserControlDays
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbdays = new System.Windows.Forms.Label();
            this.panelAM = new System.Windows.Forms.Panel();
            this.vacAM3 = new System.Windows.Forms.Label();
            this.vacAM2 = new System.Windows.Forms.Label();
            this.lbAmEvent = new System.Windows.Forms.Label();
            this.panelPM = new System.Windows.Forms.Panel();
            this.lbPmEvent = new System.Windows.Forms.Label();
            this.vacPM3 = new System.Windows.Forms.Label();
            this.vacPM2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelAM.SuspendLayout();
            this.panelPM.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("굴림체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbdays.Location = new System.Drawing.Point(3, 10);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(24, 16);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            // 
            // panelAM
            // 
            this.panelAM.BackColor = System.Drawing.Color.White;
            this.panelAM.Controls.Add(this.vacAM3);
            this.panelAM.Controls.Add(this.vacAM2);
            this.panelAM.Controls.Add(this.lbAmEvent);
            this.panelAM.Font = new System.Drawing.Font("굴림", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panelAM.Location = new System.Drawing.Point(33, 10);
            this.panelAM.Name = "panelAM";
            this.panelAM.Size = new System.Drawing.Size(54, 71);
            this.panelAM.TabIndex = 1;
            this.panelAM.Click += new System.EventHandler(this.panelAM_Click);
            this.panelAM.MouseLeave += new System.EventHandler(this.panelAM_MouseLeave);
            this.panelAM.MouseHover += new System.EventHandler(this.panelAM_MouseHover);
            // 
            // vacAM3
            // 
            this.vacAM3.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vacAM3.Location = new System.Drawing.Point(3, 49);
            this.vacAM3.Name = "vacAM3";
            this.vacAM3.Size = new System.Drawing.Size(48, 11);
            this.vacAM3.TabIndex = 2;
            // 
            // vacAM2
            // 
            this.vacAM2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vacAM2.Location = new System.Drawing.Point(3, 28);
            this.vacAM2.Name = "vacAM2";
            this.vacAM2.Size = new System.Drawing.Size(48, 11);
            this.vacAM2.TabIndex = 1;
            // 
            // lbAmEvent
            // 
            this.lbAmEvent.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAmEvent.Location = new System.Drawing.Point(3, 7);
            this.lbAmEvent.Name = "lbAmEvent";
            this.lbAmEvent.Size = new System.Drawing.Size(48, 11);
            this.lbAmEvent.TabIndex = 0;
            // 
            // panelPM
            // 
            this.panelPM.BackColor = System.Drawing.Color.White;
            this.panelPM.Controls.Add(this.lbPmEvent);
            this.panelPM.Controls.Add(this.vacPM3);
            this.panelPM.Controls.Add(this.vacPM2);
            this.panelPM.Location = new System.Drawing.Point(93, 10);
            this.panelPM.Name = "panelPM";
            this.panelPM.Size = new System.Drawing.Size(54, 71);
            this.panelPM.TabIndex = 2;
            this.panelPM.Click += new System.EventHandler(this.panelPM_Click);
            this.panelPM.MouseLeave += new System.EventHandler(this.panelPM_MouseLeave);
            this.panelPM.MouseHover += new System.EventHandler(this.panelPM_MouseHover);
            // 
            // lbPmEvent
            // 
            this.lbPmEvent.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPmEvent.Location = new System.Drawing.Point(5, 5);
            this.lbPmEvent.Name = "lbPmEvent";
            this.lbPmEvent.Size = new System.Drawing.Size(48, 11);
            this.lbPmEvent.TabIndex = 3;
            // 
            // vacPM3
            // 
            this.vacPM3.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vacPM3.Location = new System.Drawing.Point(5, 49);
            this.vacPM3.Name = "vacPM3";
            this.vacPM3.Size = new System.Drawing.Size(48, 11);
            this.vacPM3.TabIndex = 3;
            // 
            // vacPM2
            // 
            this.vacPM2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vacPM2.Location = new System.Drawing.Point(5, 28);
            this.vacPM2.Name = "vacPM2";
            this.vacPM2.Size = new System.Drawing.Size(48, 11);
            this.vacPM2.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelPM);
            this.Controls.Add(this.panelAM);
            this.Controls.Add(this.lbdays);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(150, 83);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.panelAM.ResumeLayout(false);
            this.panelPM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.Panel panelAM;
        private System.Windows.Forms.Panel panelPM;
        private System.Windows.Forms.Label lbAmEvent;
        private System.Windows.Forms.Label vacAM3;
        private System.Windows.Forms.Label vacAM2;
        private System.Windows.Forms.Label lbPmEvent;
        private System.Windows.Forms.Label vacPM3;
        private System.Windows.Forms.Label vacPM2;
        private System.Windows.Forms.Timer timer1;
    }
}
