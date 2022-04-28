
namespace HR_Admin_Desktop
{

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addressBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label2 = new System.Windows.Forms.Label();
            this.WJSONR = new System.Windows.Forms.RadioButton();
            this.JSONR = new System.Windows.Forms.RadioButton();
            this.ErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // addressBar
            // 
            this.addressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBar.Location = new System.Drawing.Point(17, 58);
            this.addressBar.Name = "addressBar";
            this.addressBar.PlaceholderText = "Enter mobile number";
            this.addressBar.Size = new System.Drawing.Size(843, 27);
            this.addressBar.TabIndex = 2;
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(22, 147);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(838, 360);
            this.webView.TabIndex = 5;
            this.webView.ZoomFactor = 1D;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Developed By: Emad Khan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.UseMnemonic = false;
            // 
            // WJSONR
            // 
            this.WJSONR.AutoSize = true;
            this.WJSONR.Location = new System.Drawing.Point(25, 104);
            this.WJSONR.Name = "WJSONR";
            this.WJSONR.Size = new System.Drawing.Size(122, 24);
            this.WJSONR.TabIndex = 7;
            this.WJSONR.Text = "Without JSON";
            this.WJSONR.UseVisualStyleBackColor = true;
            this.WJSONR.CheckedChanged += new System.EventHandler(this.WJSONR_CheckedChanged);
            // 
            // JSONR
            // 
            this.JSONR.AutoSize = true;
            this.JSONR.Location = new System.Drawing.Point(181, 105);
            this.JSONR.Name = "JSONR";
            this.JSONR.Size = new System.Drawing.Size(65, 24);
            this.JSONR.TabIndex = 8;
            this.JSONR.Text = "JSON";
            this.JSONR.UseVisualStyleBackColor = true;
            this.JSONR.CheckedChanged += new System.EventHandler(this.JSONR_CheckedChanged);
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.AutoSize = true;
            this.ErrorMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrorMsg.Location = new System.Drawing.Point(676, 107);
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.Size = new System.Drawing.Size(0, 20);
            this.ErrorMsg.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 533);
            this.Controls.Add(this.ErrorMsg);
            this.Controls.Add(this.JSONR);
            this.Controls.Add(this.WJSONR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressBar);
            this.Name = "Form1";
            this.Text = "HR Application WhatsApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox addressBar;
        private Label label1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Label label2;
        private RadioButton WJSONR;
        private RadioButton JSONR;
        private Label ErrorMsg;
    }
}