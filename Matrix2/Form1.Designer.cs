
namespace Matrix2
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
            this.lblCol = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.btnMakeBIdentity = new System.Windows.Forms.Button();
            this.txtMatrixBCol = new System.Windows.Forms.TextBox();
            this.txtMatrixACol = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearMatrices = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbOperation = new System.Windows.Forms.GroupBox();
            this.rbSubtract = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.txtMakeMatrixBRow = new System.Windows.Forms.TextBox();
            this.txtMakeMatrixARow = new System.Windows.Forms.TextBox();
            this.btnMakeMatrixB = new System.Windows.Forms.Button();
            this.btnMakeMatrixA = new System.Windows.Forms.Button();
            this.lblMatrixC = new System.Windows.Forms.Label();
            this.lblMatrixB = new System.Windows.Forms.Label();
            this.lblMatrixA = new System.Windows.Forms.Label();
            this.txtMatrixC = new System.Windows.Forms.TextBox();
            this.txtMatrixB = new System.Windows.Forms.TextBox();
            this.txtMatrixA = new System.Windows.Forms.TextBox();
            this.rbAequalsB = new System.Windows.Forms.RadioButton();
            this.btnMakeBCopyOfA = new System.Windows.Forms.Button();
            this.gbOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(280, 207);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(40, 20);
            this.lblCol.TabIndex = 37;
            this.lblCol.Text = "Cols";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(171, 207);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(49, 20);
            this.lblRows.TabIndex = 36;
            this.lblRows.Text = "Rows";
            // 
            // btnMakeBIdentity
            // 
            this.btnMakeBIdentity.Location = new System.Drawing.Point(395, 273);
            this.btnMakeBIdentity.Name = "btnMakeBIdentity";
            this.btnMakeBIdentity.Size = new System.Drawing.Size(180, 34);
            this.btnMakeBIdentity.TabIndex = 25;
            this.btnMakeBIdentity.Text = "Make B Identity";
            this.btnMakeBIdentity.UseVisualStyleBackColor = true;
            this.btnMakeBIdentity.Click += new System.EventHandler(this.btnMakeBIdentity_Click);
            // 
            // txtMatrixBCol
            // 
            this.txtMatrixBCol.Location = new System.Drawing.Point(272, 277);
            this.txtMatrixBCol.Name = "txtMatrixBCol";
            this.txtMatrixBCol.Size = new System.Drawing.Size(117, 26);
            this.txtMatrixBCol.TabIndex = 23;
            // 
            // txtMatrixACol
            // 
            this.txtMatrixACol.Location = new System.Drawing.Point(272, 230);
            this.txtMatrixACol.Name = "txtMatrixACol";
            this.txtMatrixACol.Size = new System.Drawing.Size(117, 26);
            this.txtMatrixACol.TabIndex = 20;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(534, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 31);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearMatrices
            // 
            this.btnClearMatrices.Location = new System.Drawing.Point(395, 441);
            this.btnClearMatrices.Name = "btnClearMatrices";
            this.btnClearMatrices.Size = new System.Drawing.Size(130, 31);
            this.btnClearMatrices.TabIndex = 30;
            this.btnClearMatrices.Text = "Clear Matrices";
            this.btnClearMatrices.UseVisualStyleBackColor = true;
            this.btnClearMatrices.Click += new System.EventHandler(this.btnClearMatrices_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(29, 441);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 31);
            this.btnCalculate.TabIndex = 29;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gbOperation
            // 
            this.gbOperation.Controls.Add(this.rbAequalsB);
            this.gbOperation.Controls.Add(this.rbSubtract);
            this.gbOperation.Controls.Add(this.rbAdd);
            this.gbOperation.Controls.Add(this.rbMultiply);
            this.gbOperation.Location = new System.Drawing.Point(29, 339);
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Size = new System.Drawing.Size(398, 79);
            this.gbOperation.TabIndex = 32;
            this.gbOperation.TabStop = false;
            this.gbOperation.Text = "Select Operation";
            // 
            // rbSubtract
            // 
            this.rbSubtract.AutoSize = true;
            this.rbSubtract.Location = new System.Drawing.Point(178, 37);
            this.rbSubtract.Name = "rbSubtract";
            this.rbSubtract.Size = new System.Drawing.Size(95, 24);
            this.rbSubtract.TabIndex = 11;
            this.rbSubtract.TabStop = true;
            this.rbSubtract.Text = "Subtract";
            this.rbSubtract.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(109, 37);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(63, 24);
            this.rbAdd.TabIndex = 11;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Checked = true;
            this.rbMultiply.Location = new System.Drawing.Point(17, 37);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(86, 24);
            this.rbMultiply.TabIndex = 11;
            this.rbMultiply.TabStop = true;
            this.rbMultiply.Text = "Multiply";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // txtMakeMatrixBRow
            // 
            this.txtMakeMatrixBRow.Location = new System.Drawing.Point(160, 277);
            this.txtMakeMatrixBRow.Name = "txtMakeMatrixBRow";
            this.txtMakeMatrixBRow.Size = new System.Drawing.Size(106, 26);
            this.txtMakeMatrixBRow.TabIndex = 21;
            // 
            // txtMakeMatrixARow
            // 
            this.txtMakeMatrixARow.Location = new System.Drawing.Point(160, 230);
            this.txtMakeMatrixARow.Name = "txtMakeMatrixARow";
            this.txtMakeMatrixARow.Size = new System.Drawing.Size(106, 26);
            this.txtMakeMatrixARow.TabIndex = 19;
            // 
            // btnMakeMatrixB
            // 
            this.btnMakeMatrixB.Location = new System.Drawing.Point(29, 270);
            this.btnMakeMatrixB.Name = "btnMakeMatrixB";
            this.btnMakeMatrixB.Size = new System.Drawing.Size(125, 41);
            this.btnMakeMatrixB.TabIndex = 28;
            this.btnMakeMatrixB.Text = "Make Matrix B";
            this.btnMakeMatrixB.UseVisualStyleBackColor = true;
            this.btnMakeMatrixB.Click += new System.EventHandler(this.btnMakeMatrixB_Click);
            // 
            // btnMakeMatrixA
            // 
            this.btnMakeMatrixA.Location = new System.Drawing.Point(29, 223);
            this.btnMakeMatrixA.Name = "btnMakeMatrixA";
            this.btnMakeMatrixA.Size = new System.Drawing.Size(125, 41);
            this.btnMakeMatrixA.TabIndex = 27;
            this.btnMakeMatrixA.Text = "Make Matrix A";
            this.btnMakeMatrixA.UseVisualStyleBackColor = true;
            this.btnMakeMatrixA.Click += new System.EventHandler(this.btnMakeMatrixA_Click);
            // 
            // lblMatrixC
            // 
            this.lblMatrixC.AutoSize = true;
            this.lblMatrixC.Location = new System.Drawing.Point(439, 18);
            this.lblMatrixC.Name = "lblMatrixC";
            this.lblMatrixC.Size = new System.Drawing.Size(66, 20);
            this.lblMatrixC.TabIndex = 26;
            this.lblMatrixC.Text = "Matrix C";
            // 
            // lblMatrixB
            // 
            this.lblMatrixB.AutoSize = true;
            this.lblMatrixB.Location = new System.Drawing.Point(232, 18);
            this.lblMatrixB.Name = "lblMatrixB";
            this.lblMatrixB.Size = new System.Drawing.Size(66, 20);
            this.lblMatrixB.TabIndex = 24;
            this.lblMatrixB.Text = "Matrix B";
            // 
            // lblMatrixA
            // 
            this.lblMatrixA.AutoSize = true;
            this.lblMatrixA.Location = new System.Drawing.Point(25, 18);
            this.lblMatrixA.Name = "lblMatrixA";
            this.lblMatrixA.Size = new System.Drawing.Size(66, 20);
            this.lblMatrixA.TabIndex = 22;
            this.lblMatrixA.Text = "Matrix A";
            // 
            // txtMatrixC
            // 
            this.txtMatrixC.Location = new System.Drawing.Point(443, 41);
            this.txtMatrixC.Multiline = true;
            this.txtMatrixC.Name = "txtMatrixC";
            this.txtMatrixC.ReadOnly = true;
            this.txtMatrixC.Size = new System.Drawing.Size(175, 150);
            this.txtMatrixC.TabIndex = 35;
            this.txtMatrixC.TabStop = false;
            // 
            // txtMatrixB
            // 
            this.txtMatrixB.Location = new System.Drawing.Point(236, 41);
            this.txtMatrixB.Multiline = true;
            this.txtMatrixB.Name = "txtMatrixB";
            this.txtMatrixB.ReadOnly = true;
            this.txtMatrixB.Size = new System.Drawing.Size(172, 150);
            this.txtMatrixB.TabIndex = 34;
            this.txtMatrixB.TabStop = false;
            // 
            // txtMatrixA
            // 
            this.txtMatrixA.Location = new System.Drawing.Point(29, 41);
            this.txtMatrixA.Multiline = true;
            this.txtMatrixA.Name = "txtMatrixA";
            this.txtMatrixA.ReadOnly = true;
            this.txtMatrixA.Size = new System.Drawing.Size(172, 150);
            this.txtMatrixA.TabIndex = 31;
            this.txtMatrixA.TabStop = false;
            // 
            // rbAequalsB
            // 
            this.rbAequalsB.AutoSize = true;
            this.rbAequalsB.Location = new System.Drawing.Point(279, 37);
            this.rbAequalsB.Name = "rbAequalsB";
            this.rbAequalsB.Size = new System.Drawing.Size(82, 24);
            this.rbAequalsB.TabIndex = 38;
            this.rbAequalsB.TabStop = true;
            this.rbAequalsB.Text = "A == B";
            this.rbAequalsB.UseVisualStyleBackColor = true;
            // 
            // btnMakeBCopyOfA
            // 
            this.btnMakeBCopyOfA.Location = new System.Drawing.Point(395, 226);
            this.btnMakeBCopyOfA.Name = "btnMakeBCopyOfA";
            this.btnMakeBCopyOfA.Size = new System.Drawing.Size(180, 34);
            this.btnMakeBCopyOfA.TabIndex = 38;
            this.btnMakeBCopyOfA.Text = "Make B Copy of A";
            this.btnMakeBCopyOfA.UseVisualStyleBackColor = true;
            this.btnMakeBCopyOfA.Click += new System.EventHandler(this.btnMakeBCopyOfA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 493);
            this.Controls.Add(this.btnMakeBCopyOfA);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.btnMakeBIdentity);
            this.Controls.Add(this.txtMatrixBCol);
            this.Controls.Add(this.txtMatrixACol);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearMatrices);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbOperation);
            this.Controls.Add(this.txtMakeMatrixBRow);
            this.Controls.Add(this.txtMakeMatrixARow);
            this.Controls.Add(this.btnMakeMatrixB);
            this.Controls.Add(this.btnMakeMatrixA);
            this.Controls.Add(this.lblMatrixC);
            this.Controls.Add(this.lblMatrixB);
            this.Controls.Add(this.lblMatrixA);
            this.Controls.Add(this.txtMatrixC);
            this.Controls.Add(this.txtMatrixB);
            this.Controls.Add(this.txtMatrixA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbOperation.ResumeLayout(false);
            this.gbOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Button btnMakeBIdentity;
        private System.Windows.Forms.TextBox txtMatrixBCol;
        private System.Windows.Forms.TextBox txtMatrixACol;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearMatrices;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gbOperation;
        private System.Windows.Forms.RadioButton rbSubtract;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.TextBox txtMakeMatrixBRow;
        private System.Windows.Forms.TextBox txtMakeMatrixARow;
        private System.Windows.Forms.Button btnMakeMatrixB;
        private System.Windows.Forms.Button btnMakeMatrixA;
        private System.Windows.Forms.Label lblMatrixC;
        private System.Windows.Forms.Label lblMatrixB;
        private System.Windows.Forms.Label lblMatrixA;
        private System.Windows.Forms.TextBox txtMatrixC;
        private System.Windows.Forms.TextBox txtMatrixB;
        private System.Windows.Forms.TextBox txtMatrixA;
        private System.Windows.Forms.RadioButton rbAequalsB;
        private System.Windows.Forms.Button btnMakeBCopyOfA;
    }
}

