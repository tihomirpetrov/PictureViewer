using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_Await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_normal_execution_Click(object sender, EventArgs e)
        {
            lb_content_view.Items.Clear();

            var inputField = textBox1.Text;
            
            Stopwatch watch = Stopwatch.StartNew();

            BeginDownloadSync();

            watch.Stop();

            PrintTimeResult(watch);
        }

        private void PrintTimeResult(Stopwatch watch)
        {
            lb_content_view.Items.Add($"Elapsed time in {watch.ElapsedMilliseconds / 1000.0} sec and {watch.ElapsedMilliseconds} ms.");
        }

        private void BeginDownloadSync()
        {
            List<string> webContent = PrepareContent();
            SetProgressBar(webContent);


            foreach (var item in webContent)
            {
                pb_loading_bar.Value += 1;
                WebPageDataModel model = DownloadData(item);
                PrintResultInListBox(model);
            }
        }

        private void PrintResultInListBox(WebPageDataModel model)
        {
            lb_content_view.Items.Add($"The content of {model.WebPageUrl} was downloaded. It contains {model.WebPageContent.Length} characters.");
        }

        private WebPageDataModel DownloadData(string item)
        {
            WebPageDataModel model = new WebPageDataModel();
            WebClient wc = new WebClient();
            model.WebPageUrl = item;
            model.WebPageContent = wc.DownloadString(item);
            return model;
        }

        private void SetProgressBar(List<string> webContent)
        {
            pb_loading_bar.Maximum = webContent.Count;
            pb_loading_bar.Value = 0;

        }

        private List<string> PrepareContent()
        {
            List<string> webPages = new List<string>();
            string[] input = textBox1.Text.Split(' ');

            foreach (var item in input)
            {
                webPages.Add(item);
            }

            return webPages;
        }
    }
}
