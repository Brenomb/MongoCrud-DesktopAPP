namespace Crud
{
    partial class frmDetalhe
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
            components = new System.ComponentModel.Container();
            bsDetalhe = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            btnCancelar = new Button();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)bsDetalhe).BeginInit();
            SuspendLayout();
            // 
            // bsDetalhe
            // 
            bsDetalhe.DataSource = typeof(DAL.Agenda);
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bsDetalhe, "Nome", true));
            textBox1.Location = new Point(14, 79);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 48);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 131);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Endereco";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bsDetalhe, "Endereco", true));
            textBox2.Location = new Point(14, 161);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(353, 27);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 227);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Telefone";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bsDetalhe, "Telefone", true));
            textBox3.Location = new Point(21, 251);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 27);
            textBox3.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(233, 333);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(74, 40);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(314, 333);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(74, 40);
            btnOk.TabIndex = 7;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // frmDetalhe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 404);
            Controls.Add(btnOk);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDetalhe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalhe";
            Load += frmDetalhe_Load;
            ((System.ComponentModel.ISupportInitialize)bsDetalhe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsDetalhe;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button btnCancelar;
        private Button btnOk;
    }
}