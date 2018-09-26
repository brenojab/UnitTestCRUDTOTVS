namespace UnitTestCRUDTOTVS
{
  partial class ConsultaForm
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
      this.btnConsultar = new System.Windows.Forms.Button();
      this.txtGuidConsulta = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnConsultar
      // 
      this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConsultar.Location = new System.Drawing.Point(170, 89);
      this.btnConsultar.Name = "btnConsultar";
      this.btnConsultar.Size = new System.Drawing.Size(105, 32);
      this.btnConsultar.TabIndex = 0;
      this.btnConsultar.Text = "Consultar";
      this.btnConsultar.UseVisualStyleBackColor = true;
      this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
      // 
      // txtGuidConsulta
      // 
      this.txtGuidConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtGuidConsulta.Location = new System.Drawing.Point(12, 48);
      this.txtGuidConsulta.Name = "txtGuidConsulta";
      this.txtGuidConsulta.Size = new System.Drawing.Size(425, 26);
      this.txtGuidConsulta.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(61, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(308, 17);
      this.label1.TabIndex = 3;
      this.label1.Text = "Favor digitar o GUID do registro para consultar:";
      // 
      // ConsultaForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(466, 144);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtGuidConsulta);
      this.Controls.Add(this.btnConsultar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "ConsultaForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consulta de registros";
      this.Load += new System.EventHandler(this.ConsultaForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnConsultar;
    private System.Windows.Forms.TextBox txtGuidConsulta;
    private System.Windows.Forms.Label label1;
  }
}