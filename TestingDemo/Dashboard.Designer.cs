namespace TestingDemo
{
    partial class Dashboard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.bntSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDiv);
            this.groupBox1.Controls.Add(this.btnMult);
            this.groupBox1.Controls.Add(this.bntSub);
            this.groupBox1.Controls.Add(this.btnSum);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.num2);
            this.groupBox1.Controls.Add(this.num1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(279, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddPerson);
            this.groupBox2.Controls.Add(this.txtSobrenome);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.cmbUsers);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(343, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(333, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuários:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Resultado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Segundo número:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Primeiro número:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(123, 49);
            this.num1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(71, 21);
            this.num1.TabIndex = 4;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(123, 79);
            this.num2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(71, 21);
            this.num2.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(123, 196);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(70, 21);
            this.txtResult.TabIndex = 6;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(34, 116);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(35, 26);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // bntSub
            // 
            this.bntSub.Location = new System.Drawing.Point(76, 116);
            this.bntSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntSub.Name = "bntSub";
            this.bntSub.Size = new System.Drawing.Size(35, 26);
            this.bntSub.TabIndex = 8;
            this.bntSub.Text = "-";
            this.bntSub.UseVisualStyleBackColor = true;
            this.bntSub.Click += new System.EventHandler(this.bntSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(118, 116);
            this.btnMult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(35, 26);
            this.btnMult.TabIndex = 9;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(160, 116);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(35, 26);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(104, 46);
            this.cmbUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(200, 23);
            this.cmbUsers.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 94);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 21);
            this.txtNome.TabIndex = 7;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(102, 125);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(200, 21);
            this.txtSobrenome.TabIndex = 8;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(209, 193);
            this.btnAddPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(95, 26);
            this.btnAddPerson.TabIndex = 11;
            this.btnAddPerson.Text = "Incluir Pessoa";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button bntSub;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}