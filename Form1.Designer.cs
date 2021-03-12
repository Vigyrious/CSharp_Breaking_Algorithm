
namespace NewTryCombAlg
{
    partial class BreakingAlgorithm
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
            this.TargetN = new System.Windows.Forms.TextBox();
            this.AllowedNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 428);
            this.button1.TabIndex = 0;
            this.button1.Text = "Разбий";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button);
            // 
            // TargetN
            // 
            this.TargetN.Location = new System.Drawing.Point(591, 47);
            this.TargetN.Multiline = true;
            this.TargetN.Name = "TargetN";
            this.TargetN.Size = new System.Drawing.Size(97, 192);
            this.TargetN.TabIndex = 1;
           // this.TargetN.TextChanged += new System.EventHandler(this.TargetNumber);
            // 
            // AllowedNum
            // 
            this.AllowedNum.Location = new System.Drawing.Point(591, 258);
            this.AllowedNum.Multiline = true;
            this.AllowedNum.Name = "AllowedNum";
            this.AllowedNum.Size = new System.Drawing.Size(97, 180);
            this.AllowedNum.TabIndex = 2;
            //this.AllowedNum.TextChanged += new System.EventHandler(this.AllowedNumber);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Въведете n";
            //this.label1.Click += new System.EventHandler(this.LabelTarget);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Въведете числата, които да се използват в изчислението";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(315, 426);
            this.textBox1.TabIndex = 5;
            //this.textBox1.TextChanged += new System.EventHandler(this.AlgorithmShowcase);
            // 
            // BreakingAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllowedNum);
            this.Controls.Add(this.TargetN);
            this.Controls.Add(this.button1);
            this.Name = "BreakingAlgorithm";
            this.Text = "Algorithm";
            //this.Load += new System.EventHandler(this.Razbivane_Algo);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TargetN;
        private System.Windows.Forms.TextBox AllowedNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

