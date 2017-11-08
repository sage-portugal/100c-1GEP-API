using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ApiSalariosCSharp
{
  /// <summary>
  /// Summary description for ShowErrors.
  /// </summary>
  public class ShowErrors : System.Windows.Forms.Form
  {
   public System.Windows.Forms.DataGridView grMessages;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    public ShowErrors()
    {
      // Required for Windows Form Designer support
      InitializeComponent();
      Load += new EventHandler(ShowErrors_Load);

      // TODO: Add any constructor code after InitializeComponent call
    }
    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if (components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose( disposing );
    }
    #region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    /// 


    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowErrors));
            this.grMessages = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // grMessages
            // 
            this.grMessages.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grMessages.Location = new System.Drawing.Point(0, 0);
            this.grMessages.Name = "grMessages";
            this.grMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grMessages.Size = new System.Drawing.Size(1000, 600);
            this.grMessages.TabIndex = 0;
            // 
            // ShowErrors
            // 
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.grMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowErrors";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.grMessages)).EndInit();
            this.ResumeLayout(false);

    }
    #endregion

        public  Boolean IsErrorMessage;


        private void ShowErrors_Load(object sender, EventArgs e)
        {
            grMessages.ColumnCount = 2;
            grMessages.Columns[0].Name = "ID";
            grMessages.Columns[1].Name = "Message";

            grMessages.Columns[0].HeaderText = grMessages.Columns[0].Name;
            grMessages.Columns[1].HeaderText = grMessages.Columns[1].Name;

            grMessages.Columns[0].Width = 75;
            grMessages.Columns[1].Width = 870;

            grMessages.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grMessages.Columns["Message"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if ( IsErrorMessage ){
                F_ReadErrors();
            }
            else
            {
                F_ReadWarning();
            }
        }
        private void F_ReadErrors()
        {
            grMessages.Rows.Add("","1. Initialize");
            F_InitializeCell ();
            grMessages.Rows.Add("-100", "Erro na inicialização. Verifique o registo do componente Sage.1GEP.10.dll");
            grMessages.Rows.Add("-102", "A aplicação 1GEP não é reconhecida. A aplicação não está instalada corretamente");
            grMessages.Rows.Add("-103", "Não foi encontrado o percurso dos ficheiros comuns. Verifique a existência da pasta ProgramData\\Sage\\2070\\Business\\");
            grMessages.Rows.Add("-104", "Não foi possível ligar aos recursos da aplicação (Ligar2)");
            grMessages.Rows.Add("-105", "Não foi possível inicializar o contexto");
            grMessages.Rows.Add("-106", "Aplicação não licenciada");
            grMessages.Rows.Add("-107", "Serviço inativo");
            grMessages.Rows.Add("-108", "Aplicação sem módulo L - API (Application Programming Interface)");

            grMessages.Rows.Add("", "2. Connect");
            F_InitializeCell ();
            grMessages.Rows.Add ("-201", "A empresa não está preenchida");
            grMessages.Rows.Add ("-202", "A empresa não existe ou não está registada");
            grMessages.Rows.Add ("-203", "O utilizador não tem acesso á empresa");
            grMessages.Rows.Add ("-204", "A empresa não está registada como Sage Salários");
            grMessages.Rows.Add ("-205", "Impossível abrir a base de dados, utilizador em uso");
            grMessages.Rows.Add ("-220", "Funcionário sem férias no ano selecionado");

            grMessages.Rows.Add ("","3. Employees");
            F_InitializeCell ();
            grMessages.Rows.Add ("-301", "Não existem funcionários na empresa");
            grMessages.Rows.Add ("-302", "Erro ao ler a tabela de funcionários");

            grMessages.Rows.Add ("", "4. Salary Types");
            F_InitializeCell ();

            grMessages.Rows.Add ( "-401", "Não existem códigos de remuneração na empresa");
            grMessages.Rows.Add ( "-402", "Erro ao ler a tabela de códigos de remuneração");

            grMessages.Rows.Add ("", "5. Insert work detail");
            F_InitializeCell ();

            grMessages.Rows.Add ("-501" , "[WorkDetail] Não existe");
            grMessages.Rows.Add ("-502" , "[Employee] Não existe");
            grMessages.Rows.Add ("-503" , "[SalaryType] Não existe");
            grMessages.Rows.Add ("-504" , "Data da alteração inválida (formato DD-MM-YYYY)");
            grMessages.Rows.Add ("-505" , "O funcionário não existe");
            grMessages.Rows.Add ("-506", "O funcionário encontra-se demitido. Não é possível introduzir faltas ou horas suplementares");
            grMessages.Rows.Add ("-507", "Não pode lanáar faltas de subsúdio de alimentação a funcionários que não recebem subsúdio de alimentação");
            grMessages.Rows.Add ("-508", "A data da alteração não pode ser inferior á data de admissão");
            grMessages.Rows.Add ("-509", "O código de remuneração não existe");
            grMessages.Rows.Add ("-510", "Não pode introduzir faltas cujo o modo de introdução é intervalo de dias ou horas");
            grMessages.Rows.Add ("-520", "A quantidade e o valor estáo a nulo");
            grMessages.Rows.Add ("-521", "A hora inicial está preenchida mas a hora final não está");
            grMessages.Rows.Add ("-522", "A hora final está preenchida mas a hora inicial não está");
            grMessages.Rows.Add ("-523", "Hora inicial inválida (formato HH:SS)");
            grMessages.Rows.Add ("-524", "Hora final inválida (formato HH:SS)");
            grMessages.Rows.Add ("-525", "A hora final não pode ser inferior á hora inicial");
            grMessages.Rows.Add ("-526", "A data inicial está preenchida mas a data final não está");
            grMessages.Rows.Add ("-527", "A data final está preenchida mas a data inicial não está");
            grMessages.Rows.Add ("-528", "A data inicial inválida (formato DD-MM-YYYY)");
            grMessages.Rows.Add ("-529", "A data final inválida (formato DD-MM-YYYY)");
            grMessages.Rows.Add ("-530", "A data final não pode ser inferior á data inicial");
            grMessages.Rows.Add ("-531", "Os códigos de remuneração tipificados como abonos devem ter um valor");
            grMessages.Rows.Add ("-532", "A quantidade não pode ser negativa");
            grMessages.Rows.Add ("-533", "A quantidade não pode ser superior a 999999");
            grMessages.Rows.Add ("-534", "os comentários não podem ter mais de que 50 carateres");

            grMessages.Rows.Add ("-601", "Número de dias a descontar ao vencimento (campo nº de dias) é inconsistente com o nr. de dias indicados no detalhe da falta");
            grMessages.Rows.Add ("-602", "Número de horas a descontar ao vencimento (campo nº de horas) é inconsistente com o nr. de horas de ausência no período normal de trabalho indicadas no detalhe da falta");
            grMessages.Rows.Add ("-603", "Não pode registar mais faltas! Atingiu o limite máximo de horas/dias úteis de falta no mês da alteração");
            grMessages.Rows.Add ("-604", "Não pode registar uma falta ultrapassando o limite máximo de horas/dias úteis do mês da alteração");
            grMessages.Rows.Add ("-605", "O funcionário já tem x horas de faltas introduzidas. O total de faltas mensal não pode ser superior a y, pelo que não pode introduzir mais de z horas.");
            grMessages.Rows.Add ("-606", "O total de faltas mensal não pode ser superior a x, pelo que não pode introduzir mais de y horas.");
            grMessages.Rows.Add ("-607", "O funcionário já tem x horas de faltas introduzidas. O total de faltas mensal não pode ser superior a y horas, pelo que não pode introduzir mais de z dias.");
            grMessages.Rows.Add ("-608", "O total de faltas mensal não pode ser superior a x horas, pelo que não pode introduzir mais de y dias.");
            grMessages.Rows.Add ("-609", "Hora suplementar sem quantidade");
            grMessages.Rows.Add ("-610", "O fundamento Não existe");

            grMessages.Rows.Add ("-701", "A alteração já existe. Deve escolher para atualizar ou acumular");
            grMessages.Rows.Add ("-702", "Erro ao inserir a alteração");

            grMessages.Rows.Add ("", "5. Delete work detail");
            F_InitializeCell ();
            grMessages.Rows.Add ("-801", "Erro ao eliminar a alteração");
            grMessages.Rows.Add ("-802", "A alteração não existe");
            grMessages.Rows.Add ("-803", "A alteração já foi processada");


            grMessages.Rows.Add ("",  "6. Insert service detail");
            F_InitializeCell ();
            grMessages.Rows.Add ("-551", "[ServiceDetail] não existe");
            grMessages.Rows.Add ("-552", "[Contractor] não existe");
            grMessages.Rows.Add ("-553", "[ServiceType] não existe");
            grMessages.Rows.Add ("-554", "[IncomeType] não existe");
            grMessages.Rows.Add ("-555", "Data do serviço inválida");
            grMessages.Rows.Add ("-556", "Data do documento inválida");
            grMessages.Rows.Add ("-557", "A quantidade e o valor do serviço estão a nulo");
            grMessages.Rows.Add ("-558", "A quantidade não pode ser negativa");
            grMessages.Rows.Add ("-559", "A quantidade não pode ser superior a 99999");
            grMessages.Rows.Add ("-560", "As observações não podem ter mais de 200 caracteres");
            grMessages.Rows.Add ("-561", "O prestador de serviço está inativo");
            grMessages.Rows.Add ("-563", "A data do serviço deve estar no intervalo do contrato do prestador de serviços (data início)");
            grMessages.Rows.Add ("-564", "A data do serviço deve estar no intervalo do contrato do prestador de serviços (data fim)");
            grMessages.Rows.Add ("-565", "A data do documento não pode ser superior à data de registo do serviço");
            grMessages.Rows.Add ("-566", "Tem que indicar o nº de horas afetas à prestação do serviços");
            grMessages.Rows.Add ("-567", "Tem que indicar o nº de trabalhadores afetos à prestação do serviços");
            grMessages.Rows.Add ("-568", "O serviço já existe");
            grMessages.Rows.Add ("-703", "Erro ao inserir o serviço");
            grMessages.Rows.Add ("-712", "Erro (nº erro) ao inserir o serviço");
    
            grMessages.Rows.Add ("",  "7. Delete service detail");
            F_InitializeCell ();
            grMessages.Rows.Add ("-811", "Erro (nº erro) ao eliminar o serviço");
            grMessages.Rows.Add ("-812", "O serviço não existe");
            grMessages.Rows.Add ("-813", "O serviço já foi processado");
    }

    private void F_ReadWarning()
    {

            grMessages.Rows.Add ("", "2. Connect");
            F_InitializeCell ();
            grMessages.Rows.Add ("1204", "Aplicação em modo de demonstração.");

            grMessages.Rows.Add ("", "5. Insert work time");
            F_InitializeCell ();
            grMessages.Rows.Add ("1010", "A data da alteração é superior á data de fim de contrato");
            grMessages.Rows.Add ("1011", "A data da alteração é inferior á data do último recibo processado. Deve reprocessar o recibo do mês da alteração");

            grMessages.Rows.Add ("1012", "O Número de horas de ausência no período normal de trabalho (horas efetivamente faltadas) parece inconsistente com o nº de dias úteis faltados indicados no detalhe da falta e com o nº de horas trabalhadas diariamente pelo funcionário");
            grMessages.Rows.Add ("1013", "O funcionário encontra-se em estado de ausência prolongada e com inibição do(s) recibo(s) relativos a períodos em que se encontre totalmente ausente.Como tal, alterações registadas nesses períodos não serão processadas pelo sistema");

            grMessages.Rows.Add ("1014", "Não foi possível introduzir a falta de subsídio de alimentação (ID)");
            grMessages.Rows.Add ("1015", "O sistema verificou que já existe uma falta de subsídio de alimentação registada na data. Foi atualizada a quantidade dessa falta de subsídio de alimentação pela falta registada");

    }


        private void F_InitializeCell   () {
            System.Windows.Forms.DataGridViewCellStyle boldStyle = new System.Windows.Forms.DataGridViewCellStyle();
            boldStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            grMessages.Rows[grMessages.Rows.Count - 2].DefaultCellStyle = boldStyle;
            grMessages.Rows[grMessages.Rows.Count - 2].Cells[1].Style = new DataGridViewCellStyle { ForeColor = Color.DodgerBlue, BackColor = Color.White };
   
        }
  }
}
