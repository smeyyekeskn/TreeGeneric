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
using TreeGeneric.Data;

namespace Tree.UI
{
    public partial class FrmRegion : Form
    {
        private readonly IRegionService regionService;
        private readonly FrmRegions frmRegions;
        public int? selectedId;
        public FrmRegion(IRegionService regionService, FrmRegions frm, int? id)
        {
            InitializeComponent();
       
            this.regionService = regionService;
            this.selectedId = id;
            this.frmRegions = frm;
        }

        private void FrmRegion_Load(object sender, EventArgs e)
        {
            if (selectedId != null)
            {
                var region = regionService.Find(f => f.Id == selectedId);
                txtName.Text = region.Name;
                txtDescription.Text = region.Description;
                txtCapacity.Text = region.Capacity.ToString();
                txtPhoto.Text = region.Photo;
                txtLat.Text = region.Lat;
                txtLong.Text = region.Long;
                if (region.IsActive)
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
                UpdateRegion();
            }
            else
            {
                AddRegion();
            }
            
        }


        public void AddRegion()
        {
            if (rbActive.Checked == false && rbPassive.Checked == false)
            {
                MessageBox.Show("Lütfen aktiflik durumunu seçiniz");
            }
            else
            {
                var region = new TreeGeneric.Model.Region();
                region.Name = txtName.Text;
                region.Description = txtDescription.Text;
                region.Capacity = int.Parse(txtCapacity.Text);
                region.Photo = txtPhoto.Text;
                region.Lat = txtLat.Text;
                region.Long = txtLong.Text;
                if (rbActive.Checked)
                {
                    region.IsActive = true;
                }
                else if (rbPassive.Checked)
                {
                    region.IsActive = false;
                }
                regionService.Insert(region);
                this.Close();
                frmRegions.RefreshGrid();
            }

        }

        public void UpdateRegion()
        {
            var region = regionService.Find(f => f.Id == selectedId);
            region.Name = txtName.Text;
            region.Description = txtDescription.Text;
            region.Capacity = int.Parse(txtCapacity.Text);
            region.Photo = txtPhoto.Text;
            region.Lat = txtLat.Text;
            region.Long = txtLong.Text;

            if (rbActive.Checked)
            {
                region.IsActive = true;
            }
            else
            {
                region.IsActive = false;
            }

            regionService.Update(region);
            this.Close();
            frmRegions.RefreshGrid();
        }
    }
}
