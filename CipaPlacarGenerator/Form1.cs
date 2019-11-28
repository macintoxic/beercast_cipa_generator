using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace CipaPlacarGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int width = panel5.Size.Width;
            int height = panel5.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            panel5.DrawToBitmap(bm, new Rectangle(0, 0, width, height));


            Clipboard.SetImage(bm);

           // bm.Save(@"D:\TestDrawToBitmap.bmp", ImageFormat.Bmp);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

// ConfigurationManager.AppSettings["a"] = 1.ToString();
            ConfigurationManager.AppSettings.Set("ha", txtHa.Text);
           
            //Properties.Settings.Default.Properties.Clear();

            //Properties.Settings.Default.Properties.Add(
            //    new SettingsProperty("txtHa")
            //    {
            //        DefaultValue = txtHa.Text,
            //        IsReadOnly = false,
            //        PropertyType = typeof(string),
            //        Provider = Properties.Settings.Default.Providers["LocalFileSettingsProvider"],

            //    }
            //    );

            //Properties.Settings.Default.Save();
            //System.Configuration.SettingsProperty prop = new SettingsProperty("txtHa")
            //{
            //    DefaultValue = "Default",
            //    IsReadOnly = false,
            //    PropertyType = typeof(string),
            //    Provider = Properties.Settings.Default.Providers["LocalFileSettingsProvider"],

            //};
            //prop.Attributes.Add(typeof(UserScopedSettingAttribute), new UserScopedSettingAttribute());
            //Properties.Settings.Default.Properties.Add(prop);



            //Properties.Settings.Default.Properties.Add(new SettingsProperty("txtHa")
            //{
            //    DefaultValue = "Default",
            //    IsReadOnly = false,
            //    PropertyType = typeof(string),
            //    Provider = Properties.Settings.Default.Providers["LocalFileSettingsProvider"]
            //});


            //Properties.Settings.Default.Properties.Add(new SettingsProperty( "txtHa",  txtHa.Text);
            //Properties.Settings.Default.Properties.Add ("txtRecorde", txtRecorde.Text);
            //Properties.Settings.Default.Save();
            //Properties.Settings.Default["txtRecorde"] = txtRecorde.Text;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var x = Properties.Settings.Default.Properties["txtHa"];
            txtHa.Text = ConfigurationManager.AppSettings.Get("ha");
            //if (Properties.Settings.Default.SettingsKey ["txtHa"] != null)
            //    txtHa.Text = Properties.Settings.Default["txtHa"].ToString();
        }
    }
}
