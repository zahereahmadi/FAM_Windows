using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Baran.Ferroalloy.Office.Employee;

namespace Baran.Ferroalloy.Management.Office
{
    public partial class EmployeesSelectColumns : Form
    {
       
        private Employees frmEmployees;
        private double douColumnsWidth;

        public EmployeesSelectColumns()
        {
            InitializeComponent();

           
        }
        private void EmployeesSelectColumns_Load(object sender, EventArgs e)
        {
            this.frmEmployees = (Employees)this.Owner;

           
        }
        private void btmOk_Click(object sender, EventArgs e)
        {
            SetSelectColumns();

            if (this.douColumnsWidth > 19)
            {
                MessageBox.Show("تعداد ستون‌های انتخاب شده زیاد است.");
                return;
            }
               

            Close();
        }

        private void SetSelectColumns()
        {
            this.douColumnsWidth = 0;
           
            if (this.cbFirstName.Checked)
            {
                ReportColumnProperty rcpFirstname = new ReportColumnProperty();
                rcpFirstname.strName = "nvcFirstname";
                rcpFirstname.strCaption = "نام";
                rcpFirstname.typType = typeof(System.String);
                rcpFirstname.douWidth = 2;
                this.douColumnsWidth += rcpFirstname.douWidth;
                this.frmEmployees.lisEmployeesColumns.Add(rcpFirstname);
            }
            if (this.cbLastName.Checked)
            {
                ++douColumnsWidth;
                ReportColumnProperty rclLastname = new ReportColumnProperty();
                rclLastname.strName = "nvcLastname";
                rclLastname.strCaption = "نام خانوادگی";
                rclLastname.typType = typeof(System.String);
                rclLastname.douWidth = 3;
                this.douColumnsWidth += rclLastname.douWidth;
                this.frmEmployees.lisEmployeesColumns.Add(rclLastname);
            }
            if (this.cbCoID.Checked)
            {
                ++douColumnsWidth;
                ReportColumnProperty rclCoID = new ReportColumnProperty();
                rclCoID.strName = "nvcCoID";
                rclCoID.strCaption = "کد پرسنلی";
                rclCoID.typType = typeof(System.String);
                rclCoID.douWidth = 2;
                this.douColumnsWidth += rclCoID.douWidth;
                this.frmEmployees.lisEmployeesColumns.Add(rclCoID);
            }
            if (this.cbNationalID.Checked)
            {
                ++douColumnsWidth;
                ReportColumnProperty rclNationalID = new ReportColumnProperty();
                rclNationalID.strName = "nvcNationalID";
                rclNationalID.strCaption = "کد ملی";
                rclNationalID.typType = typeof(System.String);
                rclNationalID.douWidth = 2;
                this.douColumnsWidth += rclNationalID.douWidth;
                this.frmEmployees.lisEmployeesColumns.Add(rclNationalID);
            }
            if (this.cbDepartment.Checked)
            {
                //strColumns += ", intDepartment";
            }
            if (this.cbSubdepartment.Checked)
            {
                //strColumns += ", intSubDepartment";
            }
            if (this.cbPost.Checked)
            {
                //strColumns += ", intPost";
            }
            if (this.cbEmploymentType.Checked)
            {
                //strColumns += ", intEmploymentType";
            }
            if (this.cbShiftState.Checked)
            {
                //strColumns += ", bitIsShiftMode";
            }
            if (this.cbShiftType.Checked)
            {
                //strColumns += ", intShiftType";
            }
            if (this.cbPhoneNumber.Checked)
            {
                //strColumns += ", nvcMobileNumber";
            }
            if (this.cbBirth.Checked)
            {
                //strColumns += ", datBirth";
            }
            if (this.cbFatherName.Checked)
            {
                //strColumns += ", nvcFatherName";
            }
            if (this.cbEducationLevel.Checked)
            {
                //strColumns += ", intEducationLevel";
            }
            if (this.cbLocationProvince.Checked)
            {
                //strColumns += ", nvcLocationProvince";
            }
            if (this.cbLocationCounty.Checked)
            {
                //strColumns += ", nvcLocationCounty";
            }
            if (this.cbLocationCityVillage.Checked)
            {
                //strColumns += ", nvcLocationCityVillage";
            }
            if (this.cbLocationAddress.Checked)
            {
                //strColumns += ", nvcLocationAddress";
            }
            if (this.cbPostalCode.Checked)
            {
                //strColumns += ", nvcPostalCode";
            }
        }

        private void cbFirstName_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        private void cbLastName_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void cbCoID_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbNationalID_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbDepartment_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbSubdepartment_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbPost_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbEmploymentType_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbShiftState_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void cbShiftType_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbPhoneNumber_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void dtBirth_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbFatherName_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbEducationLevel_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbLocationProvince_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbLocationCounty_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbLocationCityVillage_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbLocationAddress_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbLocationPostalCode_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            //strColumns = "";
            frmEmployees.lisEmployeesColumns = new List<ReportColumnProperty>();
            Close();
        }

        
    }
}
