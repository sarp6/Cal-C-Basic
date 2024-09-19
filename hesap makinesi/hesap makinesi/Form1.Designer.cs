namespace hesap_makinesi
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
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(500, 139);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(379, 116);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(156, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(379, 155);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 36);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Location = new System.Drawing.Point(460, 155);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(75, 36);
            this.buttonSubstract.TabIndex = 3;
            this.buttonSubstract.Text = "-";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            this.buttonSubstract.Click += new System.EventHandler(this.buttonSubstract_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(379, 197);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(75, 36);
            this.buttonMultiply.TabIndex = 4;
            this.buttonMultiply.Text = "X";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(460, 197);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(75, 36);
            this.buttonDivide.TabIndex = 5;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(379, 237);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(75, 43);
            this.buttonEquals.TabIndex = 6;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(460, 237);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 43);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubstract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelResult);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonClear;
    }
}

