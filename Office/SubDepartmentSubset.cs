using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Office
{
    public class SubDepartmentSubset
    {
        public int intID;
        public bool bolSelect;
        public bool bolIsActual;
        public int intSubDepartmnt;
        public string strName;
        public int intNumber;

        public SubDepartmentSubset()
        {
            this.intID = 0;
            this.bolSelect = false;
            this.bolIsActual = false;
            this.intSubDepartmnt = 0;
            this.strName = "";
            this.intNumber = 0;
        }

        public static SubDepartmentSubset[] GetSubDepartmentSubsets(Connection cnConnection,int intSubDepartmentsArg)
        {
            SubDepartmentSubset[] depSubDepartmentSubsets;
            int intRowsCount = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmSubDepartments = new SqlCommand("", scConnection);

            cmSubDepartments.Connection = scConnection;
            cmSubDepartments.CommandText = 
                string.Format("SELECT * FROM tabSubdepartmentSubsets WHERE bitIsActual=1 AND intSubDepartment={0} ORDER BY nvcName", intSubDepartmentsArg);

            scConnection.Open();
            SqlDataReader drSubDepartments = cmSubDepartments.ExecuteReader();
            while (drSubDepartments.Read())
            {
                ++intRowsCount;
            }
            drSubDepartments.Close();

            depSubDepartmentSubsets = new SubDepartmentSubset[intRowsCount];
            drSubDepartments = cmSubDepartments.ExecuteReader();
            intRowsCount = 0;
            while (drSubDepartments.Read())
            {
                depSubDepartmentSubsets[intRowsCount] = new SubDepartmentSubset();
                depSubDepartmentSubsets[intRowsCount].intSubDepartmnt = (int)drSubDepartments["intSubDepartment"];
                depSubDepartmentSubsets[intRowsCount].strName = drSubDepartments["nvcName"].ToString();
                depSubDepartmentSubsets[intRowsCount].intNumber = (int)drSubDepartments["intNumber"];
                ++intRowsCount;
            }

            return depSubDepartmentSubsets;
        }
        public static DataTable GetSubDepartmentSubsetsAsDataTable(Connection cnConnection)
        {
            DataTable dtSubDepartments = new DataTable();
            SqlDataAdapter daDepartments = new SqlDataAdapter();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmSubDepartments = new SqlCommand("SELECT * FROM tabSubDepartments WHERE bitIsActual=1 ORDER BY nvcName", scConnection);

            scConnection.Open();
            daDepartments.SelectCommand = cmSubDepartments;
            daDepartments.Fill(dtSubDepartments);
            scConnection.Close();

            return dtSubDepartments;
        }
        public static bool Delete(Connection cnConnection, int intIdArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmSubDepartments = new SqlCommand();

            cmSubDepartments.CommandText = String.Format("DELETE FROM tabSubDepartments WHERE intID={0}", intIdArg);
            cmSubDepartments.Connection = scConnection;

            scConnection.Open();
            if (cmSubDepartments.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static bool Insert(Connection cnConnection, SubDepartment sdInsertArg)
        {
            bool bolResultLoc = false;
            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmSubDepartments = new SqlCommand();

            cmSubDepartments.Connection = scConnection;
            cmSubDepartments.CommandText = String.Format( "INSERT INTO tabDepartments (intDepartment,nvcName, intNumber) VALUES ({0},N'{1}',{2})",
                sdInsertArg.intDepartmnt, sdInsertArg.strName, NextNumber(cnConnection));

            scConnection.Open();
            if (cmSubDepartments.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        private static int NextNumber(Connection cnConnection)
        {
            int intNextCode = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT MAX(intNumber) FROM tabSubDepartments", scConnection);

            scConnection.Open();
            intNextCode = (int)cmStuffStores.ExecuteScalar();

            intNextCode = ++intNextCode;
            scConnection.Close();

            return intNextCode;
        }
        public static bool Update(Connection cnConnection, SubDepartment sdUpadateArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmSubDepartments = new SqlCommand();

            cmSubDepartments.Connection = scConnection;
            cmSubDepartments.CommandText = String.Format("UPDATE tabSubDepartments SET intDepartment={0}, nvcName=N'{1}', intNumber={2}  WHERE intID={3}", 
                sdUpadateArg.intDepartmnt, sdUpadateArg.strName, sdUpadateArg.intNumber, sdUpadateArg.intID);

            scConnection.Open();
            if (cmSubDepartments.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static int GetNumberByName(Connection cnConnection, String strNameArg)
        {
            int intNumberLoc = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmSubDepartment = new SqlCommand();

            cmSubDepartment.Connection = scConnection;
            cmSubDepartment.CommandText = String.Format("SELECT * FROM tabSubDepartmentSubsets WHERE nvcName=N'{0}'", strNameArg);

            scConnection.Open();
            SqlDataReader drSubDepartment = cmSubDepartment.ExecuteReader();

            if (drSubDepartment.Read())
            {
                intNumberLoc = (int)drSubDepartment["intNumber"];
            }

            drSubDepartment.Close();
            scConnection.Close();

            return intNumberLoc;
        }
        public static String GetNameByNumber(Connection cnConnection,int intNumberArg)
        {
            String strNameLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmSubDepartments = new SqlCommand();

            cmSubDepartments.Connection = scConnection;
            cmSubDepartments.CommandText = 
                String.Format("SELECT nvcName FROM tabSubDepartmentSubsets WHERE intNumber={0}", intNumberArg);

            scConnection.Open();
            SqlDataReader drDepartment = cmSubDepartments.ExecuteReader();

            if (drDepartment.Read())
            {
                strNameLoc = drDepartment["nvcName"].ToString();
            }

            drDepartment.Close();
            scConnection.Close();

            return strNameLoc;
        }
    }
}
