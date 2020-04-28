namespace Aula_28_04_2020
{
    partial class FrmPredictor
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
            this.pnlHoroscopo = new System.Windows.Forms.Panel();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblSignoDesc = new System.Windows.Forms.Label();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.lblSignoTipo = new System.Windows.Forms.Label();
            this.pnlNumSorte = new System.Windows.Forms.Panel();
            this.pnlNome = new System.Windows.Forms.Panel();
            this.dtpNiver = new System.Windows.Forms.DateTimePicker();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnPrever = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lnlNumSorte = new System.Windows.Forms.Label();
            this.lblMega = new System.Windows.Forms.Label();
            this.pnlHoroscopo.SuspendLayout();
            this.pnlNumSorte.SuspendLayout();
            this.pnlNome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHoroscopo
            // 
            this.pnlHoroscopo.Controls.Add(this.lblSigno);
            this.pnlHoroscopo.Controls.Add(this.lblSignoDesc);
            this.pnlHoroscopo.Controls.Add(this.btnNumeros);
            this.pnlHoroscopo.Controls.Add(this.lblSignoTipo);
            this.pnlHoroscopo.Location = new System.Drawing.Point(7, 171);
            this.pnlHoroscopo.Name = "pnlHoroscopo";
            this.pnlHoroscopo.Size = new System.Drawing.Size(315, 256);
            this.pnlHoroscopo.TabIndex = 7;
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Location = new System.Drawing.Point(18, 10);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(69, 13);
            this.lblSigno.TabIndex = 14;
            this.lblSigno.Text = "Seu signo é: ";
            // 
            // lblSignoDesc
            // 
            this.lblSignoDesc.AutoSize = true;
            this.lblSignoDesc.Location = new System.Drawing.Point(18, 44);
            this.lblSignoDesc.MaximumSize = new System.Drawing.Size(250, 120);
            this.lblSignoDesc.Name = "lblSignoDesc";
            this.lblSignoDesc.Size = new System.Drawing.Size(55, 13);
            this.lblSignoDesc.TabIndex = 13;
            this.lblSignoDesc.Text = "Descrição";
            // 
            // btnNumeros
            // 
            this.btnNumeros.Location = new System.Drawing.Point(19, 194);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(276, 50);
            this.btnNumeros.TabIndex = 12;
            this.btnNumeros.Text = "Me mostre meus números!";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // lblSignoTipo
            // 
            this.lblSignoTipo.AutoSize = true;
            this.lblSignoTipo.Location = new System.Drawing.Point(18, 27);
            this.lblSignoTipo.Name = "lblSignoTipo";
            this.lblSignoTipo.Size = new System.Drawing.Size(66, 13);
            this.lblSignoTipo.TabIndex = 0;
            this.lblSignoTipo.Text = "Seu signo é ";
            // 
            // pnlNumSorte
            // 
            this.pnlNumSorte.Controls.Add(this.lblMega);
            this.pnlNumSorte.Controls.Add(this.lnlNumSorte);
            this.pnlNumSorte.Location = new System.Drawing.Point(7, 443);
            this.pnlNumSorte.Name = "pnlNumSorte";
            this.pnlNumSorte.Size = new System.Drawing.Size(315, 97);
            this.pnlNumSorte.TabIndex = 8;
            // 
            // pnlNome
            // 
            this.pnlNome.Controls.Add(this.dtpNiver);
            this.pnlNome.Controls.Add(this.lblDtNasc);
            this.pnlNome.Controls.Add(this.lblNome);
            this.pnlNome.Controls.Add(this.btnPrever);
            this.pnlNome.Controls.Add(this.txtNome);
            this.pnlNome.Location = new System.Drawing.Point(10, 8);
            this.pnlNome.Name = "pnlNome";
            this.pnlNome.Size = new System.Drawing.Size(312, 157);
            this.pnlNome.TabIndex = 9;
            // 
            // dtpNiver
            // 
            this.dtpNiver.Location = new System.Drawing.Point(18, 78);
            this.dtpNiver.Name = "dtpNiver";
            this.dtpNiver.Size = new System.Drawing.Size(274, 20);
            this.dtpNiver.TabIndex = 14;
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(15, 62);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(177, 13);
            this.lblDtNasc.TabIndex = 13;
            this.lblDtNasc.Text = "Selecione sua Data de Nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 6);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(88, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Digite seu Nome:";
            // 
            // btnPrever
            // 
            this.btnPrever.Location = new System.Drawing.Point(18, 104);
            this.btnPrever.Name = "btnPrever";
            this.btnPrever.Size = new System.Drawing.Size(276, 50);
            this.btnPrever.TabIndex = 11;
            this.btnPrever.Text = "Prever!";
            this.btnPrever.UseVisualStyleBackColor = true;
            this.btnPrever.Click += new System.EventHandler(this.btnPrever_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(18, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(274, 27);
            this.txtNome.TabIndex = 10;
            // 
            // lnlNumSorte
            // 
            this.lnlNumSorte.AutoSize = true;
            this.lnlNumSorte.Location = new System.Drawing.Point(16, 14);
            this.lnlNumSorte.Name = "lnlNumSorte";
            this.lnlNumSorte.Size = new System.Drawing.Size(138, 13);
            this.lnlNumSorte.TabIndex = 4;
            this.lnlNumSorte.Text = "Seus números da sorte são:";
            // 
            // lblMega
            // 
            this.lblMega.AutoSize = true;
            this.lblMega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMega.Location = new System.Drawing.Point(24, 38);
            this.lblMega.Name = "lblMega";
            this.lblMega.Size = new System.Drawing.Size(0, 20);
            this.lblMega.TabIndex = 5;
            this.lblMega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPredictor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 552);
            this.Controls.Add(this.pnlNome);
            this.Controls.Add(this.pnlNumSorte);
            this.Controls.Add(this.pnlHoroscopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPredictor";
            this.Text = "O Guru";
            this.Load += new System.EventHandler(this.FrmPredictor_Load);
            this.pnlHoroscopo.ResumeLayout(false);
            this.pnlHoroscopo.PerformLayout();
            this.pnlNumSorte.ResumeLayout(false);
            this.pnlNumSorte.PerformLayout();
            this.pnlNome.ResumeLayout(false);
            this.pnlNome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHoroscopo;
        private System.Windows.Forms.Label lblSignoTipo;
        private System.Windows.Forms.Panel pnlNumSorte;
        private System.Windows.Forms.Panel pnlNome;
        private System.Windows.Forms.DateTimePicker dtpNiver;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        protected System.Windows.Forms.Button btnPrever;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label lblSignoDesc;
        protected System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.Label lblMega;
        private System.Windows.Forms.Label lnlNumSorte;
    }
}

