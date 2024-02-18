namespace Bosov_Gen
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextY = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1_Click
            // 
            this.button1_Click.Location = new System.Drawing.Point(21, 425);
            this.button1_Click.Name = "button1_Click";
            this.button1_Click.Size = new System.Drawing.Size(283, 23);
            this.button1_Click.TabIndex = 0;
            this.button1_Click.TabStop = false;
            this.button1_Click.Text = "Сгенерировать";
            this.button1_Click.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1_Click.UseVisualStyleBackColor = true;
            this.button1_Click.Click += new System.EventHandler(this.button1_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Y=(A*Y*Y+B*Y+C)\\modM";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TextY
            // 
            this.TextY.Location = new System.Drawing.Point(309, 94);
            this.TextY.Name = "TextY";
            this.TextY.Size = new System.Drawing.Size(149, 23);
            this.TextY.TabIndex = 4;
            this.TextY.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 259);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TextY);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1_Click;
        private Label label1;
        private Button button1;
        private TextBox TextY;
        private ListBox listBox1;
    }
}