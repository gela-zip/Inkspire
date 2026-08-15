-- This CLP file was created using DB2LOOK Version "11.1" 
-- Timestamp: 8/15/2026 12:56:56 PM
-- Database Name: INKSPIRE       
-- Database Manager Version: DB2/NT64 Version 11.1.4.4     
-- Database Codepage: 1208
-- Database Collating Sequence is: SYSTEM_1252
-- Alternate collating sequence(alt_collate): null
-- varchar2 compatibility(varchar2_compat): OFF


CONNECT TO INKSPIRE;

------------------------------------------------
-- DDL Statements for Schemas
------------------------------------------------

-- Running the DDL below will explicitly create a schema in the
-- new database that corresponds to an implicitly created schema
-- in the original database.

CREATE SCHEMA "DB2ADMIN";



------------------------------------------------
-- DDL Statements for Table "DB2ADMIN"."EMPLOYEE"
------------------------------------------------
 

CREATE TABLE "DB2ADMIN"."EMPLOYEE"  (
		  "EMPID" INTEGER NOT NULL , 
		  "LNAME" VARCHAR(30 OCTETS) , 
		  "FNAME" VARCHAR(30 OCTETS) , 
		  "MINITIAL" CHAR(1 OCTETS) , 
		  "HOMEADDR" VARCHAR(30 OCTETS) , 
		  "MOBNUM" VARCHAR(11 OCTETS) , 
		  "EMPTYPE" CHAR(1 OCTETS) )   
		 IN "USERSPACE1"  
		 ORGANIZE BY ROW; 


-- DDL Statements for Primary Key on Table "DB2ADMIN"."EMPLOYEE"

ALTER TABLE "DB2ADMIN"."EMPLOYEE" 
	ADD PRIMARY KEY
		("EMPID");


------------------------------------------------
-- DDL Statements for Table "DB2ADMIN"."CUSTOMER"
------------------------------------------------
 

CREATE TABLE "DB2ADMIN"."CUSTOMER"  (
		  "CUSTID" INTEGER NOT NULL , 
		  "LNAME" VARCHAR(30 OCTETS) , 
		  "FNAME" VARCHAR(30 OCTETS) , 
		  "MINITIAL" CHAR(1 OCTETS) , 
		  "CURRDISCOUNT" DECIMAL(3,2) WITH DEFAULT 0.00 , 
		  "LASTPURCHASEDATE" DATE , 
		  "DISCOUNTEXPIRYDATE" DATE , 
		  "POINTBAL" INTEGER WITH DEFAULT 0 , 
		  "CARRYOVERAMT" DECIMAL(5,2) WITH DEFAULT 0.00 )   
		 IN "USERSPACE1"  
		 ORGANIZE BY ROW; 


-- DDL Statements for Primary Key on Table "DB2ADMIN"."CUSTOMER"

ALTER TABLE "DB2ADMIN"."CUSTOMER" 
	ADD PRIMARY KEY
		("CUSTID");


------------------------------------------------
-- DDL Statements for Table "DB2ADMIN"."ITEM"
------------------------------------------------
 

CREATE TABLE "DB2ADMIN"."ITEM"  (
		  "ITEMNUM" INTEGER NOT NULL , 
		  "ITEMNAME" VARCHAR(100 OCTETS) , 
		  "COSTPRICE" DECIMAL(7,2) , 
		  "SELLINGPRICE" DECIMAL(7,2) , 
		  "MARKUP" DECIMAL(3,2) , 
		  "STOCKONHAND" INTEGER )   
		 IN "USERSPACE1"  
		 ORGANIZE BY ROW; 


-- DDL Statements for Primary Key on Table "DB2ADMIN"."ITEM"

ALTER TABLE "DB2ADMIN"."ITEM" 
	ADD PRIMARY KEY
		("ITEMNUM");


------------------------------------------------
-- DDL Statements for Table "DB2ADMIN"."SALES_TRANS"
------------------------------------------------
 

CREATE TABLE "DB2ADMIN"."SALES_TRANS"  (
		  "SALESORNUM" INTEGER NOT NULL , 
		  "CUSTID" INTEGER , 
		  "EMPID" INTEGER , 
		  "SALEDATE" DATE , 
		  "DISCAMT" DECIMAL(7,2) WITH DEFAULT 0.00 , 
		  "GRANDTOTAL" DECIMAL(7,2) WITH DEFAULT 0.00 )   
		 IN "USERSPACE1"  
		 ORGANIZE BY ROW; 


-- DDL Statements for Primary Key on Table "DB2ADMIN"."SALES_TRANS"

ALTER TABLE "DB2ADMIN"."SALES_TRANS" 
	ADD PRIMARY KEY
		("SALESORNUM");


------------------------------------------------
-- DDL Statements for Table "DB2ADMIN"."SALES_LINE_ITEM"
------------------------------------------------
 

CREATE TABLE "DB2ADMIN"."SALES_LINE_ITEM"  (
		  "SALESORNUM" INTEGER NOT NULL , 
		  "ITEMNUM" INTEGER NOT NULL , 
		  "SALESLINENO" INTEGER , 
		  "QTY" INTEGER WITH DEFAULT 0 , 
		  "PRICE" DECIMAL(7,2) , 
		  "SUBTOTAL" DECIMAL(7,2) WITH DEFAULT 0.00 )   
		 IN "USERSPACE1"  
		 ORGANIZE BY ROW; 


-- DDL Statements for Primary Key on Table "DB2ADMIN"."SALES_LINE_ITEM"

ALTER TABLE "DB2ADMIN"."SALES_LINE_ITEM" 
	ADD PRIMARY KEY
		("SALESORNUM",
		 "ITEMNUM");


------------------------------------------------
-- DDL Statements for Table "DB2ADMIN"."CUST_AUDIT"
------------------------------------------------
 

CREATE TABLE "DB2ADMIN"."CUST_AUDIT"  (
		  "Cust_Log" INTEGER NOT NULL GENERATED ALWAYS AS IDENTITY (  
		    START WITH +1  
		    INCREMENT BY +1  
		    MINVALUE +1  
		    MAXVALUE +2147483647  
		    NO CYCLE  
		    CACHE 20  
		    NO ORDER ) , 
		  "Remarks" VARCHAR(200 OCTETS) )   
		 IN "USERSPACE1"  
		 ORGANIZE BY ROW; 


-- DDL Statements for Primary Key on Table "DB2ADMIN"."CUST_AUDIT"

ALTER TABLE "DB2ADMIN"."CUST_AUDIT" 
	ADD PRIMARY KEY
		("Cust_Log");


------------------------------------------------
-- DDL Statements for Table "DB2ADMIN"."EMP_AUDIT"
------------------------------------------------
 

CREATE TABLE "DB2ADMIN"."EMP_AUDIT"  (
		  "Emp_Log" INTEGER NOT NULL GENERATED ALWAYS AS IDENTITY (  
		    START WITH +1  
		    INCREMENT BY +1  
		    MINVALUE -2147483648  
		    MAXVALUE +2147483647  
		    NO CYCLE  
		    CACHE 20  
		    NO ORDER ) , 
		  "Remarks" VARCHAR(300 OCTETS) )   
		 IN "USERSPACE1"  
		 ORGANIZE BY ROW; 


-- DDL Statements for Primary Key on Table "DB2ADMIN"."EMP_AUDIT"

ALTER TABLE "DB2ADMIN"."EMP_AUDIT" 
	ADD PRIMARY KEY
		("Emp_Log");


------------------------------------------------
-- DDL Statements for Table "DB2ADMIN"."ITEM_AUDIT"
------------------------------------------------
 

CREATE TABLE "DB2ADMIN"."ITEM_AUDIT"  (
		  "Item_Log" INTEGER NOT NULL GENERATED ALWAYS AS IDENTITY (  
		    START WITH +1  
		    INCREMENT BY +1  
		    MINVALUE -2147483648  
		    MAXVALUE +2147483647  
		    NO CYCLE  
		    CACHE 20  
		    NO ORDER ) , 
		  "Remarks" VARCHAR(200 OCTETS) )   
		 IN "USERSPACE1"  
		 ORGANIZE BY ROW; 


-- DDL Statements for Primary Key on Table "DB2ADMIN"."ITEM_AUDIT"

ALTER TABLE "DB2ADMIN"."ITEM_AUDIT" 
	ADD PRIMARY KEY
		("Item_Log");


------------------------------------------------
-- DDL Statements for Table "DB2ADMIN"."SALES_AUDIT"
------------------------------------------------
 

CREATE TABLE "DB2ADMIN"."SALES_AUDIT"  (
		  "Sales_log" INTEGER NOT NULL GENERATED ALWAYS AS IDENTITY (  
		    START WITH +1  
		    INCREMENT BY +1  
		    MINVALUE -2147483648  
		    MAXVALUE +2147483647  
		    NO CYCLE  
		    CACHE 20  
		    NO ORDER ) , 
		  "Remarks" VARCHAR(200 OCTETS) )   
		 IN "USERSPACE1"  
		 ORGANIZE BY ROW; 


-- DDL Statements for Primary Key on Table "DB2ADMIN"."SALES_AUDIT"

ALTER TABLE "DB2ADMIN"."SALES_AUDIT" 
	ADD PRIMARY KEY
		("Sales_log");


-- DDL Statements for Check Constraints on Table "DB2ADMIN"."EMPLOYEE"

SET SYSIBM.NLS_STRING_UNITS = 'SYSTEM';

ALTER TABLE "DB2ADMIN"."EMPLOYEE" 
	ADD CONSTRAINT "SQL260810163215480" CHECK 
		(EMPID between 1000 and 2000)
	ENFORCED
	ENABLE QUERY OPTIMIZATION;

-- DDL Statements for Check Constraints on Table "DB2ADMIN"."CUSTOMER"

SET SYSIBM.NLS_STRING_UNITS = 'SYSTEM';

ALTER TABLE "DB2ADMIN"."CUSTOMER" 
	ADD CONSTRAINT "DISC_CHECK" CHECK 
		(CURRDISCOUNT in (0.00, 0.08,0.13, 0.15))
	ENFORCED
	ENABLE QUERY OPTIMIZATION;

-- DDL Statements for Check Constraints on Table "DB2ADMIN"."CUSTOMER"

SET SYSIBM.NLS_STRING_UNITS = 'SYSTEM';

ALTER TABLE "DB2ADMIN"."CUSTOMER" 
	ADD CONSTRAINT "SQL260810190302430" CHECK 
		(CUSTID between 2000 and 3000)
	ENFORCED
	ENABLE QUERY OPTIMIZATION;

-- DDL Statements for Check Constraints on Table "DB2ADMIN"."CUSTOMER"

SET SYSIBM.NLS_STRING_UNITS = 'SYSTEM';

ALTER TABLE "DB2ADMIN"."CUSTOMER" 
	ADD CONSTRAINT "SQL260810190302440" CHECK 
		(CARRYOVERAMT <300.00)
	ENFORCED
	ENABLE QUERY OPTIMIZATION;

-- DDL Statements for Check Constraints on Table "DB2ADMIN"."ITEM"

SET SYSIBM.NLS_STRING_UNITS = 'SYSTEM';

ALTER TABLE "DB2ADMIN"."ITEM" 
	ADD CONSTRAINT "SQL260812163020790" CHECK 
		(ITEMNUM between 3000 and 4000)
	ENFORCED
	ENABLE QUERY OPTIMIZATION;

-- DDL Statements for Check Constraints on Table "DB2ADMIN"."ITEM"

SET SYSIBM.NLS_STRING_UNITS = 'SYSTEM';

ALTER TABLE "DB2ADMIN"."ITEM" 
	ADD CONSTRAINT "UP_CHECK" CHECK 
		(MARKUP in (0.40,0.70,1.00))
	ENFORCED
	ENABLE QUERY OPTIMIZATION;

-- DDL Statements for Foreign Keys on Table "DB2ADMIN"."SALES_TRANS"

ALTER TABLE "DB2ADMIN"."SALES_TRANS" 
	ADD CONSTRAINT "FK_SALES_CUST" FOREIGN KEY
		("CUSTID")
	REFERENCES "DB2ADMIN"."CUSTOMER"
		("CUSTID")
	ON DELETE RESTRICT
	ON UPDATE NO ACTION
	ENFORCED
	ENABLE QUERY OPTIMIZATION;

ALTER TABLE "DB2ADMIN"."SALES_TRANS" 
	ADD CONSTRAINT "FK_SALES_EMP" FOREIGN KEY
		("EMPID")
	REFERENCES "DB2ADMIN"."EMPLOYEE"
		("EMPID")
	ON DELETE RESTRICT
	ON UPDATE NO ACTION
	ENFORCED
	ENABLE QUERY OPTIMIZATION;

-- DDL Statements for Check Constraints on Table "DB2ADMIN"."SALES_TRANS"

SET SYSIBM.NLS_STRING_UNITS = 'SYSTEM';

ALTER TABLE "DB2ADMIN"."SALES_TRANS" 
	ADD CONSTRAINT "SQL260812163342320" CHECK 
		(SALESORNUM between 5000 and 6000)
	ENFORCED
	ENABLE QUERY OPTIMIZATION;

-- DDL Statements for Foreign Keys on Table "DB2ADMIN"."SALES_LINE_ITEM"

ALTER TABLE "DB2ADMIN"."SALES_LINE_ITEM" 
	ADD CONSTRAINT "FK_SLI_ITEM" FOREIGN KEY
		("ITEMNUM")
	REFERENCES "DB2ADMIN"."ITEM"
		("ITEMNUM")
	ON DELETE RESTRICT
	ON UPDATE NO ACTION
	ENFORCED
	ENABLE QUERY OPTIMIZATION;

ALTER TABLE "DB2ADMIN"."SALES_LINE_ITEM" 
	ADD CONSTRAINT "FK_SLI_SALES" FOREIGN KEY
		("SALESORNUM")
	REFERENCES "DB2ADMIN"."SALES_TRANS"
		("SALESORNUM")
	ON DELETE CASCADE
	ON UPDATE NO ACTION
	ENFORCED
	ENABLE QUERY OPTIMIZATION;

-- DDL Statements for Check Constraints on Table "DB2ADMIN"."SALES_LINE_ITEM"

SET SYSIBM.NLS_STRING_UNITS = 'SYSTEM';

ALTER TABLE "DB2ADMIN"."SALES_LINE_ITEM" 
	ADD CONSTRAINT "ITEM_QTY" CHECK 
		(QTY>0)
	ENFORCED
	ENABLE QUERY OPTIMIZATION;








COMMIT WORK;

CONNECT RESET;

TERMINATE;

