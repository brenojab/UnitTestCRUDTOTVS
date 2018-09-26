using System;
using System.Windows.Forms;
using UnitTestTOTVS.Data.Models;
using UnitTestTOTVS.Server;

namespace UnitTestCRUDTOTVS
{
  public partial class ConsultaForm : Form
  {
    public ConsultaForm()
    {
      InitializeComponent();
    }

    private Business _server;

    public Business Server
    {
      get
      {
        if (_server == null)
          _server = new Business();

        return _server;
      }
    }

    public Esportista Esportista { get; set; }

    private void btnConsultar_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtGuidConsulta.Text))
        return;

      try
      {

        Esportista = Server.DataAccess.RetornaRegistro(Guid.Parse(txtGuidConsulta.Text));

        if (Esportista != null)
        {
          this.DialogResult = DialogResult.OK;
          this.Close();
        }
        else
        {
          MessageBox.Show("Registro não encontrado!");
        }
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void ConsultaForm_Load(object sender, EventArgs e)
    {
      this.ActiveControl = txtGuidConsulta;
    }
  }
}
