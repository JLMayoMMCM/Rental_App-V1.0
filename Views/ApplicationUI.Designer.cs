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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationUI));
            this.SplashScreen = new System.Windows.Forms.Panel();
            this.SplashTitle = new System.Windows.Forms.Label();
            this.EndScreen = new System.Windows.Forms.Panel();
            this.GridViewScreen = new System.Windows.Forms.Panel();
            this.LoginScreen = new System.Windows.Forms.Panel();
            this.IDInput = new System.Windows.Forms.TextBox();
            this.CartScreen = new System.Windows.Forms.Panel();
            this.ReceiptScreen = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SplashScreen.SuspendLayout();
            this.LoginScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplashScreen
            // 
            this.SplashScreen.BackColor = System.Drawing.Color.Transparent;
            this.SplashScreen.Controls.Add(this.SplashTitle);
            resources.ApplyResources(this.SplashScreen, "SplashScreen");
            this.SplashScreen.Name = "SplashScreen";
            this.SplashScreen.Click += new System.EventHandler(this.SplashScreen_Click);
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
            this.GridViewScreen.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.GridViewScreen, "GridViewScreen");
            this.GridViewScreen.Name = "GridViewScreen";
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
            // IDInput
            // 
            resources.ApplyResources(this.IDInput, "IDInput");
            this.IDInput.Name = "IDInput";
            // 
            // CartScreen
            // 
            this.CartScreen.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.CartScreen, "CartScreen");
            this.CartScreen.Name = "CartScreen";
            // 
            // ReceiptScreen
            // 
            this.ReceiptScreen.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ReceiptScreen, "ReceiptScreen");
            this.ReceiptScreen.Name = "ReceiptScreen";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ApplicationUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rental_App_V1._0.Properties.Resources.Intro;
            this.Controls.Add(this.LoginScreen);
            this.Controls.Add(this.SplashScreen);
            this.Controls.Add(this.ReceiptScreen);
            this.Controls.Add(this.EndScreen);
            this.Controls.Add(this.GridViewScreen);
            this.Controls.Add(this.CartScreen);
            this.MaximizeBox = false;
            this.Name = "ApplicationUI";
            this.SplashScreen.ResumeLayout(false);
            this.SplashScreen.PerformLayout();
            this.LoginScreen.ResumeLayout(false);
            this.LoginScreen.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}