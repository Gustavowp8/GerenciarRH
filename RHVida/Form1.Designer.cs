namespace RHVida
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
            this.teste = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefoneb = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lvlLista = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.brn_busca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teste
            // 
            this.teste.AutoSize = true;
            this.teste.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.teste.Location = new System.Drawing.Point(29, 31);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(142, 25);
            this.teste.TabIndex = 0;
            this.teste.Text = "Novo Contato";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 267);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(176, 23);
            this.txtTelefone.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-mail";
            // 
            // txtTelefoneb
            // 
            this.txtTelefoneb.AutoSize = true;
            this.txtTelefoneb.Location = new System.Drawing.Point(12, 249);
            this.txtTelefoneb.Name = "txtTelefoneb";
            this.txtTelefoneb.Size = new System.Drawing.Size(51, 15);
            this.txtTelefoneb.TabIndex = 6;
            this.txtTelefoneb.Text = "Telefone";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 343);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(176, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lvlLista
            // 
            this.lvlLista.Location = new System.Drawing.Point(204, 125);
            this.lvlLista.Name = "lvlLista";
            this.lvlLista.Size = new System.Drawing.Size(584, 241);
            this.lvlLista.TabIndex = 8;
            this.lvlLista.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(392, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar contato";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(204, 97);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(479, 23);
            this.txtBusca.TabIndex = 10;
            // 
            // brn_busca
            // 
            this.brn_busca.Location = new System.Drawing.Point(689, 97);
            this.brn_busca.Name = "brn_busca";
            this.brn_busca.Size = new System.Drawing.Size(99, 23);
            this.brn_busca.TabIndex = 11;
            this.brn_busca.Text = "Buscar";
            this.brn_busca.UseVisualStyleBackColor = true;
            this.brn_busca.Click += new System.EventHandler(this.brn_busca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.brn_busca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvlLista);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtTelefoneb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.teste);
            this.Name = "Form1";
            this.Text = "RHVida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label teste;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label txtTelefoneb;
        private Button btnSalvar;
        private ListView lvlLista;
        private Label label3;
        private TextBox txtBusca;
        private Button brn_busca;
    }
}