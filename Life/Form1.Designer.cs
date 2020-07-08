namespace Life
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.step1 = new System.Windows.Forms.Button();
            this.step2 = new System.Windows.Forms.Button();
            this.step12 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 522);
            this.panel1.TabIndex = 0;
            // 
            // step1
            // 
            this.step1.Location = new System.Drawing.Point(12, 540);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(75, 23);
            this.step1.TabIndex = 1;
            this.step1.Text = "Step1";
            this.step1.UseVisualStyleBackColor = true;
            this.step1.Click += new System.EventHandler(this.step1_Click);
            // 
            // step2
            // 
            this.step2.Location = new System.Drawing.Point(93, 540);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(75, 23);
            this.step2.TabIndex = 2;
            this.step2.Text = "Step 2";
            this.step2.UseVisualStyleBackColor = true;
            this.step2.Click += new System.EventHandler(this.step2_Click);
            // 
            // step12
            // 
            this.step12.Location = new System.Drawing.Point(174, 540);
            this.step12.Name = "step12";
            this.step12.Size = new System.Drawing.Size(75, 23);
            this.step12.TabIndex = 3;
            this.step12.Text = "Step 1-2";
            this.step12.UseVisualStyleBackColor = true;
            this.step12.Click += new System.EventHandler(this.step12_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerControl
            // 
            this.timerControl.Location = new System.Drawing.Point(255, 540);
            this.timerControl.Name = "timerControl";
            this.timerControl.Size = new System.Drawing.Size(75, 23);
            this.timerControl.TabIndex = 4;
            this.timerControl.Text = "Start / Stop";
            this.timerControl.UseVisualStyleBackColor = true;
            this.timerControl.Click += new System.EventHandler(this.timerControl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 574);
            this.Controls.Add(this.timerControl);
            this.Controls.Add(this.step12);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Life";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button step1;
        private System.Windows.Forms.Button step2;
        private System.Windows.Forms.Button step12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button timerControl;
    }
}

