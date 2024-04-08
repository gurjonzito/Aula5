namespace Aula5
{
    partial class frmCadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProduto));
            this.labelCod = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.boxUn = new System.Windows.Forms.ComboBox();
            this.labelUn = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.Label();
            this.boxCat = new System.Windows.Forms.ComboBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelPrat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mskCod = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(23, 21);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(88, 13);
            this.labelCod.TabIndex = 1;
            this.labelCod.Text = "Código de Barras";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(23, 76);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(55, 13);
            this.labelDesc.TabIndex = 3;
            this.labelDesc.Text = "Descrição";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(23, 92);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(290, 45);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.Text = "";
            this.txtDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // boxUn
            // 
            this.boxUn.FormattingEnabled = true;
            this.boxUn.Items.AddRange(new object[] {
            "UN",
            "PC",
            "KG",
            "ML",
            "LT"});
            this.boxUn.Location = new System.Drawing.Point(23, 168);
            this.boxUn.Name = "boxUn";
            this.boxUn.Size = new System.Drawing.Size(121, 21);
            this.boxUn.TabIndex = 5;
            this.boxUn.Validating += new System.ComponentModel.CancelEventHandler(this.boxUn_Validating);
            // 
            // labelUn
            // 
            this.labelUn.AutoSize = true;
            this.labelUn.Location = new System.Drawing.Point(23, 152);
            this.labelUn.Name = "labelUn";
            this.labelUn.Size = new System.Drawing.Size(47, 13);
            this.labelUn.TabIndex = 6;
            this.labelUn.Text = "Unidade";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(164, 152);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(52, 13);
            this.labelCat.TabIndex = 8;
            this.labelCat.Text = "Categoria";
            // 
            // boxCat
            // 
            this.boxCat.FormattingEnabled = true;
            this.boxCat.Items.AddRange(new object[] {
            "BEBIDAS",
            "IOGURTES",
            "FARINHAS",
            "CONGELADOS"});
            this.boxCat.Location = new System.Drawing.Point(164, 168);
            this.boxCat.Name = "boxCat";
            this.boxCat.Size = new System.Drawing.Size(121, 21);
            this.boxCat.TabIndex = 7;
            this.boxCat.Validating += new System.ComponentModel.CancelEventHandler(this.boxCat_Validating);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(23, 206);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(79, 13);
            this.labelValor.TabIndex = 10;
            this.labelValor.Text = "Valor de venda";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(23, 222);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(104, 20);
            this.txtValor.TabIndex = 9;
            this.txtValor.Validating += new System.ComponentModel.CancelEventHandler(this.txtValor_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 282);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(104, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelPrat
            // 
            this.labelPrat.AutoSize = true;
            this.labelPrat.Location = new System.Drawing.Point(146, 206);
            this.labelPrat.Name = "labelPrat";
            this.labelPrat.Size = new System.Drawing.Size(51, 13);
            this.labelPrat.TabIndex = 14;
            this.labelPrat.Text = "Prateleira";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 13;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // mskCod
            // 
            this.mskCod.Location = new System.Drawing.Point(26, 38);
            this.mskCod.Name = "mskCod";
            this.mskCod.Size = new System.Drawing.Size(185, 20);
            this.mskCod.TabIndex = 15;
            this.mskCod.Validating += new System.ComponentModel.CancelEventHandler(this.mskCod_Validating);
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(349, 321);
            this.Controls.Add(this.mskCod);
            this.Controls.Add(this.labelPrat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.labelCat);
            this.Controls.Add(this.boxCat);
            this.Controls.Add(this.labelUn);
            this.Controls.Add(this.boxUn);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelCod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadProduto";
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.ComboBox boxUn;
        private System.Windows.Forms.Label labelUn;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.ComboBox boxCat;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelPrat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox mskCod;
    }
}