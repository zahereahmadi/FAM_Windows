﻿using System;
using Baran.Ferroalloy.Automation.SqlDataBase;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using Baran.Ferroalloy.Finance;

namespace Baran.Ferroalloy.Office
{
    public class Employee
    {
        public int intID;
        public string strCoID;
        public string strFirstName;
        public string strLastName;
        public string strNationalID;
        public string strInsuranceNumber;
        public bool bolIsShiftMode;
        public int intDepartment;
        public int intSubDepartment;
        public int intSubDepartmentSubset;
        public int intPost;
        public int intEmploymentType;
        public int intShiftType;
        public int intWorkGroup;
        public bool bolIsLeader;
        public string strPhoneNumber;
        public DateTime dtBirth;
        public string strFatherName;
        public int intEducationLevel;
        public string strLocationProvince;
        public string strLocationCounty;
        public string strLocationCityVillage;
        public string strLocationAddress;
        public string strPostalCode;
        public Banking bnkInfo;

        public string strName
        {
            get
            {
                return this.strFirstName + " " + this.strLastName;
            }
        }

        public enum EmploymentType
        {
            روزمزد = 1,
            شرکتی = 2,
            قراردادی = 3
        }
        public enum EducationLevel
        {
            زیردیپلم=1,
            دیپلم=2,
            کاردانی=3,
            کارشناسی=4,
            فوق‌لیسانس=5,
            دکترا=6
        }
        public enum PostType
        {
            مدیر_عامل=1,
            مدیر_کارخانه=2,
            معاون_مدیرعامل=3,
            مدیر=4,
            رییس=5,
            مسول=6,
            تکنسین=7,
            کارگر=8
        }

        public struct ReportColumnProperty
        {
            public string strName;
            public string strCaption;
            public double douWidth;
            public Type typType;
        }

        public Employee()
        {
            this.intID = 0;
            this.strCoID = "";
            this.intDepartment = 0;
            this.strFirstName = "";
            this.strLastName = "";
            this.strNationalID = "";
            this.strInsuranceNumber = "";
            this.bolIsShiftMode = false;
            this.intDepartment = 0;
            this.intSubDepartment = 0;
            this.intSubDepartmentSubset = 0;
            this.intPost = 0;
            this.intEmploymentType = 0;
            this.intShiftType = 0;
            this.intWorkGroup = 0;
            this.bolIsLeader = false;
            this.strPhoneNumber = "";
            this.dtBirth = new DateTime();
            this.strFatherName = "";
            this.intEducationLevel = 0;
            this.strLocationProvince = "";
            this.strLocationCounty = "";
            this.strLocationCityVillage = "";
            this.strLocationAddress = "";
            this.strPostalCode = "";
            this.bnkInfo = new Banking();
        }
        public static string GetSqlCommand(Employee emSearchArg,string strColumnsArg)
        {
            String strCommand = @"SELECT "+ strColumnsArg + " FROM vieEmployeesInfo";

            if (emSearchArg.strFirstName.Length != 0 || emSearchArg.strLastName.Length != 0 || emSearchArg.strCoID.Length != 0 ||
               emSearchArg.strNationalID.Length != 0 || emSearchArg.intDepartment != 0)
            {
                strCommand += @" WHERE ";
            }

            if (emSearchArg.strFirstName.Length != 0)
            {
                strCommand += @"nvcFirstName LIKE N'%" + emSearchArg.strFirstName + "%' ";
            }

            if (emSearchArg.strLastName.Length != 0)
            {
                if (emSearchArg.strFirstName.Length != 0)
                {
                    strCommand += @"AND nvcLastName LIKE N'%" + emSearchArg.strLastName + "%' ";
                }
                else
                {
                    strCommand += @"nvcLastName LIKE N'%" + emSearchArg.strLastName + "%' ";
                }

            }

            if (emSearchArg.strCoID.Length != 0)
            {
                if (emSearchArg.strFirstName.Length != 0 || emSearchArg.strLastName.Length != 0)
                {
                    strCommand += @" AND nvcCoID = '" + emSearchArg.strCoID + "' ";
                }
                else
                {
                    strCommand += @"nvcCoID = '" + emSearchArg.strCoID + "'";
                }

            }

            if (emSearchArg.strNationalID.Length != 0)
            {
                if (emSearchArg.strFirstName.Length != 0 || emSearchArg.strLastName.Length != 0 || emSearchArg.strCoID.Length != 0)
                {
                    strCommand += @" AND nvcNationalID LIKE N'%" + emSearchArg.strNationalID + "%' ";
                }
                else
                {
                    strCommand += @"nvcNationalID LIKE N'%" + emSearchArg.strNationalID + "%' ";
                }
            }

            if (emSearchArg.intDepartment != 0)
            {
                if (emSearchArg.strFirstName.Length != 0 || emSearchArg.strLastName.Length != 0 || emSearchArg.strCoID.Length != 0 ||
                    emSearchArg.strNationalID.Length != 0)
                {
                    strCommand += @" AND intDepartment =" + emSearchArg.intDepartment + " ";
                }
                else
                {
                    strCommand += @"intDepartment =" + emSearchArg.intDepartment + " ";
                }
            }

            return strCommand;
        }
        public static DataTable GetEmployees(Connection cnConnection, Employee emSearchArg)
        {
            // A table mapping names the DataTable.
            DataTable dtEmployees = new DataTable();

            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daEmployees = new SqlDataAdapter();
           
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daEmployees.SelectCommand = new SqlCommand(GetSqlCommand(emSearchArg,"*"), cnSqlConnection);
            daEmployees.Fill(dtEmployees);
            cnSqlConnection.Close();

            return dtEmployees;
        }
        public static Employee GetByCoID(Connection cnConnection,string strCoIDArg)
        {
            Employee emResult = new Employee();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmEmployees = new SqlCommand();

            cmEmployees.Connection = scConnection;
            cmEmployees.CommandText = String.Format("SELECT * FROM tabEmployees WHERE nvcCoID='{0}'",strCoIDArg);

            scConnection.Open();
            SqlDataReader drEmployees = cmEmployees.ExecuteReader();
            if(drEmployees.Read())
            {
                emResult.intID = (int)drEmployees["intID"];
                emResult.strCoID = drEmployees["nvcCoID"].ToString();
                emResult.strFirstName = drEmployees["nvcFirstname"].ToString();
                emResult.strLastName = drEmployees["nvcLastname"].ToString();
                emResult.strNationalID = drEmployees["nvcNationalID"].ToString();
                emResult.intDepartment = (int)drEmployees["intDepartment"];
                emResult.intSubDepartment = (int)drEmployees["intSubDepartment"];
                emResult.intEmploymentType = (int)drEmployees["intEmploymentType"];
                emResult.intShiftType = (int)drEmployees["intShiftType"];
                emResult.strPhoneNumber = drEmployees["nvcMobileNumber"].ToString();
                emResult.dtBirth = new DateTime();
                emResult.strFatherName = drEmployees["nvcFatherName"].ToString();
                emResult.strLocationProvince = drEmployees["nvcLocationProvince"].ToString();
                emResult.strLocationCounty = drEmployees["nvcLocationCounty"].ToString();
                emResult.strLocationCityVillage = drEmployees["nvcLocationCityVillage"].ToString();
                emResult.strLocationAddress = drEmployees["nvcLocationAddress"].ToString();
            }
            drEmployees.Close();
            scConnection.Close();

            return emResult;
        }
        public static void GetByCoID(Connection cnConnection, string strCoIDArg, Employee emEmployeeArg)
        {
            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmEmployees = new SqlCommand();
            
            cmEmployees.Connection = scConnection;
            cmEmployees.CommandText = String.Format("SELECT * FROM tabEmployees WHERE nvcCoID='{0}'", strCoIDArg);

            scConnection.Open();
            SqlDataReader drEmployees = cmEmployees.ExecuteReader();
            if (drEmployees.Read())
            {
                emEmployeeArg.intID = (int)drEmployees["intID"];
                emEmployeeArg.strCoID = drEmployees["nvcCoID"].ToString();
                emEmployeeArg.strFirstName = drEmployees["nvcFirstname"].ToString();
                emEmployeeArg.strLastName = drEmployees["nvcLastname"].ToString();
                emEmployeeArg.strNationalID = drEmployees["nvcNationalID"].ToString();
                emEmployeeArg.intDepartment = (int)drEmployees["intDepartment"];
                emEmployeeArg.intSubDepartment = (int)drEmployees["intSubDepartment"];
                emEmployeeArg.intPost = (int)drEmployees["intPost"];
                emEmployeeArg.intEmploymentType = (int)drEmployees["intEmploymentType"];
                emEmployeeArg.intShiftType = (int)drEmployees["intShiftType"];
                emEmployeeArg.strPhoneNumber = drEmployees["nvcMobileNumber"].ToString();
                emEmployeeArg.dtBirth = new DateTime();
                emEmployeeArg.strFatherName = drEmployees["nvcFatherName"].ToString();
                emEmployeeArg.strLocationProvince = drEmployees["nvcLocationProvince"].ToString();
                emEmployeeArg.strLocationCounty = drEmployees["nvcLocationCounty"].ToString();
                emEmployeeArg.strLocationCityVillage = drEmployees["nvcLocationCityVillage"].ToString();
                emEmployeeArg.strLocationAddress = drEmployees["nvcLocationAddress"].ToString();
            }
            drEmployees.Close();
            scConnection.Close();
        }
        //Insert The Object in Sql Server DataBase
        public bool Insert(Connection cnConnection)
        {
            bool bolResultLoc;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);

            SqlCommand cmEmployees = new SqlCommand();
            cmEmployees.Connection = scConnection;
            cmEmployees.CommandText = 
                string.Format(@"INSERT INTO tabEmployees (nvcCoID, nvcFirstName, nvcLastName, nvcNationalID, intDepartment,intSubDepartment, intPost, intEmploymentType," +
                "bitIsShiftMode, intShiftType, nvcMobileNumber, datBirth, nvcFatherName, intEducationLevel, nvcLocationProvince, nvcLocationCounty, nvcLocationCityVillage," +
                "nvcLocationAddress, nvcPostalCode, nvcInsuranceNumber,intSubDepartmentSubset,intWorkGroup,bitIsLeader) VALUES " +
                "('{0}',N'{1}',N'{2}','{3}',{4},{5},{6},{7},'{8}',{9},'{10}','{11}-{12}-{13}',N'{14}',{15},N'{16}',N'{17}',N'{18}',N'{19}','{20}','{21}',{22},{23},'{24}')", this.strCoID,this.strFirstName,this.strLastName,
                this.strNationalID,this.intDepartment,this.intSubDepartment,this.intPost,this.intEmploymentType,this.bolIsShiftMode, this.intShiftType,this.strPhoneNumber,this.dtBirth.Year,this.dtBirth.Month,
                this.dtBirth.Day,this.strFatherName,this.intEducationLevel,this.strLocationProvince,this.strLocationCounty,this.strLocationCityVillage,this.strLocationAddress,this.strPostalCode,this.strInsuranceNumber,
                this.intSubDepartmentSubset,this.intWorkGroup,this.bolIsLeader);

            SqlCommand cmEmployeeBankInfo = new SqlCommand();
            cmEmployeeBankInfo.Connection = scConnection;
            cmEmployeeBankInfo.CommandText = string.Format(@"INSERT INTO tabEmployeesBankInfo (nvcCoID,nvcName,nvcAccount,nvcShaba,nvcAtmCard)" + 
                " VALUES ('{0}',N'{1}','{2}','{3}','{4}')",this.strCoID,this.bnkInfo.strBankName, this.bnkInfo.strBankAccount, this.bnkInfo.strBankShaba,
                this.bnkInfo.strBankAtmCard);

            scConnection.Open();
            if(cmEmployees.ExecuteNonQuery()>0)
            {
                bolResultLoc = true;
            }
            else
            {
                bolResultLoc = false;
            }
            if(this.bnkInfo.strBankName.Length != 0 || this.bnkInfo.strBankAccount.Length != 0 || 
                this.bnkInfo.strBankShaba.Length != 0 || this.bnkInfo.strBankAtmCard.Length != 0)
            {
                cmEmployeeBankInfo.ExecuteNonQuery();
            }
            scConnection.Close();

            return bolResultLoc;
        }
        //Update The Object in Sql Server DataBase
        public void Update(Connection cnConnection)
        { 
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty); 

            SqlCommand cmEmployees = new SqlCommand(); 
            cmEmployees.Connection = cnSqlConnection;
            cmEmployees.CommandText = string.Format("UPDATE tabEmployees SET nvcCoID= '{0}', nvcFirstName=N'{1}', nvcLastName=N'{2}', nvcNationalID='{3}', intDepartment={4}, intSubDepartment={5}, intPost={6}, intEmploymentType={7}, " +
                "bitIsShiftMode='{8}', intShiftType={9}, nvcMobileNumber='{10}', datBirth='{11}-{12}-{13}', nvcFatherName=N'{14}', intEducationLevel={15}, nvcLocationProvince=N'{16}', nvcLocationCounty=N'{17}', nvcLocationCityVillage=N'{18}'," +
                "nvcLocationAddress=N'{19}', nvcPostalCode='{20}', nvcInsuranceNumber='{21}' WHERE intID={22}", this.strCoID,this.strFirstName,this.strLastName, this.strNationalID,this.intDepartment,this.intSubDepartment,this.intPost,this.intEmploymentType,this.bolIsShiftMode, 
                this.intShiftType,this.strPhoneNumber,this.dtBirth.Year,this.dtBirth.Month,this.dtBirth.Day,this.strFatherName,this.intEducationLevel,this.strLocationProvince,this.strLocationCounty,this.strLocationCityVillage,
                this.strLocationAddress,this.strPostalCode,this.strInsuranceNumber, this.intID);

            SqlCommand cmEmployeeBankInfo = new SqlCommand();
            cmEmployeeBankInfo.Connection = cnSqlConnection;
            cmEmployeeBankInfo.CommandText = string.Format("UPDATE tabEmployeesBankInfo SET nvcName='{0}', nvcAccount='{1}', nvcShaba='{2}', nvcAtmCard='{3}'  WHERE nvcCoID='{4}'",
                this.bnkInfo.strBankName,this.bnkInfo.strBankAccount,this.bnkInfo.strBankShaba,this.bnkInfo.strBankAtmCard, this.strCoID);

            cnSqlConnection.Open();
            cmEmployees.ExecuteNonQuery();
            cmEmployeeBankInfo.ExecuteNonQuery();
            cnSqlConnection.Close();
        }
        //Delete The Object from Sql Server DataBase
        public static void DeleteEmployees(Connection cnConnection, DataTable dtEmployees)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmEmployees = new SqlCommand();
            cmEmployees.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach(DataRow drEmployee in dtEmployees.Rows)
            {
                if ((Boolean)drEmployee["bitSelect"])
                {
                    cmEmployees.CommandText = @"DELETE FROM tabEmployees WHERE intID = ";
                    cmEmployees.CommandText += drEmployee["intID"].ToString();
                    cmEmployees.ExecuteNonQuery();

                    cmEmployees.CommandText = @"DELETE FROM tabEmployeesBankInfo WHERE nvcCoID = '";
                    cmEmployees.CommandText += drEmployee["nvcCoID"].ToString() + "'";
                    cmEmployees.ExecuteNonQuery();
                }
            }

            cnSqlConnection.Close();
        }
        public static String GetNameByCoID(Connection cnConnection,String strCoIDArg)
        {
            String strNameLoc = "";

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmEmployee = new SqlCommand(@"SELECT * FROM tabEmployees WHERE nvcCoID = '" + strCoIDArg + "'",cnSqlConnection);
            cnSqlConnection.Open();

            SqlDataReader drEmployee = cmEmployee.ExecuteReader();

            while (drEmployee.Read())
            {
                strNameLoc = drEmployee["nvcFirstName"].ToString() + " " + drEmployee["nvcLastName"].ToString();
            }

            drEmployee.Close();
            cnSqlConnection.Close();

            return strNameLoc;
        }
        public static bool IsEmployee(Connection cnConnection,string strCoIDArg)
        {
            bool bolIsEmployee = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand comEmployees = new SqlCommand();
            comEmployees.Connection = scConnection;
            comEmployees.CommandText = String.Format("SELECT * FROM tabEmployees WHERE nvcCoID='{0}'", strCoIDArg);

            scConnection.Open();
            SqlDataReader drEmployees = comEmployees.ExecuteReader();
            if (drEmployees.Read())
            {
                bolIsEmployee = true;
            }
            else
            {
                bolIsEmployee = false;
            }
            scConnection.Close();

            return bolIsEmployee;
        }
        public static ArrayList GetProvinces(Connection cnConnection)
        {
            ArrayList alProvinces = new ArrayList();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmProvinces = new SqlCommand();

            cmProvinces.Connection = scConnection;
            cmProvinces.CommandText = String.Format("SELECT * FROM tabProvinces ORDER BY nvcName");

            scConnection.Open();
            SqlDataReader drProvinces = cmProvinces.ExecuteReader();

            while (drProvinces.Read())
            {
                alProvinces.Add(drProvinces["nvcName"].ToString());
            }

            drProvinces.Close();
            scConnection.Close();

            return alProvinces;
        }
        public static string GetNextCoId(Connection cnConnection)
        {
            string strNextCoId;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand comEmployees = new SqlCommand();
            comEmployees.Connection = scConnection;
            comEmployees.CommandText = "SELECT MAX(nvcCoID) FROM tabEmployees";

            int intCoId;
            scConnection.Open();
            try
            {
                intCoId = (int)comEmployees.ExecuteScalar();
            }
            catch(InvalidCastException)
            {
                intCoId = 1000;
            }
            
              
            strNextCoId = (++intCoId).ToString();
           
            scConnection.Close();

            return strNextCoId;
        }
    }
}