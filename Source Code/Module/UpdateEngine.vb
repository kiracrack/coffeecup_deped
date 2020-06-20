Imports DevExpress.XtraEditors
Imports System.IO
Imports MySql.Data.MySqlClient

Module UpdateEngine
    Dim engineupdated As Boolean = False
    Dim features As String = ""

    Public Sub SystemDatabaseUpdater()
        On Error Resume Next
        Dim updateVersion As String = "" : Dim updateDescription As String = ""
        'updateVersion = CDate("05/02/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    'First version run - Logs all update query
        '    com.CommandText = "CREATE TABLE  `tbldatabaseupdatelogs` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `databaseversion` date NOT NULL,  `dateupdate` datetime NOT NULL,  `appliedquery` text NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery()

        '    com.CommandText = "DROP TABLE IF EXISTS `tblsysteminfo`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "CREATE TABLE  `tblsysteminfo` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `databaseversion` date NOT NULL,  `dateupdate` datetime NOT NULL,  `features` text,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "CREATE TABLE  `tblproductfilter` (  `id` int(11) NOT NULL AUTO_INCREMENT,  `productid` varchar(10) NOT NULL DEFAULT '',  `userid` varchar(10) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)

        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("06/02/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "CREATE TABLE `tblclientfilter` (  `id` int(11) NOT NULL AUTO_INCREMENT,  `cifid` varchar(10) NOT NULL DEFAULT '',  `userid` varchar(10) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("18/03/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `prevquantity` DOUBLE NOT NULL default 0 AFTER `quantity`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblsalesfuelsold` ADD COLUMN `prevquantity` DOUBLE NOT NULL default 0 AFTER `quantity`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("15/04/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblpurchaseorder` ADD COLUMN `forwarded` BOOLEAN NOT NULL DEFAULT 0 AFTER `paymentrefnumber`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("19/04/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblpurchaseorder` ADD COLUMN `paymentrequested` BOOLEAN NOT NULL DEFAULT 0 AFTER `receivedby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("20/04/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `emailaddress` VARCHAR(200) AFTER `designation`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("23/04/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblonlinerequisitionsitem` DROP COLUMN `newvendor`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("24/04/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblrequisitions` CHANGE COLUMN `officedisbursement` `officelevel` TINYINT(1) NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblonlinerequisitions` CHANGE COLUMN `officedisbursement` `officelevel` TINYINT(1) NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblpurchaseorder` CHANGE COLUMN `officedisbursement` `officelevel` TINYINT(1) NOT NULL DEFAULT 0, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitions` ADD COLUMN `trnrefno` VARCHAR(45) AFTER `datedisapproved`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitionsitem` ADD COLUMN `trnrefno` VARCHAR(45) AFTER `verifieditem`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblpurchaseorderitem` MODIFY COLUMN `allocatedrefcode` VARCHAR(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("04/05/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblonlinerequisitions` ADD COLUMN `approved` BOOLEAN NOT NULL DEFAULT 0 AFTER `requesttrnby`, ADD COLUMN `approvedby` VARCHAR(45) AFTER `approved`, ADD COLUMN `dateapproved` DATETIME AFTER `approvedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblonlinerequisitions` ADD COLUMN `disapproved` BOOLEAN NOT NULL DEFAULT 0 AFTER `receivedby`, ADD COLUMN `disapprovedby` VARCHAR(45) AFTER `disapproved`, ADD COLUMN `datedisapproved` DATETIME AFTER `disapprovedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "DELETE FROM `tblonlinerequisitionsitem`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblonlinerequisitionsitem` MODIFY COLUMN `trnid` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("06/05/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    'com.CommandText = "DELETE FROM `tblglobalproducts`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblglobalproducts` MODIFY COLUMN `unit` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("07/05/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblapprovalhistory` ADD COLUMN `appdescription` VARCHAR(105) AFTER `approvaltype`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("08/05/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `lockedlogins` BOOLEAN NOT NULL DEFAULT 0 AFTER `creditrenew`,ADD COLUMN `lockeddescription` TEXT AFTER `lockedlogins`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("09/05/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblglobalvendor` ADD COLUMN `bankaccount` VARCHAR(45) AFTER `designation`, ADD COLUMN `accountnumber` VARCHAR(45) AFTER `bankaccount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("11/05/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblprocategory` ADD COLUMN `ffecode` VARCHAR(45) AFTER `inventorymethod`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblinventoryffe` MODIFY COLUMN `trnreference` VARCHAR(45) NOT NULL, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblinventoryffe` MODIFY COLUMN `acctableperson` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `allowbeggininginventory` BOOLEAN NOT NULL DEFAULT 0 AFTER `lockeddescription`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("10/06/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblprocategory` ADD COLUMN `prepaid` BOOLEAN NOT NULL DEFAULT 0 AFTER `ffecode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblonlinerequisitions` ADD COLUMN `disapprovedremarks` TEXT AFTER `datedisapproved`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    'com.CommandText = "ALTER TABLE `tblonlinerequisitions` DROP COLUMN `status`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblonlinerequisitions` ADD COLUMN `received` BOOLEAN NOT NULL DEFAULT 0 AFTER `remarks`, ADD COLUMN `datereceived` DATETIME AFTER `receivedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblonlinerequisitions` DROP COLUMN `appstatus`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblonlinerequisitions` DROP COLUMN `logs`, DROP COLUMN `remarks`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblonlinerequisitions` ADD COLUMN `isread` BOOLEAN NOT NULL DEFAULT 0 AFTER `disapprovedremarks`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("11/06/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    'com.CommandText = "ALTER TABLE `tblproductrequest` DROP COLUMN `status`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblproductrequest` CHANGE COLUMN `logs` `isread` BOOLEAN NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblproductrequest` ADD COLUMN `received` BOOLEAN NOT NULL DEFAULT 0 AFTER `daterequest`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblproductrequest` ADD COLUMN `cancelled` BOOLEAN NOT NULL DEFAULT 0 AFTER `received`, ADD COLUMN `cancelledby` VARCHAR(45) AFTER `cancelled`, ADD COLUMN `datecancelled` DATETIME AFTER `cancelledby`, ADD COLUMN `cancelledremarks` TEXT AFTER `datecancelled`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("15/06/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tbluserauthority` MODIFY COLUMN `authTitle` VARCHAR(145) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL, ADD COLUMN `pointofsale` BOOLEAN NOT NULL DEFAULT 0 AFTER `authapprover`, ADD COLUMN `pumpreading` BOOLEAN NOT NULL DEFAULT 0 AFTER `pointofsale`, ADD COLUMN `cashchange` BOOLEAN NOT NULL DEFAULT 0 AFTER `pumpreading`, ADD COLUMN `postexpense` BOOLEAN NOT NULL DEFAULT 0 AFTER `cashchange`, ADD COLUMN `othertransaction` BOOLEAN NOT NULL DEFAULT 0 AFTER `postexpense`, ADD COLUMN `requisition` BOOLEAN NOT NULL DEFAULT 0 AFTER `othertransaction`, ADD COLUMN `purchaseorder` BOOLEAN NOT NULL DEFAULT 0 AFTER `requisition`, ADD COLUMN `accountspayable` BOOLEAN NOT NULL DEFAULT 0 AFTER `purchaseorder`, ADD COLUMN `receivingofgoods` BOOLEAN NOT NULL DEFAULT 0 AFTER `accountspayable`, ADD COLUMN `requisitionmgt` BOOLEAN NOT NULL DEFAULT 0 AFTER `receivingofgoods`,ADD COLUMN `inventorymgt` BOOLEAN NOT NULL DEFAULT 0 AFTER `requisitionmgt`, ADD COLUMN `stockoutmgt` BOOLEAN NOT NULL DEFAULT 0 AFTER `inventorymgt`, ADD COLUMN `assetsmgt` BOOLEAN NOT NULL DEFAULT 0 AFTER `stockoutmgt`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `directapprovedpr` BOOLEAN NOT NULL DEFAULT 0 AFTER `archiveddir`, ADD COLUMN `directapprovedpo` BOOLEAN NOT NULL DEFAULT 0 AFTER `directapprovedpr`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "CREATE TABLE `tblrequisitionslogs` (  `pid` varchar(45) NOT NULL DEFAULT '',  `trnrefno` varchar(75) DEFAULT NULL,  `requestby` int(10) unsigned NOT NULL,  `officeid` varchar(10) NOT NULL,  `potypeid` varchar(10) NOT NULL,  `details` longtext,  `daterequest` datetime NOT NULL,  `officelevel` varchar(45) NOT NULL,  `priority` varchar(15) NOT NULL,  `withattachment` varchar(100) DEFAULT NULL,  `attachmentpath` varchar(100) DEFAULT NULL,  `requesttrnby` int(10) NOT NULL,  PRIMARY KEY (`pid`)) ENGINE=MyISAM DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "INSERT INTO `tblrequisitionslogs` (pid,trnrefno,requestby,officeid,potypeid,details,daterequest,officelevel,priority,withattachment,attachmentpath,requesttrnby) SELECT pid,trnrefno,requestby,officeid,potypeid,details,daterequest,if(officelevel=1,'BRANCH LEVEL','CORPORATE LEVEL'),priority,withattachment,'',requesttrnby FROM  `tblonlinerequisitions`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "INSERT INTO `tblrequisitionslogs` (pid,trnrefno,requestby,officeid,potypeid,details,daterequest,officelevel,priority,withattachment,attachmentpath,requesttrnby) SELECT pid,trnrefno,requestby,officeid,potypeid,details,daterequest,if(officelevel=1,'BRANCH LEVEL','CORPORATE LEVEL'),'Normal','','',trnby FROM  `tblrequisitions` where pid not in (select pid from tblonlinerequisitions);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("17/06/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblrequisitionslogs` MODIFY COLUMN `withattachment` VARCHAR(3) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitions` CHANGE COLUMN `officelevel` `approvinglevel` TINYINT(1) NOT NULL DEFAULT 0, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitions` ADD COLUMN `disbursinglevel` BOOLEAN NOT NULL DEFAULT 0 AFTER `approvinglevel`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitions` CHANGE COLUMN `forapproval` `forapproval` TINYINT(1) NOT NULL DEFAULT 0 after disbursinglevel, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitions` CHANGE COLUMN `approved` `approved` TINYINT(1) NOT NULL DEFAULT 0 after forapproval, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitions` ADD COLUMN `verifiedlevel` BOOLEAN NOT NULL DEFAULT 0 AFTER `approvinglevel`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("23/06/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "CREATE TABLE  `tblrequisitionslogsitem` (  `trnid` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `pid` varchar(45) NOT NULL,  `officeid` varchar(15) NOT NULL,  `productid` varchar(10) NOT NULL,  `catid` varchar(10) NOT NULL,  `vendorid` varchar(500) DEFAULT NULL,  `quantity` double NOT NULL DEFAULT '0',  `unit` varchar(10) NOT NULL,  `cost` double NOT NULL DEFAULT '0',  `total` double NOT NULL DEFAULT '0',  `allocatedrefcode` varchar(15) DEFAULT NULL,  `remarks` text,  `trnby` varchar(10) NOT NULL,  `datetrn` datetime NOT NULL,  `verifieditem` tinyint(1) NOT NULL DEFAULT '0',  `trnrefno` varchar(45) DEFAULT NULL,  PRIMARY KEY (`trnid`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "INSERT INTO tblrequisitionslogsitem select * from tblrequisitionsitem;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitionslogs` DROP COLUMN `withattachment`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitions` ADD COLUMN `priority` VARCHAR(15) NOT NULL AFTER `potypeid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitionslogs` CHANGE COLUMN `officelevel` `approvinglevel` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitionslogs` MODIFY COLUMN `attachmentpath` TEXT CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitions` ADD COLUMN `received` BOOLEAN NOT NULL DEFAULT 0 AFTER `verifiedlevel`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "update tblrequisitions set priority='Normal';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblrequisitions` ADD COLUMN `onlinerequest` BOOLEAN NOT NULL DEFAULT 0 AFTER `daterequest`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `filedir`.`tblattachmentlogs` ADD COLUMN `trntype` TEXT NOT NULL AFTER `refnumber`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("27/06/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblpermissions` DROP COLUMN `cashinvolved`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblpermissions` CHANGE COLUMN `special` `approver` TINYINT(1) NOT NULL DEFAULT 0, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `corpapprover` TINYINT(1) NOT NULL DEFAULT 0 AFTER `authapprover`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `apphistory` BOOLEAN NOT NULL DEFAULT 0 AFTER `corpapprover`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tbluserauthority` CHANGE COLUMN `authapprover` `officeapprover` TINYINT(1) NOT NULL DEFAULT 0, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `advancesearch` BOOLEAN NOT NULL DEFAULT 0 AFTER `corpapprover`, ADD COLUMN `forapprovalrequest` BOOLEAN NOT NULL DEFAULT 0 AFTER `advancesearch`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblpurchaseorder` CHANGE COLUMN `officelevel` `approvinglevel` TINYINT(1) NOT NULL DEFAULT 0, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("27/06/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblgeneralsettings` CHANGE COLUMN `id` `companycode` VARCHAR(5) NOT NULL DEFAULT '00000', DROP PRIMARY KEY, ADD PRIMARY KEY  USING BTREE(`companycode`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblcompanysettings` CHANGE COLUMN `unitcode` `companycode` VARCHAR(5) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, DROP PRIMARY KEY, ADD PRIMARY KEY  USING BTREE(`companycode`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblcompanysettings` ADD COLUMN `activated` BOOLEAN NOT NULL DEFAULT 0 AFTER `officeid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblgeneralsettings` DROP COLUMN `systemmodule`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblcompanysettings` ADD COLUMN `systemmodule` TEXT NOT NULL AFTER `companycode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("02/07/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblglobalproducts` DROP COLUMN `assignoffice`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblglobalproductshistory` DROP COLUMN `assignoffice`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("03/07/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE  `tblcompanysettings` ADD COLUMN `tinnumber` VARCHAR(45) AFTER `telephone`, ADD COLUMN `permitnumber` VARCHAR(45) AFTER `tinnumber`, ADD COLUMN `minumber` VARCHAR(45) AFTER `permitnumber`, ADD COLUMN `snumber` VARCHAR(45) AFTER `minumber`, ADD COLUMN `vatpercentage` DOUBLE DEFAULT 0 AFTER `snumber`, ADD COLUMN `posreceipttype` TEXT AFTER `vatpercentage`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("04/07/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblproductfilter` MODIFY COLUMN `productid` VARCHAR(105) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `onholdname` TEXT AFTER `onhold`, ADD COLUMN `advancepayment`  DOUBLE NOT NULL DEFAULT 0 AFTER `paymenttype`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `vatableitem` BOOLEAN NOT NULL DEFAULT 0 AFTER `enablesell`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblglobalproductshistory` ADD COLUMN `vatableitem` BOOLEAN NOT NULL DEFAULT 0 AFTER `enablesell`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "CREATE TABLE `tblhotelcottagestransaction` (  `id` int(11) NOT NULL AUTO_INCREMENT,  `productid` varchar(105) NOT NULL,  `clientname` text NOT NULL,  `contactnumber` text NOT NULL,  `advancepayment` double NOT NULL DEFAULT 0,  `trnby` varchar(105) NOT NULL,  `datetrn` datetime not null ,  `closedtrn` boolean not null default 0,  `closeddate` datetime,  `cancelled` boolean not null default 0,  `cancelledby` varchar(105),  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "CREATE TABLE `tblhotelcottages` (  `id` int(11) NOT NULL AUTO_INCREMENT,  `productid` varchar(105) NOT NULL,  `availability` boolean not null default 0,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "CREATE TABLE `tblglobalproductssequence` (  `productid` varchar(105) NOT NULL,  PRIMARY KEY ( `productid`) USING BTREE) ENGINE=MyISAM  DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "DROP TABLE `tblpoapprovalhistory`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tbluserauthority` DROP COLUMN `authTitle`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `tablesandcottages` BOOLEAN NOT NULL DEFAULT 0 AFTER `assetsmgt`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblhotelcottagestransaction` ADD COLUMN `trnsumcode` VARCHAR(45) NOT NULL AFTER `id`, ADD COLUMN `batchcode` VARCHAR(45) NOT NULL AFTER `trnsumcode`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblglobalproducts` MODIFY COLUMN `itemname` VARCHAR(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblglobalproductshistory` MODIFY COLUMN `itemname` VARCHAR(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, MODIFY COLUMN `unit` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblsalescardtransaction` ADD COLUMN `cardnumber` VARCHAR(85) NOT NULL AFTER `referenceno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblsalescardtransaction` ADD COLUMN `carddetails` VARCHAR(85) NOT NULL AFTER `cardnumber`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblsalescardtransaction` CHANGE COLUMN `tracenumber` `tracenumber` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL after carddetails ;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)

        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("05/07/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblclientsystemupdate` ADD COLUMN `server` BOOLEAN NOT NULL DEFAULT 0 AFTER `active`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `allownegativeinputs` BOOLEAN NOT NULL DEFAULT 0 AFTER `actived`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("06/07/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `adjoveride` BOOLEAN NOT NULL DEFAULT 0 AFTER `income`, ADD COLUMN `adjoverideby` VARCHAR(45) AFTER `adjoveride`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("10/07/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblglobalproductshistory` ADD COLUMN `allownegativeinputs` BOOLEAN NOT NULL DEFAULT 0 AFTER `actived`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "CREATE TABLE `tblunitconverter` (  `convcode` varchar(25) NOT NULL,  `officeid` varchar(15) NOT NULL,  `productid` varchar(100) NOT NULL,  `quantity` double NOT NULL DEFAULT '0',  PRIMARY KEY (`convcode`) USING BTREE) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    com.CommandText = "CREATE TABLE `tblunitconverterdetails` (  `trnid` int(10) unsigned NOT NULL AUTO_INCREMENT,  `convcode` varchar(25) NOT NULL,  `productid` varchar(100) NOT NULL,  `quantity` double NOT NULL DEFAULT '0',  PRIMARY KEY (`trnid`) USING BTREE) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("13/07/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `directproductregistration` BOOLEAN NOT NULL DEFAULT 0 AFTER `directapprovedpo`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("15/07/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblrequisitions` ADD COLUMN `revised` BOOLEAN NOT NULL DEFAULT 0 AFTER `forapproval`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("16/07/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblapprovalhistory` ADD COLUMN `corporateapproval` BOOLEAN NOT NULL DEFAULT 0 AFTER `finalapprover`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, com.CommandText.ToCharArray)
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("23/07/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "CREATE TABLE IF NOT EXISTS `filedir`.`tblattachmentlogs` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `refnumber` varchar(105) CHARACTER SET latin1 NOT NULL,  `trntype` text NOT NULL,  `databasename` varchar(45) NOT NULL,  `filename` text NOT NULL,  `archievedname` text NOT NULL,  `filesize` bigint(20) unsigned NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=343 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("31/07/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `custombranchapproval` BOOLEAN NOT NULL DEFAULT 0 AFTER `allowbeggininginventory`, ADD COLUMN `customcorporateapproval` BOOLEAN NOT NULL DEFAULT 0 AFTER `custombranchapproval`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("03/08/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblapproverclientprocess` ADD COLUMN `customized` BOOLEAN NOT NULL DEFAULT 0 AFTER `finalapp`, ADD COLUMN `officeid` VARCHAR(45) DEFAULT '' AFTER `customized`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tblapprovermainprocess` ADD COLUMN `customized` BOOLEAN NOT NULL DEFAULT 0 AFTER `finalapp`, ADD COLUMN `officeid` VARCHAR(45) DEFAULT '' AFTER `customized`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "CREATE TABLE `tblsudgestionbox` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `version` varchar(45) NOT NULL,  `systemname` VARCHAR(45) NOT NULL DEFAULT '0',  `datesubmitted` datetime NOT NULL,  `officeid` varchar(45) NOT NULL,  `submitby` varchar(45) NOT NULL,  `details` text NOT NULL,  `resolved` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("04/08/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblsudgestionbox` RENAME TO `tblsuggestionbox`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `defaultdownloadlocation` TEXT AFTER `directproductregistration`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tblsuggestionbox` ADD COLUMN `refnumber` VARCHAR(45) NOT NULL AFTER `id`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("09/08/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblexpenses` ADD COLUMN `affectcash` BOOLEAN NOT NULL DEFAULT 1 AFTER `remarks`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tblexpenses` ADD COLUMN `officeid` VARCHAR(45) NOT NULL AFTER `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tblsalesaccounttransaction` ADD COLUMN `officeid` VARCHAR(45) NOT NULL AFTER `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `totalexpensesaffectcash` DOUBLE NOT NULL DEFAULT 0 AFTER `totalexpenses`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `clientlogofilename` VARCHAR(105) NOT NULL DEFAULT '' AFTER `defaultdownloadlocation`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableservertimer` BOOLEAN NOT NULL DEFAULT 0 AFTER `clientlogofilename`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tbltransferitem` DROP COLUMN `catid`, DROP COLUMN `unit`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tbltransferbatch` MODIFY COLUMN `dateconfirmed` DATETIME, ADD COLUMN `cancelled` BOOLEAN NOT NULL DEFAULT 0 AFTER `dateconfirmed`, ADD COLUMN `datecancelled` DATETIME AFTER `cancelled`, ADD COLUMN `cancelledby` VARCHAR(45) AFTER `datecancelled`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("11/08/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `approveanyoffices` BOOLEAN NOT NULL DEFAULT 0 AFTER `corpapprover`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("31/08/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblhotelcottagestransaction` MODIFY COLUMN `contactnumber` TEXT CHARACTER SET latin1 COLLATE latin1_swedish_ci;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tblhotelcottagestransaction` DROP COLUMN `advancepayment`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tblhotelcottagestransaction` DROP COLUMN `batchcode`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tblhotelcottages` ADD COLUMN `sort` INTEGER UNSIGNED NOT NULL DEFAULT 0 AFTER `availability`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("09/09/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblrequisitions` ADD COLUMN `hold` BOOLEAN NOT NULL DEFAULT 0 AFTER `trnrefno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("09/10/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `cashbeggining` DOUBLE NOT NULL DEFAULT 0 AFTER `coffeecupposition`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE `tblinventoryadjustment` ADD COLUMN `fromsellamount` DOUBLE NOT NULL DEFAULT 0 AFTER `newamount`, ADD COLUMN `tosellamount` DOUBLE NOT NULL DEFAULT 0 AFTER `fromsellamount`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("14/10/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `transfermgt` TINYINT(1) NOT NULL DEFAULT 0 AFTER `inventorymgt`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "CREATE TABLE  `tbltransferrequest` (  `reqcode` varchar(45) NOT NULL,  `inventory_from` varchar(15) NOT NULL,  `inventory_to` varchar(15) NOT NULL,  `message` text NOT NULL,  `requestby` varchar(15) NOT NULL,  `daterequest` datetime NOT NULL,  `trnby` varchar(15) NOT NULL,  `confirmed` int(1) unsigned NOT NULL DEFAULT '0',  `confirmedby` varchar(45) DEFAULT NULL,  `dateconfirmed` datetime DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` datetime DEFAULT NULL,  `cancelledby` varchar(45) DEFAULT NULL,  PRIMARY KEY (`reqcode`)) ENGINE=MyISAM DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "ALTER TABLE  `tbltransferitem` MODIFY COLUMN `trnid` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "CREATE TABLE  `tbltransferrequestitem` (  `trnid` int(10) unsigned NOT NULL AUTO_INCREMENT,  `reqcode` varchar(35) NOT NULL,  `itemid` varchar(100) NOT NULL,  `quantity` double NOT NULL DEFAULT '0',  `unit` varchar(35) NOT NULL,  `remarks` text NOT NULL,  `trnby` varchar(15) NOT NULL,  `datetrn` datetime NOT NULL,  PRIMARY KEY (`trnid`) USING BTREE) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        'updateVersion = CDate("17/10/2015")
        'If nVersion() < CDate(updateVersion) Then
        '    com.CommandText = "ALTER TABLE `tbltransferrequest` ADD COLUMN `cancelledremarks` TEXT AFTER `cancelledby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    com.CommandText = "CREATE TABLE  `tbltransferrequestitemlogs` (  `trnid` int(10) unsigned NOT NULL AUTO_INCREMENT,  `reqcode` varchar(35) NOT NULL,  `itemid` varchar(100) NOT NULL,  `quantity` double NOT NULL DEFAULT '0',  `unit` varchar(35) NOT NULL,  `remarks` text NOT NULL,  `trnby` varchar(15) NOT NULL,  `datetrn` datetime NOT NULL,  PRIMARY KEY (`trnid`) USING BTREE) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    SystemUpdateLogs(ConvertDate(updateVersion), features)
        '    engineupdated = True
        'End If

        updateVersion = "2015-09-18"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `inventorymethod` VARCHAR(5) AFTER `customcorporateapproval`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltransferitem` ADD COLUMN `unitcost` DOUBLE NOT NULL DEFAULT 0 AFTER `quantity`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-05"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblclientaccountsbackup` (  `cifid` varchar(45) NOT NULL,  `companyname` text NOT NULL,  `compadd` text NOT NULL,  `telephone` text,  `walkinaccount` tinyint(1) NOT NULL DEFAULT '0',  `entryby` varchar(15) DEFAULT NULL,  `dateentered` datetime DEFAULT NULL,  `approved` tinyint(1) NOT NULL DEFAULT '0',  `approvedby` varchar(15) DEFAULT NULL,  `enabledue` tinyint(1) NOT NULL DEFAULT '0',  `duetype` varchar(45) DEFAULT NULL,  `duevalue` int(10) unsigned DEFAULT NULL,  `paymentduedays` int(10) unsigned NOT NULL DEFAULT '0',  `creditlimit` tinyint(1) NOT NULL DEFAULT '0',  `creditlimitamount` double NOT NULL DEFAULT '0',  PRIMARY KEY (`cifid`)) ENGINE=MyISAM DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD COLUMN `skipdiscount` BOOLEAN NOT NULL DEFAULT 0 AFTER `creditlimitamount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-08"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `allowinputdiscountedamount` TINYINT(1) UNSIGNED NOT NULL DEFAULT 0 AFTER `allownegativeinputs`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-09"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglobalproductshistory` ADD COLUMN `allowinputdiscountedamount` TINYINT(1) UNSIGNED NOT NULL DEFAULT 0 AFTER `allownegativeinputs`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-13"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableproductfilter` BOOLEAN NOT NULL DEFAULT 1 AFTER `enableservertimer` , ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventory` ADD COLUMN `productname` TEXT   AFTER `productid`, ADD COLUMN `categoryname` TEXT  AFTER `catid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblinventory inner join  tblglobalproducts on tblinventory.productid = tblglobalproducts.productid set productname=tblglobalproducts.itemname;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblinventory inner join  tblprocategory on tblinventory.catid=tblprocategory.catid set categoryname=tblprocategory.description;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-14"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablecashiersassistant` BOOLEAN NOT NULL DEFAULT 0 AFTER `enableproductfilter`, ADD COLUMN `enablesalesassistant` BOOLEAN NOT NULL DEFAULT 0 AFTER `enablecashiersassistant`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableupdatesalesamount` TINYINT NOT NULL DEFAULT 0 AFTER `enablesalesassistant`, ADD COLUMN `enablesalesdirectproductregister` BOOLEAN NOT NULL DEFAULT 0 AFTER `enableupdatesalesamount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `pointofsaleassistant` TINYINT(1) NOT NULL DEFAULT 0 AFTER `pointofsale`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblsalesbatchsequence` (`batchcode` bigint(20) NOT NULL,  PRIMARY KEY (`batchcode`)) ENGINE=MyISAM DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-15"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `approved` BOOLEAN NOT NULL DEFAULT 0 AFTER `allowinputdiscountedamount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproductshistory` ADD COLUMN `approved` BOOLEAN NOT NULL DEFAULT 0 AFTER `allowinputdiscountedamount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If
        updateVersion = "2015-10-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `defaultsalespersonpermission` VARCHAR(15) AFTER `enablesalesdirectproductregister`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If
        updateVersion = "2015-10-17"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablechittransaction` BOOLEAN NOT NULL DEFAULT 0 AFTER `defaultsalespersonpermission`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblsaleschittransaction` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `trnsumcode` varchar(45) NOT NULL,  `userid` varchar(10) NOT NULL,  `batchcode` varchar(25) NOT NULL,  `officeid` varchar(10) NOT NULL,  `cifid` varchar(15) NOT NULL,  `productid` varchar(45) NOT NULL,  `quantity` double NOT NULL,  `prevquantity` double NOT NULL DEFAULT '0',  `catid` varchar(10) NOT NULL,  `unit` varchar(15) NOT NULL,  `purchasedprice` double NOT NULL DEFAULT '0',  `sellprice` double NOT NULL DEFAULT '0',  `disrate` double NOT NULL DEFAULT '0',  `distotal` double NOT NULL DEFAULT '0',  `chargerate` double NOT NULL DEFAULT '0',  `chargetotal` double NOT NULL DEFAULT '0',  `taxrate` double NOT NULL DEFAULT '0',  `taxtotal` double NOT NULL DEFAULT '0',  `subtotal` double NOT NULL DEFAULT '0',  `total` double NOT NULL DEFAULT '0',  `income` double NOT NULL DEFAULT '0',  `adjoveride` tinyint(1) NOT NULL DEFAULT '0',  `adjoverideby` varchar(45) DEFAULT NULL,  `onhold` tinyint(1) NOT NULL DEFAULT '0',  `confirmed` tinyint(1) NOT NULL DEFAULT '0',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(15) DEFAULT NULL,  `void` tinyint(1) NOT NULL DEFAULT '0',  `voidby` varchar(15) DEFAULT NULL,  `datetrn` datetime NOT NULL,  PRIMARY KEY (`id`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblsaleschitbatch` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `customername` text NOT NULL,  `address` text NOT NULL,  `contactnumber` text NOT NULL,  `originaltotal` double NOT NULL DEFAULT '0',  `netdiscount` double NOT NULL DEFAULT '0',  `trnsumcode` varchar(45) DEFAULT NULL,  `userid` varchar(10) NOT NULL,  `batchcode` varchar(25) NOT NULL,  `officeid` varchar(10) NOT NULL,  `cifid` varchar(15) NOT NULL,  `totalitem` double NOT NULL DEFAULT '0',  `totalitemcancelled` double NOT NULL DEFAULT '0',  `totaldiscount` double NOT NULL DEFAULT '0',  `totalcharge` double NOT NULL DEFAULT '0',  `totaltax` double NOT NULL DEFAULT '0',  `subtotal` double NOT NULL DEFAULT '0',  `total` double NOT NULL DEFAULT '0',  `totalincome` double NOT NULL DEFAULT '0',  `paymenttype` varchar(6) NOT NULL DEFAULT '',  `advancepayment` double NOT NULL DEFAULT '0',  `amounttendered` double NOT NULL DEFAULT '0',  `amountchange` double NOT NULL DEFAULT '0',  `floattrn` tinyint(1) NOT NULL DEFAULT '0',  `onhold` tinyint(1) NOT NULL DEFAULT '0',  `onholdname` text,  `void` tinyint(1) NOT NULL DEFAULT '0',  `voidby` varchar(15) DEFAULT '',  `datetrn` datetime NOT NULL,  PRIMARY KEY (`id`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=1003976 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If
        updateVersion = "2015-10-18"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `originalsellprice` DOUBLE NOT NULL DEFAULT 0 AFTER `purchasedprice`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschittransaction` ADD COLUMN `originalsellprice` DOUBLE NOT NULL DEFAULT 0 AFTER `purchasedprice`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `partnumber` TEXT AFTER `itemname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproductshistory` ADD COLUMN `partnumber` TEXT AFTER `itemname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-22"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `forcashiertrn` BOOLEAN NOT NULL DEFAULT 0 AFTER `voidby`, ADD COLUMN `trnby` VARCHAR(15) AFTER `forcashiertrn`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschitbatch` ADD COLUMN `forcashiertrn` BOOLEAN NOT NULL DEFAULT 0 AFTER `voidby`, ADD COLUMN `trnby` VARCHAR(15) AFTER `forcashiertrn`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblsalesreturneditem` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `officeid` varchar(45) NOT NULL,  `itemcode` varchar(45) NOT NULL,  `trnsumcode` varchar(45) NOT NULL,  `trnsumrefcode` varchar(45) NOT NULL,  `batchrefcode` varchar(45) NOT NULL,  `productid` varchar(100) NOT NULL,  `quantity` double NOT NULL DEFAULT '0', `unit` VARCHAR(105) NOT NULL,  `unitcost` double NOT NULL DEFAULT '0',  `totalcost` double NOT NULL DEFAULT '0',  `returntoinventory` tinyint(1) NOT NULL DEFAULT '0',  `remarks` text,  `affectcash` tinyint(1) NOT NULL DEFAULT '1',  `trnby` varchar(15) NOT NULL,  `datereturn` datetime NOT NULL,  `verified` tinyint(1) DEFAULT '0',  `verifiedby` varchar(10) DEFAULT NULL,  `dateverified` datetime DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(45) DEFAULT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `returnitem` BOOLEAN NOT NULL DEFAULT 0 AFTER `othertransaction`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-24"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsaleschitbatch` ADD COLUMN `netdiscountaftertax` DOUBLE NOT NULL DEFAULT 0 AFTER `netdiscount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` MODIFY COLUMN `enablechittransaction` TINYINT(1) UNSIGNED NOT NULL DEFAULT 0, ADD COLUMN `enableprintrecieptcashier` TINYINT(1) UNSIGNED NOT NULL DEFAULT 1 AFTER `enablechittransaction`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-27"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `chittrn` BOOLEAN NOT NULL DEFAULT 0 AFTER `paymenttype`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschitbatch` ADD COLUMN `chittrn` BOOLEAN NOT NULL DEFAULT 0 AFTER `paymenttype`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablesaleinvoicenumber` BOOLEAN NOT NULL DEFAULT 0 AFTER `enableprintrecieptcashier`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalesdepositpaymenttransaction` (  `trnid` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `trnsumcode` varchar(20) NOT NULL DEFAULT '0',  `batchcode` varchar(25) NOT NULL,  `bankaccount` varchar(25) NOT NULL,  `referenceno` varchar(25) NOT NULL,  `amount` double NOT NULL DEFAULT '0',  `datetrn` datetime NOT NULL,  `trnby` varchar(15) NOT NULL,  `verified` tinyint(1) NOT NULL DEFAULT '0',  `dateverified` datetime DEFAULT NULL,  `verifiedby` varchar(15) DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT 0, `cancelledby` varchar(45) DEFAULT NULL,  `datecancelled` datetime DEFAULT NULL,  PRIMARY KEY (`trnid`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=100000000 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `totaldeposit` DOUBLE NOT NULL DEFAULT 0 AFTER `totalcard`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesbatch` MODIFY COLUMN `paymenttype` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci  NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschitbatch` MODIFY COLUMN `paymenttype` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `invoiceno` VARCHAR(45) NOT NULL DEFAULT '' AFTER `cifid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschitbatch` ADD COLUMN `invoiceno` VARCHAR(45) NOT NULL DEFAULT '' AFTER `cifid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-28"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enabledirectapprovedclient` BOOLEAN NOT NULL DEFAULT 0 AFTER `enablesaleinvoicenumber`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `totalchit` BOOLEAN NOT NULL DEFAULT 0 AFTER `totaltax`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-29"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "SET GLOBAL tx_isolation='REPEATABLE-READ';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "SET SESSION tx_isolation='SERIALIZABLE';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-30"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbltransferbatch` ADD COLUMN `trnid` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT first, DROP PRIMARY KEY, ADD PRIMARY KEY (`trnid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltransferrequestitem` ADD COLUMN `processed` BOOLEAN NOT NULL DEFAULT 0 AFTER `datetrn`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-10-31"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `cancelled` BOOLEAN NOT NULL DEFAULT 0 AFTER `openfortrn`, ADD COLUMN `datecancelled` DATETIME AFTER `cancelled`, ADD COLUMN `cancelledby` VARCHAR(10) AFTER `datecancelled`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` MODIFY COLUMN `totalchit` DOUBLE NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-11-03"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `chitsellprice` DOUBLE NOT NULL DEFAULT 0 AFTER `originalsellprice`, ADD COLUMN `chittotal` DOUBLE NOT NULL DEFAULT 0 AFTER `subtotal`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschitbatch` DROP COLUMN `officeid`, DROP COLUMN `cifid`, DROP COLUMN `invoiceno`, DROP COLUMN `totalitem`, DROP COLUMN `totalitemcancelled`, DROP COLUMN `totaldiscount`, DROP COLUMN `totalcharge`, DROP COLUMN `totaltax`, DROP COLUMN `subtotal`, DROP COLUMN `total`, DROP COLUMN `totalincome`, DROP COLUMN `paymenttype`, DROP COLUMN `chittrn`, DROP COLUMN `advancepayment`, DROP COLUMN `amounttendered`, DROP COLUMN `amountchange`, DROP COLUMN `floattrn`, DROP COLUMN `onhold`, DROP COLUMN `onholdname`, DROP COLUMN `void`, DROP COLUMN `voidby`, DROP COLUMN `forcashiertrn`, DROP COLUMN `trnby`, DROP COLUMN `datetrn`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschitbatch` MODIFY COLUMN `batchcode` VARCHAR(35) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL AFTER id;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschitbatch` MODIFY COLUMN `trnsumcode` VARCHAR(55) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL AFTER id;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschitbatch` ADD COLUMN `taxrate` DOUBLE NOT NULL DEFAULT 0 AFTER `netdiscount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblsaleschittransaction`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `chittotal` DOUBLE NOT NULL DEFAULT 0 AFTER `subtotal`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschitbatch` ADD COLUMN `chittotal` DOUBLE NOT NULL DEFAULT 0 AFTER `contactnumber`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschitbatch` ADD COLUMN `void` BOOLEAN NOT NULL DEFAULT 0 AFTER `userid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschitbatch` ADD COLUMN `voidby` VARCHAR(45) DEFAULT '' AFTER `void`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-11-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalesothertransaction` RENAME TO `tblsalesaccounttransaction`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `clientaccounts` BOOLEAN NOT NULL DEFAULT 0 AFTER `postexpense`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesaccounttransaction` CHANGE COLUMN `amount` `debit` DOUBLE NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesaccounttransaction` ADD COLUMN `credit` DOUBLE NOT NULL DEFAULT 0 AFTER `debit`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesdepositpaymenttransaction` ADD COLUMN `cleared` BOOLEAN NOT NULL DEFAULT 0 AFTER `verifiedby`, ADD COLUMN `clearedby` VARCHAR(15) AFTER `cleared`, ADD COLUMN `datecleared` DATETIME AFTER `clearedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `productname` VARCHAR(500) NOT NULL DEFAULT '' AFTER `productid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` DROP COLUMN `totalexpensesaffectcash`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` CHANGE COLUMN `totalchargeacct` `totalchargeacct` DOUBLE NOT NULL DEFAULT 0 after totalchit, ADD COLUMN `totalpaymentacct` DOUBLE NOT NULL DEFAULT 0 AFTER `totalchargeacct`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `totaljournaldebit` DOUBLE NOT NULL DEFAULT 0 AFTER `totalexpenses`, ADD COLUMN `totaljournalcredit` DOUBLE NOT NULL DEFAULT 0 AFTER `totaljournaldebit`, ADD COLUMN `totalothertransaction` DOUBLE NOT NULL DEFAULT 0 AFTER `totaljournalcredit`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblsalesothertransaction` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `officeid` varchar(45) NOT NULL,  `trnsumcode` varchar(45) NOT NULL,  `itemcode` varchar(45) NOT NULL,  `amount` double NOT NULL DEFAULT '0',  `remarks` text NOT NULL,  `trnby` varchar(15) NOT NULL,  `datetrn` datetime NOT NULL,  `verified` tinyint(1) DEFAULT '0',  `verifiedby` varchar(10) DEFAULT NULL,  `dateverified` datetime DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(45) DEFAULT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `clientpayment` BOOLEAN NOT NULL DEFAULT 0 AFTER `clientaccounts`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableacknowlegedchargetoaccountremarks` TINYINT(1) UNSIGNED NOT NULL DEFAULT 0 AFTER `enabledirectapprovedclient`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblsalestransaction` set productname = ifnull((select itemname from tblglobalproducts where productid=tblsalestransaction.productid),'');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccountsbackup` ADD COLUMN `skipdiscount` BOOLEAN NOT NULL DEFAULT 0 AFTER `creditlimitamount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-11-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `barcode` VARCHAR(105) NOT NULL DEFAULT '' AFTER `productid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproductshistory` ADD COLUMN `barcode` VARCHAR(105) NOT NULL DEFAULT '' AFTER `productid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblglobalproducts set barcode=productid where left(productid,1) <> 'I';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblglobalproductshistory set barcode=productid where left(productid,1) <> 'I';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `producttemplate` INTEGER UNSIGNED NOT NULL DEFAULT 1 AFTER `enableacknowlegedchargetoaccountremarks` , ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-11-18"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `sellingprice1` DOUBLE NOT NULL DEFAULT 0 AFTER `sellingprice`, ADD COLUMN `sellingprice2` DOUBLE NOT NULL DEFAULT 0 AFTER `sellingprice1`, ADD COLUMN `sellingprice3` DOUBLE NOT NULL DEFAULT 0 AFTER `sellingprice2`, ADD COLUMN `sellingprice4` DOUBLE NOT NULL DEFAULT 0 AFTER `sellingprice3`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproductshistory` ADD COLUMN `sellingprice1` DOUBLE NOT NULL DEFAULT 0 AFTER `sellingprice`, ADD COLUMN `sellingprice2` DOUBLE NOT NULL DEFAULT 0 AFTER `sellingprice1`, ADD COLUMN `sellingprice3` DOUBLE NOT NULL DEFAULT 0 AFTER `sellingprice2`, ADD COLUMN `sellingprice4` DOUBLE NOT NULL DEFAULT 0 AFTER `sellingprice3`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))

            engineupdated = True
        End If

        updateVersion = "2015-11-20"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `strictadminconfirmed` BOOLEAN NOT NULL DEFAULT 0 AFTER `producttemplate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` CHANGE COLUMN `producttemplate` `producttemplateclient` INT(10) UNSIGNED NOT NULL DEFAULT 1, ADD COLUMN `producttemplateserver` INT(10) UNSIGNED NOT NULL DEFAULT 1 AFTER `producttemplateclient`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-11-30"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `nextbeginningcash` DOUBLE NOT NULL DEFAULT 0 AFTER `totalcoins`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `cashremitted` DOUBLE NOT NULL DEFAULT 0 AFTER `nextbeginningcash`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-01"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglgroup` MODIFY COLUMN `groupcode` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `groupname` VARCHAR(105) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', ADD COLUMN `child` BOOLEAN NOT NULL DEFAULT 0 AFTER `groupname`, ADD COLUMN `parent` VARCHAR(105) NOT NULL DEFAULT '' AFTER `child`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltransactioncode` MODIFY COLUMN `groupcode` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `itemcode` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `itemname` VARCHAR(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', CHANGE COLUMN `subsidiary` `child` TINYINT(1) NOT NULL DEFAULT 0, MODIFY COLUMN `parentcode` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltransactioncode` CHANGE COLUMN `parentcode` `parent` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltransactioncode` MODIFY COLUMN `groupcode` VARCHAR(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, MODIFY COLUMN `itemcode` VARCHAR(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, MODIFY COLUMN `parent` VARCHAR(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-02"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `returnquantity` DOUBLE NOT NULL DEFAULT 0 AFTER `income`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesreturneditem` ADD COLUMN `salestrnid` VARCHAR(45) NOT NULL AFTER `id`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblsalesreturneditem` set salestrnid=(select id from tblsalestransaction where tblsalestransaction.batchcode=tblsalesreturneditem.batchrefcode and tblsalestransaction.trnsumcode = tblsalesreturneditem.trnsumrefcode and tblsalestransaction.productid = tblsalesreturneditem.productid);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesreturneditem` ADD COLUMN `originalquantity` DOUBLE NOT NULL DEFAULT 0 AFTER `quantity`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblsalesreturneditem` set originalquantity=(select quantity from tblsalestransaction where tblsalestransaction.batchcode=tblsalesreturneditem.batchrefcode and tblsalestransaction.trnsumcode = tblsalesreturneditem.trnsumrefcode and tblsalestransaction.productid = tblsalesreturneditem.productid);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblsalesreturneditem` set batchrefcode=(select batchcode from tblsalestransaction where tblsalestransaction.trnsumcode = tblsalesreturneditem.trnsumrefcode and tblsalestransaction.productid = tblsalesreturneditem.productid limit 1);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-08"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `chargeinvoicetemplate` INTEGER UNSIGNED NOT NULL DEFAULT 0 AFTER `strictadminconfirmed`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `chargeinvoicettitle` VARCHAR(45) NOT NULL DEFAULT 'CHARGE INVOICE' AFTER `chargeinvoicetemplate`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-09"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `chargeinvoicessequence` VARCHAR(10) NOT NULL DEFAULT '' AFTER `chargeinvoicettitle`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-13"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD COLUMN `enablespecialprice` BOOLEAN NOT NULL DEFAULT 0 AFTER `skipdiscount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblclientspecialprice` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `cifid` varchar(45) NOT NULL default '',  `productid` varchar(45) NOT NULL default '',  `amount` double NOT NULL default 0,  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-15"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblsalesdeliveryslip` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `refcode` varchar(45) NOT NULL,  `trnsumcode` varchar(45) NOT NULL,  `trnrefsumcode` varchar(45) NOT NULL,  `batchcode` varchar(45) NOT NULL,  `clientname` varchar(100) NOT NULL,  `requestfrom` varchar(15) NOT NULL,  `requestto` varchar(15) NOT NULL,  `remarks` text,  `createdby` varchar(15) NOT NULL,  `datecreated` datetime NOT NULL,  `confirmed` int(1) unsigned NOT NULL DEFAULT '0',  `confirmedby` varchar(45) DEFAULT NULL,  `dateconfirmed` datetime DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` datetime DEFAULT NULL,  `cancelledby` varchar(45) DEFAULT NULL,  PRIMARY KEY (`id`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalesdeliveryitem` (  `trnid` int(10) unsigned NOT NULL AUTO_INCREMENT,  `refcode` varchar(35) NOT NULL,  `trnrefsumcode` varchar(45) NOT NULL,  `batchcode` varchar(45) NOT NULL,  `refitem` varchar(100) NOT NULL,  `released` tinyint(1) NOT NULL DEFAULT '0',  `datereleased` datetime,  `trnby` varchar(15) NOT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`trnid`) USING BTREE) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` MODIFY COLUMN `chargeinvoicetemplate` VARCHAR(5) NOT NULL DEFAULT 'POS';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` MODIFY COLUMN `defaultsalespersonpermission` VARCHAR(15) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT '', MODIFY COLUMN `chargeinvoicettitle` VARCHAR(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'CHARGE INVOICE', ADD COLUMN `clientjournaltemplate` VARCHAR(10) NOT NULL DEFAULT 'POS' AFTER `chargeinvoicessequence`, ADD COLUMN `clientjournaltitle` VARCHAR(100) NOT NULL DEFAULT 'ACKNOWLEGEDMENT RECEIPT' AFTER `clientjournaltemplate`, ADD COLUMN `clientjournalsequence` VARCHAR(10) NOT NULL DEFAULT '' AFTER `clientjournaltitle`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesaccounttransaction` ADD COLUMN `referenceno` VARCHAR(45) NOT NULL DEFAULT '' AFTER `accountno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-22"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `salesdelivery` TINYINT(1) NOT NULL DEFAULT 0 AFTER `clientpayment`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `salesdeliverytemplate` VARCHAR(10) NOT NULL DEFAULT 'POS' AFTER `clientjournalsequence`, ADD COLUMN `salesdeliverytitle` VARCHAR(100) NOT NULL DEFAULT 'DELIVERY SLIP' AFTER `salesdeliverytemplate`, ADD COLUMN `salesdeliverysequence` VARCHAR(10) NOT NULL DEFAULT '' AFTER `salesdeliverytitle`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-23"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD COLUMN `hotelclient` BOOLEAN NOT NULL DEFAULT 0 AFTER `enablespecialprice`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD COLUMN `hotelofficeid` VARCHAR(10) DEFAULT '' AFTER `hotelclient`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `ishotel` BOOLEAN NOT NULL DEFAULT 0 AFTER `inventorymethod`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-24"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalesdeliveryslip` ADD COLUMN `clientaddress` VARCHAR(500) DEFAULT '' AFTER `clientname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-25"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `hotelmgt` TINYINT(1) NOT NULL DEFAULT 0 AFTER `assetsmgt`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `hotelfoliosequence` VARCHAR(10) NOT NULL DEFAULT '' AFTER `producttemplateserver`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-27"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `hotelcheckouttime` TIME NOT NULL DEFAULT '12:00:00' AFTER `hotelfoliosequence`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-28"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `hotelreservationexpiry` INTEGER UNSIGNED NOT NULL DEFAULT 7 AFTER `hotelcheckouttime`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesbatch` MODIFY COLUMN `paymenttype` VARCHAR(60) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2015-12-30"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblhotelguest` (  `guestid` varchar(45) NOT NULL,  `fullname` varchar(100) NOT NULL,  `address` longtext NOT NULL,  `birthdate` date DEFAULT NULL,  `gender` varchar(6) DEFAULT NULL,  `nationality` varchar(45) DEFAULT NULL,  `contactnumber` varchar(45) DEFAULT NULL,  `emailadd` varchar(45) DEFAULT NULL,  `datetrn` datetime NOT NULL,  `trnby` varchar(10) NOT NULL,  PRIMARY KEY (`guestid`) USING BTREE) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblhotelroomreservation` (  `trnid` varchar(25) NOT NULL,  `trnsumcode` varchar(15) NOT NULL,  `guestid` varchar(25) NOT NULL,  `hotelcif` varchar(15) NOT NULL,  `roomid` varchar(15) NOT NULL,  `datearaival` date NOT NULL,  `timearaival` time NOT NULL,  `noadults` int(2) unsigned NOT NULL,  `nochild` int(2) unsigned NOT NULL,  `paymentdeposit` double NOT NULL DEFAULT '0',  `trnby` varchar(15) NOT NULL,  `datetrn` datetime NOT NULL,  `proceedcheckin` tinyint(1) NOT NULL DEFAULT '0',  `proceedby` varchar(15) DEFAULT '',  `proceedfoliono` varchar(15) DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(15) DEFAULT '',  `approvedcancelledby` varchar(15) DEFAULT NULL,  `cancelledremarks` text,  `dateexpiry` datetime NOT NULL,  `expired` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`trnid`) USING BTREE) ENGINE=InnoDB DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblhotelrooms` (  `roomid` varchar(10) NOT NULL,  `hotelcifid` varchar(15) NOT NULL,  `roomnumber` varchar(45) NOT NULL,  `description` varchar(500) NOT NULL,  `roomrate` double NOT NULL DEFAULT '0',  `extrabedrate` double NOT NULL DEFAULT '0',  `occupied` tinyint(1) NOT NULL DEFAULT '0',  `reserved` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`roomid`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblhotelroomsamenities` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `roomid` varchar(45) NOT NULL,  `productid` varchar(45) NOT NULL,  `quantity` double NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblhotelroomtransaction` (  `foliono` varchar(15) NOT NULL,  `trnsumcode` varchar(25) NOT NULL,  `guestid` varchar(25) NOT NULL,  `hotelcif` varchar(15) NOT NULL,  `roomid` varchar(15) NOT NULL,  `datecheckin` date NOT NULL,  `timecheckin` time NOT NULL,  `datecheckout` date NOT NULL,  `timecheckout` time NOT NULL,  `nodays` int(2) unsigned NOT NULL,  `noadults` int(2) unsigned NOT NULL,  `nochild` int(2) unsigned NOT NULL,  `extrabed` double NOT NULL DEFAULT '0',  `totalextrabed` double NOT NULL DEFAULT '0',  `roomdiscount` double NOT NULL DEFAULT '0',  `totaldiscount` double NOT NULL,  `totalamount` double NOT NULL,  `trnby` varchar(15) NOT NULL,  `datetrn` datetime NOT NULL,  `discountoveride` tinyint(1) NOT NULL DEFAULT '0',  `discountoverideby` varchar(15) DEFAULT '',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(15) DEFAULT '',  `datecancelled` datetime DEFAULT NULL,  `approvedcancelledby` varchar(15) DEFAULT NULL,  `cancelledremarks` text,  `closed` tinyint(1) NOT NULL DEFAULT '0',  `dateclosed` datetime DEFAULT NULL,  PRIMARY KEY (`foliono`) USING BTREE) ENGINE=InnoDB DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblhoteltransaction` (  `trnid` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `foliono` varchar(10) NOT NULL,  `trnsumcode` varchar(10) NOT NULL,  `officeid` varchar(10) NOT NULL,  `referenceno` varchar(25) NOT NULL DEFAULT '',  `remarks` varchar(500) NOT NULL,  `debit` double NOT NULL DEFAULT '0',  `credit` double NOT NULL DEFAULT '0',  `chargefrompos` tinyint(1) NOT NULL DEFAULT '0',  `roomcharge` tinyint(1) NOT NULL DEFAULT '0',  `datecharge` date DEFAULT NULL,  `paymenttrn` tinyint(1) NOT NULL DEFAULT '0',  `datetrn` datetime NOT NULL,  `trnby` varchar(15) NOT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(45) DEFAULT NULL,  `approvedcancelledby` varchar(15) DEFAULT NULL,  `datecancelled` datetime DEFAULT NULL,  PRIMARY KEY (`trnid`) USING BTREE) ENGINE=InnoDB AUTO_INCREMENT=76 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-01-02"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhoteltransaction` ADD COLUMN `appliedcoupon` BOOLEAN NOT NULL DEFAULT 0 AFTER `chargefrompos`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `roomoccupancy` BOOLEAN NOT NULL DEFAULT 0 AFTER `tablesandcottages`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `hotelreceiptsequence` VARCHAR(10) NOT NULL DEFAULT '' AFTER `hotelreservationexpiry`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-01-04"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `clientpaymentreceipttemplate` VARCHAR(10) NOT NULL AFTER `salesdeliverysequence`, ADD COLUMN `clientpaymentreceiptsequence` VARCHAR(10) NOT NULL AFTER `clientpaymentreceipttemplate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-01-07"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelrooms` ADD COLUMN `promorate` DOUBLE NOT NULL DEFAULT 0 AFTER `roomrate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `promorate` BOOLEAN NOT NULL DEFAULT 0 AFTER `roomid`, ADD COLUMN `roomrate` DOUBLE NOT NULL DEFAULT 0 AFTER `promorate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-01-08"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblproductfilter` ADD COLUMN `productname` TEXT AFTER `productid`, ADD COLUMN `catid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `productname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblproductfilter inner join tblglobalproducts on tblproductfilter.productid = tblglobalproducts.productid set productname= itemname, tblproductfilter.catid=tblglobalproducts.catid;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DELETE FROM `tblproductfilter` where productname is null;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientfilter` ADD COLUMN `clientname` TEXT AFTER `cifid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblclientfilter inner join tblclientaccounts on tblclientfilter.cifid = tblclientaccounts.cifid set clientname= companyname;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-01-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblhotelroomsdiscount` (  `discode` int(10) unsigned NOT NULL,  `description` varchar(500) NOT NULL,  `discountrate` double NOT NULL DEFAULT '0',  PRIMARY KEY (`discode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `discountcode` VARCHAR(5) DEFAULT '' AFTER `nochild`, ADD COLUMN `discountrate` INTEGER UNSIGNED NOT NULL DEFAULT 0 AFTER `discountcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-02-22"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalescardtransaction` MODIFY COLUMN `cancelled` TINYINT(1) NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblsalescashpayment` (  `trnid` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `trnsumcode` varchar(20) NOT NULL DEFAULT '0',  `batchcode` varchar(25) NOT NULL,  `amount` double NOT NULL DEFAULT '0',  `cashchange` double NOT NULL DEFAULT '0',  `datetrn` datetime NOT NULL,  `trnby` varchar(15) NOT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(45) DEFAULT NULL,  `datecancelled` datetime DEFAULT NULL,  PRIMARY KEY (`trnid`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=100000003 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If
        updateVersion = "2016-02-23"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblaccountaccess` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `userid` varchar(7) NOT NULL,  `permission` varchar(45) NOT NULL,  `defaultaccess` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-02-28"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "DROP TABLE IF EXISTS `tblemployees`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblemployees` (  `employeeid` varchar(15) NOT NULL DEFAULT '',  `lastname` varchar(25) NOT NULL DEFAULT '',  `firstname` varchar(25) NOT NULL DEFAULT '',  `middlename` varchar(25) NOT NULL DEFAULT '',  `fullname` varchar(35) NOT NULL DEFAULT '',  `extname` varchar(6) DEFAULT '',  `nickname` varchar(20) DEFAULT '',  `birthdate` date NOT NULL,  `birthplace` varchar(450) DEFAULT '',  `nationality` varchar(45) NOT NULL DEFAULT '',  `religion` varchar(45) NOT NULL DEFAULT '',  `civilstatus` varchar(45) NOT NULL DEFAULT '',  `profilelink` varchar(45) DEFAULT '',  `per_add_brgy` varchar(65) DEFAULT '',  `per_add_city` varchar(45) DEFAULT '',  `per_add_prov` varchar(45) DEFAULT '',  `cur_add_brgy` varchar(65) DEFAULT '',  `cur_add_city` varchar(45) DEFAULT '',  `cur_add_prov` varchar(45) DEFAULT '',  `contactnumber` varchar(45) DEFAULT '',  `homenumber` varchar(45) DEFAULT '',  `emailaddress` varchar(45) DEFAULT '',  `inc_cont_person` varchar(65) DEFAULT '',  `inc_cont_number` varchar(45) DEFAULT '',  `inc_cont_address` varchar(75) DEFAULT '',  `officeid` varchar(15) DEFAULT '',  `employeetypecode` varchar(15) DEFAULT '',  `positioncode` varchar(15) DEFAULT '',  `salarygrade` varchar(45) DEFAULT '',  `salaryrate` double NOT NULL DEFAULT '0',  `monthlyrate` double NOT NULL DEFAULT '0',  `dailyrate` double NOT NULL DEFAULT '0',  `rateperhour` double NOT NULL DEFAULT '0',  `taxexempt` tinyint(1) NOT NULL DEFAULT '0',  `contractperiod` tinyint(1) NOT NULL DEFAULT '0',  `contractstartdate` date DEFAULT NULL,  `contractenddate` date DEFAULT NULL,  `datehired` date DEFAULT NULL,  `dateregular` date DEFAULT NULL,  `employeestatus` int(10) unsigned NOT NULL DEFAULT '0',  `statusdate` date DEFAULT NULL,  `statusremarks` text,  `payouttype` int(10) unsigned NOT NULL DEFAULT '0',  `approvedby` varchar(15) DEFAULT '',  `dateregistered` datetime DEFAULT NULL,  `linkeduserid` varchar(15) DEFAULT '',  PRIMARY KEY (`employeeid`)) ENGINE=MyISAM DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableautoclearedclientaccttrn` BOOLEAN NOT NULL DEFAULT 0 AFTER `clientpaymentreceiptsequence`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `printstatementledgertype` TINYINT(1) UNSIGNED NOT NULL DEFAULT 0 AFTER `enableautoclearedclientaccttrn`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-02-29"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableclientfilter` BOOLEAN NOT NULL DEFAULT 0 AFTER `printstatementledgertype`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgljournal` ADD COLUMN `batchcode` VARCHAR(25) NOT NULL DEFAULT '' AFTER `trnid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpurchaseorder` AUTO_INCREMENT = 10000 ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-03-19"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `enableoperation` BOOLEAN NOT NULL DEFAULT 1 AFTER `ishotel`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tbltransactioncode` (  `itemcode` varchar(20) NOT NULL,  `itemname` varchar(100) NOT NULL DEFAULT '',  `glcode` varchar(20) NOT NULL DEFAULT '',  PRIMARY KEY (`itemcode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpurchaseorderitem` ADD COLUMN `itemname` VARCHAR(505) NOT NULL DEFAULT '' AFTER `productid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblpurchaseorderitem` set itemname=ifnull((select itemname from tblglobalproducts where productid=tblpurchaseorderitem.productid),'');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE  `tblsalesreturneditem` DROP COLUMN `itemcode`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-04-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `directponumbersequence` VARCHAR(10) NOT NULL DEFAULT '' AFTER `enableclientfilter`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-04-21"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalesbatch` DROP COLUMN `id`, change column `batchcode` `batchcode` VARCHAR(25) not null first, DROP PRIMARY KEY, ADD PRIMARY KEY  USING BTREE(`batchcode`), ROW_FORMAT = FIXED;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD INDEX `product`(`itemname`, `barcode`, `productid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventory` MODIFY COLUMN `productname` VARCHAR(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci, ADD INDEX `IndexItem`(`productname`, `officeid`, `productid`), ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-04-23"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblproductfilter` MODIFY COLUMN `productname` VARCHAR(155) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL, ADD INDEX `Index_2`(`productid`, `productname`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblprocategory` MODIFY COLUMN `description` VARCHAR(155) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, ADD INDEX `Index_2`(`catid`, `prepaid`, `description`, `potypeid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventory` MODIFY COLUMN `categoryname` VARCHAR(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL, MODIFY COLUMN `productname` VARCHAR(350) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL, MODIFY COLUMN `unit` VARCHAR(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL, ADD INDEX `Index_2`(`categoryname`, `catid`, `productid`, `productname`, `officeid`), ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-05-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            If MessageBox.Show("WARNING: Current update are countains some modification of database transaction, if you not aware of this please contact your system administrator!?" & Environment.NewLine & Environment.NewLine & "Are you realy to execute this update!  ", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbYes Then
                com.CommandText = "ALTER TABLE `tblsalestransaction` ADD INDEX `batchcode`(`batchcode`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "ALTER TABLE `tblsalesclientcharges` ADD INDEX `batchcode`(`batchcode`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "DROP TABLE IF EXISTS  `tblsalesclientchargesitem`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "CREATE TABLE  `tblsalesclientchargesitem` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `trnsumcode` varchar(45) NOT NULL,  `userid` varchar(10) NOT NULL,  `batchcode` varchar(25) NOT NULL,  `officeid` varchar(10) NOT NULL,  `cifid` varchar(15) NOT NULL,  `productid` varchar(45) NOT NULL,  `productname` varchar(500) NOT NULL DEFAULT '',  `quantity` double NOT NULL,  `prevquantity` double NOT NULL DEFAULT '0',  `catid` varchar(10) NOT NULL,  `unit` varchar(15) NOT NULL,  `purchasedprice` double NOT NULL DEFAULT '0',  `originalsellprice` double NOT NULL DEFAULT '0',  `chitsellprice` double NOT NULL DEFAULT '0',  `sellprice` double NOT NULL DEFAULT '0',  `disrate` double NOT NULL DEFAULT '0',  `distotal` double NOT NULL DEFAULT '0',  `chargerate` double NOT NULL DEFAULT '0',  `chargetotal` double NOT NULL DEFAULT '0',  `taxrate` double NOT NULL DEFAULT '0',  `taxtotal` double NOT NULL DEFAULT '0',  `subtotal` double NOT NULL DEFAULT '0',  `chittotal` double NOT NULL DEFAULT '0',  `total` double NOT NULL DEFAULT '0',  `income` double NOT NULL DEFAULT '0',  `returnquantity` double NOT NULL DEFAULT '0',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(15) DEFAULT NULL,  `datetrn` datetime NOT NULL,  PRIMARY KEY (`id`) USING BTREE,  KEY `trnsumcode` (`trnsumcode`),  KEY `batchcode` (`batchcode`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "INSERT INTO `tblsalesclientchargesitem` (trnsumcode,userid,batchcode,officeid,cifid,productid,productname,quantity,prevquantity,catid,unit,purchasedprice,originalsellprice,chitsellprice,sellprice,disrate,distotal,chargerate,chargetotal,taxrate,taxtotal,subtotal,chittotal,total,income,returnquantity,cancelled,cancelledby,datetrn) SELECT trnsumcode,userid,batchcode,officeid,cifid,productid,productname,quantity,prevquantity,catid,unit,purchasedprice,originalsellprice,chitsellprice,sellprice,disrate,distotal,chargerate,chargetotal,taxrate,taxtotal,subtotal,chittotal,total,income,returnquantity,cancelled,cancelledby,datetrn FROM `tblsalestransaction` where batchcode in (select batchcode from tblsalesclientcharges);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "UPDATE `tblsalestransaction` SET quantity=quantity+returnquantity where returnquantity > 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "UPDATE `tblsalestransaction` SET distotal=if(sellprice<originalsellprice,quantity*(originalsellprice-sellprice),0), chargetotal=if(sellprice>originalsellprice,quantity*(sellprice-originalsellprice),0), taxtotal=(sellprice*quantity)*(taxrate/100), subtotal=sellprice*quantity, chittotal=0, total=sellprice*quantity, income=(sellprice-purchasedprice) * quantity where returnquantity > 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "UPDATE `tblsalestransaction` SET distotal=if(sellprice<originalsellprice,quantity*(originalsellprice-sellprice),0), chargetotal=if(sellprice>originalsellprice,quantity*(sellprice-originalsellprice),0), taxtotal=(sellprice*quantity)*(taxrate/100), subtotal=sellprice*quantity, chittotal=0, total=sellprice*quantity, income=(sellprice-purchasedprice) * quantity where total = 0 and cancelled=0 and void=0 and sellprice>0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                engineupdated = True
            End If
        End If

        updateVersion = "2016-05-15"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalesreturneditem` ADD COLUMN `returnreference` VARCHAR(45) NOT NULL AFTER `id`, ADD INDEX `returnreference`(`returnreference`), ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalesreturnedclientcharges` (  `trnid` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `trnsumcode` varchar(45) DEFAULT NULL,  `accountno` varchar(25) NOT NULL,  `batchcode` varchar(25) DEFAULT NULL,  `glitemcode` varchar(45) DEFAULT NULL,  `invoiceno` varchar(45) DEFAULT NULL,  `remarks` varchar(145) DEFAULT NULL,  `amount` double NOT NULL DEFAULT '0',  `datetrn` datetime DEFAULT NULL,  `trnby` varchar(15) DEFAULT NULL,  `verified` tinyint(1) NOT NULL DEFAULT '0',  `verifiedby` varchar(45) DEFAULT NULL,  `dateverified` datetime DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(45) DEFAULT NULL,  `datecancelled` datetime DEFAULT NULL,  `paymentupdated` tinyint(1) NOT NULL DEFAULT '0',  `paymentrefnumber` varchar(45) DEFAULT NULL,  `returnreference` varchar(45) DEFAULT NULL,  PRIMARY KEY (`trnid`) USING BTREE,  KEY `trnsumcode` (`trnsumcode`),  KEY `accountno` (`accountno`),  KEY `batchcode` (`batchcode`),  KEY `glitemcode` (`glitemcode`),  KEY `invoiceno` (`invoiceno`),  KEY `paymentrefnumber` (`paymentrefnumber`),  KEY `trnby` (`trnby`)) ENGINE=MyISAM AUTO_INCREMENT=100000000 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalesreturnedclientchargesitem` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `trnsumcode` varchar(45) NOT NULL,  `userid` varchar(10) NOT NULL,  `batchcode` varchar(25) NOT NULL,  `officeid` varchar(10) NOT NULL,  `cifid` varchar(15) NOT NULL,  `productid` varchar(45) NOT NULL,  `productname` varchar(500) NOT NULL DEFAULT '',  `quantity` double NOT NULL,  `prevquantity` double NOT NULL DEFAULT '0',  `catid` varchar(10) NOT NULL,  `unit` varchar(15) NOT NULL,  `purchasedprice` double NOT NULL DEFAULT '0',  `originalsellprice` double NOT NULL DEFAULT '0',  `chitsellprice` double NOT NULL DEFAULT '0',  `sellprice` double NOT NULL DEFAULT '0',  `disrate` double NOT NULL DEFAULT '0',  `distotal` double NOT NULL DEFAULT '0',  `chargerate` double NOT NULL DEFAULT '0',  `chargetotal` double NOT NULL DEFAULT '0',  `taxrate` double NOT NULL DEFAULT '0',  `taxtotal` double NOT NULL DEFAULT '0',  `subtotal` double NOT NULL DEFAULT '0',  `chittotal` double NOT NULL DEFAULT '0',  `total` double NOT NULL DEFAULT '0',  `income` double NOT NULL DEFAULT '0',  `returnquantity` double NOT NULL DEFAULT '0',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(15) DEFAULT NULL,  `datetrn` datetime NOT NULL,  `returnreference` varchar(45) DEFAULT NULL,  PRIMARY KEY (`id`) USING BTREE,  KEY `trnsumcode` (`trnsumcode`),  KEY `userid` (`userid`),  KEY `batchcode` (`batchcode`),  KEY `officeid` (`officeid`),  KEY `cifid` (`cifid`),  KEY `productid` (`productid`),  KEY `productname` (`productname`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablebackdatetrn` BOOLEAN NOT NULL DEFAULT 0 AFTER `directponumbersequence`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `backdatetrn` BOOLEAN NOT NULL DEFAULT 0 AFTER `cashfrom`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `backdate` DATE AFTER `backdatetrn`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblsalesbatch` set paymenttype='cta' where paymenttype='charge to client account';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-05-18"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `reminders` BOOLEAN NOT NULL DEFAULT 0 AFTER `advancesearch`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblreminders` (  `code` varchar(25) NOT NULL,  `officeid` varchar(10) NOT NULL,  `title` varchar(100) NOT NULL,  `details` text NOT NULL,  `datecreated` datetime NOT NULL,  `createdby` varchar(40) NOT NULL,  `followupdate` varchar(100) NOT NULL,  `closed` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`code`) USING BTREE) ENGINE=MyISAM DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblreminderslogs` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `reminderscode` varchar(100) NOT NULL,  `remarks` text NOT NULL,  `dateposted` datetime NOT NULL,  `postedby` varchar(50) NOT NULL,  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-05-22"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblclientgroup` (  `groupcode` int(10) NOT NULL,  `groupname` varchar(105) NOT NULL DEFAULT '',  `default` BOOLEAN NOT NULL DEFAULT 0,  PRIMARY KEY (`groupcode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DELETE FROM tblclientgroup WHERE groupcode='100';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "INSERT into tblclientgroup set groupcode='100',groupname='CLIENT ACCOUNTS',`default`=1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD COLUMN `groupcode` VARCHAR(3) NOT NULL DEFAULT '' AFTER `cifid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD INDEX `groupcode`(`groupcode`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientgroup` ADD INDEX `groupcode`(`groupcode`), ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            If MessageBox.Show("Update existing client accounts to default group?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = vbYes Then
                com.CommandText = "UPDATE `tblclientaccounts` set groupcode='100';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            engineupdated = True
        End If

        updateVersion = "2016-06-10"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "DROP TABLE tblclientfilter;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblclientfilter` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `filtercode` int(10) unsigned NOT NULL,  `permissioncode` int(10) unsigned NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblclientfiltersettings` (  `code` varchar(10) NOT NULL DEFAULT '',  `description` varchar(50) NOT NULL,  PRIMARY KEY (`code`),  KEY `code` (`code`,`description`),  KEY `description` (`description`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD COLUMN `accountfilter` VARCHAR(4) NOT NULL DEFAULT '' AFTER `cifid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablectaadvancepayment` BOOLEAN NOT NULL DEFAULT 0 AFTER `enablebackdatetrn`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblproductfilter`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblproductfilter` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT, `categorycode` varchar(10) NOT NULL,  `permissioncode` int(10) unsigned NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-06-18"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblpaymenttransactions` ADD COLUMN `depositpaymentchange` BOOLEAN NOT NULL DEFAULT 0 AFTER `discount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        'ACTIVATE COMPLETE PAYROLL MODULE
        updateVersion = "2016-06-30"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblemployees` (`employeeid` varchar(15) NOT NULL DEFAULT '',`lastname` varchar(25) NOT NULL DEFAULT '',`firstname` varchar(25) NOT NULL DEFAULT '',`middlename` varchar(25) NOT NULL DEFAULT '',`fullname` varchar(50) NOT NULL,`extname` varchar(6) DEFAULT '',`nickname` varchar(40) DEFAULT NULL,`birthdate` date NOT NULL,`birthplace` varchar(450) DEFAULT '',`nationality` varchar(45) NOT NULL DEFAULT '',`religion` varchar(45) NOT NULL DEFAULT '',`civilstatus` varchar(45) NOT NULL DEFAULT '',`profilelink` varchar(45) DEFAULT '',`per_add_brgy` varchar(65) DEFAULT '',`per_add_city` varchar(45) DEFAULT '',`per_add_prov` varchar(45) DEFAULT '',`cur_add_brgy` varchar(65) DEFAULT '',`cur_add_city` varchar(45) DEFAULT '',`cur_add_prov` varchar(45) DEFAULT '',`contactnumber` varchar(45) DEFAULT '',`homenumber` varchar(45) DEFAULT '',`emailaddress` varchar(45) DEFAULT '',`inc_cont_person` varchar(65) DEFAULT '',`inc_cont_number` varchar(45) DEFAULT '',`inc_cont_address` varchar(75) DEFAULT '',`officeid` varchar(15) DEFAULT '',`employeetypecode` varchar(15) DEFAULT '',`positioncode` varchar(15) DEFAULT '',`shiftcode` varchar(5) DEFAULT NULL,`contractperiod` tinyint(1) NOT NULL DEFAULT '0',`contractstartdate` date DEFAULT NULL,`contractenddate` date DEFAULT NULL,`datehired` date DEFAULT NULL,`dateregular` date DEFAULT NULL,`approvedby` varchar(15) DEFAULT '',`dateregistered` datetime DEFAULT NULL,`biometricid` varchar(10) NOT NULL DEFAULT '',`linkuserid` varchar(10) NOT NULL DEFAULT '',`linkclientid` varchar(15) NOT NULL DEFAULT '',`resigned` tinyint(1) NOT NULL DEFAULT '0',`dateresigned` date DEFAULT NULL,`profilepic` longblob,`attendancepassword` text, `actived` BOOLEAN NOT NULL DEFAULT 1,PRIMARY KEY (`employeeid`),KEY `employeeid` (`employeeid`),KEY `lastname` (`lastname`),KEY `firstname` (`firstname`),KEY `fullname` (`fullname`),KEY `officeid` (`officeid`),KEY `employeetypecode` (`employeetypecode`),KEY `positioncode` (`positioncode`),KEY `shiftcode` (`shiftcode`),KEY `biometricid` (`biometricid`),KEY `linkuserid` (`linkuserid`),KEY `linkclientid` (`linkclientid`)) ENGINE=MyISAM DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblemployeetype` (  `code` int(10) unsigned NOT NULL AUTO_INCREMENT,  `description` text NOT NULL,  `monthlyrate` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`code`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=1008 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollattendance` (`id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,`payrollcode` varchar(35) NOT NULL,`employeeid` varchar(25) NOT NULL,`biometricid` varchar(10) NOT NULL,`shiftcode` varchar(45) NOT NULL,`attendancedate` date NOT NULL,`dayofweek` varchar(10) NOT NULL,`regularday` tinyint(1) NOT NULL DEFAULT '1',`1st_timein` time DEFAULT NULL,`1st_timeout` time DEFAULT NULL,`2nd_timein` time DEFAULT NULL,`2nd_timeout` time DEFAULT NULL,`3rd_timein` time DEFAULT NULL,`3rd_timeout` time DEFAULT NULL,`regworkedhour` double NOT NULL DEFAULT '0',`totalworkedhour` double NOT NULL DEFAULT '0',`latecount` double NOT NULL DEFAULT '0',`undertimecount` double NOT NULL DEFAULT '0',`overtimecount` double NOT NULL DEFAULT '0',`overtimeapproved` tinyint(1) NOT NULL DEFAULT '0',`leaved` tinyint(1) NOT NULL DEFAULT '0',`leavedwithpay` tinyint(1) NOT NULL DEFAULT '0',`holiday` tinyint(1) NOT NULL DEFAULT '0',`holidaywithpay` tinyint(1) NOT NULL DEFAULT '0',`absent` tinyint(1) NOT NULL DEFAULT '0',`remarks` text,`checked` tinyint(1) NOT NULL DEFAULT '0',`checkedby` varchar(25) DEFAULT NULL,`approved` tinyint(1) NOT NULL DEFAULT '0',`approvedby` varchar(25) DEFAULT NULL,`capturedby` varchar(5) NOT NULL,`datecaptured` datetime NOT NULL,PRIMARY KEY (`id`),KEY `payrollcode` (`payrollcode`),KEY `employeeid` (`employeeid`),KEY `biometricid` (`biometricid`),KEY `shiftcode` (`shiftcode`),KEY `attendancedate` (`attendancedate`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollattendancelog` (`id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,`employeeid` varchar(25) NOT NULL,`logindate` date NOT NULL,`1st_timein` time DEFAULT NULL,`1st_timeout` time DEFAULT NULL,`2nd_timein` time DEFAULT NULL,`2nd_timeout` time DEFAULT NULL,`3rd_timein` time DEFAULT NULL,`3rd_timeout` time DEFAULT NULL,PRIMARY KEY (`id`),KEY `employeeid` (`employeeid`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `filedir`.`tblattendanceimage` (`id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,`employeeid` varchar(25) NOT NULL,`logindate` date NOT NULL,`1st_timein` longblob,`1st_timeout` longblob,`2nd_timein` longblob,`2nd_timeout` longblob,`3rd_timein` longblob,`3rd_timeout` longblob,PRIMARY KEY (`id`),KEY `employeeid` (`employeeid`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollautoaddallowances` (`id` int(10) unsigned NOT NULL AUTO_INCREMENT,`autoaddtype` int(1) NOT NULL DEFAULT '0',`subjectto` varchar(15) NOT NULL,`addcode` varchar(15) NOT NULL,`schedule` varchar(5) NOT NULL,`amount` double NOT NULL,`active` tinyint(1) NOT NULL DEFAULT '1',PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollautoadddeductions` (`id` int(10) unsigned NOT NULL AUTO_INCREMENT,`autoaddtype` int(1) NOT NULL DEFAULT '0',`subjectto` varchar(15) NOT NULL,`addcode` varchar(15) NOT NULL,`schedule` varchar(5) NOT NULL,`amount` double NOT NULL,`active` tinyint(1) NOT NULL DEFAULT '1',PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrolldedaddschedule` (`id` int(10) unsigned NOT NULL AUTO_INCREMENT,`employeeid` varchar(15) NOT NULL,`dedaddcode` varchar(15) NOT NULL,`deduction` tinyint(1) NOT NULL DEFAULT '0',`schedule` varchar(5) NOT NULL,`amount` double NOT NULL,`fixamount` tinyint(1) NOT NULL DEFAULT '1',`startingdate` date NOT NULL,`maturity` tinyint(1) NOT NULL DEFAULT '0',`datematurity` date NOT NULL,`active` tinyint(1) NOT NULL DEFAULT '1',PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrolldedaddsummary` (`id` int(10) unsigned NOT NULL AUTO_INCREMENT,`payrollcode` varchar(35) NOT NULL,`employeeid` varchar(15) NOT NULL,`dedaddcode` int(10) unsigned NOT NULL,`description` varchar(45) NOT NULL,`remarks` varchar(100) NOT NULL DEFAULT '',`deduction` tinyint(1) NOT NULL DEFAULT '1',`amount` double NOT NULL DEFAULT '0',PRIMARY KEY (`id`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrolldedaddtype` (  `code` int(10) unsigned NOT NULL AUTO_INCREMENT,  `description` varchar(45) NOT NULL,  `deduction` tinyint(1) NOT NULL DEFAULT '1',  PRIMARY KEY (`code`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrolldeductionlist` (`employeeid` varchar(25) NOT NULL,`payrollcode` varchar(45) NOT NULL,`dedcode` varchar(45) NOT NULL,`amount` double NOT NULL,`deductiondate` date NOT NULL,`closed` tinyint(1) NOT NULL DEFAULT '0',`deddate` date NOT NULL,PRIMARY KEY (`employeeid`)) ENGINE=MyISAM DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrolldeductionrange` (`id` int(10) unsigned NOT NULL AUTO_INCREMENT,`dedaddcode` varchar(25) NOT NULL,`range_from` double NOT NULL,`range_to` double NOT NULL,`employee_share` double NOT NULL,`employer_share` double NOT NULL,PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 ROW_FORMAT=FIXED;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollholiday` (`id` int(10) unsigned NOT NULL AUTO_INCREMENT,`officeid` varchar(8) NOT NULL DEFAULT '',`alloffice` tinyint(1) NOT NULL,`dateholiday` date NOT NULL,`description` varchar(50) NOT NULL,PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollpayoutaccounts` (`id` int(10) unsigned NOT NULL AUTO_INCREMENT,`employeeid` varchar(25) NOT NULL,`cardnumber` varchar(45) NOT NULL,`bankcode` varchar(45) NOT NULL,`usedefault` tinyint(1) NOT NULL DEFAULT '1',PRIMARY KEY (`id`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollpayoutbanks` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `bankcode` varchar(25) NOT NULL DEFAULT '',  `bankname` text NOT NULL,  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=103 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollpayoutbanks` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `bankcode` varchar(25) NOT NULL DEFAULT '',  `bankname` text NOT NULL,  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=103 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollperiod` (`payrollcode` varchar(20) NOT NULL,`schedulecode` varchar(7) NOT NULL,`computeattendance` tinyint(1) NOT NULL DEFAULT '0',`remarks` varchar(100) NOT NULL,`datefrom` date NOT NULL,`dateto` date NOT NULL,`createdby` varchar(5) NOT NULL,`datecreated` datetime NOT NULL,`cancelled` tinyint(1) NOT NULL DEFAULT '0',`cancelledby` varchar(5) DEFAULT NULL,`closed` tinyint(1) NOT NULL DEFAULT '0',`closedby` varchar(5) DEFAULT NULL,PRIMARY KEY (`payrollcode`)) ENGINE=MyISAM DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollbasicrate` (`code` int(10) unsigned NOT NULL AUTO_INCREMENT,`description` varchar(50) NOT NULL,`schedulecode` varchar(5) NOT NULL,`totalhours` int(10) unsigned NOT NULL DEFAULT '0',`ratepermonth` double NOT NULL,`rateperday` double NOT NULL,`rateperhour` double NOT NULL,`rateperminute` double NOT NULL DEFAULT '0',`taxexcempt` tinyint(1) NOT NULL DEFAULT '0',`sss` tinyint(1) NOT NULL DEFAULT '0',`philhealth` tinyint(1) NOT NULL DEFAULT '0',`pagibig` tinyint(1) NOT NULL DEFAULT '0',`savings` tinyint(1) NOT NULL DEFAULT '0',`enablelate` tinyint(1) NOT NULL DEFAULT '0',`laterate` double NOT NULL DEFAULT '0',`latetype` varchar(6) NOT NULL DEFAULT '',`enableundertime` tinyint(1) NOT NULL DEFAULT '0',`undertimerate` double NOT NULL DEFAULT '0',`undertimetype` varchar(6) NOT NULL DEFAULT '',`enableovertime` tinyint(1) NOT NULL DEFAULT '0',`overtimerate` double NOT NULL DEFAULT '0',`overtimetype` varchar(6) NOT NULL DEFAULT '',`enablensd` tinyint(1) NOT NULL DEFAULT '0',`nsdrate` double NOT NULL DEFAULT '0',`nsdtype` varchar(6) NOT NULL DEFAULT '',`nsdtimefrom` time NOT NULL DEFAULT '00:00:00',`nsdtimeto` time NOT NULL DEFAULT '00:00:00',`enablesaturday` tinyint(1) NOT NULL DEFAULT '0',`saturdayrate` double NOT NULL DEFAULT '0',`enablesunday` tinyint(1) NOT NULL DEFAULT '0',`sundayrate` double NOT NULL DEFAULT '0',`doublepayholiday` tinyint(1) NOT NULL DEFAULT '0',PRIMARY KEY (`code`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollschedule` (  `code` int(10) unsigned NOT NULL AUTO_INCREMENT,  `description` text NOT NULL,  `computeattendance` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`code`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollsettings` (`companycode` varchar(5) NOT NULL DEFAULT '0',`defaulttax` varchar(45) NOT NULL DEFAULT 'none',`defaultsss` varchar(45) NOT NULL DEFAULT 'none',`defaultpagibig` varchar(45) NOT NULL DEFAULT 'none',`defaultphilhealth` varchar(45) NOT NULL DEFAULT 'none',`defaultsavings` varchar(45) NOT NULL DEFAULT 'none',`taxpercent` double NOT NULL DEFAULT '0',`totalworkingdays` double NOT NULL DEFAULT '0',`totalworkinghours` double NOT NULL DEFAULT '0',`employeeidsequence` varchar(10) NOT NULL DEFAULT '',`biometricmodel` varchar(45) NOT NULL DEFAULT '',`biometrictemplate` varchar(45) NOT NULL DEFAULT '',PRIMARY KEY (`companycode`)) ENGINE=MyISAM DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollshiftsettings` ( `shiftcode` int(10) unsigned NOT NULL AUTO_INCREMENT, `description` varchar(45) NOT NULL, `def_1st_in` time NOT NULL, `def_1st_out` time NOT NULL, `flexibreaktime` tinyint(1) NOT NULL DEFAULT '0', `def_2nd_in` time NOT NULL, `def_2nd_out` time NOT NULL, `totalhours` double NOT NULL, `flexiregtime` tinyint(1) NOT NULL DEFAULT '0', PRIMARY KEY (`shiftcode`)) ENGINE=MyISAM AUTO_INCREMENT=1008 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollsummary` ( `id` int(10) unsigned NOT NULL AUTO_INCREMENT, `payrollcode` varchar(50) NOT NULL DEFAULT '', `ScheduleCode` varchar(5) NOT NULL DEFAULT '', `Schedule` varchar(100) NOT NULL DEFAULT '', `EmployeeID` varchar(15) NOT NULL DEFAULT '', `officeid` varchar(10) NOT NULL DEFAULT '', `Office` varchar(200) NOT NULL DEFAULT '', `Fullname` varchar(100) NOT NULL DEFAULT '', `EmployeeStatus` varchar(100) NOT NULL DEFAULT '', `Position` varchar(100) NOT NULL DEFAULT '', `SalaryRate` varchar(7) NOT NULL DEFAULT '', `RatePerMonth` double NOT NULL DEFAULT '0', `RatePerDay` double NOT NULL DEFAULT '0', `RatePerMinute` double NOT NULL DEFAULT '0', `SaturdayRate` double NOT NULL DEFAULT '0', `SundayRate` double NOT NULL DEFAULT '0', `MonthlyRate` tinyint(1) NOT NULL DEFAULT '0', `TotalWorkingDays` bigint(21) NOT NULL DEFAULT '0', `RenderedDays` bigint(21) NOT NULL DEFAULT '0', `Absent` bigint(21) NOT NULL DEFAULT '0', `HalfDay` bigint(21) NOT NULL DEFAULT '0', `LateCount` varchar(100) NOT NULL DEFAULT '', `LateRate` double NOT NULL DEFAULT '0', `TotalLate` double NOT NULL DEFAULT '0', `UndertimeCount` varchar(100) NOT NULL DEFAULT '', `UndertimeRate` double NOT NULL DEFAULT '0', `TotalUndertime` double NOT NULL DEFAULT '0', `OvertimeCount` varchar(100) NOT NULL DEFAULT '', `OvertimeRate` double NOT NULL DEFAULT '0', `TotalOvertime` double NOT NULL DEFAULT '0', `TotalAbsent` double NOT NULL DEFAULT '0', `TotalHalfDay` double NOT NULL DEFAULT '0', `Gross` double NOT NULL DEFAULT '0', `Tax` int(1) NOT NULL DEFAULT '0', `sss` double NOT NULL DEFAULT '0', `philhealth` double NOT NULL DEFAULT '0', `pagibig` double NOT NULL DEFAULT '0', `savings` double NOT NULL DEFAULT '0', `OtherAdditional` double NOT NULL DEFAULT '0', `OtherDeduction` double NOT NULL DEFAULT '0', `Approved` tinyint(1) NOT NULL DEFAULT '0', `TotalDeduction` double NOT NULL DEFAULT '0', `TotalAdditional` double NOT NULL DEFAULT '0', `NetGross` double NOT NULL DEFAULT '0', `NetPay` double NOT NULL DEFAULT '0', PRIMARY KEY (`id`), KEY `payrollcode` (`payrollcode`), KEY `ScheduleCode` (`ScheduleCode`), KEY `EmployeeID` (`EmployeeID`), KEY `officeid` (`officeid`), KEY `Office` (`Office`), KEY `Fullname` (`Fullname`)) ENGINE=InnoDB AUTO_INCREMENT=1323 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-07-03"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblpayrollshiftsettings` ADD COLUMN `flexiregtime` BOOLEAN NOT NULL AFTER `totalhours`, ADD COLUMN `flexibreaktime` BOOLEAN NOT NULL AFTER `def_1st_out`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollattendance` CHANGE COLUMN `totalworkedhour` `renderedcount` DOUBLE NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollsettings` ADD COLUMN `totalworkingmins` DOUBLE NOT NULL DEFAULT 0 AFTER `totalworkinghours`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollattendance` ADD COLUMN `halfday` BOOLEAN NOT NULL DEFAULT 0 AFTER `renderedcount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-07-06"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblpayrollpayslip` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `payrollcode` varchar(35) NOT NULL,  `employeeid` varchar(15) NOT NULL,  `dedaddcode` int(10) unsigned NOT NULL,  `description` varchar(45) NOT NULL,  `remarks` varchar(100) NOT NULL DEFAULT '',  `deduction` tinyint(1) NOT NULL DEFAULT '1',  `amount` double NOT NULL DEFAULT '0',  PRIMARY KEY (`id`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollperiod` CHANGE COLUMN `closed` `approved` TINYINT(1) NOT NULL DEFAULT 0, CHANGE COLUMN `closedby` `approvedby` VARCHAR(5) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL, ADD COLUMN `dateapproved` DATETIME AFTER `approvedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollperiod` DROP COLUMN `cancelled`, DROP COLUMN `cancelledby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollattendancelog` ADD INDEX `logindate`(`logindate`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollpayslip` ( `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `payrollcode` varchar(35) NOT NULL,  `employeeid` varchar(15) NOT NULL,  `dedaddcode` int(10) unsigned NOT NULL,  `description` varchar(45) NOT NULL,  `remarks` varchar(100) NOT NULL DEFAULT '',  `deduction` tinyint(1) NOT NULL DEFAULT '1',  `amount` double NOT NULL DEFAULT '0',  PRIMARY KEY (`id`) USING BTREE,  KEY `payrollcode` (`payrollcode`),  KEY `employeeid` (`employeeid`),  KEY `dedaddcode` (`dedaddcode`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollsummary` ( `id` int(10) unsigned NOT NULL AUTO_INCREMENT, `payrollcode` varchar(50) NOT NULL DEFAULT '', `ScheduleCode` varchar(5) CHARACTER SET utf8 NOT NULL DEFAULT '', `Schedule` varchar(100) NOT NULL DEFAULT '', `EmployeeID` varchar(15) CHARACTER SET utf8 NOT NULL DEFAULT '', `officeid` varchar(10) NOT NULL DEFAULT '', `Office` varchar(200) NOT NULL DEFAULT '', `Fullname` varchar(100) CHARACTER SET utf8 NOT NULL DEFAULT '', `EmployeeStatus` varchar(100) CHARACTER SET utf8 NOT NULL DEFAULT '', `Position` varchar(100) CHARACTER SET utf8 NOT NULL DEFAULT '', `SalaryRate` varchar(7) CHARACTER SET utf8 NOT NULL DEFAULT '', `RatePerMonth` double NOT NULL DEFAULT '0', `RatePerDay` double NOT NULL DEFAULT '0', `RatePerMinute` double NOT NULL DEFAULT '0', `SaturdayRate` double NOT NULL DEFAULT '0', `SundayRate` double NOT NULL DEFAULT '0', `MonthlyRate` tinyint(1) NOT NULL DEFAULT '0', `TotalWorkingDays` bigint(21) NOT NULL DEFAULT '0', `RenderedDays` bigint(21) NOT NULL DEFAULT '0', `Absent` bigint(21) NOT NULL DEFAULT '0', `HalfDay` bigint(21) NOT NULL DEFAULT '0', `LateCount` varchar(100) CHARACTER SET utf8 NOT NULL DEFAULT '', `LateRate` double NOT NULL DEFAULT '0', `TotalLate` double NOT NULL DEFAULT '0', `UndertimeCount` varchar(100) CHARACTER SET utf8 NOT NULL DEFAULT '', `UndertimeRate` double NOT NULL DEFAULT '0', `TotalUndertime` double NOT NULL DEFAULT '0', `OvertimeCount` varchar(100) CHARACTER SET utf8 NOT NULL DEFAULT '', `OvertimeRate` double NOT NULL DEFAULT '0', `TotalOvertime` double NOT NULL DEFAULT '0', `TotalAbsent` double NOT NULL DEFAULT '0', `TotalHalfDay` double NOT NULL DEFAULT '0', `Gross` double NOT NULL DEFAULT '0', `Tax` int(1) NOT NULL DEFAULT '0', `sss` double NOT NULL DEFAULT '0', `philhealth` double NOT NULL DEFAULT '0', `pagibig` double NOT NULL DEFAULT '0', `savings` double NOT NULL DEFAULT '0', `OtherAdditional` double NOT NULL DEFAULT '0', `OtherDeduction` double NOT NULL DEFAULT '0', `Approved` tinyint(1) NOT NULL DEFAULT '0', `TotalDeduction` double NOT NULL DEFAULT '0', `TotalAdditional` double NOT NULL DEFAULT '0', `NetGross` double NOT NULL DEFAULT '0', `NetPay` double NOT NULL DEFAULT '0', PRIMARY KEY (`id`), KEY `payrollcode` (`payrollcode`), KEY `ScheduleCode` (`ScheduleCode`), KEY `EmployeeID` (`EmployeeID`), KEY `officeid` (`officeid`), KEY `Office` (`Office`), KEY `Fullname` (`Fullname`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-07-07"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblpayrollpayremittance` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `payrollcode` varchar(35) NOT NULL,  `employeeid` varchar(15) NOT NULL,  `dedaddcode` int(10) unsigned NOT NULL,  `description` varchar(45) NOT NULL,  `employee_share` double NOT NULL DEFAULT '0',  `employer_share` double NOT NULL DEFAULT '0',  PRIMARY KEY (`id`) USING BTREE,  KEY `payrollcode` (`payrollcode`),  KEY `employeeid` (`employeeid`),  KEY `dedaddcode` (`dedaddcode`)) ENGINE=MyISAM AUTO_INCREMENT=1675 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-07-09"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `iconfolder` VARCHAR(15) NOT NULL DEFAULT 'default' AFTER `theme`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE `tblsystemiconpackage`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE `tblsystemiconlocation`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-07-14"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblpayrollsettings` ADD COLUMN `taxsched` INTEGER(2) UNSIGNED NOT NULL DEFAULT 31 AFTER `defaulttax`, ADD COLUMN `ssssched` INTEGER(2) UNSIGNED NOT NULL DEFAULT 31 AFTER `defaultsss`, ADD COLUMN `pagibigsched` INTEGER(2) UNSIGNED NOT NULL DEFAULT 31 AFTER `defaultpagibig`, ADD COLUMN `philhealthsched` INTEGER(2) UNSIGNED NOT NULL DEFAULT 31 AFTER `defaultphilhealth`, ADD COLUMN `savingssched` INTEGER(2) UNSIGNED NOT NULL DEFAULT 31 AFTER `defaultsavings`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-07-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblsalesaccountjournal` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `officeid` varchar(45) NOT NULL,  `trnsumcode` varchar(45) NOT NULL,  `itemcode` varchar(45) NOT NULL,  `accountno` varchar(45) NOT NULL,  `referenceno` varchar(45) NOT NULL DEFAULT '',  `debit` double NOT NULL DEFAULT '0',  `credit` double NOT NULL DEFAULT '0',  `remarks` text NOT NULL,  `trnby` varchar(15) NOT NULL,  `datetrn` datetime NOT NULL,  `affectcash` tinyint(1) NOT NULL DEFAULT '1',  `verified` tinyint(1) DEFAULT '0',  `verifiedby` varchar(10) DEFAULT NULL,  `dateverified` datetime DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(45) DEFAULT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `accountjournal` BOOLEAN NOT NULL DEFAULT 0 AFTER `othertransaction`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE  `tblsalessummary` CHANGE COLUMN `totaljournaldebit` `totalclientjournal` DOUBLE NOT NULL DEFAULT 0, CHANGE COLUMN `totaljournalcredit` `totalaccountjournal` DOUBLE NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD COLUMN `deleted` BOOLEAN NOT NULL DEFAULT 0 AFTER `hotelofficeid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-07-17"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsaleschecktransaction` ADD COLUMN `checkdate` DATE NOT NULL AFTER `checkdetails`, ADD COLUMN `notified` BOOLEAN NOT NULL DEFAULT 0 AFTER `checkdate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschecktransaction` ADD COLUMN `cleared` BOOLEAN NOT NULL DEFAULT 0 AFTER `verifiedby`, ADD COLUMN `clearedby` VARCHAR(15) AFTER `cleared`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschecktransaction` ADD COLUMN `datecleared` DATETIME AFTER `cleared`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-07-25"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `overages` DOUBLE NOT NULL DEFAULT 0 AFTER `totaldeposit`, ADD COLUMN `shortages` DOUBLE NOT NULL DEFAULT 0 AFTER `overages`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblsalessummary set overages=cashvariance where cashvariance > 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblsalessummary set shortages=cashvariance where cashvariance < 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblsalessummary set shortages=replace(shortages,'-','') where cashvariance < 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-07-26"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `popaymentsequence` VARCHAR(10) NOT NULL DEFAULT '' AFTER `enablectaadvancepayment`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpaymenttransactions` ADD COLUMN `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT first, DROP PRIMARY KEY, ADD PRIMARY KEY  USING BTREE(`id`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayabletransactions` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `trnid` varchar(45) NOT NULL,  `transactiontype` varchar(15) NOT NULL,  `accountno` varchar(25) NOT NULL,  `paymenttype` varchar(45) NOT NULL DEFAULT '',  `totalamount` double NOT NULL DEFAULT '0',  `paymentamount` double NOT NULL DEFAULT '0',  `discount` double NOT NULL DEFAULT '0',  `depositpaymentchange` tinyint(1) NOT NULL DEFAULT '0',  `variance` double NOT NULL DEFAULT '0',  `note` varchar(500) NOT NULL,  `depositto` varchar(45) NOT NULL,  `datetrn` datetime NOT NULL,  `trnby` varchar(15) NOT NULL,  `verified` tinyint(1) NOT NULL DEFAULT '0',  `verifiedby` varchar(45) DEFAULT NULL,  `dateverified` datetime DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(45) DEFAULT NULL,  `datecancelled` datetime DEFAULT NULL,  PRIMARY KEY (`id`) USING BTREE,  KEY `accountno` (`accountno`),  KEY `depositto` (`depositto`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "INSERT INTO tblpayabletransactions SELECT * FROM `tblpaymenttransactions` where transactiontype='payables';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DELETE FROM `tblpaymenttransactions` where transactiontype='payables';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayablechecktransaction` (  `trnid` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `trnsumcode` varchar(20) NOT NULL DEFAULT '0', `accountno` varchar(25) NOT NULL,  `referenceno` varchar(25) DEFAULT NULL,  `checkno` varchar(45) NOT NULL DEFAULT '',  `checkdetails` varchar(255) NOT NULL,  `checkdate` date NOT NULL,  `notified` tinyint(1) NOT NULL DEFAULT '0',  `remarks` varchar(145) NOT NULL,  `amount` double NOT NULL DEFAULT '0',  `datetrn` datetime NOT NULL,  `trnby` varchar(15) NOT NULL,  `verified` tinyint(1) NOT NULL DEFAULT '0',  `dateverified` datetime DEFAULT NULL,  `verifiedby` varchar(15) DEFAULT NULL,  `cleared` tinyint(1) NOT NULL DEFAULT '0',  `datecleared` datetime DEFAULT NULL,  `clearedby` varchar(15) DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(45) DEFAULT NULL,  `datecancelled` datetime DEFAULT NULL,  PRIMARY KEY (`trnid`) USING BTREE,  KEY `trnsumcode` (`trnsumcode`),  KEY `accountno` (`accountno`),  KEY `referenceno` (`referenceno`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "INSERT INTO tblpayablechecktransaction SELECT * FROM `tblsaleschecktransaction` where left(accountno,4)='SPR-';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DELETE FROM `tblsaleschecktransaction` where left(accountno,4)='SPR-';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglsettings` RENAME TO `tblglsettings_old`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblglsettings` ( `companycode` varchar(5) NOT NULL, `cashierbegcashamt` varchar(10) NOT NULL DEFAULT '', `cashierbegcashfrom` varchar(10) NOT NULL DEFAULT '', `salescode` varchar(10) NOT NULL DEFAULT '', `acctrecievable` varchar(10) NOT NULL DEFAULT '', `clientpayment` varchar(10) NOT NULL DEFAULT '', `pointofsale` varchar(10) NOT NULL DEFAULT '', `creditcard` varchar(10) NOT NULL DEFAULT '', `popayable` varchar(10) NOT NULL DEFAULT '', `paymentdiscount` varchar(10) NOT NULL DEFAULT '', `popayment` varchar(10) NOT NULL DEFAULT '', `popaymentdiscount` varchar(10) NOT NULL DEFAULT '', `bankbegcode` varchar(10) NOT NULL DEFAULT '', `overages` varchar(10) NOT NULL DEFAULT '', `shortages` varchar(10) NOT NULL DEFAULT '', `taxrate` varchar(10) NOT NULL DEFAULT '', `incomeglcode` varchar(10) NOT NULL DEFAULT '', `expenseglcode` varchar(10) NOT NULL DEFAULT '', `checkdeposit` varchar(10) NOT NULL DEFAULT '', `checkpayment` varchar(10) NOT NULL DEFAULT '', PRIMARY KEY (`companycode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschecktransaction` ADD COLUMN `depositto` VARCHAR(15)  AFTER `clearedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayablechecktransaction` ADD COLUMN `checkingaccount` VARCHAR(15) NOT NULL DEFAULT '' AFTER `referenceno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgljournal` MODIFY COLUMN `remarks` VARCHAR(245) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-07-27"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsaleschecktocash` ADD COLUMN `cleared` BOOLEAN NOT NULL DEFAULT 0 AFTER `dateverified`, ADD COLUMN `clearedby` VARCHAR(10) AFTER `cleared`, ADD COLUMN `datecleared` DATETIME AFTER `clearedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschecktocash` ADD COLUMN `checkdate` DATE NOT NULL DEFAULT '0000-00-00' AFTER `checkdetails`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschecktocash` CHANGE COLUMN `checkdetails` `issuerbank` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschecktocash` ADD COLUMN `companyname` VARCHAR(45) NOT NULL AFTER `issuerbank`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschecktocash` ADD COLUMN `notified` BOOLEAN NOT NULL DEFAULT 0 AFTER `checkdate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsaleschecktocash` ADD COLUMN `depositto` VARCHAR(15) AFTER `clearedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbillsandpayables` ADD COLUMN `paymenttype` VARCHAR(6) NOT NULL default '' AFTER `referenceno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `emailnotifysales` BOOLEAN NOT NULL DEFAULT 0 AFTER `popaymentsequence`, ADD COLUMN `emailnotifycheckdue` BOOLEAN NOT NULL DEFAULT 0 AFTER `emailnotifysales`, ADD COLUMN `emailnotifyattendancelog` BOOLEAN NOT NULL DEFAULT 0 AFTER `emailnotifycheckdue`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `notifysales` BOOLEAN NOT NULL DEFAULT 0 AFTER `cashbeggining`, ADD COLUMN `notifycheckdue` BOOLEAN NOT NULL DEFAULT 0 AFTER `notifysales`, ADD COLUMN `notifyattendancelog` BOOLEAN NOT NULL DEFAULT 0 AFTER `notifycheckdue`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `notified` BOOLEAN NOT NULL DEFAULT 0 AFTER `closedby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-07-29"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblpayrollattendancelog` ADD COLUMN `notified` BOOLEAN NOT NULL DEFAULT 0 AFTER `3rd_timeout`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblsalessummary` set notified=1 where dateopen<>current_date;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblpayrollattendancelog` set notified=1 where logindate<>current_date;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblsaleschecktocash` set notified=1 where checkdate='0000-00-00';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblsaleschecktransaction` set notified=1 where checkdate='0000-00-00';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblpayablechecktransaction` set notified=1 where checkdate='0000-00-00';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `emailnotifyreceivedpostock` BOOLEAN NOT NULL DEFAULT 0 AFTER `emailnotifyattendancelog`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `notifyreceivedpostock` BOOLEAN NOT NULL DEFAULT 0 AFTER `notifyattendancelog`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE  `tblglsettings` ADD COLUMN `gltype` VARCHAR(45) NOT NULL AFTER `checkpayment`, ADD COLUMN `value` VARCHAR(45) NOT NULL AFTER `gltype`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-08-02"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblsalescashdenomination` ( `trnid` int(10) unsigned NOT NULL AUTO_INCREMENT, `trnsumcode` varchar(8) NOT NULL DEFAULT '', `onethousand` double NOT NULL DEFAULT '0', `fivehundred` double NOT NULL DEFAULT '0', `twohundred` double NOT NULL DEFAULT '0', `onehundred` double NOT NULL DEFAULT '0', `fithty` double NOT NULL DEFAULT '0', `twenty` double NOT NULL DEFAULT '0', `ten` double NOT NULL DEFAULT '0', `five` double NOT NULL DEFAULT '0', `one` double NOT NULL DEFAULT '0', `others` double NOT NULL DEFAULT '0', `totalbills` double NOT NULL DEFAULT '0', `totalcoins` double NOT NULL DEFAULT '0', `totalamount` double NOT NULL DEFAULT '0', `timeposted` time NOT NULL, PRIMARY KEY (`trnid`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalesautoservices` (  `trncode` varchar(8) NOT NULL,  `cifid` varchar(15) NOT NULL,  `carmodel` varchar(45) NOT NULL,  `platenumber` varchar(45) NOT NULL,  `recomendation` text,  `datetrn` datetime NOT NULL,  `trnby` varchar(5) NOT NULL,  `closed` tinyint(1) NOT NULL DEFAULT '0',  `dateclosed` datetime DEFAULT NULL,  `closedby` varchar(5) NOT NULL DEFAULT '',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(5) NOT NULL DEFAULT '',  `datecancelled` datetime DEFAULT NULL,  `notifiedopen` tinyint(1) NOT NULL DEFAULT '0',  `notifiedclosed` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`trncode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalesautotransaction` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `trncode` varchar(8) NOT NULL,  `batchcode` varchar(15) NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `autoservices` BOOLEAN NOT NULL DEFAULT 0 AFTER `roomoccupancy`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `autoservicessequence` VARCHAR(10) NOT NULL DEFAULT '' AFTER `emailnotifyreceivedpostock`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-08-04"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `emailnotifyautoservices` BOOLEAN NOT NULL DEFAULT 0 AFTER `emailnotifyreceivedpostock`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `notifyautoservices` TINYINT(1) NOT NULL DEFAULT 0 AFTER `notifyreceivedpostock`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpurchaseorder` ADD COLUMN `notified` BOOLEAN NOT NULL DEFAULT 0 AFTER `delivered`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblpurchaseorder` set notified=1 where delivered=1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblnotifylist set isnotify=0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            If MessageBox.Show("Do you want to activate server realtime timer?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "UPDATE `tblgeneralsettings` set enableservertimer=1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            engineupdated = True
        End If

        updateVersion = "2016-08-05"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblreportsetting` DROP COLUMN `title`, DROP COLUMN `customtext`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblreportsetting` ADD COLUMN `reporttitle` VARCHAR(105) NOT NULL AFTER `formname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-08-12"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            'com.CommandText = "ALTER TABLE `tblpurchaseorderitem` ADD COLUMN `inventorytype` VARCHAR(10) NOT NULL DEFAULT '' AFTER `total`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            'com.CommandText = "update `tblpurchaseorderitem` set inventorytype='consumable';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblemployees` ADD COLUMN `actived` BOOLEAN NOT NULL DEFAULT 1 AFTER `attendancepassword`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` MODIFY COLUMN `inventorymethod` VARCHAR(5) NOT NULL DEFAULT 'lifo';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblprocategory` DROP COLUMN `ffecode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-08-13"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblinventoryledger` ( `id` int(10) unsigned NOT NULL AUTO_INCREMENT, `officeid` varchar(10) NOT NULL DEFAULT '', `productid` varchar(45) NOT NULL DEFAULT '', `trntype` varchar(45) NOT NULL DEFAULT '', `debit` double NOT NULL DEFAULT '0', `credit` double NOT NULL DEFAULT '0', `remarks` varchar(500) DEFAULT '', `datetrn` datetime NOT NULL, `trnby` varchar(45) DEFAULT NULL, PRIMARY KEY (`id`) USING BTREE) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            If MessageBox.Show("This confirmation script is to create new inventory ledger! " & Environment.NewLine & Environment.NewLine & "Please select the following: " & Environment.NewLine _
                                        + "     1. CLICK YES if you want to migrate all existing inventory logs" & Environment.NewLine _
                                        + "     2. CLICK NO if your want to start with beginning inventory logs", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "insert into tblinventoryledger (officeid,productid,trntype,debit,credit,remarks,datetrn,trnby) select * from (select officeid, productid,'Manual Inventory' ,quantity,0,if(remarks='','manual stockin',remarks), datetrn as dt,(select fullname from tblaccounts where accountid =tblinventorylogs.trnby) from tblinventorylogs where confirmed=1 union all select officeid, productid,'Purchase Order',quantity,0,concat('Purchase Order #',ponumber),datetrn as dt,(select fullname from tblaccounts where accountid = tblpurchaseorderitem.trnby) from tblpurchaseorderitem where delivered=1 union all select officeid, productid,'POS SOLD',0,quantity, concat('Transaction #',batchcode),datetrn as dt,(select fullname from tblaccounts where accountid = tblsalestransaction.userid) from tblsalestransaction  where cancelled = 0 and void=0 union all select inventory_to, itemid,'Received Stock',quantity,0,concat('Received from ',(select lcase(officename) from tblcompoffice where officeid=tbltransferbatch.inventory_from)),datetrn as dt,(select fullname from tblaccounts where accountid = tbltransferbatch.confirmedby) from tbltransferitem inner join tbltransferbatch on tbltransferbatch.batchcode = tbltransferitem.batchcode where cancelled=0 and confirmed=1 union all select inventory_from,itemid,'Transfer Stock',0,quantity,concat('Transfer to ',(select lcase(officename) from tblcompoffice where officeid=tbltransferbatch.inventory_to)),datetrn as dt,(select fullname from tblaccounts where accountid = tbltransferbatch.trnby) from tbltransferitem inner join tbltransferbatch on tbltransferbatch.batchcode = tbltransferitem.batchcode where cancelled=0 and confirmed=1 union all select officeid,productid,'Inventory Adjustment',if(fromquantity<newquantity,newquantity-fromquantity,0),0,if(remarks='','adjustment',lcase(remarks)),dateadj as dt,(select fullname from tblaccounts where accountid = tblinventoryadjustment.trnby) FROM `tblinventoryadjustment` where if(fromquantity<newquantity,newquantity-fromquantity,0) > 0 union all select officeid,productid,'Inventory Adjustment',0,if(fromquantity>newquantity,fromquantity-newquantity,0),if(remarks='','adjustment',lcase(remarks)),dateadj as dt,(select fullname from tblaccounts where accountid = tblinventoryadjustment.trnby) FROM `tblinventoryadjustment` where if(fromquantity>newquantity,fromquantity-newquantity,0) > 0 union all select fromofficeid,productid,'Inventory Stockout',0,quantity,if(remarks='','stock out',lcase(remarks)),datetrn as dt,(select fullname from tblaccounts where accountid = tblstockoutitem.trnby) from tblstockoutitem union all select officeid,productid,'Returned Item',quantity,0,concat('Batchcode #',batchrefcode), datereturn as dt, (select fullname from tblaccounts where accountid = tblsalesreturneditem.trnby) from tblsalesreturneditem where returntoinventory=1 and cancelled=0) as s order by dt asc;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            Else
                com.CommandText = "insert into tblinventoryledger (officeid,productid,trntype,debit,credit,remarks,datetrn,trnby) select officeid,productid,'Balance Forward',quantity,0,'beginning inventory',current_timestamp,'System administrator' from tblinventory where quantity>0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            com.CommandText = "delete FROM `tblinventoryledger` where productid='';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `cffecodesequence` VARCHAR(20) NOT NULL DEFAULT '00000000' AFTER `autoservicessequence`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblinventoryffe`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblinventoryffe` ( `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT, `ffecode` varchar(45) NOT NULL DEFAULT 'undefined', `ponumber` varchar(45) NOT NULL, `officeid` varchar(25) NOT NULL, `productid` varchar(45) NOT NULL, `productname` varchar(500) NOT NULL, `catid` varchar(10) NOT NULL, `categoryname` varchar(500) NOT NULL, `quantity` double NOT NULL DEFAULT '0', `unit` varchar(10) NOT NULL, `unitcost` double NOT NULL DEFAULT '0', `totalamount` double NOT NULL DEFAULT '0', `vendorid` varchar(25) NOT NULL, `stockhouseid` varchar(15) NOT NULL DEFAULT 'default', `remarks` longtext, `datepurchased` datetime NOT NULL, `depreciationmode` tinyint(1) unsigned NOT NULL DEFAULT '0', `depreciationvalue` double NOT NULL DEFAULT '0', `trnby` varchar(10) NOT NULL, `datetrn` datetime NOT NULL, `disposed` tinyint(1) NOT NULL DEFAULT '0', `disposedremarks` text, PRIMARY KEY (`id`) USING BTREE, KEY `ffecode` (`ffecode`), KEY `ponumber` (`ponumber`), KEY `productid` (`productid`), KEY `catid` (`catid`), KEY `officeid` (`officeid`), KEY `vendorid` (`vendorid`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblglobalproducts set sellingprice=(select sellingprice from tblinventory where productid=tblglobalproducts.productid and sellingprice>0 limit 1) where sellingprice=0 and productid in (select productid from tblinventory where sellingprice>0);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblinventory set sellingprice=(select sellingprice from tblglobalproducts where productid=tblinventory.productid and sellingprice>0 limit 1) where sellingprice=0 and productid in (select productid from tblglobalproducts where sellingprice>0);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "delete FROM `tblglobalproducts` where itemname='';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        'inventory fifo function activated
        updateVersion = "2016-08-14"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `inventorytrnid` INTEGER UNSIGNED NOT NULL DEFAULT 0 AFTER `prevquantity`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesclientchargesitem` ADD COLUMN `inventorytrnid` INTEGER UNSIGNED NOT NULL DEFAULT 0 AFTER `prevquantity`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesreturneditem` ADD COLUMN `inventorytrnid` INTEGER UNSIGNED NOT NULL DEFAULT 0 AFTER `productid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-08-19"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblpayrolldedaddsummary` ADD COLUMN `datecover` DATE AFTER `deduction`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollpayslip` ADD COLUMN `datecover` DATE AFTER `deduction`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-08-20"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalesautoservices` ADD COLUMN `odometer` DOUBLE NOT NULL AFTER `platenumber`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-08-21"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblinventorylogs` ADD COLUMN `stockhouseid` VARCHAR(15) NOT NULL DEFAULT 'default' AFTER `officeid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-08-22"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableposcashiersummaryview` BOOLEAN NOT NULL DEFAULT 1 AFTER `cffecodesequence`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-08-26"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableposcashdrawer` BOOLEAN NOT NULL DEFAULT 1 AFTER `enableposcashiersummaryview`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            If MessageBox.Show("Do you want to enable enable pos cash drawer?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "UPDATE tblgeneralsettings set enableposcashdrawer=1" : com.ExecuteNonQuery()
            Else
                com.CommandText = "UPDATE tblgeneralsettings set enableposcashdrawer=0" : com.ExecuteNonQuery()
            End If

            engineupdated = True
        End If

        updateVersion = "2016-08-28"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            If MessageBox.Show("This confirmation script is to reset inventory ledger! Do you want to reset current inventory ledger?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "DELETE FROM tblinventoryledger" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "ALTER TABLE tblinventory AUTO_INCREMENT = 1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "INSERT INTO tblinventoryledger (officeid,productid,trntype,debit,credit,remarks,datetrn,trnby) select officeid,productid,'Balance Forward',quantity,0,'beginning inventory',current_timestamp,'System administrator' from tblinventory where quantity>0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableviewsalescashendreport` BOOLEAN NOT NULL DEFAULT 1 AFTER `enableposcashdrawer`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblemailnotification` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `trntype` varchar(105) NOT NULL,  `receiver` varchar(105) NOT NULL,  `subject` varchar(500) NOT NULL DEFAULT '',  `emailbody` longtext,  `notified` tinyint(1) NOT NULL DEFAULT '0',  `datenotified` datetime DEFAULT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-08-29"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalessummary` CHANGE COLUMN `totalaccountjournal` `debitaccountjournal` DOUBLE NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `creaditaccountjournal` DOUBLE NOT NULL DEFAULT 0 AFTER `debitaccountjournal`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-08-30"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblbankaccounts` ADD COLUMN `enableemailnotification` BOOLEAN NOT NULL DEFAULT 0 AFTER `datesaved`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgljournal` ADD COLUMN `notified` BOOLEAN NOT NULL DEFAULT 0 AFTER `datecancelled`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `emailnotifybanksledger` BOOLEAN NOT NULL DEFAULT 0 AFTER `enableviewsalescashendreport`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `notifybanksledger` BOOLEAN NOT NULL DEFAULT 0 AFTER `notifyautoservices`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `emailnotifymonthlysummary` BOOLEAN NOT NULL DEFAULT 0 AFTER `emailnotifybanksledger`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `notifymonthlysummary` BOOLEAN NOT NULL DEFAULT 0 AFTER `notifybanksledger`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `backdateremarks` VARCHAR(50) NOT NULL DEFAULT '' AFTER `backdate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-09-04"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            If MessageBox.Show("This confirmation script is to drop table gl item! are you sure you want to continue? Note: after droping table gl item, please update new chart of accounts", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "DROP TABLE IF EXISTS `tblglitem`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "CREATE TABLE  `tblglitem` (  `groupcode` varchar(20) NOT NULL,  `itemcode` varchar(20) NOT NULL,  `itemname` varchar(100) NOT NULL DEFAULT '',  `parent` varchar(20) NOT NULL,  `glgroup` tinyint(1) NOT NULL DEFAULT '0',  `gl` tinyint(1) NOT NULL DEFAULT '0',  `sl` tinyint(1) NOT NULL DEFAULT '0',  `level` int(10) unsigned NOT NULL DEFAULT '0',  PRIMARY KEY (`itemcode`),  KEY `groupcode` (`groupcode`),  KEY `itemcode` (`itemcode`),  KEY `itemname` (`itemname`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            engineupdated = True
        End If

        updateVersion = "2016-09-07"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgljournal` RENAME TO `tblglaccountledger`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblgljournal` ( `id` int(10) unsigned NOT NULL AUTO_INCREMENT, `reference` varchar(15) NOT NULL DEFAULT '', `officeid` varchar(45) NOT NULL DEFAULT '', `groupcode` varchar(5) NOT NULL DEFAULT '', `itemcode` varchar(10) NOT NULL DEFAULT '', `itemname` varchar(100) NOT NULL DEFAULT '', `debit` double NOT NULL DEFAULT '0', `credit` double NOT NULL DEFAULT '0', `remarks` varchar(500) NOT NULL DEFAULT '', `datetrn` datetime NOT NULL DEFAULT '0000-00-00 00:00:00', `trnby` varchar(100) NOT NULL DEFAULT '', `verified` tinyint(1) NOT NULL DEFAULT '0', `dateverified` datetime NOT NULL DEFAULT '0000-00-00 00:00:00', `verifiedby` varchar(100) DEFAULT '', `cleared` tinyint(1) NOT NULL DEFAULT '0', `datecleared` datetime NOT NULL DEFAULT '0000-00-00 00:00:00', `clearedby` varchar(100) NOT NULL DEFAULT '', `cancelled` tinyint(1) NOT NULL DEFAULT '0', `cancelledby` varchar(100) NOT NULL DEFAULT '', `datecancelled` datetime NOT NULL DEFAULT '0000-00-00 00:00:00', PRIMARY KEY (`id`) USING BTREE, KEY `itemcode` (`itemcode`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltransactioncode` CHANGE COLUMN `glcode` `gldebit` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, ADD COLUMN `glcredit` VARCHAR(10) NOT NULL AFTER `gldebit`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `journalentries` BOOLEAN NOT NULL DEFAULT 0 AFTER `accountjournal`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `deleted` BOOLEAN NOT NULL DEFAULT 0 AFTER `notifymonthlysummary`, ADD COLUMN `datedeleted` DATETIME AFTER `deleted`, ADD COLUMN `deletedby` VARCHAR(100) NOT NULL DEFAULT '' AFTER `datedeleted`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `deleted` BOOLEAN NOT NULL DEFAULT 0 AFTER `approved`, ADD COLUMN `datedeleted` DATETIME AFTER `deleted`, ADD COLUMN `deletedby` VARCHAR(100) NOT NULL DEFAULT '' AFTER `datedeleted`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-09-12"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "DROP TABLE tblglobalproductshistory;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblemailnotification` MODIFY COLUMN `trntype` VARCHAR(1024) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL, MODIFY COLUMN `receiver` VARCHAR(1024) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL, MODIFY COLUMN `subject` VARCHAR(1024) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesautoservices` DROP COLUMN `notifiedopen`, DROP COLUMN `notifiedclosed`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpurchaseorder` DROP COLUMN `notified`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblsalessummary SET notified=0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblsalessummary set notified=1 where (month(dateopen) < month(current_date)-1 or year(dateopen) < year(current_date)) and notified=0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglaccountledger` ADD INDEX `debit`(`debit`), ADD INDEX `credit`(`credit`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltransactioncode` ADD INDEX `gldebit`(`gldebit`), ADD INDEX `glcredit`(`glcredit`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `inventory` BOOLEAN NOT NULL DEFAULT 0 AFTER `prevquantity`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblsalestransaction inner join tblglobalproducts on tblsalestransaction.productid = tblglobalproducts.productid set inventory=if(forcontract=1,0,1);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgljournal` ADD COLUMN `addtocashiercash` BOOLEAN NOT NULL DEFAULT 0 AFTER `credit`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblglticket` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `reference` varchar(100) NOT NULL,  `officeid` varchar(45) NOT NULL DEFAULT '',  `groupcode` varchar(5) NOT NULL DEFAULT '',  `itemcode` varchar(10) NOT NULL DEFAULT '',  `itemname` varchar(100) NOT NULL DEFAULT '',  `debit` double NOT NULL DEFAULT '0',  `credit` double NOT NULL DEFAULT '0',  `remarks` varchar(500) NOT NULL DEFAULT '',  `datetrn` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',  `trnby` varchar(100) NOT NULL DEFAULT '',  `cleared` tinyint(1) NOT NULL DEFAULT '0',  `datecleared` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',  `clearedby` varchar(100) NOT NULL DEFAULT '',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(100) NOT NULL DEFAULT '',  `datecancelled` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',  PRIMARY KEY (`id`) USING BTREE,  KEY `itemcode` (`itemcode`)) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-09-15"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` MODIFY COLUMN `clientpaymentreceipttemplate` VARCHAR(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '', MODIFY COLUMN `clientpaymentreceiptsequence` VARCHAR(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '', ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            'com.CommandText = "ALTER TABLE `tblinventoryffe` MODIFY COLUMN `productname` VARCHAR(500) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `categoryname` VARCHAR(500) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-09-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            If MessageBox.Show("This confirmation script exclusive for katipunan bank only and update its product name and categoryname on table inventory and purchase order. do you want to continue execute update?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "UPDATE `tblcompanysettings` set digitalsign=null;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "update tblinventory inner join  tblglobalproducts on tblinventory.productid = tblglobalproducts.productid set productname=tblglobalproducts.itemname;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "update tblinventory inner join  tblprocategory on tblinventory.catid=tblprocategory.catid set categoryname=tblprocategory.description;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "update tblpurchaseorderitem inner join  tblglobalproducts on tblpurchaseorderitem.productid = tblglobalproducts.productid set tblpurchaseorderitem.itemname=tblglobalproducts.itemname;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "DELETE FROM tblinventoryledger" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "ALTER TABLE tblinventory AUTO_INCREMENT = 1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "INSERT INTO tblinventoryledger (officeid,productid,trntype,debit,credit,remarks,datetrn,trnby) select officeid,productid,'Balance Forward',quantity,0,'beginning inventory',current_timestamp,'System administrator' from tblinventory where quantity>0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            com.CommandText = "DELETE FROM `tblproductrequest`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblproductrequest` DROP COLUMN `procost`, DROP COLUMN `newvendor`, DROP COLUMN `vendorid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblproductrequest` MODIFY COLUMN `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT = 1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `procurementemailaddress` VARCHAR(105) NOT NULL DEFAULT '' AFTER `emailnotifymonthlysummary`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-09-22"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblinventorylocked` (  `trnid` int(10) unsigned NOT NULL AUTO_INCREMENT,  `cutoff` date NOT NULL,  `officeid` varchar(15) NOT NULL,  `stockhouseid` varchar(15) DEFAULT 'default',  `catid` varchar(10) NOT NULL,  `categoryname` varchar(250) DEFAULT NULL,  `productid` varchar(45) NOT NULL,  `productname` varchar(350) DEFAULT NULL,  `quantity` double NOT NULL DEFAULT '0',  `unit` varchar(50) DEFAULT NULL,  `purchasedprice` double NOT NULL DEFAULT '0',  `calcsellrate` double NOT NULL DEFAULT '0',  `sellingprice` double NOT NULL DEFAULT '0',  `lastupdate` datetime NOT NULL,  `lasttrnby` varchar(15) NOT NULL,  `dateinventory` datetime NOT NULL,  PRIMARY KEY (`trnid`) USING BTREE,  KEY `officeid` (`officeid`),  KEY `stockhouseid` (`stockhouseid`),  KEY `catid` (`catid`),  KEY `categoryname` (`categoryname`),  KEY `productid` (`productid`),  KEY `productname` (`productname`),  KEY `unit` (`unit`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventory` ADD COLUMN `prepaid` BOOLEAN NOT NULL DEFAULT 0 AFTER `productname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventorylocked` ADD COLUMN `prepaid` BOOLEAN NOT NULL DEFAULT 0 AFTER `productname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblinventory inner join tblprocategory on tblprocategory.catid = tblinventory.catid set tblinventory.prepaid=tblprocategory.prepaid;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-09-24"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `filedir`.`tblffeattachment` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `ffecode` varchar(10) NOT NULL,  `img` longblob,  `datetrn` date NOT NULL,  `trnby` varchar(25) NOT NULL,  PRIMARY KEY (`id`),  KEY `ffecode` (`ffecode`)) ENGINE=MyISAM DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblcompoffice` set inventorymethod='fifo';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE `tblinventorydetails`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `ffetype` VARCHAR(10) NOT NULL DEFAULT '' AFTER `deletedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-10-14"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblemployees` MODIFY COLUMN `shiftcode` VARCHAR(8) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))

            updateDescription += " - Added inventory assets monthly summary cut-off for accounting reports (must be locked every month-end) <br/>" _
                               + " - Update table inventory for separation of prepaid and on-hand inventory  <br/>" _
                               + " - Added email notification of coffeecup system update for user awareness <br/>" _
                               + " - Added FFE Management functions for accounting  <br/>" _
                               + " - Error fixed when adding new employees of HR & payroll module <br/>" _
                               + " - Error fixed of total amount of TRA on sales function due to old inventory stock are completely sold (Note: previous sales transaction are not affected. only printing has a problem) <br/>"
            engineupdated = True
        End If

        updateVersion = "2016-10-15"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblprocategory` DROP COLUMN `ffecode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblprocategory` ADD COLUMN `noninventory` BOOLEAN NOT NULL DEFAULT 0 AFTER `prepaid`, ADD COLUMN `consumable` BOOLEAN NOT NULL DEFAULT 0 AFTER `noninventory`, ADD COLUMN `ffe` BOOLEAN NOT NULL DEFAULT 0 AFTER `consumable`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblprocategory` DROP COLUMN `inventorymethod`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblprocategory set noninventory=1 where uses=0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblprocategory set consumable=1 where uses=1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblprocategory set ffe=1 where uses=2;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblprocategory` DROP COLUMN `uses`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblprocategory` ADD COLUMN `enablereqfilter` BOOLEAN NOT NULL DEFAULT 0 AFTER `ffe`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblprocategory set enablereqfilter=1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblprocategory` CHANGE COLUMN `potypeid` `potypeid` VARCHAR(45) after enablereqfilter;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))

            updateDescription += " - Enable filter by FFE type on Product Management <br/> " _
                               + " - Change Product Category Setup <br/> " _
                               + " - Added POS transaction lock. to prevent both cashier and processors accessing the same transaction code <br/>" _
                               + " - Fixed issue on adding new supplier <br/> " _
                               + " - Fixed issue on printing of client statement of account direct printing <br/> " _
                               + " - Cashiers processors can now initially enter clients payment to make cashier's transactions faster (Note: cashier's function is only to validate if the payment is correctly entered)"
            engineupdated = True
        End If

        updateVersion = "2016-10-21"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblunitconverterdetails` ADD COLUMN `productname` VARCHAR(500) NOT NULL AFTER `productid`, ADD INDEX `productname`(`productname`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblunitconverter` ADD COLUMN `productname` VARCHAR(500) NOT NULL AFTER `productid`, ADD INDEX `productname`(`productname`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))

            updateDescription += " - Fixed issue that cashiers cannot load initial payment entered by processor on charge to client accounts"

            engineupdated = True
        End If

        updateVersion = "2016-10-23"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblunitconverter` DROP COLUMN `productname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblunitconverterdetails` DROP COLUMN `productname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblunitconverter` MODIFY COLUMN `convcode` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT = 1000;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-10-27"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "update `tblitemvendor` set lastupdate=current_timestamp;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Improved and Enhanced of Purchase Order function to fast Purchasing process<br/> " _
                               + " - Added Product Price List Menu on Product Management > Right Click > View Product Price List <br/> " _
                               + " - Added view inventory cutoff details on cutoff inventory summary <br/> "
            engineupdated = True
        End If

        updateVersion = "2016-11-03"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblproductrequest` DROP COLUMN `received`, DROP COLUMN `status`, ADD COLUMN `confirmed` BOOLEAN NOT NULL DEFAULT 0 AFTER `daterequest`, ADD COLUMN `dateconfirmed` DATETIME AFTER `confirmed`, ADD COLUMN `confirmedby` VARCHAR(45) AFTER `dateconfirmed`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-11-06"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "DROP table `tblrequisitions`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblrequisitions` (  `pid` varchar(45) NOT NULL,  `requestby` int(10) unsigned NOT NULL,  `officeid` varchar(10) NOT NULL,  `potypeid` varchar(10) NOT NULL,  `priority` varchar(15) NOT NULL,  `details` longtext NOT NULL,  `trnby` int(10) unsigned NOT NULL,  `daterequest` datetime NOT NULL,  `corporatelevel` tinyint(1) NOT NULL DEFAULT '0',  `approvedbranch` tinyint(1) NOT NULL DEFAULT '0',  `approvedcorporate` tinyint(1) NOT NULL DEFAULT '0',  `received` tinyint(1) NOT NULL DEFAULT '0',  `generatedpo` tinyint(1) NOT NULL DEFAULT '0',  `revised` tinyint(1) NOT NULL DEFAULT '0',  `dateapproved` datetime DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` varchar(45) DEFAULT NULL,  `disapproved` tinyint(1) NOT NULL DEFAULT '0',  `datedisapproved` datetime DEFAULT NULL,  `trnrefno` varchar(45) DEFAULT NULL,  `hold` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`pid`) USING BTREE,  KEY `pid` (`pid`),  KEY `officeid` (`officeid`),  KEY `potypeid` (`potypeid`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DELETE FROM `tblrequisitionsitem`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisitionsitem` AUTO_INCREMENT = 1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpurchaseorder` CHANGE COLUMN `approvinglevel` `corporatelevel` TINYINT(1) NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblonlinerequisitions`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblonlinerequisitionsitem`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-11-13"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `strictapproversignature` BOOLEAN NOT NULL DEFAULT 0 AFTER `procurementemailaddress`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `deletedreason` VARCHAR(105) NOT NULL DEFAULT '' AFTER `deletedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-11-15"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblpurchaseorder` ADD COLUMN `paymentrequestedby` VARCHAR(45) AFTER `paymentrequested`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-11-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblapproverclientprocess` ADD COLUMN `requiredattachment` BOOLEAN NOT NULL DEFAULT 0 AFTER `officeid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpurchaseorder` ADD COLUMN `closed` BOOLEAN NOT NULL DEFAULT 0 AFTER `paymentrefnumber`, ADD COLUMN `dateclosed` DATETIME AFTER `closed`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldeprecitionofassets` MODIFY COLUMN `catid` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, ADD COLUMN `ffetype` VARCHAR(45) NOT NULL AFTER `catid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-11-24"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `allowmanualffeinventory` BOOLEAN NOT NULL DEFAULT 0 AFTER `allowbeggininginventory`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-11-28"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableprocurementpolicy` BOOLEAN NOT NULL DEFAULT 0 AFTER `strictapproversignature`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-12-01"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "DROP TABLE IF EXISTS `tblinventoryffe`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblinventoryffe` (`ffecode` varchar(10) NOT NULL DEFAULT '',`ffetype` varchar(10) NOT NULL,`reference` varchar(45) NOT NULL DEFAULT '',`officeid` varchar(25) NOT NULL,`stockhouseid` varchar(15) NOT NULL DEFAULT 'default',`productid` varchar(45) NOT NULL,`productname` varchar(500) NOT NULL DEFAULT '',`catid` varchar(10) NOT NULL,`categoryname` varchar(500) NOT NULL DEFAULT '',`quantity` double NOT NULL DEFAULT '0',`unit` varchar(10) NOT NULL,`unitcost` double NOT NULL DEFAULT '0',`totalamount` double NOT NULL DEFAULT '0',`vendorid` varchar(25) NOT NULL,`datepurchased` date NOT NULL,`warranty` tinyint(1) NOT NULL DEFAULT '0',`warrantydate` date DEFAULT NULL,`manualdepreciation` tinyint(1) NOT NULL DEFAULT '0',`age` varchar(45) NOT NULL DEFAULT '',`bookvalue` double NOT NULL DEFAULT '0',`monthlydepreciation` double NOT NULL DEFAULT '0',`lastdepreciationdate` date DEFAULT NULL,`acctablepersonid` varchar(5) NOT NULL DEFAULT '',`acctableperson` varchar(105) DEFAULT NULL,`acctdateissued` date DEFAULT NULL,`trnby` varchar(10) NOT NULL,`datetrn` datetime NOT NULL,`disposed` tinyint(1) NOT NULL DEFAULT '0',`datedisposed` date DEFAULT NULL,`disposedby` varchar(45) DEFAULT NULL,`attachedimage` tinyint(1) NOT NULL DEFAULT '0',`flaged` tinyint(1) NOT NULL DEFAULT '1',`flagedreason` varchar(500) NOT NULL DEFAULT '',PRIMARY KEY (`ffecode`) USING BTREE,KEY `ffecode` (`ffecode`),KEY `productid` (`productid`),KEY `catid` (`catid`),KEY `officeid` (`officeid`),KEY `vendorid` (`vendorid`),KEY `ponumber` (`reference`) USING BTREE) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblinventoryffeaccountable`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblinventoryffeaccountable` (`id` int(10) unsigned NOT NULL AUTO_INCREMENT,`ffecode` varchar(10) NOT NULL,`acctableperson` varchar(5) DEFAULT NULL,`accountname` varchar(105) NOT NULL,`dateissued` date DEFAULT NULL,`returndate` date DEFAULT NULL,`note` longtext,`iscurrent` tinyint(1) NOT NULL DEFAULT '0',`issueby` varchar(15) NOT NULL,PRIMARY KEY (`id`) USING BTREE) ENGINE=InnoDB AUTO_INCREMENT=10005 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblinventoryffedetails`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblinventoryffedetails` (`id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,`productid` varchar(45) NOT NULL DEFAULT '',`ffecode` varchar(40) NOT NULL,`ffetype` varchar(10) NOT NULL,`sortorder` int(10) unsigned NOT NULL,`fieldname` varchar(250) NOT NULL,`description` varchar(250) NOT NULL,`value` varchar(250) NOT NULL,`required` tinyint(1) NOT NULL DEFAULT '0',PRIMARY KEY (`id`),KEY `ffecode` (`ffecode`),KEY `fieldname` (`fieldname`),KEY `value` (`value`)) ENGINE=MyISAM AUTO_INCREMENT=311 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblinventoryffehistory`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblinventoryffehistory` (`id` int(10) unsigned NOT NULL AUTO_INCREMENT,`ffecode` varchar(10) NOT NULL DEFAULT '',`remarks` varchar(500) DEFAULT '',`datetrn` datetime NOT NULL,`trnby` varchar(45) DEFAULT NULL,PRIMARY KEY (`id`) USING BTREE) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblinventoryffesetup`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblinventoryffesetup` (`id` int(10) unsigned NOT NULL AUTO_INCREMENT,`ffetype` varchar(10) NOT NULL,`sortorder` int(10) unsigned NOT NULL,`fieldname` varchar(45) NOT NULL,`description` varchar(100) NOT NULL,`required` tinyint(1) NOT NULL,PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblinventoryffetype`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblinventoryffetype` (`code` int(10) unsigned NOT NULL AUTO_INCREMENT,`catid` varchar(10) NOT NULL,`description` varchar(100) NOT NULL,PRIMARY KEY (`code`)) ENGINE=InnoDB AUTO_INCREMENT=1023 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2016-12-02"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `blockedrequisition` BOOLEAN NOT NULL DEFAULT 0 AFTER `enableoperation`, ADD COLUMN `blockedreason` VARCHAR(500) NOT NULL DEFAULT '' AFTER `blockedrequisition`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-01-03"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblsalesencryptnumber` (  `enableencrypt` tinyint(1) NOT NULL DEFAULT '0',  `val1` varchar(1) NOT NULL DEFAULT '',  `val2` varchar(1) NOT NULL DEFAULT '',  `val3` varchar(1) NOT NULL DEFAULT '',  `val4` varchar(1) NOT NULL DEFAULT '',  `val5` varchar(1) NOT NULL DEFAULT '',  `val6` varchar(1) NOT NULL DEFAULT '',  `val7` varchar(1) NOT NULL DEFAULT '',  `val8` varchar(1) NOT NULL DEFAULT '',  `val9` varchar(1) NOT NULL DEFAULT '',  `val0` varchar(1) NOT NULL DEFAULT '',  PRIMARY KEY (`enableencrypt`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "insert into tblsalesencryptnumber values (1, 'D', 'R', 'S', 'U', 'W', 'L', 'I', 'G', 'H', 'T');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Added function Purchased Price and Selling Price security code<br/> " _
                              + " - Added Encryption Number '1=D', '2=R', '3=S', '4=U', '5=W', '6=L', '7=I', '8=G', '9=H', '0=T' <br/> " _
                              + " - Fixed problem when cashier cannot view all on hold transaction<br/> "
            engineupdated = True
        End If

        updateVersion = "2017-01-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompanysettings` ADD COLUMN `systemdate` VARCHAR(100) NOT NULL DEFAULT '' AFTER `systemmodule`, ADD COLUMN `expirydate` VARCHAR(100) NOT NULL DEFAULT '' AFTER `systemdate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblcompanysettings set systemdate='" & EncryptTripleDES(ConvertDate(CDate(Now.AddDays(-1).ToShortDateString))) & "';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompanysettings` ADD COLUMN `enginecode` VARCHAR(200) NOT NULL DEFAULT '' AFTER `companycode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Added check printing<br/> " _
                           + " - Added new voucher process<br/> " _
                           + " - Added system security for preventing system backdate<br/> "
            engineupdated = True
        End If

        updateVersion = "2017-01-14"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `deleted` BOOLEAN NOT NULL DEFAULT 0 AFTER `blockedreason`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableconsumableadjustment` BOOLEAN NOT NULL DEFAULT 1 AFTER `enableprocurementpolicy`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableclientaccounts` BOOLEAN NOT NULL DEFAULT 1 AFTER `enableconsumableadjustment`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-01-24"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            If MessageBox.Show("This confirmation script is to drop or delete table VOUCHERS, if you not aware of this please contact your system administrator", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "DROP TABLE IF EXISTS `tblvouchers`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `vouchernosequence` VARCHAR(10) NOT NULL DEFAULT '' AFTER `enableclientaccounts`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "CREATE TABLE  `tblvouchers` (  `voucherno` varchar(15) NOT NULL,  `payto` varchar(10) NOT NULL,  `description` varchar(500) NOT NULL,  `vouchertype` varchar(6) NOT NULL,  `amount` double NOT NULL DEFAULT '0',  `creditaccount` varchar(10) NOT NULL DEFAULT '',  `datetrn` datetime NOT NULL,  `trnby` varchar(45) NOT NULL,  `verified` tinyint(1) NOT NULL DEFAULT '0',  `dateverified` datetime DEFAULT NULL,  `verifiedby` varchar(45) DEFAULT NULL,  `paid` tinyint(1) NOT NULL DEFAULT '0',  `datepaid` datetime DEFAULT NULL,  `paidby` varchar(45) DEFAULT NULL,  `cleared` tinyint(1) NOT NULL DEFAULT '0',  `datecleared` datetime DEFAULT NULL,  `clearedby` varchar(45) DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` datetime DEFAULT NULL,  `cancelledby` varchar(45) DEFAULT NULL,  PRIMARY KEY (`voucherno`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "CREATE TABLE `tblvouchersdetail` (  `trnid` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `voucherno` varchar(15) NOT NULL,  `itemcode` varchar(45) NOT NULL,  `vendorid` varchar(45) DEFAULT NULL,  `amount` double NOT NULL DEFAULT '0',  `remarks` text,  `trnby` varchar(15) NOT NULL,  `datetrn` datetime NOT NULL,  PRIMARY KEY (`trnid`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "INSERT into tblvouchers (voucherno,payto,description,vouchertype,amount,creditaccount,datetrn,trnby,verified,dateverified,verifiedby,paid,datepaid,paidby,cleared,datecleared,clearedby,cancelled,datecancelled,cancelledby) SELECT referenceno,vendorid,remarks,paymenttype,amount,creditaccount,datetrn,trnby,verified,dateverified,verifiedby,verified,dateverified,verifiedby,verified,dateverified,verifiedby,cancelled,datecancelled,cancelledby FROM `tblbillsandpayables` order by datetrn asc;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))

                com.CommandText = "INSERT into tblvouchersdetail (voucherno,itemcode,vendorid,amount,remarks,trnby,datetrn) SELECT referenceno, itemcode,vendorid,amount,remarks,trnby,datetrn FROM `tblbillsandpayables` order by datetrn asc;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "ALTER TABLE `tblpayablechecktransaction` CHANGE COLUMN `trnsumcode` `voucherno` VARCHAR(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT 0, DROP INDEX `trnsumcode`, ADD INDEX `trnsumcode` USING BTREE(`voucherno`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "ALTER TABLE `tblglsettings` ADD COLUMN `voucher` VARCHAR(10) NOT NULL AFTER `checkpayment`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "UPDATE `tblgeneralsettings` set vouchernosequence='10001'" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            engineupdated = True
        End If

        updateVersion = "2017-01-26"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblpermissionsclearing` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `percode` varchar(45) NOT NULL,  `tabname` varchar(105) NOT NULL,  PRIMARY KEY (`id`),  KEY `percode` (`percode`),  KEY `tabname` (`tabname`)) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-01-27"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE  `tblpayabletransactions` CHANGE COLUMN `trnid` `voucherno` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, DROP COLUMN `depositpaymentchange`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE  `tblpurchaseorder` ADD COLUMN `vat` DOUBLE NOT NULL DEFAULT 0 AFTER `subtotal`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-01-28"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `allowprocessorcreateclientaccounts` BOOLEAN NOT NULL DEFAULT 1 AFTER `vouchernosequence`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Added Shortcut direct change own password just press ( SHIFT + P ) on your keyboard on the Coffeecup Server main screen <br/> " _
                        + " - Added Shortcut directly open Consumable Inventory on Coffeecup Server ( F12 )  <br/>  " _
                        + " - Added Shortcut directly open Product Management on Coffeecup Server ( F11 )  <br/>  " _
                        + " - Added Shortcut directly open Add New Product on Coffeecup Server ( SHIFT + F11 )  <br/>  " _
                        + " - Added new system function ELECTRONIC VOUCHER with following process (Create > Approval > Cash/Check Payment Posting > Clearing) <br/>  " _
                        + " - Added New Security function on Transaction Clearing. Admin can customize users for transaction clearing access. Go to System Settings > Coffeecup Server Permission > Transaction Clearing  <br/>  " _
                        + " - Fixed Error Found on Invoice Item Return at Junie Auto Supply (Agusan) "
            engineupdated = True
        End If

        updateVersion = "2017-03-25"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblproductmenuitem` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `source_productid` varchar(100) NOT NULL,  `productid` varchar(100) NOT NULL,  `quantity` double NOT NULL DEFAULT '0',  PRIMARY KEY (`id`) USING BTREE,  KEY `source_productid` (`source_productid`),  KEY `productid` (`productid`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `menuitem` BOOLEAN NOT NULL AFTER `forcontract`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `menumakerstockref` VARCHAR(10) NOT NULL DEFAULT '' AFTER `inventorytrnid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `menumakerreferenceno` VARCHAR(10) NOT NULL DEFAULT '10000' AFTER `allowprocessorcreateclientaccounts`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalesmenumakerstockout` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `refnumber` varchar(10) NOT NULL,  `stockno` int(10) unsigned NOT NULL,  `productid` varchar(50) NOT NULL,  `quantity` double NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalestransaction` MODIFY COLUMN `inventorytrnid` INT(10) NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblunitconverterdetails`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblunitconverter`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblunitconverter` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `productid_source` varchar(100) NOT NULL,  `quantity_source` double NOT NULL DEFAULT '0',  `productid_target` varchar(100) NOT NULL,  `quantity_target` double NOT NULL DEFAULT '0',  PRIMARY KEY (`id`) USING BTREE,  KEY `productid_source` (`productid_source`),  KEY `quantity_target` (`quantity_target`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesautoservices` ADD COLUMN `attmechanics` VARCHAR(250) NOT NULL DEFAULT '' AFTER `odometer`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblreporthtmltemplate` ADD PRIMARY KEY (`filename`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvouchers` MODIFY COLUMN `vouchertype` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Added Menu Maker Function for Restaurant and Coffeeshop<br/> " _
                       + " - Added Unit Convertion Function (ex. from Box to Pieces)<br/>  " _
                       + " - Added Attending Mechanics Field for Auto Services<br/>  " _
                       + " - Rename from Odo Meter to Mileage on Auto Services Aggreement and input is required to be fill in<br/>  " _
                       + " - Rename from Cash voucher to Petty Cash Voucher on create voucher function<br/>  " _
                       + " - Added function for Chart of Accounts can add new account through system<br/>  " _
                       + " - Fixed Error on void function. not functional well <br/>  "
            engineupdated = True
        End If

        updateVersion = "2017-04-01"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblhotelroomsamenitieslog` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `officeid` varchar(45) NOT NULL,  `foliono` varchar(45) NOT NULL,  `stockno` varchar(45) NOT NULL,  `productid` varchar(45) NOT NULL,  `quantity` double NOT NULL DEFAULT '0',  `purchasedprice` double NOT NULL DEFAULT '0',  PRIMARY KEY (`id`),  KEY `officeid` (`officeid`),  KEY `foliono` (`foliono`),  KEY `productid` (`productid`)) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesmenumakerstockout` ADD COLUMN `officeid` VARCHAR(45) NOT NULL AFTER `id`, ADD COLUMN `purchasedprice` DOUBLE NOT NULL DEFAULT 0 AFTER `quantity`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablehousekeepingmonitoring` BOOLEAN NOT NULL DEFAULT 0 AFTER `menumakerreferenceno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE  `tbluserauthority` ADD COLUMN `housekeeping` BOOLEAN NOT NULL DEFAULT 0 AFTER `autoservices`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelrooms` ADD COLUMN `maintainance` BOOLEAN NOT NULL DEFAULT 0 AFTER `reserved`, ADD COLUMN `remarks` VARCHAR(300) NOT NULL DEFAULT '' AFTER `maintainance`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelhousekeepingreports` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `roomid` varchar(5) NOT NULL,  `roomno` varchar(6) NOT NULL DEFAULT '',  `description` varchar(100) NOT NULL DEFAULT '',  `maintainancemode` tinyint(1) NOT NULL DEFAULT '1',  `roomstatus` varchar(50) NOT NULL DEFAULT '',  `remarks` varchar(200) NOT NULL DEFAULT '',  `housekeeper` varchar(100) NOT NULL DEFAULT '',  `dateupdate` datetime NOT NULL,  `postedby` varchar(100) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablehotelmaintainanceuponcheckout` BOOLEAN NOT NULL DEFAULT 0 AFTER `enablehousekeepingmonitoring`, ADD COLUMN `hotelmaintainancedefaultstatus` VARCHAR(45) NOT NULL DEFAULT 'ON GOING ROOM CLEANING' AFTER `enablehotelmaintainanceuponcheckout`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbankaccounts` ADD COLUMN `posmerchant` BOOLEAN NOT NULL DEFAULT 0 AFTER `enableemailnotification`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalescardtype` (  `bankcode` int(10) unsigned NOT NULL AUTO_INCREMENT,  `bankname` varchar(105) NOT NULL,  PRIMARY KEY (`bankcode`)) ENGINE=InnoDB AUTO_INCREMENT=1000 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbankaccounts` ADD COLUMN `onlinetransaction` BOOLEAN NOT NULL DEFAULT 0 AFTER `posmerchant`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomreservation` ADD COLUMN `datecancelled` DATETIME AFTER `cancelled`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomreservation` ADD COLUMN `paymentreference` VARCHAR(45) NOT NULL DEFAULT '' AFTER `paymentdeposit`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelguest` ADD COLUMN `deleted` BOOLEAN NOT NULL DEFAULT 0 AFTER `trnby`, ADD COLUMN `datedeleted` DATETIME AFTER `deleted`, ADD COLUMN `deletedby` VARCHAR(5) NOT NULL DEFAULT '' AFTER `datedeleted`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `showsalesreportemailcaptionasoffice` VARCHAR(45) NOT NULL DEFAULT 0 AFTER `hotelmaintainancedefaultstatus`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomreservation` ADD COLUMN `checkoutdate` DATE AFTER `timearaival`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `platenumber` VARCHAR(45) NOT NULL DEFAULT '' AFTER `totalamount`, ADD COLUMN `remarks` VARCHAR(105) NOT NULL DEFAULT '' AFTER `platenumber`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-04-13"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `voidtrn` BOOLEAN NOT NULL DEFAULT 0 AFTER `apphistory`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Added Void function for Administrative user on Coffeecup client<br/> "
            engineupdated = True
        End If

        updateVersion = "2017-04-14"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablestrictffedetails` BOOLEAN NOT NULL DEFAULT 0 AFTER `showsalesreportemailcaptionasoffice`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `allowmanageffeotheroffice` BOOLEAN NOT NULL DEFAULT 0 AFTER `deleted`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglsettings` MODIFY COLUMN `voucher` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `gltype` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `value` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglsettings` MODIFY COLUMN `taxrate` DOUBLE NOT NULL DEFAULT 0, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvouchers` ADD COLUMN `pid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `voucherno`, ADD COLUMN `ponumber` VARCHAR(45) NOT NULL DEFAULT '' AFTER `pid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvouchers` ADD COLUMN `corporatelevel` INT(1) NOT NULL DEFAULT 0 AFTER `creditaccount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglsettings` MODIFY COLUMN `cashierbegcashamt` DOUBLE NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvouchers` ADD COLUMN `officeid` VARCHAR(8) NOT NULL DEFAULT '' AFTER `voucherno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblvouchers` set officeid=(select officeid from tblaccounts where accountid=tblvouchers.trnby);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblapprovalhistory` ADD COLUMN `mainreference` VARCHAR(25) NOT NULL DEFAULT '' AFTER `appdescription`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblapprovalhistory` set mainreference=referenceno where referenceno in (select pid from tblrequisitions);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblapprovalhistory` inner join tblpurchaseorder on tblapprovalhistory.referenceno =  tblpurchaseorder.ponumber set mainreference=requestref where referenceno in (select ponumber from tblpurchaseorder);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblapprovalhistory` inner join tblvouchers on tblapprovalhistory.referenceno =  tblvouchers.voucherno set mainreference=pid where referenceno in (select voucherno from tblvouchers);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglaccountledger` ADD COLUMN `officeid` VARCHAR(10) NOT NULL DEFAULT '' AFTER `trnid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` DROP COLUMN `enablecreditlimit`, DROP COLUMN `allowablerequest`, DROP COLUMN `creditlimit`, DROP COLUMN `creditlimitperrequest`, DROP COLUMN `creditrenew`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` MODIFY COLUMN `inventorymethod` VARCHAR(5) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT 'fifo';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` DROP COLUMN `lockedlogins`, DROP COLUMN `lockeddescription`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `corporateoffice` BOOLEAN NOT NULL DEFAULT 0 AFTER `officerid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` CHANGE COLUMN `allowmanageffeotheroffice` `allowmanageffeotheroffice` TINYINT(1) NOT NULL DEFAULT 0 after customcorporateapproval;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `allowmanualconsumableinventory` BOOLEAN NOT NULL DEFAULT 0 AFTER `customcorporateapproval`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvouchers` MODIFY COLUMN `vouchertype` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblinventoryffetransfer` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `ffecode` varchar(10) NOT NULL DEFAULT '',  `productname` varchar(500) NOT NULL DEFAULT '',  `producttype` varchar(50) NOT NULL DEFAULT '',  `officeid_from` varchar(25) NOT NULL,  `officeid_to` varchar(25) NOT NULL,  `message` varchar(100) NOT NULL DEFAULT '',  `daterequest` datetime NOT NULL,  `requestby` varchar(40) NOT NULL,  `received` tinyint(1) NOT NULL DEFAULT '0',  `datereceived` datetime DEFAULT NULL,  `receivedby` varchar(40) DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` datetime DEFAULT NULL,  `cancelledby` varchar(40) DEFAULT NULL,  PRIMARY KEY (`id`) USING BTREE) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventoryffe` ADD COLUMN `blocked` BOOLEAN NOT NULL DEFAULT 0 AFTER `flagedreason`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventoryffe` ADD COLUMN `lockedediting` BOOLEAN NOT NULL DEFAULT 0 AFTER `blocked`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Added full functions of FFE management <br/>  " _
                    + " - Added devision of voucher per office<br/>  "
            engineupdated = True
        End If

        updateVersion = "2017-04-17"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `webpassword` VARCHAR(100) NOT NULL AFTER `password`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            dst = New DataSet
            msda = New MySqlDataAdapter("select * from tblaccounts", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    com.CommandText = "update tblaccounts set webpassword=DES_ENCRYPT('" & .Rows(cnt)("username").ToString() & DecryptTripleDES(.Rows(cnt)("password").ToString()) & "','kira') where accountid='" & .Rows(cnt)("accountid").ToString() & "'" : com.ExecuteNonQuery()
                End With
            Next

            com.CommandText = "ALTER TABLE `tblinventoryffe` ADD COLUMN `disposalrequested` BOOLEAN NOT NULL DEFAULT 0 AFTER `datetrn`, ADD COLUMN `disposalrequestcorporatelevel` BOOLEAN NOT NULL DEFAULT 0 AFTER `disposalrequested`, ADD COLUMN `disposaldaterequested` DATETIME AFTER `disposalrequestcorporatelevel`, ADD COLUMN `disposalrequestedby` VARCHAR(10) AFTER `disposaldaterequested`, ADD COLUMN `disposalapproved` BOOLEAN NOT NULL DEFAULT 0 AFTER `disposalrequestedby`, ADD COLUMN `disposaldateapproved` DATETIME AFTER `disposalapproved`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventoryffeaccountable` ADD COLUMN `generatedffedoc` BOOLEAN NOT NULL DEFAULT 0 AFTER `issueby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `ffememorandumagreement` TEXT AFTER `enablestrictffedetails`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Added user accounts 2nd password for webbase login <br/>  "
            engineupdated = True
        End If

        updateVersion = "2017-04-25"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `hotelhousekeepingid` VARCHAR(15) NOT NULL DEFAULT '' AFTER `ffememorandumagreement`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblgeneralsettings set hotelhousekeepingid=(select distinct hotelofficeid from tblclientaccounts where hotelclient=1 limit 1);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccounts` DROP COLUMN `hotelofficeid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelroomsdiscounttransaction` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `foliono` int(10) unsigned NOT NULL,  `guestid` varchar(15) NOT NULL DEFAULT '',  `noofdays` double NOT NULL DEFAULT '0',  `description` varchar(500) NOT NULL,  `roomrate` double NOT NULL DEFAULT '0',  `discountrate` double NOT NULL DEFAULT '0',  `totaldiscount` double NOT NULL DEFAULT '0',  `subtotal` double NOT NULL DEFAULT '0',  `totalamount` double NOT NULL DEFAULT '0',  `datetrn` datetime NOT NULL,  `trnby` varchar(10) NOT NULL,  `discountoveride` tinyint(1) NOT NULL DEFAULT '0',  `discountoverideby` varchar(10) NOT NULL DEFAULT '',  `dateoveride` datetime DEFAULT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` DROP COLUMN `discountoveride`, DROP COLUMN `discountoverideby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `vipmgt` BOOLEAN NOT NULL DEFAULT 0 AFTER `hotelmgt`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD COLUMN `blocked` BOOLEAN NOT NULL DEFAULT 0 AFTER `deleted`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "insert into tblsalesclientcharges (trnsumcode,accountno,batchcode,glitemcode,invoiceno,remarks,amount,datetrn,trnby,verified,verifiedby,dateverified) SELECT '-',accountno,concat('folio#',referenceno),itemcode,referenceno,remarks,debit,datetrn,trnby,1,trnby,datetrn FROM `tblglaccountledger` where remarks like '%Folio%';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-05-03"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblproductmenuitem` ADD COLUMN `unit` VARCHAR(45) NOT NULL DEFAULT '' AFTER `quantity`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblproductmenuitem set unit = (select unit from tblglobalproducts  where productid=tblproductmenuitem.productid);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD COLUMN `blockedreason` VARCHAR(100) NOT NULL DEFAULT '' AFTER `blocked`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelrooms` DROP COLUMN `reserved`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelguest`  ADD COLUMN `vipguest` tinyint(1) NOT NULL DEFAULT '0' AFTER emailadd,  ADD COLUMN `viptype` varchar(5) NOT NULL DEFAULT '' AFTER vipguest,  ADD COLUMN `vipcardno` varchar(65) NOT NULL DEFAULT '' AFTER viptype,  ADD COLUMN `vipcreditlimit` double NOT NULL DEFAULT '0'  AFTER vipcardno;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelguest` ADD COLUMN `countrycode` VARCHAR(5) NOT NULL DEFAULT 'PH' AFTER `fullname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `filedir`.`tblhotelguestimage` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `guestid` varchar(25) NOT NULL,  `picture` longblob,  PRIMARY KEY (`id`),  KEY `guestid` (`guestid`)) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `menufontname` VARCHAR(100) NOT NULL DEFAULT 'Segoe UI' AFTER `iconfolder`, ADD COLUMN `menufontsize` DOUBLE NOT NULL DEFAULT 9.25 AFTER `menufontname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `pagefontname` VARCHAR(100) NOT NULL DEFAULT 'Segoe UI' AFTER `iconfolder`, ADD COLUMN `pagefontsize` DOUBLE NOT NULL DEFAULT 9.25 AFTER `pagefontname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelrooms` ADD COLUMN `deleted` BOOLEAN NOT NULL DEFAULT 0 AFTER `remarks`, ADD COLUMN `deletedby` VARCHAR(6) NOT NULL DEFAULT '' AFTER `deleted`, ADD COLUMN `datedeleted` DATETIME AFTER `deletedby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomsamenities` MODIFY COLUMN `roomid` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `productid` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', ADD COLUMN `unit` VARCHAR(15) NOT NULL DEFAULT '' AFTER `quantity`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` MODIFY COLUMN `foliono` VARCHAR(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL, MODIFY COLUMN `trnsumcode` VARCHAR(25) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '', MODIFY COLUMN `guestid` VARCHAR(25) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '', MODIFY COLUMN `hotelcif` VARCHAR(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '', MODIFY COLUMN `roomid` VARCHAR(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '', MODIFY COLUMN `datecheckout` DATE DEFAULT NULL, MODIFY COLUMN `timecheckout` TIME DEFAULT NULL, MODIFY COLUMN `nodays` INT(2) UNSIGNED NOT NULL DEFAULT 0, MODIFY COLUMN `noadults` INT(2) UNSIGNED NOT NULL DEFAULT 0, MODIFY COLUMN `nochild` INT(2) UNSIGNED NOT NULL DEFAULT 0, MODIFY COLUMN `totaldiscount` DOUBLE NOT NULL DEFAULT 0, MODIFY COLUMN `totalamount` DOUBLE NOT NULL DEFAULT 0, MODIFY COLUMN `trnby` VARCHAR(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelviptype` (  `vipcode` int(10) unsigned NOT NULL AUTO_INCREMENT,  `description` varchar(45) NOT NULL,  `enablelimit` tinyint(1) NOT NULL DEFAULT '0',  `creditlimit` double NOT NULL DEFAULT '0',  PRIMARY KEY (`vipcode`)) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `roomcheckin` BOOLEAN NOT NULL DEFAULT 1 AFTER `guestid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `vip` BOOLEAN NOT NULL DEFAULT 0 AFTER `guestid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblhotelroomtransaction` set totalamount=ifnull((select sum(debit) from tblhoteltransaction where foliono = tblhotelroomtransaction.foliono and cancelled=0  and appliedcoupon=0),0) where closed=1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesmenumakerstockout` ADD COLUMN `unit` VARCHAR(45) NOT NULL DEFAULT '' AFTER `quantity`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblsalesmenumakerstockout` set unit=(select unit from tblglobalproducts where productid=tblsalesmenumakerstockout.productid);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesmenumakerstockout` ADD COLUMN `void` BOOLEAN NOT NULL DEFAULT 0 AFTER `purchasedprice`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesmenumakerstockout` ADD COLUMN `productname` VARCHAR(100) NOT NULL DEFAULT '' AFTER `productid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblsalesmenumakerstockout` set productname=(select itemname from tblglobalproducts where productid=tblsalesmenumakerstockout.productid);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglsettings` ADD COLUMN `onlinepayment` VARCHAR(45) NOT NULL DEFAULT '' AFTER `voucher`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblsalesqueuingslip` (  `queuecode` int(10) unsigned NOT NULL,  `description` varchar(105) NOT NULL,  `icon` blob NOT NULL,  PRIMARY KEY (`queuecode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablequeuingslip` BOOLEAN NOT NULL DEFAULT 0 AFTER `hotelhousekeepingid`, ADD COLUMN `queuingsliptype` VARCHAR(45) NOT NULL DEFAULT 'Table Queue' AFTER `enablequeuingslip`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `onholdqueuecode` VARCHAR(5) NOT NULL DEFAULT '' AFTER `onhold`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalesqueuingfilter` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `permissioncode` int(10) unsigned NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `queuingproductcategory` VARCHAR(10) NOT NULL DEFAULT '' AFTER `queuingsliptype`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "drop table tblstockoutbatch;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblstockoutitem` DROP COLUMN `batchcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblstockoutitem` DROP COLUMN `sellingprice`, DROP COLUMN `income`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblstockoutitem` DROP COLUMN `trnid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblstockoutitem` ADD COLUMN `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT FIRST, ADD PRIMARY KEY (`id`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblstockoutitem` CHANGE COLUMN `fromofficeid` `allocatedofficeid` VARCHAR(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, CHANGE COLUMN `stockfromid` `officeid` VARCHAR(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL after refcode, DROP INDEX `fromofficeid`, ADD INDEX `fromofficeid` USING BTREE(`allocatedofficeid`), DROP INDEX `stockfromid`, ADD INDEX `stockfromid` USING BTREE(`officeid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblstockoutitem` set officeid=allocatedofficeid;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblstockoutitem` MODIFY COLUMN `allocatedofficeid` VARCHAR(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `iconfolderclient` VARCHAR(15) NOT NULL DEFAULT 'default' AFTER `iconfolder`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `bgcolorclient` VARCHAR(20) NOT NULL DEFAULT '34,34,34' AFTER `iconfolderclient`,ADD COLUMN `fontcolorclient` VARCHAR(5) NOT NULL DEFAULT 'LIGHT' AFTER `bgcolorclient`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblaccounts` ADD COLUMN `requiredupdate` BOOLEAN NOT NULL DEFAULT 1 AFTER `deletedreason`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblsalestransaction set purchasedprice=ifnull((select sum((purchasedprice*quantity)) from tblsalesmenumakerstockout where refnumber=tblsalestransaction.menumakerstockref),0)/quantity where menumakerstockref<>'' and void=0 and cancelled=0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            If MessageBox.Show("Enable client filter?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "UPDATE tblgeneralsettings set enableclientfilter=1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            updateDescription += " - Added Themes Management for Client users<br/>  "
            engineupdated = True
        End If

        updateVersion = "2017-05-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            If MessageBox.Show("DO YOU WANT TO DROP TABLE OF EMPLOYEES OF " & UCase(compname) & "? if you not aware of this you must select NO", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "DROP TABLE `tblemployees`" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "CREATE TABLE `tblemployees` (`employeeid` varchar(15) NOT NULL DEFAULT '',`lastname` varchar(25) NOT NULL DEFAULT '',`firstname` varchar(25) NOT NULL DEFAULT '',`middlename` varchar(25) NOT NULL DEFAULT '',`fullname` varchar(50) NOT NULL,`extname` varchar(6) DEFAULT '',`nickname` varchar(40) DEFAULT NULL,`birthdate` date NOT NULL,`birthplace` varchar(450) DEFAULT '',`nationality` varchar(45) NOT NULL DEFAULT '',`religion` varchar(45) NOT NULL DEFAULT '',`civilstatus` varchar(45) NOT NULL DEFAULT '',`profilelink` varchar(45) DEFAULT '',`per_add_brgy` varchar(65) DEFAULT '',`per_add_city` varchar(45) DEFAULT '',`per_add_prov` varchar(45) DEFAULT '',`cur_add_brgy` varchar(65) DEFAULT '',`cur_add_city` varchar(45) DEFAULT '',`cur_add_prov` varchar(45) DEFAULT '',`contactnumber` varchar(45) DEFAULT '',`homenumber` varchar(45) DEFAULT '',`emailaddress` varchar(45) DEFAULT '',`inc_cont_person` varchar(65) DEFAULT '',`inc_cont_number` varchar(45) DEFAULT '',`inc_cont_address` varchar(75) DEFAULT '',`officeid` varchar(15) DEFAULT '',`employeetypecode` varchar(15) DEFAULT '',`positioncode` varchar(15) DEFAULT '',`shiftcode` varchar(5) DEFAULT NULL,`contractperiod` tinyint(1) NOT NULL DEFAULT '0',`contractstartdate` date DEFAULT NULL,`contractenddate` date DEFAULT NULL,`datehired` date DEFAULT NULL,`dateregular` date DEFAULT NULL,`approvedby` varchar(15) DEFAULT '',`dateregistered` datetime DEFAULT NULL,`biometricid` varchar(10) NOT NULL DEFAULT '',`linkuserid` varchar(10) NOT NULL DEFAULT '',`linkclientid` varchar(15) NOT NULL DEFAULT '',`resigned` tinyint(1) NOT NULL DEFAULT '0',`dateresigned` date DEFAULT NULL,`profilepic` longblob,`attendancepassword` text, `actived` BOOLEAN NOT NULL DEFAULT 1,PRIMARY KEY (`employeeid`),KEY `employeeid` (`employeeid`),KEY `lastname` (`lastname`),KEY `firstname` (`firstname`),KEY `fullname` (`fullname`),KEY `officeid` (`officeid`),KEY `employeetypecode` (`employeetypecode`),KEY `positioncode` (`positioncode`),KEY `shiftcode` (`shiftcode`),KEY `biometricid` (`biometricid`),KEY `linkuserid` (`linkuserid`),KEY `linkclientid` (`linkclientid`)) ENGINE=MyISAM DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            com.CommandText = "CREATE TABLE `tblsalesqueuinggroup` (  `groupcode` int(10) unsigned NOT NULL,  `description` varchar(105) NOT NULL,  PRIMARY KEY (`groupcode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesqueuingslip` ADD COLUMN `groupcode` VARCHAR(5) NOT NULL DEFAULT 100 AFTER `icon`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesqueuingfilter` ADD COLUMN `groupcode` VARCHAR(5) NOT NULL DEFAULT '' AFTER `permissioncode`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventoryffehistory` ADD COLUMN `officename` VARCHAR(105) NOT NULL DEFAULT '' AFTER `trnby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Added New Module for Service Queuing Function<br/>  "
            engineupdated = True
        End If

        updateVersion = "2017-05-20"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `allowcreaterequestforotheroffice` BOOLEAN NOT NULL DEFAULT 0 AFTER `allowmanageffeotheroffice`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Added setting for purchase requisition to allow other office to create request for thier needs<br/>  "
            engineupdated = True
        End If

        updateVersion = "2017-05-30"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `officeid` VARCHAR(10) NOT NULL DEFAULT '' AFTER `foliono`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblhotelroomtransaction` set officeid=(select officeid from tblaccounts where accountid=tblhotelroomtransaction.trnby);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-06-01"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablestrictmenumakerinventory` BOOLEAN NOT NULL DEFAULT 0 AFTER `queuingproductcategory`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-06-02"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblhotelfilter` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `hotelcif` VARCHAR(15) NOT NULL DEFAULT '',  `permissioncode` int(10) unsigned NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` CHANGE COLUMN `foliono` `folioid` VARCHAR(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL, DROP PRIMARY KEY, ADD PRIMARY KEY  USING BTREE(`folioid`), DROP INDEX `foliono`, ADD INDEX `foliono` USING BTREE(`folioid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `foliono` VARCHAR(15) NOT NULL DEFAULT '' AFTER `folioid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblhotelroomtransaction set foliono=folioid;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhoteltransaction` CHANGE COLUMN `foliono` `folioid` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, DROP INDEX `foliono`, ADD INDEX `foliono` USING BTREE(`folioid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomsdiscounttransaction` CHANGE COLUMN `foliono` `folioid` VARCHAR(15) NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomsamenitieslog` CHANGE COLUMN `foliono` `folioid` VARCHAR(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, DROP INDEX `foliono`, ADD INDEX `foliono` USING BTREE(`folioid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomreservation` CHANGE COLUMN `proceedfoliono` `proceedfolioid` VARCHAR(15) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelhousekeepingreports` ADD COLUMN `hotel` VARCHAR(20) NOT NULL DEFAULT '' AFTER `id`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblhotelhousekeepingreports` set hotel=(select hotelcifid from tblhotelrooms where roomid=tblhotelhousekeepingreports.roomid );" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            'If MessageBox.Show("Notify email hotel change logs?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then

            'End If
            engineupdated = True
        End If

        updateVersion = "2017-06-05"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableclinicsservices` BOOLEAN NOT NULL DEFAULT 0 AFTER `enablestrictmenumakerinventory`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `clinicservices` BOOLEAN NOT NULL DEFAULT 0 AFTER `housekeeping`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Added Complete Clinic Module<br/>  "
            engineupdated = True
        End If

        updateVersion = "2017-06-06"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblclinics` (  `clinicid` varchar(3) NOT NULL,  `description` varchar(100) NOT NULL,  PRIMARY KEY (`clinicid`) USING BTREE,  KEY `clinicid` (`clinicid`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblclinicsattending` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `schedid` int(10) unsigned NOT NULL,  `userid` varchar(5) NOT NULL,  `fullname` varchar(50) NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblclinicschedule` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `trnid` int(10) unsigned NOT NULL,  `servicecode` varchar(15) NOT NULL,  `productid` varchar(25) NOT NULL,  `productname` varchar(100) NOT NULL,  `schedule` date NOT NULL,  `addedby` varchar(50) NOT NULL,  `dateadded` datetime NOT NULL,  `cleared` tinyint(1) NOT NULL DEFAULT '0',  `datecleared` datetime DEFAULT NULL,  `clearedby` varchar(50) NOT NULL DEFAULT '',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` datetime DEFAULT NULL,  `cancelledby` varchar(50) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblclinicservices` (  `trnid` int(10) unsigned NOT NULL AUTO_INCREMENT,  `servicecode` varchar(15) NOT NULL,  `clinicid` varchar(5) NOT NULL DEFAULT '',  `officeid` varchar(15) NOT NULL,  `clientcif` varchar(45) NOT NULL,  `batchcode` varchar(45) NOT NULL,  `salestrnid` varchar(25) NOT NULL,  `packagename` varchar(150) NOT NULL,  `amount` double NOT NULL,  `remarks` varchar(100) NOT NULL DEFAULT '',  `datetrn` datetime NOT NULL,  `trnby` varchar(5) NOT NULL,  `closed` tinyint(1) NOT NULL DEFAULT '0',  `dateclosed` datetime DEFAULT NULL,  `closedby` varchar(5) DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` datetime DEFAULT NULL,  `cancelledby` varchar(5) NOT NULL DEFAULT '',  PRIMARY KEY (`trnid`) USING BTREE) ENGINE=InnoDB AUTO_INCREMENT=1000 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblclinicstockout` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `serviceid` varchar(15) NOT NULL,  `officeid` varchar(45) NOT NULL,  `refnumber` varchar(10) NOT NULL,  `stockno` int(10) unsigned NOT NULL,  `productid` varchar(50) NOT NULL,  `productname` varchar(100) NOT NULL DEFAULT '',  `quantity` double NOT NULL DEFAULT '0',  `unit` varchar(45) NOT NULL DEFAULT '',  `purchasedprice` double NOT NULL DEFAULT '0',  `void` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-07-13"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblhotelroomtype` (  `code` varchar(5) NOT NULL,  `description` varchar(60) NOT NULL,  PRIMARY KEY (`code`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelroomrates` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `roomtype` varchar(5) NOT NULL,  `description` varchar(45) NOT NULL,  `amount` double NOT NULL,  `actived` tinyint(1) NOT NULL DEFAULT '1',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelrooms` ADD COLUMN `roomtype` VARCHAR(5) NOT NULL DEFAULT '' AFTER `hotelcifid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-07-14"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` CHANGE COLUMN `promorate` `rateid` VARCHAR(5) NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblhotelroomtransaction` set rateid='';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomreservation` ADD COLUMN `rateid` VARCHAR(5) NOT NULL DEFAULT '' AFTER `roomid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomreservation` ADD COLUMN `roomrate` DOUBLE NOT NULL DEFAULT 0 AFTER `rateid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomreservation` ADD COLUMN `officeid` VARCHAR(10) NOT NULL DEFAULT '' AFTER `trnid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-07-15"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblhotelroomstatus` (  `statuscode` varchar(5) NOT NULL,  `description` varchar(60) NOT NULL DEFAULT '',  `updateroomstatus` tinyint(1) NOT NULL DEFAULT '0',  `vacantcleared` tinyint(1) NOT NULL DEFAULT '0',  `maintainance` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`statuscode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelrooms` ADD COLUMN `roomstatus` VARCHAR(5) NOT NULL AFTER `maintainance`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-07-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `enableinventory` BOOLEAN NOT NULL DEFAULT 1 AFTER `enableoperation`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `svchargerate` DOUBLE NOT NULL DEFAULT 0 AFTER `taxtotal`, ADD COLUMN `svchargetotal` DOUBLE NOT NULL DEFAULT 0 AFTER `svchargerate`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompanysettings` ADD COLUMN `addvattotal` BOOLEAN NOT NULL DEFAULT 0 AFTER `vatpercentage`, ADD COLUMN `svchargepercentage` DOUBLE NOT NULL DEFAULT 0 AFTER `addvattotal`, ADD COLUMN `addsvtotal` BOOLEAN NOT NULL DEFAULT 0 AFTER `svchargepercentage`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `svchargeitem` BOOLEAN NOT NULL DEFAULT 0 AFTER `vatableitem`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `totalsvcharge` DOUBLE NOT NULL DEFAULT 0 AFTER `totaltax`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `digitalpaymentapproving` BOOLEAN NOT NULL DEFAULT 0 AFTER `enableclinicsservices`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpurchaseorder` ADD COLUMN `paymentapproved` BOOLEAN NOT NULL DEFAULT 0 AFTER `paymentrequested`, ADD COLUMN `datepaymentapproved` DATETIME AFTER `paymentapproved`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE  `tblgeneralsettings` ADD COLUMN `clientstockreceiving` BOOLEAN NOT NULL DEFAULT 0 AFTER `digitalpaymentapproving`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablevoucherpaymentposting` BOOLEAN NOT NULL DEFAULT 1 AFTER `clientstockreceiving`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbankaccounts` ADD COLUMN `bankaccounts` BOOLEAN NOT NULL DEFAULT 1 AFTER `begbalance`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `hotelreservation` BOOLEAN NOT NULL DEFAULT 0 AFTER `hotelmgt`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Added Optional service charge per product upon sold<br/>  "
            updateDescription += " - Added computerized approving for payment voucher request<br/>  "
            updateDescription += " - Added computerized approving for purchase order request<br/>  "
            engineupdated = True
        End If

        updateVersion = "2017-07-20"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblproductserviceitem` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `source_productid` varchar(100) NOT NULL,  `productid` varchar(100) NOT NULL,  `amount` double NOT NULL DEFAULT '0',  `officeid` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`) USING BTREE,  KEY `source_productid` (`source_productid`),  KEY `productid` (`productid`)) ENGINE=InnoDB AUTO_INCREMENT=1518 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            updateDescription += " - Added service product menu maker, segregated income by office<br/>  "
            engineupdated = True
        End If

        updateVersion = "2017-07-21"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblvouchersdetail` ADD COLUMN `officeid` VARCHAR(15) NOT NULL AFTER `voucherno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvouchersdetail` CHANGE COLUMN `amount` `debit` DOUBLE NOT NULL DEFAULT 0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvouchersdetail` ADD COLUMN `credit` DOUBLE NOT NULL DEFAULT 0 AFTER `debit`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvouchers` ADD COLUMN `gltoken` VARCHAR(100) NOT NULL DEFAULT '' AFTER `cancelledby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `gltoken` VARCHAR(100) NOT NULL DEFAULT '' AFTER `cancelledby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbankaccounts` ADD COLUMN `glitemtag` VARCHAR(15) NOT NULL DEFAULT '' AFTER `bankname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvouchers` MODIFY COLUMN `gltoken` VARCHAR(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvouchers` ADD COLUMN `receivedby` VARCHAR(50) NOT NULL DEFAULT '' AFTER `clearedby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `allowreceivedexceedingpoamount` BOOLEAN NOT NULL DEFAULT 0 AFTER `enablevoucherpaymentposting`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpurchaseorder` ADD COLUMN `verifiedexceededamountby` VARCHAR(15) NOT NULL DEFAULT '' AFTER `receivedby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `allowdisbursepobybatch` BOOLEAN NOT NULL DEFAULT 1 AFTER `allowreceivedexceedingpoamount`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvouchers` DROP COLUMN `pid`, DROP COLUMN `ponumber`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblvouchers` ADD COLUMN `purchaseorder` BOOLEAN NOT NULL DEFAULT 0 AFTER `vouchertype`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpurchaseorder` DROP COLUMN `paymentapproved`, DROP COLUMN `datepaymentapproved`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglsettings` ADD COLUMN `ticketsequence` VARCHAR(10) NOT NULL DEFAULT '0000' AFTER `companycode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))

            updateDescription += " - Added Automation Accounting Module (70% completed) <br/>  "
            updateDescription += " - Added Accounting ticket journal entries <br/>  "
            updateDescription += " - Added Accounting Standard Mneomonic accounting code function<br/>  "
            updateDescription += " - Added Accounting Accounting Tickets<br/>  "
            updateDescription += " - Re-construct voucher function to translate accounting entries <br/>  "
            updateDescription += " - Re-construct purchase order function to translate accounting entries <br/>  "
            updateDescription += " - Re-construct accounts payable function to translate accounting entries <br/>  "
            updateDescription += " - Re-construct sales overages/shortages to translate accounting entries <br/>  "

            If MessageBox.Show("Update will drop accounting ticket and journal table! are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "DROP TABLE IF EXISTS `tblgljournal`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "CREATE TABLE `tblgljournal` (  `ticketno` varchar(15) NOT NULL,  `gltoken` varchar(100) NOT NULL DEFAULT '',  `officeid` varchar(45) NOT NULL DEFAULT '',  `corporatelevel` tinyint(1) NOT NULL DEFAULT '1',  `remarks` varchar(500) NOT NULL DEFAULT '',  `datetrn` datetime NOT NULL,  `amount` double NOT NULL DEFAULT '0',  `trnby` varchar(100) NOT NULL DEFAULT '',  `verified` tinyint(1) NOT NULL DEFAULT '0',  `dateverified` datetime DEFAULT NULL,  `verifiedby` varchar(100) DEFAULT '',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(100) NOT NULL DEFAULT '',  `datecancelled` datetime DEFAULT NULL,  PRIMARY KEY (`ticketno`) USING BTREE) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))

                com.CommandText = "DROP TABLE IF EXISTS `tblglticket`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "CREATE TABLE `tblglticket` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `ticketno` varchar(15) NOT NULL DEFAULT '',  `gltoken` varchar(100) NOT NULL DEFAULT '',  `officeid` varchar(45) NOT NULL DEFAULT '',  `groupcode` varchar(5) NOT NULL DEFAULT '',  `itemcode` varchar(10) NOT NULL DEFAULT '',  `itemname` varchar(100) NOT NULL DEFAULT '',  `debit` double NOT NULL DEFAULT '0',  `credit` double NOT NULL DEFAULT '0',  `remarks` varchar(500) NOT NULL DEFAULT '',  `datetrn` datetime NOT NULL,  `trnby` varchar(100) NOT NULL DEFAULT '',  `cleared` tinyint(1) NOT NULL DEFAULT '0',  `datecleared` datetime DEFAULT NULL,  `clearedby` varchar(100) NOT NULL DEFAULT '',  PRIMARY KEY (`id`) USING BTREE,  KEY `itemcode` (`itemcode`)) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If

            If MessageBox.Show("Do you want to convert MYSAM table format of sales table? Note: " & Environment.NewLine & Environment.NewLine & "if you continue please advice all users to logout", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "ALTER TABLE `tblsalestransaction` ENGINE = MyISAM ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "ALTER TABLE `tblsalesbatch` ENGINE = MyISAM ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                updateDescription += " - Upgrading sales table to MYSAM format to make transaction 3 times faster<br/>  "
            End If
            engineupdated = True
        End If

        updateVersion = "2017-07-22"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblproductserviceitem` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `source_productid` varchar(100) NOT NULL,  `productid` varchar(100) NOT NULL,  `amount` double NOT NULL DEFAULT '0',  `officeid` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`) USING BTREE,  KEY `source_productid` (`source_productid`),  KEY `productid` (`productid`)) ENGINE=InnoDB AUTO_INCREMENT=1518 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglsettings` DROP COLUMN `gltype`, DROP COLUMN `value`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglsettings` ADD COLUMN `stockintransit` VARCHAR(45) NOT NULL DEFAULT '' AFTER `onlinepayment`, ADD COLUMN `stockreceived` VARCHAR(45) NOT NULL DEFAULT '' AFTER `stockintransit`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-07-23"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `servicemenuproduct` BOOLEAN NOT NULL DEFAULT 0 AFTER `menuitem`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblunitconverter` ADD COLUMN `autoconvert` BOOLEAN NOT NULL DEFAULT 0 AFTER `quantity_target`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollattendancelog` ADD COLUMN `officeid` VARCHAR(15) NOT NULL DEFAULT '' AFTER `employeeid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `filedir`.`tblattendanceimage` ADD COLUMN `officeid` VARCHAR(15) NOT NULL AFTER `employeeid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblpayrollattendancelog` set officeid=(select officeid from tblemployees where employeeid = tblpayrollattendancelog.employeeid);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `filedir`.`tblattendanceimage` set officeid=ifnull((select officeid from tblemployees where employeeid = tblattendanceimage.employeeid),'');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` MODIFY COLUMN `hotelmaintainancedefaultstatus` VARCHAR(5) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'CO';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalesmenumakerservice` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `officeid` varchar(45) NOT NULL,  `refnumber` varchar(10) NOT NULL,  `productid` varchar(50) NOT NULL,  `productname` varchar(100) NOT NULL DEFAULT '',  `quantity` double NOT NULL DEFAULT '0',  `amount` double NOT NULL DEFAULT '0',  `total` double NOT NULL DEFAULT '0',  `salesofficeid` varchar(45) NOT NULL,  `void` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `menumakerservicereferenceno` VARCHAR(10) NOT NULL DEFAULT 10000 AFTER `menumakerreferenceno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `menumakerserviceref` VARCHAR(10) NOT NULL DEFAULT '' AFTER `menumakerstockref`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD INDEX `menumakerstockref`(`menumakerstockref`), ADD INDEX `menumakerserviceref`(`menumakerserviceref`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-07-24"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblpayrollshiftsettings` ADD COLUMN `onetimeinout` BOOLEAN NOT NULL DEFAULT 0 AFTER `flexiregtime`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelroomratesbreakdown` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `roomtype` VARCHAR(15) NOT NULL,  `roomrateid` VARCHAR(15) NOT NULL,  `productid` VARCHAR(45) NOT NULL,  `officeid` VARCHAR(15) NOT NULL,  PRIMARY KEY (`id`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-07-25"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `duetosequenceno` VARCHAR(10) NOT NULL DEFAULT '0000' AFTER `allowdisbursepobybatch`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalesinteroffice` (  `trnno` varchar(15) NOT NULL,  `trnsumcode` varchar(45) NOT NULL,  `batchcode` varchar(25) DEFAULT NULL,  `originofficeid` varchar(15) NOT NULL,  `duetoofficeid` varchar(45) NOT NULL,  `transactioncode` varchar(15) NOT NULL,  `remarks` varchar(45) NOT NULL DEFAULT '',  `amount` double NOT NULL,  `datetrn` datetime NOT NULL,  `trnby` varchar(5) NOT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` datetime DEFAULT NULL,  `cancelledby` varchar(5) NOT NULL DEFAULT '',  PRIMARY KEY (`trnno`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `subcatid` VARCHAR(15) NOT NULL AFTER `catid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD INDEX `subcatid`(`subcatid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblprosubcategory` (  `subcatid` varchar(10) NOT NULL DEFAULT '',  `catid` varchar(10) NOT NULL,  `description` varchar(155) NOT NULL,  PRIMARY KEY (`subcatid`) USING BTREE,  KEY `subcatid` (`subcatid`),  KEY `description` (`description`),  KEY `catid` (`catid`)) ENGINE=MyISAM AUTO_INCREMENT=62 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `allowchangeitempo` BOOLEAN NOT NULL DEFAULT 0 AFTER `duetosequenceno`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `allowaccessallonhold` BOOLEAN NOT NULL DEFAULT 0 AFTER `allowchangeitempo`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-07-26"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblstockoutitem` ADD COLUMN `batchcode` VARCHAR(15) NOT NULL DEFAULT '' AFTER `id`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblstockoutbatch` (  `batchcode` varchar(45) NOT NULL DEFAULT '',  `inventory` varchar(45) NOT NULL,  `allocatedstockout` tinyint(1) NOT NULL,  `allocatedoffice` varchar(45) NOT NULL,  `remarks` varchar(100) NOT NULL DEFAULT '',  `datetrn` datetime NOT NULL,  `trnby` varchar(45) NOT NULL,  `verified` tinyint(1) NOT NULL DEFAULT '0',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` datetime DEFAULT NULL,  `cancelledby` varchar(45) DEFAULT NULL,  PRIMARY KEY (`batchcode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelroomsalesbreakdown` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `foliono` VARCHAR(45) NOT NULL DEFAULT '',  `trndate` DATE NOT NULL,  `productid` VARCHAR(45) NOT NULL DEFAULT '',  `productname` VARCHAR(105) NOT NULL DEFAULT '',  `amount` DOUBLE NOT NULL DEFAULT 0,  `officeid` VARCHAR(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhoteltransaction` ADD COLUMN `roomprofit` DOUBLE NOT NULL DEFAULT 0 AFTER `roomcharge`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomrates` ADD COLUMN `enablecustomextranight` BOOLEAN NOT NULL DEFAULT 0 AFTER `actived`, ADD COLUMN `extranightproductid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `enablecustomextranight`, ROW_FORMAT = DYNAMIC;SELECT * FROM `tblhotelroomrates`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `enablecenter` BOOLEAN NOT NULL DEFAULT 0 AFTER `servicemenuproduct`, ADD COLUMN `officecenter` VARCHAR(45) NOT NULL DEFAULT '' AFTER `enablecenter`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD INDEX `officecenter`(`officecenter`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomratesbreakdown` DROP COLUMN `officeid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `enablecoupon` BOOLEAN NOT NULL DEFAULT 0 AFTER `officecenter`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `couponseriesno` VARCHAR(10) NOT NULL DEFAULT '0000' AFTER `allowaccessallonhold`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalescoupon` (  `couponcode` varchar(30) NOT NULL DEFAULT '',  `trntype` varchar(45) NOT NULL DEFAULT '',  `trnsumcode` varchar(45) NOT NULL DEFAULT '',  `batchcode` varchar(45) NOT NULL DEFAULT '',  `trnofficeid` varchar(45) NOT NULL DEFAULT '',  `centerofficeid` varchar(45) NOT NULL DEFAULT '',  `productid` varchar(45) NOT NULL DEFAULT '',  `quantity` double NOT NULL DEFAULT '0',  `unit` varchar(45) NOT NULL DEFAULT '',  `unitprice` double NOT NULL DEFAULT '0',  `total` double NOT NULL DEFAULT '0',  `verified` tinyint(1) NOT NULL DEFAULT '0',  `verifiedby` varchar(45) NOT NULL DEFAULT '',  `dateverified` datetime DEFAULT NULL,  `verifiedoffice` varchar(45) NOT NULL DEFAULT '',  `verifiedbatchcode` varchar(45) NOT NULL DEFAULT '',  `verifiedtrnsumcode` varchar(45) NOT NULL DEFAULT '',  `datetrn` datetime NOT NULL,  `trnby` varchar(45) NOT NULL DEFAULT '',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` datetime DEFAULT NULL,  `cancelledby` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`couponcode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtype` ADD COLUMN `maxpax` INTEGER UNSIGNED NOT NULL DEFAULT 0 AFTER `description`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomrates` DROP COLUMN `description`, DROP COLUMN `enablecustomextranight`, DROP COLUMN `extranightproductid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomrates` ADD COLUMN `adultpackageid` VARCHAR(45) NOT NULL AFTER `amount`, ADD COLUMN `childppackageid` VARCHAR(45) NOT NULL AFTER `adultpackageid`, ADD COLUMN `extrapersonpackageid` VARCHAR(45) NOT NULL AFTER `childppackageid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomrates` ADD COLUMN `enablechildpackage` BOOLEAN NOT NULL DEFAULT 0 AFTER `adultpackageid`, ADD COLUMN `enablextrapersonpackage` BOOLEAN NOT NULL DEFAULT 0 AFTER `childppackageid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblhotelroomratesbreakdown`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If
        updateVersion = "2017-07-27"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelrooms` ADD COLUMN `cluster` VARCHAR(45) NOT NULL DEFAULT '' AFTER `roomnumber`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            If MessageBox.Show("Update will drop OLD HOTEL ROOM RATE! are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "ALTER TABLE `tblhotelrooms` DROP COLUMN `roomrate`, DROP COLUMN `promorate`, DROP COLUMN `extrabedrate`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            com.CommandText = "ALTER TABLE `tblglobalproducts` MODIFY COLUMN `catid` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `subcatid` VARCHAR(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `itemname` VARCHAR(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `partnumber` VARCHAR(105) CHARACTER SET latin1 COLLATE latin1_swedish_ci;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `packageid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `rateid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomreservation` ADD COLUMN `packageid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `rateid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelgroupaddon` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `bookno` varchar(45) NOT NULL DEFAULT '',  `trndate` date NOT NULL,  `productid` varchar(45) NOT NULL DEFAULT '',  `quantity` double NOT NULL DEFAULT '0',  `unit` varchar(45) NOT NULL DEFAULT '',  `unitprice` double NOT NULL DEFAULT '0',  `total` double NOT NULL DEFAULT '0',  `remarks` varchar(105) NOT NULL DEFAULT '',  `officeid` varchar(45) NOT NULL DEFAULT '',  `confirmed` tinyint(1) NOT NULL DEFAULT '0',  `trnby` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelgroupdaysummary` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `bookno` varchar(45) NOT NULL DEFAULT '',  `trndate` date NOT NULL,  `totalpax` double NOT NULL DEFAULT '0',  `rateperpax` double NOT NULL DEFAULT '0',  `confirmed` tinyint(1) NOT NULL DEFAULT '0',  `trnby` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelgroupreservation` (  `bookno` varchar(20) NOT NULL,  `guestid` varchar(45) NOT NULL,  `datearival` date NOT NULL,  `datecheckout` date NOT NULL,  `totalpackage` double NOT NULL DEFAULT '0',  `discount` double NOT NULL DEFAULT '0',  `netpackage` double NOT NULL DEFAULT '0',  `totalservice` double NOT NULL DEFAULT '0',  `miscincome` double NOT NULL DEFAULT '0',  `downpayment` double NOT NULL DEFAULT '0',  `balance` double NOT NULL DEFAULT '0',  `datetrn` datetime NOT NULL,  `trnby` varchar(45) NOT NULL DEFAULT '',  `proceed` tinyint(1) NOT NULL DEFAULT '0',  `dateproceed` datetime DEFAULT NULL,  `proceedby` varchar(45) NOT NULL DEFAULT '',  `cancelled` datetime DEFAULT NULL,  `cancelledby` varchar(45) NOT NULL DEFAULT '',  `datecancelled` datetime DEFAULT NULL,  `cancelledremarks` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`bookno`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelgrouproom` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `bookno` varchar(45) NOT NULL DEFAULT '',  `trndate` date NOT NULL,  `hotelcif` varchar(45) NOT NULL DEFAULT '',  `roomid` varchar(45) NOT NULL DEFAULT '',  `roomno` varchar(45) NOT NULL,  `description` varchar(100) NOT NULL DEFAULT '',  `roomtype` varchar(45) NOT NULL,  `rateid` varchar(45) NOT NULL DEFAULT '',  `packageid` varchar(45) NOT NULL DEFAULT '',  `pax` bigint(20) unsigned NOT NULL DEFAULT '0',  `roomrate` double NOT NULL DEFAULT '0',  `child` int(10) unsigned NOT NULL DEFAULT '0',  `childrate` double NOT NULL DEFAULT '0',  `extra` int(10) unsigned NOT NULL DEFAULT '0',  `extrarate` double NOT NULL DEFAULT '0',  `total` double NOT NULL,  `confirmed` tinyint(1) NOT NULL DEFAULT '0',  `trnby` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhoteltransaction` ADD COLUMN `tax` DOUBLE NOT NULL DEFAULT 0 AFTER `credit`, ADD COLUMN `svcharge` DOUBLE NOT NULL DEFAULT 0 AFTER `tax`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `noextra` DOUBLE NOT NULL DEFAULT 0 AFTER `nochild`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `childrate` DOUBLE NOT NULL DEFAULT 0 AFTER `nochild`, ADD COLUMN `extrarate` DOUBLE NOT NULL DEFAULT 0 AFTER `noextra`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` DROP COLUMN `extrabed`, DROP COLUMN `totalextrabed`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `roomcharge` DOUBLE NOT NULL DEFAULT 0 AFTER `extrarate`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalescoupon` ADD COLUMN `coupondate` DATE AFTER `total`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomsdiscounttransaction` ADD COLUMN `disapproved` BOOLEAN NOT NULL DEFAULT 0 AFTER `dateoveride`, ADD COLUMN `disapprovedby` VARCHAR(45) NOT NULL DEFAULT '' AFTER `disapproved`, ADD COLUMN `datedisapproved` DATETIME AFTER `disapprovedby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomsdiscounttransaction` ADD COLUMN `remarks` VARCHAR(45) NOT NULL DEFAULT '' AFTER `totalamount`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `roomtype` VARCHAR(45) NOT NULL DEFAULT '' AFTER `roomid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhoteltransaction` ADD COLUMN `roomtype` VARCHAR(45) NOT NULL DEFAULT '' AFTER `roomcharge`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-07-28"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `stockoutbatchsequence` VARCHAR(45) NOT NULL DEFAULT '0000' AFTER `couponseriesno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblstockoutbatch` ADD COLUMN `datestockout` DATE NOT NULL AFTER `inventory`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalestransaction` MODIFY COLUMN `catid` VARCHAR(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `unit` VARCHAR(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', ADD COLUMN `attendingperson` VARCHAR(45) NOT NULL DEFAULT '' AFTER `income`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `requiredattendingpersonnel` BOOLEAN NOT NULL DEFAULT 0 AFTER `servicemenuproduct`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-07-29"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "update `tblglobalproducts` set partnumber='' where partnumber is null;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblglobalproducts` set unit='' where unit is null;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblglobalproducts` set salemode='' where salemode is null;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblglobalproducts` set entryby='' where entryby is null;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` MODIFY COLUMN `partnumber` VARCHAR(105) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `unit` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `menuitem` TINYINT(1) NOT NULL DEFAULT 0, MODIFY COLUMN `salemode` VARCHAR(5) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT 'esbq', MODIFY COLUMN `entryby` VARCHAR(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '100';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-07-30"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglticket` MODIFY COLUMN `groupcode` VARCHAR(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, MODIFY COLUMN `itemcode` VARCHAR(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-07-31"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE  `tblhotelroomtransaction` ADD COLUMN `companion` TEXT AFTER `remarks`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` MODIFY COLUMN `queuingproductcategory` VARCHAR(200) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL, ADD COLUMN `hoteldefaultcheckinstatuscode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `enablehotelmaintainanceuponcheckout`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE  `tblgeneralsettings` ADD COLUMN `hoteldefaultvacantstatuscode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `enablehotelmaintainanceuponcheckout`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `defaultdiscountcategory` VARCHAR(45) NOT NULL DEFAULT '' AFTER `stockoutbatchsequence`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-01"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `flight` VARCHAR(100) NOT NULL DEFAULT '' AFTER `remarks`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomrates` MODIFY COLUMN `roomtype` VARCHAR(5) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `amount` DOUBLE NOT NULL DEFAULT 0, MODIFY COLUMN `adultpackageid` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `childppackageid` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `extrapersonpackageid` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomrates` ADD COLUMN `enableextranightpackage` BOOLEAN NOT NULL AFTER `adultpackageid`, ADD COLUMN `extranightpackageid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `enableextranightpackage`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `extranightpackage` VARCHAR(105) NOT NULL DEFAULT '' AFTER `roomrate`, ADD COLUMN `extranightrate` DOUBLE NOT NULL DEFAULT 0 AFTER `extranightpackage`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-02"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblhotelagent` (  `code` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `agentname` VARCHAR(100) NOT NULL,  PRIMARY KEY (`code`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-03"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblhotelfolio` (  `bookno` varchar(50) NOT NULL DEFAULT '',  `guestid` varchar(45) NOT NULL DEFAULT '',  `arival` date NOT NULL,  `departure` date NOT NULL,  `companion` text,  `totalpackage` double NOT NULL DEFAULT '0',  `discountcode` varchar(45) NOT NULL DEFAULT '',  `discountrate` double NOT NULL DEFAULT '0',  `totaldiscount` double NOT NULL DEFAULT '0',  `totaldue` double NOT NULL DEFAULT '0',  `agentcode` varchar(45) NOT NULL DEFAULT '',  `flight` varchar(45) NOT NULL DEFAULT '',  `remarks` text,  `trnby` varchar(45) NOT NULL DEFAULT '',  `datetrn` datetime NOT NULL,  `confirmed` tinyint(1) NOT NULL DEFAULT '0',  `confirmedby` varchar(45) NOT NULL DEFAULT '',  `dateconfirmed` datetime DEFAULT NULL,  `closed` tinyint(1) NOT NULL DEFAULT '0',  `dateclosed` datetime DEFAULT NULL,  `closedby` varchar(45) NOT NULL DEFAULT '',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` datetime DEFAULT NULL,  `cancelledby` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`bookno`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelgroupaddon` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `bookno` varchar(45) NOT NULL DEFAULT '',  `trndate` date NOT NULL,  `productid` varchar(45) NOT NULL DEFAULT '',  `quantity` double NOT NULL DEFAULT '0',  `unit` varchar(45) NOT NULL DEFAULT '',  `unitprice` double NOT NULL DEFAULT '0',  `total` double NOT NULL DEFAULT '0',  `remarks` varchar(105) NOT NULL DEFAULT '',  `officeid` varchar(45) NOT NULL DEFAULT '',  `confirmed` tinyint(1) NOT NULL DEFAULT '0',  `trnby` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelgrouproom` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `bookno` varchar(45) NOT NULL DEFAULT '',  `trndate` date NOT NULL,  `hotelcif` varchar(45) NOT NULL DEFAULT '',  `roomid` varchar(45) NOT NULL DEFAULT '',  `roomno` varchar(45) NOT NULL,  `description` varchar(100) NOT NULL DEFAULT '',  `roomtype` varchar(45) NOT NULL,  `rateid` varchar(45) NOT NULL DEFAULT '',  `packageid` varchar(45) NOT NULL DEFAULT '',  `pax` bigint(20) unsigned NOT NULL DEFAULT '0',  `roomrate` double NOT NULL DEFAULT '0',  `child` int(10) unsigned NOT NULL DEFAULT '0',  `childrate` double NOT NULL DEFAULT '0',  `extra` int(10) unsigned NOT NULL DEFAULT '0',  `extrarate` double NOT NULL DEFAULT '0',  `total` double NOT NULL,  `confirmed` tinyint(1) NOT NULL DEFAULT '0',  `trnby` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `receipt` TEXT AFTER `datetrn`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalescoupon` ADD COLUMN `receipt` TEXT AFTER `cancelledby`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalescashdenomination` ADD COLUMN `receipt` TEXT AFTER `timeposted`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `blotter` TEXT AFTER `gltoken`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesdeliveryslip` ADD COLUMN `receipt` TEXT AFTER `cancelledby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `requiredpostoclosed` BOOLEAN NOT NULL DEFAULT 0 AFTER `defaultdiscountcategory`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD COLUMN `birthdate` DATE AFTER `telephone`, ADD COLUMN `emailadd` VARCHAR(100) AFTER `birthdate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `walkinguest` BOOLEAN NOT NULL DEFAULT 1 AFTER `foliono`, ADD COLUMN `bookingref` VARCHAR(45) NOT NULL DEFAULT '' AFTER `walkinguest`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhoteltransaction` ADD COLUMN `bookingref` VARCHAR(45) NOT NULL DEFAULT '' AFTER `folioid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomsdiscounttransaction` ADD COLUMN `bookingref` VARCHAR(45) NOT NULL DEFAULT '' AFTER `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-04"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            If MessageBox.Show("Update will drop stockoutbatch table! are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "DROP TABLE IF EXISTS `tblstockoutbatch`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "CREATE TABLE `tblstockoutbatch` (  `batchcode` varchar(45) NOT NULL DEFAULT '',  `inventory` varchar(45) NOT NULL,  `datestockout` date NOT NULL,  `allocatedstockout` tinyint(1) NOT NULL,  `allocatedoffice` varchar(45) NOT NULL,  `requestby` varchar(45) NOT NULL,  `remarks` varchar(100) NOT NULL DEFAULT '',  `datetrn` datetime NOT NULL,  `trnby` varchar(45) NOT NULL,  `verified` tinyint(1) NOT NULL DEFAULT '0',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` datetime DEFAULT NULL,  `cancelledby` varchar(45) DEFAULT NULL,  PRIMARY KEY (`batchcode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            engineupdated = True
        End If

        updateVersion = "2017-08-05"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `stockouttitle` VARCHAR(105) NOT NULL DEFAULT '' AFTER `requiredpostoclosed`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-08"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE filedir.`tblemployeepic` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `employeeid` VARCHAR(45) NOT NULL,  `img` LONGBLOB,  PRIMARY KEY (`id`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblemployees` ADD COLUMN `payouttype` BOOLEAN NOT NULL DEFAULT 0 AFTER `linkclientid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `customproductorder` BOOLEAN NOT NULL DEFAULT 0 AFTER `servicemenuproduct`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `customproductorder` BOOLEAN NOT NULL DEFAULT 0 AFTER `productname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `customorderproductcategory` VARCHAR(105) NOT NULL DEFAULT '' AFTER `stockouttitle`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-09"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblsalesproductcustomorder` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `officeid` varchar(45) NOT NULL DEFAULT '',  `trnsumcode` varchar(45) NOT NULL DEFAULT '',  `batchcode` varchar(45) NOT NULL DEFAULT '',  `postrn` varchar(10) NOT NULL DEFAULT '',  `refno` varchar(10) NOT NULL DEFAULT '',  `productid` varchar(50) NOT NULL DEFAULT '',  `productname` varchar(100) NOT NULL DEFAULT '',  `quantity` double NOT NULL DEFAULT '0',  `unit` varchar(45) NOT NULL DEFAULT '',  `unitprice` double NOT NULL DEFAULT '0',  `void` tinyint(1) NOT NULL DEFAULT '0',  `trnby` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablecombinepossalesquantity` BOOLEAN NOT NULL DEFAULT 0 AFTER `customorderproductcategory`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableposviewrowborder` BOOLEAN NOT NULL DEFAULT 1 AFTER `enablecombinepossalesquantity`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-10"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblcompdepartments` (  `depid` VARCHAR(15) NOT NULL,  `officeid` VARCHAR(45) NOT NULL,  `departmentname` VARCHAR(100) NOT NULL,  PRIMARY KEY (`depid`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblemployees` ADD COLUMN `depid` VARCHAR(15) NOT NULL DEFAULT '' AFTER `officeid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelgrouproom` ADD COLUMN `folioid` VARCHAR(45) NOT NULL AFTER `confirmed`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE  `tblhotelfolio` ADD COLUMN `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT first, DROP PRIMARY KEY, ADD PRIMARY KEY  USING BTREE(  `id`), AUTO_INCREMENT = 1000;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalescoupon` ADD COLUMN `printed` BOOLEAN NOT NULL DEFAULT 0 AFTER `receipt`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelguestcompanion` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `bookno` varchar(45) NOT NULL DEFAULT '',  `fullname` varchar(45) NOT NULL DEFAULT '',  `age` varchar(5) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `offsetbalance` DOUBLE NOT NULL DEFAULT 0 AFTER `totalamount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `updaterequired` BOOLEAN NOT NULL DEFAULT 0 AFTER `ffetype`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `dateupdated` DATETIME DEFAULT 0 AFTER `dateentered`, ADD COLUMN `updatedby` VARCHAR(45) NOT NULL DEFAULT '' AFTER `dateupdated`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            If MessageBox.Show("Do you want to UPDATE Product as update required enable?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "UPDATE `tblglobalproducts` set updaterequired=1, allowinputdiscountedamount=1  where enablesell=1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            engineupdated = True
        End If

        updateVersion = "2017-08-12"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `totalextranight` DOUBLE NOT NULL DEFAULT 0 AFTER `extranightrate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-13"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "UPDATE tblglitem set sl=1 where gl=1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            If MessageBox.Show("Do you want to update GL item level?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "UPDATE tblglitem set `level`=`level`+1 where glgroup=0;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            engineupdated = True
        End If

        updateVersion = "2017-08-14"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompanysettings` ADD COLUMN `tokencode` VARCHAR(100) NOT NULL AFTER `enginecode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblcompanysettings set tokencode='" & EncryptTripleDES("EXPIRED") & "'" : com.ExecuteNonQuery()
            engineupdated = True
        End If

        updateVersion = "2017-08-15"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `stockoutbatchtemplate` VARCHAR(45) NOT NULL DEFAULT 'default' AFTER `enableposviewrowborder`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventory` ADD COLUMN `stockref` VARCHAR(45) NOT NULL DEFAULT '' AFTER `officeid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventorylogs` ADD COLUMN `stockref` VARCHAR(45) NOT NULL DEFAULT '' AFTER `batchcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventoryledger` MODIFY COLUMN `trnby` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT '', ADD COLUMN `reqoffice` VARCHAR(45) NOT NULL DEFAULT '' AFTER `remarks`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE  `tblsalesinteroffice` ADD COLUMN `coveredamount` DOUBLE NOT NULL DEFAULT 0 AFTER `amount`, ADD COLUMN `excessamount` DOUBLE NOT NULL DEFAULT 0 AFTER `coveredamount`, ADD COLUMN `excesscashpayment` BOOLEAN NOT NULL DEFAULT 0 AFTER `excessamount`, ADD COLUMN `totalmount` DOUBLE NOT NULL DEFAULT 0 AFTER `excesscashpayment`, ADD COLUMN `paymentref` VARCHAR(45) NOT NULL DEFAULT '' AFTER `totalmount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `bir_or_number` VARCHAR(45) NOT NULL DEFAULT '00000' AFTER `stockoutbatchtemplate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-17"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelgrouproom` MODIFY COLUMN `roomno` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `roomtype` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `total` DOUBLE NOT NULL DEFAULT 0, MODIFY COLUMN `folioid` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If
        updateVersion = "2017-08-18"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblclientdiscounts` CHANGE COLUMN `productid` `catid` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, DROP INDEX `productid`, ADD INDEX `productid` USING BTREE(`catid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-19"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelroomreservation` ADD COLUMN `agentcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `paymentreference`, ADD COLUMN `remarks` TEXT AFTER `agentcode`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelfolio` ADD COLUMN `bookedconfirmed` BOOLEAN NOT NULL DEFAULT 0 AFTER `trnby`, ADD COLUMN `datebookedconfirmed` DATETIME AFTER `bookedconfirmed`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelfolio` ADD COLUMN `bookedconfirmedby` VARCHAR(45) NOT NULL DEFAULT '' AFTER `datebookedconfirmed`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-20"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelroomtype` ADD COLUMN `chargepernight` boolean NOT NULL default 1 AFTER `description`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `chargepernight` BOOLEAN NOT NULL DEFAULT 1 AFTER `nodays`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelgrouproom` ADD COLUMN `chargepernight` BOOLEAN NOT NULL DEFAULT 1 AFTER `roomtype`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-21"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            If MessageBox.Show("Do you want to drop hotel room rates?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "DROP TABLE IF EXISTS `tblhotelroomrates`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "CREATE TABLE `tblhotelroomrates` (  `ratecode` int(10) unsigned NOT NULL AUTO_INCREMENT,  `roomtype` varchar(45) NOT NULL,  `description` varchar(100) NOT NULL DEFAULT '',  `actived` tinyint(1) NOT NULL DEFAULT '1',  `lockrate` tinyint(1) NOT NULL DEFAULT '1',  `temporaryrate` tinyint(1) NOT NULL DEFAULT '0',  `bookingno` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`ratecode`) USING BTREE) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            If MessageBox.Show("Do you want to drop hotel package rates breakdown?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "DROP TABLE IF EXISTS `tblhotelratesbreakdown`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "CREATE TABLE `tblhotelratesbreakdown` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `roomtype` varchar(45) NOT NULL,  `ratecode` varchar(45) NOT NULL DEFAULT '',  `breakdowntype` varchar(45) NOT NULL,  `itemcode` varchar(45) NOT NULL,  `itemname` varchar(105) NOT NULL,  `amount` double NOT NULL DEFAULT '0',  PRIMARY KEY (`id`) USING BTREE) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            com.CommandText = "CREATE TABLE `tblhotelpackageitem` (  `itemcode` varchar(50) NOT NULL DEFAULT '100',  `description` varchar(100) NOT NULL DEFAULT '',  `enablecenter` tinyint(1) NOT NULL DEFAULT '0',  `centerofficeid` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`itemcode`) USING BTREE) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` DROP COLUMN `packageid`, DROP COLUMN `extranightpackage`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelgrouproom` DROP COLUMN `packageid`, DROP COLUMN `roomrate`, DROP COLUMN `childrate`, DROP COLUMN `extrarate`,  DROP COLUMN `total`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelfolio` DROP COLUMN `companion`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-22"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelfolio` ADD COLUMN `customizedrate` BOOLEAN NOT NULL DEFAULT 0 AFTER `departure`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-23"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelgrouproom` ADD COLUMN `cancelled` BOOLEAN NOT NULL DEFAULT 0 AFTER `trnby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelgrouproom` ADD COLUMN `dateposted` DATETIME AFTER `cancelled`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelgroupaddon` ADD COLUMN `dateposted` DATETIME;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelgroupaddon` ADD COLUMN `cancelled` BOOLEAN NOT NULL DEFAULT 0 AFTER `trnby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `reserved` BOOLEAN NOT NULL DEFAULT 0 AFTER `walkinguest`, ADD COLUMN `confirmed` BOOLEAN NOT NULL DEFAULT 0 AFTER `reserved`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` MODIFY COLUMN `walkinguest` INTEGER UNSIGNED NOT NULL DEFAULT 1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `inhouse` BOOLEAN NOT NULL DEFAULT 0 AFTER `confirmed`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblhotelroomtransaction` set inhouse=1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `agentcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `remarks`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomtype` ADD COLUMN `shortcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `hotelcif`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-24"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblpayrollposition` RENAME TO `tblpayrollbasicrate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblemployees` ADD COLUMN `position` VARCHAR(100) NOT NULL DEFAULT '' AFTER `depid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollattendancelog` ADD COLUMN `shiftcode` VARCHAR(20) NOT NULL DEFAULT '' AFTER `employeeid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblpayrollattendancelog` set shiftcode=ifnull((select shiftcode from tblemployees where employeeid=tblpayrollattendancelog.employeeid),'') where shiftcode='';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollattendance` ADD COLUMN `restday` BOOLEAN NOT NULL DEFAULT 0 AFTER `renderedcount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblpayrollattendancefilter` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `approverid` VARCHAR(45) NOT NULL DEFAULT '',  `employeeid` VARCHAR(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `employeeattendance` BOOLEAN NOT NULL DEFAULT 0 AFTER `pumpreading`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-25"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelfolio` ADD COLUMN `cancelledremarks` TEXT AFTER `cancelledby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-26"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelroomtype` ADD COLUMN `sortorder` INTEGER UNSIGNED NOT NULL DEFAULT 0 AFTER `code`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-27"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblhotelfolioseries` (  `hotelcif` VARCHAR(45) NOT NULL,  `foliono` VARCHAR(45) NOT NULL DEFAULT '0000',  PRIMARY KEY (`hotelcif`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` CHANGE COLUMN `stockoutbatchtemplate` `reporttemplate` VARCHAR(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT 'default';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblcommandexecuter` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `commanddate` date NOT NULL,  `commandcode` varchar(45) NOT NULL,  `commandquery` text NOT NULL,  `executed` tinyint(1) NOT NULL,  `dateexecuted` datetime NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `defaultroomoccupieddirty` VARCHAR(45) NOT NULL DEFAULT '' AFTER `bir_or_number`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-29"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `bookingnoseries` VARCHAR(45) NOT NULL DEFAULT '000' AFTER `defaultroomoccupieddirty`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-30"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `tblemployeelevel` (  `code` int(10) unsigned NOT NULL AUTO_INCREMENT,  `description` text NOT NULL,  PRIMARY KEY (`code`) USING BTREE) ENGINE=MyISAM AUTO_INCREMENT=1000 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblemployees` ADD COLUMN `emplevel` VARCHAR(45) NOT NULL DEFAULT '' AFTER `position`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-08-31"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelgrouproom` CHANGE COLUMN `trndate` `arival` DATE NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelgrouproom` ADD COLUMN `departure` DATE AFTER `arival`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            'com.CommandText = "ALTER TABLE `tblhotelgrouproom` ADD COLUMN `nightcount` INTEGER UNSIGNED NOT NULL DEFAULT 1 AFTER `departure`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-01"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblhotelroomsalesbreakdown` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `trnsumcode` varchar(45) NOT NULL DEFAULT '',  `folioid` varchar(45) NOT NULL DEFAULT '',  `roomid` varchar(45) NOT NULL DEFAULT '',  `roomno` varchar(45) NOT NULL DEFAULT '',  `roomtype` varchar(45) NOT NULL DEFAULT '',  `rateid` varchar(45) NOT NULL DEFAULT '',  `quantity` double NOT NULL DEFAULT '0',  `breakdowntype` varchar(45) NOT NULL DEFAULT '',  `itemcode` varchar(45) NOT NULL DEFAULT '',  `itemname` varchar(105) NOT NULL DEFAULT '',  `amount` double NOT NULL DEFAULT '0',  `trndate` date NOT NULL,  `officeid` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=417 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-02"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `hotelitemizedcharge` BOOLEAN NOT NULL DEFAULT 1 AFTER `bookingnoseries`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhoteltransaction` ADD COLUMN `guestcheckno` VARCHAR(45) NOT NULL DEFAULT '' AFTER `referenceno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalesticketpaymenttransaction` (  `trnid` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `trnsumcode` varchar(20) NOT NULL DEFAULT '0',  `batchcode` varchar(25) NOT NULL DEFAULT '',  `itemcode` varchar(500) NOT NULL DEFAULT '',  `amount` double NOT NULL DEFAULT '0',  `remarks` varchar(500) NOT NULL,  `datetrn` datetime NOT NULL,  `trnby` varchar(15) NOT NULL,  `verified` tinyint(1) NOT NULL DEFAULT '0',  `dateverified` datetime DEFAULT NULL,  `verifiedby` varchar(15) DEFAULT NULL,  `cleared` tinyint(1) NOT NULL DEFAULT '0',  `clearedby` varchar(15) DEFAULT NULL,  `datecleared` datetime DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(45) DEFAULT NULL,  `datecancelled` datetime DEFAULT NULL,  PRIMARY KEY (`trnid`) USING BTREE,  KEY `trnsumcode` (`trnsumcode`),  KEY `batchcode` (`batchcode`)) ENGINE=MyISAM AUTO_INCREMENT=105 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `totalacctticket` DOUBLE NOT NULL DEFAULT 0 AFTER `totaldeposit`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblglaccountfilter` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `permissioncode` varchar(45) NOT NULL DEFAULT '',  `itemcode` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=533 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-03"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablebookingroomblocking` BOOLEAN NOT NULL DEFAULT 1 AFTER `hotelitemizedcharge`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesclientcharges` ADD COLUMN `foliocharge` BOOLEAN NOT NULL DEFAULT 0 AFTER `accountno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblsalesclientcharges` set foliocharge=1 where batchcode like '%folio%';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-04"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblcompany` (  `code` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `companyname` VARCHAR(45) NOT NULL,  PRIMARY KEY (`code`))ENGINE = InnoDB AUTO_INCREMENT = 100;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `companyid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `officeid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblprocategory` ADD COLUMN `glitemcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `potypeid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompany` MODIFY COLUMN `companyname` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', ADD COLUMN `assetcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `companyname`, ADD COLUMN `revenuecode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `assetcode`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblstoredprocedure` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `reportname` varchar(105) NOT NULL,  `spname` varchar(105) NOT NULL DEFAULT '',  `singledate` tinyint(1) NOT NULL DEFAULT '1',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=100 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblstoredprocedure` ADD COLUMN `groupcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `singledate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelpackageitem` ADD COLUMN `glitemcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `centerofficeid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomsalesbreakdown` ADD COLUMN `hotelcif` VARCHAR(45) NOT NULL AFTER `trnsumcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblhotelroomsalesbreakdown` set hotelcif=(select hotelcif from tblhotelroomtype where code=tblhotelroomsalesbreakdown.roomtype);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelgroup` (  `hotelcif` VARCHAR(45) NOT NULL,  `officeid` VARCHAR(45) NOT NULL,  PRIMARY KEY (`hotelcif`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            If MessageBox.Show("Table hotel group currently created! please configure database manual before continue next script! Click OK if you are done!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "update `tblhotelroomsalesbreakdown` set officeid=(select officeid from tblhotelgroup where hotelcif=tblhotelroomsalesbreakdown.hotelcif);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            com.CommandText = "ALTER TABLE `tblglticket` MODIFY COLUMN `groupcode` VARCHAR(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', MODIFY COLUMN `itemcode` VARCHAR(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglticket` MODIFY COLUMN `gltoken` VARCHAR(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '', AUTO_INCREMENT = 1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgljournal` MODIFY COLUMN `gltoken` VARCHAR(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelroomchangelog` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `fromroomid` VARCHAR(45) NOT NULL,  `fromroomno` VARCHAR(45) NOT NULL,  `fromroomtype` VARCHAR(45) NOT NULL,  `toroomid` VARCHAR(45) NOT NULL,  `toroomno` VARCHAR(45) NOT NULL,  `toroomtype` VARCHAR(45) NOT NULL,  `remarks` VARCHAR(105) NOT NULL,  `changeby` VARCHAR(45) NOT NULL,  `datechange` DATETIME NOT NULL,  PRIMARY KEY (`id`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomchangelog` ADD COLUMN `overideby` VARCHAR(45) NOT NULL AFTER `datechange`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomchangelog` ADD COLUMN `folioid` VARCHAR(45) NOT NULL AFTER `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomchangelog` ADD COLUMN `guestid` VARCHAR(45) NOT NULL AFTER `folioid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-05"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablehoteldayafterrevenue` BOOLEAN NOT NULL DEFAULT 1 AFTER `enablebookingroomblocking`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomsdiscounttransaction` ADD COLUMN `trnsumcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-06"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `defaultroomstatuschangeroom` VARCHAR(45) NOT NULL AFTER `enablehoteldayafterrevenue`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollsummary` ADD COLUMN `department` VARCHAR(100)  AFTER `office`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollsummary` ADD COLUMN `BasicRate` VARCHAR(105) NOT NULL DEFAULT '' AFTER `EmployeeStatus`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollsummary` MODIFY COLUMN `officeid` VARCHAR(10) CHARACTER SET utf8 COLLATE utf8_general_ci, AUTO_INCREMENT = 1 ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollsummary` MODIFY COLUMN `Office` VARCHAR(200) CHARACTER SET utf8 COLLATE utf8_general_ci, AUTO_INCREMENT = 1 ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpayrollsummary` MODIFY COLUMN `ScheduleCode` VARCHAR(5) CHARACTER SET utf8 COLLATE utf8_general_ci, MODIFY COLUMN `Schedule` VARCHAR(100) CHARACTER SET utf8 COLLATE utf8_general_ci, AUTO_INCREMENT = 1 ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-07"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhoteltransaction` ADD COLUMN `guestid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `folioid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tblhoteltransaction set guestid=ifnull((select guestid from tblhotelroomtransaction where folioid=tblhoteltransaction.folioid),ifnull((select guestid from tblhotelfolio where bookno=tblhoteltransaction.bookingref),''));" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-09"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhoteltransaction` ADD COLUMN `offsetpayment` BOOLEAN NOT NULL DEFAULT 0 AFTER `paymenttrn`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblhoteltransaction` set offsetpayment=1 where credit>0 and remarks like '%Paid by group folio%';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-10"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelguest` ADD COLUMN `guestpreferences` VARCHAR(500) NOT NULL DEFAULT '' AFTER `emailadd`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelroomstatus` ADD COLUMN `color` VARCHAR(50) NOT NULL DEFAULT '' AFTER `maintainance`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelroommaintainance` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `hotelcif` varchar(45) NOT NULL,  `hotelname` varchar(105) NOT NULL,  `roomid` varchar(45) NOT NULL DEFAULT '',  `roomno` varchar(45) NOT NULL DEFAULT '',  `roomdetails` varchar(45) NOT NULL DEFAULT '',  `startdate` datetime NOT NULL,  `enddate` datetime NOT NULL,  `roomstatus` varchar(45) NOT NULL DEFAULT '',  `statusdescription` varchar(105) NOT NULL DEFAULT '',  `remarks` varchar(105) NOT NULL DEFAULT '',  `trnby` varchar(45) NOT NULL DEFAULT '',  `datetrn` datetime NOT NULL,  `updateby` varchar(45) NOT NULL DEFAULT '',  `dateupdated` datetime DEFAULT NULL,  `closed` tinyint(1) NOT NULL DEFAULT '0',  `dateclosed` datetime DEFAULT NULL,  `closeby` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-12"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblreporttemplatetype` (  `code` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `description` VARCHAR(100) NOT NULL,  PRIMARY KEY (`code`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblreporttemplate` ADD COLUMN `reporttype` VARCHAR(45) NOT NULL AFTER `rptid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `reportgenerator` BOOLEAN NOT NULL DEFAULT 0 AFTER `clinicservices`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-13"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblcomplaintbox` (  `code` varchar(25) NOT NULL,  `officeid` varchar(10) NOT NULL,  `respondent` varchar(100) NOT NULL,  `complainant` varchar(100) NOT NULL,  `issue` varchar(100) NOT NULL,  `details` text NOT NULL,  `datecreated` datetime NOT NULL,  `createdby` varchar(40) NOT NULL,  `closed` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`code`) USING BTREE) ENGINE=MyISAM DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblcomplaintboxlogs` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `complaintcode` varchar(100) NOT NULL,  `remarks` text NOT NULL,  `dateposted` datetime NOT NULL,  `postedby` varchar(50) NOT NULL,  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `complaintbox` BOOLEAN NOT NULL DEFAULT 0 AFTER `employeeattendance`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-15"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `hotelgroupautocheckout` BOOLEAN NOT NULL DEFAULT 0 AFTER `defaultroomstatuschangeroom`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablepoceosign` BOOLEAN NOT NULL DEFAULT 0 AFTER `hotelgroupautocheckout`, ADD COLUMN `ceoaccountid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `enablepoceosign`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableprocurementid` BOOLEAN NOT NULL DEFAULT 0 AFTER `ceoaccountid`, ADD COLUMN `procurementid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `enableprocurementid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `complimentary` BOOLEAN NOT NULL DEFAULT 0 AFTER `paymenttype`, ADD COLUMN `complimentaryremarks` VARCHAR(500) NOT NULL DEFAULT '' AFTER `complimentary`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "update `tblpurchaseorderitem` set total=cost*quantity;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-17"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enabledirectinventorytransferconfirmed` BOOLEAN NOT NULL DEFAULT 0 AFTER `procurementid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-18"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "update tblapproverclientprocess set officeid='' where customized=0" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-19"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tbltimeconsoleaddress` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  `officename` VARCHAR(100) NOT NULL,  `ipaddress` VARCHAR(45) NOT NULL,  PRIMARY KEY (`id`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enabletimeconsoleipblocking` BOOLEAN NOT NULL DEFAULT 0 AFTER `enabledirectinventorytransferconfirmed`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-20"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` ADD COLUMN `incidental` DOUBLE NOT NULL DEFAULT 0 AFTER `totalamount`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelfolio` ADD COLUMN `incidental` DOUBLE NOT NULL DEFAULT 0 AFTER `totaldue`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-21"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcomplaintbox` ADD COLUMN `createdid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `datecreated`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblcomplaintbox` inner join tblaccounts on createdby=fullname set createdid=accountid;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `flexiblehotelrate` BOOLEAN NOT NULL DEFAULT 0 AFTER `enabletimeconsoleipblocking`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablestocktransferclearing` BOOLEAN NOT NULL DEFAULT 0 AFTER `flexiblehotelrate`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltransferrequest` ADD COLUMN `cleared` BOOLEAN NOT NULL DEFAULT 0 AFTER `trnby`, ADD COLUMN `clearedby` VARCHAR(45) AFTER `cleared`, ADD COLUMN `datecleared` DATETIME AFTER `clearedby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            If MessageBox.Show("New update contains stock transfer approval, do you want to enable this function?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                com.CommandText = "UPDATE tblgeneralsettings set enablestocktransferclearing=1; " : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                com.CommandText = "update `tbltransferrequest` set cleared=1,clearedby='100',datecleared=current_timestamp where confirmed=1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            Else
                com.CommandText = "update `tbltransferrequest` set cleared=1,clearedby='100',datecleared=current_timestamp;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            End If
            com.CommandText = "UPDATE `tblhoteltransaction` set cancelled=0,cancelledby='' where cancelledby='frmHotelGroupCheckin';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-22"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblrequisitions` ADD COLUMN `allocatedexpense` VARCHAR(45) NOT NULL DEFAULT '' AFTER `priority`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblrequisitionslogs` ADD COLUMN `allocatedexpense` VARCHAR(45) NOT NULL DEFAULT '' AFTER `priority`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-23"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelroomrates` ADD COLUMN `allowzerorate` BOOLEAN NOT NULL DEFAULT 0 AFTER `description`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-24"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            msda = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("show tables in " & sqldatabase, conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    com.CommandText = "ALTER TABLE `" & sqldatabase & "`.`" & .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() & "` ENGINE = MyISAM ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                End With
            Next
            engineupdated = True
        End If

        updateVersion = "2017-09-25"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "update `tblsalesbatch` set paymenttype='cpty' where paymenttype='complimentary';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-26"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblinventoryledger` ADD COLUMN `cost` DOUBLE NOT NULL DEFAULT 0 AFTER `credit`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-27"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `rrnumberseries` VARCHAR(45) NOT NULL DEFAULT '0000' AFTER `enablestocktransferclearing`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-28"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            msda = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("show tables in " & sqldatabase, conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    com.CommandText = "ALTER TABLE `" & sqldatabase & "`.`" & .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() & "` ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
                End With
            Next
            engineupdated = True
        End If

        updateVersion = "2017-09-29"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblreceivedreport` (  `rrnumber` varchar(10) NOT NULL,  `requestref` varchar(45) NOT NULL,  `ponumber` varchar(45) NOT NULL,  `vendorid` varchar(15) NOT NULL,  `officeid` varchar(45) NOT NULL,  `invoiceno` varchar(20) DEFAULT NULL,  `totalamount` double NOT NULL DEFAULT '0',  `directissue` tinyint(1) NOT NULL DEFAULT '0',  `issuedto` varchar(15) NOT NULL,  `issuedreference` varchar(45) NOT NULL,  `note` text,  `datereceived` datetime DEFAULT NULL,  `receivedby` varchar(45) DEFAULT NULL,  PRIMARY KEY (`rrnumber`) USING BTREE,  KEY `ponumber` (`ponumber`),  KEY `requestref` (`requestref`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblreceivedreportitem` (  `trnid` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `requestref` varchar(45) NOT NULL,  `ponumber` varchar(45) DEFAULT NULL,  `rrnumber` varchar(45) DEFAULT NULL,  `officeid` varchar(500) NOT NULL,  `vendorid` varchar(500) NOT NULL,  `productid` varchar(105) NOT NULL,  `itemname` varchar(505) NOT NULL DEFAULT '',  `catid` varchar(100) NOT NULL,  `quantity` double NOT NULL DEFAULT '0',  `unit` varchar(100) NOT NULL,  `cost` double NOT NULL DEFAULT '0',  `total` double NOT NULL DEFAULT '0',  `trnby` varchar(45) NOT NULL,  `datetrn` datetime NOT NULL,  `delivered` tinyint(1) NOT NULL DEFAULT '0',  `datedelivered` datetime DEFAULT NULL,  PRIMARY KEY (`trnid`),  KEY `requestref` (`requestref`),  KEY `ponumber` (`ponumber`),  KEY `officeid` (`officeid`),  KEY `vendorid` (`vendorid`),  KEY `productid` (`productid`),  KEY `itemname` (`itemname`),  KEY `catid` (`catid`)) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-09-30"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelratesbreakdown` ADD COLUMN `dayrate` INTEGER UNSIGNED NOT NULL DEFAULT 0 AFTER `ratecode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelroomrates` ADD COLUMN `deleted` BOOLEAN NOT NULL DEFAULT 0 AFTER `bookingno`, ADD COLUMN `deletedby` VARCHAR(45) NOT NULL DEFAULT '' AFTER `deleted`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-10-01"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD COLUMN `vip` BOOLEAN NOT NULL DEFAULT 0 AFTER `hotelclient`, ADD COLUMN `vipguestid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `vip`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblhotelfoliosummary` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `bookno` varchar(45) NOT NULL,  `arival` date NOT NULL,  `departure` date NOT NULL,  `dayno` int(10) unsigned NOT NULL,  `datetrn` date NOT NULL,  `roomid` text,  `roomno` text,  `roomtype` text,  `roomdesc` text,  `nightcharge` tinyint(1) NOT NULL DEFAULT '0',  `rateid` varchar(45) NOT NULL DEFAULT '',  `adult` int(10) unsigned NOT NULL DEFAULT '0',  `adultrate` double NOT NULL DEFAULT '0',  `child` int(10) unsigned NOT NULL DEFAULT '0',  `childrate` double NOT NULL DEFAULT '0',  `extra` int(10) unsigned NOT NULL DEFAULT '0',  `extrarate` double NOT NULL DEFAULT '0',  `total` double NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=461 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-10-02"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "DELETE FROM `tblclientdiscounts`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbluserauthority` ADD COLUMN `vip` BOOLEAN NOT NULL DEFAULT 0 AFTER `pointofsale`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalesvipguest` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `cifid` varchar(45) NOT NULL,  `guestid` varchar(45) NOT NULL,  `checkin` tinyint(1) NOT NULL DEFAULT '0',  `datein` datetime NOT NULL,  `checkout` tinyint(1) NOT NULL DEFAULT '0',  `dateout` datetime DEFAULT NULL,  `companion` int(10) unsigned NOT NULL,  `activateby` varchar(100) NOT NULL,  `deactivateby` varchar(100) DEFAULT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientaccounts` ADD COLUMN `vipactivated` BOOLEAN NOT NULL DEFAULT 0 AFTER `vipguestid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-10-03"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblinventoryledger` MODIFY COLUMN `reqoffice` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci, MODIFY COLUMN `datetrn` DATETIME DEFAULT NULL, ADD COLUMN `referenceno` VARCHAR(45) AFTER `trnby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventoryledger` ADD COLUMN `invoiceno` VARCHAR(45) AFTER `referenceno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventorylogs` ADD COLUMN `invoiceno` VARCHAR(45) AFTER `stockref`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblofficeequipment` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `officeid` varchar(45) NOT NULL,  `accountable` varchar(45) NOT NULL,  `productid` varchar(45) NOT NULL,  `productname` varchar(100) NOT NULL,  `productdetails` text,  `propertyno` varchar(45) NOT NULL,  `quantity` double NOT NULL DEFAULT '0',  `unit` varchar(45) NOT NULL,  `unitcost` double NOT NULL DEFAULT '0',  `totalcost` double NOT NULL DEFAULT '0',  `vendorid` varchar(45) NOT NULL,  `estimatedlife` varchar(100) NOT NULL,  `dateacquired` date NOT NULL,  `entryby` varchar(100) NOT NULL,  `dateentry` datetime NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-10-04"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tblreportfilter` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `filtercode` int(10) unsigned NOT NULL,  `permissioncode` int(10) unsigned NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `allowreceivedpurchases` BOOLEAN NOT NULL DEFAULT 0 AFTER `deleted`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-10-05"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblproductmenuitem` ADD COLUMN `cost` DOUBLE NOT NULL DEFAULT 0 AFTER `unit`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enablemenumakerinventory` BOOLEAN NOT NULL DEFAULT 1 AFTER `rrnumberseries`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblclientcharges` DROP COLUMN `cifid`, CHANGE COLUMN `productid` `catid` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, ADD COLUMN `enable` BOOLEAN NOT NULL DEFAULT 1 AFTER `chargesrate`, DROP INDEX `productid`, ADD INDEX `productid` USING BTREE(`catid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-10-06"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelroomtransaction` MODIFY COLUMN `remarks` TEXT CHARACTER SET utf8 COLLATE utf8_general_ci;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblsalespaymentvoucher` (  `trnid` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `trnsumcode` varchar(20) NOT NULL DEFAULT '0',  `batchcode` varchar(25) NOT NULL,  `voucherno` varchar(25) NOT NULL,  `amount` double NOT NULL DEFAULT '0',  `datetrn` datetime NOT NULL,  `trnby` varchar(15) NOT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `cancelledby` varchar(45) DEFAULT NULL,  `datecancelled` datetime DEFAULT NULL,  PRIMARY KEY (`trnid`) USING BTREE,  KEY `trnsumcode` (`trnsumcode`),  KEY `batchcode` (`batchcode`),  KEY `voucherno` (`voucherno`)) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-10-07"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `voidreason` TEXT AFTER `voidby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2017-10-08"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `attendingperson` VARCHAR(45) NOT NULL DEFAULT '' AFTER `trnby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `processed` BOOLEAN NOT NULL DEFAULT 0 AFTER `datetrn`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesbatch` ADD COLUMN `dateprocess` DATETIME AFTER `processed`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `cancelremarks` TEXT AFTER `cancelledby`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesbatch` MODIFY COLUMN `paymenttype` VARCHAR(300) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `remarks` TEXT AFTER `income`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-06-18"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelguestcompanion` ADD COLUMN `folioid` VARCHAR(45) NOT NULL AFTER `bookno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblcompoffice` set officename=ucase(officename);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompoffice` ADD COLUMN `posproductioncopy` BOOLEAN NOT NULL DEFAULT 1 AFTER `allowreceivedpurchases`, ADD COLUMN `posfoodcheckercopy` BOOLEAN NOT NULL DEFAULT 0 AFTER `posproductioncopy`, ADD COLUMN `posbutcherycopy` BOOLEAN NOT NULL DEFAULT 0 AFTER `posfoodcheckercopy`, ADD COLUMN `poscustomercopy` BOOLEAN NOT NULL DEFAULT 1 AFTER `posbutcherycopy`, ADD COLUMN `poscashiercopy` BOOLEAN NOT NULL DEFAULT 0 AFTER `poscustomercopy`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `tempdisablehotel` BOOLEAN NOT NULL DEFAULT 1 AFTER `enablemenumakerinventory`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))

            engineupdated = True
        End If

        updateVersion = "2018-06-21"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblhotelfoliotransaction` ADD COLUMN `discount` BOOLEAN NOT NULL DEFAULT 0 AFTER `offsetpayment`, ADD COLUMN `discountoveride` BOOLEAN NOT NULL DEFAULT 0 AFTER `discount`, ADD COLUMN `discountoverideby` VARCHAR(45) NOT NULL DEFAULT '' AFTER `discountoveride`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-06-22"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalessummary` DROP COLUMN `totalsolditem`, DROP COLUMN `cancelleditem`, DROP COLUMN `voiditem`, DROP COLUMN `totalcancelled`, DROP COLUMN `totalvoid`, DROP COLUMN `totaldiscount`, DROP COLUMN `totalcharge`, DROP COLUMN `totaltax`, DROP COLUMN `totalchit`, DROP COLUMN `totalchargeacct`, DROP COLUMN `totalpaymentacct`, DROP COLUMN `totalsales`, DROP COLUMN `totalcashsales`, DROP COLUMN `totalactualcash`, DROP COLUMN `cashvariance`, DROP COLUMN `totalincome`, DROP COLUMN `totalexpenses`, DROP COLUMN `totalclientjournal`, DROP COLUMN `debitaccountjournal`, DROP COLUMN `creaditaccountjournal`, DROP COLUMN `totalothertransaction`, DROP COLUMN `totalcheck`, DROP COLUMN `totalcard`, DROP COLUMN `totaldeposit`, DROP COLUMN `totalacctticket`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `cashend` DOUBLE NOT NULL DEFAULT 0 AFTER `dateopen`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalessummary` ADD COLUMN `cashonhand` DOUBLE NOT NULL DEFAULT 0 AFTER `cashend`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblsalessummary` set cashonhand=ifnull((select sum(totalamount) from tblsalescashdenomination where trnsumcode=tblsalessummary.trncode),0);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If


        updateVersion = "2018-06-24"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "DROP TABLE IF EXISTS `tblvouchersdetail`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblapprovermainprocess` set apptype='voucher-signatories' where apptype='accounts-payable-signatories';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tbldisbursementdetails` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `voucherno` varchar(45) NOT NULL,  `supplier` varchar(500) NOT NULL,  `datetrn` date NOT NULL,  `ponumber` varchar(45) NOT NULL,  `note` text,  `invoiceno` varchar(45) NOT NULL,  `amount` double NOT NULL,  `forpo` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=100 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tbldisbursementexpense` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `voucherno` varchar(45) NOT NULL,  `itemcode` varchar(45) NOT NULL,  `remarks` varchar(100) NOT NULL,  `amount` double NOT NULL,  `datetrn` date NOT NULL,  PRIMARY KEY `id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tbldisbursementvoucher` (  `voucherno` varchar(15) NOT NULL,  `voucherdate` date NOT NULL,  `itemcode` varchar(45) NOT NULL,  `companyid` varchar(45) NOT NULL,  `officeid` varchar(50) NOT NULL,  `vendorid` varchar(10) NOT NULL,  `check` tinyint(1) NOT NULL DEFAULT '0',  `cash` tinyint(1) NOT NULL DEFAULT '0',  `ca` tinyint(1) NOT NULL DEFAULT '0',  `amount` double NOT NULL DEFAULT '0',  `sourcefund` varchar(10) NOT NULL DEFAULT '',  `note` varchar(500) NOT NULL,  `corporatelevel` int(1) NOT NULL DEFAULT '0',  `datetrn` datetime NOT NULL,  `trnby` varchar(45) NOT NULL,  `hold` tinyint(1) NOT NULL DEFAULT '0',  `verified` tinyint(1) NOT NULL DEFAULT '0',  `dateverified` datetime DEFAULT NULL,  `verifiedby` varchar(45) DEFAULT NULL,  `checkno` varchar(45) DEFAULT '',  `checkdate` date DEFAULT NULL,  `checkamount` double NOT NULL DEFAULT '0',  `checkreleased` tinyint(1) NOT NULL DEFAULT '0',  `checkreceivedby` varchar(45) DEFAULT NULL,  `liquidated` tinyint(1) NOT NULL DEFAULT '0',  `clearedliquidation` tinyint(1) NOT NULL DEFAULT '0',  `amountspend` double NOT NULL DEFAULT '0',  `amountrefunded` double NOT NULL DEFAULT '0',  `amountreimbursed` double NOT NULL DEFAULT '0',  `dateliquidated` datetime DEFAULT NULL,  `cleared` tinyint(1) NOT NULL DEFAULT '0',  `datecleared` datetime DEFAULT NULL,  `clearedby` varchar(45) DEFAULT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  `datecancelled` datetime DEFAULT NULL,  `cancelledby` varchar(45) DEFAULT NULL,  `downloaded` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`voucherno`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-06-25"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblpurchaseorder` ADD COLUMN `requestby` INT(10) UNSIGNED NOT NULL DEFAULT 0 AFTER `requestref`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tblpurchaseorder` as p inner join tblrequisitions as r on p.requestref=r.pid set p.requestby=r.requestby;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgeneralsettings` ADD COLUMN `enableelectronicvoucher` BOOLEAN NOT NULL DEFAULT 0 AFTER `tempdisablehotel`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-06-26"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalestransaction` ADD COLUMN `postingdate` DATE NOT NULL AFTER `trnsumcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update tblsalestransaction as a inner join tblsalessummary as b on a.trnsumcode = b.trncode set a.postingdate=date_format(b.dateopen,'%Y-%m-%d');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblpurchaseorder` ADD COLUMN `ap` BOOLEAN NOT NULL AFTER `paymentrefnumber`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-06-27"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblprocategory` CHANGE COLUMN `glitemcode` `glitemrevenue` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci, ADD COLUMN `glitemcost` VARCHAR(45) AFTER `glitemrevenue`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblprocategory` ADD COLUMN `gliteminventory` VARCHAR(45) AFTER `glitemcost`, ADD COLUMN `glitempurchases` VARCHAR(45) AFTER `gliteminventory`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-06-28"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "update tblhotelroomrates set lockrate=0 where temporaryrate=1" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblgltransactiongroup` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `description` varchar(45) NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblgltransactionname` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `groupid` int(10) unsigned NOT NULL,  `description` varchar(100) NOT NULL,  `sp_command` varchar(100) NOT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=118 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblgltransactionsourcetable` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `tablename` varchar(100) NOT NULL,  `tabledesc` varchar(100) NOT NULL,  `itemcode` varchar(100) NOT NULL,  `itemdetails` varchar(100) NOT NULL, `desccode` varchar(100) NOT NULL,  `descdetails` varchar(100) NOT NULL,  `parameter` text,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1000 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE  `tblgltransactiontagging` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `groupid` int(10) unsigned NOT NULL,  `itemid` int(10) unsigned NOT NULL,  `sourceid` int(11) DEFAULT NULL,  `referenceno` varchar(100) NOT NULL,  `description` varchar(500) NOT NULL,  `debitcode` varchar(45) NOT NULL DEFAULT '',  `creditcode` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1000 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-06-28"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE  `filedir`.`tblimagerepository` (  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,  `tablename` varchar(25) NOT NULL,  `referenceno` varchar(25) NOT NULL,  `imgdata` longblob,  PRIMARY KEY (`id`),  KEY `tablename` (`tablename`),  KEY `referenceno` (`referenceno`)) ENGINE=MyISAM AUTO_INCREMENT=83 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblreceivedreport` MODIFY COLUMN `datereceived` DATE DEFAULT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblprocategory` ADD COLUMN `details` TEXT AFTER `description`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblprosubcategory` ADD COLUMN `details` TEXT AFTER `description`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-06-29"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglitem` ADD COLUMN `debit` BOOLEAN NOT NULL DEFAULT 0 AFTER `level`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgltransactiontagging` ADD COLUMN `companyid` VARCHAR(45) NOT NULL AFTER `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglitem` ADD COLUMN `companyid` VARCHAR(45) NOT NULL AFTER `groupcode`, DROP PRIMARY KEY, ADD PRIMARY KEY  USING BTREE(`itemcode`, `companyid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglgroup` DROP COLUMN `child`, CHANGE COLUMN `parent` `normalbalance` VARCHAR(105) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglgroup` ADD COLUMN `companyid` VARCHAR(45) NOT NULL first, DROP PRIMARY KEY, ADD PRIMARY KEY  USING BTREE(`groupcode`, `companyid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            'com.CommandText = "delete FROM `tblglgroup`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            ' com.CommandText = "delete FROM `tblglitem`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbltransactioncode` DROP COLUMN `gldebit`, DROP COLUMN `glcredit`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tbltransactioncodefilter` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `permissioncode` varchar(45) NOT NULL DEFAULT '',  `itemcode` varchar(45) NOT NULL DEFAULT '',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1021 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglaccountfilter` ADD COLUMN `companyid` VARCHAR(45) NOT NULL AFTER `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-06-30"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblbankaccounts` ADD COLUMN `gltoken` VARCHAR(45) NOT NULL DEFAULT 'bankaccount' AFTER `onlinetransaction`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblhotelpackageitem` CHANGE COLUMN `glitemcode` `gltoken` VARCHAR(45) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL DEFAULT 'hotelpackage';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblhotelpackageitem` set gltoken='hotelpackage';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgltransactiontagging` ADD COLUMN `debitaccounttag` BOOLEAN NOT NULL DEFAULT 0 AFTER `description`, ADD COLUMN `creditaccounttag` BOOLEAN NOT NULL DEFAULT 0 AFTER `debitcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglsettings` ADD COLUMN `accountspayable` VARCHAR(45) NOT NULL AFTER `salescode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesmenumakerstockout` ADD COLUMN `catid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `stockno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesmenumakerstockout` ADD COLUMN `postingdate` DATE NOT NULL AFTER `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesmenumakerstockout` ADD INDEX `refnumber`(`refnumber`), ADD INDEX `officeid`(`officeid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblsalesmenumakerstockout` ADD COLUMN `batchcode` VARCHAR(45) NOT NULL AFTER `postingdate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblsalesmenumakerstockout` as a inner join tblsalestransaction as b on a.refnumber = b.menumakerstockref set a.postingdate=b.postingdate,a.batchcode=b.batchcode;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgltaggingaccountdetails` ADD COLUMN `itemcode` VARCHAR(45) NOT NULL AFTER `description`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgltaggingaccountdetails` ADD COLUMN `companyid` VARCHAR(45) NOT NULL AFTER `description`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-01"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompoffice` MODIFY COLUMN `shortname` VARCHAR(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblcompoffice` set shortname=officename;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-02"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tbldisbursementdetails` ADD COLUMN `vendorid` VARCHAR(45) NOT NULL AFTER `voucherno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE `tbldisbursementdetails` as a inner join tblpurchaseorder as b on a.voucherno=b.paymentrefnumber set a.vendorid=b.vendorid ;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE tbltaxtable` (  `taxcode` int(10) unsigned NOT NULL AUTO_INCREMENT,  `taxname` varchar(45) NOT NULL,  `Description` varchar(105) NOT NULL,  `sales` tinyint(1) NOT NULL,  `purchases` tinyint(1) NOT NULL,  `taxrate` double NOT NULL,  `gltagging` varchar(45) NOT NULL,  `inclusive` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`taxcode`)) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementdetails` ADD COLUMN `taxcode` VARCHAR() NOT NULL DEFAULT '' AFTER `invoiceno`, ADD COLUMN `tax` DOUBLE NOT NULL DEFAULT 0 AFTER `taxcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblprocategory` ADD COLUMN `details` VARCHAR(100) NOT NULL DEFAULT '' AFTER `description`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE  `tbldisbursementexpense` ADD COLUMN `companyid` VARCHAR(45) NOT NULL AFTER `voucherno`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "UPDATE tbldisbursementexpense as a inner join tbldisbursementvoucher as b on a.voucherno=b.voucherno set a.companyid=b.companyid;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblgljournal`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tbldisbursementvoucher` ADD COLUMN `directexpense` BOOLEAN NOT NULL DEFAULT 0 AFTER `voucherdate`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))

            com.CommandText = "DROP TABLE IF EXISTS `tblaccountdue`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tbladjrequest`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblbillsandpayables`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblclearingcheck`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblclearingcreditcard`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblclientaccountsbackup`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblemployeepic`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "DROP TABLE IF EXISTS `tblglsettings_old`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-03"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglticket` ADD COLUMN `journal` BOOLEAN NOT NULL DEFAULT 0 AFTER `systemgenerated`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglticket` MODIFY COLUMN `datetrn` DATETIME NOT NULL DEFAULT '0000-00-00 00:00:00';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblgljournalentries` MODIFY COLUMN `datetrn` DATETIME NOT NULL DEFAULT '0000-00-00 00:00:00';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE`tblglitemtag` (  `id` INTEGER UNSIGNED NOT NULL AUTO_INCREMENT, `companyid` VARCHAR(45) NOT NULL,  `itemcode` VARCHAR(45) NOT NULL,  `retainedearning` BOOLEAN NOT NULL DEFAULT 0,  PRIMARY KEY (`id`))ENGINE = InnoDB;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-04"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblglitem` MODIFY COLUMN `groupcode` VARCHAR(8) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL, MODIFY COLUMN `companyid` VARCHAR(5) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL first;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglitem` DROP PRIMARY KEY, ADD PRIMARY KEY  USING BTREE(`itemcode`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblbankaccounts` MODIFY COLUMN `glitemtag` VARCHAR(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-05"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblsalesmenumakerstockout` ADD COLUMN `trnsumcode` VARCHAR(45) NOT NULL DEFAULT '' AFTER `id`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblsalesmenumakerstockout` as a inner join tblsalestransaction as b on a.refnumber = b.menumakerstockref set a.trnsumcode=b.trnsumcode;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-06"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "CREATE TABLE `tbldepedics` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `template` varchar(45) NOT NULL,  `yeartrn` varchar(45) NOT NULL,  `seriesno` varchar(45) NOT NULL,  `controlno` varchar(45) NOT NULL,  `dateissue` date NOT NULL,  `cancelled` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-08"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblofficeequipment` ADD COLUMN `yeartrn` VARCHAR(4) NOT NULL DEFAULT '' AFTER `officeid`, ADD COLUMN `seriesno` INTEGER UNSIGNED NOT NULL DEFAULT 0 AFTER `yeartrn`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblofficeequipment` set yeartrn=date_format(dateentry,'%Y');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblofficeequipment` set seriesno=id;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblofficeequipment` set propertyno=concat(date_format(dateentry,'%Y%m%d'),'-',if(length(seriesno)=1,concat('00',seriesno),if(length(seriesno)=2,concat('0',seriesno),seriesno)));" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblofficeequipmentpullout` (  `trncode` varchar(50) NOT NULL,  `yeartrn` varchar(50) NOT NULL,  `seriesno` varchar(10) NOT NULL,  `borrower` varchar(45) NOT NULL,  `dateborrowed` date NOT NULL,  `timeborrowed` time NOT NULL,  `datereturned` date DEFAULT NULL,  `timereturned` time DEFAULT NULL,  `returned` tinyint(1) NOT NULL DEFAULT '0',  `receivedby` varchar(45) DEFAULT NULL,  `trnby` varchar(45) NOT NULL,  `datetrn` datetime NOT NULL,  PRIMARY KEY (`trncode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblofficeequipmentpulloutitem` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `trnid` varchar(45) NOT NULL,  `trncode` varchar(45) NOT NULL,  `productid` varchar(45) NOT NULL,  `qty` double NOT NULL,  `unit` varchar(45) NOT NULL,  `itemname` text NOT NULL,  `reason` text,  `remarks` text,  `returned` tinyint(1) NOT NULL DEFAULT '0',  `datereturned` datetime DEFAULT NULL,  `receivedby` varchar(45) DEFAULT NULL,  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If
        updateVersion = "2018-07-09"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblofficeequipmentpulloutitem` ADD INDEX `trnid`(`trnid`);" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-10"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblcompoffice` MODIFY COLUMN `initialcode` VARCHAR(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblcompanysettings` ADD COLUMN `logourl` TEXT AFTER `logo`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventory` ADD COLUMN `subcatid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `categoryname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblinventory` ADD COLUMN `subcatname` VARCHAR(250) NOT NULL DEFAULT '' AFTER `subcatid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-11"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblofficeequipmentpulloutitem` ADD COLUMN `originoffice` VARCHAR(50) NOT NULL DEFAULT '' AFTER `trnid`, ADD COLUMN `borroweroffice` VARCHAR(50) NOT NULL DEFAULT '' AFTER `originoffice`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblofficeequipmentpulloutitem` set originoffice=ifnull((select officeid from tblofficeequipment where id=tblofficeequipmentpulloutitem.trnid),''),borroweroffice=ifnull((select a.officeid from tblaccounts as a inner join tblofficeequipmentpullout as b on a.accountid=b.borrower where b.trncode =tblofficeequipmentpulloutitem.trncode),'');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-12"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblofficeequipment` ADD COLUMN `catid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `accountable`, ADD COLUMN `subcatid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `catid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-13"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblofficeequipment` ADD COLUMN `sequenceno` INTEGER UNSIGNED NOT NULL AFTER `subcatid`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblofficeequipment` ADD COLUMN `unitstatus` VARCHAR(45) NOT NULL DEFAULT '' AFTER `totalcost`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblglobalproducts` ADD COLUMN `codename` VARCHAR(45) NOT NULL DEFAULT '' AFTER `itemname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblofficeequipment` ADD COLUMN `codename` VARCHAR(45) NOT NULL DEFAULT '' AFTER `productname`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-14"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblofficeequipment` ADD COLUMN `modelid` VARCHAR(45) NOT NULL DEFAULT '' AFTER `productname`, ADD COLUMN `serialnumber` VARCHAR(100) NOT NULL AFTER `modelid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "CREATE TABLE `tblofficeequipmentmodel` (  `code` int(10) unsigned NOT NULL AUTO_INCREMENT,  `description` varchar(45) NOT NULL,  `productid` varchar(45) NOT NULL,  PRIMARY KEY (`code`)) ENGINE=InnoDB AUTO_INCREMENT=10000 DEFAULT CHARSET=latin1;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-16"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "update `tblinventory` as i inner join tblglobalproducts as a on i.productid=a.productid set i.subcatid=a.subcatid, i.subcatname=ifnull((select description from tblprosubcategory where subcatid=a.subcatid),'');" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-20"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblprocategory` ADD COLUMN `sequence` INTEGER UNSIGNED NOT NULL DEFAULT 0 ;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-21"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblofficeequipment` MODIFY COLUMN `sequenceno` VARCHAR(10) NOT NULL DEFAULT '';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblofficeequipment` set sequenceno='' where sequenceno='0';" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If

        updateVersion = "2018-07-22"
        If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
            com.CommandText = "ALTER TABLE `tblstockoutbatch` ADD COLUMN `stockoutno` VARCHAR(45) NOT NULL AFTER `batchcode`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "update `tblstockoutbatch`set stockoutno=batchcode;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            com.CommandText = "ALTER TABLE `tblofficeequipment` ADD COLUMN `issuereference` VARCHAR(45) NOT NULL DEFAULT '' AFTER `officeid`, ROW_FORMAT = DYNAMIC;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
            engineupdated = True
        End If


        If engineupdated = True Then
            Dim dversion As Date = updateVersion
            SendSystemUpdateNotification(Format(dversion.ToString("yy.M.d")), updateDescription)
            XtraMessageBox.Show("Your database engine was updated to Build Version " & dversion.ToString & Environment.NewLine & "Please view update list at ""Main System Menu"" > About > What's New! ", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            engineupdated = False
        End If
    End Sub

    Public Function DatabaseUpdateLogs(ByVal nVersions As String, ByVal strQuery As String)
        com.CommandText = "insert into tbldatabaseupdatelogs set databaseversion='" & nVersions & "',dateupdate=current_timestamp,appliedquery='" & strQuery & "'" : com.ExecuteNonQuery()
        Return 0
    End Function

    Public Sub UpdateDatabaseFunction()
        com.CommandText = "CREATE DATABASE IF NOT EXISTS coffeecup_reports" : com.ExecuteNonQuery()
    End Sub

End Module
