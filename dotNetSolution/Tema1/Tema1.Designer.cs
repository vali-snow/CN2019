namespace Tema1
{
    partial class Tema1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.lblMachinePrecision = new System.Windows.Forms.Label();
            this.btnCalculate1 = new System.Windows.Forms.Button();
            this.txtMachinePrecision = new System.Windows.Forms.TextBox();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.grdMultiplication = new System.Windows.Forms.GroupBox();
            this.btnCheckMultiplication = new System.Windows.Forms.Button();
            this.lblXM = new System.Windows.Forms.Label();
            this.txtZM = new System.Windows.Forms.TextBox();
            this.txtYM = new System.Windows.Forms.TextBox();
            this.txtXM = new System.Windows.Forms.TextBox();
            this.lblYM = new System.Windows.Forms.Label();
            this.lblZM = new System.Windows.Forms.Label();
            this.grbAddition = new System.Windows.Forms.GroupBox();
            this.btnCheckAdditivity = new System.Windows.Forms.Button();
            this.lblXA = new System.Windows.Forms.Label();
            this.txtZA = new System.Windows.Forms.TextBox();
            this.txtYA = new System.Windows.Forms.TextBox();
            this.txtXA = new System.Windows.Forms.TextBox();
            this.lblYA = new System.Windows.Forms.Label();
            this.lblZA = new System.Windows.Forms.Label();
            this.grb3 = new System.Windows.Forms.GroupBox();
            this.grbHier = new System.Windows.Forms.GroupBox();
            this.lblBestApprox = new System.Windows.Forms.Label();
            this.txtBestApprox = new System.Windows.Forms.TextBox();
            this.txtCalcWithP6 = new System.Windows.Forms.TextBox();
            this.txtCalcWithP5 = new System.Windows.Forms.TextBox();
            this.txtCalcWithP4 = new System.Windows.Forms.TextBox();
            this.txtCalcWithP3 = new System.Windows.Forms.TextBox();
            this.txtCalcWithP2 = new System.Windows.Forms.TextBox();
            this.txtCalcWithP1 = new System.Windows.Forms.TextBox();
            this.txtCalcWithMath = new System.Windows.Forms.TextBox();
            this.cbxCalculateSinValueWithP6 = new System.Windows.Forms.CheckBox();
            this.cbxCalculateSinValueWithP5 = new System.Windows.Forms.CheckBox();
            this.cbxCalculateSinValueWithP4 = new System.Windows.Forms.CheckBox();
            this.cbxCalculateSinValueWithP3 = new System.Windows.Forms.CheckBox();
            this.cbxCalculateSinValueWithP2 = new System.Windows.Forms.CheckBox();
            this.cbxCalculateSinValueWithP1 = new System.Windows.Forms.CheckBox();
            this.cbxCalculateSinValueWithMath = new System.Windows.Forms.CheckBox();
            this.cbxGenerateRandom = new System.Windows.Forms.CheckBox();
            this.btnStartSession = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.grdMultiplication.SuspendLayout();
            this.grbAddition.SuspendLayout();
            this.grb3.SuspendLayout();
            this.grbHier.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(338, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tema 1";
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.lblMachinePrecision);
            this.grb1.Controls.Add(this.btnCalculate1);
            this.grb1.Controls.Add(this.txtMachinePrecision);
            this.grb1.Location = new System.Drawing.Point(37, 64);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(333, 92);
            this.grb1.TabIndex = 1;
            this.grb1.TabStop = false;
            this.grb1.Text = "1. Precizia Masina";
            // 
            // lblMachinePrecision
            // 
            this.lblMachinePrecision.AutoSize = true;
            this.lblMachinePrecision.Location = new System.Drawing.Point(19, 28);
            this.lblMachinePrecision.Name = "lblMachinePrecision";
            this.lblMachinePrecision.Size = new System.Drawing.Size(109, 13);
            this.lblMachinePrecision.TabIndex = 2;
            this.lblMachinePrecision.Text = "Precizia Masina in C#";
            // 
            // btnCalculate1
            // 
            this.btnCalculate1.Location = new System.Drawing.Point(22, 53);
            this.btnCalculate1.Name = "btnCalculate1";
            this.btnCalculate1.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate1.TabIndex = 1;
            this.btnCalculate1.Text = "Calculeaza";
            this.btnCalculate1.UseVisualStyleBackColor = true;
            this.btnCalculate1.Click += new System.EventHandler(this.btnCalculate1_Click);
            // 
            // txtMachinePrecision
            // 
            this.txtMachinePrecision.Enabled = false;
            this.txtMachinePrecision.Location = new System.Drawing.Point(147, 25);
            this.txtMachinePrecision.Name = "txtMachinePrecision";
            this.txtMachinePrecision.ReadOnly = true;
            this.txtMachinePrecision.Size = new System.Drawing.Size(161, 20);
            this.txtMachinePrecision.TabIndex = 0;
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.grdMultiplication);
            this.grb2.Controls.Add(this.grbAddition);
            this.grb2.Location = new System.Drawing.Point(37, 162);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(333, 205);
            this.grb2.TabIndex = 2;
            this.grb2.TabStop = false;
            this.grb2.Text = "2. Cazuri unde asociativitatea esueaza";
            // 
            // grdMultiplication
            // 
            this.grdMultiplication.Controls.Add(this.btnCheckMultiplication);
            this.grdMultiplication.Controls.Add(this.lblXM);
            this.grdMultiplication.Controls.Add(this.txtZM);
            this.grdMultiplication.Controls.Add(this.txtYM);
            this.grdMultiplication.Controls.Add(this.txtXM);
            this.grdMultiplication.Controls.Add(this.lblYM);
            this.grdMultiplication.Controls.Add(this.lblZM);
            this.grdMultiplication.Location = new System.Drawing.Point(6, 113);
            this.grdMultiplication.Name = "grdMultiplication";
            this.grdMultiplication.Size = new System.Drawing.Size(305, 76);
            this.grdMultiplication.TabIndex = 1;
            this.grdMultiplication.TabStop = false;
            this.grdMultiplication.Text = "Inmultirea";
            // 
            // btnCheckMultiplication
            // 
            this.btnCheckMultiplication.Location = new System.Drawing.Point(17, 45);
            this.btnCheckMultiplication.Name = "btnCheckMultiplication";
            this.btnCheckMultiplication.Size = new System.Drawing.Size(123, 23);
            this.btnCheckMultiplication.TabIndex = 3;
            this.btnCheckMultiplication.Text = "Verifica Asociativitatea";
            this.btnCheckMultiplication.UseVisualStyleBackColor = true;
            this.btnCheckMultiplication.Click += new System.EventHandler(this.btnCheckMultiplication_Click);
            // 
            // lblXM
            // 
            this.lblXM.AutoSize = true;
            this.lblXM.Location = new System.Drawing.Point(20, 22);
            this.lblXM.Name = "lblXM";
            this.lblXM.Size = new System.Drawing.Size(15, 13);
            this.lblXM.TabIndex = 0;
            this.lblXM.Text = "x:";
            // 
            // txtZM
            // 
            this.txtZM.Location = new System.Drawing.Point(259, 19);
            this.txtZM.Name = "txtZM";
            this.txtZM.Size = new System.Drawing.Size(40, 20);
            this.txtZM.TabIndex = 5;
            this.txtZM.Text = "1E-10";
            // 
            // txtYM
            // 
            this.txtYM.Location = new System.Drawing.Point(186, 19);
            this.txtYM.Name = "txtYM";
            this.txtYM.Size = new System.Drawing.Size(37, 20);
            this.txtYM.TabIndex = 3;
            this.txtYM.Text = "1E-10";
            // 
            // txtXM
            // 
            this.txtXM.Enabled = false;
            this.txtXM.Location = new System.Drawing.Point(38, 19);
            this.txtXM.Name = "txtXM";
            this.txtXM.Size = new System.Drawing.Size(115, 20);
            this.txtXM.TabIndex = 1;
            this.txtXM.Text = "1+1E-15";
            // 
            // lblYM
            // 
            this.lblYM.AutoSize = true;
            this.lblYM.Location = new System.Drawing.Point(168, 22);
            this.lblYM.Name = "lblYM";
            this.lblYM.Size = new System.Drawing.Size(15, 13);
            this.lblYM.TabIndex = 2;
            this.lblYM.Text = "y:";
            // 
            // lblZM
            // 
            this.lblZM.AutoSize = true;
            this.lblZM.Location = new System.Drawing.Point(241, 22);
            this.lblZM.Name = "lblZM";
            this.lblZM.Size = new System.Drawing.Size(15, 13);
            this.lblZM.TabIndex = 4;
            this.lblZM.Text = "z:";
            // 
            // grbAddition
            // 
            this.grbAddition.Controls.Add(this.btnCheckAdditivity);
            this.grbAddition.Controls.Add(this.lblXA);
            this.grbAddition.Controls.Add(this.txtZA);
            this.grbAddition.Controls.Add(this.txtYA);
            this.grbAddition.Controls.Add(this.txtXA);
            this.grbAddition.Controls.Add(this.lblYA);
            this.grbAddition.Controls.Add(this.lblZA);
            this.grbAddition.Location = new System.Drawing.Point(6, 29);
            this.grbAddition.Name = "grbAddition";
            this.grbAddition.Size = new System.Drawing.Size(305, 78);
            this.grbAddition.TabIndex = 0;
            this.grbAddition.TabStop = false;
            this.grbAddition.Text = "Adunarea";
            // 
            // btnCheckAdditivity
            // 
            this.btnCheckAdditivity.Location = new System.Drawing.Point(17, 45);
            this.btnCheckAdditivity.Name = "btnCheckAdditivity";
            this.btnCheckAdditivity.Size = new System.Drawing.Size(123, 23);
            this.btnCheckAdditivity.TabIndex = 3;
            this.btnCheckAdditivity.Text = "Verifica Asociativitatea";
            this.btnCheckAdditivity.UseVisualStyleBackColor = true;
            this.btnCheckAdditivity.Click += new System.EventHandler(this.btnCheckAdditivity_Click);
            // 
            // lblXA
            // 
            this.lblXA.AutoSize = true;
            this.lblXA.Location = new System.Drawing.Point(20, 22);
            this.lblXA.Name = "lblXA";
            this.lblXA.Size = new System.Drawing.Size(15, 13);
            this.lblXA.TabIndex = 0;
            this.lblXA.Text = "x:";
            // 
            // txtZA
            // 
            this.txtZA.Location = new System.Drawing.Point(168, 19);
            this.txtZA.Name = "txtZA";
            this.txtZA.Size = new System.Drawing.Size(40, 20);
            this.txtZA.TabIndex = 5;
            this.txtZA.Text = "1E-16";
            // 
            // txtYA
            // 
            this.txtYA.Location = new System.Drawing.Point(95, 19);
            this.txtYA.Name = "txtYA";
            this.txtYA.Size = new System.Drawing.Size(37, 20);
            this.txtYA.TabIndex = 3;
            this.txtYA.Text = "1E-16";
            // 
            // txtXA
            // 
            this.txtXA.Location = new System.Drawing.Point(38, 19);
            this.txtXA.Name = "txtXA";
            this.txtXA.Size = new System.Drawing.Size(25, 20);
            this.txtXA.TabIndex = 1;
            this.txtXA.Text = "1.0";
            // 
            // lblYA
            // 
            this.lblYA.AutoSize = true;
            this.lblYA.Location = new System.Drawing.Point(77, 22);
            this.lblYA.Name = "lblYA";
            this.lblYA.Size = new System.Drawing.Size(15, 13);
            this.lblYA.TabIndex = 2;
            this.lblYA.Text = "y:";
            // 
            // lblZA
            // 
            this.lblZA.AutoSize = true;
            this.lblZA.Location = new System.Drawing.Point(150, 22);
            this.lblZA.Name = "lblZA";
            this.lblZA.Size = new System.Drawing.Size(15, 13);
            this.lblZA.TabIndex = 4;
            this.lblZA.Text = "z:";
            // 
            // grb3
            // 
            this.grb3.Controls.Add(this.btnClear);
            this.grb3.Controls.Add(this.grbHier);
            this.grb3.Controls.Add(this.txtCalcWithP6);
            this.grb3.Controls.Add(this.txtCalcWithP5);
            this.grb3.Controls.Add(this.txtCalcWithP4);
            this.grb3.Controls.Add(this.btnStartSession);
            this.grb3.Controls.Add(this.txtCalcWithP3);
            this.grb3.Controls.Add(this.txtCalcWithP2);
            this.grb3.Controls.Add(this.txtCalcWithP1);
            this.grb3.Controls.Add(this.txtCalcWithMath);
            this.grb3.Controls.Add(this.cbxCalculateSinValueWithP6);
            this.grb3.Controls.Add(this.cbxCalculateSinValueWithP5);
            this.grb3.Controls.Add(this.cbxCalculateSinValueWithP4);
            this.grb3.Controls.Add(this.cbxCalculateSinValueWithP3);
            this.grb3.Controls.Add(this.cbxCalculateSinValueWithP2);
            this.grb3.Controls.Add(this.cbxCalculateSinValueWithP1);
            this.grb3.Controls.Add(this.cbxCalculateSinValueWithMath);
            this.grb3.Controls.Add(this.cbxGenerateRandom);
            this.grb3.Location = new System.Drawing.Point(376, 64);
            this.grb3.Name = "grb3";
            this.grb3.Size = new System.Drawing.Size(394, 419);
            this.grb3.TabIndex = 3;
            this.grb3.TabStop = false;
            this.grb3.Text = "3. Aproximari polinomiale ale functiei sin";
            // 
            // grbHier
            // 
            this.grbHier.Controls.Add(this.lblTime);
            this.grbHier.Controls.Add(this.txtTime);
            this.grbHier.Controls.Add(this.lblBestApprox);
            this.grbHier.Controls.Add(this.txtBestApprox);
            this.grbHier.Location = new System.Drawing.Point(15, 211);
            this.grbHier.Name = "grbHier";
            this.grbHier.Size = new System.Drawing.Size(370, 106);
            this.grbHier.TabIndex = 17;
            this.grbHier.TabStop = false;
            this.grbHier.Text = "Ierarhii";
            // 
            // lblBestApprox
            // 
            this.lblBestApprox.AutoSize = true;
            this.lblBestApprox.Location = new System.Drawing.Point(9, 21);
            this.lblBestApprox.Name = "lblBestApprox";
            this.lblBestApprox.Size = new System.Drawing.Size(261, 13);
            this.lblBestApprox.TabIndex = 6;
            this.lblBestApprox.Text = "In functie de aproximarea cat mai apropiata a valorilor:";
            // 
            // txtBestApprox
            // 
            this.txtBestApprox.Enabled = false;
            this.txtBestApprox.Location = new System.Drawing.Point(12, 37);
            this.txtBestApprox.Name = "txtBestApprox";
            this.txtBestApprox.Size = new System.Drawing.Size(342, 20);
            this.txtBestApprox.TabIndex = 7;
            // 
            // txtCalcWithP6
            // 
            this.txtCalcWithP6.Location = new System.Drawing.Point(250, 179);
            this.txtCalcWithP6.Name = "txtCalcWithP6";
            this.txtCalcWithP6.Size = new System.Drawing.Size(119, 20);
            this.txtCalcWithP6.TabIndex = 16;
            // 
            // txtCalcWithP5
            // 
            this.txtCalcWithP5.Location = new System.Drawing.Point(250, 156);
            this.txtCalcWithP5.Name = "txtCalcWithP5";
            this.txtCalcWithP5.Size = new System.Drawing.Size(119, 20);
            this.txtCalcWithP5.TabIndex = 15;
            // 
            // txtCalcWithP4
            // 
            this.txtCalcWithP4.Location = new System.Drawing.Point(250, 133);
            this.txtCalcWithP4.Name = "txtCalcWithP4";
            this.txtCalcWithP4.Size = new System.Drawing.Size(119, 20);
            this.txtCalcWithP4.TabIndex = 14;
            // 
            // txtCalcWithP3
            // 
            this.txtCalcWithP3.Location = new System.Drawing.Point(250, 110);
            this.txtCalcWithP3.Name = "txtCalcWithP3";
            this.txtCalcWithP3.Size = new System.Drawing.Size(119, 20);
            this.txtCalcWithP3.TabIndex = 13;
            // 
            // txtCalcWithP2
            // 
            this.txtCalcWithP2.Location = new System.Drawing.Point(250, 87);
            this.txtCalcWithP2.Name = "txtCalcWithP2";
            this.txtCalcWithP2.Size = new System.Drawing.Size(119, 20);
            this.txtCalcWithP2.TabIndex = 12;
            // 
            // txtCalcWithP1
            // 
            this.txtCalcWithP1.Location = new System.Drawing.Point(250, 64);
            this.txtCalcWithP1.Name = "txtCalcWithP1";
            this.txtCalcWithP1.Size = new System.Drawing.Size(119, 20);
            this.txtCalcWithP1.TabIndex = 11;
            // 
            // txtCalcWithMath
            // 
            this.txtCalcWithMath.Location = new System.Drawing.Point(250, 41);
            this.txtCalcWithMath.Name = "txtCalcWithMath";
            this.txtCalcWithMath.Size = new System.Drawing.Size(119, 20);
            this.txtCalcWithMath.TabIndex = 10;
            // 
            // cbxCalculateSinValueWithP6
            // 
            this.cbxCalculateSinValueWithP6.AutoSize = true;
            this.cbxCalculateSinValueWithP6.Location = new System.Drawing.Point(15, 181);
            this.cbxCalculateSinValueWithP6.Name = "cbxCalculateSinValueWithP6";
            this.cbxCalculateSinValueWithP6.Size = new System.Drawing.Size(169, 17);
            this.cbxCalculateSinValueWithP6.TabIndex = 7;
            this.cbxCalculateSinValueWithP6.Text = "Calculeaza valoarea sin cu P6";
            this.cbxCalculateSinValueWithP6.UseVisualStyleBackColor = true;
            // 
            // cbxCalculateSinValueWithP5
            // 
            this.cbxCalculateSinValueWithP5.AutoSize = true;
            this.cbxCalculateSinValueWithP5.Location = new System.Drawing.Point(15, 158);
            this.cbxCalculateSinValueWithP5.Name = "cbxCalculateSinValueWithP5";
            this.cbxCalculateSinValueWithP5.Size = new System.Drawing.Size(169, 17);
            this.cbxCalculateSinValueWithP5.TabIndex = 6;
            this.cbxCalculateSinValueWithP5.Text = "Calculeaza valoarea sin cu P5";
            this.cbxCalculateSinValueWithP5.UseVisualStyleBackColor = true;
            // 
            // cbxCalculateSinValueWithP4
            // 
            this.cbxCalculateSinValueWithP4.AutoSize = true;
            this.cbxCalculateSinValueWithP4.Location = new System.Drawing.Point(15, 135);
            this.cbxCalculateSinValueWithP4.Name = "cbxCalculateSinValueWithP4";
            this.cbxCalculateSinValueWithP4.Size = new System.Drawing.Size(169, 17);
            this.cbxCalculateSinValueWithP4.TabIndex = 5;
            this.cbxCalculateSinValueWithP4.Text = "Calculeaza valoarea sin cu P4";
            this.cbxCalculateSinValueWithP4.UseVisualStyleBackColor = true;
            // 
            // cbxCalculateSinValueWithP3
            // 
            this.cbxCalculateSinValueWithP3.AutoSize = true;
            this.cbxCalculateSinValueWithP3.Location = new System.Drawing.Point(15, 112);
            this.cbxCalculateSinValueWithP3.Name = "cbxCalculateSinValueWithP3";
            this.cbxCalculateSinValueWithP3.Size = new System.Drawing.Size(169, 17);
            this.cbxCalculateSinValueWithP3.TabIndex = 4;
            this.cbxCalculateSinValueWithP3.Text = "Calculeaza valoarea sin cu P3";
            this.cbxCalculateSinValueWithP3.UseVisualStyleBackColor = true;
            // 
            // cbxCalculateSinValueWithP2
            // 
            this.cbxCalculateSinValueWithP2.AutoSize = true;
            this.cbxCalculateSinValueWithP2.Location = new System.Drawing.Point(15, 89);
            this.cbxCalculateSinValueWithP2.Name = "cbxCalculateSinValueWithP2";
            this.cbxCalculateSinValueWithP2.Size = new System.Drawing.Size(169, 17);
            this.cbxCalculateSinValueWithP2.TabIndex = 3;
            this.cbxCalculateSinValueWithP2.Text = "Calculeaza valoarea sin cu P2";
            this.cbxCalculateSinValueWithP2.UseVisualStyleBackColor = true;
            // 
            // cbxCalculateSinValueWithP1
            // 
            this.cbxCalculateSinValueWithP1.AutoSize = true;
            this.cbxCalculateSinValueWithP1.Location = new System.Drawing.Point(15, 66);
            this.cbxCalculateSinValueWithP1.Name = "cbxCalculateSinValueWithP1";
            this.cbxCalculateSinValueWithP1.Size = new System.Drawing.Size(169, 17);
            this.cbxCalculateSinValueWithP1.TabIndex = 2;
            this.cbxCalculateSinValueWithP1.Text = "Calculeaza valoarea sin cu P1";
            this.cbxCalculateSinValueWithP1.UseVisualStyleBackColor = true;
            // 
            // cbxCalculateSinValueWithMath
            // 
            this.cbxCalculateSinValueWithMath.AutoSize = true;
            this.cbxCalculateSinValueWithMath.Location = new System.Drawing.Point(15, 43);
            this.cbxCalculateSinValueWithMath.Name = "cbxCalculateSinValueWithMath";
            this.cbxCalculateSinValueWithMath.Size = new System.Drawing.Size(217, 17);
            this.cbxCalculateSinValueWithMath.TabIndex = 1;
            this.cbxCalculateSinValueWithMath.Text = "Calculeaza valoarea exacta cu Math.Sin";
            this.cbxCalculateSinValueWithMath.UseVisualStyleBackColor = true;
            // 
            // cbxGenerateRandom
            // 
            this.cbxGenerateRandom.AutoSize = true;
            this.cbxGenerateRandom.Location = new System.Drawing.Point(15, 19);
            this.cbxGenerateRandom.Name = "cbxGenerateRandom";
            this.cbxGenerateRandom.Size = new System.Drawing.Size(167, 17);
            this.cbxGenerateRandom.TabIndex = 0;
            this.cbxGenerateRandom.Text = "Genereaza 100000 nr random";
            this.cbxGenerateRandom.UseVisualStyleBackColor = true;
            // 
            // btnStartSession
            // 
            this.btnStartSession.Location = new System.Drawing.Point(15, 323);
            this.btnStartSession.Name = "btnStartSession";
            this.btnStartSession.Size = new System.Drawing.Size(116, 23);
            this.btnStartSession.TabIndex = 8;
            this.btnStartSession.Text = "Porneste Sesiunea";
            this.btnStartSession.UseVisualStyleBackColor = true;
            this.btnStartSession.Click += new System.EventHandler(this.btnStartSession_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(9, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(211, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "In functie de timpul de calcul cat mai redus:";
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(12, 76);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(342, 20);
            this.txtTime.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(137, 323);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Curata Rezultatele";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Tema1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 544);
            this.Controls.Add(this.grb3);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Tema1";
            this.Text = "Form1";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grb2.ResumeLayout(false);
            this.grdMultiplication.ResumeLayout(false);
            this.grdMultiplication.PerformLayout();
            this.grbAddition.ResumeLayout(false);
            this.grbAddition.PerformLayout();
            this.grb3.ResumeLayout(false);
            this.grb3.PerformLayout();
            this.grbHier.ResumeLayout(false);
            this.grbHier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Label lblMachinePrecision;
        private System.Windows.Forms.Button btnCalculate1;
        private System.Windows.Forms.TextBox txtMachinePrecision;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.GroupBox grb3;
        private System.Windows.Forms.GroupBox grbAddition;
        private System.Windows.Forms.TextBox txtZA;
        private System.Windows.Forms.Label lblZA;
        private System.Windows.Forms.TextBox txtYA;
        private System.Windows.Forms.Label lblYA;
        private System.Windows.Forms.TextBox txtXA;
        private System.Windows.Forms.Label lblXA;
        private System.Windows.Forms.Button btnCheckAdditivity;
        private System.Windows.Forms.GroupBox grdMultiplication;
        private System.Windows.Forms.Button btnCheckMultiplication;
        private System.Windows.Forms.Label lblXM;
        private System.Windows.Forms.TextBox txtZM;
        private System.Windows.Forms.TextBox txtYM;
        private System.Windows.Forms.TextBox txtXM;
        private System.Windows.Forms.Label lblYM;
        private System.Windows.Forms.Label lblZM;
        private System.Windows.Forms.CheckBox cbxCalculateSinValueWithMath;
        private System.Windows.Forms.CheckBox cbxGenerateRandom;
        private System.Windows.Forms.Button btnStartSession;
        private System.Windows.Forms.CheckBox cbxCalculateSinValueWithP6;
        private System.Windows.Forms.CheckBox cbxCalculateSinValueWithP5;
        private System.Windows.Forms.CheckBox cbxCalculateSinValueWithP4;
        private System.Windows.Forms.CheckBox cbxCalculateSinValueWithP3;
        private System.Windows.Forms.CheckBox cbxCalculateSinValueWithP2;
        private System.Windows.Forms.CheckBox cbxCalculateSinValueWithP1;
        private System.Windows.Forms.TextBox txtCalcWithP6;
        private System.Windows.Forms.TextBox txtCalcWithP5;
        private System.Windows.Forms.TextBox txtCalcWithP4;
        private System.Windows.Forms.TextBox txtCalcWithP3;
        private System.Windows.Forms.TextBox txtCalcWithP2;
        private System.Windows.Forms.TextBox txtCalcWithP1;
        private System.Windows.Forms.TextBox txtCalcWithMath;
        private System.Windows.Forms.GroupBox grbHier;
        private System.Windows.Forms.Label lblBestApprox;
        private System.Windows.Forms.TextBox txtBestApprox;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnClear;
    }
}

