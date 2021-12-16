﻿BEGIN TRANSACTION

CREATE TABLE [Online].[Gender] (
	[GenderId] UNIQUEIDENTIFIER NOT NULL DEFAULT (NEWSEQUENTIALID()) PRIMARY KEY,
	[Code] NVARCHAR (50) NOT NULL UNIQUE,
	[Text] NVARCHAR (250) NULL,
	[IsActive] BIT NULL,
	[SortOrder] INT NULL,
	[RowVersion] TIMESTAMP NOT NULL,
	[CreatedBy] NVARCHAR(250) NULL,
	[CreatedDate] DATETIME2 NULL,
	[UpdatedBy] NVARCHAR(250) NULL,
	[UpdatedDate] DATETIME2 NULL
);
	
COMMIT TRANSACTION