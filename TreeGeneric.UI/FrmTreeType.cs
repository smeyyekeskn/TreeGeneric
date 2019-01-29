using Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeGeneric.BussinessLogic;
using TreeGeneric.Model;

namespace TreeGeneric.UI
{
    public partial class FrmTreeType : Form
    {
        private readonly ITreeTypeService treeTypeService;
        private readonly IRegionService regionService;
        private readonly FrmTreeTypes frmTreeTypes;
        private int? selectedId;
        public FrmTreeType(ITreeTypeService treeTypeService,FrmTreeTypes frmTreeTypes, int?id, ILifetimeScope scope)
        {
            InitializeComponent();
            this.frmTreeTypes = frmTreeTypes;
            this.selectedId = id;
            regionService=scope.Resolve<IRegionService>();
            
        }

        private void FrmTreeType_Load(object sender, EventArgs e)
        {
            cbTreeRegion.DataSource = regionService.GetAll();
            cbTreeRegion.ValueMember = "Id";
            cbTreeRegion.DisplayMember = "Name";
            if (selectedId != null)
            {                
                var treeType = treeTypeService.Find(f => f.Id == selectedId);
                txtName.Text = treeType.Name;
                txtDescription.Text = treeType.Description;
                txtPhoto.Text = treeType.Photo;
                txtPlantingPrice.Text = treeType.PlantingPrice.ToString();
                txtStock.Text = treeType.AvailabilityCount.ToString();
                txtTreePrice.Text = treeType.TreePrice.ToString();
                cbTreeRegion.SelectedItem = treeType.Region.Name;
                if (treeType.IsActive)
                {
                    rbActive.Checked = true;
                }
                else
                {
                    rbPassive.Checked = true;
                }
            }
           


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (selectedId != null)
            {
                UpdateTreeType();
            }
            else
            {
                AddTreeType();
            }
        }
        public void UpdateTreeType()
        {
            var treeType = treeTypeService.Find(f => f.Id == selectedId);
            treeType.Name = txtName.Text;
            treeType.Description = txtDescription.Text;
            treeType.Photo = txtPhoto.Text;
            treeType.PlantingPrice = int.Parse(txtPlantingPrice.Text);
            treeType.TreePrice = int.Parse(txtTreePrice.Text);
            treeType.AvailabilityCount = int.Parse(txtStock.Text);
            treeType.RegionId = int.Parse(cbTreeRegion.SelectedValue.ToString());
            treeType.Commision = decimal.Parse(10.ToString());

            if (rbActive.Checked)
            {
                treeType.IsActive = true;
            }
            else
            {
                treeType.IsActive = false;
            }

            treeTypeService.Update(treeType);
            this.Close();
            frmTreeTypes.RefreshGrid();
        }
        public void AddTreeType()
        {
            
                var treeType = new TreeType();
                treeType.Name = txtName.Text;
                treeType.Description = txtDescription.Text;
                treeType.Photo = txtPhoto.Text;
                treeType.AvailabilityCount = int.Parse(txtStock.Text);
                treeType.TreePrice = decimal.Parse(txtTreePrice.Text);
                treeType.PlantingPrice = decimal.Parse(txtPlantingPrice.Text);
                treeType.Commision = decimal.Parse(10.ToString());
                treeType.RegionId = int.Parse(cbTreeRegion.SelectedValue.ToString());
                //treeType.CreatedBy = "username";
                if (rbActive.Checked)
                {
                    treeType.IsActive = true;
                }
                else if (rbPassive.Checked)
                {
                    treeType.IsActive = false;
                }
                treeTypeService.Insert(treeType);
                this.Close();
                frmTreeTypes.RefreshGrid();
        }
              
    }
}
