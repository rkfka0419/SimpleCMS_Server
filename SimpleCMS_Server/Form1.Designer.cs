namespace SimpleCMS_Server
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
            this.Btn_Record = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Btn_DeleteDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Record
            // 
            this.Btn_Record.Location = new System.Drawing.Point(231, 49);
            this.Btn_Record.Name = "Btn_Record";
            this.Btn_Record.Size = new System.Drawing.Size(311, 87);
            this.Btn_Record.TabIndex = 0;
            this.Btn_Record.Text = "Record";
            this.Btn_Record.UseVisualStyleBackColor = true;
            this.Btn_Record.Click += new System.EventHandler(this.Btn_Record_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Location = new System.Drawing.Point(231, 175);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(311, 87);
            this.Btn_Stop.TabIndex = 1;
            this.Btn_Stop.Text = "Stop";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_DeleteDB
            // 
            this.Btn_DeleteDB.Location = new System.Drawing.Point(231, 311);
            this.Btn_DeleteDB.Name = "Btn_DeleteDB";
            this.Btn_DeleteDB.Size = new System.Drawing.Size(311, 87);
            this.Btn_DeleteDB.TabIndex = 2;
            this.Btn_DeleteDB.Text = "DeleteDB";
            this.Btn_DeleteDB.UseVisualStyleBackColor = true;
            this.Btn_DeleteDB.Click += new System.EventHandler(this.Btn_DeleteDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_DeleteDB);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Record);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Record;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Button Btn_DeleteDB;
    }
}

