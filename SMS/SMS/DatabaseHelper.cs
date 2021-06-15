using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static SMS.Common;

namespace SMS
{
    class DatabaseHelper
    {
        private SqlConnection SqlConnection;
        private SqlDataAdapter SqlDataAdapter;

        private static readonly string DATABASE_NAME = "schoolManagement";

        private static readonly string _tbl_extra = "tbl_extra";
        private static readonly string exId = "exId";
        private static readonly string exKey = "exKey";
        private static readonly string exValue = "exValue";




        private static readonly string _tbl_stu_auth = "tbl_stu_auth";
        private static readonly string stuAuthId = "stuAuthId";
        private static readonly string stuAuthFKstuDetId = "stuAuthFKstuDetId";
        private static readonly string stuAuthUsername = "stuAuthUsername";
        private static readonly string stuAuthPass = "stuAuthPass";

        private static readonly string _tbl_stu_details = "tbl_stu_details";
        private static readonly string stuDetId = "stuDetId";
        private static readonly string stuDetName = "stuDetName";
        private static readonly string stuDetFname = "stuDetFname";
        private static readonly string stuDetAge = "stuDetAge";
        private static readonly string stuDetGender = "stuDetGender";
        private static readonly string stuDetAddress = "stuDetAddress";
        private static readonly string stuDetStuPh = "stuDetStuPh";
        private static readonly string stuDetFatherPh = "stuDetFatherPh";
        private static readonly string stuDetLastClass = "stuDetLastClass";
        private static readonly string stuDetLastSchool = "stuDetLastSchool";




        private static readonly string _tbl_teacher_auth = "tbl_teacher_auth";
        private static readonly string teacherAuthId = "teacherAuthId";
        private static readonly string teacherAuthFKteacherDetId = "teacherAuthFKteacherDetId";
        private static readonly string teacherAuthUsername = "teacherAuthUsername";
        private static readonly string teacherAuthPass = "teacherAuthPass";

        private static readonly string _tbl_teacher_details = "tbl_teacher_details";
        private static readonly string teacherDetId = "teacherDetId";
        private static readonly string teacherDetName = "teacherDetName";
        private static readonly string teacherDetFname = "teacherDetFname";
        private static readonly string teacherDetAge = "teacherDetAge";
        private static readonly string teacherDetGender = "teacherDetGender";
        private static readonly string teacherDetAddress = "teacherDetAddress";
        private static readonly string teacherDetPh = "teacherDetPh";
        private static readonly string teacherDetEmail = "teacherDetEmail";
        private static readonly string teacherDetQualification = "teacherDetQualification";
        private static readonly string teacherDetSubject = "teacherDetSubject";




        private static readonly string _tbl_admin_auth = "tbl_admin_auth";
        private static readonly string adminAuthId = "adminAuthId";
        private static readonly string adminAuthFKstuDetId = "adminAuthFKstuDetId";
        private static readonly string adminAuthUsername = "adminAuthUsername";
        private static readonly string adminAuthPass = "adminAuthPass";

        private static readonly string _tbl_admin_details = "tbl_admin_details";
        private static readonly string adminDetId = "adminDetId";
        private static readonly string adminDetName = "adminDetName";
        private static readonly string adminDetGender = "adminDetGender";
        private static readonly string adminDetAddress = "adminDetAddress";
        private static readonly string adminDetStuPh = "adminDetStuPh";




        private static readonly string _tbl_hr_auth = "tbl_hr_auth";
        private static readonly string hrAuthId = "hrAuthId";
        private static readonly string hrAuthFKstuDetId = "hrAuthFKstuDetId";
        private static readonly string hrAuthUsername = "hrAuthUsername";
        private static readonly string hrAuthPass = "hrAuthPass";

        private static readonly string _tbl_hr_details = "tbl_hr_details";
        private static readonly string hrDetId = "hrDetId";
        private static readonly string hrDetName = "hrDetName";
        private static readonly string hrDetGender = "hrDetGender";
        private static readonly string hrDetAddress = "hrDetAddress";
        private static readonly string hrDetStuPh = "hrDetStuPh";





        private static readonly string _tbl_acc_auth = "tbl_acc_auth";
        private static readonly string accAuthId = "accAuthId";
        private static readonly string accAuthFKstuDetId = "accAuthFKstuDetId";
        private static readonly string accAuthUsername = "accAuthUsername";
        private static readonly string accAuthPass = "accAuthPass";

        private static readonly string _tbl_acc_details = "tbl_acc_details";
        private static readonly string accDetId = "accDetId";
        private static readonly string accDetName = "accDetName";
        private static readonly string accDetGender = "accDetGender";
        private static readonly string accDetAddress = "accDetAddress";
        private static readonly string accDetStuPh = "accDetStuPh";



        private static readonly string _tbl_classes = "tbl_classes";
        private static readonly string classId = "classId";
        private static readonly string className = "className";



        private static readonly string _tbl_sec = "tbl_sec";
        private static readonly string secId = "secId";
        private static readonly string secName = "secName";
        private static readonly string secFkclassId = "secFkclassId";



        private static readonly string _tbl_classBooks = "tbl_classBooks";
        private static readonly string clsBookId = "clsBookId";
        private static readonly string clsBookClsLevel = "clsBookClsLevel";
        private static readonly string clsBookName = "clsBookName";



        private static readonly string _tbl_std_assgin_class = "tbl_std_assgin_class";
        private static readonly string stdAssignClsId = "stdAssignClsId";
        private static readonly string stdAssignClsStdDetId = "stdAssignClsStdDetId";
        private static readonly string stdAssignClsFKSecId = "stdAssignClsFKSecId";
        private static readonly string stdAssignClsDate = "stdAssignClsDate";


        private static readonly string _tbl_stu_fees = "tbl_stu_fees";
        private static readonly string stuFeesId = "stuFeesId";
        private static readonly string stuFeesFKstuDetId = "stuFeesFKstuDetId";
        private static readonly string stuFeesPaidDate = "stuFeesPaidDate";
        private static readonly string stuFeesMonth = "stuFeesMonth";



        private static readonly string _tbl_stu_attendence= "tbl_stu_attendence";
        private static readonly string stuAttenId = "stuAttenId";
        private static readonly string stuAttenFKstuDetId = "stuAttenFKstuDetId";
        private static readonly string stuAttenDate = "stuAttenDate";
        private static readonly string stuAttenStatus = "stuAttenStatus";



        private static readonly string _tbl_teacher_attendence = "tbl_teacher_attendence";
        private static readonly string teacherAttenId = "teacherAttenId";
        private static readonly string teacherAttenFKstuDetId = "teacherAttenFKstuDetId";
        private static readonly string teacherAttenDate = "teacherAttenDate";
        private static readonly string teacherAttenStatus = "teacherAttenStatus";



        private static readonly string _tbl_admin_attendence = "tbl_admin_attendence";
        private static readonly string adminAttenId = "adminAttenId";
        private static readonly string adminAttenFKAdminDetId = "adminAttenFKAdminDetId";
        private static readonly string adminAttenDate = "adminAttenDate";
        private static readonly string adminAttenStatus = "adminAttenStatus";



        private static readonly string _tbl_hr_attendence = "tbl_hr_attendence";
        private static readonly string hrAttenId = "hrAttenId";
        private static readonly string hrAttenFKteacherDetId = "hrAttenFKteacherDetId";
        private static readonly string hrAttenDate = "hrAttenDate";
        private static readonly string hrAttenStatus = "hrAttenStatus";



        private static readonly string _tbl_acc_attendence = "tbl_acc_attendence";
        private static readonly string accAttenId = "accAttenId";
        private static readonly string accAttenFKteacherDetId = "accAttenFKteacherDetId";
        private static readonly string accAttenDate = "accAttenDate";
        private static readonly string accAttenStatus = "accAttenStatus";


        private static readonly string _tbl_teacher_class_assign = "tbl_teacher_class_assign";
        private static readonly string teacherClsAssignId = "teacherClsAssignId";
        private static readonly string teacherClsAssignFKteacherDetId = "teacherClsAssignFKteacherDetId";
        private static readonly string teacherClsAssignFKSecId = "teacherClsAssignFKSecId";

        private static readonly string _tbl_emp_salary = "tbl_emp_salary";
        private static readonly string empSalaryId = "empSalaryId";
        private static readonly string empSalaryFKuserId = "empSalaryFKuserId";
        private static readonly string empSalaryDepType = "empSalaryDepType";
        private static readonly string empSalaryIncentive = "empSalaryIncentive";
        private static readonly string empSalaryBonus = "empSalaryBonus";
        private static readonly string empSalaryGrossPay = "empSalaryGrossPay";
        private static readonly string empSalaryDeduction = "empSalaryDeduction";
        private static readonly string empSalaryMonth = "empSalaryMonth";
        private static readonly string empSalaryDate = "empSalaryDate";

        private static readonly string _tbl_Default_Salary = "tbl_Default_Salary";
        private static readonly string tbl_Default_Salary = "tbl_Default_Salary";
        private static readonly string defaultSalarybasicPay = "defaultSalarybasicPay";
        private static readonly string defaultSalaryIncentive = "defaultSalaryIncentive";
        private static readonly string defaultSalaryTax = "defaultSalaryTax";
        private static readonly string defaultSalaryDepartment = "defaultSalaryDepartment";


        public DatabaseHelper()
        {
            //Zeeshan
            //string connectionString = "Data Source=DESKTOP-IKTLIBO\\SAA;Initial Catalog=" + DATABASE_NAME + ";User ID=sa;Password=123;";
            //for shafqat
            string connectionString = "Data Source=DESKTOP-501T6H6\\SA;Initial Catalog=" + DATABASE_NAME + ";User ID=sa;Password=1234;";
            //for awais
            //string connectionString = "Data Source=.;Initial Catalog=" + DATABASE_NAME + ";User ID=sa;Password=123;";
            SqlConnection = new SqlConnection(connectionString);
        }


        public DataTable GetAttendenceTBL(DepartmentType departmentType,int stdAttFKstdDetId, string stdAttDate)
        {
            switch (departmentType)
            {
                case DepartmentType.STUDENT:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_stu_attendence + " where " + stuAttenFKstuDetId + " = '" + stdAttFKstdDetId + "' and " + stuAttenDate + " like '%" + stdAttDate + "' order by stuAttenDate", SqlConnection);

                    break;
                case DepartmentType.TEACHER:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_teacher_attendence + " where " + teacherAttenFKstuDetId + " = '" + stdAttFKstdDetId + "' and " + teacherAttenDate + " like '%" + stdAttDate + "' order by teacherAttenDate", SqlConnection);

                    break;
                case DepartmentType.ADMIN:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_admin_attendence + " where " + adminAttenFKAdminDetId + " = '" + stdAttFKstdDetId + "' and " + adminAttenDate + " like '%" + stdAttDate + "' order by adminAttenDate", SqlConnection);
                    break;
                case DepartmentType.HR:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_hr_attendence + " where " + hrAttenFKteacherDetId + " = '" + stdAttFKstdDetId + "' and " + hrAttenDate + " like '%" + stdAttDate + "' order by hrAttenDate", SqlConnection);
                    break;
                case DepartmentType.ACCOUNTS:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_acc_attendence + " where " + accAttenFKteacherDetId + " = '" + stdAttFKstdDetId + "' and " + accAttenDate  + " like '%" + stdAttDate + "' order by accAttenDate", SqlConnection);
                    break;
            }
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public bool AddORUpdateAttendence(DepartmentType departmentType, int stdAttendenceFKstuDetId,string stdAttendenceDate, string stdAttendenceStatus )
        {
            bool result;
            try
            {
                DataTable temptable = new DataTable();
                DataTable tbl = new DataTable();
                DataTable tbl1 = new DataTable();

                switch (departmentType)
                {
                    case DepartmentType.ADMIN:
                        SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_admin_attendence + " where " + adminAttenFKAdminDetId + " = '" + stdAttendenceFKstuDetId + "' and " + adminAttenDate + " = '" + stdAttendenceDate + "'", SqlConnection);
                        SqlDataAdapter.Fill(temptable);
                        if (temptable.Rows.Count > 0)
                        {
                            SqlDataAdapter = new SqlDataAdapter("update " + _tbl_admin_attendence + " set " + adminAttenStatus + " = '" + stdAttendenceStatus + "' where " + adminAttenFKAdminDetId + " = '" + stdAttendenceFKstuDetId + "' and " + adminAttenDate + " = '" + stdAttendenceDate + "'", SqlConnection);
                            SqlDataAdapter.Fill(tbl1);
                            result = true;
                        }
                        else
                        {
                            SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_admin_attendence + " values('" + stdAttendenceFKstuDetId + "','" + stdAttendenceDate + "','" + stdAttendenceStatus + "')", SqlConnection);
                            SqlDataAdapter.Fill(tbl);
                            result = true;
                        }
                        break;
                    case DepartmentType.TEACHER:
                        SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_teacher_attendence + " where " + teacherAttenFKstuDetId+ " = '" + stdAttendenceFKstuDetId + "' and " + teacherAttenDate + " = '" + stdAttendenceDate + "'", SqlConnection);
                        SqlDataAdapter.Fill(temptable);
                        if (temptable.Rows.Count > 0)
                        {
                            SqlDataAdapter = new SqlDataAdapter("update " + _tbl_teacher_attendence + " set " + teacherAttenStatus + " = '" + stdAttendenceStatus + "' where " + teacherAttenFKstuDetId+ " = '" + stdAttendenceFKstuDetId + "' and " + teacherAttenDate + " = '" + stdAttendenceDate + "'", SqlConnection);
                            SqlDataAdapter.Fill(tbl1);
                            result = true;
                        }
                        else
                        {
                            SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_teacher_attendence + " values('" + stdAttendenceFKstuDetId + "','" + stdAttendenceDate + "','" + stdAttendenceStatus + "')", SqlConnection);
                            SqlDataAdapter.Fill(tbl);
                            result = true;
                        }
                        break;
                    case DepartmentType.HR:
                        SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_hr_attendence + " where " + hrAttenFKteacherDetId + " = '" + stdAttendenceFKstuDetId + "' and " +hrAttenDate + " = '" + stdAttendenceDate + "'", SqlConnection);
                        SqlDataAdapter.Fill(temptable);
                        if (temptable.Rows.Count > 0)
                        {
                            SqlDataAdapter = new SqlDataAdapter("update " + _tbl_hr_attendence + " set " + hrAttenStatus + " = '" + stdAttendenceStatus + "' where " + hrAttenFKteacherDetId+ " = '" + stdAttendenceFKstuDetId + "' and " + hrAttenDate + " = '" + stdAttendenceDate + "'", SqlConnection);
                            SqlDataAdapter.Fill(tbl1);
                            result = true;
                        }
                        else
                        {
                            SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_hr_attendence + " values('" + stdAttendenceFKstuDetId + "','" + stdAttendenceDate + "','" + stdAttendenceStatus + "')", SqlConnection);
                            SqlDataAdapter.Fill(tbl);
                            result = true;
                        }
                        break;
                    case DepartmentType.ACCOUNTS:
                        SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_acc_attendence + " where " + accAttenFKteacherDetId + " = '" + stdAttendenceFKstuDetId + "' and " + accAttenDate + " = '" + stdAttendenceDate + "'", SqlConnection);
                        SqlDataAdapter.Fill(temptable);
                        if (temptable.Rows.Count > 0)
                        {
                            SqlDataAdapter = new SqlDataAdapter("update " + _tbl_acc_attendence + " set " + accAttenStatus + " = '" + stdAttendenceStatus + "' where " + accAttenFKteacherDetId + " = '" + stdAttendenceFKstuDetId + "' and " + accAttenDate + " = '" + stdAttendenceDate + "'", SqlConnection);
                            SqlDataAdapter.Fill(tbl1);
                            result = true;
                        }
                        else
                        {
                            SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_acc_attendence + " values('" + stdAttendenceFKstuDetId + "','" + stdAttendenceDate + "','" + stdAttendenceStatus + "')", SqlConnection);
                            SqlDataAdapter.Fill(tbl);
                            result = true;
                        }

                        break;
                    case DepartmentType.STUDENT:
                        SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_stu_attendence + " where " + stuAttenFKstuDetId + " = '" + stdAttendenceFKstuDetId + "' and " + stuAttenDate + " = '" + stdAttendenceDate + "'", SqlConnection);
                        SqlDataAdapter.Fill(temptable);
                        if (temptable.Rows.Count > 0)
                        {
                            SqlDataAdapter = new SqlDataAdapter("update " + _tbl_stu_attendence + " set " + stuAttenStatus + " = '" + stdAttendenceStatus + "' where " + stuAttenFKstuDetId + " = '" + stdAttendenceFKstuDetId + "' and " + stuAttenDate + " = '" + stdAttendenceDate + "'", SqlConnection);
                            SqlDataAdapter.Fill(tbl1);
                            result = true;
                        }
                        else
                        {
                            SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_stu_attendence + " values('" + stdAttendenceFKstuDetId + "','" + stdAttendenceDate + "','" + stdAttendenceStatus + "')", SqlConnection);
                            SqlDataAdapter.Fill(tbl);
                            result = true;
                        }
                        break;
                    default:
                        return false;
                }

            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        //Attendence tbl student end

        public void Logout()
        {
            string loginType = Common.LOGINTYPE;
            SqlDataAdapter = new SqlDataAdapter("delete from "+_tbl_extra+" where "+exKey+" = 'LoginType'", SqlConnection);
            SqlDataAdapter SqlDataAdapter1 = new SqlDataAdapter("delete from " + _tbl_extra + " where " + exKey + " = 'FKOFAlreadySignedIn"+loginType+"'", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            SqlDataAdapter1.Fill(tbl);
        }

        public DataTable GetClassesTBL()
        {
            SqlDataAdapter = new SqlDataAdapter("select * from "+_tbl_classes, SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public DataTable GetClassesListAssignedAgainstTeacherTBL(string teacherDetId)
        {
            SqlDataAdapter = new SqlDataAdapter("select classId,className from tbl_teacher_class_assign inner join tbl_sec on tbl_teacher_class_assign.teacherClsAssignFKSecId = tbl_sec.secId inner join tbl_classes on tbl_sec.secFkclassId = tbl_classes.classId where teacherClsAssignFKteacherDetId = "+teacherDetId, SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public bool AddClassName(string clsName)
        {
            bool result;
            try
            {
                DataTable temptable = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_classes + " where " + className + " = '" + clsName + "'", SqlConnection);
                SqlDataAdapter.Fill(temptable);
                if (temptable.Rows.Count > 0)
                {
                    new Alert("Duplicate Class Name", Alert.AlertType.WARNING);
                    return false;
                }
                SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_classes + " values('" + clsName + "')", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                result = true;
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public bool AddOrUpdatestdAssignClass(int stdDetId, int secId, string date)
        {
            bool result;
            try
            {
                DataTable temptable = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_std_assgin_class + " where " + stdAssignClsStdDetId + " = '" + stdDetId + "'", SqlConnection);
                SqlDataAdapter.Fill(temptable);
                if (temptable.Rows.Count > 0)
                {
                    //update std Class
                    SqlDataAdapter = new SqlDataAdapter("update " + _tbl_std_assgin_class + " set " + stdAssignClsFKSecId + " = '" + secId + "', " + stdAssignClsDate + " = '" + date + "' where " + stdAssignClsStdDetId + " = " + stdDetId, SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    result = true;
                }
                else {
                    SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_std_assgin_class + " values('" + stdDetId + "', '" + secId + "', '" + date + "')", SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    result = true;
                }
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public bool AddTeacherAssignClass(int teacherDetId, int secId)
        {
            bool result;
            try
            {
                SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_teacher_class_assign + " values(" + teacherDetId + ", " + secId + ")", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                result = true;
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public bool UpdateTeacherAssignClass(int teacherDetId, int secId)
        {
            bool result;
            try
            {
                SqlDataAdapter = new SqlDataAdapter("update " + _tbl_teacher_class_assign + " set " + teacherClsAssignFKteacherDetId + " = '" + teacherDetId + "' where " + teacherClsAssignFKSecId + " = " + secId , SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                result = true;
            }
            catch (Exception)
            {
                new Alert("Error Occured", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public bool DeleteTeacherAssignClass(int teacherDetId, string secId)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_teacher_class_assign + " where " + teacherClsAssignFKteacherDetId + " = " + teacherDetId + "," + teacherClsAssignFKSecId + " = " + secId, SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                new Alert("Paid Fees Deleted", Alert.AlertType.SUCCESS);
                return true;
            }
            catch (Exception)
            {
                new Alert("Error Occured", Alert.AlertType.ERROR);
                return false;
            }
        }

        public DataTable GetTeacherAssignClassTBL(string secId)
        {
            SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_teacher_class_assign + " where " + teacherClsAssignFKSecId + " = '" + secId + "'", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public DataTable GetStdAssignClsTBL(int stdDetId)
        {
            SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_std_assgin_class + " where " + stdAssignClsStdDetId + " = '" + stdDetId + "'", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public DataTable GetTotalStdsOfSec(int secId)
        {
            SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_std_assgin_class + " where " + stdAssignClsFKSecId + " = '" + secId + "'", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public bool AddOrDeleteStufees(int stdDetId, string date, string Month)
        {
            bool result;
            try
            {
                DataTable temptable = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_stu_fees + " where " + stuFeesFKstuDetId + " = '" + stdDetId + "' and " + stuFeesMonth + " = '" + Month + "'", SqlConnection);
                SqlDataAdapter.Fill(temptable);
                if (temptable.Rows.Count > 0)
                {
                    SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_stu_fees + " where " + stuFeesFKstuDetId + " = " + stdDetId + " and " + stuFeesMonth + " = '" + Month + "'", SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    new Alert("Student Fees UnPaid", Alert.AlertType.WARNING);
                    result = true;
                }
                else
                {
                    //insert std fee Month
                    SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_stu_fees + " values('" + stdDetId + "','" + date + "', '" + Month + "')", SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    new Alert("Student Fees Paid", Alert.AlertType.SUCCESS);
                    result = true;
                }
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public DataTable GetStdFeesTBL(int stdDetId, string Month)
        {
            SqlDataAdapter = new SqlDataAdapter("select stuDetName,stuFeesPaidDate from tbl_stu_fees full outer join tbl_stu_details on tbl_stu_fees.stuFeesFKstuDetId = tbl_stu_details.stuDetId where " + stuFeesFKstuDetId + " = '" + stdDetId + "' and " + stuFeesMonth + " like '%" + Month + "%'", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }


        public void UpdateClassName(int id , string clsName)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("update " + _tbl_classes + " set "+className+" = '"+clsName+"' where "+classId+" = "+id, SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
            }
            catch (Exception)
            {
                new Alert("Error Occured", Alert.AlertType.ERROR);
            }
        }

        public void DeleteClassName(int id)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_classes + " where " + classId + " = " + id, SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                new Alert("Class Name Deleted", Alert.AlertType.SUCCESS);
            }
            catch (Exception)
            {
                new Alert("Error Occured", Alert.AlertType.ERROR);
            }
        }

        public DataTable GetSectionsWithClassNameTBL()
        {
            SqlDataAdapter = new SqlDataAdapter("select secId,secName,className from tbl_sec inner join tbl_classes on tbl_sec.secFkclassId = tbl_classes.classId", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public DataTable GetSectionsTBL(int clsId)
        {
            SqlDataAdapter = new SqlDataAdapter("select * from tbl_sec where secFkclassId = "+clsId, SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public DataTable GetSectionsTBL(int teacherDetId,int clsId)
        {
            SqlDataAdapter = new SqlDataAdapter("select secId,secName,secFkclassId from tbl_sec inner join tbl_teacher_class_assign on tbl_sec.secId = tbl_teacher_class_assign.teacherClsAssignFKSecId where secFkclassId = "+ clsId + " and teacherClsAssignFKteacherDetId = "+teacherDetId, SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        //Add Sections
        public bool AddSectionName(int classId,string sectionName)
        {
            bool result;
            try
            {
                DataTable temptable = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_sec + " where " + secName + " = '" + sectionName + "' and "+secFkclassId+" = "+classId, SqlConnection);
                SqlDataAdapter.Fill(temptable);
                if (temptable.Rows.Count > 0)
                {
                    new Alert("Duplicate Section Name", Alert.AlertType.WARNING);
                    return false;
                }
                SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_sec + " values('" + sectionName + "'," + classId + ")", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                result = true;
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }
        //Add Sec End

        //Update Section
        public void UpdateSectionName(int id, string sectionName)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("update " + _tbl_sec + " set " + secName + " = '" + sectionName + "' where " + secId + " = " + id, SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
            }
            catch (Exception)
            {
                new Alert("Error Occured", Alert.AlertType.ERROR);
            }
        }
        //Update Sec End

        //Delete Section
        public void DeleteSectionName(int id)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_sec + " where " + secId + " = " + id, SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                new Alert("Section Name Deleted", Alert.AlertType.SUCCESS);
            }
            catch (Exception)
            {
                new Alert("Error Occured", Alert.AlertType.ERROR);
            }
        }
        //Delete Sec End

        public DataTable GetSubjectsTBL(int clsId)
        {
            SqlDataAdapter = new SqlDataAdapter("select * from tbl_classBooks where clsBookClsLevel = " + clsId, SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        //Add Subject
        public bool AddSubjectName(int classFk,string subjectName)
        {
            bool result;
            try
            {
                DataTable temptable = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_classBooks + " where " + clsBookName + " = '" + subjectName + "' and " + clsBookClsLevel + " = " + classFk, SqlConnection);
                SqlDataAdapter.Fill(temptable);
                if (temptable.Rows.Count > 0)
                {
                    new Alert("Duplicate Subject Name", Alert.AlertType.WARNING);
                    return false;
                }
                SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_classBooks + " values('" + classFk + "','" + subjectName + "')", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                result = true;
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }
        //Add Sub End

        //Update Subjects 
        public void UpdateSubjectName(int id, string subjectName)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("update " + _tbl_classBooks + " set " + clsBookName + " = '" + subjectName + "' where " + clsBookId + " = " + id, SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
            }
            catch (Exception)
            {
                new Alert("Error Occured", Alert.AlertType.ERROR);
            }
        }
        //Update Sub End

        //Delete Subject 
        public void DeleteSubjectName(int id)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_classBooks + " where " + clsBookId + " = " + id, SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                new Alert("Section Subject Deleted", Alert.AlertType.SUCCESS);
            }
            catch (Exception)
            {
                new Alert("Error Occured", Alert.AlertType.ERROR);
            }
        }
        // Delete Subject

        public DataTable GetAllDepartmentDetailsAndAuth(Common.DepartmentType departmentType)
        {
            switch (departmentType)
            {
                case Common.DepartmentType.STUDENT:
                    SqlDataAdapter = new SqlDataAdapter("select stuDetId,stuDetName,stuDetFname,stuDetAge,stuDetGender,stuDetAddress,stuDetStuPh,stuDetFatherPh,stuDetLastClass,stuDetLastSchool,stuAuthUsername,stuAuthPass from tbl_stu_details inner join tbl_stu_auth ON tbl_stu_details.stuDetId = tbl_stu_auth.stuAuthFKstuDetId", SqlConnection);
                    break;
                case Common.DepartmentType.TEACHER:
                    SqlDataAdapter = new SqlDataAdapter("select teacherDetId,teacherDetName,teacherDetFname,teacherDetAge,teacherDetGender,teacherDetAddress,teacherDetPh,teacherDetEmail,teacherDetQualification,teacherDetSubject,teacherAuthUsername,teacherAuthPass from tbl_teacher_details inner join tbl_teacher_auth ON tbl_teacher_details.teacherDetId = tbl_teacher_auth.teacherAuthFKteacherDetId", SqlConnection);
                    break;
                case Common.DepartmentType.ACCOUNTS:
                    SqlDataAdapter = new SqlDataAdapter("select accDetId,accDetName,accDetGender,accDetAddress,accDetStuPh,accAuthUsername,accAuthPass from tbl_acc_details inner join tbl_acc_auth ON tbl_acc_details.accDetId = tbl_acc_auth.accAuthFKstuDetId", SqlConnection);
                    break;
                case Common.DepartmentType.HR:
                    SqlDataAdapter = new SqlDataAdapter("select hrDetId,hrDetName,hrDetGender,hrDetAddress,hrDetStuPh,hrAuthUsername,hrAuthPass from tbl_hr_details inner join tbl_hr_auth ON tbl_hr_details.hrDetId = tbl_hr_auth.hrAuthFKstuDetId", SqlConnection);
                    break;
                case Common.DepartmentType.ADMIN:
                    SqlDataAdapter = new SqlDataAdapter("select adminDetId,adminDetName,adminDetGender,adminDetAddress,adminDetStuPh,adminAuthUsername,adminAuthPass from tbl_admin_details inner join tbl_admin_auth ON tbl_admin_details.adminDetId = tbl_admin_auth.adminAuthFKstuDetId", SqlConnection);
                    break;
            }
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public DataTable GetAllDepartmentDetailsAndAuth(Common.DepartmentType departmentType,string searchTerm)
        {
            int searchTermInt = Convert.ToInt32(Regex.Match(searchTerm, @"\d+").Value);

            switch (departmentType)
            {
                case Common.DepartmentType.STUDENT:
                    SqlDataAdapter = new SqlDataAdapter("select stuDetId,stuDetName,stuDetFname,stuDetAge,stuDetGender,stuDetAddress,stuDetStuPh,stuDetFatherPh,stuDetLastClass,stuDetLastSchool,stuAuthUsername,stuAuthPass from tbl_stu_details inner join tbl_stu_auth ON tbl_stu_details.stuDetId = tbl_stu_auth.stuAuthFKstuDetId where stuDetId = 'searchTermInt' or stuDetName like 'searchTerm%' or stuDetAge like 'searchTerm%' or stuDetGender like 'searchTerm%' or stuDetAddress like 'searchTerm%' or stuDetLastClass like 'searchTerm%' or stuAuthUsername like 'awais%'", SqlConnection);
                    break;
                case Common.DepartmentType.TEACHER:
                    SqlDataAdapter = new SqlDataAdapter("select teacherDetId,teacherDetName,teacherDetFname,teacherDetAge,teacherDetGender,teacherDetAddress,teacherDetPh,teacherDetEmail,teacherDetQualification,teacherDetSubject,teacherAuthUsername,teacherAuthPass from tbl_teacher_details inner join tbl_teacher_auth ON tbl_teacher_details.teacherDetId = tbl_teacher_auth.teacherAuthFKteacherDetId where teacherDetId ='searchTermInt' or teacherDetName like 'searchTerm%' or teacherDetAge like 'searchTerm%' or teacherDetGender like 'searchTerm%' or teacherDetAddress like 'searchTerm%' or teacherDetQualification like 'searchTerm%' or teacherDetSubject like 'searchTerm%' or teacherAuthUsername like 'searchTerm%'", SqlConnection);
                    break;
                case Common.DepartmentType.ACCOUNTS:
                    SqlDataAdapter = new SqlDataAdapter("select accDetId,accDetName,accDetGender,accDetAddress,accDetStuPh,accAuthUsername,accAuthPass from tbl_acc_details inner join tbl_acc_auth ON tbl_acc_details.accDetId = tbl_acc_auth.accAuthFKstuDetId where accDetId = 'searchTermInt' or accDetName like 'searchTerm%' or accDetGender like 'searchTerm%' or accDetAddress like 'searchTerm%' or accAuthUsername like 'searchTerm%'", SqlConnection);
                    break;
                case Common.DepartmentType.HR:
                    SqlDataAdapter = new SqlDataAdapter("select hrDetId,hrDetName,hrDetGender,hrDetAddress,hrDetStuPh,hrAuthUsername,hrAuthPass from tbl_hr_details inner join tbl_hr_auth ON tbl_hr_details.hrDetId = tbl_hr_auth.hrAuthFKstuDetId where hrDetId = 'searchTermInt' or hrDetName like 'searchTerm%' or hrDetGender like 'searchTerm%' or hrDetAddress like 'searchTerm%' or hrAuthUsername like 'searchTerm%'", SqlConnection);
                    break;
                case Common.DepartmentType.ADMIN:
                    SqlDataAdapter = new SqlDataAdapter("select adminDetId,adminDetName,adminDetGender,adminDetAddress,adminDetStuPh,adminAuthUsername,adminAuthPass from tbl_admin_details inner join tbl_admin_auth ON tbl_admin_details.adminDetId = tbl_admin_auth.adminAuthFKstuDetId where adminDetId ='searchTermInt' or adminDetName like 'searchTerm%'  or adminDetGender like 'searchTerm%' or adminDetAddress like 'searchTerm%' or adminAuthUsername like 'searchTerm%'", SqlConnection);
                    break;
            }
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public DataTable GetTBLDetailsAllDepartments(Common.DepartmentType departmentType,int fk)
        {
            switch (departmentType)
            {
                case Common.DepartmentType.ACCOUNTS:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_acc_details + " where " + accDetId + " = '" + fk + "'", SqlConnection);
                    break;
                case Common.DepartmentType.ADMIN:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_admin_details + " where " + adminDetId + " = '" + fk + "'", SqlConnection);
                    break;
                case Common.DepartmentType.HR:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_hr_details + " where " + hrDetId + " = '" + fk + "'", SqlConnection);
                    break;
                case Common.DepartmentType.STUDENT:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_stu_details + " where " + stuDetId + " = '" + fk + "'", SqlConnection);
                    break;
                case Common.DepartmentType.TEACHER:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_teacher_details + " where " + teacherDetId + " = '" + fk + "'", SqlConnection);
                    break;
            }
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public DataTable GetTBLDetailsAllDepartments(Common.DepartmentType departmentType)
        {
            switch (departmentType)
            {
                case Common.DepartmentType.ACCOUNTS:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_acc_details, SqlConnection);
                    break;
                case Common.DepartmentType.ADMIN:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_admin_details, SqlConnection);
                    break;
                case Common.DepartmentType.HR:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_hr_details, SqlConnection);
                    break;
                case Common.DepartmentType.STUDENT:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_stu_details, SqlConnection);
                    break;
                case Common.DepartmentType.TEACHER:
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_teacher_details, SqlConnection);
                    break;
            }
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public DataTable GetSingleStdDetailsAndAuth(string stdDetId)
        {
            SqlDataAdapter = new SqlDataAdapter("select stuDetId,stuDetName,stuDetFname,stuDetAge,stuDetGender,stuDetAddress,stuDetStuPh,stuDetFatherPh,stuDetLastClass,stuDetLastSchool,stuAuthUsername,stuAuthPass from tbl_stu_details inner join tbl_stu_auth ON tbl_stu_details.stuDetId = tbl_stu_auth.stuAuthFKstuDetId where stuDetId = '" + stdDetId + "'", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public string Login(string email, string pass,string loginType)
        {
            switch (loginType)
            {
                case "Student":
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_stu_auth + " where " + stuAuthUsername + " = '" + email + "' and " + stuAuthPass + " = '" + pass + "'", SqlConnection);
                    break;
                case "Administrator":
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_admin_auth + " where " + adminAuthUsername + " = '" + email + "' and " + adminAuthPass + " = '" + pass + "'", SqlConnection);
                    break;
                case "Teacher":
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_teacher_auth + " where " + teacherAuthUsername + " = '" + email + "' and " + teacherAuthPass + " = '" + pass + "'", SqlConnection);
                    break;
                case "Accounts":
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_acc_auth + " where " + accAuthUsername + " = '" + email + "' and " + accAuthPass + " = '" + pass + "'", SqlConnection);
                    break;
                case "Admission":
                    SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_hr_auth + " where " + hrAuthUsername + " = '" + email + "' and " + hrAuthPass + " = '" + pass + "'", SqlConnection);
                    break;
            }

            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            bool isLogin = (tbl.Rows.Count > 0);
            if (isLogin)
            {
                //get the fk of user
                return tbl.Rows[0][1].ToString();
            }
            else {
                return "NotValid";
            }
        }

        public string CheckLogin() {
            SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_extra + " where " + exKey + " = 'LoginType'", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            if (tbl.Rows.Count > 0) {
                return tbl.Rows[0][2].ToString();
            }
            else {
                return "NeedLogin";
            }
        }

        public int GetFKOfAlreadySignedInUser(string userType) {
            SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_extra + " where " + exKey + " = '"+userType+"'", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            if (tbl.Rows.Count > 0)
            {
                return Convert.ToInt32(tbl.Rows[0][2].ToString());
            }
            else {
                return 0;
            }
        }

        public void saveLoginState(string logType,int userFk) {
            SqlDataAdapter = new SqlDataAdapter("insert into "+_tbl_extra+ " values ('LoginType','"+logType+"')", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);

            SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_extra + " values ('FKOFAlreadySignedIn"+ logType + "','" + userFk + "')", SqlConnection);
            DataTable tbl1 = new DataTable();
            SqlDataAdapter.Fill(tbl1);
        }

        public bool RegisterUser(Common.DepartmentType departmentType,string v1,string v2,string v3,string v4,string v5,string v6,string v7,string v8,string v9, string v10, string v11)
        {
            bool result;
            try
            {

                DataTable temptable = new DataTable();

                switch (departmentType)
                {
                    case Common.DepartmentType.STUDENT:
                        SqlDataAdapter = new SqlDataAdapter("select * from "+_tbl_stu_auth+" where "+stuAuthUsername+" = '"+v10+"'", SqlConnection);
                        SqlDataAdapter.Fill(temptable);
                        if(temptable.Rows.Count > 0)
                        {
                            new Alert("Duplicate Username or Email", Alert.AlertType.WARNING);
                            return false;
                        }
                        SqlDataAdapter = new SqlDataAdapter("insert into "+_tbl_stu_details+ " output inserted."+stuDetId+" values('" + v1+"','"+v2+"','"+v3+"','"+v4+"','"+v5+"','"+v6+"','"+v7+"','"+v8+"','"+v9+"')", SqlConnection);
                        break;
                    case Common.DepartmentType.ADMIN:
                        SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_admin_auth + " where " + adminAuthUsername + " = '" + v10+"'", SqlConnection);
                        SqlDataAdapter.Fill(temptable);
                        if (temptable.Rows.Count > 0)
                        {
                            new Alert("Duplicate Username or Email", Alert.AlertType.WARNING);
                            return false;
                        }
                        SqlDataAdapter = new SqlDataAdapter("insert into " +_tbl_admin_details+ " output inserted." + adminDetId + " values('" +v1+ "','" +v2+ "','" + v3 + "','" + v4 + "')", SqlConnection);
                        break;
                    case Common.DepartmentType.TEACHER:
                        SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_teacher_auth + " where " + teacherAuthUsername + " = '" + v10+"'", SqlConnection);
                        SqlDataAdapter.Fill(temptable);
                        if (temptable.Rows.Count > 0)
                        {
                            new Alert("Duplicate Username or Email", Alert.AlertType.WARNING);
                            return false;
                        }
                        SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_teacher_details + " output inserted." + teacherDetId + " values('" + v1 + "','" + v2 + "','" + v3 + "','" + v4 + "','" + v5 + "','" + v6 + "','" + v7 + "','" + v8 + "','" + v9 + "')", SqlConnection);
                        break;
                    case Common.DepartmentType.ACCOUNTS:
                        SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_acc_auth + " where " + accAuthUsername + " = '" + v10+"'", SqlConnection);
                        SqlDataAdapter.Fill(temptable);
                        if (temptable.Rows.Count > 0)
                        {
                            new Alert("Duplicate Username or Email", Alert.AlertType.WARNING);
                            return false;
                        }
                        SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_acc_details + " output inserted." + accDetId + " values('" + v1 + "','" + v2 + "','" + v3 + "','" + v4 + "')", SqlConnection);
                        break;
                    case Common.DepartmentType.HR:
                        SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_hr_auth + " where " + hrAuthUsername + " = '" + v10+ "'", SqlConnection);
                        SqlDataAdapter.Fill(temptable);
                        if (temptable.Rows.Count > 0)
                        {
                            new Alert("Duplicate Username or Email", Alert.AlertType.WARNING);
                            return false;
                        }
                        SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_hr_details + " output inserted." + hrDetId + " values('" + v1 + "','" + v2 + "','" + v3 + "','" + v4 + "')", SqlConnection);
                        break;
                }
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                int id = Convert.ToInt32(tbl.Rows[0][0].ToString());

                switch (departmentType)
                {
                    case Common.DepartmentType.STUDENT:
                        SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_stu_auth + " values('" + id + "','" + v10 + "','" + v11 + "')", SqlConnection);
                        break;
                    case Common.DepartmentType.ADMIN:
                        SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_admin_auth + " values('" + id + "','" + v10 + "','" + v11 + "')", SqlConnection);
                        break;
                    case Common.DepartmentType.TEACHER:
                        SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_teacher_auth + " values('" + id + "','" + v10 + "','" + v11 + "')", SqlConnection);
                        break;
                    case Common.DepartmentType.ACCOUNTS:
                        SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_acc_auth + " values('" + id + "','" + v10 + "','" + v11 + "')", SqlConnection);
                        break;
                    case Common.DepartmentType.HR:
                        SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_hr_auth + " values('" + id + "','" + v10 + "','" + v11 + "')", SqlConnection);
                        break;
                }
                DataTable tbl1 = new DataTable();
                SqlDataAdapter.Fill(tbl1);

                new Alert("Successfullay Added", Alert.AlertType.SUCCESS);
                result = true;
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public bool UpdateUser(Common.DepartmentType departmentType,int key, string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v10, string v11,bool showAlerts)
        {
            SqlDataAdapter SqlDataAdapterForUpdate;
            bool result;
            try
            {
                switch (departmentType)
                {
                    case Common.DepartmentType.STUDENT:
                        SqlDataAdapter = new SqlDataAdapter("update " + _tbl_stu_details + " set "+stuDetName+" = '"+v1+ "' , " + stuDetFname + " = '" + v2 + "' , " + stuDetAge + " = '" + v3 + "' , " + stuDetGender + " = '" + v4 + "' , " + stuDetAddress + " = '" + v5 + "' , " + stuDetStuPh + " = '" + v6 + "' , " + stuDetFatherPh + " = '" + v7 + "' , " + stuDetLastClass + " = '" + v8 + "' , " + stuDetLastSchool + " = '" + v9 + "' where "+stuDetId+" = " + key, SqlConnection);
                        SqlDataAdapterForUpdate = new SqlDataAdapter("update "+_tbl_stu_auth+" set "+stuAuthUsername+" = '"+v10+"' , "+stuAuthPass+" = '"+v11+"' where "+stuAuthFKstuDetId+" = "+key+" ", SqlConnection);
                        break;
                    case Common.DepartmentType.ADMIN:
                        SqlDataAdapter = new SqlDataAdapter("update " + _tbl_admin_details + " set "+adminDetName+" = '"+v1+ "' , " + adminDetGender + " = '" + v2 + "' , " + adminDetAddress + " = '" + v3 + "' , " + adminDetStuPh + " = '" + v4 +"' where "+adminDetId+" = " + key, SqlConnection);
                        SqlDataAdapterForUpdate = new SqlDataAdapter("update " + _tbl_admin_auth + " set " + adminAuthUsername + " = '" + v10 + "' , " + adminAuthPass + " = '" + v11 + "' where " + adminAuthFKstuDetId + " = " + key + " ", SqlConnection);
                        break;
                    case Common.DepartmentType.TEACHER:
                        SqlDataAdapter = new SqlDataAdapter("update " + _tbl_teacher_details + " set "+teacherDetName+" = '"+v1+ "' , " + teacherDetFname + " = '" + v2 + "' , " + teacherDetAge + " = '" + v3 + "' , " + teacherDetGender+ " = '" + v4 + "' , " + teacherDetAddress + " = '" + v5 + "' , " + teacherDetPh + " = '" + v6 + "' , " + teacherDetEmail + " = '" + v7 + "' , " + teacherDetQualification + " = '" + v8 + "' , " + teacherDetSubject + " = '" + v9 + "' where "+teacherDetId+" = " + key, SqlConnection);
                        SqlDataAdapterForUpdate = new SqlDataAdapter("update " + _tbl_teacher_auth + " set " + teacherAuthUsername + " = '" + v10 + "' , " + teacherAuthPass + " = '" + v11 + "' where " + teacherAuthFKteacherDetId + " = " + key + " ", SqlConnection);
                        break;
                    case Common.DepartmentType.ACCOUNTS:
                        SqlDataAdapter = new SqlDataAdapter("update " + _tbl_acc_details + " set "+accDetName+" = '"+v1+ "' , " + accDetGender + " = '" + v2 + "' , " +accDetAddress+ " = '" + v3 + "' , " + accDetStuPh+ " = '" + v4 +"' where "+accDetId+" = " + key, SqlConnection);
                        SqlDataAdapterForUpdate = new SqlDataAdapter("update " + _tbl_acc_auth + " set " + accAuthUsername + " = '" + v10 + "' , " + accAuthPass + " = '" + v11 + "' where " + accAuthFKstuDetId + " = " + key + " ", SqlConnection);
                        break;
                    case Common.DepartmentType.HR:
                        SqlDataAdapter = new SqlDataAdapter("update " + _tbl_hr_details + " set "+hrDetName+" = '"+v1+ "' , " + hrDetGender+ " = '" + v2 + "' , " +hrDetAddress+ " = '" + v3 + "' , " +hrDetStuPh+ " = '" + v4 +"' where "+hrDetId+" = " + key, SqlConnection);
                        SqlDataAdapterForUpdate = new SqlDataAdapter("update " + _tbl_hr_auth + " set " + hrAuthUsername + " = '" + v10 + "' , " + hrAuthPass + " = '" + v11 + "' where " + hrAuthFKstuDetId + " = " + key + " ", SqlConnection);
                        break;
                    default:
                        SqlDataAdapterForUpdate = new SqlDataAdapter("", SqlConnection);
                        break;
                }
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                DataTable tbl1 = new DataTable();
                SqlDataAdapterForUpdate.Fill(tbl1);

                if (showAlerts){new Alert("Successfullay Updated", Alert.AlertType.SUCCESS);}
                result = true;
            }
            catch (Exception)
            {
                if (showAlerts) { new Alert("Some Error Occurred", Alert.AlertType.ERROR); }
                result = false;
            }
            return result;
        }

        public bool DeleteAuth(DepartmentType departmentType, string detId)
        {
            try
            {
                switch (departmentType)
                {
                    case DepartmentType.ADMIN:
                        SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_admin_auth + " where " + adminAuthFKstuDetId + " = " + detId, SqlConnection);
                        break;
                    case DepartmentType.TEACHER:
                        SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_teacher_auth + " where " + teacherAuthFKteacherDetId + " = " + detId, SqlConnection);
                        break;
                    case DepartmentType.HR:
                        SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_hr_auth + " where " + hrAuthFKstuDetId + " = " + detId, SqlConnection);
                        break;
                    case DepartmentType.ACCOUNTS:
                        SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_acc_auth + " where " + accAuthFKstuDetId + " = " + detId, SqlConnection);
                        break;
                    case DepartmentType.STUDENT:
                        SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_stu_auth + " where " + stuAuthFKstuDetId + " = " + detId, SqlConnection);
                        break;
                }

                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UnsignStdClass(string stdDetId)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_std_assgin_class + " where " + stdAssignClsStdDetId + " = " + stdDetId, SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteUser(Common.DepartmentType departmentType, int key, bool showAlerts)
        {
            SqlDataAdapter SqlDataAdapterForDelete;
            bool result;
            try
            {
                switch (departmentType)
                {
                    case Common.DepartmentType.STUDENT:
                        SqlDataAdapter = new SqlDataAdapter("delete from "+_tbl_stu_details+" where "+stuDetId+" = "+key, SqlConnection);
                        SqlDataAdapterForDelete = new SqlDataAdapter("delete from " + _tbl_stu_auth + " where " + stuAuthFKstuDetId + " = " + key, SqlConnection);
                        break;
                    case Common.DepartmentType.ADMIN:
                        SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_admin_details + " where " + adminDetId + " = " + key, SqlConnection);
                        SqlDataAdapterForDelete = new SqlDataAdapter("delete from " + _tbl_admin_auth + " where " + adminAuthFKstuDetId + " = " + key, SqlConnection);
                        break;
                    case Common.DepartmentType.TEACHER:
                        SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_teacher_details + " where " + teacherDetId + " = " + key, SqlConnection);
                        SqlDataAdapterForDelete = new SqlDataAdapter("delete from " + _tbl_teacher_auth + " where " + teacherAuthFKteacherDetId + " = " + key, SqlConnection);
                        break;
                    case Common.DepartmentType.ACCOUNTS:
                        SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_acc_details + " where " + accDetId + " = " + key, SqlConnection);
                        SqlDataAdapterForDelete = new SqlDataAdapter("delete from " + _tbl_acc_auth + " where " + accAuthFKstuDetId + " = " + key, SqlConnection);
                        break;
                    case Common.DepartmentType.HR:
                        SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_hr_details + " where " + hrDetId + " = " + key, SqlConnection);
                        SqlDataAdapterForDelete = new SqlDataAdapter("delete from " + _tbl_hr_auth + " where " + hrAuthFKstuDetId + " = " + key, SqlConnection);
                        break;
                    default:
                        SqlDataAdapterForDelete = new SqlDataAdapter("", SqlConnection);
                        break;
                }
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                DataTable tbl1 = new DataTable();
                SqlDataAdapterForDelete.Fill(tbl1);

                if (showAlerts) { new Alert("Successfullay Deleted", Alert.AlertType.SUCCESS); }
                result = true;
            }
            catch (Exception)
            {
                if (showAlerts) { new Alert("Some Error Occurred", Alert.AlertType.ERROR); }
                result = false;
            }
            return result;
        }

        public DataTable GetAllUserPswd(Common.DepartmentType departmentType, string stdDetId)
        {
            switch (departmentType)
            {
                case Common.DepartmentType.STUDENT:
                    SqlDataAdapter = new SqlDataAdapter("select stuAuthPass from tbl_stu_auth where stuAuthFKstuDetId ='" + stdDetId + "'", SqlConnection);
                    break;
                case Common.DepartmentType.ADMIN:
                    SqlDataAdapter = new SqlDataAdapter("select adminAuthPass from tbl_admin_auth where adminAuthFKstuDetId ='" + stdDetId + "'", SqlConnection);
                    break;
                case Common.DepartmentType.TEACHER:
                    SqlDataAdapter = new SqlDataAdapter("select teacherAuthPass from tbl_teacher_auth where teacherAuthFKteacherDetId ='" + stdDetId + "'", SqlConnection);
                    break;
                case Common.DepartmentType.ACCOUNTS:
                    SqlDataAdapter = new SqlDataAdapter("select accAuthPass from tbl_acc_auth where accAuthFKstuDetId ='" + stdDetId + "'", SqlConnection);
                    break;
                case Common.DepartmentType.HR:
                    SqlDataAdapter = new SqlDataAdapter("select hrAuthPass from tbl_hr_auth where hrAuthFKstuDetId ='" + stdDetId + "'", SqlConnection);
                    break;
            }

           
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public bool UpdatePassword(Common.DepartmentType departmentType,string stdDetId,string newPass)
        {
            SqlDataAdapter SqlDataAdapterForUpdate;
            bool result;
            try
            {
                switch (departmentType)
                {
                    case Common.DepartmentType.STUDENT:
                        SqlDataAdapter = new SqlDataAdapter("update " + _tbl_stu_auth + " set " + stuAuthPass + " = '" + newPass + "' where " + stuAuthFKstuDetId + " = " + stdDetId, SqlConnection);
                    
                        break;
                    case Common.DepartmentType.ADMIN:
                        SqlDataAdapter = new SqlDataAdapter("update " + _tbl_admin_auth + " set " + adminAuthPass + " = '" + newPass + "' where " + adminAuthFKstuDetId + " = " + stdDetId, SqlConnection);

                        break;
                    case Common.DepartmentType.TEACHER:
                        SqlDataAdapter = new SqlDataAdapter("update " + _tbl_teacher_auth + " set " + teacherAuthPass + " = '" + newPass + "' where " + teacherAuthFKteacherDetId + " = " + stdDetId, SqlConnection);

                        break;
                    case Common.DepartmentType.ACCOUNTS:
                        SqlDataAdapter = new SqlDataAdapter("update " + _tbl_acc_auth + " set " + accAuthPass + " = '" + newPass + "' where " + accAuthFKstuDetId + " = " + stdDetId, SqlConnection);

                        break;
                    case Common.DepartmentType.HR:
                        SqlDataAdapter = new SqlDataAdapter("update " + _tbl_hr_auth + " set " + hrAuthPass + " = '" + newPass + "' where " + hrAuthFKstuDetId + " = " + stdDetId, SqlConnection);

                        break;
                }
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
           
                result = true;
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR); 
                result = false;
            }
            return result;
        }

        public DataTable GetLeaveStdTBL()
        {
            SqlDataAdapter = new SqlDataAdapter("select stdLeaveRecFKstdDetId, stuDetName, stuDetFname, stuDetGender, stuDetStuPh, stdLeaveRecLastClassStudied, stdLeaveRecLeaveStatus, stdLeaveRecAcademicResult, stdLeaveRecPercenage from tbl_std_leave_record inner join tbl_stu_details on tbl_std_leave_record.stdLeaveRecFKstdDetId = tbl_stu_details.stuDetId", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public bool AddLeaveStd(string stdDetId, string leaveStatus, string lastClassStudied, string passOutyear, string resultPer)
        {
            bool result;
            try
            {
                SqlDataAdapter = new SqlDataAdapter("insert into tbl_std_leave_record values('"+stdDetId+"', '"+leaveStatus+"','"+lastClassStudied+"', '"+passOutyear+"', '"+resultPer+"')", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                result = true;
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public DataTable GetExEmpDetTBL()
        {
            SqlDataAdapter = new SqlDataAdapter("select * from tbl_ex_emp_det", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        public bool AddExEmpDetTBL(string userDetId, string exEmptName, string exEmpGender, string exEmpDeptName, string exEmpLeaveDate)
        {
            bool result;
            try
            {
                SqlDataAdapter = new SqlDataAdapter("insert into tbl_ex_emp_det values('" + userDetId + "', '" + exEmptName + "','" + exEmpGender + "', '" + exEmpDeptName + "', '" + exEmpLeaveDate + "')", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                result = true;
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public string GetSingleStdClass(string stdDetId)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("select className from tbl_classes inner join tbl_sec on tbl_classes.classId = tbl_sec.secFkclassId inner join tbl_std_assgin_class on tbl_std_assgin_class.stdAssignClsFKSecId = tbl_sec.secId where tbl_std_assgin_class.stdAssignClsStdDetId = '" + stdDetId + "'", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                return tbl.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetAttClassWiseReportTBL(string date, string clsName, string secName)
        {
            try {
                SqlDataAdapter = new SqlDataAdapter("select stuAttenFKstuDetId, stuDetName, stuAttenStatus from tbl_stu_attendence inner join tbl_stu_details on tbl_stu_attendence.stuAttenFKstuDetId = tbl_stu_details.stuDetId inner join tbl_std_assgin_class on tbl_std_assgin_class.stdAssignClsStdDetId = tbl_stu_attendence.stuAttenFKstuDetId inner join tbl_sec on tbl_sec.secId = tbl_std_assgin_class.stdAssignClsFKSecId inner join tbl_classes on tbl_classes.classId = tbl_sec.secFkclassId where stuAttenDate = '" + date + "' and className = '" + clsName + "' and secName = '" + secName + "'", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                return tbl;
            }
            catch (Exception) {
                return null;
            }
        }

        public bool AddExp(string expName,string expDec, string expChrg, string expProfitLose, string expDate)
        {
            bool result;
            try
            {
                SqlDataAdapter = new SqlDataAdapter("insert into tbl_expenditures values('" + expName + "','" + expDec + "','" + expChrg + "','" + expProfitLose + "','" + expDate + "')", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                result = true;
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public bool UpdateExp(string expName, string expDec, string expChrg, string expProfitLose, string expDate, string tblId)
        {
            bool result;
            try
            {
                SqlDataAdapter = new SqlDataAdapter("update tbl_expenditures set expendituresName = '" + expName + "', expendituresDescribtion = '" + expDec + "', expendituresChareges = '" + expChrg + "', expendituresProfitLose = '" + expProfitLose + "', expendituresDate = '" + expDate + "' where expendituresId = '"+tblId+"'", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                result = true;
            }
            catch (Exception)
            {
                new Alert("Error Occured", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public bool DeleteExp(string tblId)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("delete from tbl_expenditures where expendituresId = '" + tblId + "')", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                new Alert("Paid Fees Deleted", Alert.AlertType.SUCCESS);
                return true;
            }
            catch (Exception)
            {
                new Alert("Error Occured", Alert.AlertType.ERROR);
                return false;
            }
        }

        public DataTable GetExp()
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("select * from tbl_expenditures", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                return tbl;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetEmpSalaryMonthly(string empDetId, string empDepType, string month)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_emp_salary + " where " + empSalaryFKuserId + " = '" + empDetId + "' and " + empSalaryDepType + " = '" + empDepType + "' and " + empSalaryMonth + " = '" + month + "'", SqlConnection);
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        //Add or delete Salary
        public bool AddOrDeleteEmpSalary(int empDetId, string empName, string empDepType, string empIncentive, string empBonus, string empGross, string empSalDeduction, string empNetPay, string month, string date)
        {
            bool result;
            try
            {
                DataTable temptable = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_emp_salary + " where " + empSalaryFKuserId + " = '" + empDetId + "' and " + empSalaryDepType + " = '" + empDepType + "' and " + empSalaryMonth + " = '" + month + "'", SqlConnection);
                SqlDataAdapter.Fill(temptable);
                if (temptable.Rows.Count > 0)
                {
                    SqlDataAdapter = new SqlDataAdapter("delete from " + _tbl_emp_salary + " where " + empSalaryFKuserId + " = '" + empDetId + "' and " + empSalaryDepType + " = '" + empDepType + "' and " + empSalaryMonth + " = '" + month + "'", SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    new Alert("Employee Status UnPaid", Alert.AlertType.WARNING);
                    result = true;
                }
                else
                {
                    //insert std fee Month
                    SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_emp_salary + " values('" + empDetId + "','" + empName + "', '" + empDepType + "', '" + empIncentive + "', '" + empBonus + "', '" + empGross + "', '" + empSalDeduction + "', '" + empNetPay + "', '" + month + "','" + date + "')", SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    new Alert("Employee Status Paid", Alert.AlertType.SUCCESS);
                    result = true;
                }
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public DataTable GetDefaultSalary()
        {
            SqlDataAdapter = new SqlDataAdapter("select * from "+_tbl_Default_Salary+ " order by defaultSalaryDepartment", SqlConnection);
            DataTable tbl = new DataTable();
            SqlDataAdapter.Fill(tbl);
            return tbl;
        }

        //Default salary update or insert
        public bool AddOrUpdateDefaultSalary(string basicPay, string defIncentive, string tax, string dept)
        {
            bool result;
            try
            {
                DataTable temptable = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select * from " + _tbl_Default_Salary + " where " + defaultSalaryDepartment + " = '" + dept + "'", SqlConnection);
                SqlDataAdapter.Fill(temptable);
                if (temptable.Rows.Count > 0)
                {
                    //update std Class
                    SqlDataAdapter = new SqlDataAdapter("update " + _tbl_Default_Salary + " set " + defaultSalarybasicPay + " = '" + basicPay + "', " + defaultSalaryIncentive + " = '" + defIncentive + "' , " + defaultSalaryTax + " = '" + tax + "' where " + defaultSalaryDepartment + " = '" + dept+"'", SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    result = true;
                }
                else
                {
                    SqlDataAdapter = new SqlDataAdapter("insert into " + _tbl_Default_Salary + " values('" + basicPay + "', '" + defIncentive + "', '" + tax + "', '" + dept + "')", SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    result = true;
                }
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }


        public DataTable GetSaleryBonus(string dept,string userId)
        {
            try
            {
                SqlDataAdapter = new SqlDataAdapter("select salBonusId ,salBonusEmpId,salBonus,defaultSalarybasicPay,defaultSalaryTax,defaultSalaryIncentive,(salBonus+defaultSalarybasicPay+defaultSalaryIncentive-defaultSalaryTax) as NetPay from tbl_saleries_bonuses inner join tbl_Default_Salary on tbl_Default_Salary.defaultSalaryDepartment = tbl_saleries_bonuses.salBonusDep where salBonusDep = '"+dept+"' and salBonusEmpId = '"+userId+"'", SqlConnection);
                DataTable tbl = new DataTable();
                SqlDataAdapter.Fill(tbl);
                return tbl;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool AddOrUpdateBonusOfEmp(string userId, string dept, string bonus)
        {
            bool result;
            try
            {
                DataTable temptable = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select * from tbl_saleries_bonuses where salBonusEmpId = '" + userId + "' and salBonusDep = '" + dept + "'", SqlConnection);
                SqlDataAdapter.Fill(temptable);
                if (temptable.Rows.Count > 0)
                {
                    //update std Class
                    SqlDataAdapter = new SqlDataAdapter("update tbl_saleries_bonuses set salBonus = '" + bonus + "' where salBonusEmpId = '" + userId + "' and salBonusDep = '" + dept + "'", SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    result = true;
                }
                else
                {
                    SqlDataAdapter = new SqlDataAdapter("insert into tbl_saleries_bonuses values(" + userId + ", '" + dept + "', " + bonus + ")", SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    result = true;
                }
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public bool AddOrUpdateFeesAccToStdCls(string clsId, int fees)
        {
            bool result;
            try
            {
                DataTable temptable = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select * from tbl_fees_acc_std_cls where feesClsFKClsId = " + clsId + "", SqlConnection);
                SqlDataAdapter.Fill(temptable);
                if (temptable.Rows.Count > 0)
                {
                    //update std Class
                    SqlDataAdapter = new SqlDataAdapter("update tbl_fees_acc_std_cls set feesClsFees = '" + fees + "' where feesClsFKClsId = " + clsId, SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    result = true;
                }
                else
                {
                    SqlDataAdapter = new SqlDataAdapter("insert into tbl_fees_acc_std_cls values(" + clsId + ", '" + fees + "')", SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    result = true;
                }
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

        public int GetFeesAccToClass(string clsId)
        {
            try
            {
                DataTable tbl = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select feesClsFees from tbl_fees_acc_std_cls where feesClsFKClsId = " + clsId + "", SqlConnection);
                SqlDataAdapter.Fill(tbl);
                return Convert.ToInt32(tbl.Rows[0][0].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int[] CalculateProfitLoss(string monthOrYear)
        {
            int[] res = { 0, 0};
            try
            {
                //calc profit from fees
                DataTable tbl = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select stuFeesFKstuDetId from tbl_stu_fees where stuFeesMonth like '%" + monthOrYear + "%'", SqlConnection);
                SqlDataAdapter.Fill(tbl);
                int profit = 0;
                int loss = 0;
                foreach (DataRow row in tbl.Rows)
                {
                    string id = row[0].ToString();
                    DataTable tbl1 = new DataTable();
                    SqlDataAdapter = new SqlDataAdapter("select feesClsFees from tbl_sec inner join tbl_classes on tbl_sec.secFkclassId = tbl_classes.classId inner join tbl_std_assgin_class on tbl_std_assgin_class.stdAssignClsFKSecId = tbl_sec.secId inner join tbl_fees_acc_std_cls on feesClsFKClsId = classId  where stdAssignClsStdDetId = " + id, SqlConnection);
                    SqlDataAdapter.Fill(tbl1);
                    profit += Convert.ToInt32(tbl1.Rows[0][0].ToString());
                }
                //calc expenditure profit / loss
                DataTable tbl2 = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select expendituresChareges,expendituresProfitLose from tbl_expenditures where expendituresDate like '%"+monthOrYear+"%'", SqlConnection);
                SqlDataAdapter.Fill(tbl2);
                foreach(DataRow row in tbl2.Rows)
                {
                    if(row[1].ToString() == "Profit")
                    {
                        profit += Convert.ToInt32(row[0].ToString());
                    }
                    else
                    {
                        loss += Convert.ToInt32(row[0].ToString());
                    }
                }

                //calc loss from salary
                DataTable tbl3 = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select empSalaryNetPay from tbl_emp_salary where empSalaryMonth like '%"+monthOrYear+"%'", SqlConnection);
                SqlDataAdapter.Fill(tbl3);
                foreach (DataRow row in tbl3.Rows)
                {
                    loss += Convert.ToInt32(row[0].ToString());
                }

                res[0] = profit;
                res[1] = loss;
            }
            catch (Exception){}
            return res;
        }

        public string GetPref(string key)
        {
            try
            {
                DataTable tbl = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select exValue from tbl_extra where exKey = '"+key+"'", SqlConnection);
                SqlDataAdapter.Fill(tbl);
                return tbl.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }

        public bool AddOrUpdatePref(string key, string value)
        {
            bool result;
            try
            {
                DataTable temptable = new DataTable();
                SqlDataAdapter = new SqlDataAdapter("select exValue from tbl_extra where exKey = '" + key + "'", SqlConnection);
                SqlDataAdapter.Fill(temptable);
                if (temptable.Rows.Count > 0)
                {
                    SqlDataAdapter = new SqlDataAdapter("update tbl_extra set exValue = '" + value+ "' where exKey = '" + key + "'", SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    result = true;
                }
                else
                {
                    SqlDataAdapter = new SqlDataAdapter("insert into tbl_extra values('" + key + "', '" + value + "')", SqlConnection);
                    DataTable tbl = new DataTable();
                    SqlDataAdapter.Fill(tbl);
                    result = true;
                }
            }
            catch (Exception)
            {
                new Alert("Some Error Occurred", Alert.AlertType.ERROR);
                result = false;
            }
            return result;
        }

    }
}