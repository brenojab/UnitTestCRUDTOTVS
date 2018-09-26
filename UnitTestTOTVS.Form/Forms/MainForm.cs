using System;
using System.Windows.Forms;
using UnitTestTOTVS.Data;
using UnitTestTOTVS.Data.Models;
using UnitTestTOTVS.Server;

namespace UnitTestCRUDTOTVS
{
  public partial class MainForm : Form
  {
    public MainForm()
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

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        Esportista esportista = new Esportista()
        {
          Id = Guid.Parse(txtGuid.Text),
          Nome = txtNome.Text,
          Peso = numPeso.Value,
          Altura = numAltura.Value,
          PraticaEsportes = chkPraticaEsportes.Checked,
          QuantidadeVezesSemana = (int)numFrequencia.Value
        };

        string motivo = string.Empty;

        if (Server.Salvar(esportista, ref motivo))
        {
          MessageBox.Show("Registro salvo!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
          RefreshGrid();
          CleanFields();
        }
        else
        {
          MessageBox.Show($"Esportista não válido! >> {Environment.NewLine} {motivo}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void CleanFields()
    {
      txtGuid.Text = txtNome.Text = string.Empty;
      numPeso.Value = numAltura.Value = numFrequencia.Value = 0m;
      chkPraticaEsportes.Checked = false;
    }

    private void RefreshGrid()
    {
      dgvView.DataSource = Server.DataAccess.DeserializeJson();
    }

    private void btnRandGuid_Click(object sender, EventArgs e)
    {
      txtGuid.Text = Guid.NewGuid().ToString();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      this.ActiveControl = txtGuid;

      RefreshGrid();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      if (dgvView.SelectedCells.Count > 0)
      {
        int selectedrowindex = dgvView.SelectedCells[0].RowIndex;

        DataGridViewRow selectedRow = dgvView.Rows[selectedrowindex];

        string id = Convert.ToString(selectedRow.Cells["Id"].Value);

        var registro = Server.DataAccess.RetornaRegistro(Guid.Parse(id));

        if (registro != null)
        {
          PreencheDadosFormulario(registro);
        }
        else
        {
          if (MessageBox.Show("O registro em questão não existe no banco. Deseja incluir?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          {
            btnSave_Click(sender, e);
          }
        }
      }
      else
      {
        MessageBox.Show("Favor selecionar o registro a editar na grid!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      if (dgvView.SelectedCells.Count > 0)
      {
        int selectedrowindex = dgvView.SelectedCells[0].RowIndex;

        DataGridViewRow selectedRow = dgvView.Rows[selectedrowindex];

        string id = Convert.ToString(selectedRow.Cells["Id"].Value);

        var registro = Server.DataAccess.RetornaRegistro(Guid.Parse(id));

        if (registro != null)
        {
          if (MessageBox.Show("Deseja excluir o registro selecionado?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
          {
            Server.DataAccess.RemoveRegistro(registro);
          }
        }
      }
      else
      {
        MessageBox.Show("Favor selecionar o registro a editar na grid!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }

      RefreshGrid();
    }

    private void chkPraticaEsportes_CheckedChanged(object sender, EventArgs e)
    {
      numFrequencia.Enabled = chkPraticaEsportes.Checked;
    }

    private void btnConsultar_Click(object sender, EventArgs e)
    {
      using (ConsultaForm consultaForm = new ConsultaForm())
      {
        consultaForm.ShowDialog();

        if (consultaForm.DialogResult == DialogResult.OK)
          PreencheDadosFormulario(consultaForm.Esportista);
      }
    }

    private void PreencheDadosFormulario(Esportista esportista)
    {
      if (esportista != null)
      {
        txtGuid.Text = esportista.Id.ToString();
        txtNome.Text = esportista.Nome;
        numPeso.Value = esportista.Peso;
        numAltura.Value = esportista.Altura;
        chkPraticaEsportes.Checked = esportista.PraticaEsportes;
        numFrequencia.Value = esportista.QuantidadeVezesSemana;
      }
    }

    private void btnGerarDadosAletarórios_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Tem certeza que deseja gerar dados aleatórios?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        foreach (Esportista esportista in DataServices.GenerateListEsportistas())
        {
          Server.DataAccess.Save(esportista);
        }
      }

      RefreshGrid();
    }
  }
}
