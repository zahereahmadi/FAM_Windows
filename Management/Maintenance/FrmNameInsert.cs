﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Management.Maintenance
{
    public partial class FrmNameInsert : Form
    {
        public string categoryName;

        public FrmNameInsert()
        {
            InitializeComponent();
        }

        private void FrmNameInsert_Load(object sender, EventArgs e)
        {
            this.dgvListName.AutoGenerateColumns = false;

            ListRefresh();
        }

        public void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                this.dgvListName.DataSource = db.PartName.ListNames(categories.intNumber);
            }
        }

        private void TxtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                this.dgvListName.DataSource = db.PartName.ListNames(categories.intNumber,txtSearchName.Text);
            }
        }

        private void BtmRegister_Click(object sender, EventArgs e)
        {
            if (txtRegisterName.Text == "")
            {
                RtlMessageBox.Show("لطفا نام کالا را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txtRegisterName.Text;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                    var nameEntity = db.PartName.GetEntity(t => t.nvcName == name);
                    if (nameEntity != null)
                    {
                        RtlMessageBox.Show("این نام کالا قبلا ثبت شده است", "خطا", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        var maxNumber = db.PartName.GetAll().Max(t => t.intNumber);
                        tabPartName tabName = new tabPartName()
                        {
                            bitSelect = false,
                            intNumber = maxNumber + 1,
                            nvcName = name,
                            intCategory = categories.intNumber
                        };
                        db.PartName.Insert(tabName);
                        db.Save();
                        RtlMessageBox.Show("ثبت با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListRefresh();
                        txtRegisterName.Text = "";
                        txtEditName.Text = "";
                    }

                }
            }
        }

        private void BtmEdit_Click(object sender, EventArgs e)
        {
            if (txtEditName.Text == "")
            {
                RtlMessageBox.Show("لطفا نام کالا را از لیست مقابل انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                    string name = txtEditName.Text;
                    if (dgvListName.CurrentRow != null)
                    {
                        int nameId = int.Parse(dgvListName.CurrentRow.Cells[0].Value.ToString());
                        var nameEntity = db.PartName.GetEntity(t => t.intID == nameId);
                        if (nameEntity != null)
                        {
                            nameEntity.intID = nameId;
                            nameEntity.bitSelect = nameEntity.bitSelect;
                            nameEntity.intNumber = nameEntity.intNumber;
                            nameEntity.nvcName = name;
                            nameEntity.intCategory = categories.intNumber;

                            db.PartName.Update(nameEntity);
                            db.Save();
                            RtlMessageBox.Show("ویرایش با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ListRefresh();
                            txtEditName.Text = "";
                            txtRegisterName.Text = "";
                        }
                    }
                }
            }
        }

        private void DgvListName_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void DgvListName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListName.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListName.CurrentRow;
                this.txtEditName.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListName.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListName.CurrentRow;
                int nameId = Convert.ToInt32(dgvRow.Cells[0].Value.ToString());
                string name = dgvRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var nameEntity = db.PartName.GetEntity(t => t.intID == nameId);
                        db.PartName.Delete(nameEntity);
                        db.Save();
                        ListRefresh();
                        txtEditName.Text = "";
                        txtRegisterName.Text = "";
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک کالا را از لیست انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtRegisterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtEditName_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DgvListName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GbRegister_Enter(object sender, EventArgs e)
        {

        }
    }
}
