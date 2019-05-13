using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VisionApiCar
{
    public partial class SettingsControl : UserControl
    {
        private Dictionary<string, string> _regions;

        public SettingsControl()
        {
            InitializeComponent();
            InitializeRegionCombo();
        }

        public string SubscriptionKey
        {
            get { return tbSubscriptionKey.Text; }
        }
        public string RegionEnpoint
        {
            get { return (string)cbRegion.SelectedValue; }
        }

        private void InitializeRegionCombo()
        {
            _regions = new Dictionary<string, string>
            {
                ["West US"] = "westus.api.cognitive.microsoft.com",
                ["West US 2"] = "westus2.api.cognitive.microsoft.com",
                ["East US"] = "eastus.api.cognitive.microsoft.com",
                ["East US 2"] = "eastus2.api.cognitive.microsoft.com",
                ["West Central US"] = "westcentralus.api.cognitive.microsoft.com",
                ["South Central US"] = "southcentralus.api.cognitive.microsoft.com",
                ["West Europe"] = "westeurope.api.cognitive.microsoft.com",
                ["North Europe"] = "northeurope.api.cognitive.microsoft.com",
                ["Southeast Asia"] = "southeastasia.api.cognitive.microsoft.com",
                ["East Asia"] = "eastasia.api.cognitive.microsoft.com",
                ["Australia East"] = "australiaeast.api.cognitive.microsoft.com",
                ["Brazil South"] = "brazilsouth.api.cognitive.microsoft.com",
                ["Canada Central"] = "canadacentral.api.cognitive.microsoft.com",
                ["Central India"] = "centralindia.api.cognitive.microsoft.com",
                ["UK South"] = "uksouth.api.cognitive.microsoft.com",
                ["Japan East"] = "japaneast.api.cognitive.microsoft.com",
            };

            cbRegion.DataSource = new BindingSource(_regions, null);
            cbRegion.DisplayMember = "Key";
            cbRegion.ValueMember = "VALUE";
        }

    }
}
