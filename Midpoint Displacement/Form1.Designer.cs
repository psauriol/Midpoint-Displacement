namespace Midpoint_Displacement
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowlinesCheckbox = new System.Windows.Forms.CheckBox();
            this.ShowFillCheckbox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(998, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Debug1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Debug2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1070, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(911, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of generations";
            // 
            // ShowlinesCheckbox
            // 
            this.ShowlinesCheckbox.AutoSize = true;
            this.ShowlinesCheckbox.Location = new System.Drawing.Point(998, 51);
            this.ShowlinesCheckbox.Name = "ShowlinesCheckbox";
            this.ShowlinesCheckbox.Size = new System.Drawing.Size(172, 21);
            this.ShowlinesCheckbox.TabIndex = 5;
            this.ShowlinesCheckbox.Text = "Show Calculated Lines";
            this.ShowlinesCheckbox.UseVisualStyleBackColor = true;
            // 
            // ShowFillCheckbox
            // 
            this.ShowFillCheckbox.AutoSize = true;
            this.ShowFillCheckbox.Checked = true;
            this.ShowFillCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowFillCheckbox.Location = new System.Drawing.Point(998, 78);
            this.ShowFillCheckbox.Name = "ShowFillCheckbox";
            this.ShowFillCheckbox.Size = new System.Drawing.Size(85, 21);
            this.ShowFillCheckbox.TabIndex = 6;
            this.ShowFillCheckbox.Text = "Show Fill";
            this.ShowFillCheckbox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1113, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Erase";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ShowFillCheckbox);
            this.Controls.Add(this.ShowlinesCheckbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Displacement test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ShowlinesCheckbox;
        private System.Windows.Forms.CheckBox ShowFillCheckbox;
        private System.Windows.Forms.Button button2;
    }
}

