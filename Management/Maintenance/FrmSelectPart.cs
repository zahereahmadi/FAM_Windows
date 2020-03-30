using Baran.Ferroalloy.Automation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management.Maintenance
{
    public partial class FrmSelectPart : Form
    {
        private bool bolEnableBtmSearchByInterface;
        public int partId;
        public string partName;
        public string partCode;
        public string measurementUnit;

        public FrmSelectPart()
        {
            InitializeComponent();
            bolEnableBtmSearchByInterface = false;
            partId = 0;
            partName = "";
            partCode = "";
            measurementUnit = "";
        }

        private void FrmSelectPart_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                //Fill cbStores
                var storeses = db.Stores.GetAll();
                foreach (var item in storeses)
                {
                    cbStores.Items.Add(item.nvcName);
                }
                //Fill cbCategory
                var categorieses = db.Categories.GetAll();
                foreach (var item in categorieses)
                {
                    cbCategories.Items.Add(item.nvcName);
                }

                dgvParts.AutoGenerateColumns = false;

            }
            SetEnableBtmSearch();
        }



        #region Filter

        public void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var tabPartTypes = db.PartTypes.FilterPartTypes(cbStores.SelectedItem, cbCategories.SelectedItem, cbName.SelectedItem,
                    cbBranch.SelectedItem, cbSubBranch.SelectedItem);
                var list = db.PartTypes.FillDgvParts(tabPartTypes);
                dgvParts.DataSource = list;
                //var filter = db.PartTypes.GetAll().Where(t =>
                //    t.tabStores.nvcName.Equals(cbStores.SelectedItem) ||
                //    t.tabCategories.nvcName.Equals(cbCategories.SelectedItem) ||
                //    t.tabPartName.nvcName.Equals(cbName.SelectedItem) ||
                //    t.tabPartBranch.Equals(cbBranch.SelectedItem) ||
                //    t.tabPartSubBranch.nvcName.Equals(cbSubBranch.SelectedItem));
                //List<PartsViewModel> list = new List<PartsViewModel>();
                //foreach (var item in filter)
                //{
                //    var parts = db.PartTypes.GetEntityById(item.intID);
                //    list.Add(new PartsViewModel()
                //    {
                //        storeTitle = item.tabStores.nvcName,
                //        categoryTitle = item.tabCategories.nvcName,
                //        nameTitle = item.tabPartName.nvcName,
                //        branchTitle = item.tabPartBranch.nvcName,
                //        subBranchTitle = item.tabPartSubBranch.nvcName,
                //        measurementUnitTitle = item.tabMeasurementUnits.nvcName,
                //        floOrderPoint = parts.floOrderPoint,
                //        floSupply = parts.floSupply,
                //        intID = item.intID
                //    });
                //}
                //dgvParts.DataSource = list;
            }
        }

        #endregion

        #region Stores

        private void CbStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbName.Items.Clear();
            this.cbCategories.SelectedIndex = -1;
            this.cbBranch.Items.Clear();
            this.cbSubBranch.Items.Clear();
            labCode.Text = "";
            labName.Text = "";

            SetEnableBtmSearch();
        }

        #endregion

        #region Categories

        private void CbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbMinorGroups
            this.cbName.Items.Clear();
            this.cbSubBranch.Items.Clear();
            if (this.cbCategories.SelectedIndex > 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var categoryId = cbCategories.SelectedIndex;
                    var names = db.PartName.Get(t => t.intCategory == categoryId);
                    foreach (var item in names)
                    {
                        cbName.Items.Add(item.nvcName);
                    }
                }
                this.cbBranch.Items.Clear();
                this.labCode.Text = "";
                this.labName.Text = "";
            }

            SetEnableBtmSearch();
        }

        #endregion

        #region Names

        private void cbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbBranch.Items.Clear();
            using (UnitOfWork db = new UnitOfWork())
            {
                var name = cbName.SelectedItem;
                var branches = db.PartBranch.GetAll().Where(t => t.tabPartName.nvcName.Equals(name));
                foreach (var item in branches)
                {
                    cbBranch.Items.Add(item.nvcName);
                }
            }
            SetEnableBtmSearch();
        }

        #endregion

        #region Branch

        private void CbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbSubBranch.Items.Clear();
            using (UnitOfWork db = new UnitOfWork())
            {
                var name = cbBranch.SelectedItem;
                var branches = db.PartSubBranch.GetAll().Where(t => t.tabPartBranch.nvcName.Equals(name));
                foreach (var item in branches)
                {
                    cbSubBranch.Items.Add(item.nvcName);
                }
            }
            SetEnableBtmSearch();
        }

        #endregion

        #region SubBranch

        private void CbSubBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.labName.Text = cbName.SelectedItem + " " + cbBranch.SelectedItem + " " + cbSubBranch.SelectedItem;
                var storeId = db.Stores.GetEntityByName(t => t.nvcName == cbStores.SelectedItem).intNumber.ToString();
                var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber.ToString();
                var nameId = db.PartName.GetEntityByName(t => t.nvcName == cbName.SelectedItem).intNumber.ToString();
                var branchId = db.PartBranch.GetEntityByName(t => t.nvcName == cbBranch.SelectedItem).intNumber.ToString();
                var subBranchId = db.PartSubBranch.GetEntityByName(t => t.nvcName == cbSubBranch.SelectedItem).intNumber.ToString();
                var model = MyExtentions.GetPartTypeByIds(storeId, categoryId, nameId, branchId, subBranchId);
                this.labCode.Text = model.Store + "" + model.Category + "" + model.PartName + "" + model.PartBranch + "" + model.PartSubBranch;

                //var parts = db.Parts.GetAll().FirstOrDefault(t =>
                //    t.intStore == int.Parse(storeId) && t.intCategory == int.Parse(categoryId) && t.intName == int.Parse(nameId) &&
                //    t.intBranch == int.Parse(branchId) && t.intSubBranch == int.Parse(subBranchId));
            }
            SetEnableBtmSearch();
        }

        #endregion

        private void SetEnableBtmSearch()
        {
            if (this.cbBranch.SelectedIndex >= 1 || this.cbStores.SelectedIndex >= 1 ||
                this.cbCategories.SelectedIndex >= 1 || this.cbName.SelectedIndex >= 1)
            {
                this.btmSearch.Enabled = true;
            }
            else
            {
                this.btmSearch.Enabled = false;
            }
        }

        private void BtmSearch_Click(object sender, EventArgs e)
        {
            this.btmSearch.Enabled = false;
            Filter();
            this.btmSearch.Enabled = true;
        }

        private void BtmSelect_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow != null)
            {
                partId = Convert.ToInt32(dgvParts.CurrentRow.Cells["intID"].Value.ToString());
                using (UnitOfWork db=new UnitOfWork())
                {
                    var parts = db.PartTypes.GetEntity(t => t.intID == partId);
                    partName = parts.tabPartName.nvcName + " " + parts.tabPartBranch.nvcName + " " + parts.tabPartSubBranch.nvcName;
                    var measurementUnits = db.MeasurementUnits.GetEntity(t => t.intCategory == parts.intCategory);
                    measurementUnit = measurementUnits.nvcName;
                    var storeId = parts.intStore.ToString();
                    var categoryId = parts.intCategory.ToString();
                    var nameId = parts.intName.ToString();
                    var branchId = parts.intBranch.ToString();
                    var subBranchId = parts.intSubBranch.ToString();
                    var model = MyExtentions.GetPartTypeByIds(storeId, categoryId, nameId, branchId, subBranchId);
                    partCode = model.Store + "" + model.Category + "" + model.PartName + "" + model.PartBranch + "" + model.PartSubBranch;
                }
                this.Close();
            }
            else
            {
                RtlMessageBox.Show("لطفا یک قطعه را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
