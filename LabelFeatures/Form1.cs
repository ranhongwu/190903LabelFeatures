using RHW.CartoGraphic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabelFeatures
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        //标注显示
        public static FrmLabels frmLabels = null;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (frmLabels == null)//防止重复打开窗体
            {
                frmLabels = new FrmLabels(axMapControl1.Map);
                frmLabels.Show();
            }
            else
            {
                frmLabels.Activate();
            }
        }

        //清除标注
        public static FrmClearLabel frmClearLabel = null;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (frmClearLabel == null)
            {
                frmClearLabel = new FrmClearLabel(axMapControl1.Map);
                frmClearLabel.Show();
            }
            else
            {
                frmClearLabel.Activate();
            }
        }
    }
}
