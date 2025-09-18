namespace WFA25091801
{
    partial class FrmMuveletek
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
            txtElsoAdat = new TextBox();
            label1 = new Label();
            btnOsszeadas = new Button();
            txtmasodikAdat = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnKivonas = new Button();
            btnSzorzas = new Button();
            btnOsztas = new Button();
            label4 = new Label();
            lblEredmeny = new Label();
            SuspendLayout();
            // 
            // txtElsoAdat
            // 
            txtElsoAdat.Location = new Point(12, 57);
            txtElsoAdat.Name = "txtElsoAdat";
            txtElsoAdat.Size = new Size(85, 32);
            txtElsoAdat.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(381, 35);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 1;
            label1.Text = "eredmény";
            // 
            // btnOsszeadas
            // 
            btnOsszeadas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnOsszeadas.Location = new Point(121, 22);
            btnOsszeadas.Margin = new Padding(0);
            btnOsszeadas.Name = "btnOsszeadas";
            btnOsszeadas.Size = new Size(50, 50);
            btnOsszeadas.TabIndex = 2;
            btnOsszeadas.Text = "+";
            btnOsszeadas.UseVisualStyleBackColor = true;
            // 
            // txtmasodikAdat
            // 
            txtmasodikAdat.Location = new Point(243, 57);
            txtmasodikAdat.Name = "txtmasodikAdat";
            txtmasodikAdat.Size = new Size(90, 32);
            txtmasodikAdat.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 1;
            label2.Text = "1. op";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(243, 35);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 1;
            label3.Text = "2. op";
            // 
            // btnKivonas
            // 
            btnKivonas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnKivonas.Location = new Point(171, 22);
            btnKivonas.Margin = new Padding(0);
            btnKivonas.Name = "btnKivonas";
            btnKivonas.Size = new Size(50, 50);
            btnKivonas.TabIndex = 2;
            btnKivonas.Text = "-";
            btnKivonas.UseVisualStyleBackColor = true;
            // 
            // btnSzorzas
            // 
            btnSzorzas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnSzorzas.Location = new Point(121, 72);
            btnSzorzas.Margin = new Padding(0);
            btnSzorzas.Name = "btnSzorzas";
            btnSzorzas.Size = new Size(50, 50);
            btnSzorzas.TabIndex = 2;
            btnSzorzas.Text = "*";
            btnSzorzas.UseVisualStyleBackColor = true;
            // 
            // btnOsztas
            // 
            btnOsztas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnOsztas.Location = new Point(171, 72);
            btnOsztas.Margin = new Padding(0);
            btnOsztas.Name = "btnOsztas";
            btnOsztas.Size = new Size(50, 50);
            btnOsztas.TabIndex = 2;
            btnOsztas.Text = "/";
            btnOsztas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.Location = new Point(339, 50);
            label4.Name = "label4";
            label4.Size = new Size(36, 37);
            label4.TabIndex = 1;
            label4.Text = "=";
            // 
            // lblEredmeny
            // 
            lblEredmeny.BackColor = Color.White;
            lblEredmeny.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblEredmeny.Location = new Point(381, 60);
            lblEredmeny.Name = "lblEredmeny";
            lblEredmeny.Size = new Size(90, 32);
            lblEredmeny.TabIndex = 3;
            lblEredmeny.Text = "###";
            lblEredmeny.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMuveletek
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 139);
            Controls.Add(lblEredmeny);
            Controls.Add(btnOsztas);
            Controls.Add(btnKivonas);
            Controls.Add(btnSzorzas);
            Controls.Add(btnOsszeadas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtmasodikAdat);
            Controls.Add(txtElsoAdat);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmMuveletek";
            Text = "alapműveletek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtElsoAdat;
        private Label label1;
        private Button btnOsszeadas;
        private TextBox txtmasodikAdat;
        private Label label2;
        private Label label3;
        private Button btnKivonas;
        private Button btnSzorzas;
        private Button btnOsztas;
        private Label label4;
        private Label lblEredmeny;
    }
}
