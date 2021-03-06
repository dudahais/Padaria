
namespace Ibread
{
    partial class Pedido
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lTelefone = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.lCPF = new System.Windows.Forms.Label();
            this.lPaes = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbPaes = new System.Windows.Forms.TextBox();
            this.bInserir = new System.Windows.Forms.Button();
            this.lID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.bLimpar = new System.Windows.Forms.Button();
            this.cliente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_paes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Daybury", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.textBox1.Location = new System.Drawing.Point(31, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1175, 257);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Vendas!";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliente_id,
            this.cliente_nome,
            this.cliente_cpf,
            this.cliente_telefone,
            this.cliente_paes});
            this.dataGridView1.Location = new System.Drawing.Point(134, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(997, 420);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.Location = new System.Drawing.Point(150, 181);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(55, 20);
            this.lNome.TabIndex = 6;
            this.lNome.Text = "Nome:";
            this.lNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(207, 181);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(408, 26);
            this.tbNome.TabIndex = 7;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // lTelefone
            // 
            this.lTelefone.AutoSize = true;
            this.lTelefone.Location = new System.Drawing.Point(130, 244);
            this.lTelefone.Name = "lTelefone";
            this.lTelefone.Size = new System.Drawing.Size(75, 20);
            this.lTelefone.TabIndex = 8;
            this.lTelefone.Text = "Telefone:";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(207, 244);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(408, 26);
            this.tbTelefone.TabIndex = 9;
            // 
            // lCPF
            // 
            this.lCPF.AutoSize = true;
            this.lCPF.Location = new System.Drawing.Point(734, 181);
            this.lCPF.Name = "lCPF";
            this.lCPF.Size = new System.Drawing.Size(40, 20);
            this.lCPF.TabIndex = 10;
            this.lCPF.Text = "CPF";
            this.lCPF.Click += new System.EventHandler(this.label3_Click);
            // 
            // lPaes
            // 
            this.lPaes.AutoSize = true;
            this.lPaes.Location = new System.Drawing.Point(630, 247);
            this.lPaes.Name = "lPaes";
            this.lPaes.Size = new System.Drawing.Size(157, 20);
            this.lPaes.TabIndex = 11;
            this.lPaes.Text = "Quantidade de pães:";
            this.lPaes.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(793, 175);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(310, 26);
            this.tbCPF.TabIndex = 12;
            this.tbCPF.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbPaes
            // 
            this.tbPaes.Location = new System.Drawing.Point(793, 244);
            this.tbPaes.Name = "tbPaes";
            this.tbPaes.Size = new System.Drawing.Size(113, 26);
            this.tbPaes.TabIndex = 13;
            // 
            // bInserir
            // 
            this.bInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInserir.Font = new System.Drawing.Font("Arial", 9.75F);
            this.bInserir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.bInserir.Location = new System.Drawing.Point(154, 326);
            this.bInserir.Name = "bInserir";
            this.bInserir.Size = new System.Drawing.Size(194, 45);
            this.bInserir.TabIndex = 14;
            this.bInserir.Text = "Inserir";
            this.bInserir.UseVisualStyleBackColor = true;
            this.bInserir.Click += new System.EventHandler(this.bInserir_Click);
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(150, 137);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(26, 20);
            this.lID.TabIndex = 16;
            this.lID.Text = "ID";
            this.lID.Visible = false;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(207, 134);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(79, 26);
            this.tbID.TabIndex = 17;
            this.tbID.Visible = false;
            // 
            // bLimpar
            // 
            this.bLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLimpar.Font = new System.Drawing.Font("Arial", 9.75F);
            this.bLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.bLimpar.Location = new System.Drawing.Point(366, 326);
            this.bLimpar.Name = "bLimpar";
            this.bLimpar.Size = new System.Drawing.Size(194, 45);
            this.bLimpar.TabIndex = 18;
            this.bLimpar.Text = "Limpar";
            this.bLimpar.UseVisualStyleBackColor = true;
            this.bLimpar.Click += new System.EventHandler(this.bLimpar_Click_1);
            // 
            // cliente_id
            // 
            this.cliente_id.FillWeight = 12F;
            this.cliente_id.HeaderText = "ID";
            this.cliente_id.MinimumWidth = 8;
            this.cliente_id.Name = "cliente_id";
            this.cliente_id.Width = 30;
            // 
            // cliente_nome
            // 
            this.cliente_nome.HeaderText = "Nome";
            this.cliente_nome.MinimumWidth = 8;
            this.cliente_nome.Name = "cliente_nome";
            this.cliente_nome.Width = 160;
            // 
            // cliente_cpf
            // 
            this.cliente_cpf.HeaderText = "CPF";
            this.cliente_cpf.MinimumWidth = 8;
            this.cliente_cpf.Name = "cliente_cpf";
            this.cliente_cpf.Width = 140;
            // 
            // cliente_telefone
            // 
            this.cliente_telefone.HeaderText = "Telefone";
            this.cliente_telefone.MinimumWidth = 8;
            this.cliente_telefone.Name = "cliente_telefone";
            this.cliente_telefone.Width = 140;
            // 
            // cliente_paes
            // 
            this.cliente_paes.HeaderText = "Quantidade de pães";
            this.cliente_paes.MinimumWidth = 8;
            this.cliente_paes.Name = "cliente_paes";
            this.cliente_paes.Width = 130;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.bLimpar);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lID);
            this.Controls.Add(this.bInserir);
            this.Controls.Add(this.tbPaes);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.lPaes);
            this.Controls.Add(this.lCPF);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.lTelefone);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lNome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pedido";
            this.Size = new System.Drawing.Size(1432, 1077);
            this.Load += new System.EventHandler(this.Pedido_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lTelefone;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label lCPF;
        private System.Windows.Forms.Label lPaes;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbPaes;
        private System.Windows.Forms.Button bInserir;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button bLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_paes;
    }
}
