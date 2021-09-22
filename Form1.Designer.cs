namespace MoveGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BorderBar = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Exit_Label = new System.Windows.Forms.Label();
            this.Data_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.spawn = new System.Windows.Forms.Timer(this.components);
            this.BorderBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderBar
            // 
            this.BorderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BorderBar.Controls.Add(this.Title_Label);
            this.BorderBar.Controls.Add(this.Exit_Label);
            this.BorderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderBar.Font = new System.Drawing.Font("Bahnschrift", 10.25F);
            this.BorderBar.Location = new System.Drawing.Point(0, 0);
            this.BorderBar.Name = "BorderBar";
            this.BorderBar.Size = new System.Drawing.Size(1121, 26);
            this.BorderBar.TabIndex = 1;
            this.BorderBar.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderBar_Paint);
            this.BorderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderBar_MouseDown);
            this.BorderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorderBar_MouseMove);
            this.BorderBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BorderBar_MouseUp);
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Location = new System.Drawing.Point(3, 3);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(43, 17);
            this.Title_Label.TabIndex = 1;
            this.Title_Label.Text = "To Go";
            // 
            // Exit_Label
            // 
            this.Exit_Label.AutoSize = true;
            this.Exit_Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Exit_Label.Location = new System.Drawing.Point(1105, 0);
            this.Exit_Label.Name = "Exit_Label";
            this.Exit_Label.Size = new System.Drawing.Size(16, 17);
            this.Exit_Label.TabIndex = 0;
            this.Exit_Label.Text = "X";
            this.Exit_Label.Click += new System.EventHandler(this.Exit_Label_Click);
            // 
            // Data_Panel
            // 
            this.Data_Panel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.Data_Panel.Location = new System.Drawing.Point(0, 20);
            this.Data_Panel.Name = "Data_Panel";
            this.Data_Panel.Size = new System.Drawing.Size(1121, 813);
            this.Data_Panel.TabIndex = 2;
            this.Data_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Data_Panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acceleration";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 832);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 68);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Magazine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Location = new System.Drawing.Point(1080, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Set";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // spawn
            // 
            this.spawn.Interval = 1000;
            this.spawn.Tick += new System.EventHandler(this.spawn_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1121, 900);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Data_Panel);
            this.Controls.Add(this.BorderBar);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Move_Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.BorderBar.ResumeLayout(false);
            this.BorderBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BorderBar;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Label Exit_Label;
        private System.Windows.Forms.Panel Data_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer spawn;
    }
}

