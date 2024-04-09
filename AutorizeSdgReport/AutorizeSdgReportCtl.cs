using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;
using Common;
using DAL;
using LSExtensionWindowLib;
using NAppUpdate.Framework.Utils;
using Oracle.DataAccess.Client;
using LSSERVICEPROVIDERLib;
using Telerik.Charting;
using Telerik.WinControls.UI;

namespace AutorizeSdgReport
{

    [ComVisible(true)]
    [ProgId("AutorizeSdgReport.AutorizeSdgReportCtl")]
    public partial class AutorizeSdgReportCtl : UserControl, IExtensionWindow
    {
        #region Ctor
        public AutorizeSdgReportCtl()
        {
            InitializeComponent();



            try
            {
                //Entity Framework Profiler
                HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();
            }
            catch (Exception e)
            {

            }
            this.BackColor = Color.FromName("Control");
            fromDateTimePicker.Value = DateTime.Now.AddDays(-30);
            toDateTimePicker2.Value = DateTime.Now;
            this.radChartView1.Area.View.Palette = KnownPalette.Flower;
            radChartView1.ShowToolTip = true;
            var ddl = (new Telerik.WinControls.UI.RadDropDownList());


            var dal = new MockDataLayer();
            dal.Connect();
            var ph = dal.GetPhraseByID(423);
            var bb = dal.GetObjDetailses("client", "client_id <10000");
            ddl.BindingContext = new BindingContext();

            //  ddl.AutoSizeItems = true;
            //  ddl.FitItemsToSize = true;


            ddl.Items.Add("");
            var data = ph.PhraseEntries.Select(x => x.PhraseDescription);
            System.Drawing.Font f = ddl.Font;
            List<Size> sizes = new List<Size>();

            foreach (var phrase in bb)
            {
                ddl.Items.Add(phrase.Name);
                sizes.Add(TextRenderer.MeasureText(phrase.Name, f));
            }




            var str = data.First();
            var a = System.Text.ASCIIEncoding.Unicode.GetByteCount(str);
            var b = System.Text.ASCIIEncoding.ASCII.GetByteCount(str);
            int howManyBytes = data.First().Length * sizeof(Char);


            Size textSize = TextRenderer.MeasureText(str, ddl.Font);
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
                var size1 = graphics.MeasureString("Hello there", new Font("Segoe UI", 11, FontStyle.Regular, GraphicsUnit.Point));
                //   ddl.Size = textSize;
                var w = sizes.Max(x => x.Width);
                ddl.Size = new Size(w, 100);

                IList<Sdg> sd;

            }


            radPanel4.Controls.Add(ddl);
        }

        private void Bar()
        {

            radChartView1.Series.Clear();

            var dal = new MockDataLayer();
            dal.Connect();



            var list = dal.GetAothorizeSdgsByDate(fromDateTimePicker.Value, toDateTimePicker2.Value);
            list = dal.GetSdgs();
            var autorized_list = from item in list
                                 where item.AUTHORISED_ON >= fromDateTimePicker.Value
                                       && item.AUTHORISED_ON < toDateTimePicker2.Value
                                 select item;
            var created_list = from item in list
                               where item.CREATED_ON >= fromDateTimePicker.Value
                                     && item.CREATED_ON < toDateTimePicker2.Value && item.SdgClientId != null
                               select item;

            var ag = autorized_list.ToList().GroupBy(x => x.Client.Name);
            var vg = created_list.ToList().GroupBy(x => x.Client.Name);

            radChartView1.Title = "SDGS";


            BarSeries barSeries = new BarSeries("Performance", "RepresentativeName");
            barSeries.BackColor = Color.GreenYellow;
            barSeries.Name = "Authorized";
            barSeries.LegendTitle = "Authorized ON";
            barSeries.ShowLabels = true;


            foreach (IGrouping<string, Sdg> grouping in ag)
            {

                barSeries.DataPoints.Add(new CategoricalDataPoint(grouping.Count(), grouping.Key));

            }



            this.radChartView1.Series.Add(barSeries);



            //Completed
            BarSeries barSeries2 = new BarSeries("Performanc2e", "Representative2Name");
            barSeries2.Name = "Created";
            barSeries2.LegendTitle = "Created ON";
            barSeries2.ShowLabels = true;
            radChartView1.ShowToolTip = true;
            foreach (IGrouping<string, Sdg> grouping in vg)
            {

                barSeries2.DataPoints.Add(new CategoricalDataPoint(grouping.Count(), grouping.Key));

            }
            this.radChartView1.Series.Add(barSeries2);
        }

        private void Area()
        {
            radChartView1.Series.Clear();

            var dal = new MockDataLayer();
            dal.Connect();
            var list = dal.GetSdgs();

            var gropu = list.GroupBy(x => x.Status);
            AreaSeries areaSeries = new AreaSeries();

            foreach (IGrouping<string, Sdg> grouping in gropu)
            {
                var c = new CategoricalDataPoint(grouping.Count(), grouping.Key.ToString());


                areaSeries.DataPoints.Add(c);

            }

            this.radChartView1.Series.Add(areaSeries);


        }

        #endregion


        #region private members


        private IExtensionWindowSite2 _ntlsSite;
        private INautilusDBConnection _ntlsCon;
        private INautilusProcessXML _processXml;

        #endregion


        #region Implementation of IExtensionWindow

        public bool CloseQuery()
        {
            return true;
        }

        public void Internationalise() { }

        public void SetSite(object site)
        {
            _ntlsSite = (IExtensionWindowSite2)site;
            _ntlsSite.SetWindowInternalName("AutorizeSdgReportCtl");
            _ntlsSite.SetWindowRegistryName("AutorizeSdgReportCtl");
            _ntlsSite.SetWindowTitle("AutorizeSdgReportCtl");



        }


        public void PreDisplay()
        {
            Utils.CreateConstring(_ntlsCon);

        }

        public WindowButtonsType GetButtons()
        {
            return LSExtensionWindowLib.WindowButtonsType.windowButtonsNone;
        }

        public bool SaveData()
        {
            return false;
        }

        public void SetServiceProvider(object serviceProvider)
        {
            var sp = serviceProvider as NautilusServiceProvider;
            _processXml = Utils.GetXmlProcessor(sp);
            _ntlsCon = Utils.GetNtlsCon(sp);
        }

        public void SetParameters(string parameters)
        {

        }

        public void Setup()
        {

        }

        public WindowRefreshType DataChange()
        {
            return LSExtensionWindowLib.WindowRefreshType.windowRefreshNone;
        }

        public WindowRefreshType ViewRefresh()
        {
            return LSExtensionWindowLib.WindowRefreshType.windowRefreshNone;
        }

        public void refresh() { }

        public void SaveSettings(int hKey) { }

        public void RestoreSettings(int hKey) { }
        public void Close()
        {

        }


        #endregion

        private void radButton1_Click(object sender, EventArgs e)
        {
            radChartView1.Series.Clear();
            Bar();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            radChartView1.Series.Clear();
            BarStatus();

        }

        private void BarStatus()
        {
            radChartView1.Series.Clear();

            var dal = new MockDataLayer();
            dal.Connect();



            var list = dal.GetAothorizeSdgsByDate(fromDateTimePicker.Value, toDateTimePicker2.Value);
            list = dal.GetSdgs();
            var A_list = from item in list
                         where item.Status == "A" && item.SdgClientId != null
                         select item;
            var V_list = from item in list
                         where item.Status == "V" && item.SdgClientId != null
                         select item;
            var X_list = from item in list
                         where item.Status == "X" && item.SdgClientId != null
                         select item;
            //  var authorize_list = dal.ClinetBySdg(fromDateTimePicker.Value, toDateTimePicker2.Value, false);


            var ag = A_list.ToList().GroupBy(x => x.Client.Name);
            var vg = V_list.ToList().GroupBy(x => x.Client.Name);
            var xg = X_list.ToList().GroupBy(x => x.Client.Name);

            radChartView1.Title = "SDGS";


            BarSeries barSeries = new BarSeries("Performance", "RepresentativeName");
            barSeries.BackColor = Color.GreenYellow;
            barSeries.Name = "Authorized";
            barSeries.LegendTitle = "Authorized";
            barSeries.ShowLabels = true;

            foreach (IGrouping<string, Sdg> grouping in ag)
            {

                barSeries.DataPoints.Add(new CategoricalDataPoint(grouping.Count(), grouping.Key.ToString()));

            }
            radChartView1.Series.Add(barSeries);
            barSeries = new BarSeries("Performance", "RepresentativeName");
            barSeries.BackColor = Color.Red;
            barSeries.Name = "Available";
            barSeries.LegendTitle = "Available";
            barSeries.ShowLabels = true;

            foreach (IGrouping<string, Sdg> grouping in vg)
            {

                barSeries.DataPoints.Add(new CategoricalDataPoint(grouping.Count(), grouping.Key.ToString()));

            }
            radChartView1.Series.Add(barSeries);
            barSeries = new BarSeries("Performance", "RepresentativeName");
            barSeries.BackColor = Color.RosyBrown;
            barSeries.Name = "Canceled";
            barSeries.LegendTitle = "Canceled";
            barSeries.ShowLabels = true;

            foreach (IGrouping<string, Sdg> grouping in xg)
            {

                barSeries.DataPoints.Add(new CategoricalDataPoint(grouping.Count(), grouping.Key.ToString()));

            }
            radChartView1.Series.Add(barSeries);


        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            radChartView1.Series.Clear();
            var dal = new MockDataLayer();
            dal.Connect();
            var list = dal.GetSdgs();

            var gropu = list.GroupBy(x => x.Status);


            this.radChartView1.AreaType = ChartAreaType.Pie;

            radChartView1.ShowToolTip = true;
            radChartView1.ShowItemToolTips = true;



            PieSeries series = new PieSeries("Performance");
            series.LabelMode = PieLabelModes.Radial;

            radChartView1.ShowLegend = true;
            series.Name = "סטטוסים";

            series.ShowLabels = true;

            radChartView1.ShowGrid = true;

            foreach (IGrouping<string, Sdg> grouping in gropu)
            {
                var p = new PieDataPoint(grouping.Count(), grouping.Key.ToString());
                series.DataPoints.Add(p);


            }

            series.ShowLabels = true;
            this.radChartView1.Series.Add(series);

            dal.Close();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            Area();

        }

        void selectionController_SelectedPointChanged(object sender, ChartViewSelectedPointChangedEventArgs args)
        {
            if (args.NewSelectedPoint != null)
            {
                UpdateSelectedPoint(args.NewSelectedPoint);
            }
            if (args.OldSelectedPoint != null)
            {
                UpdateSelectedPoint(args.OldSelectedPoint);
            }
        }

        void UpdateSelectedPoint(DataPoint point)
        {
            PieDataPoint pieDataPoint = point as PieDataPoint;
            if (pieDataPoint != null)
            {
                if (pieDataPoint.IsSelected)
                {
                    pieDataPoint.OffsetFromCenter = 0.1;
                }
                else
                {
                    pieDataPoint.OffsetFromCenter = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var dal1 = new MockDataLayer();
            dal1.Connect();
            //   var b = dal1.GetObjDetailses("sdg", "sdg_id <1000");


            var b1 = dal1.GetAllObjectSet();


            int sid = 1000;
            //    var q1 = from item in b1 where item.SdgId < 1100 select new { item.SdgId, item.Name, item.SamplingTime };

            var qq = (from item in b1 where item.SdgId == 1100 select new { item.SdgId, item.Samples });
            
            foreach (var objDetailse in qq)
            {


                //    listBox1.Items.Add(objDetailse);

            }


            //      var b2 = dal1.GetSdgs();

            //  b = dal1.GetObjDetailses("sample", "sample_id <1000");
            //   b = dal1.GetObjDetailses("u_contract", "");

            //    var qqq = from item in b2 where item.SdgId < 1000 select item.SdgId;

            return;



            return;

            var sdgs = dal1.GetSdgs();

            foreach (var objDetailse in sdgs)
            {

            }
            foreach (var objDetailse in sdgs)
            {
                listBox1.Items.Add(objDetailse.Name);
            }
            //      USP Challenge Category
            return;


            var dal = new MockDataLayer();
            dal.Connect();
            List<string> names = new List<string>();
            var sdg = dal.GetSdgTree(1691);
            foreach (Sample sample in sdg.Samples)
            {

                names.Add(sample.Name);
                foreach (Aliquot aliqout in sample.Aliqouts)
                {
                    names.Add(aliqout.Name);

                    foreach (Test test in aliqout.Tests)
                    {
                        names.Add(test.NAME);
                        foreach (Result result in test.Results)
                        {
                            names.Add(result.Name);
                        }
                    }
                }
            }
            MessageBox.Show(names.Count.ToString());

        }

        private List<objDetails> Reflection()
        {
            List<objDetails> objDetailses = new List<objDetails>();
            var dal = new MockDataLayer();
            dal.Connect();



            var sdgPropertyInfo =
                typeof(Sdg);
            string tn = sdgPropertyInfo.Name;
            var propertyInfoName1 =
                      sdgPropertyInfo.GetProperties().Where(x => x.Name.StartsWith("Name")).FirstOrDefault();
            var propertyInfoId =
            sdgPropertyInfo.GetProperties().Where(x => x.Name.StartsWith(tn + "Id")).FirstOrDefault();
            var Sdgs = dal.GetSdgs();
            foreach (Sdg sdg in Sdgs)
            {
                object newValue = propertyInfoName1.GetValue(sdg, null);
                object newValueId = propertyInfoId.GetValue(sdg, null);
                var od = new objDetails();
                od.Name = newValue.ToString();
                od.ID = newValueId.ToString();
                objDetailses.Add(od);
            }
            return objDetailses;
            var Sdgs1 = dal.GetSdgs();
            foreach (Sdg sdg in Sdgs1)
            {
                foreach (Sample sample in sdg.Samples)
                {


                    var propertyInfoName =
                        typeof(Sample).GetProperties().Where(x => x.Name.StartsWith("Name")).FirstOrDefault();
                    object newValue = propertyInfoName.GetValue(sample, null);
                    var od = new objDetails();
                    od.Name = newValue.ToString();
                    objDetailses.Add(od);
                }
            }
            return objDetailses;

        }




        private void Stam(object sender, EventArgs e)
        {
            var dal = new MockDataLayer();
            dal.Connect();
            var Sdgs = dal.GetSdgs();


            var q = from item in Sdgs where item.Status == "X" select new { item.SdgId, item.Name };



            LogEmployees(q);




        }
        public void LogEmployees(IEnumerable<dynamic> list)
        {
            foreach (dynamic item in list)
            {
                string name = item.Name;
                int id = item.Id;
            }
        }
        private void SendQ(dynamic q)
        {


        }





    }

    public class objDetails
    {
        public string Name { get; set; }
        public string ID { get; set; }
    }
}

