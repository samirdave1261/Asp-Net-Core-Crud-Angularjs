
/******Script for Create Table ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Core_insert](
	[RID] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [varchar](255) NULL,
	[Lname] [varchar](255) NULL,
	[Email] [varchar](60) NULL,
	[mobile] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


