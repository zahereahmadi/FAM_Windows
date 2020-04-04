using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Automation.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Office;

namespace Baran.Ferroalloy.Management
{
    public partial class Login : Form
    {
        public Connection cnConnection;
        public FamSetting setSettings;
        public User usLogined;
        public Employee emLogined;
        private Management frmManagement;
        public static Boolean bolIsRunning;

        public Login()
        {
            InitializeComponent();
            bolIsRunning = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.frmManagement = (Management)this.Owner;

            if (FamSetting.GetSaveUserName(this.setSettings.strXmlPath))
            {
                this.CbSaveUserName.Checked = true;
                this.tbCoId.Text = FamSetting.GetLastUserName(this.setSettings.strXmlPath);
            }
        }

        private void btmOk_Click(object sender, EventArgs e)
        {
            if (tbCoId.Text == "" || tbPassword.Text == "")
            {
                this.labMessage.ForeColor = Color.Red;
                this.labMessage.Text = "لطفا نام کاربری و رمز ورود را وارد کنید. ";
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (this.CbSaveUserName.Checked)
                    {
                        FamSetting.SetLastUserName(this.setSettings.strXmlPath, this.tbCoId.Text);
                    }
                    var employees = db.Employees.GetEntity(t => t.nvcCoID == tbCoId.Text && t.nvcPassword == tbPassword.Text);
                    if (employees != null)
                    {
                        employees.bitLogined = true;
                        db.Save();
                        frmManagement.staUser.Text = employees.nvcFirstname + " " + employees.nvcLastname;
                        SetApplicationFacilities(employees.intPost, employees.intDepartment,
                            employees.intSubDepartment);
                        this.frmManagement.menLogIn.Enabled = false;
                        this.frmManagement.menLogOut.Enabled = true;
                        this.Close();

                    }
                    else
                    {
                        this.labMessage.ForeColor = Color.Red;
                        this.labMessage.Text = "کارمندی با این مشخصات یافت نشد. ";
                    }

                }
            }
            //User.AccountStatus usUserStatus = User.GetAccountStatus(this.cnConnection, this.tbCoId.Text, this.tbPassword.Text);

            //switch (usUserStatus)
            //{
            //    case User.AccountStatus.AccountIsReady:
            //        User.Login(this.cnConnection, ref this.usLogined, this.tbCoId.Text, this.tbPassword.Text);
            //        Employee.GetByCoID(this.cnConnection, this.usLogined.strCoID, this.emLogined);
            //        this.frmManagement.staUser.Text = this.emLogined.strName;
            //        SetApplicationFacilities();
            //        if (this.CbSaveUserName.Checked)
            //        {
            //            FamSetting.SetLastUserName(this.setSettings.strXmlPath, this.tbCoId.Text);
            //        }
            //        this.frmManagement.menLogIn.Enabled = false;
            //        this.frmManagement.menLogOut.Enabled = true;
            //        this.Close();
            //        break;

            //    case User.AccountStatus.AccountAlreadyLogined:
            //        this.labMessage.ForeColor = Color.Red;
            //        this.labMessage.Text = "این کاربر پیش از این به سامانه وارد شده است. ";
            //        DialogResult drResult = MessageBox.Show("آیا کاربری که پیش از این وارد شده است خارج و شما وارد شوید؟", "پرسش", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            //            MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            //        if (drResult == DialogResult.Yes)
            //        {
            //            User.Login(this.cnConnection, ref this.usLogined, this.tbCoId.Text, this.tbPassword.Text);
            //            Employee.GetByCoID(this.cnConnection, this.usLogined.strCoID, this.emLogined);
            //            this.frmManagement.staUser.Text = this.emLogined.strName;
            //            SetApplicationFacilities();
            //            if (this.CbSaveUserName.Checked)
            //            {
            //                FamSetting.SetLastUserName(this.setSettings.strXmlPath, this.tbCoId.Text);
            //            }
            //            this.frmManagement.menLogIn.Enabled = false;
            //            this.frmManagement.menLogOut.Enabled = true;
            //            this.Close();
            //        }
            //        break;

            //    case User.AccountStatus.UserOrPassNotCorrect:
            //        this.labMessage.ForeColor = Color.Red;
            //        this.labMessage.Text = "نام کاربری یا گذرواژه اشتباه است.";
            //        break;
            //}
        }

        private void SetApplicationFacilities(int? postId, int? departmentId, int? subDepartmentId)
        {
            if ((postId == 3 || postId == 4) && departmentId == 1 && subDepartmentId == 0)
            {
                frmManagement.menOffice.Enabled = true;
                frmManagement.menEmployees.Enabled = true;
                frmManagement.menAttendance.Enabled = true;
                frmManagement.type = false;
                // سطح دسترسی = کل کارخانه  و نوع دسترسی = خواندن
            }
            else if ((postId == 5 || postId == 8) && departmentId == 1 && subDepartmentId == 1)
            {
                frmManagement.menOffice.Enabled = true;
                frmManagement.menEmployees.Enabled = true;
                frmManagement.menAttendance.Enabled = true;
                frmManagement.type = true;
                // سطح دسترسی = کل کارخانه  و نوع دسترسی = نوشتن
            }

            else if (postId == 4 && departmentId == 1 && subDepartmentId == 2)
            {
                frmManagement.menOffice.Enabled = true;
                frmManagement.menEmployees.Enabled = true;
                frmManagement.menAttendance.Enabled = true;
                frmManagement.type = false;
                // سطح دسترسی = کارمندان زیرواحد  و نوع دسترسی = خواندن
            }
            else if ((postId == 5 || postId == 8) && departmentId == 1 && subDepartmentId == 2)
            {
                frmManagement.menOffice.Enabled = true;
                frmManagement.menEmployees.Enabled = true;
                frmManagement.menAttendance.Enabled = true;
                frmManagement.type = false;
                // سطح دسترسی = خود شخص  و نوع دسترسی = خواندن
            }
            else if (postId == 3 && (departmentId == 2 || departmentId == 3 || departmentId == 4 || departmentId == 5 || departmentId == 6) && subDepartmentId == 0)
            {
                frmManagement.menOffice.Enabled = true;
                frmManagement.menEmployees.Enabled = true;
                frmManagement.menAttendance.Enabled = true;
                frmManagement.type = false;
                // سطح دسترسی = واحد مربوطه  و نوع دسترسی = خواندن
            }
            else if (postId == 4 && (departmentId == 2 || departmentId == 3 || departmentId == 4 || departmentId == 5 || departmentId == 6) && subDepartmentId == 0)
            {
                frmManagement.menOffice.Enabled = true;
                frmManagement.menEmployees.Enabled = true;
                frmManagement.menAttendance.Enabled = true;
                frmManagement.type = false;
                // سطح دسترسی = کارمندان زیر واحد  و نوع دسترسی = خواندن
            }
            else if ((postId == 5 || postId == 6 || postId == 7 || postId == 8) && (departmentId == 2 ||
                     departmentId == 3 || departmentId == 4 || departmentId == 5 || departmentId == 6) && subDepartmentId == 0)
            {
                frmManagement.menOffice.Enabled = true;
                frmManagement.menEmployees.Enabled = true;
                frmManagement.menAttendance.Enabled = true;
                frmManagement.type = false;
                // سطح دسترسی = خودشخص  و نوع دسترسی = خواندن
            }


            //   مالی
            // حسابداری عادی

            else if ((postId == 3 || postId == 4) && departmentId == 2 && subDepartmentId == 0)
            {
                frmManagement.menFinance.Enabled = true;
                frmManagement.menNormalAccounting.Enabled = true;
                frmManagement.menIndustrialAccounting.Enabled = true;
                frmManagement.type = false;
            }
            else if ((postId == 5 || postId == 8) && departmentId == 2 && subDepartmentId == 1)
            {
                frmManagement.menFinance.Enabled = true;
                frmManagement.menNormalAccounting.Enabled = true;
                frmManagement.type = true;
            }

            else if (postId == 4 && departmentId == 2 && subDepartmentId == 2)
            {
                frmManagement.menFinance.Enabled = true;
                frmManagement.menNormalAccounting.Enabled = true;
                frmManagement.type = false;
            }
            else if ((postId == 5 || postId == 8) && departmentId == 2 && subDepartmentId == 2)
            {
                frmManagement.menFinance.Enabled = true;
                frmManagement.menNormalAccounting.Enabled = true;
                frmManagement.type = false;
            }

            //حسابداری صنعتی
            else if ((postId == 5 || postId == 8) && departmentId == 2 && subDepartmentId == 2)
            {
                frmManagement.menFinance.Enabled = true;
                frmManagement.menIndustrialAccounting.Enabled = true;
                frmManagement.type = true;
            }

            else if (postId == 4 && departmentId == 2 && subDepartmentId == 1)
            {
                frmManagement.menFinance.Enabled = true;
                frmManagement.menIndustrialAccounting.Enabled = true;
                frmManagement.type = false;
            }
            else if ((postId == 5 || postId == 8) && departmentId == 2 && subDepartmentId == 1)
            {
                frmManagement.menFinance.Enabled = true;
                frmManagement.menIndustrialAccounting.Enabled = true;
                frmManagement.type = false;
            }
            else if (postId == 3 && (departmentId == 2 || departmentId == 3 || departmentId == 4 || departmentId == 5 || departmentId == 6) && subDepartmentId == 0)
            {
                frmManagement.menFinance.Enabled = true;
                frmManagement.menIndustrialAccounting.Enabled = true;
                frmManagement.type = false;
            }
            else if (postId == 4 && (departmentId == 2 || departmentId == 3 || departmentId == 4 || departmentId == 5 || departmentId == 6) && subDepartmentId == 0)
            {
                frmManagement.menFinance.Enabled = true;
                frmManagement.menIndustrialAccounting.Enabled = true;
                frmManagement.type = false;
            }
            else if (postId == 5 && (departmentId == 2 || departmentId == 3 || departmentId == 4 || departmentId == 5 || departmentId == 6) && subDepartmentId == 0)
            {
                frmManagement.menFinance.Enabled = true;
                frmManagement.menIndustrialAccounting.Enabled = true;
                frmManagement.type = true;
            }
        }

        private void SetApplicationFacilities()
        {
            if (usLogined.bolOfficeEnabed)
            {
                this.frmManagement.menOffice.Enabled = true;

                switch (this.emLogined.intPost)
                {
                    //مدیریت
                    case 4:
                        this.frmManagement.menEmployees.Enabled = true;
                        Employees.bolWritePermision = false;
                        StoreGetOuts.bolWritePermision = true;
                        OfficePrefrences.bolWritePermision = true;
                        this.frmManagement.MensOfficeDepartmentStoreGetOuts.Enabled = true;
                        this.frmManagement.MensOfficeDepartmentStorePurchaseRequests.Enabled = true;
                        this.frmManagement.menOfficeDepartmentPrefrences.Enabled = true;
                        break;
                }
            }
            else
            {
                this.frmManagement.menOffice.Enabled = false;
            }

            if (usLogined.bolFinanceEnabed)
            {
                this.frmManagement.menFinance.Enabled = true;

            }
            else
            {
                this.frmManagement.menFinance.Enabled = false;
            }

            if (usLogined.bolCommerceEnabed)
            {
                this.frmManagement.menCommerce.Enabled = true;

            }
            else
            {
                this.frmManagement.menCommerce.Enabled = false;
            }

            if (usLogined.bolProductionEnabed)
            {
                this.frmManagement.menProduction.Enabled = true;

                switch (this.emLogined.intPost)
                {
                    //مدیریت
                    case 4:
                        this.frmManagement.menLoadingRegister.Enabled = true;
                        EmptyLadleRegister.bolWritePermision = false;
                        StoreGetOuts.bolWritePermision = true;
                        ProductionPrefrences.bolWritePermision = true;
                        this.frmManagement.mensProductionDepartmentStoreGetOuts.Enabled = true;
                        this.frmManagement.MensProductionDepartmentStorePurchaseRequests.Enabled = true;
                        this.frmManagement.menProductionDepartmentPrefrences.Enabled = true;
                        break;
                }
            }
            else
            {
                this.frmManagement.menProduction.Enabled = false;
            }

            if (usLogined.bolTechnicalEnabed)
            {
                this.frmManagement.menTechnical.Enabled = true;

                switch (this.emLogined.intPost)
                {
                    //مدیریت
                    case 4:
                        //this.frmManagement.menTechnicalDepartmentElectricalFurnace.Enabled = true;
                        //this.frmManagement.menTechnicalDepartmentElectricalWorkShop.Enabled = true;
                        //this.frmManagement.menTechnicalDepartmentElectricalSunStation.Enabled = true;
                        //this.frmManagement.menTechnicalDepartmentMechanicalFurnace.Enabled = true;
                        //this.frmManagement.menTechnicalDepartmentMechanicalWorkShop.Enabled = true;
                        //this.frmManagement.menTechnicalDepartmentMechanicalMetal.Enabled = true;
                        //this.frmManagement.menTechnicalDepartmentMechanicalPiping.Enabled = true;
                        this.frmManagement.menTechnicalDepartmentMechanicalTechnicalInfo.Enabled = true;
                        this.frmManagement.menTechnicalDepartmentMechanicalMaintenanceInfo.Enabled = true;
                        this.frmManagement.menTechnicalDepartmentProjects.Enabled = true;
                        this.frmManagement.MensTechnicalDepartmentStorePurchaseRequests.Enabled = true;
                        this.frmManagement.mensTechnicalDepartmentStoreGetOuts.Enabled = true;
                        this.frmManagement.menTechnicalDepartmentPrefrences.Enabled = true;
                        break;
                }
            }
            else
            {
                this.frmManagement.menTechnical.Enabled = false;
            }

            if (usLogined.bolStoreEnabed)
            {
                this.frmManagement.menStore.Enabled = true;

                switch (this.emLogined.intPost)
                {
                    //مدیریت
                    case 4:
                        //this.frmManagement.menStoreDepartmentStuffs.Enabled = true;
                        this.frmManagement.menStoreDepartmentVendors.Enabled = true;
                        this.frmManagement.menStoreDepartmentInvoices.Enabled = true;
                        this.frmManagement.MensStoreDepartmentStorePurchaseRequests.Enabled = true;
                        this.frmManagement.mensStoreDepartmentStoreGetOuts.Enabled = true;
                        this.frmManagement.menStoreDepartmentPrefrences.Enabled = true;
                        break;
                }

            }
            else
            {
                this.frmManagement.menStore.Enabled = false;
            }

            if (usLogined.bolLabEnabed)
            {
                this.frmManagement.menLab.Enabled = true;

                switch (this.emLogined.intPost)
                {
                    //مدیریت
                    case 4:
                        this.frmManagement.menLabDepartmentStorePurchaseRequests.Enabled = true;
                        this.frmManagement.menLabDepartmentStoreGetOuts.Enabled = true;
                        this.frmManagement.menLabDepartmentPrefrences.Enabled = true;
                        break;
                }
            }
            else
            {
                this.frmManagement.menLab.Enabled = false;
            }

            //this.menExit.Enabled = true;
            //this.menLogIn.Enabled = false;
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            bolIsRunning = false;
        }

        private void CbSaveUserName_CheckedChanged(object sender, EventArgs e)
        {
            FamSetting.SetSaveUserName(this.setSettings.strXmlPath, this.CbSaveUserName.Checked);
        }

        private void TbUsername_Enter(object sender, EventArgs e)
        {
            Language.SetEnglishLanguage();
        }

        private void TbPassword_Enter(object sender, EventArgs e)
        {
            Language.SetEnglishLanguage();
        }
    }
}
