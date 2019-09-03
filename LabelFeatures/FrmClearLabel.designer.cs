namespace RHW.CartoGraphic
{
    partial class FrmClearLabel
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
            this.cbxLayers = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLayers.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxLayers
            // 
            this.cbxLayers.EditValue = "";
            this.cbxLayers.Location = new System.Drawing.Point(67, 35);
            this.cbxLayers.Margin = new System.Windows.Forms.Padding(2);
            this.cbxLayers.Name = "cbxLayers";
            this.cbxLayers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLayers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxLayers.Size = new System.Drawing.Size(286, 20);
            this.cbxLayers.TabIndex = 21;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 38);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "图层：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(278, 79);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "应用";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmClearLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 133);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxLayers);
            this.Controls.Add(this.labelControl5);
            this.MaximizeBox = false;
            this.Name = "FrmClearLabel";
            this.Text = "清除标注";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmClearLabel_FormClosed);
            this.Load += new System.EventHandler(this.FrmClearLabel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbxLayers.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.ComboBoxEdit cbxLayers;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}