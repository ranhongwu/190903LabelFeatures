using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ESRI.ArcGIS.Carto;
using LabelFeatures;

namespace RHW.CartoGraphic
{
    public partial class FrmClearLabel : DevExpress.XtraEditors.XtraForm
    {
        public FrmClearLabel(IMap map)
        {
            InitializeComponent();
            pMap = map;
        }

        public FrmClearLabel(IFeatureLayer featureLayer)
        {
            InitializeComponent();
            pFeatureLayer = featureLayer;
        }

        #region 定义变量
        private IMap pMap = null;
        private IFeatureLayer pFeatureLayer = null;
        #endregion

        //加载窗体
        private void FrmClearLabel_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < pMap.LayerCount; i++)
            {
                if (pMap.Layer[i] is FeatureLayer)
                {
                    cbxLayers.Properties.Items.Add(pMap.Layer[i].Name);
                }
            }
        }

        //确定，清除某图层的标记
        private void btnOK_Click(object sender, EventArgs e)
        {
            #region 输入条件判断
            if (cbxLayers.Text.Trim() == "")
            {
                MessageBox.Show("请选择图层!", "提示");
                return;
            }
            #endregion

            for (int i = 0; i < pMap.LayerCount; i++)
            {
                if((pMap.Layer[i] is FeatureLayer) && pMap.Layer[i].Name == cbxLayers.Text)
                {
                    pFeatureLayer = pMap.Layer[i] as IFeatureLayer;
                    break;
                }
            }
            IGeoFeatureLayer pGeoFeatureLayer = pFeatureLayer as IGeoFeatureLayer;
            pGeoFeatureLayer.DisplayAnnotation = false;

            IActiveView pActiveView = pMap as IActiveView;
            pActiveView.Refresh();
        }

        //关闭窗体
        private void FrmClearLabel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.frmClearLabel = null;
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1.frmClearLabel = null;
            this.Close();
        }
    }
}