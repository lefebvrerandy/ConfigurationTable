USE [Fog_Light_Kanban]
GO

/** Object:  Table [dbo].[Configuration_Table]    Script Date: 3/27/2019 4:57:59 PM **/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE IF EXISTS [dbo].[Configuration_Table];
Go

CREATE TABLE [dbo].[Configuration_Table](
    [Key] [nchar](25) NOT NULL,
    [Value] [nchar](25) NOT NULL
) ON [PRIMARY]
GO
GO
DELETE FROM [dbo].[Configuration_Table] /* Delete tables before inserting new data */
GO
INSERT INTO [dbo].[Configuration_Table]
           ([Key],[Value])
     VALUES
           ('TimeScale','1'),				/* Time scale is x1 */
		   ('RefillRate', '5'),				/* Refille rate is 5 minutes */
		   ('RookieDefectRate','0.0085'),	/* Rookie has a 0.85% chance to produce a defective product */
		   ('RookieBuildRate','0.50'),		/* Rookie will take 50% longer to build a product*/
		   ('NormalDefectRate','0.0050'),	/* Normal has a 0.5% chance to produce a defective product */
		   ('NormalBuildRate','1'),			/* Normal will build a product at normal rate*/
		   ('SuperDefectRate','0.0015'),	/* Super has a 0.15% chance to produce a defective product */
		   ('SuperBuildRate','1.15'),		/* Super will build a product 15% quicker than normal */
		   ('BinHarness','55'), /* Default rate for Harness */
		   ('BinReflector','35'), /* Default rate for Reflector */
		   ('BinHousing','24'), /* Default rate for Housing */
		   ('BinLens','40'), /* Default rate for Lens */
		   ('BinBulb','60'), /* Default rate for Bulb */
		   ('BinBezel','75') /* Default rate for Bezel */
GO