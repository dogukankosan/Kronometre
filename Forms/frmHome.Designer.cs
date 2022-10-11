
namespace FormStudent
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Krotext = new DevExpress.XtraEditors.LabelControl();
            this.Btn_Start = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Reflesh = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Krotext
            // 
            this.lbl_Krotext.Appearance.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.lbl_Krotext.Appearance.Options.UseFont = true;
            this.lbl_Krotext.Location = new System.Drawing.Point(36, 52);
            this.lbl_Krotext.Name = "lbl_Krotext";
            this.lbl_Krotext.Size = new System.Drawing.Size(13, 29);
            this.lbl_Krotext.TabIndex = 4;
            this.lbl_Krotext.Text = "0";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.Btn_Start.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.Btn_Start.Appearance.Options.UseBackColor = true;
            this.Btn_Start.Appearance.Options.UseFont = true;
            this.Btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Start.Location = new System.Drawing.Point(167, 12);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(111, 36);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "BAŞLAT (F2)";
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Appearance.BackColor = System.Drawing.Color.Red;
            this.Btn_Stop.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.Btn_Stop.Appearance.Options.UseBackColor = true;
            this.Btn_Stop.Appearance.Options.UseFont = true;
            this.Btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Stop.Location = new System.Drawing.Point(167, 56);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(111, 36);
            this.Btn_Stop.TabIndex = 1;
            this.Btn_Stop.Text = "DURDUR (F3)";
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Reflesh
            // 
            this.Btn_Reflesh.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.Btn_Reflesh.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.Btn_Reflesh.Appearance.Options.UseBackColor = true;
            this.Btn_Reflesh.Appearance.Options.UseFont = true;
            this.Btn_Reflesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Reflesh.Location = new System.Drawing.Point(167, 101);
            this.Btn_Reflesh.Name = "Btn_Reflesh";
            this.Btn_Reflesh.Size = new System.Drawing.Size(111, 36);
            this.Btn_Reflesh.TabIndex = 2;
            this.Btn_Reflesh.Text = "SIFIRLA (F5)";
            this.Btn_Reflesh.Click += new System.EventHandler(this.Btn_Reflesh_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(283, 149);
            this.Controls.Add(this.Btn_Reflesh);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.lbl_Krotext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KRONOMETRE";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHome_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lbl_Krotext;
        private DevExpress.XtraEditors.SimpleButton Btn_Start;
        private DevExpress.XtraEditors.SimpleButton Btn_Stop;
        private DevExpress.XtraEditors.SimpleButton Btn_Reflesh;
    }
}

