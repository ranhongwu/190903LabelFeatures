namespace RHW.CartoGraphic
{
    partial class FrmLabels
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
            this.cbxFields = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnStyle = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLayers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFields.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxLayers
            // 
            this.cbxLayers.EditValue = "";
            this.cbxLayers.Location = new System.Drawing.Point(94, 39);
            this.cbxLayers.Name = "cbxLayers";
            this.cbxLayers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLayers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxLayers.Size = new System.Drawing.Size(409, 30);
            this.cbxLayers.TabIndex = 19;
            this.cbxLayers.SelectedIndexChanged += new System.EventHandler(this.cbxLayers_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(37, 44);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 22);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "图层：";
            // 
            // cbxFields
            // 
            this.cbxFields.EditValue = "";
            this.cbxFields.Location = new System.Drawing.Point(94, 118);
            this.cbxFields.Name = "cbxFields";
            this.cbxFields.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxFields.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxFields.Size = new System.Drawing.Size(409, 30);
            this.cbxFields.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 22);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "字段：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(413, 328);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 36);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "应用";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 328);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 36);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStyle
            // 
            this.btnStyle.Location = new System.Drawing.Point(449, 259);
            this.btnStyle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.Size = new System.Drawing.Size(71, 36);
            this.btnStyle.TabIndex = 28;
            this.btnStyle.Text = "字体";
            this.btnStyle.Click += new System.EventHandler(this.btnStyle_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 214);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(407, 79);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "GISer冉";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(449, 214);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(71, 36);
            this.simpleButton1.TabIndex = 30;
            this.simpleButton1.Text = "颜色";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 184);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 22);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "预览：";
            // 
            // FrmLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 402);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnStyle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxFields);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbxLayers);
            this.Controls.Add(this.labelControl5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmLabels";
            this.Text = "标注显示";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLabels_FormClosed);
            this.Load += new System.EventHandler(this.FrmLabels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbxLayers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFields.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.ComboBoxEdit cbxLayers;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cbxFields;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnStyle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}