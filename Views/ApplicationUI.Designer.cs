namespace Rental_App_V1._0.Views
{
    partial class ApplicationUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationUI));
            this.SplashScreen = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SplashTitle = new System.Windows.Forms.Label();
            this.EndScreen = new System.Windows.Forms.Panel();
            this.GridViewScreen = new System.Windows.Forms.Panel();
            this.TotalDayRentLBL = new System.Windows.Forms.Label();
            this.TableLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.LDSCHL = new System.Windows.Forms.Button();
            this.LDDVC = new System.Windows.Forms.Button();
            this.CBODayRent = new System.Windows.Forms.ComboBox();
            this.LDCLTH = new System.Windows.Forms.Button();
            this.LDTL = new System.Windows.Forms.Button();
            this.DTIMAGETEST = new System.Windows.Forms.DataGridView();
            this.LoginScreen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IDInput = new System.Windows.Forms.TextBox();
            this.CartScreen = new System.Windows.Forms.Panel();
            this.GRDCRT = new System.Windows.Forms.DataGridView();
            this.ReceiptScreen = new System.Windows.Forms.Panel();
            this.CheckStudent = new System.Windows.Forms.Panel();
            this.ChkNoBtn = new System.Windows.Forms.Button();
            this.ChkYesBtn = new System.Windows.Forms.Button();
            this.StudentLoginProgram = new System.Windows.Forms.TextBox();
            this.StudentLoginAge = new System.Windows.Forms.TextBox();
            this.StudentLoginID = new System.Windows.Forms.TextBox();
            this.StudentLoginName = new System.Windows.Forms.TextBox();
            this.SplashScreen.SuspendLayout();
            this.GridViewScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTIMAGETEST)).BeginInit();
            this.LoginScreen.SuspendLayout();
            this.CartScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRDCRT)).BeginInit();
            this.CheckStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplashScreen
            // 
            this.SplashScreen.BackColor = System.Drawing.Color.Transparent;
            this.SplashScreen.Controls.Add(this.flowLayoutPanel1);
            this.SplashScreen.Controls.Add(this.SplashTitle);
            resources.ApplyResources(this.SplashScreen, "SplashScreen");
            this.SplashScreen.Name = "SplashScreen";
            this.SplashScreen.Click += new System.EventHandler(this.SplashScreen_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // SplashTitle
            // 
            resources.ApplyResources(this.SplashTitle, "SplashTitle");
            this.SplashTitle.Name = "SplashTitle";
            // 
            // EndScreen
            // 
            this.EndScreen.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.EndScreen, "EndScreen");
            this.EndScreen.Name = "EndScreen";
            // 
            // GridViewScreen
            // 
            this.GridViewScreen.BackColor = System.Drawing.SystemColors.Control;
            this.GridViewScreen.BackgroundImage = global::Rental_App_V1._0.Properties.Resources.Intro;
            resources.ApplyResources(this.GridViewScreen, "GridViewScreen");
            this.GridViewScreen.Controls.Add(this.TotalDayRentLBL);
            this.GridViewScreen.Controls.Add(this.TableLabel);
            this.GridViewScreen.Controls.Add(this.CategoryLabel);
            this.GridViewScreen.Controls.Add(this.label2);
            this.GridViewScreen.Controls.Add(this.SearchBox);
            this.GridViewScreen.Controls.Add(this.LDSCHL);
            this.GridViewScreen.Controls.Add(this.LDDVC);
            this.GridViewScreen.Controls.Add(this.CBODayRent);
            this.GridViewScreen.Controls.Add(this.LDCLTH);
            this.GridViewScreen.Controls.Add(this.LDTL);
            this.GridViewScreen.Controls.Add(this.DTIMAGETEST);
            this.GridViewScreen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GridViewScreen.Name = "GridViewScreen";
            // 
            // TotalDayRentLBL
            // 
            resources.ApplyResources(this.TotalDayRentLBL, "TotalDayRentLBL");
            this.TotalDayRentLBL.Name = "TotalDayRentLBL";
            // 
            // TableLabel
            // 
            resources.ApplyResources(this.TableLabel, "TableLabel");
            this.TableLabel.Name = "TableLabel";
            // 
            // CategoryLabel
            // 
            resources.ApplyResources(this.CategoryLabel, "CategoryLabel");
            this.CategoryLabel.Name = "CategoryLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // SearchBox
            // 
            resources.ApplyResources(this.SearchBox, "SearchBox");
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModifyDB);
            // 
            // LDSCHL
            // 
            resources.ApplyResources(this.LDSCHL, "LDSCHL");
            this.LDSCHL.Name = "LDSCHL";
            this.LDSCHL.UseVisualStyleBackColor = true;
            this.LDSCHL.Click += new System.EventHandler(this.Load_Home_Data);
            // 
            // LDDVC
            // 
            resources.ApplyResources(this.LDDVC, "LDDVC");
            this.LDDVC.Name = "LDDVC";
            this.LDDVC.UseVisualStyleBackColor = true;
            this.LDDVC.Click += new System.EventHandler(this.Load_Tool_Data);
            // 
            // CBODayRent
            // 
            this.CBODayRent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CBODayRent, "CBODayRent");
            this.CBODayRent.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CBODayRent.FormattingEnabled = true;
            this.CBODayRent.Items.AddRange(new object[] {
            resources.GetString("CBODayRent.Items"),
            resources.GetString("CBODayRent.Items1"),
            resources.GetString("CBODayRent.Items2"),
            resources.GetString("CBODayRent.Items3"),
            resources.GetString("CBODayRent.Items4"),
            resources.GetString("CBODayRent.Items5"),
            resources.GetString("CBODayRent.Items6"),
            resources.GetString("CBODayRent.Items7"),
            resources.GetString("CBODayRent.Items8"),
            resources.GetString("CBODayRent.Items9"),
            resources.GetString("CBODayRent.Items10"),
            resources.GetString("CBODayRent.Items11"),
            resources.GetString("CBODayRent.Items12"),
            resources.GetString("CBODayRent.Items13")});
            this.CBODayRent.Name = "CBODayRent";
            // 
            // LDCLTH
            // 
            resources.ApplyResources(this.LDCLTH, "LDCLTH");
            this.LDCLTH.Name = "LDCLTH";
            this.LDCLTH.UseVisualStyleBackColor = true;
            this.LDCLTH.Click += new System.EventHandler(this.Load_Clothing_Data);
            // 
            // LDTL
            // 
            resources.ApplyResources(this.LDTL, "LDTL");
            this.LDTL.Name = "LDTL";
            this.LDTL.UseVisualStyleBackColor = true;
            this.LDTL.Click += new System.EventHandler(this.Load_Device_Data);
            // 
            // DTIMAGETEST
            // 
            this.DTIMAGETEST.AllowUserToAddRows = false;
            resources.ApplyResources(this.DTIMAGETEST, "DTIMAGETEST");
            this.DTIMAGETEST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTIMAGETEST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DTIMAGETEST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTIMAGETEST.Name = "DTIMAGETEST";
            this.DTIMAGETEST.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTIMAGETEST_CellContentClick);
            this.DTIMAGETEST.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridViewItem_Click);
            // 
            // LoginScreen
            // 
            this.LoginScreen.BackColor = System.Drawing.Color.Transparent;
            this.LoginScreen.Controls.Add(this.label1);
            this.LoginScreen.Controls.Add(this.button1);
            this.LoginScreen.Controls.Add(this.IDInput);
            resources.ApplyResources(this.LoginScreen, "LoginScreen");
            this.LoginScreen.Name = "LoginScreen";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // IDInput
            // 
            resources.ApplyResources(this.IDInput, "IDInput");
            this.IDInput.Name = "IDInput";
            // 
            // CartScreen
            // 
            this.CartScreen.BackColor = System.Drawing.Color.Transparent;
            this.CartScreen.Controls.Add(this.GRDCRT);
            resources.ApplyResources(this.CartScreen, "CartScreen");
            this.CartScreen.Name = "CartScreen";
            // 
            // GRDCRT
            // 
            this.GRDCRT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.GRDCRT, "GRDCRT");
            this.GRDCRT.Name = "GRDCRT";
            // 
            // ReceiptScreen
            // 
            this.ReceiptScreen.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ReceiptScreen, "ReceiptScreen");
            this.ReceiptScreen.Name = "ReceiptScreen";
            // 
            // CheckStudent
            // 
            this.CheckStudent.BackgroundImage = global::Rental_App_V1._0.Properties.Resources.Intro;
            resources.ApplyResources(this.CheckStudent, "CheckStudent");
            this.CheckStudent.Controls.Add(this.ChkNoBtn);
            this.CheckStudent.Controls.Add(this.ChkYesBtn);
            this.CheckStudent.Controls.Add(this.StudentLoginProgram);
            this.CheckStudent.Controls.Add(this.StudentLoginAge);
            this.CheckStudent.Controls.Add(this.StudentLoginID);
            this.CheckStudent.Controls.Add(this.StudentLoginName);
            this.CheckStudent.Name = "CheckStudent";
            // 
            // ChkNoBtn
            // 
            resources.ApplyResources(this.ChkNoBtn, "ChkNoBtn");
            this.ChkNoBtn.Name = "ChkNoBtn";
            this.ChkNoBtn.UseVisualStyleBackColor = true;
            this.ChkNoBtn.Click += new System.EventHandler(this.Check_No);
            // 
            // ChkYesBtn
            // 
            resources.ApplyResources(this.ChkYesBtn, "ChkYesBtn");
            this.ChkYesBtn.Name = "ChkYesBtn";
            this.ChkYesBtn.UseVisualStyleBackColor = true;
            this.ChkYesBtn.Click += new System.EventHandler(this.Check_Yes);
            // 
            // StudentLoginProgram
            // 
            resources.ApplyResources(this.StudentLoginProgram, "StudentLoginProgram");
            this.StudentLoginProgram.Name = "StudentLoginProgram";
            this.StudentLoginProgram.ReadOnly = true;
            this.StudentLoginProgram.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // StudentLoginAge
            // 
            resources.ApplyResources(this.StudentLoginAge, "StudentLoginAge");
            this.StudentLoginAge.Name = "StudentLoginAge";
            this.StudentLoginAge.ReadOnly = true;
            this.StudentLoginAge.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // StudentLoginID
            // 
            resources.ApplyResources(this.StudentLoginID, "StudentLoginID");
            this.StudentLoginID.Name = "StudentLoginID";
            this.StudentLoginID.ReadOnly = true;
            this.StudentLoginID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // StudentLoginName
            // 
            resources.ApplyResources(this.StudentLoginName, "StudentLoginName");
            this.StudentLoginName.Name = "StudentLoginName";
            this.StudentLoginName.ReadOnly = true;
            // 
            // ApplicationUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rental_App_V1._0.Properties.Resources.Intro;
            this.Controls.Add(this.CartScreen);
            this.Controls.Add(this.SplashScreen);
            this.Controls.Add(this.LoginScreen);
            this.Controls.Add(this.CheckStudent);
            this.Controls.Add(this.GridViewScreen);
            this.Controls.Add(this.ReceiptScreen);
            this.Controls.Add(this.EndScreen);
            this.MaximizeBox = false;
            this.Name = "ApplicationUI";
            this.Load += new System.EventHandler(this.ApplicationUI_Load_1);
            this.SplashScreen.ResumeLayout(false);
            this.SplashScreen.PerformLayout();
            this.GridViewScreen.ResumeLayout(false);
            this.GridViewScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTIMAGETEST)).EndInit();
            this.LoginScreen.ResumeLayout(false);
            this.LoginScreen.PerformLayout();
            this.CartScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRDCRT)).EndInit();
            this.CheckStudent.ResumeLayout(false);
            this.CheckStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SplashScreen;
        private System.Windows.Forms.Panel EndScreen;
        private System.Windows.Forms.Panel GridViewScreen;
        private System.Windows.Forms.Panel LoginScreen;
        private System.Windows.Forms.Panel CartScreen;
        private System.Windows.Forms.Panel ReceiptScreen;
        private System.Windows.Forms.Label SplashTitle;
        private System.Windows.Forms.TextBox IDInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DTIMAGETEST;
        private System.Windows.Forms.Button LDDVC;
        private System.Windows.Forms.Button LDSCHL;
        private System.Windows.Forms.Button LDCLTH;
        private System.Windows.Forms.Button LDTL;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel CheckStudent;
        private System.Windows.Forms.Button ChkNoBtn;
        private System.Windows.Forms.Button ChkYesBtn;
        private System.Windows.Forms.TextBox StudentLoginProgram;
        private System.Windows.Forms.TextBox StudentLoginAge;
        private System.Windows.Forms.TextBox StudentLoginID;
        private System.Windows.Forms.TextBox StudentLoginName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Label TotalDayRentLBL;
        public System.Windows.Forms.ComboBox CBODayRent;
        private System.Windows.Forms.DataGridView GRDCRT;
    }
}