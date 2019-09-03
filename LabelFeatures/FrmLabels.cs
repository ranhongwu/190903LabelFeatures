using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using stdole;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LabelFeatures;

namespace RHW.CartoGraphic
{
    public partial class FrmLabels : DevExpress.XtraEditors.XtraForm
    {
        public FrmLabels(IMap map)
        {
            InitializeComponent();
            pMap = map;
        }

        public FrmLabels(IMap map,IFeatureClass featureClass)
        {
            InitializeComponent();
            pFeatureClass = featureClass;
            pMap = map;
        }

        #region 定义变量
        public IMap pMap = null;
        
        public IColor TextColor = ColorToIColor(Color.FromArgb(255, 0, 0));
        private IFeatureClass pFeatureClass = null;
        private string LabelField = "";

        //字体设置
        IFontDisp pFontDisp=null;
        IRgbColor MyColor = new RgbColor();//颜色
        Color pColor = Color.Black;
        #endregion

        //加载窗体,遍历图层
        private void FrmLabels_Load(object sender, EventArgs e)
        {
            //从右键菜单选项中添加标注的情况
            if (cbxLayers.Text.Trim() != "")
            {
                List<string> attList = new List<string>();
                attList = get_FieldsString(pFeatureClass);
                foreach (string s in attList)
                {
                    cbxFields.Properties.Items.Add(s);
                }
                cbxFields.SelectedIndex = 0;
            }

            for (int i = 0; i < pMap.LayerCount; i++)
            {
                if (pMap.Layer[i] is FeatureLayer)
                {
                    cbxLayers.Properties.Items.Add(pMap.Layer[i].Name);
                }
            }

            //初始化字体
            pFontDisp = new stdole.StdFontClass() as stdole.IFontDisp;
            pFontDisp.Name = "Tahoma";
            pFontDisp.Size = 9;

            MyColor.Blue = 255;
            MyColor.Red = 0;
            MyColor.Green = 0;

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.ForeColor = pColor;
        }

        //选择图层后遍历属性字段
        private void cbxLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> attList = new List<string>();
            IFeatureLayer pFeatureLayer = new FeatureLayer();

            cbxFields.Properties.Items.Clear();
            for (int i = 0; i < pMap.LayerCount; i++)
            {
                if ((pMap.Layer[i] is FeatureLayer)&&(pMap.Layer[i].Name==cbxLayers.Text))
                {
                    pFeatureLayer = pMap.Layer[i] as IFeatureLayer;
                    pFeatureClass = pFeatureLayer.FeatureClass;
                }
            }
            attList = get_FieldsString(pFeatureClass);
            foreach(string s in attList)
            {
                cbxFields.Properties.Items.Add(s);
            }
        }

        //关闭窗体
        private void FrmLabels_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.frmLabels = null;
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1.frmLabels = null;
            this.Close();
        }

        //确定标注地图
        private void btnOK_Click(object sender, EventArgs e)
        {
            #region 输入条件判断
            if (cbxLayers.Text.Trim() == "")
            {
                MessageBox.Show("请选择标注要素!", "提示");
                return;
            }
            if (cbxFields.Text.Trim() == "")
            {
                MessageBox.Show("请选择标注字段!", "提示");
                return;
            }
            #endregion

            LabelField = cbxFields.Text;
            string layerName = cbxLayers.Text;
            IFeatureLayer pFeatureLayer=null;

            for (int i = 0; i < pMap.LayerCount; i++)
            {
                if ((pMap.Layer[i] is FeatureLayer) && (pMap.Layer[i].Name == cbxLayers.Text))
                {
                    pFeatureLayer = pMap.Layer[i] as IFeatureLayer;
                    break;
                }
            }

            //产生文本符号
            ITextSymbol pTextSymbol = new TextSymbolClass();
            pTextSymbol.Font = pFontDisp;
            pTextSymbol.Color = ColorToIColor(pColor);

            FunLabelFeatureLayer(pFeatureLayer, LabelField, MyColor, pTextSymbol);

            IActiveView pActiveView = pMap as IActiveView;
            pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
            pFeatureLayer.ShowTips = true;
        }

        //设置字体
        private void btnStyle_Click(object sender, EventArgs e)
        {
            System.Drawing.Font font = null;
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog.Font;
                pFontDisp.Name = font.Name;
                pFontDisp.Size = (decimal)font.Size;
                pFontDisp.Italic = font.Italic;
                pFontDisp.Bold = font.Bold;
                pFontDisp.Underline = font.Underline;
            }
            else
            {
                return;
            }

            richTextBox1.Font = font;
        }

        //设置文字颜色
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pColor = colorDialog.Color;
                richTextBox1.ForeColor = pColor;
            }
            else
            {
                return;
            }
        }

        #region 封装方法
        //标注图层
        public void FunLabelFeatureLayer(IFeatureLayer pFeaturelayer, string sLableField, IRgbColor pRGB, ITextSymbol textSymbol)
        {
            //判断图层是否为空
            if (pFeaturelayer == null)
                return;
            IGeoFeatureLayer pGeoFeaturelayer = (IGeoFeatureLayer)pFeaturelayer;
            IAnnotateLayerPropertiesCollection pAnnoLayerPropsCollection;
            pAnnoLayerPropsCollection = pGeoFeaturelayer.AnnotationProperties;
            pAnnoLayerPropsCollection.Clear();

            //未指定字体颜色则默认为黑色
            if (pRGB == null)
            {
                pRGB = new RgbColor();
                pRGB.Red = 0;
                pRGB.Green = 0;
                pRGB.Blue = 0;
            }

            IBasicOverposterLayerProperties pBasicOverposterlayerProps = new BasicOverposterLayerProperties();
            switch (pFeaturelayer.FeatureClass.ShapeType)//判断图层类型
            {
                case esriGeometryType.esriGeometryPolygon:
                    pBasicOverposterlayerProps.FeatureType = esriBasicOverposterFeatureType.esriOverposterPolygon;
                    break;
                case esriGeometryType.esriGeometryPoint:
                    pBasicOverposterlayerProps.FeatureType = esriBasicOverposterFeatureType.esriOverposterPoint;
                    break;
                case esriGeometryType.esriGeometryPolyline:
                    pBasicOverposterlayerProps.FeatureType = esriBasicOverposterFeatureType.esriOverposterPolyline;
                    break;
            }

            ILabelEngineLayerProperties pLabelEnginelayerProps = new LabelEngineLayerProperties() as ILabelEngineLayerProperties;
            pLabelEnginelayerProps.Expression = "[" + sLableField + "]";
            pLabelEnginelayerProps.Symbol = textSymbol;
            pLabelEnginelayerProps.BasicOverposterLayerProperties = pBasicOverposterlayerProps;

            pAnnoLayerPropsCollection.Add((IAnnotateLayerProperties)pLabelEnginelayerProps);
            pGeoFeaturelayer.DisplayAnnotation = true;
        }

        /// <summary>
        /// 获取待要素类的所有属性字段名
        /// </summary>
        /// <param name="pFeatureClass">待复制要素类</param>
        /// <returns>返回待复制要素类的所有属性字段名</returns>
        public static List<string> get_FieldsString(IFeatureClass pFeatureClass)
        {
            IFields pFields = pFeatureClass.Fields;
            IField pField;
            List<string> s = new List<string>();
            for (int i = 0; i < pFields.FieldCount; i++)
            {
                pField = pFields.Field[i];
                if (pField.Type != esriFieldType.esriFieldTypeGeometry)
                    s.Add(pField.Name);
            }
            return s;
        }

        /// <summary>
        /// Color转IColor
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static IColor ColorToIColor(Color color)
        {
            IColor pColor = new RgbColorClass();
            pColor.RGB = color.B * 65536 + color.G * 256 + color.R;
            return pColor;
        }
        #endregion
        
    }
}