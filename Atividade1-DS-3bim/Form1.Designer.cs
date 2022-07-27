namespace Atividade1_DS_3bim
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(152, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso:";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(152, 69);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(272, 20);
            this.txtCurso.TabIndex = 3;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(152, 123);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(101, 40);
            this.btnIncluir.TabIndex = 4;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(323, 123);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(101, 40);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Curso});
            this.dgvAlunos.Location = new System.Drawing.Point(80, 199);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(454, 167);
            this.dgvAlunos.TabIndex = 6;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alterar Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(441, 399);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 22);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(441, 440);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(93, 53);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar Sistema";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(331, 440);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(93, 53);
            this.btnTodos.TabIndex = 11;
            this.btnTodos.Text = "Excluir Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(77, 460);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 13);
            this.label.TabIndex = 12;
            this.label.Text = "Total de Alunos:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(218, 460);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 548);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblTotal;
    }
}

