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


    public class FormApiSalarios : System.Windows.Forms.Form
    {

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btEmployees;
        private System.Windows.Forms.Button btErrors;
        private System.Windows.Forms.Button btInitialize;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSalaryTypes;
        private System.Windows.Forms.Button btWarnings;
        private System.Windows.Forms.CheckBox ckUpdate;
        private System.Windows.Forms.ComboBox cbEmployees;
        private System.Windows.Forms.ComboBox cbSalaryType0;
        private System.Windows.Forms.ComboBox cbSalaryType1;
        private System.Windows.Forms.ComboBox cbSalaryType2;
        private System.Windows.Forms.DateTimePicker dpDate0;
        private System.Windows.Forms.DateTimePicker dpDate1;
        private System.Windows.Forms.DateTimePicker dpDate2;
        private System.Windows.Forms.DateTimePicker dpDate3;
        private System.Windows.Forms.GroupBox frSalaryType;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Label labelLine0;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Label lbCompany0;
        private System.Windows.Forms.Label lbCompany1;
        private System.Windows.Forms.Label lbError0;
        private System.Windows.Forms.Label lbError1;
        private System.Windows.Forms.Label lbError2;
        private System.Windows.Forms.Label lbError3;
        private System.Windows.Forms.Label lbError4;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblSalarytype0;
        private System.Windows.Forms.Label lblSalarytype1;
        private System.Windows.Forms.Label lblSalarytype2;
        private System.Windows.Forms.Label lblWorktime0;
        private System.Windows.Forms.Label lblWorktime1;
        private System.Windows.Forms.Label lblWorktime2;
        private System.Windows.Forms.Label lblWorktime3;
        private System.Windows.Forms.Label lblWorktime4;
        private System.Windows.Forms.Label lblWorktime5;
        private System.Windows.Forms.Label lblWorktime6;
        private System.Windows.Forms.Label lblWorktime7;
        private System.Windows.Forms.Label lblWorktime8;
        private System.Windows.Forms.Label lblWorktime9;
        private System.Windows.Forms.PictureBox imLogo;
        private System.Windows.Forms.PictureBox imResult0;
        private System.Windows.Forms.PictureBox imResult1;
        private System.Windows.Forms.PictureBox imResult2;
        private System.Windows.Forms.PictureBox imResult3;
        private System.Windows.Forms.PictureBox imResult4;
        private System.Windows.Forms.PictureBox imThumbsDown;
        private System.Windows.Forms.PictureBox imThumbsUp;
        private System.Windows.Forms.RadioButton opSalaryType0;
        private System.Windows.Forms.RadioButton opSalaryType1;
        private System.Windows.Forms.RadioButton opSalaryType2;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.TextBox tbCompany0;
        private System.Windows.Forms.TextBox tbCompany1;
        private System.Windows.Forms.TextBox tbCompany2;
        private System.Windows.Forms.TextBox tbEndTime;
        private System.Windows.Forms.TextBox tbOverTimeReason;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbStartTime;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.TextBox textBoxFooter;
        private Label lblSalaryTypeName0;
        private Label lblSalaryTypeName1;
        private Label lblSalaryTypeName2;

        //
        // Control Arrays
        //
        private System.Windows.Forms.Label[] lbl;
        private System.Windows.Forms.Label[] lbError;
        private System.Windows.Forms.Label[] lbSalaryTypeName;
        private System.Windows.Forms.PictureBox[] imResult;
        private System.Windows.Forms.TextBox[] tbCompany;
        private System.Windows.Forms.Label[] lblWorktime;
        private System.Windows.Forms.ComboBox[] cbSalaryType;
        private System.Windows.Forms.DateTimePicker[] dpDate;
        private System.Windows.Forms.RadioButton[] opSalaryType;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FormApiSalarios()
        {

            // ############################################################################################
            //
            // if by any circumstance you want to build your project arround the SageBGEPAPI10
            // not usings this dll as a refrence in your project, you might not refrence the dll
            // and instance all Classes and call all Methods by Reflection
            //
            // Here you can find an approach to Reflection here:
            //
            // Use_BGEP_API_by_Reflection();
            //
            // ############################################################################################

            // Required for Windows Form Designer support
            InitializeComponent();
            
            //
            // Control Arrays Populate
            //
            lbl = new Label[] { lbl0, lbl1, lbl2, lbl3, lbl4, lbl5 };
            lbError = new Label[] {lbError0, lbError1, lbError2, lbError3, lbError4};
            lbSalaryTypeName = new Label[] { lblSalaryTypeName0, lblSalaryTypeName1, lblSalaryTypeName2 };
            lblWorktime = new Label[] { lblWorktime0, lblWorktime1, lblWorktime2, lblWorktime3, lblWorktime4, lblWorktime5, lblWorktime6, lblWorktime7, lblWorktime8, lblWorktime9 };
            imResult = new PictureBox[] {imResult0, imResult1,imResult2,imResult3,imResult4};
            tbCompany = new TextBox[] { tbCompany0, tbCompany1, tbCompany2 };
            cbSalaryType = new ComboBox[] { cbSalaryType0, cbSalaryType1, cbSalaryType2 };
            dpDate = new DateTimePicker[] { dpDate0, dpDate1, dpDate2, dpDate3 };
            opSalaryType = new RadioButton[] { opSalaryType0, opSalaryType1, opSalaryType2 };

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
            PayrollAPI_ComType = Type.GetTypeFromProgID("SageBGEPAPI10.PayrollAPI");
            Employees_ComType  = Type.GetTypeFromProgID("SageBGEPAPI10.Employees");
            Employee_ComType  = Type.GetTypeFromProgID("SageBGEPAPI10.Employee");

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
                new object[] { "Sage", "123abc", "DEMO_BGEP" });
            
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
                    String employeeInfo = "ID: " + ID + " - Name: " + Name + " - eMail: " + EMail + " - DateOfBirth: " +  DateOfBirth + "";

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApiSalarios));
            this.btClose = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btEmployees = new System.Windows.Forms.Button();
            this.btErrors = new System.Windows.Forms.Button();
            this.btInitialize = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btSalaryTypes = new System.Windows.Forms.Button();
            this.btWarnings = new System.Windows.Forms.Button();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.cbSalaryType0 = new System.Windows.Forms.ComboBox();
            this.cbSalaryType1 = new System.Windows.Forms.ComboBox();
            this.cbSalaryType2 = new System.Windows.Forms.ComboBox();
            this.ckUpdate = new System.Windows.Forms.CheckBox();
            this.dpDate0 = new System.Windows.Forms.DateTimePicker();
            this.dpDate1 = new System.Windows.Forms.DateTimePicker();
            this.dpDate2 = new System.Windows.Forms.DateTimePicker();
            this.dpDate3 = new System.Windows.Forms.DateTimePicker();
            this.imLogo = new System.Windows.Forms.PictureBox();
            this.imResult0 = new System.Windows.Forms.PictureBox();
            this.imResult1 = new System.Windows.Forms.PictureBox();
            this.imResult2 = new System.Windows.Forms.PictureBox();
            this.imResult3 = new System.Windows.Forms.PictureBox();
            this.imResult4 = new System.Windows.Forms.PictureBox();
            this.imThumbsDown = new System.Windows.Forms.PictureBox();
            this.imThumbsUp = new System.Windows.Forms.PictureBox();
            this.lbCompany0 = new System.Windows.Forms.Label();
            this.lbCompany1 = new System.Windows.Forms.Label();
            this.lbError0 = new System.Windows.Forms.Label();
            this.lbError1 = new System.Windows.Forms.Label();
            this.lbError2 = new System.Windows.Forms.Label();
            this.lbError3 = new System.Windows.Forms.Label();
            this.lbError4 = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblSalarytype0 = new System.Windows.Forms.Label();
            this.lblSalarytype1 = new System.Windows.Forms.Label();
            this.lblSalarytype2 = new System.Windows.Forms.Label();
            this.lblWorktime0 = new System.Windows.Forms.Label();
            this.lblWorktime1 = new System.Windows.Forms.Label();
            this.lblWorktime2 = new System.Windows.Forms.Label();
            this.lblWorktime3 = new System.Windows.Forms.Label();
            this.lblWorktime4 = new System.Windows.Forms.Label();
            this.lblWorktime5 = new System.Windows.Forms.Label();
            this.lblWorktime6 = new System.Windows.Forms.Label();
            this.lblWorktime7 = new System.Windows.Forms.Label();
            this.lblWorktime8 = new System.Windows.Forms.Label();
            this.lblWorktime9 = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.tbCompany0 = new System.Windows.Forms.TextBox();
            this.tbCompany1 = new System.Windows.Forms.TextBox();
            this.tbCompany2 = new System.Windows.Forms.TextBox();
            this.tbEndTime = new System.Windows.Forms.TextBox();
            this.tbOverTimeReason = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbStartTime = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.labelLine0 = new System.Windows.Forms.Label();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.textBoxFooter = new System.Windows.Forms.TextBox();
            this.labelFooter = new System.Windows.Forms.Label();
            this.frSalaryType = new System.Windows.Forms.GroupBox();
            this.opSalaryType2 = new System.Windows.Forms.RadioButton();
            this.opSalaryType1 = new System.Windows.Forms.RadioButton();
            this.opSalaryType0 = new System.Windows.Forms.RadioButton();
            this.lblSalaryTypeName0 = new System.Windows.Forms.Label();
            this.lblSalaryTypeName1 = new System.Windows.Forms.Label();
            this.lblSalaryTypeName2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imThumbsDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imThumbsUp)).BeginInit();
            this.frSalaryType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(296, 552);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(81, 33);
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
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btDelete.Enabled = false;
            this.btDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(224, 448);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(120, 33);
            this.btDelete.TabIndex = 57;
            this.btDelete.Text = "Delete work detail";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btDisconnect.Enabled = false;
            this.btDisconnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisconnect.Location = new System.Drawing.Point(384, 512);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(81, 33);
            this.btDisconnect.TabIndex = 43;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = false;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btEmployees
            // 
            this.btEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEmployees.Enabled = false;
            this.btEmployees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployees.Location = new System.Drawing.Point(384, 160);
            this.btEmployees.Name = "btEmployees";
            this.btEmployees.Size = new System.Drawing.Size(81, 33);
            this.btEmployees.TabIndex = 26;
            this.btEmployees.Text = "Employees";
            this.btEmployees.UseVisualStyleBackColor = false;
            this.btEmployees.Click += new System.EventHandler(this.btEmployees_Click);
            // 
            // btErrors
            // 
            this.btErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btErrors.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btErrors.Location = new System.Drawing.Point(96, 552);
            this.btErrors.Name = "btErrors";
            this.btErrors.Size = new System.Drawing.Size(89, 33);
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
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btInsert.Enabled = false;
            this.btInsert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(346, 448);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(120, 33);
            this.btInsert.TabIndex = 20;
            this.btInsert.Text = "Insert work detail";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(8, 552);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(81, 33);
            this.btReset.TabIndex = 28;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSalaryTypes
            // 
            this.btSalaryTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSalaryTypes.Enabled = false;
            this.btSalaryTypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalaryTypes.Location = new System.Drawing.Point(384, 200);
            this.btSalaryTypes.Name = "btSalaryTypes";
            this.btSalaryTypes.Size = new System.Drawing.Size(81, 33);
            this.btSalaryTypes.TabIndex = 6;
            this.btSalaryTypes.Text = "Salary types";
            this.btSalaryTypes.UseVisualStyleBackColor = false;
            this.btSalaryTypes.Click += new System.EventHandler(this.btSalaryTypes_Click);
            // 
            // btWarnings
            // 
            this.btWarnings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btWarnings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWarnings.Location = new System.Drawing.Point(192, 552);
            this.btWarnings.Name = "btWarnings";
            this.btWarnings.Size = new System.Drawing.Size(97, 33);
            this.btWarnings.TabIndex = 53;
            this.btWarnings.Text = "Show warnings";
            this.btWarnings.UseVisualStyleBackColor = false;
            this.btWarnings.Click += new System.EventHandler(this.btWarnings_Click);
            // 
            // cbEmployees
            // 
            this.cbEmployees.Enabled = false;
            this.cbEmployees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployees.Location = new System.Drawing.Point(504, 168);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(81, 23);
            this.cbEmployees.TabIndex = 5;
            this.cbEmployees.SelectedIndexChanged += new System.EventHandler(this.cbEmployees_SelectedIndexChanged);
            // 
            // cbSalaryType0
            // 
            this.cbSalaryType0.Enabled = false;
            this.cbSalaryType0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalaryType0.Location = new System.Drawing.Point(472, 240);
            this.cbSalaryType0.Name = "cbSalaryType0";
            this.cbSalaryType0.Size = new System.Drawing.Size(68, 23);
            this.cbSalaryType0.TabIndex = 7;
            this.cbSalaryType0.SelectedIndexChanged += new System.EventHandler(this.cbSalaryType0_SelectedIndexChanged);
            // 
            // cbSalaryType1
            // 
            this.cbSalaryType1.Enabled = false;
            this.cbSalaryType1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalaryType1.Location = new System.Drawing.Point(472, 264);
            this.cbSalaryType1.Name = "cbSalaryType1";
            this.cbSalaryType1.Size = new System.Drawing.Size(68, 23);
            this.cbSalaryType1.TabIndex = 8;
            this.cbSalaryType1.SelectedIndexChanged += new System.EventHandler(this.cbSalaryType1_SelectedIndexChanged);
            // 
            // cbSalaryType2
            // 
            this.cbSalaryType2.Enabled = false;
            this.cbSalaryType2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalaryType2.Location = new System.Drawing.Point(472, 288);
            this.cbSalaryType2.Name = "cbSalaryType2";
            this.cbSalaryType2.Size = new System.Drawing.Size(68, 23);
            this.cbSalaryType2.TabIndex = 9;
            this.cbSalaryType2.SelectedIndexChanged += new System.EventHandler(this.cbSalaryType2_SelectedIndexChanged);
            // 
            // ckUpdate
            // 
            this.ckUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckUpdate.Location = new System.Drawing.Point(728, 424);
            this.ckUpdate.Name = "ckUpdate";
            this.ckUpdate.Size = new System.Drawing.Size(65, 17);
            this.ckUpdate.TabIndex = 19;
            this.ckUpdate.Text = "Update";
            this.ckUpdate.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // dpDate0
            // 
            this.dpDate0.Checked = false;
            this.dpDate0.Enabled = false;
            this.dpDate0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate0.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate0.Location = new System.Drawing.Point(224, 352);
            this.dpDate0.Name = "dpDate0";
            this.dpDate0.Size = new System.Drawing.Size(85, 23);
            this.dpDate0.TabIndex = 10;
            // 
            // dpDate1
            // 
            this.dpDate1.Checked = false;
            this.dpDate1.Enabled = false;
            this.dpDate1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate1.Location = new System.Drawing.Point(224, 384);
            this.dpDate1.Name = "dpDate1";
            this.dpDate1.Size = new System.Drawing.Size(85, 23);
            this.dpDate1.TabIndex = 14;
            // 
            // dpDate2
            // 
            this.dpDate2.Checked = false;
            this.dpDate2.Enabled = false;
            this.dpDate2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate2.Location = new System.Drawing.Point(528, 384);
            this.dpDate2.Name = "dpDate2";
            this.dpDate2.Size = new System.Drawing.Size(85, 23);
            this.dpDate2.TabIndex = 16;
            // 
            // dpDate3
            // 
            this.dpDate3.Checked = false;
            this.dpDate3.Enabled = false;
            this.dpDate3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate3.Location = new System.Drawing.Point(728, 352);
            this.dpDate3.Name = "dpDate3";
            this.dpDate3.Size = new System.Drawing.Size(85, 23);
            this.dpDate3.TabIndex = 13;
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
            // imResult2
            // 
            this.imResult2.Image = ((System.Drawing.Image)(resources.GetObject("imResult2.Image")));
            this.imResult2.Location = new System.Drawing.Point(472, 168);
            this.imResult2.Name = "imResult2";
            this.imResult2.Size = new System.Drawing.Size(16, 16);
            this.imResult2.TabIndex = 63;
            this.imResult2.TabStop = false;
            this.imResult2.Visible = false;
            // 
            // imResult3
            // 
            this.imResult3.Image = ((System.Drawing.Image)(resources.GetObject("imResult3.Image")));
            this.imResult3.Location = new System.Drawing.Point(472, 208);
            this.imResult3.Name = "imResult3";
            this.imResult3.Size = new System.Drawing.Size(16, 16);
            this.imResult3.TabIndex = 62;
            this.imResult3.TabStop = false;
            this.imResult3.Visible = false;
            // 
            // imResult4
            // 
            this.imResult4.Image = ((System.Drawing.Image)(resources.GetObject("imResult4.Image")));
            this.imResult4.Location = new System.Drawing.Point(472, 456);
            this.imResult4.Name = "imResult4";
            this.imResult4.Size = new System.Drawing.Size(16, 16);
            this.imResult4.TabIndex = 61;
            this.imResult4.TabStop = false;
            this.imResult4.Visible = false;
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
            // lbError2
            // 
            this.lbError2.AutoSize = true;
            this.lbError2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError2.Location = new System.Drawing.Point(601, 170);
            this.lbError2.Name = "lbError2";
            this.lbError2.Size = new System.Drawing.Size(0, 15);
            this.lbError2.TabIndex = 27;
            // 
            // lbError3
            // 
            this.lbError3.AutoSize = true;
            this.lbError3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError3.Location = new System.Drawing.Point(504, 216);
            this.lbError3.Name = "lbError3";
            this.lbError3.Size = new System.Drawing.Size(0, 15);
            this.lbError3.TabIndex = 31;
            // 
            // lbError4
            // 
            this.lbError4.AutoSize = true;
            this.lbError4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError4.Location = new System.Drawing.Point(504, 456);
            this.lbError4.Name = "lbError4";
            this.lbError4.Size = new System.Drawing.Size(0, 15);
            this.lbError4.TabIndex = 42;
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
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.Enabled = false;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(120, 171);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(201, 15);
            this.lbl2.TabIndex = 25;
            this.lbl2.Text = "3. Get employees. Choose employee:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Enabled = false;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(120, 211);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(209, 15);
            this.lbl3.TabIndex = 30;
            this.lbl3.Text = "4. Get salary types. Choose salary type:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Enabled = false;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(120, 328);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(112, 15);
            this.lbl4.TabIndex = 35;
            this.lbl4.Text = "5. Insert work detail:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Enabled = false;
            this.lbl5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(120, 520);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(81, 15);
            this.lbl5.TabIndex = 44;
            this.lbl5.Text = "6. Disconnect:";
            // 
            // lblSalarytype0
            // 
            this.lblSalarytype0.AutoSize = true;
            this.lblSalarytype0.Enabled = false;
            this.lblSalarytype0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarytype0.Location = new System.Drawing.Point(384, 244);
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
            this.lblSalarytype1.Location = new System.Drawing.Point(384, 272);
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
            this.lblSalarytype2.Location = new System.Drawing.Point(384, 296);
            this.lblSalarytype2.Name = "lblSalarytype2";
            this.lblSalarytype2.Size = new System.Drawing.Size(52, 15);
            this.lblSalarytype2.TabIndex = 34;
            this.lblSalarytype2.Text = "Absence";
            // 
            // lblWorktime0
            // 
            this.lblWorktime0.AutoSize = true;
            this.lblWorktime0.Enabled = false;
            this.lblWorktime0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime0.Location = new System.Drawing.Point(152, 356);
            this.lblWorktime0.Name = "lblWorktime0";
            this.lblWorktime0.Size = new System.Drawing.Size(34, 15);
            this.lblWorktime0.TabIndex = 36;
            this.lblWorktime0.Text = "Date:";
            // 
            // lblWorktime1
            // 
            this.lblWorktime1.AutoSize = true;
            this.lblWorktime1.Enabled = false;
            this.lblWorktime1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime1.Location = new System.Drawing.Point(320, 356);
            this.lblWorktime1.Name = "lblWorktime1";
            this.lblWorktime1.Size = new System.Drawing.Size(56, 15);
            this.lblWorktime1.TabIndex = 37;
            this.lblWorktime1.Text = "Quantity:";
            // 
            // lblWorktime2
            // 
            this.lblWorktime2.AutoSize = true;
            this.lblWorktime2.Enabled = false;
            this.lblWorktime2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime2.Location = new System.Drawing.Point(473, 356);
            this.lblWorktime2.Name = "lblWorktime2";
            this.lblWorktime2.Size = new System.Drawing.Size(39, 15);
            this.lblWorktime2.TabIndex = 38;
            this.lblWorktime2.Text = "Value:";
            // 
            // lblWorktime3
            // 
            this.lblWorktime3.AutoSize = true;
            this.lblWorktime3.Enabled = false;
            this.lblWorktime3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime3.Location = new System.Drawing.Point(320, 388);
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
            this.lblWorktime4.Location = new System.Drawing.Point(624, 388);
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
            this.lblWorktime5.Location = new System.Drawing.Point(152, 420);
            this.lblWorktime5.Name = "lblWorktime5";
            this.lblWorktime5.Size = new System.Drawing.Size(69, 15);
            this.lblWorktime5.TabIndex = 41;
            this.lblWorktime5.Text = "Comments:";
            // 
            // lblWorktime6
            // 
            this.lblWorktime6.AutoSize = true;
            this.lblWorktime6.Enabled = false;
            this.lblWorktime6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime6.Location = new System.Drawing.Point(152, 388);
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
            this.lblWorktime7.Location = new System.Drawing.Point(473, 388);
            this.lblWorktime7.Name = "lblWorktime7";
            this.lblWorktime7.Size = new System.Drawing.Size(56, 15);
            this.lblWorktime7.TabIndex = 50;
            this.lblWorktime7.Text = "End date:";
            // 
            // lblWorktime8
            // 
            this.lblWorktime8.AutoSize = true;
            this.lblWorktime8.Enabled = false;
            this.lblWorktime8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime8.Location = new System.Drawing.Point(624, 356);
            this.lblWorktime8.Name = "lblWorktime8";
            this.lblWorktime8.Size = new System.Drawing.Size(88, 15);
            this.lblWorktime8.TabIndex = 51;
            this.lblWorktime8.Text = "Reference date:";
            // 
            // lblWorktime9
            // 
            this.lblWorktime9.AutoSize = true;
            this.lblWorktime9.Enabled = false;
            this.lblWorktime9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorktime9.Location = new System.Drawing.Point(472, 420);
            this.lblWorktime9.Name = "lblWorktime9";
            this.lblWorktime9.Size = new System.Drawing.Size(100, 15);
            this.lblWorktime9.TabIndex = 58;
            this.lblWorktime9.Text = "Over time reason:";
            // 
            // tbComments
            // 
            this.tbComments.Enabled = false;
            this.tbComments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComments.Location = new System.Drawing.Point(224, 416);
            this.tbComments.MaxLength = 0;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(241, 23);
            this.tbComments.TabIndex = 18;
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
            // tbEndTime
            // 
            this.tbEndTime.Enabled = false;
            this.tbEndTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndTime.Location = new System.Drawing.Point(728, 384);
            this.tbEndTime.MaxLength = 0;
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Size = new System.Drawing.Size(57, 23);
            this.tbEndTime.TabIndex = 17;
            // 
            // tbOverTimeReason
            // 
            this.tbOverTimeReason.Enabled = false;
            this.tbOverTimeReason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOverTimeReason.Location = new System.Drawing.Point(576, 416);
            this.tbOverTimeReason.MaxLength = 0;
            this.tbOverTimeReason.Name = "tbOverTimeReason";
            this.tbOverTimeReason.Size = new System.Drawing.Size(57, 23);
            this.tbOverTimeReason.TabIndex = 59;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Enabled = false;
            this.tbQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.Location = new System.Drawing.Point(408, 352);
            this.tbQuantity.MaxLength = 0;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(57, 23);
            this.tbQuantity.TabIndex = 11;
            // 
            // tbStartTime
            // 
            this.tbStartTime.Enabled = false;
            this.tbStartTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartTime.Location = new System.Drawing.Point(408, 384);
            this.tbStartTime.MaxLength = 0;
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(57, 23);
            this.tbStartTime.TabIndex = 15;
            // 
            // tbValue
            // 
            this.tbValue.Enabled = false;
            this.tbValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValue.Location = new System.Drawing.Point(528, 352);
            this.tbValue.MaxLength = 0;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(57, 23);
            this.tbValue.TabIndex = 12;
            // 
            // labelLine0
            // 
            this.labelLine0.AutoSize = true;
            this.labelLine0.BackColor = System.Drawing.Color.Gray;
            this.labelLine0.Enabled = false;
            this.labelLine0.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine0.Location = new System.Drawing.Point(120, 149);
            this.labelLine0.Name = "labelLine0";
            this.labelLine0.Size = new System.Drawing.Size(697, 4);
            this.labelLine0.TabIndex = 68;
            this.labelLine0.Text = resources.GetString("labelLine0.Text");
            // 
            // labelLine1
            // 
            this.labelLine1.AutoSize = true;
            this.labelLine1.BackColor = System.Drawing.Color.Gray;
            this.labelLine1.Enabled = false;
            this.labelLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine1.Location = new System.Drawing.Point(119, 496);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.Size = new System.Drawing.Size(697, 4);
            this.labelLine1.TabIndex = 69;
            this.labelLine1.Text = resources.GetString("labelLine1.Text");
            // 
            // textBoxFooter
            // 
            this.textBoxFooter.BackColor = System.Drawing.Color.DimGray;
            this.textBoxFooter.Location = new System.Drawing.Point(-1, 600);
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
            this.labelFooter.Location = new System.Drawing.Point(5, 624);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(186, 15);
            this.labelFooter.TabIndex = 71;
            this.labelFooter.Text = "Copyright @ 2016 Sage Portugal";
            // 
            // frSalaryType
            // 
            this.frSalaryType.Controls.Add(this.opSalaryType2);
            this.frSalaryType.Controls.Add(this.opSalaryType1);
            this.frSalaryType.Controls.Add(this.opSalaryType0);
            this.frSalaryType.Location = new System.Drawing.Point(346, 211);
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
            // lblSalaryTypeName0
            // 
            this.lblSalaryTypeName0.AutoSize = true;
            this.lblSalaryTypeName0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryTypeName0.Location = new System.Drawing.Point(550, 245);
            this.lblSalaryTypeName0.Name = "lblSalaryTypeName0";
            this.lblSalaryTypeName0.Size = new System.Drawing.Size(0, 15);
            this.lblSalaryTypeName0.TabIndex = 73;
            // 
            // lblSalaryTypeName1
            // 
            this.lblSalaryTypeName1.AutoSize = true;
            this.lblSalaryTypeName1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryTypeName1.Location = new System.Drawing.Point(550, 265);
            this.lblSalaryTypeName1.Name = "lblSalaryTypeName1";
            this.lblSalaryTypeName1.Size = new System.Drawing.Size(0, 15);
            this.lblSalaryTypeName1.TabIndex = 74;
            // 
            // lblSalaryTypeName2
            // 
            this.lblSalaryTypeName2.AutoSize = true;
            this.lblSalaryTypeName2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryTypeName2.Location = new System.Drawing.Point(550, 295);
            this.lblSalaryTypeName2.Name = "lblSalaryTypeName2";
            this.lblSalaryTypeName2.Size = new System.Drawing.Size(0, 15);
            this.lblSalaryTypeName2.TabIndex = 75;
            // 
            // FormApiSalarios
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 659);
            this.Controls.Add(this.lblSalaryTypeName2);
            this.Controls.Add(this.lblSalaryTypeName1);
            this.Controls.Add(this.lblSalaryTypeName0);
            this.Controls.Add(this.frSalaryType);
            this.Controls.Add(this.labelFooter);
            this.Controls.Add(this.textBoxFooter);
            this.Controls.Add(this.labelLine1);
            this.Controls.Add(this.labelLine0);
            this.Controls.Add(this.ckUpdate);
            this.Controls.Add(this.dpDate0);
            this.Controls.Add(this.cbEmployees);
            this.Controls.Add(this.tbCompany0);
            this.Controls.Add(this.btInitialize);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.btEmployees);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSalaryTypes);
            this.Controls.Add(this.cbSalaryType0);
            this.Controls.Add(this.cbSalaryType1);
            this.Controls.Add(this.cbSalaryType2);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.tbStartTime);
            this.Controls.Add(this.tbEndTime);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.dpDate1);
            this.Controls.Add(this.dpDate2);
            this.Controls.Add(this.dpDate3);
            this.Controls.Add(this.btErrors);
            this.Controls.Add(this.btWarnings);
            this.Controls.Add(this.tbCompany1);
            this.Controls.Add(this.tbCompany2);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.tbOverTimeReason);
            this.Controls.Add(this.lblWorktime9);
            this.Controls.Add(this.imLogo);
            this.Controls.Add(this.lbCompany1);
            this.Controls.Add(this.lbCompany0);
            this.Controls.Add(this.lblWorktime8);
            this.Controls.Add(this.imResult4);
            this.Controls.Add(this.imResult3);
            this.Controls.Add(this.imResult2);
            this.Controls.Add(this.imResult1);
            this.Controls.Add(this.imThumbsDown);
            this.Controls.Add(this.imThumbsUp);
            this.Controls.Add(this.imResult0);
            this.Controls.Add(this.lblWorktime7);
            this.Controls.Add(this.lblWorktime6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbError4);
            this.Controls.Add(this.lblWorktime5);
            this.Controls.Add(this.lblWorktime4);
            this.Controls.Add(this.lblWorktime3);
            this.Controls.Add(this.lblWorktime2);
            this.Controls.Add(this.lblWorktime1);
            this.Controls.Add(this.lblWorktime0);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblSalarytype2);
            this.Controls.Add(this.lblSalarytype1);
            this.Controls.Add(this.lblSalarytype0);
            this.Controls.Add(this.lbError3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbError2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbError1);
            this.Controls.Add(this.lbError0);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl0);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormApiSalarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sage Salários - API (Application Programming Interface)";
            ((System.ComponentModel.ISupportInitialize)(this.imLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imResult4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imThumbsDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imThumbsUp)).EndInit();
            this.frSalaryType.ResumeLayout(false);
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
        public SageBGEPAPI10.PayrollAPI m_API;
        //
        public SageBGEPAPI10.Employees m_Employees;
        public SageBGEPAPI10.Employee l_Employee;
        //
        public SageBGEPAPI10.SalaryTypes m_Allowances;
        public SageBGEPAPI10.SalaryTypes m_Deductions;
        public SageBGEPAPI10.SalaryTypes m_Absences;
        //
        public SageBGEPAPI10.WorkDetail lWorkDetail;
        //
        public SageBGEPAPI10.SalaryType lSalaryType;

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
            Disconnect = 5
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
        // Purpose : Initializes BGEP API for implementation
        //
        // ===============================================================
        private void btInitialize_Click(object sender, EventArgs e){

            m_API = new SageBGEPAPI10.PayrollAPI();

            int lResult = m_API.Initialize();
      
            if ( lResult == 0 ){
                NotifyInitializeResult (eSteps.Initialize, true);
            }
            tbCompany[0].Text = (String)"DEMO_BGEP";
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
      
                if ( tbCompany[0].Text != "" ) {

                    int lResult = m_API.Connect(tbCompany[1].Text, tbCompany[2].Text, tbCompany[0].Text);

                    if ( lResult == 0 ){
                        NotifyInitializeResult (eSteps.Connect, true);
                    }
            
                    F_ShowResult (eSteps.Connect, lResult);
                }
            }
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
      
            if ( m_API != null ){

                    m_Employees = m_API.GetEmployees();

                if ( m_Employees.Success) {
                    NotifyInitializeResult (eSteps.Employees, true);
                }

                foreach (SageBGEPAPI10.Employee l_Employee in m_Employees)
                {
                    cbEmployees.Items.Add(l_Employee.ID);
                }
                F_ShowResult (eSteps.Employees, m_Employees.Result);
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

                m_Allowances = m_API.GetSalaryTypes(SageBGEPAPI10.eSalaryType.Allowance);

                if ( m_Allowances.Success ) {
                    foreach (SageBGEPAPI10.SalaryType lSalaryType in m_Allowances){
                        cbSalaryType[0].Items.Add( lSalaryType.ID);
                    }
                }
                F_ShowResult (eSteps.SalaryTypes, m_Allowances.Result);


                m_Deductions = m_API.GetSalaryTypes(SageBGEPAPI10.eSalaryType.Deduction);
                if ( m_Deductions.Success ){

                    foreach (SageBGEPAPI10.SalaryType lSalaryType in m_Deductions){
                        cbSalaryType[1].Items.Add(lSalaryType.ID);

                    }
                }
                F_ShowResult (eSteps.SalaryTypes, m_Deductions.Result);

                m_Absences = m_API.GetSalaryTypes(SageBGEPAPI10.eSalaryType.Absence);
                if ( m_Absences.Success ) {
                    foreach (SageBGEPAPI10.SalaryType  lSalaryType in m_Absences){
                        cbSalaryType[2].Items.Add(lSalaryType.ID);
                    }
                }
                F_ShowResult (eSteps.SalaryTypes, m_Absences.Result);
            }
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

            if ( m_API != null ) {

                lWorkDetail = new SageBGEPAPI10.WorkDetail();

                if ( cbEmployees.Text != "" ){
                    lWorkDetail.Employee = m_Employees[cbEmployees.Text];
                }

                if ( opSalaryType[0].Checked){
                        if (cbSalaryType[0].Text != ""){
                            lWorkDetail.SalaryType = m_Allowances[cbSalaryType0.Text];
                        }
                }
                else if (opSalaryType[1].Checked)
                {
                        if (cbSalaryType[1].Text != ""){
                            lWorkDetail.SalaryType = m_Deductions[cbSalaryType1.Text];
                        }
                }
                else if (opSalaryType[2].Checked)
                {
                        if ( cbSalaryType[2].Text != "" ){
                            lWorkDetail.SalaryType = m_Absences[cbSalaryType2.Text];
                        }
                }
            

                if ( dpDate[0].Text != "" ) {
                    lWorkDetail.WorkDate = dpDate[0].Text;
                }

                if ( IsNumeric(tbQuantity.Text) ){
                    lWorkDetail.Quantity = Decimal.Parse((tbQuantity.Text),NumberStyles.Currency);
                }
      
                if ( IsNumeric(tbValue.Text) ){
                    lWorkDetail.Value = Decimal.Parse((tbValue.Text),NumberStyles.Currency);
                }

                lWorkDetail.StartDate = dpDate[1].Text;
                lWorkDetail.StartTime = tbStartTime.Text;

                lWorkDetail.EndDate = dpDate[2].Text;
                lWorkDetail.EndTime = tbEndTime.Text;
                lWorkDetail.Comments = tbComments.Text;

                lWorkDetail.ReferenceDate = dpDate[3].Text;
                lWorkDetail.OverTimeReason = tbOverTimeReason.Text;

                int lResult = m_API.AddWorkDetail(lWorkDetail, (ckUpdate.Checked = true));

                F_ShowResult (eSteps.WorkTime, lResult);
     
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
            
                lWorkDetail = new SageBGEPAPI10.WorkDetail();

                if ( cbEmployees.Text != "" ){
                    lWorkDetail.Employee = m_Employees[cbEmployees.Text];
                }

                if (opSalaryType[0].Checked)
                {
                    if (cbSalaryType[0].Text != "")
                    {
                        lWorkDetail.SalaryType = m_Allowances[cbSalaryType0.Text];
                    }
                }
                else if (opSalaryType[1].Checked)
                {
                    if (cbSalaryType[1].Text != "")
                    {
                        lWorkDetail.SalaryType = m_Deductions[cbSalaryType1.Text];
                    }
                }
                else if (opSalaryType[2].Checked)
                {
                    if (cbSalaryType[2].Text != "")
                    {
                        lWorkDetail.SalaryType = m_Absences[cbSalaryType2.Text];
                    }
                }
      
            if ( dpDate0.Text != "" ) {
                lWorkDetail.WorkDate = dpDate[0].Text;
            }

            int lResult = m_API.DeleteWorkDetail(lWorkDetail);

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
            if (lWorkDetail != null)
            {
                Marshal.ReleaseComObject(lWorkDetail);
                lWorkDetail = null;
            }
            if (lSalaryType != null)
            {
                Marshal.ReleaseComObject(lSalaryType);
                lSalaryType = null;
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
                    lbl2.Enabled = iResult;
                    btEmployees.Enabled = iResult;
                    btDisconnect.Enabled = iResult;

                    lbl1.Enabled = ! iResult;

                    for (int i = 0; i < tbCompany.Length; i++)
                    {
                        tbCompany[i].Enabled = iResult;
                    }
              
                    lbCompany0.Enabled = iResult;
                    lbCompany1.Enabled = iResult;

                    btConnect.Enabled = ! iResult;

                    if ( iResult ) {
                    btEmployees.Focus();
                    }
                    break;

                case eSteps.Employees:
                cbEmployees.Enabled = iResult;
                btSalaryTypes.Enabled = iResult;
                lbl3.Enabled = iResult;
                break;

                case eSteps.SalaryTypes:

                for (int i = 0; i < cbSalaryType.Length; i++)
                {
                    cbSalaryType[i].Enabled = iResult;
                }

                lbl4.Enabled = iResult;
         

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
                lbl5.Enabled = iResult;
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
            for (int i = 0; i < lbl.Length; i++)
            {
                lbl[i].Enabled = true;
            }

            for (int i = 0; i < lbError.Length; i++)
            {
                lbError[i].Text = "";
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
                tbCompany[i].Text = "";
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
                dpDate[i].Text = "";
            }

            cbEmployees.Items.Clear();
            cbEmployees.Enabled = false;

            btInitialize.Enabled = true;
            btConnect.Enabled = false;
            btEmployees.Enabled = false;
            btSalaryTypes.Enabled = false;
            btDisconnect.Enabled = false;
            btInsert.Enabled = false;
            btDelete.Enabled = false;

            frSalaryType.Enabled = false;
        }

        private void F_ShowResult (eSteps iStep, long iResult)   {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApiSalarios));
 
            int index = (int)iStep;

            imResult[index].Visible = true;
            
            if ( iResult == 0 ) {
                imResult[index].Image = ((System.Drawing.Image)(resources.GetObject("imThumbsUp.Image")));
                lbError[index].Text = "";

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
            lSalaryType = m_Allowances[cbSalaryType[(int)SalaryTypes.Allowances].Text];
            lbSalaryTypeName[(int)SalaryTypes.Allowances].Text = lSalaryType.Name;

        }

        private void cbSalaryType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lSalaryType = m_Deductions[cbSalaryType[(int)SalaryTypes.Deductions].Text];
            lbSalaryTypeName[(int)SalaryTypes.Deductions].Text = lSalaryType.Name;
        }

        private void cbSalaryType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lSalaryType = m_Absences[cbSalaryType[(int)SalaryTypes.Absences].Text];
            lbSalaryTypeName[(int)SalaryTypes.Absences].Text = lSalaryType.Name;
        }


    } // end class

} // end namespace
