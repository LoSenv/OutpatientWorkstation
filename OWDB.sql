CREATE DATABASE OWDB
ON
(NAME='DataFile_1'
,FILENAME='D:\OWDB\DataFile_1.mdf')
LOG ON
(NAME='LogFile_1'
,FILENAME='D:\OWDB\LogFile_1.ldf');
GO
USE OWDB

--�����Կ
IF ASYMKEY_ID('ak_OWDB_ForSymKeyCrypto') IS NOT NULL							
	DROP ASYMMETRIC KEY ak_OWDB_ForSymKeyCrypto;						
GO							
CREATE ASYMMETRIC KEY ak_OWDB_ForSymKeyCrypto							
	WITH 						
		ALGORITHM=RSA_2048					
		ENCRYPTION BY PASSWORD='1qaz@WSX';			


IF KEY_ID('sk_OWDB_ForDataCrypto') IS NOT NULL										
	DROP SYMMETRIC KEY sk_OWDB_ForDataCrypto;									
GO										
CREATE SYMMETRIC KEY sk_OWDB_ForDataCrypto										
	WITH 									
		ALGORITHM=AES_128								
		ENCRYPTION BY ASYMMETRIC KEY ak_OWDB_ForSymKeyCrypto;

--������Ա��

DROP TABLE  IF EXISTS  tb_Admin
CREATE TABLE tb_Admin
(Name
varchar(20)
not null
constraint pk_Admin_Name
primary key(Name)
,Password
varbinary(128)
not null)

--�����ű�

DROP TABLE  IF EXISTS tb_Department
CREATE TABLE tb_Department
(No
int
not null
constraint pk_Department_No
primary key(No) identity(1,1)
,Name
varchar(20)
not null
,Remark
varchar(50))


--�����ұ�

DROP TABLE IF EXISTS  tb_TechnicalOffice
CREATE TABLE tb_TechnicalOffice
(No
int
not null
constraint pk_TechnicalOffice_No
primary key(No) identity(1,1)
,Name
varchar(20)
not null
,DepartmentNo
int
not null
constraint fk_TechnicalOffice_DepartmentNo
foreign key(DepartmentNo)
references tb_Department(No)
,Remark
varchar(50))

--����װ��λ��

DROP TABLE IF EXISTS  tb_Unit
CREATE TABLE tb_Unit
(No
INT
not null
constraint pk_Unit_No
primary key(No)
,Name
varchar(20)
not null)


--����ҩ������
DROP TABLE IF EXISTS tb_UseMethod
CREATE TABLE tb_UseMethod
(No
int
not null
constraint pk_UseMethod_No
primary key(No)
,Name
varchar(50)
not null)


--����ҩƵ�ʱ�

DROP TABLE IF EXISTS tb_UseFrequency
CREATE TABLE tb_UseFrequency
(No
int
not null
constraint pk_UseFrequency_No
primary key(No)
,Name
varchar(50)
not null)


--��Ա�����ͱ�

DROP TABLE IF EXISTS tb_AgencyType
CREATE TABLE tb_AgencyType
(No
int
not null	
constraint pk_AgencyType_No
primary key(No)
,Type
varchar(20)
not null)

--��ҩƷ��

DROP TABLE  IF EXISTS  tb_Medicine
CREATE TABLE tb_Medicine
(No
int
not null
constraint pk_Medicine_No
primary key(No) identity(1,1)
,Name
varchar(20)
not null
,Pinyin
varchar(20)
not null
,Spec
varchar(20)
not null
,Efficacy
varchar(128)
not null
,Price
Decimal
not null
,Count
int
not null
,UnitNo
INT
not null
constraint fk_Medicine_UnitNo
foreign key(UnitNo)
references tb_Unit(No))

--�����˱�

DROP TABLE IF EXISTS tb_Patient
CREATE TABLE tb_Patient
(No
int
not null
constraint pk_Patient_No
primary key(No) identity(1,1)
,Name
varchar(20)
not null
,Gender
bit
not null
,BirthDate
date
not null
,Phone
char(10)
not null
,Adress
varchar(40)
not null)


--��Ա����

DROP TABLE IF EXISTS  tb_Agency
CREATE TABLE tb_Agency
(No
int
not null
constraint pk_Agency_No
primary key(No) identity(1,1)
,Name
varchar(20)
not null
,Gender
bit
not null
,Phone
char(10)
not null
,Password
varbinary(128)
,AgencyTypeNo
int
not null
constraint fk_Agency_AgencyTypeNo
foreign key(AgencyTypeNo)
references tb_AgencyType(No)
,TechnicalOfficeNo
int
constraint fk_Agency_TechnicalOfficeNo
foreign key(TechnicalOfficeNo)
references tb_TechnicalOffice(No)
,Remark
varchar(128))

--����������

DROP TABLE  IF EXISTS  tb_Ordonnance
CREATE TABLE tb_Ordonnance
(No
int 
not null
constraint pk_Ordonnance_No
primary key(No)
,PatientNo
int
not null
constraint fk_Ordonnance_PatientNo
foreign key(PatientNo)
references tb_Patient(No)
,AgencyNo
int
not null
constraint fk_Ordonnance_AgencyNo
foreign key(AgencyNo)
references tb_Agency(No)
,Date
datetime
not null)


--����������ϸ��

DROP TABLE  IF EXISTS  tb_OrdonnanceDetail
CREATE TABLE tb_OrdonnanceDetail
(No
int
not null
constraint pk_OrdonnanceDetail_No
primary key(No) identity
,OrdonnanceNo
int
not null
constraint fk_OrdonnanceDetail_OrdonnanceNo
foreign key(OrdonnanceNo)
references tb_Ordonnance(No)
,Type
varchar(50)
not null
,Encod
varchar(30)
not null
,MedicineNo
int
not null
constraint fk_OrdonnanceDetail_MedicineNo
foreign key(MedicineNo)
references tb_Medicine(No)
,UseMethodNo
int
not null
constraint fk_OrdonnanceDetail_UseMethodNo
foreign key(UseMethodNo)
references tb_UseMethod(No)
,UseFrequencyNo
int
not null
constraint fk_OrdonnanceDetail_UseFrequencyNo
foreign key(UseFrequencyNo)
references tb_UseFrequency(No)
,Remark
varchar(128))

--��������

DROP TABLE IF EXISTS    tb_MedicalRecord
CREATE TABLE tb_MedicalRecord
(No
int
not null
constraint pk_MedicalRecord_No
primary key(No) identity(1,1)
,Name
VARCHAR(20)
NOT NULL
,DoctorNo
int
not null
constraint pk_MedicalRecord_DoctorNo
foreign key(DoctorNo)
references tb_Agency(No)
,Situation
varchar(100)
not null
,RegisterNo
int
not null
constraint pk_MedicalRecord_RegisterNo
foreign key(RegisterNo)
references tb_Register(No))


--���Һű�
USE OWDB
DROP TABLE  IF EXISTS    tb_Register
CREATE TABLE tb_Register
(No
int
not null
constraint pk_Register_No
primary key(No) identity(1,1)
,PatientNo
int
not null
constraint fk_Register_PatientNo
foreign key(PatientNo)
references tb_Patient(No)
,TechnicalOfficeNo
int
not null
constraint fk_Register_TechnicalOfficeNo
foreign key(TechnicalOfficeNo)
references tb_TechnicalOffice(No)
,DoctorNo
int
not null
constraint fk_Register_DoctorNo
foreign key(DoctorNo)
references tb_Agency(No)
,RegistrarNo
int
not null
constraint fk_Register_RegistrarNo
foreign key(RegistrarNo)
references tb_Agency(No)
,RegisterPrice
int
not null
,Remark
varchar(50)
,DateTime
datetime
not null)


--����Ա���������

insert into tb_Admin(Name,Password)
values('Admin',HASHBYTES('MD5','123'))

--Ա�����ͱ��������

insert into tb_AgencyType(No,Type)
values('1','ҽ��'),('2','�Һ�Ա'),('3','�շ�Ա')

--��ҩ�������������

insert into tb_UseMethod(No,Name)
values(1,'�ڷ�'),(2,'ͿĨ�˿ڴ�')


--��ҩƵ�ʱ��������

insert into tb_UseFrequency(No,Name)
values(1,'һ��һ��'),(2,'һ������'),(3,'һ������')


--��װ��λ���������

insert into tb_Unit(No,Name)
values(1,'��'),(2,'ƿ')

--ҩƷ���������

BULK INSERT tb_Medicine
FROM 'D:\HMMS\SqlSrv\Data\Medicine.csv'
WITH
(FIELDTERMINATOR=','
,ROWTERMINATOR='\n'
,FIRSTROW=2);