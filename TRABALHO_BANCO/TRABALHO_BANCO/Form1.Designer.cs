namespace TRABALHO_BANCO
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.btInserir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cLIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLINOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLICPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLITELEFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRABALHO_BANCODataSet = new TRABALHO_BANCO.TRABALHO_BANCODataSet();
            this.cLIENTETableAdapter = new TRABALHO_BANCO.TRABALHO_BANCODataSetTableAdapters.CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHO_BANCODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(91, 26);
            this.txName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(147, 22);
            this.txName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone:";
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.Location = new System.Drawing.Point(105, 74);
            this.mtxTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxTelefone.Mask = "(00) 00000-0000";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(132, 22);
            this.mtxTelefone.TabIndex = 4;
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(91, 123);
            this.mtxCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxCPF.Mask = "000,000,000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(147, 22);
            this.mtxCPF.TabIndex = 5;
            this.mtxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxCPF_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(105, 167);
            this.txEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(132, 22);
            this.txEmail.TabIndex = 7;
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(331, 23);
            this.btInserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(100, 28);
            this.btInserir.TabIndex = 8;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(331, 70);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(100, 28);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(331, 164);
            this.btDeletar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(100, 28);
            this.btDeletar.TabIndex = 10;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(331, 119);
            this.btConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(100, 28);
            this.btConsultar.TabIndex = 11;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIIDDataGridViewTextBoxColumn,
            this.cLINOMEDataGridViewTextBoxColumn,
            this.cLICPFDataGridViewTextBoxColumn,
            this.cLITELEFONEDataGridViewTextBoxColumn,
            this.cLIEMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(105, 276);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(879, 230);
            this.dataGridView1.TabIndex = 12;
            // 
            // cLIIDDataGridViewTextBoxColumn
            // 
            this.cLIIDDataGridViewTextBoxColumn.DataPropertyName = "CLI_ID";
            this.cLIIDDataGridViewTextBoxColumn.HeaderText = "CLI_ID";
            this.cLIIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cLIIDDataGridViewTextBoxColumn.Name = "cLIIDDataGridViewTextBoxColumn";
            this.cLIIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // cLINOMEDataGridViewTextBoxColumn
            // 
            this.cLINOMEDataGridViewTextBoxColumn.DataPropertyName = "CLI_NOME";
            this.cLINOMEDataGridViewTextBoxColumn.HeaderText = "CLI_NOME";
            this.cLINOMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cLINOMEDataGridViewTextBoxColumn.Name = "cLINOMEDataGridViewTextBoxColumn";
            this.cLINOMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cLICPFDataGridViewTextBoxColumn
            // 
            this.cLICPFDataGridViewTextBoxColumn.DataPropertyName = "CLI_CPF";
            this.cLICPFDataGridViewTextBoxColumn.HeaderText = "CLI_CPF";
            this.cLICPFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cLICPFDataGridViewTextBoxColumn.Name = "cLICPFDataGridViewTextBoxColumn";
            this.cLICPFDataGridViewTextBoxColumn.Width = 125;
            // 
            // cLITELEFONEDataGridViewTextBoxColumn
            // 
            this.cLITELEFONEDataGridViewTextBoxColumn.DataPropertyName = "CLI_TELEFONE";
            this.cLITELEFONEDataGridViewTextBoxColumn.HeaderText = "CLI_TELEFONE";
            this.cLITELEFONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cLITELEFONEDataGridViewTextBoxColumn.Name = "cLITELEFONEDataGridViewTextBoxColumn";
            this.cLITELEFONEDataGridViewTextBoxColumn.Width = 120;
            // 
            // cLIEMAILDataGridViewTextBoxColumn
            // 
            this.cLIEMAILDataGridViewTextBoxColumn.DataPropertyName = "CLI_EMAIL";
            this.cLIEMAILDataGridViewTextBoxColumn.HeaderText = "CLI_EMAIL";
            this.cLIEMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cLIEMAILDataGridViewTextBoxColumn.Name = "cLIEMAILDataGridViewTextBoxColumn";
            this.cLIEMAILDataGridViewTextBoxColumn.Width = 150;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.tRABALHO_BANCODataSet;
            // 
            // tRABALHO_BANCODataSet
            // 
            this.tRABALHO_BANCODataSet.DataSetName = "TRABALHO_BANCODataSet";
            this.tRABALHO_BANCODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxCPF);
            this.Controls.Add(this.mtxTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHO_BANCODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TRABALHO_BANCODataSet tRABALHO_BANCODataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private TRABALHO_BANCODataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLINOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLICPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLITELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIEMAILDataGridViewTextBoxColumn;
    }
}

