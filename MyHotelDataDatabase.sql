--------------------------------------------------------
--  File created - Saturday-June-08-2024   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table APPUSER
--------------------------------------------------------

  CREATE TABLE "MYHOTELDATA"."APPUSER" 
   (	"APPUSERID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ISHIDDEN" NUMBER DEFAULT 0, 
	"USERNAME" VARCHAR2(50 BYTE), 
	"PASSWORD" VARCHAR2(50 BYTE), 
	"ISADMIN" NUMBER DEFAULT 0
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table APPUSERPERMISSION
--------------------------------------------------------

  CREATE TABLE "MYHOTELDATA"."APPUSERPERMISSION" 
   (	"APPUSERPERMISSIONID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"APPUSERID" NUMBER, 
	"USERPERMISSION" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table CUSTOMER
--------------------------------------------------------

  CREATE TABLE "MYHOTELDATA"."CUSTOMER" 
   (	"CUSTOMERID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ISHIDDEN" NUMBER DEFAULT 1, 
	"CUSTOMERCODE" VARCHAR2(50 BYTE), 
	"CUSTOMERTYPE" VARCHAR2(50 BYTE), 
	"CUSTOMERNAME" VARCHAR2(50 BYTE), 
	"SEX" VARCHAR2(10 BYTE), 
	"DOB" VARCHAR2(100 BYTE), 
	"PHONE" VARCHAR2(200 BYTE), 
	"PASSPORTNUMBER" VARCHAR2(200 BYTE), 
	"COUNTRY" VARCHAR2(500 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table RESERVATION
--------------------------------------------------------

  CREATE TABLE "MYHOTELDATA"."RESERVATION" 
   (	"RESERVATIONID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ISHIDDEN" NUMBER DEFAULT 0, 
	"CUSTOMERID" NUMBER, 
	"CHECKINDATE" DATE, 
	"ISCHECKIN" VARCHAR2(50 BYTE), 
	"NUMBEROFDAY" NUMBER DEFAULT 0, 
	"NUMBEROFADULT" NUMBER DEFAULT 0, 
	"NUMBEROFCHILDRENS" NUMBER DEFAULT 0, 
	"MEMO" VARCHAR2(50 BYTE), 
	"CHECKOUTDATE" DATE, 
	"ISPAY" VARCHAR2(50 BYTE), 
	"ISCHECKOUT" VARCHAR2(50 BYTE), 
	"APPUSERID" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table RESERVATIONDETAIL
--------------------------------------------------------

  CREATE TABLE "MYHOTELDATA"."RESERVATIONDETAIL" 
   (	"RESERVATIONDETAILID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"RESERVATIONID" NUMBER, 
	"ROOMID" NUMBER, 
	"ROOMTYPE" VARCHAR2(50 BYTE), 
	"STATUS" VARCHAR2(50 BYTE), 
	"QUANTITY" NUMBER, 
	"PRICE" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table ROOM
--------------------------------------------------------

  CREATE TABLE "MYHOTELDATA"."ROOM" 
   (	"ROOMID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ISHIDDEN" NUMBER DEFAULT 0, 
	"ROOMNAME" VARCHAR2(50 BYTE), 
	"ROOMTYPE" VARCHAR2(50 BYTE), 
	"STATUS" VARCHAR2(50 BYTE), 
	"QUANTITY" NUMBER DEFAULT 0, 
	"PRICE" NUMBER DEFAULT 0, 
	"IMAGE" BLOB
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" 
 LOB ("IMAGE") STORE AS SECUREFILE (
  TABLESPACE "USERS" ENABLE STORAGE IN ROW 4000 CHUNK 8192
  NOCACHE LOGGING  NOCOMPRESS  KEEP_DUPLICATES 
  STORAGE(INITIAL 262144 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)) ;
REM INSERTING into MYHOTELDATA.APPUSER
SET DEFINE OFF;
Insert into MYHOTELDATA.APPUSER (APPUSERID,ISHIDDEN,USERNAME,PASSWORD,ISADMIN) values (41,0,'Admin','123',1);
Insert into MYHOTELDATA.APPUSER (APPUSERID,ISHIDDEN,USERNAME,PASSWORD,ISADMIN) values (82,0,'Ny','123',0);
Insert into MYHOTELDATA.APPUSER (APPUSERID,ISHIDDEN,USERNAME,PASSWORD,ISADMIN) values (42,0,'Thearith','123',0);
Insert into MYHOTELDATA.APPUSER (APPUSERID,ISHIDDEN,USERNAME,PASSWORD,ISADMIN) values (61,0,'John','123',0);
Insert into MYHOTELDATA.APPUSER (APPUSERID,ISHIDDEN,USERNAME,PASSWORD,ISADMIN) values (81,0,'Jan','123',0);
REM INSERTING into MYHOTELDATA.APPUSERPERMISSION
SET DEFINE OFF;
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (44,82,'ReservationModify');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (45,82,'CustomerModify');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (46,82,'RoomModify');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (47,82,'ReservationCreate');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (48,82,'CustomerCreate');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (49,82,'RoomCreate');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (50,82,'RoomView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (51,82,'ReservationView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (52,82,'CustomerView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (1,41,'ReservationDelete');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (2,41,'CustomerDelete');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (3,41,'RoomDelete');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (4,41,'ReservationModify');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (5,41,'CustomerModify');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (6,41,'RoomModify');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (7,41,'ReservationCreate');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (8,41,'CustomerCreate');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (9,41,'RoomCreate');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (10,41,'RoomView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (11,41,'ReservationView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (12,41,'CustomerView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (21,42,'RoomCreate');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (19,42,'ReservationCreate');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (20,42,'CustomerCreate');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (22,42,'RoomView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (23,42,'ReservationView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (24,42,'CustomerView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (25,61,'ReservationCreate');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (26,61,'CustomerCreate');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (27,61,'RoomCreate');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (28,61,'RoomView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (29,61,'ReservationView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (30,61,'CustomerView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (41,81,'RoomView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (42,81,'ReservationView');
Insert into MYHOTELDATA.APPUSERPERMISSION (APPUSERPERMISSIONID,APPUSERID,USERPERMISSION) values (43,81,'CustomerView');
REM INSERTING into MYHOTELDATA.CUSTOMER
SET DEFINE OFF;
Insert into MYHOTELDATA.CUSTOMER (CUSTOMERID,ISHIDDEN,CUSTOMERCODE,CUSTOMERTYPE,CUSTOMERNAME,SEX,DOB,PHONE,PASSPORTNUMBER,COUNTRY) values (40,1,'Cus001','Couples','Shary','Female','Thursday, June 17, 1999','555-668-899','P2466788944','USA');
Insert into MYHOTELDATA.CUSTOMER (CUSTOMERID,ISHIDDEN,CUSTOMERCODE,CUSTOMERTYPE,CUSTOMERNAME,SEX,DOB,PHONE,PASSPORTNUMBER,COUNTRY) values (41,1,'Cus002','Family Group','Tim','Male','Sunday, September 5, 1999','555-333-444','P0943435522','UK');
Insert into MYHOTELDATA.CUSTOMER (CUSTOMERID,ISHIDDEN,CUSTOMERCODE,CUSTOMERTYPE,CUSTOMERNAME,SEX,DOB,PHONE,PASSPORTNUMBER,COUNTRY) values (43,1,'Cus003','Couples','Sothearith','Male','Monday, July 2, 2001','0962385003','P09745358544','Cambodia');
Insert into MYHOTELDATA.CUSTOMER (CUSTOMERID,ISHIDDEN,CUSTOMERCODE,CUSTOMERTYPE,CUSTOMERNAME,SEX,DOB,PHONE,PASSPORTNUMBER,COUNTRY) values (121,1,'Cus004','Solo Traveler','Tedd','Male','Wednesday, February 8, 1995','5567-553-443','P04935332344','Canada');
Insert into MYHOTELDATA.CUSTOMER (CUSTOMERID,ISHIDDEN,CUSTOMERCODE,CUSTOMERTYPE,CUSTOMERNAME,SEX,DOB,PHONE,PASSPORTNUMBER,COUNTRY) values (122,1,'Cus005','Couples','Hello','Male','Saturday, June 8, 2002','344-454-5344','P03423423434','Cambodia');
REM INSERTING into MYHOTELDATA.RESERVATION
SET DEFINE OFF;
Insert into MYHOTELDATA.RESERVATION (RESERVATIONID,ISHIDDEN,CUSTOMERID,CHECKINDATE,ISCHECKIN,NUMBEROFDAY,NUMBEROFADULT,NUMBEROFCHILDRENS,MEMO,CHECKOUTDATE,ISPAY,ISCHECKOUT,APPUSERID) values (68,0,122,to_date('08-JUN-24','DD-MON-RR'),'Already',0,3,1,'free drink',to_date('11-JUN-24','DD-MON-RR'),'Not Yet','Not Yet',null);
Insert into MYHOTELDATA.RESERVATION (RESERVATIONID,ISHIDDEN,CUSTOMERID,CHECKINDATE,ISCHECKIN,NUMBEROFDAY,NUMBEROFADULT,NUMBEROFCHILDRENS,MEMO,CHECKOUTDATE,ISPAY,ISCHECKOUT,APPUSERID) values (66,0,121,to_date('09-JUN-24','DD-MON-RR'),'Note Yet',0,6,0,'free drink',to_date('11-JUN-24','DD-MON-RR'),'Already','Not Yet',null);
Insert into MYHOTELDATA.RESERVATION (RESERVATIONID,ISHIDDEN,CUSTOMERID,CHECKINDATE,ISCHECKIN,NUMBEROFDAY,NUMBEROFADULT,NUMBEROFCHILDRENS,MEMO,CHECKOUTDATE,ISPAY,ISCHECKOUT,APPUSERID) values (64,0,40,to_date('07-JUN-24','DD-MON-RR'),'Already',0,3,3,'tt',to_date('09-JUN-24','DD-MON-RR'),'Not Yet','Already',null);
Insert into MYHOTELDATA.RESERVATION (RESERVATIONID,ISHIDDEN,CUSTOMERID,CHECKINDATE,ISCHECKIN,NUMBEROFDAY,NUMBEROFADULT,NUMBEROFCHILDRENS,MEMO,CHECKOUTDATE,ISPAY,ISCHECKOUT,APPUSERID) values (65,0,43,to_date('07-JUN-24','DD-MON-RR'),'Already',0,4,1,'rr',to_date('11-JUN-24','DD-MON-RR'),'Already','Already',null);
REM INSERTING into MYHOTELDATA.RESERVATIONDETAIL
SET DEFINE OFF;
Insert into MYHOTELDATA.RESERVATIONDETAIL (RESERVATIONDETAILID,RESERVATIONID,ROOMID,ROOMTYPE,STATUS,QUANTITY,PRICE) values (135,66,21,'Triple Room','Available',3,70);
Insert into MYHOTELDATA.RESERVATIONDETAIL (RESERVATIONDETAILID,RESERVATIONID,ROOMID,ROOMTYPE,STATUS,QUANTITY,PRICE) values (139,68,21,'Triple Room','Available',4,70);
Insert into MYHOTELDATA.RESERVATIONDETAIL (RESERVATIONDETAILID,RESERVATIONID,ROOMID,ROOMTYPE,STATUS,QUANTITY,PRICE) values (134,65,2,'Double Room','Available',5,50);
Insert into MYHOTELDATA.RESERVATIONDETAIL (RESERVATIONDETAILID,RESERVATIONID,ROOMID,ROOMTYPE,STATUS,QUANTITY,PRICE) values (133,64,1,'Singel Room','Available',3,30);
REM INSERTING into MYHOTELDATA.ROOM
SET DEFINE OFF;
Insert into MYHOTELDATA.ROOM (ROOMID,ISHIDDEN,ROOMNAME,ROOMTYPE,STATUS,QUANTITY,PRICE) values (2,0,'R002','Double Room','Available',-5,50);
Insert into MYHOTELDATA.ROOM (ROOMID,ISHIDDEN,ROOMNAME,ROOMTYPE,STATUS,QUANTITY,PRICE) values (21,0,'R003','Triple Room','Available',-7,70);
Insert into MYHOTELDATA.ROOM (ROOMID,ISHIDDEN,ROOMNAME,ROOMTYPE,STATUS,QUANTITY,PRICE) values (1,0,'R001','Singel Room','Available',-3,30);
Insert into MYHOTELDATA.ROOM (ROOMID,ISHIDDEN,ROOMNAME,ROOMTYPE,STATUS,QUANTITY,PRICE) values (25,0,'sdf','Singel Room','Available',0,30);
--------------------------------------------------------
--  DDL for Index APPUSER_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "MYHOTELDATA"."APPUSER_PK" ON "MYHOTELDATA"."APPUSER" ("APPUSERID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Trigger TRG_STOCK_RESERVATION_DELETE
--------------------------------------------------------

  CREATE OR REPLACE EDITIONABLE TRIGGER "MYHOTELDATA"."TRG_STOCK_RESERVATION_DELETE" 
After Delete
On ReservationDetail
For Each Row
Declare
Begin
Update Room Set Room.Quantity = Room.Quantity + :Old.Quantity
Where Room.RoomId = :Old.RoomId;
End;
/
ALTER TRIGGER "MYHOTELDATA"."TRG_STOCK_RESERVATION_DELETE" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_STOCK_RESERVATION_INSERT
--------------------------------------------------------

  CREATE OR REPLACE EDITIONABLE TRIGGER "MYHOTELDATA"."TRG_STOCK_RESERVATION_INSERT" 
After Insert
On ReservationDetail
For Each Row
Declare
Begin
Update Room Set Room.Quantity = Room.Quantity - :New.Quantity
Where Room.RoomId = :New.RoomId;
End;
/
ALTER TRIGGER "MYHOTELDATA"."TRG_STOCK_RESERVATION_INSERT" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_STOCK_RESERVATION_UPDATE
--------------------------------------------------------

  CREATE OR REPLACE EDITIONABLE TRIGGER "MYHOTELDATA"."TRG_STOCK_RESERVATION_UPDATE" 
After Update
On ReservationDetail
For Each Row
Declare
Begin
Update Room Set Room.Quantity = Room.Quantity - (:New.Quantity-:Old.Quantity)
Where Room.RoomId = :New.RoomId And Room.RoomId = :Old.RoomId And
:New.Quantity <> :Old.Quantity;
End;
/
ALTER TRIGGER "MYHOTELDATA"."TRG_STOCK_RESERVATION_UPDATE" ENABLE;
--------------------------------------------------------
--  DDL for Procedure APPUSERADD
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."APPUSERADD" (
    P_UserName      AppUser.UserName%Type,
    P_Password  AppUser.Password%Type

)
As
Begin 
    Insert Into AppUser(UserName,Password)
    Values(P_UserName,P_Password);
    commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure APPUSERDELETE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."APPUSERDELETE" (
    P_AppUserID     AppUser.AppUserId%Type
)
As
Begin
    Delete From AppUser Where AppUserId = P_AppUserId;
    commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure APPUSERGET
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."APPUSERGET" (
    P_AppUserId     AppUser.AppUserId%Type Default 0
)
As 
    C_AppUser   Sys_RefCursor;
Begin
    If(P_AppUserId=0)Then
        Open C_AppUser For Select * From AppUser;
    Else
        Open C_AppUser For Select * From AppUser Where AppUserId=P_AppUserId;
    End If;
    Commit;
    DBMS_SQL.return_result(C_AppUser);
End;

/
--------------------------------------------------------
--  DDL for Procedure APPUSERLOGIN
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."APPUSERLOGIN" 
(
P_Username AppUser.Username%Type,
P_Password AppUser.Password%Type

)
As
C_AppUser Sys_RefCursor;
Begin
Open C_AppUser For Select * From AppUser Where Upper(Username) = Upper(P_Username) And
Password = P_Password;
DBMS_SQL.return_result(C_AppUser);
End;

/
--------------------------------------------------------
--  DDL for Procedure APPUSERPERMISSIONADD
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."APPUSERPERMISSIONADD" 
(
P_AppUserId AppUserPermission.AppUserId%Type,
P_UserPermission AppUserPermission.UserPermission%Type
)
As
Begin
Insert Into AppUserPermission(AppUserId,UserPermission)
Values(P_AppUserId,P_UserPermission);
Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure APPUSERPERMISSIONDELETE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."APPUSERPERMISSIONDELETE" 
(
P_AppUserId AppUserPermission.AppUserId%Type
)
As
Begin
Delete From AppUserPermission Where AppUserId = P_AppUserId;
Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure APPUSERPERMISSIONGET
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."APPUSERPERMISSIONGET" 
(
P_AppUserId AppUserPermission.AppUserId%Type Default 0
)
As
C_AppUserPermission Sys_RefCursor;
Begin
If P_AppUserId = 0 Then
Open C_AppUserPermission For Select * From AppUserPermission;
Else
Open C_AppUserPermission For Select * From AppUserPermission Where AppUserId =
P_AppUserId;
End If;
DBMS_SQL.return_result(C_AppUserPermission);
End;

/
--------------------------------------------------------
--  DDL for Procedure APPUSERUPDATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."APPUSERUPDATE" (
    P_AppUserId     AppUser.AppUserId%Type,
    P_UserName      AppUser.UserName%Type,
    P_Password  AppUser.Password%Type
)
As
Begin 
    Update AppUser
    Set 
    UserName = P_UserName,
    Password = P_Password
    Where AppUserId = P_AppUserId ;
    Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure CUSTOMERADD
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."CUSTOMERADD" (
    
    P_CustomerCode      Customer.CustomerCode%Type,
    P_CustomerType             Customer.CustomerType%Type,
    P_CustomerName             Customer.CustomerName%Type,
    P_Sex                       Customer.Sex%Type,
    P_Dob                       Customer.Dob%Type,
    P_Phone                     Customer.Phone%Type,
    P_PassportNumber           Customer.PassportNumber %Type,
    P_Country           Customer.Country%Type
   
)
As
Begin
    Insert Into Customer(CustomerCode,CustomerType,CustomerName,Sex,Dob,Phone,PassportNumber,Country) 
    Values(P_CustomerCode,P_CustomerType,P_CustomerName,P_Sex,P_Dob,P_Phone,P_PassportNumber,P_Country);
    Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure CUSTOMERDELETE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."CUSTOMERDELETE" (
    P_CustomerId    Customer.CustomerID%Type
)
As
begin
    Delete From Customer Where CustomerId = P_CustomerId;
    Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure CUSTOMERGET
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."CUSTOMERGET" 
(
    P_CustomerId    Customer.CustomerId%Type Default 0
)
As
    C_Customer Sys_RefCursor;
Begin
    If(P_CustomerId = 0) Then
        Open C_Customer For Select * From Customer;
    Else
        Open C_Customer For Select * From Customer Where CustomerId = P_CustomerId;
    End If;
    DBMS_SQL.return_result(C_Customer);
End;

/
--------------------------------------------------------
--  DDL for Procedure CUSTOMERUPDATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."CUSTOMERUPDATE" (
   
    P_CustomerId        Customer.CustomerId%Type,
    P_CustomerCode      Customer.CustomerCode%Type,
    P_CustomerType             Customer.CustomerType%Type,
    P_CustomerName             Customer.CustomerName%Type,
    P_Sex                       Customer.Sex%Type,
    P_Dob                       Customer.Dob%Type,
    P_Phone                     Customer.Phone%Type,
    P_PassportNumber           Customer.PassportNumber%Type,
    P_Country                  Customer.Country%Type
   
)
As 
Begin
    Update Customer
    Set 
    
    CustomerCode=P_CustomerCode,
    CustomerType=P_CustomerType,
    CustomerName = P_CustomerName,
    Sex=P_Sex,
    Dob=P_Dob,
    Phone=P_Phone,
    PassportNumber = P_PassportNumber,
    Country = P_Country


    Where CustomerId=P_CustomerId;
    Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure RESERVATIONADD
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."RESERVATIONADD" (
P_CustomerId Reservation.CustomerId%Type,
P_CheckInDate Reservation.CheckInDate%Type,
P_IsCheckIn Reservation.IsCheckIn%Type,
P_NumberOfDay Reservation.NumberOfDay%Type,
P_NumberOfAdult Reservation.NumberOfAdult%Type,
P_NumberOfChildrens Reservation.NumberOfChildrens%Type,
P_Memo Reservation.Memo%Type,
P_CheckOutDate Reservation.CheckInDate%Type,
P_IsPay Reservation.IsPay%Type,
P_IsCheckOut Reservation.IsCheckOut%Type,
P_AppUserId Reservation.AppUserId%Type,
P_ReservationId Out Reservation.ReservationId%Type
)
As
Begin
Insert Into Reservation(CustomerId,CheckInDate,IsCheckIn,NumberOfDay,NumberOfAdult,NumberOfChildrens,Memo,CheckOutDate,IsPay,IsCheckOut,AppUserId)
Values(P_CustomerId,P_CheckInDate,P_IsCheckIn,P_NumberOfDay,P_NumberOfAdult,P_NumberOfChildrens,P_Memo,P_CheckOutDate,P_IsPay,P_IsCheckOut,P_AppUserId)
Returning ReservationId Into P_ReservationId;
Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure RESERVATIONDELETE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."RESERVATIONDELETE" (
    P_ReservationId        Reservation.ReservationId%Type 
)
As
Begin 
    Delete From Reservation Where ReservationId = P_ReservationId;
    Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure RESERVATIONDETAILADD
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."RESERVATIONDETAILADD" 
(
P_ReservationId  ReservationDetail.ReservationId%Type,
P_RoomId  ReservationDetail.RoomId%Type,
P_RoomType  ReservationDetail.RoomType%Type,
P_Status  ReservationDetail.Status%Type,
P_Quantity  ReservationDetail.Quantity%Type,
P_Price  ReservationDetail.Price%Type

)
As
Begin
Insert Into ReservationDetail(ReservationId,RoomId,RoomType,Status,Quantity,Price)
Values(P_ReservationId,P_RoomId,P_RoomType,P_Status,P_Quantity,P_Price);
Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure RESERVATIONDETAILDELETE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."RESERVATIONDETAILDELETE" 
(
P_ReservationId ReservationDetail.ReservationId%Type
)
As
Begin
Delete From ReservationDetail Where ReservationId = P_ReservationId;
Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure RESERVATIONDETAILGET
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."RESERVATIONDETAILGET" 
(
P_ReservationId Reservation.ReservationId%Type Default 0
)
As
C_ReservationDetail Sys_RefCursor;
Begin
If P_ReservationId = 0 Then
Open C_ReservationDetail For Select
ReservationDetailId,ReservationId,RoomId,RoomType,Status,Quantity,Price,Quantity * Price As Amount From
ReservationDetail;
Else
Open C_ReservationDetail For Select
ReservationDetailId,ReservationId,RoomId,RoomType,Status,Quantity,Price,Quantity * Price As Amount From
ReservationDetail Where ReservationId = P_ReservationId;
End If;
DBMS_SQL.return_result(C_ReservationDetail);
End;

/
--------------------------------------------------------
--  DDL for Procedure RESERVATIONDETAILUPDATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."RESERVATIONDETAILUPDATE" 
(
P_ReservationDetailId  ReservationDetail.ReservationDetailId%Type,
P_ReservationId  ReservationDetail.ReservationId%Type,
P_RoomId  ReservationDetail.RoomId%Type,
P_RoomType  ReservationDetail.RoomType%Type,
P_Status  ReservationDetail.Status%Type,
P_Quantity  ReservationDetail.Quantity%Type,
P_Price  ReservationDetail.Price%Type

)
As
Begin
Update ReservationDetail Set
ReservationId = P_ReservationId,
RoomId = P_RoomId,
RoomType = P_RoomType,
Status=P_Status,
Quantity = P_Quantity,
Price = P_Price
Where ReservationDetailId = P_ReservationDetailId;
Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure RESERVATIONGET
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."RESERVATIONGET" (
    P_ReservationId        Reservation.ReservationId%Type Default 0
)
As 
    C_Reservation  Sys_RefCursor;
Begin 
    If(P_ReservationId=0) Then
        Open C_Reservation For Select * From Reservation;
    Else
        Open C_Reservation For Select * From Reservation Where ReservationId = P_ReservationId;
    End If;
    DBMS_SQL.return_result(C_Reservation);
End;

/
--------------------------------------------------------
--  DDL for Procedure RESERVATIONUPDATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."RESERVATIONUPDATE" (
    P_ReservationId Reservation.ReservationId%Type,
    P_CustomerId Reservation.CustomerId%Type,
    P_CheckInDate Reservation.CheckInDate%Type,
    P_IsCheckIn Reservation.IsCheckIn%Type,
    P_NumberOfDay Reservation.NumberOfDay%Type,
    P_NumberOfAdult Reservation.NumberOfAdult%Type,
    P_NumberOfChildrens Reservation.NumberOfChildrens%Type,
    P_Memo Reservation.Memo%Type,
    P_CheckOutDate Reservation.CheckInDate%Type,
    P_IsPay Reservation.IsPay%Type,
    P_IsCheckOut Reservation.IsCheckOut%Type,
    P_AppUserId Reservation.AppUserId%Type
)
As 
Begin
    Update Reservation
    Set
    CustomerId=P_CustomerId,
    CheckInDate=P_CheckInDate,
    IsCheckIn= P_IsCheckIn,
    NumberOfDay=P_NumberOfDay,
    NumberOfAdult=P_NumberOfAdult,
    NumberOfChildrens=P_NumberOfChildrens,
    Memo=P_Memo,
    CheckOutDate=P_CheckOutDate,
    IsPay= P_IsPay,
    IsCheckOut=P_IsCheckOut,
    AppUserId=P_AppUserId

    Where ReservationId = P_ReservationId;
    Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure ROOMADD
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."ROOMADD" (
    P_RoomName  Room.RoomName %Type,
    P_RoomType   Room.RoomType%Type,
    P_Status Room.Status%Type,
    P_Quantity  Room.Quantity%Type,
    P_Price  Room.Price%Type,
    P_Image Room.Image%Type
    
)
As 
Begin
    Insert Into Room (RoomName,RoomType,Status,Quantity,Price,Image)
    Values (P_RoomName,P_RoomType,P_Status,P_Quantity,P_Price,P_Image);
    commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure ROOMDELETE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."ROOMDELETE" (
    P_RoomId    Room.RoomId%Type
)
As
begin
    Delete From Room Where RoomId = P_RoomId;
    Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure ROOMGET
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."ROOMGET" 
(
    P_RoomId    Room.RoomId%Type Default 0
)
As
    C_Room Sys_RefCursor;
Begin
    If(P_RoomId = 0) Then
        Open C_Room For Select * From Room;
    Else
        Open C_Room For Select * From Room Where RoomId = P_RoomId;
    End If;
    DBMS_SQL.return_result(C_Room);
End;

/
--------------------------------------------------------
--  DDL for Procedure ROOMUPDATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "MYHOTELDATA"."ROOMUPDATE" (
    P_RoomId        Room.RoomId%Type,
    P_RoomName  Room.RoomName %Type,
    P_RoomType   Room.RoomType%Type,
    P_Status Room.Status%Type,
    P_Quantity  Room.Quantity%Type,
    P_Price  Room.Price%Type,
    P_Image Room.Image%Type
    
   
)
As 
Begin
    Update Room
    Set 
    RoomName=P_RoomName,
    RoomType=P_RoomType,
    Status =P_Status,
    Quantity=P_Quantity,
    Price = P_Price,
    Image=P_Image
    


    Where RoomId=P_RoomId;
    Commit;
End;

/
--------------------------------------------------------
--  Constraints for Table RESERVATIONDETAIL
--------------------------------------------------------

  ALTER TABLE "MYHOTELDATA"."RESERVATIONDETAIL" MODIFY ("RESERVATIONDETAILID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table ROOM
--------------------------------------------------------

  ALTER TABLE "MYHOTELDATA"."ROOM" MODIFY ("ROOMID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table RESERVATION
--------------------------------------------------------

  ALTER TABLE "MYHOTELDATA"."RESERVATION" MODIFY ("RESERVATIONID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table APPUSER
--------------------------------------------------------

  ALTER TABLE "MYHOTELDATA"."APPUSER" MODIFY ("APPUSERID" NOT NULL ENABLE);
  ALTER TABLE "MYHOTELDATA"."APPUSER" ADD CONSTRAINT "APPUSER_PK" PRIMARY KEY ("APPUSERID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table APPUSERPERMISSION
--------------------------------------------------------

  ALTER TABLE "MYHOTELDATA"."APPUSERPERMISSION" MODIFY ("APPUSERPERMISSIONID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table CUSTOMER
--------------------------------------------------------

  ALTER TABLE "MYHOTELDATA"."CUSTOMER" MODIFY ("CUSTOMERID" NOT NULL ENABLE);
