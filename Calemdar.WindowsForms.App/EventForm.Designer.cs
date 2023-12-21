namespace Calemdar.WindowsForms.App
{
    partial class EventForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEvent = new CodeeloUI.Controls.CodeeloTextBox();
            this.txtDate = new CodeeloUI.Controls.CodeeloTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата";
            // 
            // txtEvent
            // 
            this.txtEvent.BackColor = System.Drawing.Color.White;
            this.txtEvent.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtEvent.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.txtEvent.BorderSize = 2;
            this.txtEvent.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEvent.Location = new System.Drawing.Point(89, 146);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(4);
            this.txtEvent.Multiline = false;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Padding = new System.Windows.Forms.Padding(7);
            this.txtEvent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEvent.PlaceholderText = "";
            this.txtEvent.Size = new System.Drawing.Size(302, 43);
            this.txtEvent.TabIndex = 4;
            this.txtEvent.UnderlinedStyle = false;
            this.txtEvent.UsePasswordChar = false;
            this.txtEvent.TextWasChanged += new System.EventHandler(this.codeeloTextBox2_TextWasChanged);
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txtDate.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.txtDate.BorderSize = 2;
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDate.Location = new System.Drawing.Point(89, 49);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Multiline = false;
            this.txtDate.Name = "txtDate";
            this.txtDate.Padding = new System.Windows.Forms.Padding(7);
            this.txtDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDate.PlaceholderText = "";
            this.txtDate.Size = new System.Drawing.Size(302, 43);
            this.txtDate.TabIndex = 5;
            this.txtDate.UnderlinedStyle = false;
            this.txtDate.UsePasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Событие";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(301, 212);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 257);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.label1);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить событие";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CodeeloUI.Controls.CodeeloTextBox txtEvent;
        private CodeeloUI.Controls.CodeeloTextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
    }
}