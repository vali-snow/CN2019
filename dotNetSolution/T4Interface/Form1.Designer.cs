namespace T4Interface
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
            this.matrix1 = new System.Windows.Forms.GroupBox();
            this.matrix2 = new System.Windows.Forms.GroupBox();
            this.matrix3 = new System.Windows.Forms.GroupBox();
            this.matrix4 = new System.Windows.Forms.GroupBox();
            this.matrix5 = new System.Windows.Forms.GroupBox();
            this.controlPanel = new System.Windows.Forms.GroupBox();
            this.m1Btn = new System.Windows.Forms.Button();
            this.m2Btn = new System.Windows.Forms.Button();
            this.m3Btn = new System.Windows.Forms.Button();
            this.m4Btn = new System.Windows.Forms.Button();
            this.m5Btn = new System.Windows.Forms.Button();
            this.m1Check = new System.Windows.Forms.CheckBox();
            this.m2Check = new System.Windows.Forms.CheckBox();
            this.m3Check = new System.Windows.Forms.CheckBox();
            this.m4Check = new System.Windows.Forms.CheckBox();
            this.m5Check = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.matrix1.SuspendLayout();
            this.matrix2.SuspendLayout();
            this.matrix3.SuspendLayout();
            this.matrix4.SuspendLayout();
            this.matrix5.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // matrix1
            // 
            this.matrix1.Controls.Add(this.label1);
            this.matrix1.Controls.Add(this.textBox1);
            this.matrix1.Controls.Add(this.m1Check);
            this.matrix1.Controls.Add(this.m1Btn);
            this.matrix1.Location = new System.Drawing.Point(10, 19);
            this.matrix1.Name = "matrix1";
            this.matrix1.Size = new System.Drawing.Size(606, 54);
            this.matrix1.TabIndex = 0;
            this.matrix1.TabStop = false;
            this.matrix1.Text = "Matrix1";
            // 
            // matrix2
            // 
            this.matrix2.Controls.Add(this.label2);
            this.matrix2.Controls.Add(this.textBox2);
            this.matrix2.Controls.Add(this.m2Check);
            this.matrix2.Controls.Add(this.m2Btn);
            this.matrix2.Location = new System.Drawing.Point(10, 84);
            this.matrix2.Name = "matrix2";
            this.matrix2.Size = new System.Drawing.Size(606, 54);
            this.matrix2.TabIndex = 1;
            this.matrix2.TabStop = false;
            this.matrix2.Text = "Matrix 2";
            // 
            // matrix3
            // 
            this.matrix3.Controls.Add(this.label3);
            this.matrix3.Controls.Add(this.textBox3);
            this.matrix3.Controls.Add(this.m3Check);
            this.matrix3.Controls.Add(this.m3Btn);
            this.matrix3.Location = new System.Drawing.Point(10, 144);
            this.matrix3.Name = "matrix3";
            this.matrix3.Size = new System.Drawing.Size(606, 54);
            this.matrix3.TabIndex = 1;
            this.matrix3.TabStop = false;
            this.matrix3.Text = "Matrix 3";
            // 
            // matrix4
            // 
            this.matrix4.Controls.Add(this.label4);
            this.matrix4.Controls.Add(this.textBox4);
            this.matrix4.Controls.Add(this.m4Check);
            this.matrix4.Controls.Add(this.m4Btn);
            this.matrix4.Location = new System.Drawing.Point(10, 204);
            this.matrix4.Name = "matrix4";
            this.matrix4.Size = new System.Drawing.Size(606, 54);
            this.matrix4.TabIndex = 1;
            this.matrix4.TabStop = false;
            this.matrix4.Text = "Matrix 4";
            // 
            // matrix5
            // 
            this.matrix5.Controls.Add(this.label5);
            this.matrix5.Controls.Add(this.textBox5);
            this.matrix5.Controls.Add(this.m5Check);
            this.matrix5.Controls.Add(this.m5Btn);
            this.matrix5.Location = new System.Drawing.Point(10, 264);
            this.matrix5.Name = "matrix5";
            this.matrix5.Size = new System.Drawing.Size(606, 54);
            this.matrix5.TabIndex = 1;
            this.matrix5.TabStop = false;
            this.matrix5.Text = "Matrix 5";
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.matrix3);
            this.controlPanel.Controls.Add(this.matrix4);
            this.controlPanel.Controls.Add(this.matrix5);
            this.controlPanel.Controls.Add(this.matrix2);
            this.controlPanel.Controls.Add(this.matrix1);
            this.controlPanel.Location = new System.Drawing.Point(71, 59);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(628, 324);
            this.controlPanel.TabIndex = 2;
            this.controlPanel.TabStop = false;
            this.controlPanel.Text = "ControlPanel";
            this.controlPanel.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // m1Btn
            // 
            this.m1Btn.Location = new System.Drawing.Point(29, 21);
            this.m1Btn.Name = "m1Btn";
            this.m1Btn.Size = new System.Drawing.Size(108, 22);
            this.m1Btn.TabIndex = 0;
            this.m1Btn.Text = "Calculate";
            this.m1Btn.UseVisualStyleBackColor = true;
            this.m1Btn.Click += new System.EventHandler(this.m1Btn_Click);
            // 
            // m2Btn
            // 
            this.m2Btn.Location = new System.Drawing.Point(29, 19);
            this.m2Btn.Name = "m2Btn";
            this.m2Btn.Size = new System.Drawing.Size(108, 22);
            this.m2Btn.TabIndex = 1;
            this.m2Btn.Text = "Calculate";
            this.m2Btn.UseVisualStyleBackColor = true;
            this.m2Btn.Click += new System.EventHandler(this.m2Btn_Click);
            // 
            // m3Btn
            // 
            this.m3Btn.Location = new System.Drawing.Point(29, 19);
            this.m3Btn.Name = "m3Btn";
            this.m3Btn.Size = new System.Drawing.Size(108, 22);
            this.m3Btn.TabIndex = 1;
            this.m3Btn.Text = "Calculate";
            this.m3Btn.UseVisualStyleBackColor = true;
            this.m3Btn.Click += new System.EventHandler(this.m3Btn_Click);
            // 
            // m4Btn
            // 
            this.m4Btn.Location = new System.Drawing.Point(29, 19);
            this.m4Btn.Name = "m4Btn";
            this.m4Btn.Size = new System.Drawing.Size(108, 22);
            this.m4Btn.TabIndex = 1;
            this.m4Btn.Text = "Calculate";
            this.m4Btn.UseVisualStyleBackColor = true;
            this.m4Btn.Click += new System.EventHandler(this.m4Btn_Click);
            // 
            // m5Btn
            // 
            this.m5Btn.Location = new System.Drawing.Point(29, 19);
            this.m5Btn.Name = "m5Btn";
            this.m5Btn.Size = new System.Drawing.Size(108, 22);
            this.m5Btn.TabIndex = 1;
            this.m5Btn.Text = "Calculate";
            this.m5Btn.UseVisualStyleBackColor = true;
            this.m5Btn.Click += new System.EventHandler(this.m5Btn_Click);
            // 
            // m1Check
            // 
            this.m1Check.AutoSize = true;
            this.m1Check.Location = new System.Drawing.Point(263, 21);
            this.m1Check.Name = "m1Check";
            this.m1Check.Size = new System.Drawing.Size(97, 17);
            this.m1Check.TabIndex = 1;
            this.m1Check.Text = "Solution Found";
            this.m1Check.UseVisualStyleBackColor = true;
            // 
            // m2Check
            // 
            this.m2Check.AutoSize = true;
            this.m2Check.Location = new System.Drawing.Point(263, 19);
            this.m2Check.Name = "m2Check";
            this.m2Check.Size = new System.Drawing.Size(97, 17);
            this.m2Check.TabIndex = 2;
            this.m2Check.Text = "Solution Found";
            this.m2Check.UseVisualStyleBackColor = true;
            this.m2Check.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // m3Check
            // 
            this.m3Check.AutoSize = true;
            this.m3Check.Location = new System.Drawing.Point(263, 19);
            this.m3Check.Name = "m3Check";
            this.m3Check.Size = new System.Drawing.Size(97, 17);
            this.m3Check.TabIndex = 2;
            this.m3Check.Text = "Solution Found";
            this.m3Check.UseVisualStyleBackColor = true;
            // 
            // m4Check
            // 
            this.m4Check.AutoSize = true;
            this.m4Check.Location = new System.Drawing.Point(263, 19);
            this.m4Check.Name = "m4Check";
            this.m4Check.Size = new System.Drawing.Size(97, 17);
            this.m4Check.TabIndex = 2;
            this.m4Check.Text = "Solution Found";
            this.m4Check.UseVisualStyleBackColor = true;
            // 
            // m5Check
            // 
            this.m5Check.AutoSize = true;
            this.m5Check.Location = new System.Drawing.Point(263, 19);
            this.m5Check.Name = "m5Check";
            this.m5Check.Size = new System.Drawing.Size(97, 17);
            this.m5Check.TabIndex = 2;
            this.m5Check.Text = "Solution Found";
            this.m5Check.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(455, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(455, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(455, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(455, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Norma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Norma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Norma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Norma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Norma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 527);
            this.Controls.Add(this.controlPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.matrix1.ResumeLayout(false);
            this.matrix1.PerformLayout();
            this.matrix2.ResumeLayout(false);
            this.matrix2.PerformLayout();
            this.matrix3.ResumeLayout(false);
            this.matrix3.PerformLayout();
            this.matrix4.ResumeLayout(false);
            this.matrix4.PerformLayout();
            this.matrix5.ResumeLayout(false);
            this.matrix5.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox matrix1;
        private System.Windows.Forms.GroupBox matrix2;
        private System.Windows.Forms.GroupBox matrix3;
        private System.Windows.Forms.GroupBox matrix4;
        private System.Windows.Forms.GroupBox matrix5;
        private System.Windows.Forms.GroupBox controlPanel;
        private System.Windows.Forms.Button m1Btn;
        private System.Windows.Forms.Button m2Btn;
        private System.Windows.Forms.Button m3Btn;
        private System.Windows.Forms.Button m4Btn;
        private System.Windows.Forms.Button m5Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox m1Check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox m2Check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox m3Check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox m4Check;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox m5Check;
    }
}

