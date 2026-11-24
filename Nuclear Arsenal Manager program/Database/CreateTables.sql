IF DB_ID('SARMS') IS NULL
BEGIN
    CREATE DATABASE SARMS;
END
GO

USE SARMS;
GO

CREATE TABLE SITES
(
    SiteID INT IDENTITY(1,1) PRIMARY KEY,
    SiteName NVARCHAR(100) NOT NULL,
    Region NVARCHAR(100),
    Capacity INT,
    SecurityLevel INT
);

CREATE TABLE STAFF
(
    StaffID INT IDENTITY(1,1) PRIMARY KEY,
    UserID VARCHAR(50) UNIQUE NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    Clearance VARCHAR(20) NOT NULL,
    SecurityQuestion VARCHAR(50) NOT NULL,
    SiteID INT,

    CONSTRAINT FK_Staff_Site
        FOREIGN KEY (SiteID)
        REFERENCES SITES(SiteID)
);

CREATE TABLE ASSETS -- The nukes
(
    AssetID INT IDENTITY(1,1) PRIMARY KEY,
    SerialNumber NVARCHAR(50) UNIQUE NOT NULL,
    AssetName NVARCHAR(100),
    Category NVARCHAR(50),
    Status NVARCHAR(50),
    CurrentSiteID INT,

    CONSTRAINT FK_Asset_Site
        FOREIGN KEY (CurrentSiteID)
        REFERENCES SITES(SiteID)
);

CREATE TABLE REQUESTS
(
    RequestID INT IDENTITY(1,1) PRIMARY KEY,
    StaffID INT NOT NULL,
    RequestText VARCHAR(MAX) NOT NULL,
    Status VARCHAR(20) DEFAULT 'Pending',
    DateSubmitted DATETIME DEFAULT GETDATE(),
    DateReviewed DATETIME NULL,

    CONSTRAINT FK_Request_Staff
        FOREIGN KEY (StaffID)
        REFERENCES STAFF(StaffID)
);

CREATE TABLE TRANSFERS
(
    TransferID INT IDENTITY(1,1) PRIMARY KEY,
    AssetID INT NOT NULL,
    FromSiteID INT NOT NULL,
    ToSiteID INT NOT NULL,
    RequesterID INT NOT NULL,
    ApproverID INT NULL,
    TransferStatus VARCHAR(20) DEFAULT 'Pending',
    RequestDate DATETIME DEFAULT GETDATE(),
    ApprovalDate DATETIME NULL,
    TransferDate DATETIME NULL,

    CONSTRAINT FK_Transfer_Asset
        FOREIGN KEY (AssetID)
        REFERENCES ASSETS(AssetID),

    CONSTRAINT FK_Transfer_FromSite
        FOREIGN KEY (FromSiteID)
        REFERENCES SITES(SiteID),

    CONSTRAINT FK_Transfer_ToSite
        FOREIGN KEY (ToSiteID)
        REFERENCES SITES(SiteID),

    CONSTRAINT FK_Transfer_Requester
        FOREIGN KEY (RequesterID)
        REFERENCES STAFF(StaffID),

    CONSTRAINT FK_Transfer_Approver
        FOREIGN KEY (ApproverID)
        REFERENCES STAFF(StaffID)
);

CREATE TABLE AUDITLOG
(
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    StaffID INT NOT NULL,
    ActionTaken VARCHAR(100) NOT NULL,
    TableAffected VARCHAR(50) NOT NULL,
    ActionTimestamp DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_AuditLog_Staff
        FOREIGN KEY (StaffID)
        REFERENCES STAFF(StaffID)
);