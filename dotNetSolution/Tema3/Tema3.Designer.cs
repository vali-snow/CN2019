namespace Tema3
{
    partial class Tema3
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
            this.clbInitialization = new System.Windows.Forms.CheckedListBox();
            this.lblInitialization = new System.Windows.Forms.Label();
            this.lvlStepsCompleted = new System.Windows.Forms.Label();
            this.clbStepsCompleted = new System.Windows.Forms.CheckedListBox();
            this.btnStartCS = new System.Windows.Forms.Button();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.lblMatrixA12 = new System.Windows.Forms.Label();
            this.lblMatrixB12 = new System.Windows.Forms.Label();
            this.lblMatrixAplusB24 = new System.Windows.Forms.Label();
            this.lblAplusBCorrect = new System.Windows.Forms.Label();
            this.lblAOriBCorrect = new System.Windows.Forms.Label();
            this.lblAxCorrect = new System.Windows.Forms.Label();
            this.lblBxCorrect = new System.Windows.Forms.Label();
            this.lblAPlusBxCorrect = new System.Windows.Forms.Label();
            this.lblAOriBxCorrect = new System.Windows.Forms.Label();
            this.txtMatrixA12 = new System.Windows.Forms.TextBox();
            this.txtMatrixB12 = new System.Windows.Forms.TextBox();
            this.txtMatrixAplusB24 = new System.Windows.Forms.TextBox();
            this.txtAplusBCorrect = new System.Windows.Forms.TextBox();
            this.txtAOriBCorrect = new System.Windows.Forms.TextBox();
            this.txtAxCorrect = new System.Windows.Forms.TextBox();
            this.txtBxCorrect = new System.Windows.Forms.TextBox();
            this.txtAPlusBxCorrect = new System.Windows.Forms.TextBox();
            this.txtAOriBxCorrect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clbInitialization
            // 
            this.clbInitialization.FormattingEnabled = true;
            this.clbInitialization.Items.AddRange(new object[] {
            "read size from a.txt",
            "read matrix from a.txt",
            "read vector from a.txt",
            "read size from b.txt",
            "read matrix from b.txt",
            "read vector from b.txt",
            "read size from aplusb.txt",
            "read matrix from aplusb.txt",
            "read vector from aplusb.txt",
            "read size from aorib.txt",
            "read matrix from aorib.txt",
            "read vector from aorib.txt"});
            this.clbInitialization.Location = new System.Drawing.Point(18, 32);
            this.clbInitialization.Name = "clbInitialization";
            this.clbInitialization.Size = new System.Drawing.Size(196, 184);
            this.clbInitialization.TabIndex = 0;
            // 
            // lblInitialization
            // 
            this.lblInitialization.AutoSize = true;
            this.lblInitialization.Location = new System.Drawing.Point(15, 16);
            this.lblInitialization.Name = "lblInitialization";
            this.lblInitialization.Size = new System.Drawing.Size(61, 13);
            this.lblInitialization.TabIndex = 1;
            this.lblInitialization.Text = "Initialization";
            // 
            // lvlStepsCompleted
            // 
            this.lvlStepsCompleted.AutoSize = true;
            this.lvlStepsCompleted.Location = new System.Drawing.Point(237, 16);
            this.lvlStepsCompleted.Name = "lvlStepsCompleted";
            this.lvlStepsCompleted.Size = new System.Drawing.Size(87, 13);
            this.lvlStepsCompleted.TabIndex = 2;
            this.lvlStepsCompleted.Text = "Steps Completed";
            // 
            // clbStepsCompleted
            // 
            this.clbStepsCompleted.FormattingEnabled = true;
            this.clbStepsCompleted.Items.AddRange(new object[] {
            "read data from text files",
            "check that Matrix A has at most 12 not null elements on a row",
            "check that Matrix B has at most 12 not null elements on a row",
            "calculate Matrix A + B",
            "check that Matrix A + B has at most 24 not null elements on a row",
            "check that Matrix A + B is the same as Matrix APlusB",
            "calculate Matrix A * B",
            "check that Matrix A * B is the same as Matrix AOriB",
            "check that Matrix A * (2019,2018,..,1) = Vector A",
            "check that Matrix B * (2019,2018,..,1) = Vector B",
            "check that Matrix APlusB * (2019,2018,..,1) = Vector APlusB",
            "check that Matrix AOriB * (2019,2018,..,1) = Vector AOriB"});
            this.clbStepsCompleted.Location = new System.Drawing.Point(240, 32);
            this.clbStepsCompleted.Name = "clbStepsCompleted";
            this.clbStepsCompleted.Size = new System.Drawing.Size(467, 184);
            this.clbStepsCompleted.TabIndex = 3;
            // 
            // btnStartCS
            // 
            this.btnStartCS.Location = new System.Drawing.Point(738, 235);
            this.btnStartCS.Name = "btnStartCS";
            this.btnStartCS.Size = new System.Drawing.Size(143, 23);
            this.btnStartCS.TabIndex = 4;
            this.btnStartCS.Text = "Start Calculation Session";
            this.btnStartCS.UseVisualStyleBackColor = true;
            this.btnStartCS.Click += new System.EventHandler(this.btnStartCS_Click);
            // 
            // btnClearResults
            // 
            this.btnClearResults.Location = new System.Drawing.Point(971, 235);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(113, 23);
            this.btnClearResults.TabIndex = 5;
            this.btnClearResults.Text = "Clear Results";
            this.btnClearResults.UseVisualStyleBackColor = true;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // lblMatrixA12
            // 
            this.lblMatrixA12.AutoSize = true;
            this.lblMatrixA12.Location = new System.Drawing.Point(735, 35);
            this.lblMatrixA12.Name = "lblMatrixA12";
            this.lblMatrixA12.Size = new System.Drawing.Size(205, 13);
            this.lblMatrixA12.TabIndex = 6;
            this.lblMatrixA12.Text = "Matrix A - max 12 not null elements on row";
            // 
            // lblMatrixB12
            // 
            this.lblMatrixB12.AutoSize = true;
            this.lblMatrixB12.Location = new System.Drawing.Point(735, 56);
            this.lblMatrixB12.Name = "lblMatrixB12";
            this.lblMatrixB12.Size = new System.Drawing.Size(205, 13);
            this.lblMatrixB12.TabIndex = 7;
            this.lblMatrixB12.Text = "Matrix B - max 12 not null elements on row";
            // 
            // lblMatrixAplusB24
            // 
            this.lblMatrixAplusB24.AutoSize = true;
            this.lblMatrixAplusB24.Location = new System.Drawing.Point(735, 77);
            this.lblMatrixAplusB24.Name = "lblMatrixAplusB24";
            this.lblMatrixAplusB24.Size = new System.Drawing.Size(218, 13);
            this.lblMatrixAplusB24.TabIndex = 8;
            this.lblMatrixAplusB24.Text = "Matrix A+B - max 24 not null elements on row";
            // 
            // lblAplusBCorrect
            // 
            this.lblAplusBCorrect.AutoSize = true;
            this.lblAplusBCorrect.Location = new System.Drawing.Point(735, 98);
            this.lblAplusBCorrect.Name = "lblAplusBCorrect";
            this.lblAplusBCorrect.Size = new System.Drawing.Size(141, 13);
            this.lblAplusBCorrect.TabIndex = 9;
            this.lblAplusBCorrect.Text = "Matrix A+B == Matrix APlusB";
            // 
            // lblAOriBCorrect
            // 
            this.lblAOriBCorrect.AutoSize = true;
            this.lblAOriBCorrect.Location = new System.Drawing.Point(735, 119);
            this.lblAOriBCorrect.Name = "lblAOriBCorrect";
            this.lblAOriBCorrect.Size = new System.Drawing.Size(132, 13);
            this.lblAOriBCorrect.TabIndex = 10;
            this.lblAOriBCorrect.Text = "Matrix A*B == Matrix AOriB";
            // 
            // lblAxCorrect
            // 
            this.lblAxCorrect.AutoSize = true;
            this.lblAxCorrect.Location = new System.Drawing.Point(735, 140);
            this.lblAxCorrect.Name = "lblAxCorrect";
            this.lblAxCorrect.Size = new System.Drawing.Size(189, 13);
            this.lblAxCorrect.TabIndex = 11;
            this.lblAxCorrect.Text = "Matrix A * (2019,2018,..,1) == Vector A";
            // 
            // lblBxCorrect
            // 
            this.lblBxCorrect.AutoSize = true;
            this.lblBxCorrect.Location = new System.Drawing.Point(735, 161);
            this.lblBxCorrect.Name = "lblBxCorrect";
            this.lblBxCorrect.Size = new System.Drawing.Size(189, 13);
            this.lblBxCorrect.TabIndex = 12;
            this.lblBxCorrect.Text = "Matrix B * (2019,2018,..,1) == Vector B";
            // 
            // lblAPlusBxCorrect
            // 
            this.lblAPlusBxCorrect.AutoSize = true;
            this.lblAPlusBxCorrect.Location = new System.Drawing.Point(735, 182);
            this.lblAPlusBxCorrect.Name = "lblAPlusBxCorrect";
            this.lblAPlusBxCorrect.Size = new System.Drawing.Size(243, 13);
            this.lblAPlusBxCorrect.TabIndex = 13;
            this.lblAPlusBxCorrect.Text = "Matrix APlusB * (2019,2018,..,1) == Vector APlusB";
            // 
            // lblAOriBxCorrect
            // 
            this.lblAOriBxCorrect.AutoSize = true;
            this.lblAOriBxCorrect.Location = new System.Drawing.Point(735, 203);
            this.lblAOriBxCorrect.Name = "lblAOriBxCorrect";
            this.lblAOriBxCorrect.Size = new System.Drawing.Size(229, 13);
            this.lblAOriBxCorrect.TabIndex = 14;
            this.lblAOriBxCorrect.Text = "Matrix AOriB * (2019,2018,..,1) == Vector AOriB";
            // 
            // txtMatrixA12
            // 
            this.txtMatrixA12.Location = new System.Drawing.Point(984, 32);
            this.txtMatrixA12.Name = "txtMatrixA12";
            this.txtMatrixA12.Size = new System.Drawing.Size(100, 20);
            this.txtMatrixA12.TabIndex = 15;
            this.txtMatrixA12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMatrixB12
            // 
            this.txtMatrixB12.Location = new System.Drawing.Point(984, 53);
            this.txtMatrixB12.Name = "txtMatrixB12";
            this.txtMatrixB12.Size = new System.Drawing.Size(100, 20);
            this.txtMatrixB12.TabIndex = 16;
            this.txtMatrixB12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMatrixAplusB24
            // 
            this.txtMatrixAplusB24.Location = new System.Drawing.Point(984, 74);
            this.txtMatrixAplusB24.Name = "txtMatrixAplusB24";
            this.txtMatrixAplusB24.Size = new System.Drawing.Size(100, 20);
            this.txtMatrixAplusB24.TabIndex = 17;
            this.txtMatrixAplusB24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAplusBCorrect
            // 
            this.txtAplusBCorrect.Location = new System.Drawing.Point(984, 95);
            this.txtAplusBCorrect.Name = "txtAplusBCorrect";
            this.txtAplusBCorrect.Size = new System.Drawing.Size(100, 20);
            this.txtAplusBCorrect.TabIndex = 18;
            this.txtAplusBCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAOriBCorrect
            // 
            this.txtAOriBCorrect.Location = new System.Drawing.Point(984, 116);
            this.txtAOriBCorrect.Name = "txtAOriBCorrect";
            this.txtAOriBCorrect.Size = new System.Drawing.Size(100, 20);
            this.txtAOriBCorrect.TabIndex = 19;
            this.txtAOriBCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAxCorrect
            // 
            this.txtAxCorrect.Location = new System.Drawing.Point(984, 137);
            this.txtAxCorrect.Name = "txtAxCorrect";
            this.txtAxCorrect.Size = new System.Drawing.Size(100, 20);
            this.txtAxCorrect.TabIndex = 20;
            this.txtAxCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxCorrect
            // 
            this.txtBxCorrect.Location = new System.Drawing.Point(984, 158);
            this.txtBxCorrect.Name = "txtBxCorrect";
            this.txtBxCorrect.Size = new System.Drawing.Size(100, 20);
            this.txtBxCorrect.TabIndex = 21;
            this.txtBxCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAPlusBxCorrect
            // 
            this.txtAPlusBxCorrect.Location = new System.Drawing.Point(984, 179);
            this.txtAPlusBxCorrect.Name = "txtAPlusBxCorrect";
            this.txtAPlusBxCorrect.Size = new System.Drawing.Size(100, 20);
            this.txtAPlusBxCorrect.TabIndex = 22;
            this.txtAPlusBxCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAOriBxCorrect
            // 
            this.txtAOriBxCorrect.Location = new System.Drawing.Point(984, 200);
            this.txtAOriBxCorrect.Name = "txtAOriBxCorrect";
            this.txtAOriBxCorrect.Size = new System.Drawing.Size(100, 20);
            this.txtAOriBxCorrect.TabIndex = 23;
            this.txtAOriBxCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tema3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 275);
            this.Controls.Add(this.txtAOriBxCorrect);
            this.Controls.Add(this.txtAPlusBxCorrect);
            this.Controls.Add(this.txtBxCorrect);
            this.Controls.Add(this.txtAxCorrect);
            this.Controls.Add(this.txtAOriBCorrect);
            this.Controls.Add(this.txtAplusBCorrect);
            this.Controls.Add(this.txtMatrixAplusB24);
            this.Controls.Add(this.txtMatrixB12);
            this.Controls.Add(this.txtMatrixA12);
            this.Controls.Add(this.lblAOriBxCorrect);
            this.Controls.Add(this.lblAPlusBxCorrect);
            this.Controls.Add(this.lblBxCorrect);
            this.Controls.Add(this.lblAxCorrect);
            this.Controls.Add(this.lblAOriBCorrect);
            this.Controls.Add(this.lblAplusBCorrect);
            this.Controls.Add(this.lblMatrixAplusB24);
            this.Controls.Add(this.lblMatrixB12);
            this.Controls.Add(this.lblMatrixA12);
            this.Controls.Add(this.btnClearResults);
            this.Controls.Add(this.btnStartCS);
            this.Controls.Add(this.clbStepsCompleted);
            this.Controls.Add(this.lvlStepsCompleted);
            this.Controls.Add(this.lblInitialization);
            this.Controls.Add(this.clbInitialization);
            this.Name = "Tema3";
            this.Text = "Tema3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbInitialization;
        private System.Windows.Forms.Label lblInitialization;
        private System.Windows.Forms.Label lvlStepsCompleted;
        private System.Windows.Forms.CheckedListBox clbStepsCompleted;
        private System.Windows.Forms.Button btnStartCS;
        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.Label lblMatrixA12;
        private System.Windows.Forms.Label lblMatrixB12;
        private System.Windows.Forms.Label lblMatrixAplusB24;
        private System.Windows.Forms.Label lblAplusBCorrect;
        private System.Windows.Forms.Label lblAOriBCorrect;
        private System.Windows.Forms.Label lblAxCorrect;
        private System.Windows.Forms.Label lblBxCorrect;
        private System.Windows.Forms.Label lblAPlusBxCorrect;
        private System.Windows.Forms.Label lblAOriBxCorrect;
        private System.Windows.Forms.TextBox txtMatrixA12;
        private System.Windows.Forms.TextBox txtMatrixB12;
        private System.Windows.Forms.TextBox txtMatrixAplusB24;
        private System.Windows.Forms.TextBox txtAplusBCorrect;
        private System.Windows.Forms.TextBox txtAOriBCorrect;
        private System.Windows.Forms.TextBox txtAxCorrect;
        private System.Windows.Forms.TextBox txtBxCorrect;
        private System.Windows.Forms.TextBox txtAPlusBxCorrect;
        private System.Windows.Forms.TextBox txtAOriBxCorrect;
    }
}

