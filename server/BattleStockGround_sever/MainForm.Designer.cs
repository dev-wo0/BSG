﻿namespace BattleStockGround_sever
{
     partial class MainForm
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
               this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
               this.listBox1 = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // listBox1
               // 
               this.listBox1.FormattingEnabled = true;
               this.listBox1.ItemHeight = 12;
               this.listBox1.Location = new System.Drawing.Point(0, 38);
               this.listBox1.Name = "listBox1";
               this.listBox1.Size = new System.Drawing.Size(255, 364);
               this.listBox1.TabIndex = 22;
               // 
               // MainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(311, 416);
               this.Controls.Add(this.listBox1);
               this.Name = "MainForm";
               this.Text = "Form1";
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
               this.ResumeLayout(false);

          }

          #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

