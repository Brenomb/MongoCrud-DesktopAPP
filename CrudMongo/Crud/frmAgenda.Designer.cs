namespace Crud
{
    partial class frmAgenda
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
            components = new System.ComponentModel.Container();
            bsAgenda = new BindingSource(components);
            dataGridView1 = new DataGridView();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enderecoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lblAgenda = new Label();
            btnNovo = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)bsAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bsAgenda
            // 
            bsAgenda.DataMember = "ListaAgenda";
            bsAgenda.DataSource = typeof(DAL.Repositorio);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, enderecoDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bsAgenda;
            dataGridView1.Location = new Point(24, 53);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(678, 376);
            dataGridView1.TabIndex = 0;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            enderecoDataGridViewTextBoxColumn.MinimumWidth = 6;
            enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            enderecoDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // lblAgenda
            // 
            lblAgenda.AutoSize = true;
            lblAgenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgenda.Location = new Point(258, 9);
            lblAgenda.Name = "lblAgenda";
            lblAgenda.Size = new Size(100, 31);
            lblAgenda.TabIndex = 1;
            lblAgenda.Text = "Agenda ";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(413, 464);
            btnNovo.Margin = new Padding(3, 4, 3, 4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(86, 31);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(505, 464);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 31);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(616, 464);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 537);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnNovo);
            Controls.Add(lblAgenda);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAgenda";
            Text = "Crud com Mongo";
            Load += frmAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)bsAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsAgenda;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private Label lblAgenda;
        private Button btnNovo;
        private Button btnExcluir;
        private Button btnEditar;
    }
}