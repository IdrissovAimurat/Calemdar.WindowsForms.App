namespace Calemdar.WindowsForms.App
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelEvent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDays.Location = new System.Drawing.Point(3, 0);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(34, 28);
            this.labelDays.TabIndex = 0;
            this.labelDays.Text = "00";
            // 
            // labelEvent
            // 
            this.labelEvent.Location = new System.Drawing.Point(3, 28);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(155, 53);
            this.labelEvent.TabIndex = 1;
            this.labelEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEvent.Click += new System.EventHandler(this.labelEvent_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.labelDays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(161, 81);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Timer timer1;
    }
}
