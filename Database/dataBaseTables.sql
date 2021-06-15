use master

drop database schoolManagement

create database schoolManagement

use schoolManagement

create table tbl_extra(
	exId int primary key identity,
	exKey varchar(50),
	exValue varchar(50)
)

/*Ex Emp Det*/
create table tbl_ex_emp_det(
	exEmpId int primary key identity,
	exEmpFKUserTypeId int,
	exEmpDeptName varchar(50),
	exEmpLeaveDate varchar(50),
)
/*Ex Emp Det*/

create table tbl_stu_auth(
	stuAuthId int primary key identity,
	stuAuthFKstuDetId int,
	stuAuthUsername varchar(50),
	stuAuthPass varchar(50),
)

create table tbl_stu_details(
	stuDetId int primary key identity,
	stuDetName varchar(50),
	stuDetFname varchar(50),
	stuDetAge varchar(50),
	stuDetGender varchar(50),
	stuDetAddress varchar(50),
	stuDetStuPh varchar(50),
	stuDetFatherPh varchar(50),
	stuDetLastClass varchar(50),
	stuDetLastSchool varchar(50),
)

create table tbl_stu_attendence(
	stuAttenId int primary key identity,
	stuAttenFKstuDetId int,
	stuAttenDate varchar(50),
	stuAttenStatus varchar(50)
)

create table tbl_stu_fees(
	stuFeesId int primary key identity,
	stuFeesFKstuDetId int,
	stuFeesPaidDate varchar(50),
	stuFeesMonth varchar(50)
)

create table tbl_std_assgin_class(
	stdAssignClsId int primary key identity,
	stdAssignClsStdDetId int,
	stdAssignClsFKSecId int,
	stdAssignClsDate varchar(50)
)

create table tbl_room(
	roomId int primary key identity,
	roomFloor varchar(50),
	roomNo varchar(50),
	roomStatus varchar(50),
	roomAssignStatus varchar(50),
)

create table tbl_classBooks(
	clsBookId int primary key identity,
	clsBookClsLevel int,
	clsBookName varchar(50)
)

create table tbl_classes(
	classId int primary key identity,
	className varchar(50)
)

create table tbl_sec(
	secId int primary key identity,
	secName varchar(50),
	secFkclassId int
)

create table tbl_teacher_auth(
	teacherAuthId int primary key identity,
	teacherAuthFKteacherDetId int,
	teacherAuthUsername varchar(50),
	teacherAuthPass varchar(50)
)

create table tbl_teacher_details(
	teacherDetId int primary key identity,
	teacherDetName varchar(50),
	teacherDetFname varchar(50),
	teacherDetAge varchar(50),
	teacherDetGender varchar(50),
	teacherDetAddress varchar(50),
	teacherDetPh varchar(50),
	teacherDetEmail varchar(50),
	teacherDetQualification varchar(50),
	teacherDetSubject varchar(50),
)

create table tbl_teacher_attendence(
	teacherAttenId int primary key identity,
	teacherAttenFKteacherDetId int,
	teacherAttenDate varchar(50),
	teacherAttenStatus varchar(50)
)

create table tbl_teacher_class_assign(
	teacherClsAssignId int primary key identity,
	teacherClsAssignFKteacherDetId int,
	teacherClsAssignFKSecId int
)

create table tbl_admin_auth(
	adminAuthId int primary key identity,
	adminAuthFKstuDetId int,
	adminAuthUsername varchar(50),
	adminAuthPass varchar(50),
)

create table tbl_admin_details(
	adminDetId int primary key identity,
	adminDetName varchar(50),
	adminDetGender varchar(50),
	adminDetAddress varchar(50),
	adminDetStuPh varchar(50),
)

create table tbl_hr_auth(
	hrAuthId int primary key identity,
	hrAuthFKstuDetId int,
	hrAuthUsername varchar(50),
	hrAuthPass varchar(50),
)

create table tbl_hr_details(
	hrDetId int primary key identity,
	hrDetName varchar(50),
	hrDetGender varchar(50),
	hrDetAddress varchar(50),
	hrDetStuPh varchar(50),
)

create table tbl_acc_auth(
	accAuthId int primary key identity,
	accAuthFKstuDetId int,
	accAuthUsername varchar(50),
	accAuthPass varchar(50),
)

create table tbl_acc_details(
	accDetId int primary key identity,
	accDetName varchar(50),
	accDetGender varchar(50),
	accDetAddress varchar(50),
	accDetStuPh varchar(50),
)

create table tbl_std_leave_record(
	stdLeaveRecId int primary key identity,
	stdLeaveRecFKstdDetId int,
	stdLeaveRecLeaveStatus varchar(50),
	stdLeaveRecAcademicResult varchar(50),
	stdLeaveRecPercenage varchar(50)
)

create table tbl_emp_salary(
    empSalaryId int primary key identity,
    empSalaryFKuserType	 int,
	empSalaryName varchar(50),
	empSalaryType varchar(50),
    empSalaryIntivcene varchar(50),
	empSalaryBonus varchar(50),
	empSalaryGrossPay varchar(50),
	empSalaryDeduction varchar(50),
	empSalaryNetPay varchar(50)
)

insert into tbl_admin_auth values('1','admin', '123');
insert into tbl_admin_details values('admin','male', 'jsbfukas', '69169');
insert into tbl_classes values('one');

