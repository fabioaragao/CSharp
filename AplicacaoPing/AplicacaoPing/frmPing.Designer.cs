namespace AplicacaoPing
{
    partial class frmPing
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpHost = new System.Windows.Forms.GroupBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.gbIP = new System.Windows.Forms.GroupBox();
            this.txtIpHost = new System.Windows.Forms.TextBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpHost.SuspendLayout();
            this.gbIP.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpHost
            // 
            this.gpHost.Controls.Add(this.txtHost);
            this.gpHost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpHost.Location = new System.Drawing.Point(14, 15);
            this.gpHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpHost.Name = "gpHost";
            this.gpHost.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpHost.Size = new System.Drawing.Size(315, 60);
            this.gpHost.TabIndex = 0;
            this.gpHost.TabStop = false;
            this.gpHost.Text = "Digite o Host:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(7, 23);
            this.txtHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(300, 22);
            this.txtHost.TabIndex = 0;
            // 
            // gbIP
            // 
            this.gbIP.Controls.Add(this.txtIpHost);
            this.gbIP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIP.Location = new System.Drawing.Point(14, 96);
            this.gbIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbIP.Name = "gbIP";
            this.gbIP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbIP.Size = new System.Drawing.Size(315, 63);
            this.gbIP.TabIndex = 1;
            this.gbIP.TabStop = false;
            this.gbIP.Text = "IP do Host ";
            // 
            // txtIpHost
            // 
            this.txtIpHost.Location = new System.Drawing.Point(7, 23);
            this.txtIpHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIpHost.Name = "txtIpHost";
            this.txtIpHost.ReadOnly = true;
            this.txtIpHost.Size = new System.Drawing.Size(300, 22);
            this.txtIpHost.TabIndex = 0;
            this.txtIpHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.txtStatus);
            this.gbStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(14, 180);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbStatus.Size = new System.Drawing.Size(315, 66);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status do Ping:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(7, 23);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(300, 22);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPing
            // 
            this.btnPing.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPing.Location = new System.Drawing.Point(14, 254);
            this.btnPing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(87, 37);
            this.btnPing.TabIndex = 3;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(128, 254);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 37);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(240, 254);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(87, 37);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desenvolvido por: Fábio Aragão";
            // 
            // frmPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbIP);
            this.Controls.Add(this.gpHost);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPing";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramenta de Ping";
            this.gpHost.ResumeLayout(false);
            this.gpHost.PerformLayout();
            this.gbIP.ResumeLayout(false);
            this.gbIP.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.GroupBox gbIP;
        private System.Windows.Forms.TextBox txtIpHost;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
    }
}

