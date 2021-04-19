USE [JwelryStore]
GO

/****** Object:  Table [dbo].[Estimations]    Script Date: 19-04-2021 19:00:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Estimations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GoldPricePerGram] [decimal](18, 2) NOT NULL,
	[GoldWeightInGram] [decimal](18, 2) NOT NULL,
	[TotalPrice] [decimal](18, 2) NOT NULL,
	[DiscountPercentage] [decimal](18, 2) NOT NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_Estimation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Estimations]  WITH CHECK ADD  CONSTRAINT [FK_Users_Id_Estimation_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO

ALTER TABLE [dbo].[Estimations] CHECK CONSTRAINT [FK_Users_Id_Estimation_UserId]
GO


