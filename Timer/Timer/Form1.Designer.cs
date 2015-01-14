namespace Timer
{
    partial class FormTimer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textSetTime = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textRemainingTime = new System.Windows.Forms.TextBox();
            this.timerControl = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "時間設定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "秒";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "残り時間";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "秒";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textSetTime
            // 
            this.textSetTime.Location = new System.Drawing.Point(79, 40);
            this.textSetTime.Name = "textSetTime";
            this.textSetTime.Size = new System.Drawing.Size(100, 19);
            this.textSetTime.TabIndex = 4;
            this.textSetTime.Text = "10";
            this.textSetTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 65);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(190, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "スタート！(Without any Pushes)";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textRemainingTime
            // 
            this.textRemainingTime.Location = new System.Drawing.Point(79, 185);
            this.textRemainingTime.Name = "textRemainingTime";
            this.textRemainingTime.Size = new System.Drawing.Size(100, 19);
            this.textRemainingTime.TabIndex = 6;
            this.textRemainingTime.Text = "10";
            this.textRemainingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timerControl
            // 
            this.timerControl.Interval = 1000;
            this.timerControl.Tick += new System.EventHandler(this.timerControl_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Config";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "スタート！(Push when timer stops)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "スタート！(Push when timer is 5min)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 216);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textRemainingTime);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textSetTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTimer";
            this.Text = "タイマー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSetTime;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textRemainingTime;
        private System.Windows.Forms.Timer timerControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

