namespace UnitTestCRUDTOTVS
{
  partial class MainForm
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
      this.btnIncluir = new System.Windows.Forms.Button();
      this.tbcPrincipal = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.grpMain = new System.Windows.Forms.GroupBox();
      this.btnGerarDadosAletarórios = new System.Windows.Forms.Button();
      this.grpFrequencia = new System.Windows.Forms.GroupBox();
      this.chkPraticaEsportes = new System.Windows.Forms.CheckBox();
      this.lblFrequencia = new System.Windows.Forms.Label();
      this.numFrequencia = new System.Windows.Forms.NumericUpDown();
      this.numAltura = new System.Windows.Forms.NumericUpDown();
      this.numPeso = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.btnRandGuid = new System.Windows.Forms.Button();
      this.txtGuid = new System.Windows.Forms.TextBox();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.lblNome = new System.Windows.Forms.Label();
      this.lblAltura = new System.Windows.Forms.Label();
      this.lblPeso = new System.Windows.Forms.Label();
      this.dgvView = new System.Windows.Forms.DataGridView();
      this.btnEditar = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnConsultar = new System.Windows.Forms.Button();
      this.tbcPrincipal.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.grpMain.SuspendLayout();
      this.grpFrequencia.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numFrequencia)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numAltura)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
      this.SuspendLayout();
      // 
      // btnIncluir
      // 
      this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnIncluir.Location = new System.Drawing.Point(12, 415);
      this.btnIncluir.Name = "btnIncluir";
      this.btnIncluir.Size = new System.Drawing.Size(106, 23);
      this.btnIncluir.TabIndex = 7;
      this.btnIncluir.Text = "&Incluir / Salvar";
      this.btnIncluir.UseVisualStyleBackColor = true;
      this.btnIncluir.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // tbcPrincipal
      // 
      this.tbcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbcPrincipal.Controls.Add(this.tabPage1);
      this.tbcPrincipal.Location = new System.Drawing.Point(0, 0);
      this.tbcPrincipal.Name = "tbcPrincipal";
      this.tbcPrincipal.SelectedIndex = 0;
      this.tbcPrincipal.Size = new System.Drawing.Size(923, 409);
      this.tbcPrincipal.TabIndex = 21;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.grpMain);
      this.tabPage1.Controls.Add(this.dgvView);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(915, 383);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Principal";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // grpMain
      // 
      this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.grpMain.Controls.Add(this.btnGerarDadosAletarórios);
      this.grpMain.Controls.Add(this.grpFrequencia);
      this.grpMain.Controls.Add(this.numAltura);
      this.grpMain.Controls.Add(this.numPeso);
      this.grpMain.Controls.Add(this.label1);
      this.grpMain.Controls.Add(this.btnRandGuid);
      this.grpMain.Controls.Add(this.txtGuid);
      this.grpMain.Controls.Add(this.txtNome);
      this.grpMain.Controls.Add(this.lblNome);
      this.grpMain.Controls.Add(this.lblAltura);
      this.grpMain.Controls.Add(this.lblPeso);
      this.grpMain.Location = new System.Drawing.Point(6, 7);
      this.grpMain.Name = "grpMain";
      this.grpMain.Size = new System.Drawing.Size(273, 370);
      this.grpMain.TabIndex = 20;
      this.grpMain.TabStop = false;
      this.grpMain.Text = "Principal";
      // 
      // btnGerarDadosAletarórios
      // 
      this.btnGerarDadosAletarórios.Location = new System.Drawing.Point(156, 19);
      this.btnGerarDadosAletarórios.Name = "btnGerarDadosAletarórios";
      this.btnGerarDadosAletarórios.Size = new System.Drawing.Size(98, 23);
      this.btnGerarDadosAletarórios.TabIndex = 21;
      this.btnGerarDadosAletarórios.Tag = "Gera dados aleatórios";
      this.btnGerarDadosAletarórios.Text = "Gerar dados";
      this.btnGerarDadosAletarórios.UseVisualStyleBackColor = true;
      this.btnGerarDadosAletarórios.Click += new System.EventHandler(this.btnGerarDadosAletarórios_Click);
      // 
      // grpFrequencia
      // 
      this.grpFrequencia.Controls.Add(this.chkPraticaEsportes);
      this.grpFrequencia.Controls.Add(this.lblFrequencia);
      this.grpFrequencia.Controls.Add(this.numFrequencia);
      this.grpFrequencia.Location = new System.Drawing.Point(16, 211);
      this.grpFrequencia.Name = "grpFrequencia";
      this.grpFrequencia.Size = new System.Drawing.Size(181, 100);
      this.grpFrequencia.TabIndex = 20;
      this.grpFrequencia.TabStop = false;
      this.grpFrequencia.Text = "Prática de esportes";
      // 
      // chkPraticaEsportes
      // 
      this.chkPraticaEsportes.AutoSize = true;
      this.chkPraticaEsportes.Location = new System.Drawing.Point(17, 22);
      this.chkPraticaEsportes.Name = "chkPraticaEsportes";
      this.chkPraticaEsportes.Size = new System.Drawing.Size(108, 17);
      this.chkPraticaEsportes.TabIndex = 5;
      this.chkPraticaEsportes.Text = "Pratica esportes?";
      this.chkPraticaEsportes.UseVisualStyleBackColor = true;
      this.chkPraticaEsportes.CheckedChanged += new System.EventHandler(this.chkPraticaEsportes_CheckedChanged);
      // 
      // lblFrequencia
      // 
      this.lblFrequencia.AutoSize = true;
      this.lblFrequencia.Location = new System.Drawing.Point(14, 45);
      this.lblFrequencia.Name = "lblFrequencia";
      this.lblFrequencia.Size = new System.Drawing.Size(105, 13);
      this.lblFrequencia.TabIndex = 14;
      this.lblFrequencia.Text = "Frequência semanal:";
      // 
      // numFrequencia
      // 
      this.numFrequencia.Enabled = false;
      this.numFrequencia.Location = new System.Drawing.Point(14, 61);
      this.numFrequencia.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
      this.numFrequencia.Name = "numFrequencia";
      this.numFrequencia.Size = new System.Drawing.Size(78, 20);
      this.numFrequencia.TabIndex = 6;
      // 
      // numAltura
      // 
      this.numAltura.DecimalPlaces = 2;
      this.numAltura.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.numAltura.Location = new System.Drawing.Point(16, 185);
      this.numAltura.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            65536});
      this.numAltura.Name = "numAltura";
      this.numAltura.Size = new System.Drawing.Size(92, 20);
      this.numAltura.TabIndex = 4;
      // 
      // numPeso
      // 
      this.numPeso.DecimalPlaces = 1;
      this.numPeso.Location = new System.Drawing.Point(16, 146);
      this.numPeso.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
      this.numPeso.Name = "numPeso";
      this.numPeso.Size = new System.Drawing.Size(90, 20);
      this.numPeso.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 45);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Guid:";
      // 
      // btnRandGuid
      // 
      this.btnRandGuid.Location = new System.Drawing.Point(16, 19);
      this.btnRandGuid.Name = "btnRandGuid";
      this.btnRandGuid.Size = new System.Drawing.Size(134, 23);
      this.btnRandGuid.TabIndex = 0;
      this.btnRandGuid.Text = "Gerar GUID randômico";
      this.btnRandGuid.UseVisualStyleBackColor = true;
      this.btnRandGuid.Click += new System.EventHandler(this.btnRandGuid_Click);
      // 
      // txtGuid
      // 
      this.txtGuid.Location = new System.Drawing.Point(16, 61);
      this.txtGuid.Name = "txtGuid";
      this.txtGuid.Size = new System.Drawing.Size(238, 20);
      this.txtGuid.TabIndex = 1;
      // 
      // txtNome
      // 
      this.txtNome.Location = new System.Drawing.Point(16, 107);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(238, 20);
      this.txtNome.TabIndex = 2;
      // 
      // lblNome
      // 
      this.lblNome.AutoSize = true;
      this.lblNome.Location = new System.Drawing.Point(13, 91);
      this.lblNome.Name = "lblNome";
      this.lblNome.Size = new System.Drawing.Size(38, 13);
      this.lblNome.TabIndex = 6;
      this.lblNome.Text = "Nome:";
      // 
      // lblAltura
      // 
      this.lblAltura.AutoSize = true;
      this.lblAltura.Location = new System.Drawing.Point(13, 169);
      this.lblAltura.Name = "lblAltura";
      this.lblAltura.Size = new System.Drawing.Size(37, 13);
      this.lblAltura.TabIndex = 10;
      this.lblAltura.Text = "Altura:";
      // 
      // lblPeso
      // 
      this.lblPeso.AutoSize = true;
      this.lblPeso.Location = new System.Drawing.Point(13, 130);
      this.lblPeso.Name = "lblPeso";
      this.lblPeso.Size = new System.Drawing.Size(34, 13);
      this.lblPeso.TabIndex = 8;
      this.lblPeso.Text = "Peso:";
      // 
      // dgvView
      // 
      this.dgvView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvView.Location = new System.Drawing.Point(285, 7);
      this.dgvView.Name = "dgvView";
      this.dgvView.RowHeadersVisible = false;
      this.dgvView.Size = new System.Drawing.Size(622, 370);
      this.dgvView.TabIndex = 19;
      // 
      // btnEditar
      // 
      this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnEditar.Location = new System.Drawing.Point(124, 415);
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Size = new System.Drawing.Size(106, 23);
      this.btnEditar.TabIndex = 8;
      this.btnEditar.Text = "&Editar";
      this.btnEditar.UseVisualStyleBackColor = true;
      this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
      // 
      // btnExcluir
      // 
      this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnExcluir.Location = new System.Drawing.Point(236, 415);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(103, 23);
      this.btnExcluir.TabIndex = 9;
      this.btnExcluir.Text = "E&xcluir";
      this.btnExcluir.UseVisualStyleBackColor = true;
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // btnConsultar
      // 
      this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnConsultar.Location = new System.Drawing.Point(345, 415);
      this.btnConsultar.Name = "btnConsultar";
      this.btnConsultar.Size = new System.Drawing.Size(101, 23);
      this.btnConsultar.TabIndex = 10;
      this.btnConsultar.Text = "Consultar";
      this.btnConsultar.UseVisualStyleBackColor = true;
      this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(923, 450);
      this.Controls.Add(this.btnConsultar);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnEditar);
      this.Controls.Add(this.tbcPrincipal);
      this.Controls.Add(this.btnIncluir);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Unit Test CRUD TOTVS - Breno Batista";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.tbcPrincipal.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.grpMain.ResumeLayout(false);
      this.grpMain.PerformLayout();
      this.grpFrequencia.ResumeLayout(false);
      this.grpFrequencia.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numFrequencia)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numAltura)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button btnIncluir;
    private System.Windows.Forms.TabControl tbcPrincipal;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.GroupBox grpMain;
    private System.Windows.Forms.GroupBox grpFrequencia;
    private System.Windows.Forms.CheckBox chkPraticaEsportes;
    private System.Windows.Forms.Label lblFrequencia;
    private System.Windows.Forms.NumericUpDown numFrequencia;
    private System.Windows.Forms.NumericUpDown numAltura;
    private System.Windows.Forms.NumericUpDown numPeso;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnRandGuid;
    private System.Windows.Forms.TextBox txtGuid;
    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.Label lblAltura;
    private System.Windows.Forms.Label lblPeso;
    private System.Windows.Forms.DataGridView dgvView;
    private System.Windows.Forms.Button btnEditar;
    private System.Windows.Forms.Button btnExcluir;
    private System.Windows.Forms.Button btnConsultar;
    private System.Windows.Forms.Button btnGerarDadosAletarórios;
  }
}

