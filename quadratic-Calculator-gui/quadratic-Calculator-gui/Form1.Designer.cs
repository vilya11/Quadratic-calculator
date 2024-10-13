namespace quadratic_Calculator_gui
{
    partial class calculate
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
            this.Calculator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.clear1 = new System.Windows.Forms.Button();
            this.calculate1 = new System.Windows.Forms.Button();
            this.aInputText = new System.Windows.Forms.TextBox();
            this.bInputText = new System.Windows.Forms.TextBox();
            this.cInputText = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.Label();
            this.x1InputText = new System.Windows.Forms.TextBox();
            this.x2InputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.AutoSize = true;
            this.Calculator.BackColor = System.Drawing.Color.Pink;
            this.Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Calculator.Location = new System.Drawing.Point(152, 19);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(461, 39);
            this.Calculator.TabIndex = 2;
            this.Calculator.Text = "Quadratic Formula Calculator";
            this.Calculator.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(273, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ax^2+bx+c=0";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.a.ForeColor = System.Drawing.Color.White;
            this.a.Location = new System.Drawing.Point(110, 150);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(37, 26);
            this.a.TabIndex = 10;
            this.a.Text = "a=";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.b.ForeColor = System.Drawing.Color.White;
            this.b.Location = new System.Drawing.Point(110, 196);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(37, 26);
            this.b.TabIndex = 11;
            this.b.Text = "b=";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.c.ForeColor = System.Drawing.Color.White;
            this.c.Location = new System.Drawing.Point(110, 246);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(36, 26);
            this.c.TabIndex = 12;
            this.c.Text = "c=";
            this.c.Click += new System.EventHandler(this.label3_Click);
            // 
            // clear1
            // 
            this.clear1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.clear1.Location = new System.Drawing.Point(612, 237);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(176, 50);
            this.clear1.TabIndex = 4;
            this.clear1.Text = "clear";
            this.clear1.UseVisualStyleBackColor = false;
            this.clear1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculate1
            // 
            this.calculate1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.calculate1.Location = new System.Drawing.Point(612, 150);
            this.calculate1.Name = "calculate1";
            this.calculate1.Size = new System.Drawing.Size(176, 50);
            this.calculate1.TabIndex = 3;
            this.calculate1.Text = "calculate";
            this.calculate1.UseVisualStyleBackColor = false;
            this.calculate1.Click += new System.EventHandler(this.calculate1_Click);
            // 
            // aInputText
            // 
            this.aInputText.Location = new System.Drawing.Point(200, 154);
            this.aInputText.Name = "aInputText";
            this.aInputText.Size = new System.Drawing.Size(283, 22);
            this.aInputText.TabIndex = 0;
            this.aInputText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bInputText
            // 
            this.bInputText.Location = new System.Drawing.Point(200, 201);
            this.bInputText.Name = "bInputText";
            this.bInputText.Size = new System.Drawing.Size(283, 22);
            this.bInputText.TabIndex = 1;
            // 
            // cInputText
            // 
            this.cInputText.Location = new System.Drawing.Point(200, 246);
            this.cInputText.Name = "cInputText";
            this.cInputText.Size = new System.Drawing.Size(283, 22);
            this.cInputText.TabIndex = 2;
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.x1.ForeColor = System.Drawing.Color.White;
            this.x1.Location = new System.Drawing.Point(111, 295);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(48, 26);
            this.x1.TabIndex = 13;
            this.x1.Text = "x1=";
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.x2.ForeColor = System.Drawing.Color.White;
            this.x2.Location = new System.Drawing.Point(110, 339);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(48, 26);
            this.x2.TabIndex = 0;
            this.x2.Text = "x2=";
            // 
            // x1InputText
            // 
            this.x1InputText.Location = new System.Drawing.Point(200, 300);
            this.x1InputText.Name = "x1InputText";
            this.x1InputText.ReadOnly = true;
            this.x1InputText.Size = new System.Drawing.Size(283, 22);
            this.x1InputText.TabIndex = 3;
            // 
            // x2InputText
            // 
            this.x2InputText.Location = new System.Drawing.Point(200, 344);
            this.x2InputText.Name = "x2InputText";
            this.x2InputText.ReadOnly = true;
            this.x2InputText.Size = new System.Drawing.Size(283, 22);
            this.x2InputText.TabIndex = 4;
            // 
            // calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.x2InputText);
            this.Controls.Add(this.x1InputText);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.cInputText);
            this.Controls.Add(this.bInputText);
            this.Controls.Add(this.aInputText);
            this.Controls.Add(this.calculate1);
            this.Controls.Add(this.clear1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculator);
            this.Name = "calculate";
            this.Text = "Quadratic Formula Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Calculator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Button clear1;
        private System.Windows.Forms.Button calculate1;
        private System.Windows.Forms.TextBox aInputText;
        private System.Windows.Forms.TextBox bInputText;
        private System.Windows.Forms.TextBox cInputText;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label x2;
        private System.Windows.Forms.TextBox x1InputText;
        private System.Windows.Forms.TextBox x2InputText;
    }
}

