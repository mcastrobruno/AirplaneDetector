using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionApiCar
{
    public partial class FormMain : Form
    {
        private static readonly List<VisualFeatureTypes> features = new List<VisualFeatureTypes>
        {
            VisualFeatureTypes.Categories, VisualFeatureTypes.Description, VisualFeatureTypes.Tags
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnSelectPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog
            {
                Filter = "Image files (*.jpg)|*.jpg"
            };

            DialogResult result = fd.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtImagePath.Text = fd.FileName;
                pBoxImage.Load(fd.FileName);
            }
        }

        private async void BtnAnalysis_ClickAsync(object sender, EventArgs e)
        {
            ComputerVisionClient computerVision = new ComputerVisionClient(new ApiKeyServiceClientCredentials(settings.SubscriptionKey))
            {
                Endpoint = $"https://{settings.RegionEnpoint}"
            };

            await AnalyzeLocalAsync(computerVision, txtImagePath.Text);
        }


        private async Task AnalyzeLocalAsync(ComputerVisionClient computerVision, string imagePath)
        {
            if (!File.Exists(imagePath))
            {
                txtAnalyseResult.Text = "Não foi possível carregar a imagem...";
            }

            using (Stream imageStream = File.OpenRead(imagePath))
            {
                var analysis = await computerVision.DetectObjectsInStreamAsync(imageStream);

                var stuffs = analysis.Objects.Select(x => x.ObjectProperty);


                txtAnalyseResult.Text += $"\nTags: {string.Join(",", stuffs)}";
            }
        }

    }
}
