using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Globalization;
using System.Reflection;
using System.Diagnostics;

namespace ApiSalariosCSharp
{
  /// <summary>
  /// Summary description for FormApiSalarios.
  /// </summary>
  /// 

        
    public class FormApiSalariosMain : System.Windows.Forms.Form
    {

        //
        // Vars
        //
        private Char m_DecimalSymbol = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        private const String EMPTY = "";


        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btErrors;
        private System.Windows.Forms.Button btInitialize;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btWarnings;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Label labelLine0;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Label lbCompany0;
        private System.Windows.Forms.Label lbCompany1;
        private System.Windows.Forms.Label lbError0;
        private System.Windows.Forms.Label lbError1;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.PictureBox imLogo;
        private System.Windows.Forms.PictureBox imResult0;
        private System.Windows.Forms.PictureBox imResult1;
        private System.Windows.Forms.PictureBox imThumbsDown;
        private System.Windows.Forms.PictureBox imThumbsUp;
        private System.Windows.Forms.TextBox tbCompany0;
        private System.Windows.Forms.TextBox tbCompany1;
        private System.Windows.Forms.TextBox tbCompany2;
        private System.Windows.Forms.TextBox textBoxFooter;

        //
        // Control Arrays
        //
        private System.Windows.Forms.Label[] lblGeneric;
        private System.Windows.Forms.Label[] lblServs;
        private System.Windows.Forms.Label[] lbError;
        private System.Windows.Forms.Label[] lbSalaryTypeName;
        private System.Windows.Forms.PictureBox[] imResult;
        private System.Windows.Forms.TextBox[] tbCompany;
        private System.Windows.Forms.Label[] lblWorktime;
        private System.Windows.Forms.ComboBox[] cbSalaryType;
        private System.Windows.Forms.DateTimePicker[] dpDate;
        private System.Windows.Forms.RadioButton[] opSalaryType;
        
        //
        // Controls
        //
        private TabControl tabControlMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lbl2;
        private Label lbError2;
        private Label lbl3;
        private Label lbError3;
        private Label lblSalarytype0;
        private Label lblSalarytype1;
        private Label lblSalarytype2;
        private Label lbl4;
        private Label lblWorktime0;
        private Label lblWorktime1;
        private Label lblWorktime2;
        private Label lblWorktime3;
        private Label lblWorktime4;
        private Label lblWorktime5;
        private Label lbError4;
        private Label lblWorktime6;
        private Label lblWorktime7;
        private PictureBox imResult2;
        private PictureBox imResult3;
        private PictureBox imResult4;
        private Label lblWorktime8;
        private Label lblWorktime9;
        private TextBox tbOverTimeReason;
        private Button btDelete;
        private DateTimePicker dpDate3;
        private DateTimePicker dpDate2;
        private DateTimePicker dpDate1;
        private TextBox tbComments;
        private TextBox tbEndTime;
        private TextBox tbStartTime;
        private TextBox tbValue;
        private TextBox tbQuantity;
        private Button btInsert;
        private ComboBox cbSalaryType2;
        private ComboBox cbSalaryType1;
        private ComboBox cbSalaryType0;
        private Button btSalaryTypes;
        private Button btEmployees;
        private ComboBox cbEmployees;
        private DateTimePicker dpDate0;
        private CheckBox ckUpdate;
        private RadioButton opSalaryType0;
        private RadioButton opSalaryType1;
        private RadioButton opSalaryType2;
        private GroupBox frSalaryType;
        private Label lblSalaryTypeName0;
        private Label lblSalaryTypeName1;
        private Label lblSalaryTypeName2;
        private Label lbError8;
        private Label lbError7;
        private DataGridView grHolidays;
        private Button btHolidays;
        private PictureBox imResult8;
        private ComboBox cbYears;
        private Label lbl8;
        private Label lbl7;
        private Label label2;
        private ComboBox cbEmployeesH;
        private Button btEmployeesH;
        private PictureBox imResult7;
        private PictureBox imResult5;
        private Label lbError5;
        private ComboBox cbTaxRegion;
        private Button btContractors;
        private ComboBox cbContractors;
        private Button btServiceTypes;
        private ComboBox cbServicesType;
        private Button btIncomeTypes;
        private ComboBox cbIncomeTypes;
        private DateTimePicker dpServiceDate0;
        private Button btDeleteService;
        private Button btInsertService;
        private TextBox tbDocumentoNumber;
        private TextBox tbServiceQuantity;
        private TextBox tbServiceValue;
        private TextBox tbServiceComments;
        private TextBox tbNumberOfHours;
        private TextBox tbNumberOfWorkers;
        private CheckBox ckUpdateService;
        private DateTimePicker dpServiceDate1;
        private Label lbl6;
        private PictureBox imResult6;
        private Label lbError6;
        private Label lbl9;
        private PictureBox imResult9;
        private Label lbError9;
        private Label lbl10;
        private PictureBox imResult10;
        private Label lbError10;
        private Label lbService0;
        private Label lbService1;
        private Label lbService2;
        private Label lbl11;
        private Label lbService3;
        private Label lbService4;
        private Label lbService5;
        private Label lbService6;
        private Label lbService7;
        private PictureBox imResult11;
        private Label lbError11;
        private Label lbService8;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FormApiSalariosMain()
        {

            // ############################################################################################
            //
            // if by any circumstance you want to build your project arround the Sage1GEPAPI10
            // not usings this dll as a refrence in your project, you might not refrence the dll
            // and instance all Classes and call all Methods by Reflection
            //
            // Here you can find an approach to Reflection here:
            //
            // Use_1GEP_API_by_Reflection();
            //
            // ############################################################################################

            // Required for Windows Form Designer support
            InitializeComponent();

            //
            // Control Arrays Populate
            //
            lblGeneric = new Label[] { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7,lbl8,lbl9,lbl10,lbl11  };
            lblServs = new Label[] { lbService0, lbService1, lbService2, lbService3, lbService4, lbService5, lbService6, lbService7, lbService8 };
            lbError = new Label[] {lbError0, lbError1, lbError2, lbError3, lbError4, lbError5, lbError6, lbError7, lbError8, lbError9, lbError10, lbError11 };
            lbSalaryTypeName = new Label[] { lblSalaryTypeName0, lblSalaryTypeName1, lblSalaryTypeName2 };
            lblWorktime = new Label[] { lblWorktime0, lblWorktime1, lblWorktime2, lblWorktime3, lblWorktime4, lblWorktime5, lblWorktime6, lblWorktime7, lblWorktime8, lblWorktime9 };
            imResult = new PictureBox[] {imResult0, imResult1, imResult2, imResult3, imResult4, imResult5, imResult6, imResult7, imResult8, imResult9, imResult10, imResult11 };
            tbCompany = new TextBox[] { tbCompany0, tbCompany1, tbCompany2 };
            cbSalaryType = new ComboBox[] { cbSalaryType0, cbSalaryType1, cbSalaryType2 };
            dpDate = new DateTimePicker[] { dpDate0, dpDate1, dpDate2, dpDate3 };
            opSalaryType = new RadioButton[] { opSalaryType0, opSalaryType1, opSalaryType2 };

            // year combo Load
            string currentYear = DateTime.Now.Year.ToString();
            int iYear = Convert.ToInt32(currentYear);

            for ( int n = iYear;   n > (iYear - 10); n--)
            {
                cbYears.Items.Add(n);
            }

            grHolidays.ColumnCount = 4;
            grHolidays.Columns[0].Name = "Start";
            grHolidays.Columns[1].Name = "End";
            grHolidays.Columns[2].Name = "Work days";
            grHolidays.Columns[3].Name = "Notes";

            cbTaxRegion.Items.Add("Continent");
            cbTaxRegion.Items.Add("Acores");
            cbTaxRegion.Items.Add("Foreign");
            cbTaxRegion.Items.Add("Madeira");

            grHolidays.Columns[0].HeaderText = grHolidays.Columns[0].Name;
            grHolidays.Columns[1].HeaderText = grHolidays.Columns[1].Name;
            grHolidays.Columns[2].HeaderText = grHolidays.Columns[2].Name;
            grHolidays.Columns[3].HeaderText = grHolidays.Columns[3].Name;

            grHolidays.Columns[0].Width = 75;
            grHolidays.Columns[1].Width = 75;
            grHolidays.Columns[2].Width = 50;
            grHolidays.Columns[3].Width = 180;


            grHolidays.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grHolidays.Columns["Notes"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grHolidays.Columns["Work days"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            

            // TODO: Add any constructor code after InitializeComponent call
        }

        // ===============================================================
        // Reflection: Variable Declaration
        // ---------------------------------------------------------------
        // Purpose : Declares all Object to use by Reflection
        //
        // ===============================================================
        public System.Type PayrollAPI_ComType;
        public System.Type Employees_ComType;
        public System.Type Employee_ComType;
        public System.Object m_Api_ComObject;
        public System.Object m_Employees_ComObject;
        public System.Object l_Employee_ComObject;


        // ===============================================================
        // Reflection: Instance
        // ---------------------------------------------------------------
        // Purpose : Creates Instances by Reflection
        //
        // ===============================================================
        public void Use_BGEP_API_by_Reflection (){

            // Create an Type of your COM Registered Object.
            PayrollAPI_ComType = Type.GetTypeFromProgID("Sage1GEPAPI10.PayrollAPI");
            Employees_ComType  = Type.GetTypeFromProgID("Sage1GEPAPI10.Employees");
            Employee_ComType  = Type.GetTypeFromProgID("Sage1GEPAPI10.Employee");

            // Create an instance of your COM Registered Object.
            m_Api_ComObject = Activator.CreateInstance(PayrollAPI_ComType);
            m_Employees_ComObject = Activator.CreateInstance(Employees_ComType);
            l_Employee_ComObject = Activator.CreateInstance(Employee_ComType);

            // Vars
            int lResult;
            Boolean bResult;

            // Initialize Api
            lResult = (int)PayrollAPI_ComType.InvokeMember("Initialize",
                BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, 
                null,
                m_Api_ComObject, new object[] { });

            // Connnect to Data Base
            lResult = (int)PayrollAPI_ComType.InvokeMember("Connect",
                BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, 
                null,
                m_Api_ComObject,
                new object[] { "Sage", "123abc", "DEMO_1GEP" });
            
            // Load Employees
            if (m_Api_ComObject != null)
            {
                // Get Employyes Collection
                m_Employees_ComObject = PayrollAPI_ComType.InvokeMember("GetEmployees", 
                    BindingFlags.InvokeMethod, 
                    null, 
                    m_Api_ComObject, 
                    new object[] { });

                // Get Success retrieving Employees
                bResult = (Boolean)Employees_ComType.InvokeMember("Success",
                    BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public,
                    null,
                    m_Employees_ComObject,
                    null);

                // Get Count of Employees
                int lCount = (int)Employees_ComType.InvokeMember("Count",
                    BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public,
                    null,
                    m_Employees_ComObject,
                    null);

                // Get one Employee by index = [1]
                l_Employee_ComObject = Employees_ComType.InvokeMember("Item",
                    BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public,
                    null,
                    m_Employees_ComObject,
                    new object[] {1});

                // Get All Employees by index = [0] to [lCount]
                for (int i = 1; i <= lCount; i++)
                {
                    l_Employee_ComObject = Employees_ComType.InvokeMember("Item",
                        BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public,
                        null,
                        m_Employees_ComObject,
                        new object[] { i });

                    // Get Employee ID
                    String ID = (String)Employee_ComType.InvokeMember("ID",
                        BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public,
                        null,
                        l_Employee_ComObject,
                        null);

                    // Get Employee Name
                    String Name = (String)Employee_ComType.InvokeMember("Name",
                        BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public,
                        null,
                        l_Employee_ComObject,
                        null);

                    // Get Employee DateOfBirth
                    String DateOfBirth = (String)Employee_ComType.InvokeMember("DateOfBirth",
                        BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public,
                        null,
                        l_Employee_ComObject,
                        null);

                    // Get Employee EMail
                    String EMail = (String)Employee_ComType.InvokeMember("EMail",
                        BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public,
                        null,
                        l_Employee_ComObject,
                        null);

                    // Open Output Window to see results
                    // Ctrl + Alt + O
                    String employeeInfo = "ID: " + ID + " - Name: " + Name + " - eMail: " + EMail + " - DateOfBirth: " +  DateOfBirth + EMPTY;

                    Debug.WriteLine(employeeInfo);
                }
            }
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApiSalariosMain));
            this.btClose = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btErrors = new System.Windows.Forms.Button();
            this.btInitialize = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btWarnings = new System.Windows.Forms.Button();
            this.imLogo = new System.Windows.Forms.PictureBox();
            this.imResult0 = new System.Windows.Forms.PictureBox();
            this.imResult1 = new System.Windows.Forms.PictureBox();
            this.imThumbsDown = new System.Windows.Forms.PictureBox();
            this.imThumbsUp = new System.Windows.Forms.PictureBox();
            this.lbCompany0 = new System.Windows.Forms.Label();
            this.lbCompany1 = new System.Windows.Forms.Label();
            this.lbError0 = new System.Windows.Forms.Label();
            this.lbError1 = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.tbCompany0 = new System.Windows.Forms.TextBox();
            this.tbCompany1 = new System.Windows.Forms.TextBox();
            this.tbCompany2 = new System.Windows.Forms.TextBox();
            this.labelLine0 = new System.Windows.Forms.Label();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.textBoxFooter = new System.Windows.Forms.TextBox();
            this.labelFooter = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblSalaryTypeName2 = new System.Windows.Forms.Label();
            this.lbError2 = new System.Windows.Forms.Label();
            this.lblSalaryTypeName1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblSalaryTypeName0 = new System.Windows.Forms.Label();
            this.lbError3 = new System.Windows.Forms.Label();
            this.frSalaryType = new System.Windows.Forms.GroupBox();
            this.opSalaryType2 = new System.Windows.Forms.RadioButton();
            this.opSalaryType1 = new System.Windows.Forms.RadioButton();
            this.opSalaryType0 = new System.Windows.Forms.RadioButton();
            this.lblSalarytype0 = new System.Windows.Forms.Label();
            this.lblSalarytype1 = new System.Windows.Forms.Label();
            this.lblSalarytype2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblWorktime0 = new System.Windows.Forms.Label();
            this.ckUpdate = new System.Windows.Forms.CheckBox();
            this.lblWorktime1 = new System.Windows.Forms.Label();
            this.dpDate0 = new System.Windows.Forms.DateTimePicker();
            this.lblWorktime2 = new System.Windows.Forms.Label();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.lblWorktime3 = new System.Windows.Forms.Label();
            this.lblWorktime4 = new System.Windows.Forms.Label();
            this.lblWorktime5 = new System.Windows.Forms.Label();
            this.lbError4 = new System.Windows.Forms.Label();
            this.btEmployees = new System.Windows.Forms.Button();
            this.lblWorktime6 = new System.Windows.Forms.Label();
            this.lblWorktime7 = new System.Windows.Forms.Label();
            this.imResult2 = new System.Windows.Forms.PictureBox();
            this.btSalaryTypes = new System.Windows.Forms.Button();
            this.imResult3 = new System.Windows.Forms.PictureBox();
            this.cbSalaryType0 = new System.Windows.Forms.ComboBox();
            this.imResult4 = new System.Windows.Forms.PictureBox();
            this.cbSalaryType1 = new System.Windows.Forms.ComboBox();
            this.lblWorktime8 = new System.Windows.Forms.Label();
            this.cbSalaryType2 = new System.Windows.Forms.ComboBox();
            this.lblWorktime9 = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            this.tbOverTimeReason = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.dpDate3 = new System.Windows.Forms.DateTimePicker();
            this.tbStartTime = new System.Windows.Forms.TextBox();
            this.dpDate2 = new System.Windows.Forms.DateTimePicker();
            this.tbEndTime = new System.Windows.Forms.TextBox();
            this.dpDate1 = new System.Windows.Forms.DateTimePicker();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbError5 = new System.Windows.Forms.Label();
            this.lbError8 = new System.Windows.Forms.Label();
            this.lbError7 = new System.Windows.Forms.Label();
            this.grHolidays = new System.Windows.Forms.DataGridView();
            this.btHolidays = new System.Windows.Forms.Button();
            this.imResult8 = new System.Windows.Forms.PictureBox();
            this.cbYears = new System.Windows.Forms.ComboBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmployeesH = new System.Windows.Forms.ComboBox();
            this.btEmployeesH = new System.Windows.Forms.Button();
            this.imResult7 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbTaxRegion = new System.Windows.Forms.ComboBox();
            this.btContractors = new System.Windows.Forms.Button();
            this.cbContractors = new System.Windows.Forms.ComboBox();
            this.btServiceTypes = new System.Windows.Forms.Button();
            this.cbServicesType = new System.Windows.Forms.ComboBox();
            this.btIncomeTypes = new System.Windows.Forms.Button();
            this.cbIncomeTypes = new System.Windows.Forms.ComboBox();
            this.dpServiceDate0 = new System.Windows.Forms.DateTimePicker();
            this.btDeleteService = new System.Windows.Forms.Button();
            this.btInsertService = new System.Windows.Forms.Button();
            this.tbDocumentoNumber = new System.Windows.Forms.TextBox();
            this.tbServiceQuantity = new System.Windows.Forms.TextBox();
            this.tbServiceValue = new System.Windows.Forms.TextBox();
            this.tbServiceComments = new System.Windows.Forms.TextBox();
            this.tbNumberOfHours = new System.Windows.Forms.TextBox();
            this.tbNumberOfWorkers = new System.Windows.Forms.TextBox();
            this.ckUpdateService = new System.Windows.Forms.CheckBox();
            this.dpServiceDate1 = new System.Windows.Forms.DateTimePicker();
            this.lbl6 = new System.Windows.Forms.Label();
            this.imResult6 = new System.Windows.Forms.PictureBox();
            this.lbError6 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.imResult9 = new System.Windows.Forms.PictureBox();
            this.lbError9 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.imResult10 = new System.Windows.Forms.PictureBox();
            this.lbError10 = new System.Windows.Forms.Label();
            this.lbService0 = new System.Windows.Forms.Label();
            this.lbService1 = new System.Windows.Forms.Label();
            this.lbService2 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbService3 = new System.Windows.Forms.Label();
            this.lbService4 = new System.Windows.Forms.Label();
            this.lbService5 = new System.Windows.Forms.Label();
            this.lbService6 = new System.Windows.Forms.Label();
            this.lbService7 = new System.Windows.Forms.Label();
            this.imResult11 = new System.Windows.Forms.PictureBox();
            this.lbError11 = new System.Windows.Forms.Label();
            this.lbService8 = new System.Windows.Forms.Label();
            this.imResult5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imThumbsDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imThumbsUp)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.frSalaryType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imResult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grHolidays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult7)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imResult6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult5)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(8, 282);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(97, 33);
            this.btClose.TabIndex = 29;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btConnect.Enabled = false;
            this.btConnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(384, 112);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(81, 33);
            this.btConnect.TabIndex = 4;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btDisconnect.Enabled = false;
            this.btDisconnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisconnect.Location = new System.Drawing.Point(384, 549);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(81, 33);
            this.btDisconnect.TabIndex = 43;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = false;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btErrors
            // 
            this.btErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btErrors.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btErrors.Location = new System.Drawing.Point(8, 198);
            this.btErrors.Name = "btErrors";
            this.btErrors.Size = new System.Drawing.Size(97, 33);
            this.btErrors.TabIndex = 52;
            this.btErrors.Text = "Show errors";
            this.btErrors.UseVisualStyleBackColor = false;
            this.btErrors.Click += new System.EventHandler(this.btErrors_Click);
            // 
            // btInitialize
            // 
            this.btInitialize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btInitialize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInitialize.Location = new System.Drawing.Point(384, 40);
            this.btInitialize.Name = "btInitialize";
            this.btInitialize.Size = new System.Drawing.Size(81, 33);
            this.btInitialize.TabIndex = 0;
            this.btInitialize.Text = "Initialize";
            this.btInitialize.UseVisualStyleBackColor = false;
            this.btInitialize.Click += new System.EventHandler(this.btInitialize_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(8, 158);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(97, 33);
            this.btReset.TabIndex = 28;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btWarnings
            // 
            this.btWarnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btWarnings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWarnings.Location = new System.Drawing.Point(8, 240);
            this.btWarnings.Name = "btWarnings";
            this.btWarnings.Size = new System.Drawing.Size(97, 33);
            this.btWarnings.TabIndex = 53;
            this.btWarnings.Text = "Show warnings";
            this.btWarnings.UseVisualStyleBackColor = false;
            this.btWarnings.Click += new System.EventHandler(this.btWarnings_Click);
            // 
            // imLogo
            // 
            this.imLogo.Image = ((System.Drawing.Image)(resources.GetObject("imLogo.Image")));
            this.imLogo.Location = new System.Drawing.Point(16, 8);
            this.imLogo.Name = "imLogo";
            this.imLogo.Size = new System.Drawing.Size(108, 40);
            this.imLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imLogo.TabIndex = 60;
            this.imLogo.TabStop = false;
            // 
            // imResult0
            // 
            this.imResult0.Image = ((System.Drawing.Image)(resources.GetObject("imResult0.Image")));
            this.imResult0.Location = new System.Drawing.Point(472, 48);
            this.imResult0.Name = "imResult0";
            this.imResult0.Size = new System.Drawing.Size(16, 16);
            this.imResult0.TabIndex = 67;
            this.imResult0.TabStop = false;
            this.imResult0.Visible = false;
            // 
            // imResult1
            // 
            this.imResult1.Image = ((System.Drawing.Image)(resources.GetObject("imResult1.Image")));
            this.imResult1.Location = new System.Drawing.Point(472, 120);
            this.imResult1.Name = "imResult1";
            this.imResult1.Size = new System.Drawing.Size(16, 16);
            this.imResult1.TabIndex = 64;
            this.imResult1.TabStop = false;
            this.imResult1.Visible = false;
            // 
            // imThumbsDown
            // 
            this.imThumbsDown.Image = ((System.Drawing.Image)(resources.GetObject("imThumbsDown.Image")));
            this.imThumbsDown.Location = new System.Drawing.Point(784, 32);
            this.imThumbsDown.Name = "imThumbsDown";
            this.imThumbsDown.Size = new System.Drawing.Size(16, 16);
            this.imThumbsDown.TabIndex = 65;
            this.imThumbsDown.TabStop = false;
            this.imThumbsDown.Visible = false;
            // 
            // imThumbsUp
            // 
            this.imThumbsUp.Image = ((System.Drawing.Image)(resources.GetObject("imThumbsUp.Image")));
            this.imThumbsUp.Location = new System.Drawing.Point(760, 32);
            this.imThumbsUp.Name = "imThumbsUp";
            this.imThumbsUp.Size = new System.Drawing.Size(16, 16);
            this.imThumbsUp.TabIndex = 66;
            this.imThumbsUp.TabStop = false;
            this.imThumbsUp.Visible = false;
            // 
            // lbCompany0
            // 
            this.lbCompany0.AutoSize = true;
            this.lbCompany0.Enabled = false;
            this.lbCompany0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompany0.Location = new System.Drawing.Point(392, 91);
            this.lbCompany0.Name = "lbCompany0";
            this.lbCompany0.Size = new System.Drawing.Size(37, 15);
            this.lbCompany0.TabIndex = 54;
            this.lbCompany0.Text = "Login";
            // 
            // lbCompany1
            // 
            this.lbCompany1.AutoSize = true;
            this.lbCompany1.Enabled = false;
            this.lbCompany1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompany1.Location = new System.Drawing.Point(568, 91);
            this.lbCompany1.Name = "lbCompany1";
            this.lbCompany1.Size = new System.Drawing.Size(57, 15);
            this.lbCompany1.TabIndex = 55;
            this.lbCompany1.Text = "Password";
            // 
            // lbError0
            // 
            this.lbError0.AutoSize = true;
            this.lbError0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError0.Location = new System.Drawing.Point(504, 48);
            this.lbError0.Name = "lbError0";
            this.lbError0.Size = new System.Drawing.Size(0, 15);
            this.lbError0.TabIndex = 23;
            // 
            // lbError1
            // 
            this.lbError1.AutoSize = true;
            this.lbError1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError1.Location = new System.Drawing.Point(504, 120);
            this.lbError1.Name = "lbError1";
            this.lbError1.Size = new System.Drawing.Size(0, 15);
            this.lbError1.TabIndex = 24;
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.Location = new System.Drawing.Point(120, 48);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(62, 15);
            this.lbl0.TabIndex = 21;
            this.lbl0.Text = "1. Initialize";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Enabled = false;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(120, 91);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(166, 15);
            this.lbl1.TabIndex = 22;
            this.lbl1.Text = "2. Connect. Choose company:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Enabled = false;
            this.lbl5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(120, 557);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(81, 15);
            this.lbl5.TabIndex = 44;
            this.lbl5.Text = "6. Disconnect:";
            // 
            // tbCompany0
            // 
            this.tbCompany0.BackColor = System.Drawing.Color.White;
            this.tbCompany0.Enabled = false;
            this.tbCompany0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCompany0.Location = new System.Drawing.Point(296, 88);
            this.tbCompany0.MaxLength = 0;
            this.tbCompany0.Name = "tbCompany0";
            this.tbCompany0.Size = new System.Drawing.Size(81, 23);
            this.tbCompany0.TabIndex = 1;
            // 
            // tbCompany1
            // 
            this.tbCompany1.Enabled = false;
            this.tbCompany1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCompany1.Location = new System.Drawing.Point(472, 88);
            this.tbCompany1.MaxLength = 0;
            this.tbCompany1.Name = "tbCompany1";
            this.tbCompany1.Size = new System.Drawing.Size(81, 23);
            this.tbCompany1.TabIndex = 2;
            // 
            // tbCompany2
            // 
            this.tbCompany2.Enabled = false;
            this.tbCompany2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCompany2.Location = new System.Drawing.Point(632, 88);
            this.tbCompany2.MaxLength = 0;
            this.tbCompany2.Name = "tbCompany2";
            this.tbCompany2.PasswordChar = '*';
            this.tbCompany2.Size = new System.Drawing.Size(105, 23);
            this.tbCompany2.TabIndex = 3;
            // 
            // labelLine0
            // 
            this.labelLine0.AutoSize = true;
            this.labelLine0.BackColor = System.Drawing.Color.Gray;
            this.labelLine0.Enabled = false;
            this.labelLine0.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine0.Location = new System.Drawing.Point(120, 149);
            this.labelLine0.Name = "labelLine0";
            this.labelLine0.Size = new System.Drawing.Size(715, 4);
            this.labelLine0.TabIndex = 68;
            this.labelLine0.Text = resources.GetString("labelLine0.Text");
            // 
            // labelLine1
            // 
            this.labelLine1.AutoSize = true;
            this.labelLine1.BackColor = System.Drawing.Color.Gray;
            this.labelLine1.Enabled = false;
            this.labelLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine1.Location = new System.Drawing.Point(117, 542);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.Size = new System.Drawing.Size(717, 4);
            this.labelLine1.TabIndex = 69;
            this.labelLine1.Text = resources.GetString("labelLine1.Text");
            // 
            // textBoxFooter
            // 
            this.textBoxFooter.BackColor = System.Drawing.Color.DimGray;
            this.textBoxFooter.Location = new System.Drawing.Point(-1, 585);
            this.textBoxFooter.Name = "textBoxFooter";
            this.textBoxFooter.Size = new System.Drawing.Size(836, 62);
            this.textBoxFooter.TabIndex = 70;
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.BackColor = System.Drawing.Color.DimGray;
            this.labelFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter.ForeColor = System.Drawing.Color.White;
            this.labelFooter.Location = new System.Drawing.Point(8, 608);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(186, 15);
            this.labelFooter.TabIndex = 71;
            this.labelFooter.Text = "Copyright @ 2016 Sage Portugal";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(121, 158);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(714, 373);
            this.tabControlMain.TabIndex = 76;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl2);
            this.tabPage1.Controls.Add(this.lblSalaryTypeName2);
            this.tabPage1.Controls.Add(this.lbError2);
            this.tabPage1.Controls.Add(this.lblSalaryTypeName1);
            this.tabPage1.Controls.Add(this.lbl3);
            this.tabPage1.Controls.Add(this.lblSalaryTypeName0);
            this.tabPage1.Controls.Add(this.lbError3);
            this.tabPage1.Controls.Add(this.frSalaryType);
            this.tabPage1.Controls.Add(this.lblSalarytype0);
            this.tabPage1.Controls.Add(this.lblSalarytype1);
            this.tabPage1.Controls.Add(this.lblSalarytype2);
            this.tabPage1.Controls.Add(this.lbl4);
            this.tabPage1.Controls.Add(this.lblWorktime0);
            this.tabPage1.Controls.Add(this.ckUpdate);
            this.tabPage1.Controls.Add(this.lblWorktime1);
            this.tabPage1.Controls.Add(this.dpDate0);
            this.tabPage1.Controls.Add(this.lblWorktime2);
            this.tabPage1.Controls.Add(this.cbEmployees);
            this.tabPage1.Controls.Add(this.lblWorktime3);
            this.tabPage1.Controls.Add(this.lblWorktime4);
            this.tabPage1.Controls.Add(this.lblWorktime5);
            this.tabPage1.Controls.Add(this.lbError4);
            this.tabPage1.Controls.Add(this.btEmployees);
            this.tabPage1.Controls.Add(this.lblWorktime6);
            this.tabPage1.Controls.Add(this.lblWorktime7);
            this.tabPage1.Controls.Add(this.imResult2);
            this.tabPage1.Controls.Add(this.btSalaryTypes);
            this.tabPage1.Controls.Add(this.imResult3);
            this.tabPage1.Controls.Add(this.cbSalaryType0);
            this.tabPage1.Controls.Add(this.imResult4);
            this.tabPage1.Controls.Add(this.cbSalaryType1);
            this.tabPage1.Controls.Add(this.lblWorktime8);
            this.tabPage1.Controls.Add(this.cbSalaryType2);
            this.tabPage1.Controls.Add(this.lblWorktime9);
            this.tabPage1.Controls.Add(this.btInsert);
            this.tabPage1.Controls.Add(this.tbOverTimeReason);
            this.tabPage1.Controls.Add(this.tbQuantity);
            this.tabPage1.Controls.Add(this.btDelete);
            this.tabPage1.Controls.Add(this.tbValue);
            this.tabPage1.Controls.Add(this.dpDate3);
            this.tabPage1.Controls.Add(this.tbStartTime);
            this.tabPage1.Controls.Add(this.dpDate2);
            this.tabPage1.Controls.Add(this.tbEndTime);
            this.tabPage1.Controls.Add(this.dpDate1);
            this.tabPage1.Controls.Add(this.tbComments);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(706, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.Enabled = false;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(3, 17);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(201, 15);
            this.lbl2.TabIndex = 25;
            this.lbl2.Text = "3. Get employees. Choose employee:";
            // 
            // lblSalaryTypeName2
            // 
            this.lblSalaryTypeName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalaryTypeName2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryTypeName2.Location = new System.Drawing.Point(433, 136);
            this.lblSalaryTypeName2.Name = "lblSalaryTypeName2";
            this.lblSalaryTypeName2.Size = new System.Drawing.Size(270, 17);
            this.lblSalaryTypeName2.TabIndex = 75;
            // 
            // lbError2
            // 
            this.lbError2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbError2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbError2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError2.Location = new System.Drawing.Point(474, 16);
            this.lbError2.Name = "lbError2";
            this.lbError2.Size = new System.Drawing.Size(230, 17);
            this.lbError2.TabIndex = 27;
            // 
            // lblSalaryTypeName1
            // 
            this.lblSalaryTypeName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalaryTypeName1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryTypeName1.Location = new System.Drawing.Point(433, 112);
            this.lblSalaryTypeName1.Name = "lblSalaryTypeName1";
            this.lblSalaryTypeName1.Size = new System.Drawing.Size(270, 17);
            this.lblSalaryTypeName1.TabIndex = 74;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Enabled = false;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(3, 57);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(209, 15);
            this.lbl3.TabIndex = 30;
            this.lbl3.Text = "4. Get salary types. Choose salary type:";
            // 
            // lblSalaryTypeName0
            // 
            this.lblSalaryTypeName0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalaryTypeName0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryTypeName0.Location = new System.Drawing.Point(433, 88);
            this.lblSalaryTypeName0.Name = "lblSalaryTypeName0";
            this.lblSalaryTypeName0.Size = new System.Drawing.Size(270, 17);
            this.lblSalaryTypeName0.TabIndex = 73;
            // 
            // lbError3
            // 
            this.lbError3.AutoSize = true;
            this.lbError3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError3.Location = new System.Drawing.Point(387, 62);
            this.lbError3.Name = "lbError3";
            this.lbError3.Size = new System.Drawing.Size(0, 15);
            this.lbError3.TabIndex = 31;
            // 
            // frSalaryType
            // 
            this.frSalaryType.Controls.Add(this.opSalaryType2);
            this.frSalaryType.Controls.Add(this.opSalaryType1);
            this.frSalaryType.Controls.Add(this.opSalaryType0);
            this.frSalaryType.Location = new System.Drawing.Point(229, 57);
            this.frSalaryType.Name = "frSalaryType";
            this.frSalaryType.Size = new System.Drawing.Size(28, 109);
            this.frSalaryType.TabIndex = 72;
            this.frSalaryType.TabStop = false;
            // 
            // opSalaryType2
            // 
            this.opSalaryType2.BackColor = System.Drawing.SystemColors.Window;
            this.opSalaryType2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.opSalaryType2.Location = new System.Drawing.Point(6, 81);
            this.opSalaryType2.Name = "opSalaryType2";
            this.opSalaryType2.Size = new System.Drawing.Size(17, 17);
            this.opSalaryType2.TabIndex = 49;
            this.opSalaryType2.UseVisualStyleBackColor = false;
            // 
            // opSalaryType1
            // 
            this.opSalaryType1.BackColor = System.Drawing.SystemColors.Window;
            this.opSalaryType1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.opSalaryType1.Location = new System.Drawing.Point(6, 56);
            this.opSalaryType1.Name = "opSalaryType1";
            this.opSalaryType1.Size = new System.Drawing.Size(17, 17);
            this.opSalaryType1.TabIndex = 48;
            this.opSalaryType1.UseVisualStyleBackColor = false;
            // 
            // opSalaryType0
            // 
            this.opSalaryType0.BackColor = System.Drawing.SystemColors.Window;
            this.opSalaryType0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.opSalaryType0.Location = new System.Drawing.Point(6, 32);
            this.opSalaryType0.Name = "opSalaryType0";
            this.opSalaryType0.Size = new System.Drawing.Size(17, 17);
            this.opSalaryType0.TabIndex = 47;
            this.opSalaryType0.UseVisualStyleBackColor = false;
            // 
            // lblSalarytype0
            // 
            this.lblSalarytype0.AutoSize = true;
            this.lblSalarytype0.Enabled = false;
            this.lblSalarytype0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarytype0.Location = new System.Drawing.Point(267, 90);
            this.lblSalarytype0.Name = "lblSalarytype0";
            this.lblSalarytype0.Size = new System.Drawing.Size(62, 15);
            this.lblSalarytype0.TabIndex = 32;
            this.lblSalarytype0.Text = "Allowance";
            // 
            // lblSalarytype1
            // 
            this.lblSalarytype1.AutoSize = true;
            this.lblSalarytype1.Enabled = false;
            this.lblSalarytype1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarytype1.Location = new System.Drawing.Point(267, 118);
            this.lblSalarytype1.Name = "lblSalarytype1";
            this.lblSalarytype1.Size = new System.Drawing.Size(62, 15);
            this.lblSalarytype1.TabIndex = 33;
            this.lblSalarytype1.Text = "Deduction";
            // 
            // lblSalarytype2
            // 
            this.lblSalarytype2.AutoSize = true;
            this.lblSalarytype2.Enabled = false;
            this.lblSalarytype2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarytype2.Location = new System.Drawing.Point(267, 142);
            this.lblSalarytype2.Name = "lblSalarytype2";
            this.lblSalarytype2.Size = new System.Drawing.Size(52, 15);
            this.lblSalarytype2.TabIndex = 34;
            this.lblSalarytype2.Text = "Absence";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Enabled = false;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(3, 174);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(112, 15);
            this.lbl4.TabIndex = 35;
            this.lbl4.Text = "5. Insert work detail:";
            // 
            // lblWorktime0
            // 
            this.lblWorktime0.AutoSize = true;
            this.lblWorktime0.Enabled = false;
            this.lblWorktime0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime0.Location = new System.Drawing.Point(35, 202);
            this.lblWorktime0.Name = "lblWorktime0";
            this.lblWorktime0.Size = new System.Drawing.Size(34, 15);
            this.lblWorktime0.TabIndex = 36;
            this.lblWorktime0.Text = "Date:";
            // 
            // ckUpdate
            // 
            this.ckUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckUpdate.Location = new System.Drawing.Point(611, 270);
            this.ckUpdate.Name = "ckUpdate";
            this.ckUpdate.Size = new System.Drawing.Size(65, 17);
            this.ckUpdate.TabIndex = 19;
            this.ckUpdate.Text = "Update";
            this.ckUpdate.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lblWorktime1
            // 
            this.lblWorktime1.AutoSize = true;
            this.lblWorktime1.Enabled = false;
            this.lblWorktime1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime1.Location = new System.Drawing.Point(203, 202);
            this.lblWorktime1.Name = "lblWorktime1";
            this.lblWorktime1.Size = new System.Drawing.Size(56, 15);
            this.lblWorktime1.TabIndex = 37;
            this.lblWorktime1.Text = "Quantity:";
            // 
            // dpDate0
            // 
            this.dpDate0.Checked = false;
            this.dpDate0.Enabled = false;
            this.dpDate0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate0.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate0.Location = new System.Drawing.Point(107, 198);
            this.dpDate0.Name = "dpDate0";
            this.dpDate0.Size = new System.Drawing.Size(85, 23);
            this.dpDate0.TabIndex = 10;
            // 
            // lblWorktime2
            // 
            this.lblWorktime2.AutoSize = true;
            this.lblWorktime2.Enabled = false;
            this.lblWorktime2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime2.Location = new System.Drawing.Point(356, 202);
            this.lblWorktime2.Name = "lblWorktime2";
            this.lblWorktime2.Size = new System.Drawing.Size(39, 15);
            this.lblWorktime2.TabIndex = 38;
            this.lblWorktime2.Text = "Value:";
            // 
            // cbEmployees
            // 
            this.cbEmployees.Enabled = false;
            this.cbEmployees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployees.Location = new System.Drawing.Point(387, 14);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(81, 23);
            this.cbEmployees.TabIndex = 5;
            this.cbEmployees.SelectedIndexChanged += new System.EventHandler(this.cbEmployees_SelectedIndexChanged);
            // 
            // lblWorktime3
            // 
            this.lblWorktime3.AutoSize = true;
            this.lblWorktime3.Enabled = false;
            this.lblWorktime3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime3.Location = new System.Drawing.Point(203, 234);
            this.lblWorktime3.Name = "lblWorktime3";
            this.lblWorktime3.Size = new System.Drawing.Size(61, 15);
            this.lblWorktime3.TabIndex = 39;
            this.lblWorktime3.Text = "Start time:";
            // 
            // lblWorktime4
            // 
            this.lblWorktime4.AutoSize = true;
            this.lblWorktime4.Enabled = false;
            this.lblWorktime4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime4.Location = new System.Drawing.Point(507, 234);
            this.lblWorktime4.Name = "lblWorktime4";
            this.lblWorktime4.Size = new System.Drawing.Size(57, 15);
            this.lblWorktime4.TabIndex = 40;
            this.lblWorktime4.Text = "End time:";
            // 
            // lblWorktime5
            // 
            this.lblWorktime5.AutoSize = true;
            this.lblWorktime5.Enabled = false;
            this.lblWorktime5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime5.Location = new System.Drawing.Point(35, 266);
            this.lblWorktime5.Name = "lblWorktime5";
            this.lblWorktime5.Size = new System.Drawing.Size(69, 15);
            this.lblWorktime5.TabIndex = 41;
            this.lblWorktime5.Text = "Comments:";
            // 
            // lbError4
            // 
            this.lbError4.AutoSize = true;
            this.lbError4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError4.Location = new System.Drawing.Point(387, 302);
            this.lbError4.Name = "lbError4";
            this.lbError4.Size = new System.Drawing.Size(0, 15);
            this.lbError4.TabIndex = 42;
            // 
            // btEmployees
            // 
            this.btEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEmployees.Enabled = false;
            this.btEmployees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployees.Location = new System.Drawing.Point(267, 6);
            this.btEmployees.Name = "btEmployees";
            this.btEmployees.Size = new System.Drawing.Size(81, 33);
            this.btEmployees.TabIndex = 26;
            this.btEmployees.Text = "Employees";
            this.btEmployees.UseVisualStyleBackColor = false;
            this.btEmployees.Click += new System.EventHandler(this.btEmployees_Click);
            // 
            // lblWorktime6
            // 
            this.lblWorktime6.AutoSize = true;
            this.lblWorktime6.Enabled = false;
            this.lblWorktime6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime6.Location = new System.Drawing.Point(35, 234);
            this.lblWorktime6.Name = "lblWorktime6";
            this.lblWorktime6.Size = new System.Drawing.Size(60, 15);
            this.lblWorktime6.TabIndex = 49;
            this.lblWorktime6.Text = "Start date:";
            // 
            // lblWorktime7
            // 
            this.lblWorktime7.AutoSize = true;
            this.lblWorktime7.Enabled = false;
            this.lblWorktime7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime7.Location = new System.Drawing.Point(356, 234);
            this.lblWorktime7.Name = "lblWorktime7";
            this.lblWorktime7.Size = new System.Drawing.Size(56, 15);
            this.lblWorktime7.TabIndex = 50;
            this.lblWorktime7.Text = "End date:";
            // 
            // imResult2
            // 
            this.imResult2.Image = ((System.Drawing.Image)(resources.GetObject("imResult2.Image")));
            this.imResult2.Location = new System.Drawing.Point(355, 14);
            this.imResult2.Name = "imResult2";
            this.imResult2.Size = new System.Drawing.Size(16, 16);
            this.imResult2.TabIndex = 63;
            this.imResult2.TabStop = false;
            this.imResult2.Visible = false;
            // 
            // btSalaryTypes
            // 
            this.btSalaryTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSalaryTypes.Enabled = false;
            this.btSalaryTypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalaryTypes.Location = new System.Drawing.Point(267, 46);
            this.btSalaryTypes.Name = "btSalaryTypes";
            this.btSalaryTypes.Size = new System.Drawing.Size(81, 33);
            this.btSalaryTypes.TabIndex = 6;
            this.btSalaryTypes.Text = "Salary types";
            this.btSalaryTypes.UseVisualStyleBackColor = false;
            this.btSalaryTypes.Click += new System.EventHandler(this.btSalaryTypes_Click);
            // 
            // imResult3
            // 
            this.imResult3.Image = ((System.Drawing.Image)(resources.GetObject("imResult3.Image")));
            this.imResult3.Location = new System.Drawing.Point(355, 54);
            this.imResult3.Name = "imResult3";
            this.imResult3.Size = new System.Drawing.Size(16, 16);
            this.imResult3.TabIndex = 62;
            this.imResult3.TabStop = false;
            this.imResult3.Visible = false;
            // 
            // cbSalaryType0
            // 
            this.cbSalaryType0.Enabled = false;
            this.cbSalaryType0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalaryType0.Location = new System.Drawing.Point(355, 86);
            this.cbSalaryType0.Name = "cbSalaryType0";
            this.cbSalaryType0.Size = new System.Drawing.Size(68, 23);
            this.cbSalaryType0.TabIndex = 7;
            this.cbSalaryType0.SelectedIndexChanged += new System.EventHandler(this.cbSalaryType0_SelectedIndexChanged);
            // 
            // imResult4
            // 
            this.imResult4.Image = ((System.Drawing.Image)(resources.GetObject("imResult4.Image")));
            this.imResult4.Location = new System.Drawing.Point(355, 302);
            this.imResult4.Name = "imResult4";
            this.imResult4.Size = new System.Drawing.Size(16, 16);
            this.imResult4.TabIndex = 61;
            this.imResult4.TabStop = false;
            this.imResult4.Visible = false;
            // 
            // cbSalaryType1
            // 
            this.cbSalaryType1.Enabled = false;
            this.cbSalaryType1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalaryType1.Location = new System.Drawing.Point(355, 110);
            this.cbSalaryType1.Name = "cbSalaryType1";
            this.cbSalaryType1.Size = new System.Drawing.Size(68, 23);
            this.cbSalaryType1.TabIndex = 8;
            this.cbSalaryType1.SelectedIndexChanged += new System.EventHandler(this.cbSalaryType1_SelectedIndexChanged);
            // 
            // lblWorktime8
            // 
            this.lblWorktime8.AutoSize = true;
            this.lblWorktime8.Enabled = false;
            this.lblWorktime8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime8.Location = new System.Drawing.Point(507, 202);
            this.lblWorktime8.Name = "lblWorktime8";
            this.lblWorktime8.Size = new System.Drawing.Size(88, 15);
            this.lblWorktime8.TabIndex = 51;
            this.lblWorktime8.Text = "Reference date:";
            // 
            // cbSalaryType2
            // 
            this.cbSalaryType2.Enabled = false;
            this.cbSalaryType2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalaryType2.Location = new System.Drawing.Point(355, 134);
            this.cbSalaryType2.Name = "cbSalaryType2";
            this.cbSalaryType2.Size = new System.Drawing.Size(68, 23);
            this.cbSalaryType2.TabIndex = 9;
            this.cbSalaryType2.SelectedIndexChanged += new System.EventHandler(this.cbSalaryType2_SelectedIndexChanged);
            // 
            // lblWorktime9
            // 
            this.lblWorktime9.AutoSize = true;
            this.lblWorktime9.Enabled = false;
            this.lblWorktime9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime9.Location = new System.Drawing.Point(355, 266);
            this.lblWorktime9.Name = "lblWorktime9";
            this.lblWorktime9.Size = new System.Drawing.Size(100, 15);
            this.lblWorktime9.TabIndex = 58;
            this.lblWorktime9.Text = "Over time reason:";
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btInsert.Enabled = false;
            this.btInsert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(229, 294);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(120, 33);
            this.btInsert.TabIndex = 20;
            this.btInsert.Text = "Insert work detail";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // tbOverTimeReason
            // 
            this.tbOverTimeReason.Enabled = false;
            this.tbOverTimeReason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOverTimeReason.Location = new System.Drawing.Point(459, 262);
            this.tbOverTimeReason.MaxLength = 0;
            this.tbOverTimeReason.Name = "tbOverTimeReason";
            this.tbOverTimeReason.Size = new System.Drawing.Size(57, 23);
            this.tbOverTimeReason.TabIndex = 59;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Enabled = false;
            this.tbQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.Location = new System.Drawing.Point(291, 198);
            this.tbQuantity.MaxLength = 0;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(57, 23);
            this.tbQuantity.TabIndex = 11;
            this.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbQuantity.LostFocus += new System.EventHandler(this.tbQuantity_LostFocus);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btDelete.Enabled = false;
            this.btDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(107, 294);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(120, 33);
            this.btDelete.TabIndex = 57;
            this.btDelete.Text = "Delete work detail";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tbValue
            // 
            this.tbValue.Enabled = false;
            this.tbValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValue.Location = new System.Drawing.Point(411, 198);
            this.tbValue.MaxLength = 0;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(57, 23);
            this.tbValue.TabIndex = 12;
            this.tbValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbValue.LostFocus += new System.EventHandler(this.tbValue_LostFocus);
            // 
            // dpDate3
            // 
            this.dpDate3.Checked = false;
            this.dpDate3.Enabled = false;
            this.dpDate3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate3.Location = new System.Drawing.Point(611, 198);
            this.dpDate3.Name = "dpDate3";
            this.dpDate3.Size = new System.Drawing.Size(85, 23);
            this.dpDate3.TabIndex = 13;
            // 
            // tbStartTime
            // 
            this.tbStartTime.Enabled = false;
            this.tbStartTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartTime.Location = new System.Drawing.Point(291, 230);
            this.tbStartTime.MaxLength = 0;
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(57, 23);
            this.tbStartTime.TabIndex = 15;
            // 
            // dpDate2
            // 
            this.dpDate2.Checked = false;
            this.dpDate2.Enabled = false;
            this.dpDate2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate2.Location = new System.Drawing.Point(411, 230);
            this.dpDate2.Name = "dpDate2";
            this.dpDate2.Size = new System.Drawing.Size(85, 23);
            this.dpDate2.TabIndex = 16;
            // 
            // tbEndTime
            // 
            this.tbEndTime.Enabled = false;
            this.tbEndTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndTime.Location = new System.Drawing.Point(611, 230);
            this.tbEndTime.MaxLength = 0;
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Size = new System.Drawing.Size(57, 23);
            this.tbEndTime.TabIndex = 17;
            // 
            // dpDate1
            // 
            this.dpDate1.Checked = false;
            this.dpDate1.Enabled = false;
            this.dpDate1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate1.Location = new System.Drawing.Point(107, 230);
            this.dpDate1.Name = "dpDate1";
            this.dpDate1.Size = new System.Drawing.Size(85, 23);
            this.dpDate1.TabIndex = 14;
            // 
            // tbComments
            // 
            this.tbComments.Enabled = false;
            this.tbComments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComments.Location = new System.Drawing.Point(107, 262);
            this.tbComments.MaxLength = 0;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(241, 23);
            this.tbComments.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbError5);
            this.tabPage3.Controls.Add(this.lbError8);
            this.tabPage3.Controls.Add(this.lbError7);
            this.tabPage3.Controls.Add(this.grHolidays);
            this.tabPage3.Controls.Add(this.btHolidays);
            this.tabPage3.Controls.Add(this.imResult8);
            this.tabPage3.Controls.Add(this.cbYears);
            this.tabPage3.Controls.Add(this.lbl8);
            this.tabPage3.Controls.Add(this.lbl7);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cbEmployeesH);
            this.tabPage3.Controls.Add(this.btEmployeesH);
            this.tabPage3.Controls.Add(this.imResult7);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(706, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Employees Holidays";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbError5
            // 
            this.lbError5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbError5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError5.Location = new System.Drawing.Point(267, 281);
            this.lbError5.Name = "lbError5";
            this.lbError5.Size = new System.Drawing.Size(425, 19);
            this.lbError5.TabIndex = 76;
            // 
            // lbError8
            // 
            this.lbError8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbError8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError8.Location = new System.Drawing.Point(13, 168);
            this.lbError8.Name = "lbError8";
            this.lbError8.Size = new System.Drawing.Size(248, 47);
            this.lbError8.TabIndex = 75;
            // 
            // lbError7
            // 
            this.lbError7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbError7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError7.Location = new System.Drawing.Point(434, 14);
            this.lbError7.Name = "lbError7";
            this.lbError7.Size = new System.Drawing.Size(265, 17);
            this.lbError7.TabIndex = 74;
            // 
            // grHolidays
            // 
            this.grHolidays.AllowUserToAddRows = false;
            this.grHolidays.AllowUserToDeleteRows = false;
            this.grHolidays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grHolidays.Location = new System.Drawing.Point(267, 107);
            this.grHolidays.Name = "grHolidays";
            this.grHolidays.ReadOnly = true;
            this.grHolidays.Size = new System.Drawing.Size(425, 171);
            this.grHolidays.TabIndex = 73;
            // 
            // btHolidays
            // 
            this.btHolidays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btHolidays.Enabled = false;
            this.btHolidays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHolidays.Location = new System.Drawing.Point(16, 107);
            this.btHolidays.Name = "btHolidays";
            this.btHolidays.Size = new System.Drawing.Size(114, 33);
            this.btHolidays.TabIndex = 71;
            this.btHolidays.Text = "Read holidays";
            this.btHolidays.UseVisualStyleBackColor = false;
            this.btHolidays.Click += new System.EventHandler(this.btHolidays_Click);
            // 
            // imResult8
            // 
            this.imResult8.Image = ((System.Drawing.Image)(resources.GetObject("imResult8.Image")));
            this.imResult8.Location = new System.Drawing.Point(136, 115);
            this.imResult8.Name = "imResult8";
            this.imResult8.Size = new System.Drawing.Size(16, 16);
            this.imResult8.TabIndex = 72;
            this.imResult8.TabStop = false;
            this.imResult8.Visible = false;
            // 
            // cbYears
            // 
            this.cbYears.Enabled = false;
            this.cbYears.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYears.Location = new System.Drawing.Point(214, 56);
            this.cbYears.Name = "cbYears";
            this.cbYears.Size = new System.Drawing.Size(81, 23);
            this.cbYears.TabIndex = 70;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.White;
            this.lbl8.Enabled = false;
            this.lbl8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(3, 56);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(136, 15);
            this.lbl8.TabIndex = 69;
            this.lbl8.Text = "4. Get year. Choose year:";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.Color.White;
            this.lbl7.Enabled = false;
            this.lbl7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(3, 16);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(201, 15);
            this.lbl7.TabIndex = 65;
            this.lbl7.Text = "3. Get employees. Choose employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 67;
            // 
            // cbEmployeesH
            // 
            this.cbEmployeesH.Enabled = false;
            this.cbEmployeesH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployeesH.Location = new System.Drawing.Point(347, 12);
            this.cbEmployeesH.Name = "cbEmployeesH";
            this.cbEmployeesH.Size = new System.Drawing.Size(81, 23);
            this.cbEmployeesH.TabIndex = 64;
            this.cbEmployeesH.SelectedIndexChanged += new System.EventHandler(this.cbEmployeesH_SelectedIndexChanged);
            // 
            // btEmployeesH
            // 
            this.btEmployeesH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEmployeesH.Enabled = false;
            this.btEmployeesH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployeesH.Location = new System.Drawing.Point(214, 6);
            this.btEmployeesH.Name = "btEmployeesH";
            this.btEmployeesH.Size = new System.Drawing.Size(81, 33);
            this.btEmployeesH.TabIndex = 66;
            this.btEmployeesH.Text = "Employees";
            this.btEmployeesH.UseVisualStyleBackColor = false;
            this.btEmployeesH.Click += new System.EventHandler(this.btEmployeesH_Click);
            // 
            // imResult7
            // 
            this.imResult7.Image = ((System.Drawing.Image)(resources.GetObject("imResult7.Image")));
            this.imResult7.Location = new System.Drawing.Point(310, 13);
            this.imResult7.Name = "imResult7";
            this.imResult7.Size = new System.Drawing.Size(16, 16);
            this.imResult7.TabIndex = 68;
            this.imResult7.TabStop = false;
            this.imResult7.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbTaxRegion);
            this.tabPage2.Controls.Add(this.btContractors);
            this.tabPage2.Controls.Add(this.cbContractors);
            this.tabPage2.Controls.Add(this.btServiceTypes);
            this.tabPage2.Controls.Add(this.cbServicesType);
            this.tabPage2.Controls.Add(this.btIncomeTypes);
            this.tabPage2.Controls.Add(this.cbIncomeTypes);
            this.tabPage2.Controls.Add(this.dpServiceDate0);
            this.tabPage2.Controls.Add(this.btDeleteService);
            this.tabPage2.Controls.Add(this.btInsertService);
            this.tabPage2.Controls.Add(this.tbDocumentoNumber);
            this.tabPage2.Controls.Add(this.tbServiceQuantity);
            this.tabPage2.Controls.Add(this.tbServiceValue);
            this.tabPage2.Controls.Add(this.tbServiceComments);
            this.tabPage2.Controls.Add(this.tbNumberOfHours);
            this.tabPage2.Controls.Add(this.tbNumberOfWorkers);
            this.tabPage2.Controls.Add(this.ckUpdateService);
            this.tabPage2.Controls.Add(this.dpServiceDate1);
            this.tabPage2.Controls.Add(this.lbl6);
            this.tabPage2.Controls.Add(this.imResult6);
            this.tabPage2.Controls.Add(this.lbError6);
            this.tabPage2.Controls.Add(this.lbl9);
            this.tabPage2.Controls.Add(this.imResult9);
            this.tabPage2.Controls.Add(this.lbError9);
            this.tabPage2.Controls.Add(this.lbl10);
            this.tabPage2.Controls.Add(this.imResult10);
            this.tabPage2.Controls.Add(this.lbError10);
            this.tabPage2.Controls.Add(this.lbService0);
            this.tabPage2.Controls.Add(this.lbService1);
            this.tabPage2.Controls.Add(this.lbService2);
            this.tabPage2.Controls.Add(this.lbl11);
            this.tabPage2.Controls.Add(this.lbService3);
            this.tabPage2.Controls.Add(this.lbService4);
            this.tabPage2.Controls.Add(this.lbService5);
            this.tabPage2.Controls.Add(this.lbService6);
            this.tabPage2.Controls.Add(this.lbService7);
            this.tabPage2.Controls.Add(this.imResult11);
            this.tabPage2.Controls.Add(this.lbError11);
            this.tabPage2.Controls.Add(this.lbService8);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contractors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbTaxRegion
            // 
            this.cbTaxRegion.Enabled = false;
            this.cbTaxRegion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaxRegion.Location = new System.Drawing.Point(118, 199);
            this.cbTaxRegion.Name = "cbTaxRegion";
            this.cbTaxRegion.Size = new System.Drawing.Size(89, 23);
            this.cbTaxRegion.TabIndex = 40;
            // 
            // btContractors
            // 
            this.btContractors.Enabled = false;
            this.btContractors.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContractors.Location = new System.Drawing.Point(246, 15);
            this.btContractors.Name = "btContractors";
            this.btContractors.Size = new System.Drawing.Size(81, 33);
            this.btContractors.TabIndex = 41;
            this.btContractors.Text = "Contractors";
            this.btContractors.Click += new System.EventHandler(this.btContractors_Click);
            // 
            // cbContractors
            // 
            this.cbContractors.Enabled = false;
            this.cbContractors.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContractors.Location = new System.Drawing.Point(366, 23);
            this.cbContractors.Name = "cbContractors";
            this.cbContractors.Size = new System.Drawing.Size(105, 23);
            this.cbContractors.TabIndex = 42;
            this.cbContractors.SelectedIndexChanged += new System.EventHandler(this.cbContractors_SelectedIndexChanged);
            // 
            // btServiceTypes
            // 
            this.btServiceTypes.Enabled = false;
            this.btServiceTypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServiceTypes.Location = new System.Drawing.Point(246, 55);
            this.btServiceTypes.Name = "btServiceTypes";
            this.btServiceTypes.Size = new System.Drawing.Size(81, 33);
            this.btServiceTypes.TabIndex = 43;
            this.btServiceTypes.Text = "Service types";
            this.btServiceTypes.Click += new System.EventHandler(this.btServiceTypes_Click);
            // 
            // cbServicesType
            // 
            this.cbServicesType.Enabled = false;
            this.cbServicesType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServicesType.Location = new System.Drawing.Point(366, 63);
            this.cbServicesType.Name = "cbServicesType";
            this.cbServicesType.Size = new System.Drawing.Size(65, 23);
            this.cbServicesType.TabIndex = 44;
            this.cbServicesType.SelectedIndexChanged += new System.EventHandler(this.cbServicesType_SelectedIndexChanged);
            // 
            // btIncomeTypes
            // 
            this.btIncomeTypes.Enabled = false;
            this.btIncomeTypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncomeTypes.Location = new System.Drawing.Point(246, 95);
            this.btIncomeTypes.Name = "btIncomeTypes";
            this.btIncomeTypes.Size = new System.Drawing.Size(81, 33);
            this.btIncomeTypes.TabIndex = 45;
            this.btIncomeTypes.Text = "Income types";
            this.btIncomeTypes.Click += new System.EventHandler(this.btIncomeTypes_Click);
            // 
            // cbIncomeTypes
            // 
            this.cbIncomeTypes.Enabled = false;
            this.cbIncomeTypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIncomeTypes.Location = new System.Drawing.Point(366, 103);
            this.cbIncomeTypes.Name = "cbIncomeTypes";
            this.cbIncomeTypes.Size = new System.Drawing.Size(65, 23);
            this.cbIncomeTypes.TabIndex = 46;
            this.cbIncomeTypes.SelectedIndexChanged += new System.EventHandler(this.cbIncomeTypes_SelectedIndexChanged);
            // 
            // dpServiceDate0
            // 
            this.dpServiceDate0.Checked = false;
            this.dpServiceDate0.Enabled = false;
            this.dpServiceDate0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpServiceDate0.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpServiceDate0.Location = new System.Drawing.Point(118, 167);
            this.dpServiceDate0.Name = "dpServiceDate0";
            this.dpServiceDate0.Size = new System.Drawing.Size(85, 23);
            this.dpServiceDate0.TabIndex = 47;
            // 
            // btDeleteService
            // 
            this.btDeleteService.Enabled = false;
            this.btDeleteService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteService.Location = new System.Drawing.Point(104, 295);
            this.btDeleteService.Name = "btDeleteService";
            this.btDeleteService.Size = new System.Drawing.Size(81, 42);
            this.btDeleteService.TabIndex = 48;
            this.btDeleteService.Text = "Delete work detail";
            this.btDeleteService.Click += new System.EventHandler(this.btDeleteService_Click);
            // 
            // btInsertService
            // 
            this.btInsertService.Enabled = false;
            this.btInsertService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertService.Location = new System.Drawing.Point(17, 295);
            this.btInsertService.Name = "btInsertService";
            this.btInsertService.Size = new System.Drawing.Size(81, 42);
            this.btInsertService.TabIndex = 49;
            this.btInsertService.Text = "Insert work detail";
            this.btInsertService.Click += new System.EventHandler(this.btInsertService_Click);
            // 
            // tbDocumentoNumber
            // 
            this.tbDocumentoNumber.Enabled = false;
            this.tbDocumentoNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDocumentoNumber.Location = new System.Drawing.Point(526, 167);
            this.tbDocumentoNumber.MaxLength = 10;
            this.tbDocumentoNumber.Name = "tbDocumentoNumber";
            this.tbDocumentoNumber.Size = new System.Drawing.Size(81, 23);
            this.tbDocumentoNumber.TabIndex = 50;
            // 
            // tbServiceQuantity
            // 
            this.tbServiceQuantity.Enabled = false;
            this.tbServiceQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServiceQuantity.Location = new System.Drawing.Point(334, 199);
            this.tbServiceQuantity.MaxLength = 9;
            this.tbServiceQuantity.Name = "tbServiceQuantity";
            this.tbServiceQuantity.Size = new System.Drawing.Size(81, 23);
            this.tbServiceQuantity.TabIndex = 51;
            // 
            // tbServiceValue
            // 
            this.tbServiceValue.Enabled = false;
            this.tbServiceValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServiceValue.Location = new System.Drawing.Point(526, 199);
            this.tbServiceValue.MaxLength = 9;
            this.tbServiceValue.Name = "tbServiceValue";
            this.tbServiceValue.Size = new System.Drawing.Size(81, 23);
            this.tbServiceValue.TabIndex = 52;
            // 
            // tbServiceComments
            // 
            this.tbServiceComments.Enabled = false;
            this.tbServiceComments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServiceComments.Location = new System.Drawing.Point(118, 231);
            this.tbServiceComments.MaxLength = 0;
            this.tbServiceComments.Name = "tbServiceComments";
            this.tbServiceComments.Size = new System.Drawing.Size(369, 23);
            this.tbServiceComments.TabIndex = 53;
            // 
            // tbNumberOfHours
            // 
            this.tbNumberOfHours.Enabled = false;
            this.tbNumberOfHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberOfHours.Location = new System.Drawing.Point(118, 263);
            this.tbNumberOfHours.MaxLength = 0;
            this.tbNumberOfHours.Name = "tbNumberOfHours";
            this.tbNumberOfHours.Size = new System.Drawing.Size(81, 23);
            this.tbNumberOfHours.TabIndex = 54;
            // 
            // tbNumberOfWorkers
            // 
            this.tbNumberOfWorkers.Enabled = false;
            this.tbNumberOfWorkers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberOfWorkers.Location = new System.Drawing.Point(334, 263);
            this.tbNumberOfWorkers.MaxLength = 0;
            this.tbNumberOfWorkers.Name = "tbNumberOfWorkers";
            this.tbNumberOfWorkers.Size = new System.Drawing.Size(81, 23);
            this.tbNumberOfWorkers.TabIndex = 55;
            // 
            // ckUpdateService
            // 
            this.ckUpdateService.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckUpdateService.Location = new System.Drawing.Point(518, 263);
            this.ckUpdateService.Name = "ckUpdateService";
            this.ckUpdateService.Size = new System.Drawing.Size(65, 17);
            this.ckUpdateService.TabIndex = 56;
            this.ckUpdateService.Text = "Update";
            this.ckUpdateService.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // dpServiceDate1
            // 
            this.dpServiceDate1.Checked = false;
            this.dpServiceDate1.Enabled = false;
            this.dpServiceDate1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpServiceDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpServiceDate1.Location = new System.Drawing.Point(334, 167);
            this.dpServiceDate1.Name = "dpServiceDate1";
            this.dpServiceDate1.Size = new System.Drawing.Size(85, 23);
            this.dpServiceDate1.TabIndex = 57;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Enabled = false;
            this.lbl6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(6, 23);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(207, 15);
            this.lbl6.TabIndex = 74;
            this.lbl6.Text = "3. Get contractors. Choose contractor:";
            // 
            // imResult6
            // 
            this.imResult6.Image = ((System.Drawing.Image)(resources.GetObject("imResult6.Image")));
            this.imResult6.Location = new System.Drawing.Point(342, 23);
            this.imResult6.Name = "imResult6";
            this.imResult6.Size = new System.Drawing.Size(16, 16);
            this.imResult6.TabIndex = 75;
            this.imResult6.TabStop = false;
            this.imResult6.Visible = false;
            // 
            // lbError6
            // 
            this.lbError6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbError6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError6.Location = new System.Drawing.Point(475, 25);
            this.lbError6.Name = "lbError6";
            this.lbError6.Size = new System.Drawing.Size(220, 17);
            this.lbError6.TabIndex = 73;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Enabled = false;
            this.lbl9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(6, 58);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(195, 15);
            this.lbl9.TabIndex = 72;
            this.lbl9.Text = "4. Get service types. Choose service:";
            // 
            // imResult9
            // 
            this.imResult9.Image = ((System.Drawing.Image)(resources.GetObject("imResult9.Image")));
            this.imResult9.Location = new System.Drawing.Point(342, 63);
            this.imResult9.Name = "imResult9";
            this.imResult9.Size = new System.Drawing.Size(16, 16);
            this.imResult9.TabIndex = 76;
            this.imResult9.TabStop = false;
            this.imResult9.Visible = false;
            // 
            // lbError9
            // 
            this.lbError9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbError9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError9.Location = new System.Drawing.Point(438, 65);
            this.lbError9.Name = "lbError9";
            this.lbError9.Size = new System.Drawing.Size(257, 17);
            this.lbError9.TabIndex = 71;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Enabled = false;
            this.lbl10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(6, 95);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(229, 15);
            this.lbl10.TabIndex = 70;
            this.lbl10.Text = "5. Get income types. Choose income type:";
            // 
            // imResult10
            // 
            this.imResult10.Image = ((System.Drawing.Image)(resources.GetObject("imResult10.Image")));
            this.imResult10.Location = new System.Drawing.Point(342, 103);
            this.imResult10.Name = "imResult10";
            this.imResult10.Size = new System.Drawing.Size(16, 16);
            this.imResult10.TabIndex = 77;
            this.imResult10.TabStop = false;
            this.imResult10.Visible = false;
            // 
            // lbError10
            // 
            this.lbError10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbError10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError10.Location = new System.Drawing.Point(438, 105);
            this.lbError10.Name = "lbError10";
            this.lbError10.Size = new System.Drawing.Size(257, 17);
            this.lbError10.TabIndex = 69;
            // 
            // lbService0
            // 
            this.lbService0.AutoSize = true;
            this.lbService0.Enabled = false;
            this.lbService0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService0.Location = new System.Drawing.Point(14, 167);
            this.lbService0.Name = "lbService0";
            this.lbService0.Size = new System.Drawing.Size(73, 15);
            this.lbService0.TabIndex = 68;
            this.lbService0.Text = "Service date:";
            // 
            // lbService1
            // 
            this.lbService1.AutoSize = true;
            this.lbService1.Enabled = false;
            this.lbService1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService1.Location = new System.Drawing.Point(438, 167);
            this.lbService1.Name = "lbService1";
            this.lbService1.Size = new System.Drawing.Size(83, 15);
            this.lbService1.TabIndex = 67;
            this.lbService1.Text = "Document nr.:";
            // 
            // lbService2
            // 
            this.lbService2.AutoSize = true;
            this.lbService2.Enabled = false;
            this.lbService2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService2.Location = new System.Drawing.Point(14, 199);
            this.lbService2.Name = "lbService2";
            this.lbService2.Size = new System.Drawing.Size(65, 15);
            this.lbService2.TabIndex = 66;
            this.lbService2.Text = "Tax region:";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Enabled = false;
            this.lbl11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.Location = new System.Drawing.Point(6, 135);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(122, 15);
            this.lbl11.TabIndex = 65;
            this.lbl11.Text = "6. Insert service detail:";
            // 
            // lbService3
            // 
            this.lbService3.AutoSize = true;
            this.lbService3.Enabled = false;
            this.lbService3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService3.Location = new System.Drawing.Point(214, 199);
            this.lbService3.Name = "lbService3";
            this.lbService3.Size = new System.Drawing.Size(56, 15);
            this.lbService3.TabIndex = 64;
            this.lbService3.Text = "Quantity:";
            // 
            // lbService4
            // 
            this.lbService4.AutoSize = true;
            this.lbService4.Enabled = false;
            this.lbService4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService4.Location = new System.Drawing.Point(438, 199);
            this.lbService4.Name = "lbService4";
            this.lbService4.Size = new System.Drawing.Size(39, 15);
            this.lbService4.TabIndex = 63;
            this.lbService4.Text = "Value:";
            // 
            // lbService5
            // 
            this.lbService5.AutoSize = true;
            this.lbService5.Enabled = false;
            this.lbService5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService5.Location = new System.Drawing.Point(14, 231);
            this.lbService5.Name = "lbService5";
            this.lbService5.Size = new System.Drawing.Size(69, 15);
            this.lbService5.TabIndex = 62;
            this.lbService5.Text = "Comments:";
            // 
            // lbService6
            // 
            this.lbService6.AutoSize = true;
            this.lbService6.Enabled = false;
            this.lbService6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService6.Location = new System.Drawing.Point(14, 263);
            this.lbService6.Name = "lbService6";
            this.lbService6.Size = new System.Drawing.Size(101, 15);
            this.lbService6.TabIndex = 61;
            this.lbService6.Text = "Number of hours:";
            // 
            // lbService7
            // 
            this.lbService7.AutoSize = true;
            this.lbService7.Enabled = false;
            this.lbService7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService7.Location = new System.Drawing.Point(214, 263);
            this.lbService7.Name = "lbService7";
            this.lbService7.Size = new System.Drawing.Size(112, 15);
            this.lbService7.TabIndex = 60;
            this.lbService7.Text = "Number of workers:";
            // 
            // imResult11
            // 
            this.imResult11.Image = ((System.Drawing.Image)(resources.GetObject("imResult11.Image")));
            this.imResult11.Location = new System.Drawing.Point(197, 304);
            this.imResult11.Name = "imResult11";
            this.imResult11.Size = new System.Drawing.Size(16, 16);
            this.imResult11.TabIndex = 78;
            this.imResult11.TabStop = false;
            this.imResult11.Visible = false;
            // 
            // lbError11
            // 
            this.lbError11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbError11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError11.Location = new System.Drawing.Point(219, 303);
            this.lbError11.Name = "lbError11";
            this.lbError11.Size = new System.Drawing.Size(476, 17);
            this.lbError11.TabIndex = 59;

            // 
            // lbService8
            // 
            this.lbService8.AutoSize = true;
            this.lbService8.Enabled = false;
            this.lbService8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService8.Location = new System.Drawing.Point(214, 167);
            this.lbService8.Name = "lbService8";
            this.lbService8.Size = new System.Drawing.Size(92, 15);
            this.lbService8.TabIndex = 58;
            this.lbService8.Text = "Document date:";
            // 
            // imResult5
            // 
            this.imResult5.Image = ((System.Drawing.Image)(resources.GetObject("imResult5.Image")));
            this.imResult5.Location = new System.Drawing.Point(507, 48);
            this.imResult5.Name = "imResult5";
            this.imResult5.Size = new System.Drawing.Size(16, 16);
            this.imResult5.TabIndex = 77;
            this.imResult5.TabStop = false;
            this.imResult5.Visible = false;
            // 
            // FormApiSalariosMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 649);
            this.Controls.Add(this.imResult5);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelFooter);
            this.Controls.Add(this.textBoxFooter);
            this.Controls.Add(this.labelLine1);
            this.Controls.Add(this.labelLine0);
            this.Controls.Add(this.tbCompany0);
            this.Controls.Add(this.btInitialize);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.btErrors);
            this.Controls.Add(this.btWarnings);
            this.Controls.Add(this.tbCompany1);
            this.Controls.Add(this.tbCompany2);
            this.Controls.Add(this.imLogo);
            this.Controls.Add(this.lbCompany1);
            this.Controls.Add(this.lbCompany0);
            this.Controls.Add(this.imResult1);
            this.Controls.Add(this.imThumbsDown);
            this.Controls.Add(this.imThumbsUp);
            this.Controls.Add(this.imResult0);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbError1);
            this.Controls.Add(this.lbError0);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl0);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormApiSalariosMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sage Salários - API (Application Programming Interface)";
            ((System.ComponentModel.ISupportInitialize)(this.imLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imThumbsDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imThumbsUp)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.frSalaryType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imResult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grHolidays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult7)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imResult6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        // ===============================================================
        // Variable Declaration
        // ---------------------------------------------------------------
        // Purpose : Declares all Object to use in Application
        //
        // ===============================================================
        public Sage1GEPAPI10.PayrollAPI m_API;
        
        //
        public Sage1GEPAPI10.Employee l_Employee;
        public Sage1GEPAPI10.Employees m_Employees;

        //
        public Sage1GEPAPI10.Contractor l_Contractor;
        public Sage1GEPAPI10.Contractors m_Contractors;
        public Sage1GEPAPI10.ServiceType l_ServiceType;
        public Sage1GEPAPI10.ServiceTypes m_ServiceTypes;
        public Sage1GEPAPI10.ServiceDetail l_ServiceDetail;
        public Sage1GEPAPI10.IncomeType l_IncomeType;
        public Sage1GEPAPI10.IncomeTypes m_IncomeTypes;

        //
        public Sage1GEPAPI10.SalaryTypes m_Allowances;
        public Sage1GEPAPI10.SalaryTypes m_Deductions;
        public Sage1GEPAPI10.SalaryTypes m_Absences;
        
        //
        public Sage1GEPAPI10.WorkDetail l_WorkDetail;
        
        //
        public Sage1GEPAPI10.SalaryType l_SalaryType;
        public Sage1GEPAPI10.EmployeeHoliday l_Holiday;

        // ===============================================================
        // Enums
        // ---------------------------------------------------------------
        // Purpose : Enum Declaration
        //
        // ===============================================================
        public enum eSteps {
            Initialize = 0,
            Connect = 1,
            Employees = 2,
            SalaryTypes = 3,
            WorkTime = 4,
            Disconnect = 5,
            Contractors = 6,
            EmployeesHolidays = 7,
            Years = 8,
            ServiceTypes = 9,
            IncomeTypes = 10,
            ServiceDetail = 11
        };

        public enum SalaryTypes
        {
            Allowances = 0,
            Deductions = 1,
            Absences =2
        };



        // ===============================================================
        // Initialize
        // ---------------------------------------------------------------
        // Purpose : Initializes 1GEP API for implementation
        //
        // ===============================================================
        private void btInitialize_Click(object sender, EventArgs e){

            m_API = new Sage1GEPAPI10.PayrollAPI();

            int lResult = m_API.Initialize();
      
            if ( lResult == 0 ){
                NotifyInitializeResult (eSteps.Initialize, true);
            }
            tbCompany[0].Text = (String)"DEMO_1GEP";
            F_ShowResult (eSteps.Initialize, lResult);
        }

        // ===============================================================
        // Connect
        // ---------------------------------------------------------------
        // Purpose : Connection with specific Data Base
        // 
        // ---------------------------------------------------------------
        //  Parameters
        // -----------
        //  Company   : Company name or token
        //  User      : User Login
        //  Password  : User Password
        // ---------------------------------------------------------------
        // ===============================================================
        private void btConnect_Click(object sender, EventArgs e) {

            if ( m_API != null ){
      
                if (!tbCompany[0].Text.Equals(EMPTY) ) {

                    int lResult = m_API.Connect(tbCompany[1].Text, tbCompany[2].Text, tbCompany[0].Text);

                    if ( lResult == 0 ){
                        NotifyInitializeResult (eSteps.Connect, true);
                    }
            
                    F_ShowResult (eSteps.Connect, lResult);
                }
            }
        }

        // ===============================================================
        // GetSalaryTypes
        // ---------------------------------------------------------------
        // Purpose : Gets a Collection of GetSalaryTypes
        // 
        // ---------------------------------------------------------------
        //  Parameters
        // -----------
        //  eSalaryType   : eSalaryType.Allowance
        //                : eSalaryType.Deduction
        //                : eSalaryType.Absence
        // ---------------------------------------------------------------
        //  Returns : Collection of SalaryTypes
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void btSalaryTypes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbSalaryType.Length; i++)
            {
                cbSalaryType[i].Items.Clear();
            }
              
            if ( m_API != null ) {
                NotifyInitializeResult (eSteps.SalaryTypes, true);

                m_Allowances = m_API.GetSalaryTypes(Sage1GEPAPI10.eSalaryType.Allowance);

                if ( m_Allowances.Success ) {
                    foreach (Sage1GEPAPI10.SalaryType lSalaryType in m_Allowances){
                        cbSalaryType[0].Items.Add( lSalaryType.ID);
                    }
                }
                F_ShowResult (eSteps.SalaryTypes, m_Allowances.Result);


                m_Deductions = m_API.GetSalaryTypes(Sage1GEPAPI10.eSalaryType.Deduction);
                if ( m_Deductions.Success ){

                    foreach (Sage1GEPAPI10.SalaryType lSalaryType in m_Deductions){
                        cbSalaryType[1].Items.Add(lSalaryType.ID);

                    }
                }
                F_ShowResult (eSteps.SalaryTypes, m_Deductions.Result);

                m_Absences = m_API.GetSalaryTypes(Sage1GEPAPI10.eSalaryType.Absence);
                if ( m_Absences.Success ) {
                    foreach (Sage1GEPAPI10.SalaryType  lSalaryType in m_Absences){
                        cbSalaryType[2].Items.Add(lSalaryType.ID);
                    }
                }
                F_ShowResult (eSteps.SalaryTypes, m_Absences.Result);
            }
        }



        //===============================================================
        // DeleteWorkDetail
        // ---------------------------------------------------------------
        // Purpose : Deletes a Work Detail for a specific employee
        // ---------------------------------------------------------------
        // Parameters
        // -----------
        // Employee      : Employee ID
        // SalaryType    : Salary Type to process
        // WorkDate      : Working Day Date
        // ---------------------------------------------------------------
        // Returns
        // --------
        // Result        : Result status of Deletion
        //---------------------------------------------------------------
        //==============================================================
        private void btDelete_Click(object sender, EventArgs e)
        {

            if ( m_API != null ) {
            
                l_WorkDetail = new Sage1GEPAPI10.WorkDetail();

                if ( !cbEmployees.Text.Equals(EMPTY) ){
                    l_WorkDetail.Employee = m_Employees[cbEmployees.Text];
                }

                if (opSalaryType[0].Checked)
                {
                    if (!cbSalaryType[0].Text.Equals(EMPTY))
                    {
                        l_WorkDetail.SalaryType = m_Allowances[cbSalaryType0.Text];
                    }
                }
                else if (opSalaryType[1].Checked)
                {
                    if (!cbSalaryType[1].Text.Equals(EMPTY))
                    {
                        l_WorkDetail.SalaryType = m_Deductions[cbSalaryType1.Text];
                    }
                }
                else if (opSalaryType[2].Checked)
                {
                    if (!cbSalaryType[2].Text.Equals(EMPTY))
                    {
                        l_WorkDetail.SalaryType = m_Absences[cbSalaryType2.Text];
                    }
                }
      
            if (!dpDate0.Text.Equals(EMPTY)) {
                l_WorkDetail.WorkDate = dpDate[0].Text;
            }

            int lResult = m_API.DeleteWorkDetail(l_WorkDetail);

            F_ShowResult (eSteps.WorkTime, lResult);
            }

        }

        // ===============================================================
        // Disconnect
        // ---------------------------------------------------------------
        // Purpose : Disconnect from specific Data Base
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void btDisconnect_Click(object sender, EventArgs e)
        {
            if ( m_API != null ) {
                m_API.Disconnect();
            }

            DisabledAll();
            for (int i = 0; i < tbCompany.Length; i++)
            {
                tbCompany[i].Enabled = true;
            }

            lbCompany0.Enabled = true;
            lbCompany1.Enabled = true;

            lbl1.Enabled = true;
            lbl0.Enabled = false;

            btConnect.Enabled = true;
            btInitialize.Enabled = false;
        }

        // ===============================================================
        // Reset
        // ---------------------------------------------------------------
        // Purpose : Resets Connection
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void btReset_Click(object sender, EventArgs e)
        {
            if ( m_API != null ){
                m_API.Terminate();
                APIterminate();
            }
            DisabledAll();
        }


        private void btErrors_Click(object sender, EventArgs e)
        {
            ShowErrors lShowError = new ShowErrors();
            lShowError.IsErrorMessage = true;
            lShowError.ShowDialog();

        }
        private void btWarnings_Click(object sender, EventArgs e)
        {
            ShowErrors lShowError = new ShowErrors();
            lShowError.IsErrorMessage = false;
            lShowError.ShowDialog();

        }
        private void btClose_Click(object sender, EventArgs e)
        {
          if ( m_API != null ) {
            m_API.Terminate();
            APIterminate();
          }
          Close();
          return;
        }

        // ===============================================================
        // Terminate
        // ---------------------------------------------------------------
        // Purpose : Terminates API
        //         : Removes all Objects
        // ---------------------------------------------------------------
        // ===============================================================
        private void APIterminate(){
        
            Marshal.ReleaseComObject(m_API);
            m_API = null;

            if (m_Employees != null)
            {
                Marshal.ReleaseComObject(m_Employees);
                m_Employees = null;
            }

            if (l_Employee != null)
            {
                Marshal.ReleaseComObject(l_Employee);
                l_Employee = null;
            }
            if (m_Allowances != null)
            {
                Marshal.ReleaseComObject(m_Allowances);
                m_Allowances = null;
            }
            if (m_Deductions != null)
            {
                Marshal.ReleaseComObject(m_Deductions);
                m_Deductions = null;
            }
            if (m_Absences != null)
            {
                Marshal.ReleaseComObject(m_Absences);
                m_Absences = null;
            }
            if (l_WorkDetail != null)
            {
                Marshal.ReleaseComObject(l_WorkDetail);
                l_WorkDetail = null;
            }
            if (l_SalaryType != null)
            {
                Marshal.ReleaseComObject(l_SalaryType);
                l_SalaryType = null;
            }

        }


        private void NotifyInitializeResult (eSteps iStep , Boolean iResult )   {

            switch (iStep) {

                case eSteps.Initialize:
                    lbl1.Enabled = iResult;
    
                    for (int i = 0; i < tbCompany.Length; i++)
                    {
                        tbCompany[i].Enabled = iResult;
                    }
                    lbCompany0.Enabled = iResult;
                    lbCompany1.Enabled = iResult;

                    btConnect.Enabled = iResult;

                    lbl0.Enabled = ! iResult;
                    btInitialize.Enabled = ! iResult;
                    tbCompany[0].Focus();
                    break;

            case eSteps.Connect:

                    lbl1.Enabled = !iResult;
                    lbl2.Enabled = iResult;
                    lbl7.Enabled = iResult;

                    btEmployees.Enabled = iResult;
                    btEmployeesH.Enabled = iResult;
                    btContractors.Enabled = iResult;
                    btDisconnect.Enabled = iResult;

                    for (int i = 0; i < tbCompany.Length; i++)
                    {
                        tbCompany[i].Enabled = iResult;
                    }
              
                    lbCompany0.Enabled = iResult;
                    lbCompany1.Enabled = iResult;

                    btConnect.Enabled = ! iResult;

                    lblGeneric[((int)eSteps.Disconnect)].Enabled = iResult;

                    if ( iResult ) {
                        btEmployees.Focus();
                    }
                    break;

                case eSteps.Employees:
                    cbEmployees.Enabled = iResult;
                    btSalaryTypes.Enabled = iResult;
                    lblGeneric[((int)eSteps.SalaryTypes)].Enabled = iResult;
                    break;


                 case eSteps.EmployeesHolidays:
                    cbEmployeesH.Enabled = iResult;
                    btHolidays.Enabled = iResult;
                    cbYears.Enabled = iResult;
                    lblGeneric[((int)eSteps.Years)].Enabled = iResult;
                    break;

                case eSteps.SalaryTypes:

                    for (int i = 0; i < cbSalaryType.Length; i++)
                    {
                        cbSalaryType[i].Enabled = iResult;
                    }
                    
                    lblGeneric[((int)eSteps.WorkTime)].Enabled = iResult;
         

                    for (int i = 0; i < lblWorktime.Length; i++)
                    {
                        lblWorktime[i].Enabled = iResult;
                    }

                    for (int i = 0; i < dpDate.Length; i++)
                    {
                        dpDate[i].Enabled = iResult;
                    }

                    frSalaryType.Enabled = iResult;

                    tbQuantity.Enabled = iResult;
                    tbValue.Enabled = iResult;
                    tbStartTime.Enabled = iResult;
                    tbEndTime.Enabled = iResult;
                    tbComments.Enabled = iResult;
                    tbOverTimeReason.Enabled = iResult;

                    btDisconnect.Enabled = iResult;
                    btInsert.Enabled = iResult;
                    btDelete.Enabled = iResult;

                    break;


                case eSteps.Contractors:
                    cbContractors.Enabled = iResult;
                    btServiceTypes.Enabled = iResult;
                    lblGeneric[((int)eSteps.ServiceTypes)].Enabled = iResult;
                    break;



                case eSteps.ServiceTypes:
                    cbServicesType.Enabled = iResult;
                    btIncomeTypes.Enabled = iResult;
                    lblGeneric[((int)eSteps.IncomeTypes)].Enabled = iResult;
                    break;

                case eSteps.IncomeTypes:
                    cbIncomeTypes.Enabled = iResult;
                    lblGeneric[((int)eSteps.ServiceDetail)].Enabled = iResult;


                    for (int i = 0; i < lblWorktime.Length; i++)
                    {
                        lblWorktime[i].Enabled = iResult;
                    }

                    for (int i = 0; i < lblServs.Length; i++)
                    {
                        lblServs[i].Enabled = iResult;
                    }

                    dpServiceDate0.Enabled = iResult;
                    dpServiceDate1.Enabled = iResult;
                    tbDocumentoNumber.Enabled = iResult;
                    tbServiceQuantity.Enabled = iResult;
                    tbServiceValue.Enabled = iResult;
                    tbServiceComments.Enabled = iResult;
                    tbNumberOfHours.Enabled = iResult;
                    tbNumberOfWorkers.Enabled = iResult;
                    cbTaxRegion.Enabled = iResult;


                    btDisconnect.Enabled = iResult;
                    btInsertService.Enabled = iResult;
                    btDeleteService.Enabled = iResult;

                    break;

            }
        }

        // ===============================================================
        // DisabledAll
        // ---------------------------------------------------------------
        // Purpose : Disable all Objects on form
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void DisabledAll()
        {
            for (int i = 0; i < lblGeneric.Length; i++)
            {
                lblGeneric[i].Enabled = true;
            }

            for (int i = 0; i < lbError.Length; i++)
            {
                lbError[i].Text = EMPTY;
            }

            for (int i = 0; i < cbSalaryType.Length; i++)
            {
                cbSalaryType[i].Items.Clear();
                cbSalaryType[i].Enabled = false;
            }

            for (int i = 0; i < imResult.Length; i++)
            {
                imResult[i].Visible = false;
            }

            for (int i = 0; i < tbCompany.Length; i++)
            {
                tbCompany[i].Text = EMPTY;
                tbCompany[i].Enabled = false;
            }

            lbCompany0.Enabled = false;
            lbCompany1.Enabled = false;

            for (int i = 0; i < lblWorktime.Length; i++)
            {
                lblWorktime[i].Enabled = false;
            }

            for (int i = 0; i < dpDate.Length; i++)
            {
                dpDate[i].Enabled = false;
                dpDate[i].Text = EMPTY;
            }

            cbEmployees.Items.Clear();
            cbEmployees.Enabled = false;
            cbEmployeesH.Enabled = false;

            btInitialize.Enabled = true;
            btConnect.Enabled = false;
            btEmployees.Enabled = false;
            btEmployeesH.Enabled = false;
            btSalaryTypes.Enabled = false;
            btContractors.Enabled = false;
            btDisconnect.Enabled = false;
            btInsert.Enabled = false;
            btDelete.Enabled = false;

            frSalaryType.Enabled = false;

            grHolidays.Enabled = false;

        }

        private void F_ShowResult (eSteps iStep, long iResult)   {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApiSalariosMain));
 
            int index = (int)iStep;

            imResult[index].Visible = true;
            
            if ( iResult == 0 ) {
                imResult[index].Image = ((System.Drawing.Image)(resources.GetObject("imThumbsUp.Image")));
                lbError[index].Text = EMPTY;

            } else if ( iResult < 0 ) {
                imResult[index].Image = ((System.Drawing.Image)(resources.GetObject("imThumbsDown.Image")));
                lbError[index].Text = "Error " + iResult + " : " + m_API.Error;

            } else {
                imResult[index].Image = ((System.Drawing.Image)(resources.GetObject("imThumbsUp.Image")));
                lbError[index].Text = "Warning " + iResult + " : " + m_API.Error;
            }

        }

        private void tbQuantity_LostFocus()
        {
            if ( ! IsNumeric(tbQuantity.Text) ){
                tbQuantity.Text = "0";
            }
        }

        private void tbValue_LostFocus()
        {
            if ( ! IsNumeric(tbValue.Text) ){
                tbValue.Text = "0";
            }
        }

        public Boolean IsNumeric(string text){
            double test;
            return double.TryParse(text, out test);
        }

        // ===============================================================
        // Selection of Employee
        // ---------------------------------------------------------------
        // Purpose : Selects an Employee for process
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_Employee = m_Employees[cbEmployees.Text];
            lbError[(int)eSteps.Employees].Text = l_Employee.Name;
        }


        // ===============================================================
        // Selection of SalaryType
        // ---------------------------------------------------------------
        // Purpose : Selects an SalaryType for process
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void cbSalaryType0_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_SalaryType = m_Allowances[cbSalaryType[(int)SalaryTypes.Allowances].Text];
            lbSalaryTypeName[(int)SalaryTypes.Allowances].Text = l_SalaryType.Name;

        }

        private void cbSalaryType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_SalaryType = m_Deductions[cbSalaryType[(int)SalaryTypes.Deductions].Text];
            lbSalaryTypeName[(int)SalaryTypes.Deductions].Text = l_SalaryType.Name;
        }

        private void cbSalaryType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_SalaryType = m_Absences[cbSalaryType[(int)SalaryTypes.Absences].Text];
            lbSalaryTypeName[(int)SalaryTypes.Absences].Text = l_SalaryType.Name;
        }

        // ===============================================================
        // GetEmployees
        // ---------------------------------------------------------------
        //  Purpose : Gets a Collection of Employees
        // 
        // ---------------------------------------------------------------
        //  Returns : Collection of Employees
        // 
        // ---------------------------------------------------------------
        // ===============================================================

        private void btEmployeesH_Click(object sender, EventArgs e)
        {
  
            cbEmployeesH.Items.Clear();

            if (m_API != null)
            {

                m_Employees = m_API.GetEmployees();

                if (m_Employees.Success)
                {
                    NotifyInitializeResult(eSteps.EmployeesHolidays, true);
                }

                foreach (Sage1GEPAPI10.Employee l_Employee in m_Employees)
                {
                    cbEmployeesH.Items.Add(l_Employee.ID);
                }
                F_ShowResult(eSteps.EmployeesHolidays, m_Employees.Result);
            }
        }

        // ===============================================================
        // GetHolidays
        // ---------------------------------------------------------------
        //  Purpose : Gets a Collection of Employee Holidays
        // 
        // ---------------------------------------------------------------
        //  Returns : Collection of Employee Holidays
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void btHolidays_Click(object sender, EventArgs e)
        {

            //Employee this[ref object iIndexOrKey] { get; }

            grHolidays.Rows.Clear();
            grHolidays.Refresh();

            if (m_API != null)
            {
                if (!cbEmployeesH.Text.Equals(EMPTY) && !cbYears.Text.Equals(EMPTY) && (m_Employees != null) )
                {
                    if (m_API.GetEmployeeHolidays( m_Employees[cbEmployeesH.Text], Convert.ToInt16(cbYears.Text)  ))
                    {
                        foreach (Sage1GEPAPI10.EmployeeHoliday lHoliday in m_Employees[cbEmployeesH.Text].Holidays)
                        {
                        grHolidays.Rows.Add(lHoliday.StartDate, lHoliday.EndDate, lHoliday.WorkDays, lHoliday.Comments);
                        }
                    }

                    int lResult = m_Employees[cbEmployeesH.Text].Holidays.Result;

                    F_ShowResult(eSteps.Years, lResult);
                 }
        }
        }

        private void cbEmployeesH_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_Employee = m_Employees[cbEmployeesH.Text];
            lbError[(int)eSteps.EmployeesHolidays].Text = l_Employee.Name;
        }

        // ===============================================================
        // GetEmployees
        // ---------------------------------------------------------------
        //  Purpose : Gets a Collection of Employees
        // 
        // ---------------------------------------------------------------
        //  Returns : Collection of Employees
        // 
        // ---------------------------------------------------------------
        // ===============================================================

        private void btEmployees_Click(object sender, EventArgs e)
        {
            cbEmployees.Items.Clear();

            if (m_API != null)
            {
                m_Employees = m_API.GetEmployees();

                if (m_Employees.Success)
                {
                    NotifyInitializeResult(eSteps.Employees, true);
                }

                foreach (Sage1GEPAPI10.Employee l_Employee in m_Employees)
                {
                    cbEmployees.Items.Add(l_Employee.ID);
                }
                F_ShowResult(eSteps.Employees, m_Employees.Result);
            }
        }

        // ===============================================================
        // GetContractors
        // ---------------------------------------------------------------
        //  Purpose : Gets a Collection of Contractors
        // 
        // ---------------------------------------------------------------
        //  Returns : Collection of Contractors
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void btContractors_Click(object sender, EventArgs e)
        {
            cbContractors.Items.Clear();
            if (m_API != null)
            {
                m_Contractors = m_API.GetContractors();
                if (m_Contractors.Success) {
                    NotifyInitializeResult(eSteps.Contractors, true);
                    foreach (Sage1GEPAPI10.Contractor l_Contractor in m_Contractors) {
                        cbContractors.Items.Add(l_Contractor.ID);
                    }
                }
                F_ShowResult(eSteps.Contractors, m_Contractors.Result);
            }
        }



        // ===============================================================
        // GetServiceTypes
        // ---------------------------------------------------------------
        //  Purpose : Gets a Collection of ServiceTypes
        // 
        // ---------------------------------------------------------------
        //  Returns : Collection of ServiceTypes
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void btServiceTypes_Click(object sender, EventArgs e)
        {
            cbServicesType.Items.Clear();

            if (m_API != null)
            {
                m_ServiceTypes = m_API.GetServiceTypes();

                if (m_ServiceTypes.Success) {
                    NotifyInitializeResult(eSteps.ServiceTypes, true);
                    foreach (Sage1GEPAPI10.ServiceType l_ServiceType in m_ServiceTypes) {
                        cbServicesType.Items.Add(l_ServiceType.ID); 
                    }
                }

                F_ShowResult(eSteps.ServiceTypes, m_Contractors.Result);
            }

        }



        // ===============================================================
        // GetIncomeTypes
        // ---------------------------------------------------------------
        //  Purpose : Gets a Collection of IncomeTypes
        // 
        // ---------------------------------------------------------------
        //  Returns : Collection of IncomeTypes
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void btIncomeTypes_Click(object sender, EventArgs e)
        {
            cbIncomeTypes.Items.Clear();
            if (m_API != null)
            {
                m_IncomeTypes = m_API.GetIncomeTypes();
                if (m_IncomeTypes.Success) {
                    NotifyInitializeResult(eSteps.IncomeTypes, true);
                    foreach (Sage1GEPAPI10.IncomeType l_IncomeType in m_IncomeTypes) {
                        cbIncomeTypes.Items.Add(l_IncomeType.ID);
                    }
            }
                F_ShowResult(eSteps.IncomeTypes, m_Contractors.Result);
            }
        }


        // ===============================================================
        // Selection of Contractor
        // ---------------------------------------------------------------
        // Purpose : Selects an Contractor for process
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void cbContractors_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_Contractor = m_Contractors[cbContractors.Text];
            lbError[(int)eSteps.Contractors].Text = l_Contractor.Name;
        }

        // ===============================================================
        // Selection of ServiceType
        // ---------------------------------------------------------------
        // Purpose : Selects a ServiceType for process
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void cbServicesType_SelectedIndexChanged(object sender, EventArgs e)
        {

            l_ServiceType = m_ServiceTypes[cbServicesType.Text];
            lbError[(int)eSteps.ServiceTypes].Text = l_ServiceType.Name;
        }


        // ===============================================================
        // Selection of IncomeType
        // ---------------------------------------------------------------
        // Purpose : Selects a IncomeType for process
        // 
        // ---------------------------------------------------------------
        // ===============================================================
        private void cbIncomeTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_IncomeType = m_IncomeTypes[cbIncomeTypes.Text];
            lbError[(int)eSteps.IncomeTypes].Text = l_IncomeType.Name;
        }


        private void tbQuantity_LostFocus(object sender, EventArgs e)
        {
                tbQuantity.Text = validateValues(tbQuantity.Text);                
        }

        private void tbValue_LostFocus(object sender, EventArgs e)
        {
            tbValue.Text = validateValues(tbValue.Text);
        }

        private string validateValues(String inputText)
        {
            Double number = 0;

            inputText = inputText.Replace('.', m_DecimalSymbol);
            inputText = inputText.Replace(',', m_DecimalSymbol);
            Double.TryParse(inputText, out number);

            if (number == 0) {
                inputText = "0";
            }

            return inputText;
        }


        //===============================================================
        // AddWorkDetail
        // ---------------------------------------------------------------
        // Purpose : Adds a Work Detail for a specific employee
        // ---------------------------------------------------------------
        // Parameters
        // -----------
        // Employee      : Employee ID
        // SalaryType    : Salary Type to process
        // WorkDate      : Working Day Date
        // Quantity      : Quantity, depends on SalaryType
        // Value         : Quantity, depends on SalaryType
        // StartTime     : Start Time of Work Detail, Absence, etc.
        // EndTime       : End Time, Absence, etc.
        // Comments      : Comments about Work Detail
        // ReferenceDate : Reference Date of Work Detail
        // OverTimeReason: Comments about Over Time Reason
        //---------------------------------------------------------------
        // Returns
        // --------
        // Result        : Result status of Insertion
        // ---------------------------------------------------------------
        // ===============================================================
        private void btInsert_Click(object sender, EventArgs e)
        {

            if (m_API != null)
            {

                l_WorkDetail = new Sage1GEPAPI10.WorkDetail();

                if (!cbEmployees.Text.Equals(EMPTY))
                {
                    l_WorkDetail.Employee = m_Employees[cbEmployees.Text];
                }

                if (opSalaryType[0].Checked)
                {
                    if (!cbSalaryType[0].Equals(EMPTY))
                    {
                        l_WorkDetail.SalaryType = m_Allowances[cbSalaryType0.Text];
                    }
                }
                else if (opSalaryType[1].Checked)
                {
                    if (!cbSalaryType[1].Equals(EMPTY))
                    {
                        l_WorkDetail.SalaryType = m_Deductions[cbSalaryType1.Text];
                    }
                }
                else if (opSalaryType[2].Checked)
                {
                    if (!cbSalaryType[2].Equals(EMPTY))
                    {
                        l_WorkDetail.SalaryType = m_Absences[cbSalaryType2.Text];
                    }
                }


                if (!dpDate[0].Text.Equals(EMPTY))
                {
                    l_WorkDetail.WorkDate = dpDate[0].Text;
                }

                if (IsNumeric(tbQuantity.Text))
                {
                    l_WorkDetail.Quantity = Decimal.Parse((tbQuantity.Text), NumberStyles.Currency);
                }

                if (IsNumeric(tbValue.Text))
                {
                    l_WorkDetail.Value = Decimal.Parse((tbValue.Text), NumberStyles.Currency);
                }

                l_WorkDetail.StartDate = dpDate[1].Text;
                l_WorkDetail.StartTime = tbStartTime.Text;

                l_WorkDetail.EndDate = dpDate[2].Text;
                l_WorkDetail.EndTime = tbEndTime.Text;
                l_WorkDetail.Comments = tbComments.Text;

                l_WorkDetail.ReferenceDate = dpDate[3].Text;
                l_WorkDetail.OverTimeReason = tbOverTimeReason.Text;

                int lResult = m_API.AddWorkDetail(l_WorkDetail, (ckUpdate.Checked = true));

                F_ShowResult(eSteps.WorkTime, lResult);

            }
        }


        //===============================================================
        // AddWorkDetail
        //---------------------------------------------------------------
        // Purpose : Adds a Work Detail for a specific employee
        //
        //---------------------------------------------------------------
        // Parameters
        //-----------
        // Employee      : Employee ID
        // SalaryType    : Salary Type to process
        // WorkDate      : Working Day Date
        // Quantity      : Quantity, depends on SalaryType
        // Value         : Quantity, depends on SalaryType
        // StartTime     : Start Time of Work Detail, Absence, etc.
        // EndTime       : End Time, Absence, etc.
        // Comments      : Comments about Work Detail
        // ReferenceDate : Reference Date of Work Detail
        // OverTimeReason: Comments about Over Time Reason
        //---------------------------------------------------------------
        // Returns
        //--------
        // Result        : Result status of Insertion
        //---------------------------------------------------------------
        //===============================================================
        private void btInsertService_Click(object sender, EventArgs e)
        {
        
            if (m_API != null)
            {

                l_ServiceDetail = new Sage1GEPAPI10.ServiceDetail();


                if(!this.cbContractors.Text.Equals(EMPTY)) {
                    l_ServiceDetail.Contractor = m_Contractors[this.cbContractors.Text];
                }

                if (!this.cbServicesType.Text.Equals(EMPTY)) {
                    l_ServiceDetail.ServiceType = m_ServiceTypes[this.cbServicesType.Text];
                }
                if (!this.cbIncomeTypes.Text.Equals(EMPTY)) {
                    l_ServiceDetail.IncomeType = m_IncomeTypes[this.cbIncomeTypes.Text];
                }

                if (!this.dpServiceDate0.Text.Equals(EMPTY)) {
                    l_ServiceDetail.ServiceDate = this.dpServiceDate0.Text;
                }

                if (!this.dpServiceDate1.Text.Equals(EMPTY))
                {
                    l_ServiceDetail.DocumentDate = this.dpServiceDate1.Text;
                }

                if (IsNumeric(this.tbServiceQuantity.Text) && (this.tbServiceQuantity.Text.Length) < 10) {
                    l_ServiceDetail.Quantity = Decimal.Parse((tbServiceQuantity.Text), NumberStyles.Currency);
                   
                }

                if (IsNumeric(this.tbServiceValue.Text) && (this.tbServiceValue.Text.Length) < 10 ) {
                    l_ServiceDetail.Value = Decimal.Parse((tbServiceValue.Text), NumberStyles.Currency);                  
                }


                l_ServiceDetail.DocumentNumber = this.tbDocumentoNumber.Text;
                l_ServiceDetail.TaxRegion = (Sage1GEPAPI10.eTaxRegion) (this.cbTaxRegion.SelectedIndex+1);
                
                l_ServiceDetail.Comments = this.tbServiceComments.Text;

                if (IsNumeric(this.tbNumberOfHours.Text)) {
                    l_ServiceDetail.NumberOfHours = Decimal.Parse((this.tbNumberOfHours.Text), NumberStyles.Currency); 
                }

                if (IsNumeric(this.tbNumberOfWorkers.Text)) {
                    l_ServiceDetail.NumberOfWorkers = Decimal.Parse((this.tbNumberOfWorkers.Text), NumberStyles.Currency);
                } 

                int lResult = m_API.AddServiceDetail(l_ServiceDetail, (this.ckUpdateService.Checked = true));

                F_ShowResult(eSteps.ServiceDetail, lResult);

            }
        }

        //===============================================================
        // DeleteWorkDetail
        //---------------------------------------------------------------
        // Purpose : Deletes a Work Detail for a specific employee
        //
        //---------------------------------------------------------------
        // Parameters
        //-----------
        // Employee      : Employee ID
        // SalaryType    : Salary Type to process
        // WorkDate      : Working Day Date
        //---------------------------------------------------------------
        // Returns
        //--------
        // Result        : Result status of Deletion
        //---------------------------------------------------------------
        //===============================================================
        private void btDeleteService_Click(object sender, EventArgs e)
        {

            if (m_API != null)
            {
                l_ServiceDetail = new Sage1GEPAPI10.ServiceDetail();

               
                if (!this.cbContractors.Text.Equals(EMPTY))
                {
                    l_ServiceDetail.Contractor = m_Contractors[this.cbContractors.Text];
                }
                    
    
                if (!this.cbServicesType.Text.Equals(EMPTY))
                {
                    l_ServiceDetail.ServiceType = m_ServiceTypes[this.cbServicesType.Text];
                }
                 
                    
                if (!this.cbIncomeTypes.Text.Equals(EMPTY)){
                    l_ServiceDetail.IncomeType = m_IncomeTypes[this.cbIncomeTypes.Text];
                }

                if (!this.dpServiceDate0.Text.Equals(EMPTY)){
                    l_ServiceDetail.ServiceDate = this.dpServiceDate0.Text;
                }

                int lResult = m_API.DeleteServiceDetail(l_ServiceDetail);

                F_ShowResult(eSteps.ServiceDetail, lResult);
                
            }
        }

    } // end class

} // end namespace
