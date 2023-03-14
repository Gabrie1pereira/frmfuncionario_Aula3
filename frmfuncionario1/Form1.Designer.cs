namespace frmfuncionario1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.txtDiasTrabalhadas = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.LNOME = new System.Windows.Forms.Label();
            this.LCPF = new System.Windows.Forms.Label();
            this.LValorH = new System.Windows.Forms.Label();
            this.LHorasTRABALHADAS = new System.Windows.Forms.Label();
            this.LsalarioBase = new System.Windows.Forms.Label();
            this.txtValorIR = new System.Windows.Forms.TextBox();
            this.txtSalario_Liquido = new System.Windows.Forms.TextBox();
            this.LvlIr = new System.Windows.Forms.Label();
            this.Lsalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncalcular.Location = new System.Drawing.Point(271, 327);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(103, 31);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(94, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(105, 121);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(78, 23);
            this.txtValorDiaria.TabIndex = 2;
            // 
            // txtDiasTrabalhadas
            // 
            this.txtDiasTrabalhadas.Location = new System.Drawing.Point(476, 121);
            this.txtDiasTrabalhadas.Name = "txtDiasTrabalhadas";
            this.txtDiasTrabalhadas.Size = new System.Drawing.Size(60, 23);
            this.txtDiasTrabalhadas.TabIndex = 3;
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSalario.Location = new System.Drawing.Point(295, 184);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ReadOnly = true;
            this.txtSalario.Size = new System.Drawing.Size(113, 23);
            this.txtSalario.TabIndex = 4;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(464, 62);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(150, 23);
            this.txtCPF.TabIndex = 5;
            // 
            // LNOME
            // 
            this.LNOME.AutoSize = true;
            this.LNOME.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LNOME.Location = new System.Drawing.Point(31, 60);
            this.LNOME.Name = "LNOME";
            this.LNOME.Size = new System.Drawing.Size(57, 21);
            this.LNOME.TabIndex = 6;
            this.LNOME.Text = "Nome";
            // 
            // LCPF
            // 
            this.LCPF.AutoSize = true;
            this.LCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LCPF.Location = new System.Drawing.Point(409, 60);
            this.LCPF.Name = "LCPF";
            this.LCPF.Size = new System.Drawing.Size(38, 21);
            this.LCPF.TabIndex = 7;
            this.LCPF.Text = "CPF";
            // 
            // LValorH
            // 
            this.LValorH.AutoSize = true;
            this.LValorH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LValorH.Location = new System.Drawing.Point(6, 120);
            this.LValorH.Name = "LValorH";
            this.LValorH.Size = new System.Drawing.Size(93, 20);
            this.LValorH.TabIndex = 8;
            this.LValorH.Text = "Valor/Diaria";
            // 
            // LHorasTRABALHADAS
            // 
            this.LHorasTRABALHADAS.AutoSize = true;
            this.LHorasTRABALHADAS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LHorasTRABALHADAS.Location = new System.Drawing.Point(326, 123);
            this.LHorasTRABALHADAS.Name = "LHorasTRABALHADAS";
            this.LHorasTRABALHADAS.Size = new System.Drawing.Size(144, 21);
            this.LHorasTRABALHADAS.TabIndex = 9;
            this.LHorasTRABALHADAS.Text = "Dias  Trabalhados";
            // 
            // LsalarioBase
            // 
            this.LsalarioBase.AutoSize = true;
            this.LsalarioBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LsalarioBase.Location = new System.Drawing.Point(134, 187);
            this.LsalarioBase.Name = "LsalarioBase";
            this.LsalarioBase.Size = new System.Drawing.Size(106, 21);
            this.LsalarioBase.TabIndex = 10;
            this.LsalarioBase.Text = "Salario Base ";
            // 
            // txtValorIR
            // 
            this.txtValorIR.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtValorIR.Location = new System.Drawing.Point(295, 231);
            this.txtValorIR.Name = "txtValorIR";
            this.txtValorIR.Size = new System.Drawing.Size(113, 23);
            this.txtValorIR.TabIndex = 11;
            this.txtValorIR.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSalario_Liquido
            // 
            this.txtSalario_Liquido.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSalario_Liquido.Location = new System.Drawing.Point(295, 280);
            this.txtSalario_Liquido.Name = "txtSalario_Liquido";
            this.txtSalario_Liquido.Size = new System.Drawing.Size(113, 23);
            this.txtSalario_Liquido.TabIndex = 12;
            this.txtSalario_Liquido.TextChanged += new System.EventHandler(this.txtSalario_Liquido_TextChanged);
            // 
            // LvlIr
            // 
            this.LvlIr.AutoSize = true;
            this.LvlIr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LvlIr.Location = new System.Drawing.Point(134, 233);
            this.LvlIr.Name = "LvlIr";
            this.LvlIr.Size = new System.Drawing.Size(93, 21);
            this.LvlIr.TabIndex = 13;
            this.LvlIr.Text = "Valor do IR";
            // 
            // Lsalario
            // 
            this.Lsalario.AutoSize = true;
            this.Lsalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lsalario.Location = new System.Drawing.Point(134, 282);
            this.Lsalario.Name = "Lsalario";
            this.Lsalario.Size = new System.Drawing.Size(129, 21);
            this.Lsalario.TabIndex = 14;
            this.Lsalario.Text = "Salario Liquido ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 370);
            this.Controls.Add(this.Lsalario);
            this.Controls.Add(this.LvlIr);
            this.Controls.Add(this.txtSalario_Liquido);
            this.Controls.Add(this.txtValorIR);
            this.Controls.Add(this.LsalarioBase);
            this.Controls.Add(this.LHorasTRABALHADAS);
            this.Controls.Add(this.LValorH);
            this.Controls.Add(this.LCPF);
            this.Controls.Add(this.LNOME);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtDiasTrabalhadas);
            this.Controls.Add(this.txtValorDiaria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btncalcular);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Funcionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btncalcular;
        private TextBox txtNome;
        private TextBox txtValorDiaria;
        private TextBox txtDiasTrabalhadas;
        private TextBox txtSalario;
        private TextBox txtCPF;
        private Label LNOME;
        private Label LCPF;
        private Label LValorH;
        private Label LHorasTRABALHADAS;
        private Label LsalarioBase;
        private TextBox txtValorIR;
        private TextBox txtSalario_Liquido;
        private Label LvlIr;
        private Label Lsalario;
    }
}