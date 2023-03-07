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
            this.txtValorhora = new System.Windows.Forms.TextBox();
            this.txtHorastrabalhadas = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.LNOME = new System.Windows.Forms.Label();
            this.LCPF = new System.Windows.Forms.Label();
            this.LValorH = new System.Windows.Forms.Label();
            this.LHorasTRABALHADAS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncalcular.Location = new System.Drawing.Point(271, 316);
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
            // txtValorhora
            // 
            this.txtValorhora.Location = new System.Drawing.Point(118, 162);
            this.txtValorhora.Name = "txtValorhora";
            this.txtValorhora.Size = new System.Drawing.Size(188, 23);
            this.txtValorhora.TabIndex = 2;
            // 
            // txtHorastrabalhadas
            // 
            this.txtHorastrabalhadas.Location = new System.Drawing.Point(168, 264);
            this.txtHorastrabalhadas.Name = "txtHorastrabalhadas";
            this.txtHorastrabalhadas.Size = new System.Drawing.Size(138, 23);
            this.txtHorastrabalhadas.TabIndex = 3;
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSalario.Location = new System.Drawing.Point(513, 165);
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
            this.LValorH.Location = new System.Drawing.Point(6, 162);
            this.LValorH.Name = "LValorH";
            this.LValorH.Size = new System.Drawing.Size(110, 20);
            this.LValorH.TabIndex = 8;
            this.LValorH.Text = "Salario P/Hora";
            // 
            // LHorasTRABALHADAS
            // 
            this.LHorasTRABALHADAS.AutoSize = true;
            this.LHorasTRABALHADAS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LHorasTRABALHADAS.Location = new System.Drawing.Point(6, 264);
            this.LHorasTRABALHADAS.Name = "LHorasTRABALHADAS";
            this.LHorasTRABALHADAS.Size = new System.Drawing.Size(154, 21);
            this.LHorasTRABALHADAS.TabIndex = 9;
            this.LHorasTRABALHADAS.Text = "Horas Trabalhadas ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(360, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pretensão Salarial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 370);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LHorasTRABALHADAS);
            this.Controls.Add(this.LValorH);
            this.Controls.Add(this.LCPF);
            this.Controls.Add(this.LNOME);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtHorastrabalhadas);
            this.Controls.Add(this.txtValorhora);
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
        private TextBox txtValorhora;
        private TextBox txtHorastrabalhadas;
        private TextBox txtSalario;
        private TextBox txtCPF;
        private Label LNOME;
        private Label LCPF;
        private Label LValorH;
        private Label LHorasTRABALHADAS;
        private Label label5;
    }
}