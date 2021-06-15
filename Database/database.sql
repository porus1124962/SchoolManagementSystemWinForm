create database schoolManagement

use schoolManagement

create table tbl_extra(
	exId int primary key identity,
	exKey varchar(50),
	exValue varchar(50)
)

select * from tbl_extra

select exValue from tbl_extra where exKey = 'LoginType'

delete from tbl_extra where exId =4
--delete from tbl_extra where exValue = '5'


/*Ex Emp Det*/
create table tbl_ex_emp_det(
	exEmpId int primary key identity,
	exEmpFKUserTypeId int,
	exEmptName varchar(50),
	exEmpGender varchar(50),
	exEmpDeptName varchar(50),
	exEmpLeaveDate varchar(50),
)

drop table tbl_ex_emp_det

select * from tbl_ex_emp_det
/*Ex Emp Det*/




/* student auth */
create table tbl_stu_auth(
	stuAuthId int primary key identity,
	stuAuthFKstuDetId int,
	stuAuthUsername varchar(50),
	stuAuthPass varchar(50),
)

select * from tbl_stu_auth

delete from tbl_stu_auth where stuAuthId = 2

insert into tbl_stu_auth values (5,'awais','123')

update tbl_stu_auth set stuAuthUsername = 'some name' , stuAuthPass = 'some pass' where stuAuthFKstuDetId = 9

/* student auth */



/* student details */

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

delete from tbl_stu_details where stuDetId = 12

select stuDetId,stuDetName,stuDetFname,stuDetAge,stuDetGender,stuDetAddress,stuDetStuPh,stuDetFatherPh,stuDetLastClass,stuDetLastSchool,stuAuthUsername,stuAuthPass from tbl_stu_details inner join tbl_stu_auth ON tbl_stu_details.stuDetId = tbl_stu_auth.stuAuthFKstuDetId

select * from tbl_stu_details

insert into tbl_stu_details values ('jhjhgawais','ngjkasir jklali','18','Male','cpo','032255','534654','5','Gol mal school system')

select stuDetId,stuDetName,stuDetFname,stuDetAge,stuDetGender,stuDetAddress,stuDetStuPh,stuDetFatherPh,stuDetLastClass,stuDetLastSchool,stuAuthUsername,stuAuthPass from tbl_stu_details inner join tbl_stu_auth ON tbl_stu_details.stuDetId = tbl_stu_auth.stuAuthFKstuDetId where stuDetId = '2' or stuDetName like 'awais%' or stuDetAge like '18%' or stuDetGender like 'male%' or stuDetAddress like 'cpo%' or stuDetLastClass like '5%' or stuAuthUsername like 'awais%'

/* student details */



/* student attendence */

create table tbl_stu_attendence(
	stuAttenId int primary key identity,
	stuAttenFKstuDetId int,
	stuAttenDate varchar(50),
	stuAttenStatus varchar(50)
)

select stuAttenFKstuDetId, stuDetName, stuAttenStatus from tbl_stu_attendence inner join tbl_stu_details on tbl_stu_attendence.stuAttenFKstuDetId = tbl_stu_details.stuDetId inner join tbl_std_assgin_class on tbl_std_assgin_class.stdAssignClsStdDetId = tbl_stu_attendence.stuAttenFKstuDetId inner join tbl_sec on tbl_sec.secId = tbl_std_assgin_class.stdAssignClsFKSecId inner join tbl_classes on tbl_classes.classId = tbl_sec.secFkclassId where stuAttenDate = '08/07/2019' and className = 'one' and secName = 'D'

select * from tbl_stu_attendence
select * from  tbl_stu_attendence  where stuAttenFKstuDetId  = '8' and stuAttenDate like '%Jul/2019' order by stuAttenDate 

select * from tbl_stu_attendence where stuAttenFKstuDetId = '8' and stuAttenDate like '%Jul/2019' order by stuAttenDate

update tbl_stu_attendence set stuAttenDate = '05/Jul/2019' where stuAttenId = '2'
select * from tbl_stu_attendence where stuAttenFKstuDetId = '8' and stuAttenDate = '05/Jul/2019'

insert into tbl_stu_attendence values (4,'24-04-18','P')

drop table tbl_stu_attendence

/* student attendence */


/* student fees */

create table tbl_stu_fees(
	stuFeesId int primary key identity,
	stuFeesFKstuDetId int,
	stuFeesPaidDate varchar(50),
	stuFeesMonth varchar(50)
)

select * from tbl_stu_fees

select stuDetName,stuFeesPaidDate from tbl_stu_fees inner join tbl_stu_details on tbl_stu_fees.stuFeesFKstuDetId = tbl_stu_details.stuDetId

insert into tbl_stu_fees values (18,'09/Jul/2019','Jul/2019')

delete from tbl_stu_fees where stuFeesId = 2

/* student fees */


/* student assign to class*/

create table tbl_std_assgin_class(
	stdAssignClsId int primary key identity,
	stdAssignClsStdDetId int,
	stdAssignClsFKSecId int,
	stdAssignClsDate varchar(50)
)

select * from tbl_std_assgin_class

insert into tbl_std_assgin_class values(8,7,'2019')

drop table tbl_std_assgin_class

/* student assign to class*/


/* room */

create table tbl_room(
	roomId int primary key identity,
	roomFloor varchar(50),
	roomNo varchar(50),
	roomStatus varchar(50),
	roomAssignStatus varchar(50),
)

select * from tbl_room

insert into tbl_room values ('Ground','28','Ready','No')

/* room */



/* classBooks */

create table tbl_classBooks(
	clsBookId int primary key identity,
	clsBookClsLevel int,
	clsBookName varchar(50)
)

select * from tbl_classBooks

insert into tbl_classBooks values (1,'Math')

delete from tbl_classBooks where clsBookId = 1

drop table tbl_classBooks

/* classBooks */


/* classes */
create table tbl_classes(
	classId int primary key identity,
	className varchar(50)
)

select * from tbl_classes

insert into tbl_classes values ('Three')

/* classes */

/* sections */
create table tbl_sec(
	secId int primary key identity,
	secName varchar(50),
	secFkclassId int
)

select * from tbl_sec

delete from tbl_sec where secId = 6
/* sections */

/* classDetails */

--create table tbl_classDetails(
--	classDetailsId int primary key identity,
--	classDetailsFKclsBookId int,
--	classDetailsFKRoomId int,
--	classDetailsSec varchar(50),
--	classDetailsStartTime varchar(50),
--	classDetailsEndTime varchar(50)
--)

--no need

--select * from tbl_classBooks

--insert into tbl_classBooks values ('One','Math')

/* classDetails */



/* teacherAuth */

create table tbl_teacher_auth(
	teacherAuthId int primary key identity,
	teacherAuthFKteacherDetId int,
	teacherAuthUsername varchar(50),
	teacherAuthPass varchar(50)
)

select * from tbl_teacher_auth

insert into tbl_teacher_auth values (4,'Rana','1234')

/* teacherAuth */



/* teacher details */

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

select * from tbl_teacher_details

select * from tbl_teacher_details where teacherDetId = '2' or teacherDetName like 'teacher2%' or teacherDetGender like 'male%'

select teacherDetId,teacherDetName,teacherDetFname,teacherDetAge,teacherDetGender,teacherDetAddress,teacherDetPh,teacherDetEmail,teacherDetQualification,teacherDetSubject,teacherAuthUsername,teacherAuthPass from tbl_teacher_details inner join tbl_teacher_auth ON tbl_teacher_details.teacherDetId = tbl_teacher_auth.teacherAuthFKteacherDetId

select teacherDetId,teacherDetName,teacherDetFname,teacherDetAge,teacherDetGender,teacherDetAddress,teacherDetPh,teacherDetEmail,teacherDetQualification,teacherDetSubject,teacherAuthUsername,teacherAuthPass from tbl_teacher_details inner join tbl_teacher_auth ON tbl_teacher_details.teacherDetId = tbl_teacher_auth.teacherAuthFKteacherDetId where teacherDetId ='2' or teacherDetName like 'Awais%' or teacherDetAge like '32%' or teacherDetGender like 'Gay%' or teacherDetAddress like '6778/qa%' or teacherDetQualification like '12%' or teacherDetSubject like 'c#%' or teacherAuthUsername like 'Awais%'

drop table tbl_teacher_details

/* teacher details */


/* teacher attendence */

create table tbl_teacher_attendence(
	teacherAttenId int primary key identity,
	teacherAttenFKstuDetId int,
	teacherAttenDate varchar(50),
	teacherAttenStatus varchar(50)
)

select * from tbl_teacher_attendence

insert into tbl_teacher_attendence values (4,'24-04-18','P')

drop table tbl_teacher_attendence

/* teacher attendence */



/* teacher class assign */

create table tbl_teacher_class_assign(
	teacherClsAssignId int primary key identity,
	teacherClsAssignFKteacherDetId int,
	teacherClsAssignFKSecId int
)

select * from tbl_teacher_class_assign

insert into tbl_teacher_class_assign values (4,5)

drop table tbl_teacher_class_assign

select classId,className from tbl_teacher_class_assign inner join tbl_sec on tbl_teacher_class_assign.teacherClsAssignFKSecId = tbl_sec.secId inner join tbl_classes on tbl_sec.secFkclassId = tbl_classes.classId where teacherClsAssignFKteacherDetId = 5

select secId,secName,secFkclassId from tbl_sec inner join tbl_teacher_class_assign on tbl_sec.secId = tbl_teacher_class_assign.teacherClsAssignFKSecId where secFkclassId = 1 and teacherClsAssignFKteacherDetId = 5

/* teacher class assign */



/* admin auth */
create table tbl_admin_auth(
	adminAuthId int primary key identity,
	adminAuthFKstuDetId int,
	adminAuthUsername varchar(50),
	adminAuthPass varchar(50),
)

insert into tbl_admin_auth values('1','admin','12345');

select * from tbl_admin_auth

delete from tbl_admin_auth where adminAuthId = 1
/* admin auth */



/* admin details */

create table tbl_admin_details(
	adminDetId int primary key identity,
	adminDetName varchar(50),
	adminDetGender varchar(50),
	adminDetAddress varchar(50),
	adminDetStuPh varchar(50),
)

select * from tbl_admin_details

delete from tbl_admin_details where adminDetId = 8

insert into tbl_admin_details values('Usman','Male','144','6969')

select adminDetId,adminDetName,adminDetGender,adminDetAddress,adminDetStuPh,adminAuthUsername,adminAuthPass from tbl_admin_details inner join tbl_admin_auth ON tbl_admin_details.adminDetId = tbl_admin_auth.adminAuthFKstuDetId

select adminDetId,adminDetName,adminDetGender,adminDetAddress,adminDetStuPh,adminAuthUsername,adminAuthPass from tbl_admin_details inner join tbl_admin_auth ON tbl_admin_details.adminDetId = tbl_admin_auth.adminAuthFKstuDetId where adminDetId ='1' or adminDetName like 'usman%'  or adminDetGender like 'male%' or adminDetAddress like 'un%' or adminAuthUsername like 'usman12%'  

/* admin details */


/* admin attendence */

create table tbl_admin_attendence(
	adminAttenId int primary key identity,
	adminAttenFKAdminDetId int,
	adminAttenDate varchar(50),
	adminAttenStatus varchar(50)
)
drop table tbl_admin_attendence

select * from tbl_admin_attendence

insert into tbl_admin_attendence values (4,'24-04-18','P')

/* admin attendence */


/* hr auth */
create table tbl_hr_auth(
	hrAuthId int primary key identity,
	hrAuthFKstuDetId int,
	hrAuthUsername varchar(50),
	hrAuthPass varchar(50),
)

insert into tbl_hr_auth values('1','hr','12345');

select * from tbl_hr_auth

/* hr auth */


/* hr details */

create table tbl_hr_details(
	hrDetId int primary key identity,
	hrDetName varchar(50),
	hrDetGender varchar(50),
	hrDetAddress varchar(50),
	hrDetStuPh varchar(50),
)

insert into tbl_hr_details values('Usman','Male','144','6969')

select hrDetId,hrDetName,hrDetGender,hrDetAddress,hrDetStuPh,hrAuthUsername,hrAuthPass from tbl_hr_details inner join tbl_hr_auth ON tbl_hr_details.hrDetId = tbl_hr_auth.hrAuthFKstuDetId
select hrDetId,hrDetName,hrDetGender,hrDetAddress,hrDetStuPh,hrAuthUsername,hrAuthPass from tbl_hr_details inner join tbl_hr_auth ON tbl_hr_details.hrDetId = tbl_hr_auth.hrAuthFKstuDetId where hrDetId = '1' or hrDetName like 'awais%' or hrDetGender like 'Gay%' or hrDetAddress like '34/34' or hrAuthUsername like 'awais34'
/* hr details */


/* hr attendence */

create table tbl_hr_attendence(
	hrAttenId int primary key identity,
	hrAttenFKteacherDetId int,
	hrAttenDate varchar(50),
	hrAttenStatus varchar(50)
)

select * from tbl_hr_attendence

insert into tbl_hr_attendence values (4,'24-04-18','P')

/* hr attendence */


/* acc auth */
create table tbl_acc_auth(
	accAuthId int primary key identity,
	accAuthFKstuDetId int,
	accAuthUsername varchar(50),
	accAuthPass varchar(50),
)

select * from tbl_acc_auth

insert into tbl_acc_auth values('1','acc','123');
/* acc auth */


/* acc details */

create table tbl_acc_details(
	accDetId int primary key identity,
	accDetName varchar(50),
	accDetGender varchar(50),
	accDetAddress varchar(50),
	accDetStuPh varchar(50),
)

select * from tbl_acc_details

insert into tbl_acc_details values('rehamn acc','Male','144','6969')

select accDetId,accDetName,accDetGender,accDetAddress,accDetStuPh,accAuthUsername,accAuthPass from tbl_acc_details inner join tbl_acc_auth ON tbl_acc_details.accDetId = tbl_acc_auth.accAuthFKstuDetId
select accDetId,accDetName,accDetGender,accDetAddress,accDetStuPh,accAuthUsername,accAuthPass from tbl_acc_details inner join tbl_acc_auth ON tbl_acc_details.accDetId = tbl_acc_auth.accAuthFKstuDetId where accDetId = '1' or accDetName like 'awais%' or accDetGender like 'male%' or accDetAddress like '68/34%' or accAuthUsername like 'awais12%'

/* acc details */



/* acc attendence */

create table tbl_acc_attendence(
	accAttenId int primary key identity,
	accAttenFKteacherDetId int,
	accAttenDate varchar(50),
	accAttenStatus varchar(50)
)

select * from tbl_acc_attendence

insert into tbl_acc_attendence values (4,'24-04-18','P')

/* acc attendence */




/* tbl leave std*/

create table tbl_std_leave_record(
	stdLeaveRecId int primary key identity,
	stdLeaveRecFKstdDetId int,
	stdLeaveRecLeaveStatus varchar(50),
	stdLeaveRecLastClassStudied varchar(50),
	stdLeaveRecAcademicResult varchar(50),
	stdLeaveRecPercenage varchar(50)
)

select * from tbl_std_leave_record

select stdLeaveRecFKstdDetId, stuDetName, stuDetFname, stuDetGender, stuDetStuPh, className, stdLeaveRecLeaveStatus, stdLeaveRecAcademicResult, stdLeaveRecPercenage from tbl_std_leave_record inner join tbl_stu_details on tbl_std_leave_record.stdLeaveRecFKstdDetId = tbl_stu_details.stuDetId inner join  on tbl_std_leave_record.stdLeaveRecFKstdDetId = tbl_std_assgin_class.stdAssignClsStdDetId inner join tbl_sec on tbl_std_assign_class.stdAssignClsFKSecId = tbl_sec.secId inner join tbl_classes on tbl_sec.secFkclassId = tbl_classes.classId

select stdLeaveRecFKstdDetId, stuDetName, stuDetFname, stuDetGender, stuDetStuPh, stdLeaveRecLastClassStudied, stdLeaveRecLeaveStatus, stdLeaveRecAcademicResult, stdLeaveRecPercenage from tbl_std_leave_record inner join tbl_stu_details on tbl_std_leave_record.stdLeaveRecFKstdDetId = tbl_stu_details.stuDetId

insert into tbl_std_leave_record values('8', 'Pass','Four', '2016', '80%')
insert into tbl_std_leave_record values('13','Left','One', '2015', '70%')
insert into tbl_std_leave_record values('17','Left','Nine', '2018', '60%')
insert into tbl_std_leave_record values('18','Pass','Six', '2019', '69%')
insert into tbl_std_leave_record values('19','Left','Five', '2017', '50%')
insert into tbl_std_leave_record values('20','Left','Four', '2017', '50%')

drop table tbl_std_leave_record

/* tbl leave std*/


/* tbl Salary */
create table tbl_emp_salary(
    empSalaryId int primary key identity,
    empSalaryFKuserId int,
	empSalaryName varchar(50),
	empSalaryDepType varchar(50),
    empSalaryIncentive varchar(50),
	empSalaryBonus varchar(50),
	empSalaryGrossPay varchar(50),
	empSalaryDeduction varchar(50),
	empSalaryNetPay varchar(50),
	empSalaryMonth varchar(50),
	empSalaryDate varchar(50)
)

drop table tbl_emp_salary

select * from tbl_emp_salary

select empSalaryNetPay from tbl_emp_salary where empSalaryMonth like '%Jul/2019%'

/* tbl Salary */


select className from tbl_classes inner join tbl_sec on tbl_classes.classId = tbl_sec.secFkclassId inner join tbl_std_assgin_class on tbl_std_assgin_class.stdAssignClsFKSecId = tbl_sec.secId where tbl_std_assgin_class.stdAssignClsStdDetId = '17'


/* tbl_expenditures */
create table tbl_expenditures (
expendituresId int primary key identity,
expendituresName varchar(50),
expendituresDescribtion varchar(50),
expendituresChareges int,
expendituresProfitLose varchar(50),
expendituresDate varchar(50)
)
select * from tbl_expenditures

/* tbl_expenditures */


/*tbl_Default_Salary*/
create table tbl_Default_Salary(
defaultSalaryId int primary key identity,
defaultSalarybasicPay varchar(50),
defaultSalaryIncentive varchar(50),
defaultSalaryTax varchar(50),
defaultSalaryDepartment varchar(50)
) 

select * from tbl_Default_Salary order by defaultSalaryDepartment

drop table tbl_Default_Salary
/*tbl_Default_Salary*/



/* salries bonuses */

create table tbl_saleries_bonuses(
	salBonusId int primary key identity,
	salBonusEmpId int,
	salBonusDep varchar(50),
	salBonus int
)

insert into tbl_saleries_bonuses values('11','Accounts','4500')

drop table tbl_saleries_bonuses

select * from tbl_saleries_bonuses

select salBonusId,teacherDetId,salBonus,defaultSalarybasicPay,defaultSalaryTax,defaultSalaryIncentive,(salBonus+defaultSalarybasicPay+defaultSalaryIncentive-defaultSalaryTax) as NetPay from tbl_saleries_bonuses inner join tbl_Default_Salary on tbl_saleries_bonuses.salBonusDep = tbl_Default_Salary.defaultSalaryDepartment full outer join tbl_teacher_details on tbl_teacher_details.teacherDetId = tbl_saleries_bonuses.salBonusEmpId where defaultSalaryDepartment = 'Teacher'

select salBonusId,salBonusDep,teacherDetId,salBonus,defaultSalarybasicPay,defaultSalaryTax,defaultSalaryIncentive,(salBonus+defaultSalarybasicPay+defaultSalaryIncentive-defaultSalaryTax) as NetPay from tbl_teacher_details full outer join tbl_saleries_bonuses on tbl_saleries_bonuses.salBonusEmpId = tbl_teacher_details.teacherDetId inner join tbl_Default_Salary on tbl_Default_Salary.defaultSalaryDepartment = tbl_saleries_bonuses.salBonusDep where salBonusDep = 'Teacher'

select salBonusId ,salBonusEmpId,salBonus,defaultSalarybasicPay,defaultSalaryTax,defaultSalaryIncentive,(salBonus+defaultSalarybasicPay+defaultSalaryIncentive-defaultSalaryTax) as NetPay from tbl_saleries_bonuses inner join tbl_Default_Salary on tbl_Default_Salary.defaultSalaryDepartment = tbl_saleries_bonuses.salBonusDep where salBonusDep = 'Teacher' and salBonusEmpId = '1'

select salBonusId ,salBonusEmpId,salBonus,defaultSalarybasicPay,defaultSalaryTax,defaultSalaryIncentive,(salBonus+defaultSalarybasicPay+defaultSalaryIncentive-defaultSalaryTax) as NetPay from tbl_saleries_bonuses inner join tbl_Default_Salary on tbl_Default_Salary.defaultSalaryDepartment = tbl_saleries_bonuses.salBonusDep where salBonusDep = 'Admission' and salBonusEmpId = '4'
 /* salries bonuses */

 /* tbl for fees acc to students*/

 create table tbl_fees_acc_std_cls(
	feesClsId int primary key identity,
	feesClsFKClsId int,
	feesClsFees int
 )

 drop table tbl_fees_acc_std_cls

 /* tbl for fees acc to students*/

 /* calc profit */

select classId,feesClsFees from tbl_sec inner join tbl_classes on tbl_sec.secFkclassId = tbl_classes.classId inner join tbl_std_assgin_class on tbl_std_assgin_class.stdAssignClsFKSecId = tbl_sec.secId inner join tbl_fees_acc_std_cls on feesClsFKClsId = classId  where stdAssignClsStdDetId = 22

select feesClsFees from tbl_fees_acc_std_cls where feesClsFKClsId = 1

select expendituresChareges,expendituresProfitLose from tbl_expenditures where expendituresDate like '%1995%'

 /* calc profit */