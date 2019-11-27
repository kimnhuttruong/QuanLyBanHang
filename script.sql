USE [master]
GO
/****** Object:  Database [UDQL1_DA]    Script Date: 11/25/2019 8:27:29 PM ******/
CREATE DATABASE [UDQL1_DA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UDQL1_DA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\UDQL1_DA.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UDQL1_DA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\UDQL1_DA_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [UDQL1_DA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UDQL1_DA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UDQL1_DA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UDQL1_DA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UDQL1_DA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UDQL1_DA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UDQL1_DA] SET ARITHABORT OFF 
GO
ALTER DATABASE [UDQL1_DA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [UDQL1_DA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UDQL1_DA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UDQL1_DA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UDQL1_DA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UDQL1_DA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UDQL1_DA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UDQL1_DA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UDQL1_DA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UDQL1_DA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [UDQL1_DA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UDQL1_DA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UDQL1_DA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UDQL1_DA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UDQL1_DA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UDQL1_DA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UDQL1_DA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UDQL1_DA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UDQL1_DA] SET  MULTI_USER 
GO
ALTER DATABASE [UDQL1_DA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UDQL1_DA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UDQL1_DA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UDQL1_DA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [UDQL1_DA] SET DELAYED_DURABILITY = DISABLED 
GO
USE [UDQL1_DA]
GO
/****** Object:  Table [dbo].[ADJUSTMENT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ADJUSTMENT](
	[ID] [varchar](20) NOT NULL,
	[RefDate] [datetime] NULL,
	[Ref_OrgNo] [nvarchar](20) NULL,
	[RefType] [int] NULL,
	[Employee_ID] [varchar](20) NULL,
	[Stock_ID] [varchar](20) NULL,
	[Amount] [money] NULL,
	[Accept] [bit] NULL,
	[IsClose] [bit] NULL,
	[Description] [nvarchar](255) NULL,
	[User_ID] [varchar](20) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_ADJUSTMENT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ADJUSTMENT_DETAIL]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ADJUSTMENT_DETAIL](
	[ID] [uniqueidentifier] NOT NULL,
	[Adjustment_ID] [varchar](20) NULL,
	[Product_ID] [varchar](20) NULL,
	[Product_Name] [nvarchar](255) NULL,
	[Stock_ID] [varchar](20) NULL,
	[Unit] [nvarchar](20) NULL,
	[UnitConvert] [money] NULL,
	[Width] [money] NULL,
	[Height] [money] NULL,
	[Orgin] [nvarchar](255) NULL,
	[CurrentQty] [money] NULL,
	[NewQty] [money] NULL,
	[QtyDiff] [money] NULL,
	[UnitPrice] [money] NULL,
	[Amount] [money] NULL,
	[QtyConvert] [money] NULL,
	[StoreID] [bigint] NULL,
	[Batch] [varchar](50) NULL,
	[Serial] [varchar](50) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
 CONSTRAINT [PK_ADJUSTMENT_DETAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BOOK]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOOK](
	[ID] [nvarchar](20) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Created] [datetime] NULL,
	[Closed] [datetime] NULL,
	[IsMain] [bit] NULL,
	[IsClose] [bit] NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_BOOK] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CASH]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CASH](
	[ID] [uniqueidentifier] NOT NULL,
	[RefDate] [datetime] NULL,
	[RefOrgNo] [nvarchar](20) NULL,
	[RefType] [smallint] NULL,
	[RefStatus] [smallint] NULL,
	[CashID] [uniqueidentifier] NULL,
	[BookID] [nvarchar](20) NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[BAmount] [money] NULL,
	[FAmount] [money] NULL,
	[AAmount] [money] NULL,
	[DAmount] [money] NULL,
	[EAmount] [money] NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CASH] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CASH_ITEM]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CASH_ITEM](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](20) NULL,
	[Name] [nvarchar](255) NULL,
	[NameEN] [nvarchar](255) NULL,
	[RefType] [smallint] NULL,
	[CategoryID] [nvarchar](20) NULL,
	[ParentID] [uniqueidentifier] NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CASH_ITEM] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CASH_ITEM_CLASS]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CASH_ITEM_CLASS](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](20) NULL,
	[Name] [nvarchar](255) NULL,
	[NameEN] [nvarchar](255) NULL,
	[RefType] [smallint] NULL,
	[ObjectType] [smallint] NULL,
	[Credit] [uniqueidentifier] NULL,
	[Debit] [uniqueidentifier] NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[ParentID] [uniqueidentifier] NULL,
	[IsSystem] [bit] NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CASH_ITEM_CLASS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CASH_METHOD]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CASH_METHOD](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](20) NULL,
	[Name] [nvarchar](255) NULL,
	[NameEN] [nvarchar](255) NULL,
	[TypeID] [smallint] NULL,
	[IsSystem] [bit] NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CASH_METHOD] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CASH_PAYMEN]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CASH_PAYMEN](
	[ID] [nvarchar](20) NOT NULL,
	[RefID] [nvarchar](20) NULL,
	[RefDate] [datetime] NULL,
	[RefNo] [nvarchar](20) NULL,
	[RefOrgNo] [nvarchar](20) NULL,
	[RefType] [smallint] NULL,
	[RefStatus] [smallint] NULL,
	[PaymentMethod] [uniqueidentifier] NULL,
	[ClassID] [nvarchar](20) NULL,
	[Reason] [nvarchar](255) NULL,
	[BranchID] [nvarchar](20) NULL,
	[ContractID] [nvarchar](20) NULL,
	[CustomerID] [nvarchar](20) NULL,
	[CustomerName] [nvarchar](255) NULL,
	[CustomerAddress] [nvarchar](255) NULL,
	[CustomerTax] [nvarchar](20) NULL,
	[ContactName] [nvarchar](100) NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[Amount] [money] NULL,
	[Discount] [money] NULL,
	[FAmount] [money] NULL,
	[FDiscount] [money] NULL,
	[IsReceived] [bit] NULL,
	[IsClosed] [bit] NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CASH_PAYMENT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CASH_RECEIPT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CASH_RECEIPT](
	[ID] [uniqueidentifier] NOT NULL,
	[RefID] [nvarchar](20) NULL,
	[RefDate] [datetime] NULL,
	[RefNo] [nvarchar](20) NULL,
	[RefOrgNo] [nvarchar](20) NULL,
	[RefType] [smallint] NULL,
	[RefStatus] [smallint] NULL,
	[PaymentMethod] [uniqueidentifier] NULL,
	[ClassID] [nvarchar](20) NULL,
	[Reason] [nvarchar](255) NULL,
	[BranchID] [nvarchar](20) NULL,
	[ContractID] [nvarchar](20) NULL,
	[CustomerID] [nvarchar](20) NULL,
	[CustomerName] [nvarchar](255) NULL,
	[CustomerAddress] [nvarchar](255) NULL,
	[CustomerTax] [nvarchar](20) NULL,
	[ContactName] [nvarchar](100) NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[Amount] [money] NULL,
	[Discount] [money] NULL,
	[FAmount] [money] NULL,
	[FDiscount] [money] NULL,
	[IsReceived] [bit] NULL,
	[IsClosed] [bit] NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CASH_RECEIPT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CASH_TERM]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CASH_TERM](
	[ID] [nvarchar](20) NOT NULL,
	[Code] [nvarchar](20) NULL,
	[Name] [nvarchar](255) NULL,
	[NameEN] [nvarchar](255) NULL,
	[TypeID] [smallint] NULL,
	[DueTime] [int] NULL,
	[DiscountTime] [int] NULL,
	[DiscountPercent] [money] NULL,
	[DelayWithin] [int] NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CASH_TERM] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CITY]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CITY](
	[Province_ID] [varchar](20) NOT NULL,
	[Province_Name] [nvarchar](255) NULL,
	[ACN] [varchar](5) NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CITY] PRIMARY KEY CLUSTERED 
(
	[Province_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CODE]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CODE](
	[Soft_Id] [varchar](20) NOT NULL,
	[Soft_Name] [nvarchar](255) NULL,
	[Version] [varchar](20) NULL,
	[Type] [int] NULL,
	[Contact] [nvarchar](255) NULL,
	[CompanyName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Tel] [varchar](20) NULL,
	[Mobile] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
	[Email] [varchar](20) NULL,
	[Website] [nvarchar](255) NULL,
	[Language] [varchar](20) NULL,
	[Created] [datetime] NULL,
	[Limit] [datetime] NULL,
	[Day] [int] NULL,
	[License] [int] NULL,
	[Code] [nvarchar](100) NULL,
	[Number] [int] NULL,
	[Command] [int] NULL,
	[Today] [datetime] NULL,
	[Active] [nvarchar](100) NULL,
	[ComputerCode] [nvarchar](100) NULL,
 CONSTRAINT [PK_CODE] PRIMARY KEY CLUSTERED 
(
	[Soft_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COMPANY]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COMPANY](
	[CompanyID] [varchar](50) NOT NULL,
	[CompamyName] [nvarchar](255) NULL,
	[CompanyAddress] [nvarchar](255) NULL,
	[CompanyTax] [varchar](50) NULL,
	[Tel] [varchar](30) NULL,
	[Fax] [varchar](50) NULL,
	[WebSite] [varchar](30) NULL,
	[Email] [varchar](30) NULL,
	[Logo] [image] NULL,
 CONSTRAINT [PK_COMPANY] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CURRENCY]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CURRENCY](
	[Currency_ID] [varchar](3) NOT NULL,
	[CurrencyName] [nvarchar](50) NULL,
	[Exchange] [money] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CURRENCY] PRIMARY KEY CLUSTERED 
(
	[Currency_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[Customer_ID] [varchar](20) NOT NULL,
	[OrderID] [bigint] NULL,
	[CustomerName] [nvarchar](255) NULL,
	[Customer_Type_ID] [varchar](20) NULL,
	[Customer_Group_ID] [varchar](20) NULL,
	[CustomerAddress] [nvarchar](255) NULL,
	[Birthday] [varchar](10) NULL,
	[Barcode] [varchar](20) NULL,
	[Tax] [varchar](20) NULL,
	[Tel] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[Mobile] [varchar](20) NULL,
	[Website] [varchar](100) NULL,
	[Contact] [nvarchar](100) NULL,
	[Position] [nvarchar](100) NULL,
	[NickYM] [nvarchar](20) NULL,
	[NickSky] [nvarchar](20) NULL,
	[Area] [nvarchar](100) NULL,
	[District] [nvarchar](100) NULL,
	[Contry] [nvarchar](100) NULL,
	[City] [nvarchar](100) NULL,
	[BankAccount] [varchar](20) NULL,
	[BankName] [nvarchar](100) NULL,
	[CreditLimit] [money] NULL,
	[Discount] [money] NULL,
	[IsDebt] [bit] NULL,
	[IsDebtDetail] [bit] NULL,
	[IsProvider] [bit] NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUSTOMER_DEBT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER_DEBT](
	[ID] [uniqueidentifier] NOT NULL,
	[RefID] [nvarchar](20) NULL,
	[RefDate] [datetime] NULL,
	[RefOrgNo] [nvarchar](20) NULL,
	[RefType] [smallint] NULL,
	[RefStatus] [smallint] NULL,
	[PaymentMethod] [uniqueidentifier] NULL,
	[CustomerID] [nvarchar](20) NULL,
	[ProductID] [nvarchar](20) NULL,
	[ProductName] [nvarchar](255) NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[TermID] [nvarchar](20) NULL,
	[DueDate] [datetime] NULL,
	[Quantity] [money] NULL,
	[ReQuantity] [money] NULL,
	[Amount] [money] NULL,
	[Discount] [money] NULL,
	[Payment] [money] NULL,
	[Balance] [money] NULL,
	[FAmount] [money] NULL,
	[FPayment] [money] NULL,
	[FBalance] [money] NULL,
	[FDiscount] [money] NULL,
	[IsChanged] [bit] NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CUSTOMER_DEBT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CUSTOMER_GROUP]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOMER_GROUP](
	[Customer_Group_ID] [varchar](20) NOT NULL,
	[Customer_Group_Name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CUSTOMER_GROUP] PRIMARY KEY CLUSTERED 
(
	[Customer_Group_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUSTOMER_RECEIPT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER_RECEIPT](
	[ID] [uniqueidentifier] NOT NULL,
	[RefID] [nvarchar](20) NULL,
	[RefDate] [datetime] NULL,
	[RefOrgNo] [nvarchar](20) NULL,
	[RefType] [smallint] NULL,
	[RefStatus] [smallint] NULL,
	[PaymentMethod] [uniqueidentifier] NULL,
	[Barcode] [nvarchar](20) NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[BranchID] [nvarchar](20) NULL,
	[ContractID] [nvarchar](20) NULL,
	[CustomerID] [nvarchar](20) NULL,
	[CustomerName] [nvarchar](255) NULL,
	[CustomerAddress] [nvarchar](255) NULL,
	[CustomerTax] [nvarchar](20) NULL,
	[ContactName] [nvarchar](100) NULL,
	[Amount] [money] NULL,
	[FAmount] [money] NULL,
	[Discount] [money] NULL,
	[FDiscount] [money] NULL,
	[Reconciled] [bit] NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CUSTOMER_RECEIPT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CUSTOMER_RECEIPT_DETAIL]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER_RECEIPT_DETAIL](
	[ID] [uniqueidentifier] NOT NULL,
	[ReceiptID] [uniqueidentifier] NULL,
	[RefOrgNo] [uniqueidentifier] NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[Quantity] [money] NULL,
	[Amount] [money] NULL,
	[Debit] [money] NULL,
	[Payment] [money] NULL,
	[DiscountPercent] [money] NULL,
	[Discount] [money] NULL,
	[FDebit] [money] NULL,
	[FAmount] [money] NULL,
	[FDiscount] [money] NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
 CONSTRAINT [PK_CUSTOMER_RECEIPT_DETAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CUSTOMER_TYPE]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUSTOMER_TYPE](
	[Customer_Type_ID] [varchar](20) NOT NULL,
	[Customer_Type_Name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CUSTOMER_TYPE] PRIMARY KEY CLUSTERED 
(
	[Customer_Type_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DEBT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEBT](
	[ID] [uniqueidentifier] NOT NULL,
	[RefID] [nvarchar](20) NULL,
	[RefDate] [datetime] NULL,
	[RefOrgNo] [uniqueidentifier] NULL,
	[RefType] [smallint] NULL,
	[RefStatus] [smallint] NULL,
	[PaymentMethod] [uniqueidentifier] NULL,
	[CustomerID] [nvarchar](20) NULL,
	[ProductID] [nvarchar](20) NULL,
	[ProductName] [nvarchar](255) NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[TermID] [nvarchar](20) NULL,
	[DueDate] [datetime] NULL,
	[Quantity] [money] NULL,
	[ReQuantity] [money] NULL,
	[Price] [money] NULL,
	[Amount] [money] NULL,
	[Payment] [money] NULL,
	[Balance] [money] NULL,
	[FAmount] [money] NULL,
	[IsChanged] [bit] NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_DEBT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DEPARTMENT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DEPARTMENT](
	[Department_ID] [varchar](20) NOT NULL,
	[Department_Name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_DEPARTMENTT] PRIMARY KEY CLUSTERED 
(
	[Department_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMPLOYEE](
	[Employee_ID] [varchar](20) NOT NULL,
	[FirtName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Employee_Name] [nvarchar](100) NULL,
	[Alias] [nvarchar](100) NULL,
	[Sex] [bit] NULL,
	[Address] [nvarchar](255) NULL,
	[Country_ID] [varchar](20) NULL,
	[H_Tel] [varchar](20) NULL,
	[O_Tel] [varchar](20) NULL,
	[Mobile] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
	[Email] [nvarchar](255) NULL,
	[Birthday] [datetime] NULL,
	[Married] [int] NULL,
	[Position_ID] [varchar](20) NULL,
	[JobTitle_ID] [varchar](20) NULL,
	[Branch_ID] [varchar](20) NULL,
	[Department_ID] [varchar](20) NULL,
	[Team_ID] [varchar](20) NULL,
	[PersonalTax_ID] [varchar](50) NULL,
	[City_ID] [varchar](20) NULL,
	[District_ID] [varchar](20) NULL,
	[Manager_ID] [varchar](20) NULL,
	[EmployeeType] [int] NULL,
	[BasicSalary] [money] NULL,
	[Advance] [money] NULL,
	[AdvanceOther] [money] NULL,
	[Commission] [money] NULL,
	[Discount] [money] NULL,
	[ProfitRate] [money] NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_EMPLOYEE] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FORM]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FORM](
	[Form_Id] [nvarchar](50) NOT NULL,
	[Form_Caption] [nvarchar](255) NULL,
	[ENCaption] [nvarchar](250) NULL,
	[Width] [int] NULL,
	[Height] [int] NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_FORM] PRIMARY KEY CLUSTERED 
(
	[Form_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[INVENTORY]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INVENTORY](
	[ID] [bigint] NOT NULL,
	[RefID] [varchar](20) NULL,
	[RefDate] [datetime] NULL,
	[RefType] [int] NULL,
	[Stock_ID] [varchar](20) NULL,
	[Product_ID] [varchar](20) NULL,
	[Customer_ID] [varchar](20) NULL,
	[Currency_ID] [varchar](3) NULL,
	[Limit] [datetime] NULL,
	[Quantity] [money] NULL,
	[Amount] [money] NULL,
	[Batch] [nvarchar](50) NULL,
	[Serial] [nvarchar](50) NULL,
	[ChassyNo] [nvarchar](50) NULL,
	[Color] [nvarchar](20) NULL,
	[Location] [nvarchar](20) NULL,
	[Width] [money] NULL,
	[Height] [money] NULL,
	[Orgin] [nvarchar](255) NULL,
	[Size] [nvarchar](255) NULL,
	[Descritopn] [nvarchar](255) NULL,
 CONSTRAINT [PK_INVENTORY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INVENTORY_ACTION]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVENTORY_ACTION](
	[Action_ID] [int] NOT NULL,
	[Action_Name] [nvarchar](255) NULL,
 CONSTRAINT [PK_INVENTORY_ACTION] PRIMARY KEY CLUSTERED 
(
	[Action_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[INVENTORY_BOOK]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INVENTORY_BOOK](
	[ID] [uniqueidentifier] NOT NULL,
	[Book_ID] [varchar](20) NULL,
	[Created] [datetime] NULL,
	[Stock_Date] [datetime] NULL,
	[Limit] [datetime] NULL,
	[Stock_ID] [varchar](20) NULL,
	[Product_ID] [varchar](20) NULL,
	[ProductName] [nvarchar](255) NULL,
	[Customer_ID] [varchar](20) NULL,
	[Currency_ID] [varchar](3) NULL,
	[Quantity] [money] NULL,
	[ExchangeRate] [money] NULL,
	[UnitPrice] [money] NULL,
	[Amount] [money] NULL,
	[Batch] [nvarchar](50) NULL,
	[Serial] [nvarchar](50) NULL,
	[Frame] [nvarchar](50) NULL,
	[Width] [money] NULL,
	[Height] [money] NULL,
	[Orgin] [nvarchar](255) NULL,
	[Size] [nvarchar](255) NULL,
	[Lock] [int] NULL,
 CONSTRAINT [PK_INVENTORY_BOOK] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INVENTORY_DATE]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INVENTORY_DATE](
	[ID] [bigint] NOT NULL,
	[RefDate] [datetime] NULL,
	[Stock_ID] [varchar](20) NULL,
	[Product_ID] [varchar](20) NULL,
	[E_Qty] [money] NULL,
	[E_Unt] [money] NULL,
	[E_Amt] [money] NULL,
 CONSTRAINT [PK_INVENTORY_DATE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INVENTORY_DETAIL]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INVENTORY_DETAIL](
	[ID] [bigint] NOT NULL,
	[RefNo] [varchar](20) NULL,
	[RefDate] [datetime] NULL,
	[RefDetailNo] [uniqueidentifier] NULL,
	[RefType] [int] NULL,
	[RefStatus] [int] NULL,
	[StoreID] [bigint] NULL,
	[Stock_ID] [varchar](20) NULL,
	[Product_ID] [varchar](20) NULL,
	[Product_Name] [nvarchar](255) NULL,
	[Customer_ID] [varchar](20) NULL,
	[Employee_ID] [varchar](20) NULL,
	[Batch] [nvarchar](50) NULL,
	[Serial] [varchar](50) NULL,
	[Unit] [nvarchar](50) NULL,
	[Price] [money] NULL,
	[Quantity] [money] NULL,
	[UnitPrice] [money] NULL,
	[Amount] [money] NULL,
	[E_Qty] [money] NULL,
	[E_Amt] [money] NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Book_ID] [varchar](20) NULL,
 CONSTRAINT [PK_INVENTORY_DETAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[INVENTORY_LEDGER]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[INVENTORY_LEDGER](
	[ID] [int] NULL,
	[RefDate] [datetime] NULL,
	[Product_ID] [varchar](20) NULL,
	[Product_Name] [nvarchar](255) NULL,
	[Unit_Name] [nvarchar](250) NULL,
	[Stock_ID] [varchar](20) NULL,
	[Stock_Name] [nvarchar](255) NULL,
	[Product_Group_ID] [varchar](20) NULL,
	[ProductGroup_Name] [nvarchar](255) NULL,
	[OpenQuantity] [money] NULL,
	[OpenAmount] [money] NULL,
	[InQuantity] [money] NULL,
	[InAmount] [money] NULL,
	[OutQuantity] [money] NULL,
	[OutAmount] [money] NULL,
	[OnhandQuantity] [money] NULL,
	[CloseAmount] [money] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KEYCODE]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KEYCODE](
	[Id_Key] [int] NOT NULL,
	[KeyCode] [varchar](500) NULL,
	[Id_Contact] [int] NULL,
	[DateCreate] [datetime] NULL,
	[Property] [nvarchar](500) NULL,
	[NumActive] [int] NULL,
	[Activated] [int] NULL,
	[Blacklist] [bit] NULL,
	[TypeActive] [int] NULL,
	[TypeSoft] [int] NULL,
	[DateLimit] [datetime] NULL,
	[Register] [bit] NULL,
 CONSTRAINT [PK_KEYCODE] PRIMARY KEY CLUSTERED 
(
	[Id_Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MODULE]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODULE](
	[ID] [int] NOT NULL,
	[Ref_ID] [nvarchar](20) NULL,
	[Ref_Name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Path] [nvarchar](255) NULL,
	[Version] [nvarchar](20) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_MODULE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PAYMENT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PAYMENT](
	[Payment_ID] [varchar](20) NULL,
	[Payment_Date] [datetime] NULL,
	[Payment_No] [varchar](20) NULL,
	[ReceiverName] [nvarchar](100) NULL,
	[Currency_ID] [varchar](3) NULL,
	[Exchange] [money] NULL,
	[Customer_ID] [nchar](10) NULL,
	[Customer_Name] [nvarchar](255) NULL,
	[Customer_Address] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Payment_Group_ID] [varchar](20) NULL,
	[Amount] [money] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PAYMENT_GROUP]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PAYMENT_GROUP](
	[Payment_Group_ID] [varchar](20) NOT NULL,
	[Payment_Group_Name] [nvarchar](100) NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_PAYMENT_GROUP] PRIMARY KEY CLUSTERED 
(
	[Payment_Group_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[_chucnang] [nvarchar](30) NULL,
	[_lavel] [int] NULL,
	[_ma] [int] NULL,
	[_cha] [int] NULL,
	[_tatca] [bit] NULL,
	[_truycap] [bit] NULL,
	[_them] [bit] NULL,
	[_xoa] [bit] NULL,
	[_sua] [bit] NULL,
	[_print] [bit] NULL,
	[_nhap] [bit] NULL,
	[_xuat] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PRODUCT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCT](
	[Product_ID] [varchar](20) NOT NULL,
	[Product_Name] [nvarchar](255) NULL,
	[Product_NameEN] [nvarchar](255) NULL,
	[Product_Type_ID] [int] NULL,
	[Manufacturer_ID] [int] NULL,
	[Model_ID] [nvarchar](20) NULL,
	[Product_Group_ID] [varchar](20) NULL,
	[Provider_ID] [varchar](20) NULL,
	[Origin] [nvarchar](100) NULL,
	[Barcode] [varchar](20) NULL,
	[Unit] [nvarchar](20) NULL,
	[UnitConvert] [nvarchar](20) NULL,
	[UnitRate] [money] NULL,
	[Org_Price] [money] NULL,
	[Sale_Price] [money] NULL,
	[Retail_Price] [money] NULL,
	[Quantity] [money] NULL,
	[CurrentCost] [money] NULL,
	[AverageCost] [money] NULL,
	[Warranty] [int] NULL,
	[VAT_ID] [money] NULL,
	[ImportTax_ID] [money] NULL,
	[ExportTax_ID] [money] NULL,
	[LuxuryTax_ID] [money] NULL,
	[Customer_ID] [varchar](20) NULL,
	[Customer_Name] [nvarchar](255) NULL,
	[CostMethod] [smallint] NULL,
	[MinStock] [money] NULL,
	[MaxStock] [money] NULL,
	[Discount] [money] NULL,
	[Commission] [money] NULL,
	[Description] [nvarchar](255) NULL,
	[Color] [nvarchar](50) NULL,
	[Expiry] [bit] NULL,
	[LimitOrders] [money] NULL,
	[ExpiryValue] [money] NULL,
	[Batch] [bit] NULL,
	[Depth] [money] NULL,
	[Height] [money] NULL,
	[Width] [money] NULL,
	[Thickness] [money] NULL,
	[Size] [nvarchar](50) NULL,
	[Photo] [image] NULL,
	[Currency_ID] [varchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[Stock_ID] [varchar](20) NULL,
	[UserID] [varchar](20) NULL,
	[Serial] [bit] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUCT_BUILD]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCT_BUILD](
	[ProductID] [varchar](20) NOT NULL,
	[BuildID] [varchar](20) NOT NULL,
	[Quantity] [money] NULL,
	[Price] [money] NULL,
	[Amount] [money] NULL,
 CONSTRAINT [PK_PRODUCT_BUILD] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[BuildID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUCT_GROUP]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCT_GROUP](
	[ProductGroup_ID] [varchar](20) NOT NULL,
	[ProductGroup_Name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[IsMain] [bit] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_PRODUCT_GROUP] PRIMARY KEY CLUSTERED 
(
	[ProductGroup_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUCT_MODEL]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_MODEL](
	[ID] [uniqueidentifier] NULL,
	[Code] [nvarchar](20) NULL,
	[Name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PRODUCT_PRICE]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_PRICE](
	[ID] [uniqueidentifier] NOT NULL,
	[RefDate] [datetime] NULL,
	[RefStatus] [smallint] NULL,
	[BeginDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[ProductID] [uniqueidentifier] NULL,
	[CustomerID] [uniqueidentifier] NULL,
	[Price] [money] NULL,
	[DiscountRate] [money] NULL,
	[CommissionRate] [money] NULL,
	[Quantity] [money] NULL,
	[BeginAmount] [money] NULL,
	[EndAmount] [money] NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_PRODUCT_PRICE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PRODUCT_TYPE]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_TYPE](
	[Product_Type_ID] [int] NOT NULL,
	[Product_Name] [nvarchar](255) NULL,
 CONSTRAINT [PK_PRODUCT_TYPE] PRIMARY KEY CLUSTERED 
(
	[Product_Type_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PRODUCT_UNIT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_UNIT](
	[Product_ID] [nvarchar](20) NOT NULL,
	[Unit_ID] [nvarchar](20) NOT NULL,
	[UnitConvert_ID] [nvarchar](20) NOT NULL,
	[UnitConvert] [money] NULL,
	[Sorted] [bigint] NULL,
 CONSTRAINT [PK_PRODUCT_UNIT] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC,
	[Unit_ID] ASC,
	[UnitConvert_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PROVIDER]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROVIDER](
	[Customer_ID] [varchar](20) NOT NULL,
	[OrderID] [bigint] NULL,
	[CustomerName] [nvarchar](255) NULL,
	[Customer_Type_ID] [varchar](20) NULL,
	[Customer_Group_ID] [varchar](20) NULL,
	[CustomerAddress] [nvarchar](255) NULL,
	[Birthday] [varchar](10) NULL,
	[Barcode] [varchar](20) NULL,
	[Tax] [varchar](20) NULL,
	[Tel] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[Mobile] [varchar](20) NULL,
	[Website] [varchar](100) NULL,
	[Contact] [nvarchar](100) NULL,
	[Position] [nvarchar](100) NULL,
	[NickYM] [nvarchar](20) NULL,
	[NickSky] [nvarchar](20) NULL,
	[Area] [nvarchar](100) NULL,
	[District] [nvarchar](100) NULL,
	[Contry] [nvarchar](100) NULL,
	[City] [nvarchar](100) NULL,
	[BankAccount] [varchar](20) NULL,
	[BankName] [nvarchar](100) NULL,
	[CreditLimit] [money] NULL,
	[Discount] [money] NULL,
	[IsDebt] [bit] NULL,
	[IsDebtDetail] [bit] NULL,
	[IsProvider] [bit] NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_PROVIDER] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PROVIDER_DEBT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVIDER_DEBT](
	[ID] [uniqueidentifier] NOT NULL,
	[RefID] [nvarchar](20) NULL,
	[RefDate] [datetime] NULL,
	[RefOrgNo] [nvarchar](20) NULL,
	[RefType] [smallint] NULL,
	[RefStatus] [smallint] NULL,
	[PaymentMethod] [uniqueidentifier] NULL,
	[CustomerID] [nvarchar](20) NULL,
	[ProductID] [nvarchar](20) NULL,
	[ProductName] [nvarchar](255) NULL,
	[CurrencyID] [nvarchar](20) NULL,
	[ExchangeRate] [money] NULL,
	[TermID] [nvarchar](20) NULL,
	[DueDate] [datetime] NULL,
	[Quantity] [money] NULL,
	[ReQuantity] [money] NULL,
	[Amount] [money] NULL,
	[Payment] [money] NULL,
	[Balance] [money] NULL,
	[FAmount] [money] NULL,
	[FPayment] [money] NULL,
	[FBalance] [money] NULL,
	[Discount] [money] NULL,
	[FDiscount] [money] NULL,
	[IsChanged] [bit] NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_PROVIDER_DEBT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PROVIDER_PAYMENT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVIDER_PAYMENT](
	[ID] [uniqueidentifier] NOT NULL,
	[RefID] [nvarchar](20) NULL,
	[RefDate] [datetime] NULL,
	[RefOrgNo] [nvarchar](20) NULL,
	[RefType] [smallint] NULL,
	[RefStatus] [smallint] NULL,
	[PaymentMethod] [uniqueidentifier] NULL,
	[Barcode] [nvarchar](20) NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[BranchID] [nvarchar](20) NULL,
	[ContractID] [nvarchar](20) NULL,
	[CustomerID] [nvarchar](20) NULL,
	[CustomerName] [nvarchar](255) NULL,
	[CustomerAddress] [nvarchar](255) NULL,
	[CustomerTax] [nvarchar](20) NULL,
	[ContactName] [nvarchar](100) NULL,
	[Amount] [money] NULL,
	[FAmount] [money] NULL,
	[Discount] [money] NULL,
	[FDiscount] [money] NULL,
	[Reconciled] [bit] NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_PROVIDER_PAYMENT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PROVIDER_PAYMENT_DETAIL]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVIDER_PAYMENT_DETAIL](
	[ID] [uniqueidentifier] NOT NULL,
	[PaymentID] [uniqueidentifier] NULL,
	[RefOrgNo] [uniqueidentifier] NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[Quantity] [money] NULL,
	[Amount] [money] NULL,
	[Debit] [money] NULL,
	[Payment] [money] NULL,
	[DiscountPercent] [money] NULL,
	[Discount] [money] NULL,
	[FAmount] [money] NULL,
	[FDebit] [money] NULL,
	[FPayment] [money] NULL,
	[FDiscount] [money] NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
 CONSTRAINT [PK_PROVIDER_PAYMENT_DETAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RECEIPT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RECEIPT](
	[Receipt_ID] [varchar](20) NOT NULL,
	[Receipt_Date] [datetime] NULL,
	[Receipt_No] [varchar](20) NULL,
	[DelivererName] [nvarchar](100) NULL,
	[Currency_ID] [varchar](3) NULL,
	[Exchange] [money] NULL,
	[Customer_ID] [varchar](20) NULL,
	[Customer_Name] [nvarchar](255) NULL,
	[Customer_Address] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Receipt_Group_ID] [varchar](20) NULL,
	[Amount] [money] NULL,
 CONSTRAINT [PK_RECEIPTL] PRIMARY KEY CLUSTERED 
(
	[Receipt_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RECEIPT_GROUP]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RECEIPT_GROUP](
	[Receipt_Group_ID] [varchar](20) NOT NULL,
	[Receipt_Group_Name] [nvarchar](100) NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_RECEIPT_GROUP] PRIMARY KEY CLUSTERED 
(
	[Receipt_Group_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REFTYPE]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REFTYPE](
	[ID] [smallint] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[NameEN] [nvarchar](255) NULL,
	[CategoryID] [smallint] NULL,
	[Sorted] [bigint] NULL,
	[IsSearch] [bit] NULL,
 CONSTRAINT [PK_REFTYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[REPORT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REPORT](
	[Report_ID] [varchar](20) NOT NULL,
	[Report_Name] [nvarchar](255) NULL,
	[Title] [nvarchar](255) NULL,
	[Comment] [nvarchar](255) NULL,
	[FileName] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[DataSet] [nvarchar](50) NULL,
	[Class] [nvarchar](50) NULL,
	[Parent_ID] [varchar](20) NULL,
	[Order] [int] NULL,
	[Avtive] [bit] NULL,
 CONSTRAINT [PK_REPORT] PRIMARY KEY CLUSTERED 
(
	[Report_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REPORT_GROUP]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REPORT_GROUP](
	[Report_Group_ID] [varchar](20) NOT NULL,
	[Report_Group_Name] [nvarchar](50) NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_REPORT_GROUP] PRIMARY KEY CLUSTERED 
(
	[Report_Group_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SALE_ORDER]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALE_ORDER](
	[ID] [uniqueidentifier] NOT NULL,
	[RefID] [nvarchar](20) NULL,
	[RefDate] [datetime] NULL,
	[RefNo] [nvarchar](20) NULL,
	[RefOrgNo] [nvarchar](20) NULL,
	[RefType] [smallint] NULL,
	[RefStatus] [smallint] NULL,
	[PaymentMethod] [nvarchar](20) NULL,
	[Barcode] [nvarchar](20) NULL,
	[StockID] [nvarchar](20) NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[BranchID] [nvarchar](20) NULL,
	[ContractID] [nvarchar](20) NULL,
	[CustomerID] [nvarchar](20) NULL,
	[CustomerName] [nvarchar](255) NULL,
	[CustomerAddress] [nvarchar](255) NULL,
	[CustomerTax] [nvarchar](20) NULL,
	[ContactName] [nvarchar](100) NULL,
	[ShipViaID] [nvarchar](20) NULL,
	[TermID] [nvarchar](20) NULL,
	[DueDate] [datetime] NULL,
	[ExpectedDate] [datetime] NULL,
	[DiscountDate] [datetime] NULL,
	[DiscountPercent] [money] NULL,
	[DiscountTaken] [money] NULL,
	[IsPaid] [bit] NULL,
	[IsReceived] [bit] NULL,
	[IsClosed] [bit] NULL,
	[IsPrinted] [bit] NULL,
	[IsFob] [bit] NULL,
	[FOB] [money] NULL,
	[Amount] [money] NULL,
	[Payment] [money] NULL,
	[VatAmount] [money] NULL,
	[Discount] [money] NULL,
	[OtherDiscount] [money] NULL,
	[ShipCharge] [money] NULL,
	[OtherCharge] [money] NULL,
	[FAmount] [money] NULL,
	[FPayment] [money] NULL,
	[FVatAmount] [money] NULL,
	[FDiscount] [money] NULL,
	[FOtherDiscount] [money] NULL,
	[FShipCharge] [money] NULL,
	[FOtherCharge] [money] NULL,
	[SellerID] [nvarchar](20) NULL,
	[DeliverID] [nvarchar](20) NULL,
	[DeliveryDate] [datetime] NULL,
	[DriverID] [nvarchar](20) NULL,
	[TruckNumber] [nvarchar](20) NULL,
	[CarryingMeans] [nvarchar](255) NULL,
	[IsPublic] [bit] NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](20) NULL,
	[ModifiedDate] [datetime] NULL,
	[OwnerID] [nvarchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_SALE_ORDER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SALE_ORDER_DETAIL]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALE_ORDER_DETAIL](
	[ID] [uniqueidentifier] NOT NULL,
	[RefID] [nvarchar](20) NULL,
	[StockID] [nvarchar](20) NULL,
	[TypeID] [smallint] NULL,
	[ProductID] [nvarchar](20) NULL,
	[ProductName] [nvarchar](255) NULL,
	[Unit] [nvarchar](20) NULL,
	[UnitConvert] [money] NULL,
	[TaxID] [nvarchar](20) NULL,
	[TaxRate] [money] NULL,
	[TaxAmount] [money] NULL,
	[Vat] [nvarchar](20) NULL,
	[Quantity] [money] NULL,
	[Shipped] [money] NULL,
	[FUnitPrice] [money] NULL,
	[UnitPrice] [money] NULL,
	[DiscountRate] [money] NULL,
	[FDiscount] [money] NULL,
	[Discount] [money] NULL,
	[FVatAmount] [money] NULL,
	[VatAmount] [money] NULL,
	[FCharge] [money] NULL,
	[Charge] [money] NULL,
	[FAmount] [money] NULL,
	[Amount] [money] NULL,
	[Batch] [nvarchar](20) NULL,
	[SerialBegin] [nvarchar](20) NULL,
	[SerialEnd] [nvarchar](20) NULL,
	[ChassyNo] [nvarchar](20) NULL,
	[Width] [money] NULL,
	[Height] [money] NULL,
	[Orgin] [nvarchar](255) NULL,
	[Size] [nvarchar](255) NULL,
	[IsClosed] [bit] NULL,
	[IsWarranty] [bit] NULL,
	[IsBorrow] [bit] NULL,
	[IsBatch] [bit] NULL,
	[IsSerial] [bit] NULL,
	[Sorted] [int] NULL,
	[StoreID] [uniqueidentifier] NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_SALE_ORDER_DETAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SOFT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SOFT](
	[Id_Soft] [int] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[NewVersion] [varchar](50) NULL,
	[Date] [datetime] NULL,
	[VerHistory] [nvarchar](500) NULL,
 CONSTRAINT [PK_SOFT] PRIMARY KEY CLUSTERED 
(
	[Id_Soft] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STOCK]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STOCK](
	[Stock_ID] [varchar](20) NOT NULL,
	[Stock_Name] [nvarchar](255) NULL,
	[Contact] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Email] [nvarchar](50) NULL,
	[Telephone] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
	[Mobi] [varchar](20) NULL,
	[Manager] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_STOCK] PRIMARY KEY CLUSTERED 
(
	[Stock_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STOCK_BUILD]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STOCK_BUILD](
	[ID] [varchar](20) NOT NULL,
	[RefDate] [datetime] NULL,
	[Ref_OrgNo] [nvarchar](20) NULL,
	[RefType] [int] NULL,
	[Barcode] [varchar](20) NULL,
	[Department_ID] [varchar](20) NULL,
	[Employee_ID] [varchar](20) NULL,
	[FromStock_ID] [varchar](20) NULL,
	[ToStock_ID] [varchar](20) NULL,
	[Branch_ID] [varchar](20) NULL,
	[Contract_ID] [varchar](20) NULL,
	[Product_ID] [varchar](20) NULL,
	[Currency_ID] [varchar](3) NULL,
	[ProductName] [nvarchar](255) NULL,
	[ExchangeRate] [money] NULL,
	[Quantity] [money] NULL,
	[Amount] [money] NULL,
	[FAmount] [money] NULL,
	[IsClose] [bit] NULL,
	[Description] [nvarchar](255) NULL,
	[User_ID] [varchar](20) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_STOCK_BUILD] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STOCK_BUILD_DETAIL]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STOCK_BUILD_DETAIL](
	[ID] [uniqueidentifier] NULL,
	[Transfer_ID] [varchar](20) NULL,
	[RefType] [int] NULL,
	[Product_ID] [varchar](20) NULL,
	[Product_Name] [nvarchar](250) NULL,
	[OutStock] [varchar](20) NULL,
	[InStock] [varchar](20) NULL,
	[Unit] [nvarchar](20) NULL,
	[UnitConvert] [money] NULL,
	[UnitPrice] [money] NULL,
	[Quantity] [money] NULL,
	[Amount] [money] NULL,
	[QtyConvert] [money] NULL,
	[Limit] [datetime] NULL,
	[Width] [money] NULL,
	[Height] [money] NULL,
	[Orgin] [nvarchar](255) NULL,
	[Size] [nvarchar](255) NULL,
	[Color] [nvarchar](255) NULL,
	[Batch] [varchar](50) NULL,
	[Serial] [varchar](50) NULL,
	[ChassyNo] [varchar](50) NULL,
	[IME] [varchar](50) NULL,
	[StoreID] [bigint] NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STOCK_INWARD]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STOCK_INWARD](
	[ID] [uniqueidentifier] NOT NULL,
	[Inward_ID] [varchar](20) NULL,
	[Product_ID] [varchar](20) NULL,
	[ProductName] [nvarchar](255) NULL,
	[RefType] [int] NULL,
	[Stock_ID] [varchar](20) NULL,
	[Unit] [nvarchar](20) NULL,
	[UnitConvert] [money] NULL,
	[Vat] [int] NULL,
	[VatAmount] [money] NULL,
	[CurrentQty] [money] NULL,
	[Quantity] [money] NULL,
	[UnitPrice] [money] NULL,
	[Amount] [money] NULL,
	[QtyConvert] [money] NULL,
	[DiscountRate] [money] NULL,
	[Discount] [money] NULL,
	[Charge] [money] NULL,
	[Limit] [datetime] NULL,
	[Width] [money] NULL,
	[Height] [money] NULL,
	[Orgin] [nvarchar](255) NULL,
	[Size] [nvarchar](255) NULL,
	[Color] [varchar](20) NULL,
	[Batch] [varchar](50) NULL,
	[Serial] [varchar](50) NULL,
	[ChassyNo] [varchar](50) NULL,
	[IME] [varchar](50) NULL,
	[StoreID] [bigint] NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_STOCK_INWARD] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STOCK_OUTWARD]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STOCK_OUTWARD](
	[ID] [varchar](20) NOT NULL,
	[RefDate] [datetime] NULL,
	[Ref_OrgNo] [nvarchar](20) NULL,
	[RefType] [int] NULL,
	[RefStatus] [int] NULL,
	[PaymentMethod] [uniqueidentifier] NULL,
	[TermID] [nvarchar](20) NULL,
	[PaymentDate] [datetime] NULL,
	[DeliveryDate] [datetime] NULL,
	[Barcode] [varchar](20) NULL,
	[Department_ID] [nvarchar](20) NULL,
	[Employee_ID] [varchar](20) NULL,
	[Stock_ID] [varchar](20) NULL,
	[Branch_ID] [varchar](20) NULL,
	[Contract_ID] [varchar](20) NULL,
	[Customer_ID] [varchar](20) NULL,
	[CustomerName] [nvarchar](255) NULL,
	[CustomerAddress] [nvarchar](255) NULL,
	[Contact] [nvarchar](100) NULL,
	[Reason] [nvarchar](255) NULL,
	[Payment] [smallint] NULL,
	[Currency_ID] [varchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[Vat] [int] NULL,
	[VatAmount] [money] NULL,
	[Amount] [money] NULL,
	[FAmount] [money] NULL,
	[DiscountDate] [datetime] NULL,
	[DiscountRate] [money] NULL,
	[Discount] [money] NULL,
	[OtherDiscount] [money] NULL,
	[Charge] [money] NULL,
	[Cost] [money] NULL,
	[Profit] [money] NULL,
	[User_ID] [varchar](20) NULL,
	[IsClose] [bit] NULL,
	[Sorted] [bigint] NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
	[Timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_STOCK_OUTWARD] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STOCK_OUTWARD_DETAIL]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STOCK_OUTWARD_DETAIL](
	[ID] [uniqueidentifier] NOT NULL,
	[Outward_ID] [varchar](20) NULL,
	[Stock_ID] [varchar](20) NULL,
	[RefType] [int] NULL,
	[Product_ID] [varchar](20) NULL,
	[ProductName] [nvarchar](255) NULL,
	[Vat] [int] NULL,
	[VatAmount] [money] NULL,
	[Unit] [nvarchar](20) NULL,
	[UnitConvert] [money] NULL,
	[CurrentQty] [money] NULL,
	[Quantity] [money] NULL,
	[UnitPrice] [money] NULL,
	[Amount] [money] NULL,
	[QtyConvert] [money] NULL,
	[DiscountRate] [money] NULL,
	[Discount] [money] NULL,
	[Charge] [money] NULL,
	[Cost] [money] NULL,
	[Profit] [money] NULL,
	[Batch] [varchar](50) NULL,
	[Serial] [varchar](50) NULL,
	[ChassyNo] [varchar](50) NULL,
	[IME] [varchar](50) NULL,
	[Width] [money] NULL,
	[Height] [money] NULL,
	[Orgin] [nvarchar](255) NULL,
	[Size] [nvarchar](255) NULL,
	[StoreID] [bigint] NULL,
	[Description] [nvarchar](250) NULL,
	[Sorted] [bigint] NULL,
	[Active] [bit] NULL,
	[Timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_STOCK_OUTWARD_DETAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STOCK_TRANSFER]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STOCK_TRANSFER](
	[ID] [varchar](20) NOT NULL,
	[RefDate] [datetime] NULL,
	[Ref_OrgNo] [nvarchar](20) NULL,
	[RefType] [int] NULL,
	[Department_ID] [varchar](20) NULL,
	[Employee_ID] [varchar](20) NULL,
	[FromStock_ID] [varchar](20) NULL,
	[Sender_ID] [varchar](20) NULL,
	[ToStock_ID] [varchar](20) NULL,
	[Receiver_ID] [varchar](20) NULL,
	[Branch_ID] [varchar](20) NULL,
	[Contract_ID] [varchar](20) NULL,
	[Currency_ID] [varchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[Barcode] [varchar](20) NULL,
	[Amount] [money] NULL,
	[IsReview] [bit] NULL,
	[User_ID] [varchar](20) NULL,
	[IsClose] [bit] NULL,
	[Sorted] [bigint] NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_STOCK_TRANSFER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STOCK_TRANSFER_DETAIL]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STOCK_TRANSFER_DETAIL](
	[ID] [uniqueidentifier] NOT NULL,
	[Transfer_ID] [varchar](20) NULL,
	[RefType] [int] NULL,
	[Product_ID] [varchar](20) NULL,
	[Product_Name] [nvarchar](250) NULL,
	[OutStock] [varchar](20) NULL,
	[OutStockName] [nvarchar](250) NULL,
	[InStock] [varchar](20) NULL,
	[InStockName] [nvarchar](250) NULL,
	[Unit] [nvarchar](20) NULL,
	[UnitConvert] [money] NULL,
	[UnitPrice] [money] NULL,
	[Quantity] [money] NULL,
	[Amount] [money] NULL,
	[QtyConvert] [money] NULL,
	[StoreID] [bigint] NULL,
	[Batch] [varchar](50) NULL,
	[Serial] [varchar](50) NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
 CONSTRAINT [PK_STOCK_TRANSFER_DETAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_COMPANY]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_COMPANY](
	[Company_Id] [varchar](20) NOT NULL,
	[Company] [nvarchar](250) NULL,
	[Address] [nvarchar](250) NULL,
	[Tel] [varchar](50) NULL,
	[Fax] [varchar](50) NULL,
	[WebSite] [varchar](250) NULL,
	[Email] [varchar](50) NULL,
	[Tax] [varchar](50) NULL,
	[Licence] [nvarchar](50) NULL,
	[Photo] [image] NULL,
 CONSTRAINT [PK_SYS_COMPANY] PRIMARY KEY CLUSTERED 
(
	[Company_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_GROUP]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_GROUP](
	[Group_ID] [varchar](20) NOT NULL,
	[Group_Name] [nvarchar](100) NULL,
	[Group_NameEn] [nvarchar](100) NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_SYS_GROUP] PRIMARY KEY CLUSTERED 
(
	[Group_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_GROUP_OBJECT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_GROUP_OBJECT](
	[Object_ID] [varchar](50) NOT NULL,
	[Goup_ID] [varchar](20) NOT NULL,
	[Active] [nchar](10) NULL,
 CONSTRAINT [PK_SYS_GROUP_OBJECT] PRIMARY KEY CLUSTERED 
(
	[Object_ID] ASC,
	[Goup_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_GROUP_STOCK]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_GROUP_STOCK](
	[GroupID] [varchar](50) NOT NULL,
	[StockID] [varchar](50) NOT NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_SYS_GROUP_STOCK] PRIMARY KEY CLUSTERED 
(
	[StockID] ASC,
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_INFO]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_INFO](
	[SysInfo_ID] [varchar](10) NOT NULL,
	[Application] [varchar](50) NULL,
	[Version] [varchar](50) NULL,
	[Type] [int] NULL,
	[Created] [datetime] NULL,
	[Description] [nvarchar](255) NULL,
	[Interface] [int] NULL,
	[Guid_ID] [nvarchar](255) NULL,
 CONSTRAINT [PK_SYS_INFO] PRIMARY KEY CLUSTERED 
(
	[SysInfo_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_OBJECT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_OBJECT](
	[ID] [uniqueidentifier] NOT NULL,
	[Object_ID] [varchar](50) NULL,
	[Object_Name] [nvarchar](50) NULL,
	[Object_NameEn] [nvarchar](50) NULL,
	[Description] [nvarchar](255) NULL,
	[Parent_ID] [varchar](20) NULL,
	[Level] [int] NULL,
	[Order_ID] [int] NULL,
	[Owner] [nvarchar](50) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_SYS_OBJECT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_OPTION]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_OPTION](
	[Option_ID] [varchar](50) NOT NULL,
	[OptionValue] [nvarchar](100) NULL,
	[ValueType] [int] NULL,
	[System] [bit] NULL,
	[Description] [nvarchar](255) NULL,
 CONSTRAINT [PK_SYS_OPTION] PRIMARY KEY CLUSTERED 
(
	[Option_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_RULE]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_RULE](
	[Rule_ID] [varchar](20) NOT NULL,
	[Rule_Name] [nvarchar](100) NULL,
	[Rule_NameEn] [nvarchar](100) NULL,
	[Description] [nvarchar](255) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_SYS_RULE] PRIMARY KEY CLUSTERED 
(
	[Rule_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_USER]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_USER](
	[UserID] [varchar](20) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Group_ID] [varchar](20) NULL,
	[Description] [nvarchar](255) NULL,
	[PartID] [varchar](20) NULL,
	[Active] [bit] NULL,
	[Employee_ID] [nchar](10) NULL,
 CONSTRAINT [PK_SYS_USER] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_USER_RULE]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_USER_RULE](
	[Goup_ID] [varchar](20) NOT NULL,
	[Object_ID] [varchar](50) NOT NULL,
	[Rule_ID] [varchar](20) NULL,
	[AllowAdd] [bit] NULL,
	[AllowDelete] [bit] NULL,
	[AllowEdit] [bit] NULL,
	[AllowAccess] [bit] NULL,
	[AllowPrint] [bit] NULL,
	[AllowExport] [bit] NULL,
	[AllowImport] [bit] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_SYS_USER_RULE] PRIMARY KEY CLUSTERED 
(
	[Goup_ID] ASC,
	[Object_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SYS_USER_STOCK]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SYS_USER_STOCK](
	[UserID] [varchar](50) NOT NULL,
	[StockID] [varchar](50) NOT NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_SYS_USER_STOCK] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[StockID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRANS_CASH]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANS_CASH](
	[ID] [uniqueidentifier] NOT NULL,
	[BookID] [nvarchar](20) NULL,
	[RefID] [nvarchar](20) NULL,
	[RefDate] [datetime] NULL,
	[RefNo] [uniqueidentifier] NULL,
	[RefOrgNo] [uniqueidentifier] NULL,
	[RefType] [smallint] NULL,
	[RefStatus] [smallint] NULL,
	[CustomerID] [nvarchar](20) NULL,
	[PaymentMethod] [uniqueidentifier] NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[Amount] [money] NULL,
	[Balance] [money] NULL,
	[FAmount] [money] NULL,
	[FBalance] [money] NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
 CONSTRAINT [PK_TRANS_CASH] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRANS_DEBT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANS_DEBT](
	[ID] [uniqueidentifier] NOT NULL,
	[BookID] [nvarchar](20) NULL,
	[RefID] [nvarchar](20) NULL,
	[RefDate] [datetime] NULL,
	[RefDetailNo] [uniqueidentifier] NULL,
	[RefNo] [uniqueidentifier] NULL,
	[RefOrgNo] [uniqueidentifier] NULL,
	[RefType] [smallint] NULL,
	[RefStatus] [smallint] NULL,
	[CustomerID] [nvarchar](20) NULL,
	[CurrencyID] [nvarchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[IsDebt] [bit] NULL,
	[Amount] [money] NULL,
	[Discount] [money] NULL,
	[Payment] [money] NULL,
	[Balance] [money] NULL,
	[FAmount] [money] NULL,
	[FDiscount] [money] NULL,
	[FPayment] [money] NULL,
	[FBalance] [money] NULL,
	[Debit] [money] NULL,
	[Description] [nvarchar](255) NULL,
	[Sorted] [bigint] NULL,
 CONSTRAINT [PK_TRANS_DEBT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRANS_REF]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANS_REF](
	[ID] [uniqueidentifier] NOT NULL,
	[RefID] [nvarchar](20) NULL,
	[RefOrgNo] [nvarchar](20) NULL,
	[RefType] [int] NULL,
	[RefDate] [datetime] NULL,
	[TransFrom] [nvarchar](20) NULL,
	[TransTo] [nvarchar](50) NULL,
	[Department_ID] [nvarchar](50) NULL,
	[Employee_ID] [nvarchar](50) NULL,
	[Stock_ID] [nvarchar](50) NULL,
	[Branch_ID] [nvarchar](50) NULL,
	[Contract_ID] [nvarchar](50) NULL,
	[Contract] [nvarchar](200) NULL,
	[Reason] [nvarchar](255) NULL,
	[Currency_ID] [nvarchar](3) NULL,
	[ExchangeRate] [money] NULL,
	[Amount] [money] NULL,
	[Discount] [money] NULL,
	[FAmount] [money] NULL,
	[FDiscount] [money] NULL,
	[IsClose] [bit] NULL,
	[Sorted] [bigint] NULL,
	[Description] [nvarchar](255) NULL,
	[User_ID] [nvarchar](20) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_TRANS_REF] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UNIT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNIT](
	[Unit_ID] [nvarchar](20) NOT NULL,
	[Unit_Name] [nvarchar](250) NULL,
	[Description] [nvarchar](250) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_UNIT] PRIMARY KEY CLUSTERED 
(
	[Unit_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UNITCONVERT]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UNITCONVERT](
	[ID] [nvarchar](255) NOT NULL,
	[ProductID] [varchar](20) NULL,
	[UnitPrime] [nvarchar](20) NULL,
	[UnitConvert] [nvarchar](20) NULL,
	[ConvertRate] [money] NULL,
	[Formation] [nvarchar](255) NULL,
 CONSTRAINT [PK_UNITCONVERT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VAITRONGUOIDUNG]    Script Date: 11/25/2019 8:27:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VAITRONGUOIDUNG](
	[id] [int] NULL,
	[tengroup] [nvarchar](30) NULL,
	[UserName] [nvarchar](50) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[DEPARTMENT] ([Department_ID], [Department_Name], [Description], [Active]) VALUES (N'GD', N'Giám Đốc', NULL, NULL)
INSERT [dbo].[EMPLOYEE] ([Employee_ID], [FirtName], [LastName], [Employee_Name], [Alias], [Sex], [Address], [Country_ID], [H_Tel], [O_Tel], [Mobile], [Fax], [Email], [Birthday], [Married], [Position_ID], [JobTitle_ID], [Branch_ID], [Department_ID], [Team_ID], [PersonalTax_ID], [City_ID], [District_ID], [Manager_ID], [EmployeeType], [BasicSalary], [Advance], [AdvanceOther], [Commission], [Discount], [ProfitRate], [IsPublic], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [OwnerID], [Description], [Sorted], [Active]) VALUES (N'NV0000001', NULL, NULL, N'Kim Nhựt Trường', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'GD', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[SYS_GROUP] ([Group_ID], [Group_Name], [Group_NameEn], [Description], [Active]) VALUES (N'11aaaa', N'okkkk', N'', N'ok', 1)
INSERT [dbo].[SYS_GROUP] ([Group_ID], [Group_Name], [Group_NameEn], [Description], [Active]) VALUES (N'aaaa', N'kim', N'', N'kim nhut', 0)
INSERT [dbo].[SYS_GROUP] ([Group_ID], [Group_Name], [Group_NameEn], [Description], [Active]) VALUES (N'admin', N'Quản trị hệ thống', N'admin', N'Quản trị hệ thống', 1)
INSERT [dbo].[SYS_GROUP] ([Group_ID], [Group_Name], [Group_NameEn], [Description], [Active]) VALUES (N'bbb', N'nhựt', N'', N'kim', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'fdd06ebc-427a-4c28-a1ae-03b0e15964e6', N'bbiUnit', N'Đơn Vị', N'Unit', NULL, N'rbpgDicStock', 2, 30, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'e56990a9-bb4c-41de-8923-086e96dbfeae', N'rpgReport', N'Báo Cáo', N'Report', NULL, N'rbpStock', 1, 14, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'326c091d-27d8-408e-a9dd-0c9374b48601', N'rbpgSale', N'Bán Hàng', N'	Sale', NULL, N'rbpStock', 1, 9, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'fdff62dd-645d-4090-a8de-0f452e86e758', N'bbiVoucherManager', N'Quản Lý Chứng Từ', N'VoucherManager', NULL, N'rpgInvoice', 2, 49, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'97930834-7385-4131-b1d6-13e89a94b48e', N'bbiEmployee', N'Nhân Viên', N'Employee', NULL, N'rpgDeparment', 2, 36, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'2bf23d30-9bdc-435e-b1e2-2ac3fa16cb88', N'bbiStock', N'Kho', N'Stock', NULL, N'rbpgDicStock', 2, 29, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'ff1103df-b69c-40ef-bea9-2f73ef0bc41b', N'bbiProvider', N'Nhà Phân Phối', N'Provider', NULL, N'rbpgPartner', 2, 28, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'd98665d9-c8e1-4106-bb2a-34b357f291b1', N'bbiReport', N'Báo Cáo Kho', N'Report', NULL, N'rpgReport', 2, 50, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'53895501-c76d-461b-ac84-351160cd93c1', N'bbiAdjustment', N'Kiểm Kê', N'Adjustment', NULL, N'rbpgStockOther', 2, 45, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'391473df-78fd-484c-b6aa-37355414556c', N'bbiReportSale', N'Doanh Thu Bán Hàng', N'ReportSale', NULL, N'rpgReport', 2, 51, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'9cc1babb-c33f-45ee-9d18-382aabdf498d', N'bbiPacket', N'Đóng Gói', N'Packet', NULL, N'rbpgStockOther', 2, 44, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'0eceafd8-4067-471d-b388-387b20f3a25b', N'bbiOutward', N'Xuất Kho', N'Outward', NULL, N'rbpgInventory', 2, 42, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'fa9deacf-d397-444e-8bee-393d1d6b8857', N'rpgDebt', N'Công Nợ', N'Debt', NULL, N'rbpStock', 1, 10, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'a3bd8110-71d8-4c34-8dfa-3a2699e9d261', N'bbiCompanyInfo', N'Đơn Vị', N'	CompanyInfo', NULL, N'rbpgClose', 2, 16, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'bbf47518-ef69-4c32-bed8-3b5032c137de', N'bbiLock', N'Kết Chuyễn', N'Lock', NULL, N'rbpgDatabase', 2, 23, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'48c047da-ba2d-45e8-b91a-3d481d1a6c5b', N'bbiItemGroup', N'Nhóm Hàng', N'ItemGroup', NULL, N'rbpgDicStock', 2, 31, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'f92b1be2-efa6-4d59-a155-44b760f7f2f8', N'bbiPayment', N'Trả Tiền', N'Payment', NULL, N'rpgDebt', 2, 40, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'9bae914c-96b6-4b0a-acf6-484a2f1ae7b2', N'bbiUserRule', N'Vai Trò & Quyền Hạn', N'UserRule', NULL, N'bbiPermission', 3, 25, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'50760ad2-eb65-475a-8c45-4c193b9faaac', N'bbiExpire', N'Hạn Sử Dụng', N'Expire', NULL, N'rpgReport', 2, 52, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'124fbfad-b27d-41e1-8b56-4ea55515daa9', N'bbiRestore', N'Phục Hồi', N'Restore', NULL, N'rbpgDatabase', 2, 21, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'07957401-146a-4879-a08a-59837bb702d7', N'rbpgPartner', N'Đối Tác', N'Partner', NULL, N'rbpDictionary', 1, 6, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'3efd80d7-3d70-4d09-bfac-5ab88f5051e5', N'bbiFix', N'Sửa Chữa', N'Fix', NULL, N'rbpgDatabase', 2, 22, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'0bfdc0db-89d9-4d35-ac08-5c523c63e6fb', N'rbpgDicStock', N'Kho Hàng', N'Stock', NULL, N'rbpDictionary', 1, 7, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'e8c31caa-d79b-43d8-91ab-5fb3faed6f9b', N'bbiPurchase', N'Mua Hàng', N'Purchase', NULL, N'rbpgSale', 2, 37, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'11e97c29-939b-4809-bc59-66d2d313269d', N'bbiSaleReturn', N'Xuất trả hàng', N'SaleReturn', NULL, N'rbpgSale', 2, 56, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'4506625e-186f-4820-abcc-672036ded9d6', N'bbiPurchaseReturn', N'Nhập trả hàng', N'PurchaseReturn', NULL, N'rbpgSale', 2, 57, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'd444edc3-d736-4395-846b-70f4a8c955ff', N'bbiUnitConvert', N'Quy đổi đơn vị', N'UnitConvert', NULL, N'rbpgDicStock', 2, 58, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'71a6ca2c-b7b5-4319-8e58-7ee0ffc1feeb', N'rpgDeparment', N'Bộ Phận', N'Department', NULL, N'rbpDictionary', 1, 8, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'd54f21de-a188-4ca0-982a-898f35f2cecd', N'bbiPermission', N'Quản Lý Phân Quyền', N'Permission', NULL, N'rbpgSecurity', 2, 17, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'58172443-92db-4fa1-af21-8f5ae89dd087', N'bbiSale', N'Bán Hàng', N'Sale', NULL, N'rbpgSale', 2, 38, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'a2eeefac-3f6e-43dc-b6ee-93454f8c59b4', N'bbiInventory', N'Tồn Kho', N'Inventory', NULL, N'rbpgInventory', 2, 43, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'f0bdcbe6-3512-473a-b2db-94634c9682c9', N'bbiInvoice', N'Hoá Đơn', N'Invoice', NULL, N'rpgInvoice', 2, 48, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'94138cd3-21f7-4658-a516-97ec3010f7fe', N'bbiInventoryOrder', N'Đặt Hàng', N'InventoryOrder', NULL, N'rpgTool', 2, 53, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'0cff005d-6516-45f0-82ad-988f84931ae9', N'bbiTransfer', N'Chuyển Kho', N'Transfer', NULL, N'rbpgStockOther', 2, 46, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'aa7e6096-4f80-40a7-a912-9b26ebc2851b', N'rbpgDatabase', N'Dữ Liệu', N'Database', NULL, N'rbpSystem', 1, 5, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'e8709294-c7b4-4b56-b4c2-9b5d15dab980', N'bbiBackup', N'Sao Lưu', N'Backup', NULL, N'rbpgDatabase', 2, 20, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'f02f230c-ff5a-481f-bbfd-a0cb68429edd', N'bbiHistory', N'Lịch Sử Hàng Hoá', N'History', NULL, N'rpgTool', 2, 55, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'6075d2e4-0bbd-40a9-9671-a1e8c7404de7', N'rbpSystem', N'Hệ Thống', N'System', NULL, N'', 0, 0, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'1fdeaa53-e193-406e-ac4e-ad69531850df', N'bbiChangepassword', N'Đổi Mật Khẩu', N'Changepassword', NULL, N'rbpgSecurity', 2, 18, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'1e609ffc-8a66-44f8-9b01-b2c4e43cf352', N'bbiPrintBarcode', N'In Mã Vạch', N'PrintBarcode', NULL, N'rbpgDicStock', 2, 33, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'369d8989-2c45-4e22-ae02-bc5ba6b24937', N'bbiInventorySummary', N'Tổng Hợp Tồn Kho', N'InventorySummary', N'', N'rbpgStockOther', 2, 47, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'ca2fed16-65e6-4d61-9fd4-c489f3a8e6a8', N'rbpgSecurity', N'Bảo Mật', N'Secutiry', N'', N'rbpSystem', 1, 4, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'8c43b50f-8cac-4684-941d-c7dccd447496', N'bbiUser', N'Quản Lý Người Dùng', N'User', N'', N'bbiPermission', 3, 24, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'5405ab60-9c28-4756-9880-ca6a6eb7a3e3', N'rbpDictionary', N'Danh Mục', N'Dictionary', N'', N'', 0, 1, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'bd45cd66-ae98-4fe1-87b2-caae2d67722c', N'bbiCustomer', N'Khách Hàng', N'Customer', N'', N'rbpgPartner', 2, 27, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'b2a51fbf-7e4f-4f36-a363-d3129c634c53', N'rpgTool', N'Công Cụ', N'Tool', N'', N'rbpStock', 1, 15, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'f8a341cc-506e-4d9b-9a21-d4b9176fec5f', N'rbpgClose', N'Hệ Thống', N'System', N'', N'rbpSystem', 1, 3, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'7145ac4b-9084-41f8-9fd6-dcaddf060a5c', N'bbiCustomerGroup', N'Khu Vực', N'CustomerGroup', N'', N'rbpgPartner', 2, 26, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'efc3fd96-22b8-48fe-bc09-e0569876ac2f', N'bbiExchangeRate', N'Tỷ Giá', N'ExchangeRate', N'', N'rbpgDicStock', 2, 34, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'efa7aef5-4c3f-4904-9ad8-e05d9e73ce5b', N'bbiInward', N'Nhập Kho', N'Inward', N'', N'rbpgInventory', 2, 41, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'645add70-e138-4fb1-86ba-e41a9e83db05', N'rbpStock', N'Chức Năng', N'Stock', N'', N'', 0, 2, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'37a2038c-973d-4598-a6a4-e4270433ba1f', N'bbiMaterial', N'Hàng Hoá', N'Material', N'', N'rbpgDicStock', 2, 32, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'6a9d3a0b-cf91-4b5f-a577-e440873436b1', N'bbiInitInventory', N'Nhập Số Dư Ban Đầu', N'InitInventory', N'', N'rpgTool', 2, 54, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'3de3193f-b607-452f-ac25-e6b8ca371829', N'rpgInvoice', N'Hoá Đơn', N'Invoice', N'', N'rbpStock', 1, 13, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'a297c145-3c87-4eb9-a9d2-e727bf727ff7', N'bbiReciept', N'Thu Tiền', N'Reciept', N'', N'rpgDebt', 2, 39, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'45f63217-a739-41a1-86e7-f26000f9503a', N'bbiDepartment', N'Bộ Phận', N'Department', N'', N'rpgDeparment', 2, 35, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'1abe3533-504f-471e-b015-f7d00ef9d392', N'bbiSysLog', N'Nhật Ký Hệ Thống', N'SysLog', N'', N'rbpgSecurity', 2, 19, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'7964d843-7c76-436f-9d79-fbe6b991bfee', N'rbpgInventory', N'Kho Hàng', N'Inventory', N'', N'rbpStock', 1, 11, N'QLKBH', 1)
INSERT [dbo].[SYS_OBJECT] ([ID], [Object_ID], [Object_Name], [Object_NameEn], [Description], [Parent_ID], [Level], [Order_ID], [Owner], [Active]) VALUES (N'122dff15-c518-4d13-a6eb-ffb24157dfc2', N'rbpgStockOther', N'Tiện ích', N'Utilities', N'', N'rbpStock', 1, 12, N'QLKBH', 1)
INSERT [dbo].[SYS_RULE] ([Rule_ID], [Rule_Name], [Rule_NameEn], [Description], [Active]) VALUES (N'add', N'Thêm', NULL, NULL, 1)
INSERT [dbo].[SYS_RULE] ([Rule_ID], [Rule_Name], [Rule_NameEn], [Description], [Active]) VALUES (N'all', N'Tất cả', NULL, NULL, 1)
INSERT [dbo].[SYS_RULE] ([Rule_ID], [Rule_Name], [Rule_NameEn], [Description], [Active]) VALUES (N'delete', N'Xoá', NULL, NULL, 1)
INSERT [dbo].[SYS_RULE] ([Rule_ID], [Rule_Name], [Rule_NameEn], [Description], [Active]) VALUES (N'edit', N'Sửa', NULL, NULL, 1)
INSERT [dbo].[SYS_RULE] ([Rule_ID], [Rule_Name], [Rule_NameEn], [Description], [Active]) VALUES (N'export', N'Xuất khẩu', NULL, NULL, 1)
INSERT [dbo].[SYS_RULE] ([Rule_ID], [Rule_Name], [Rule_NameEn], [Description], [Active]) VALUES (N'find', N'Tìm kiếm', NULL, NULL, 1)
INSERT [dbo].[SYS_RULE] ([Rule_ID], [Rule_Name], [Rule_NameEn], [Description], [Active]) VALUES (N'import', N'Nhập khẩu', NULL, NULL, 1)
INSERT [dbo].[SYS_RULE] ([Rule_ID], [Rule_Name], [Rule_NameEn], [Description], [Active]) VALUES (N'post', N'Gửi', NULL, NULL, 1)
INSERT [dbo].[SYS_RULE] ([Rule_ID], [Rule_Name], [Rule_NameEn], [Description], [Active]) VALUES (N'print', N'In', NULL, NULL, 1)
INSERT [dbo].[SYS_RULE] ([Rule_ID], [Rule_Name], [Rule_NameEn], [Description], [Active]) VALUES (N'report', N'Báo cáo', NULL, NULL, 1)
INSERT [dbo].[SYS_RULE] ([Rule_ID], [Rule_Name], [Rule_NameEn], [Description], [Active]) VALUES (N'view', N'Xem', NULL, NULL, 1)
INSERT [dbo].[SYS_USER] ([UserID], [UserName], [Password], [Group_ID], [Description], [PartID], [Active], [Employee_ID]) VALUES (N'', N'kimnhut', N'123', N'aaaa', N'', N'', 1, N'NV0000001 ')
INSERT [dbo].[SYS_USER] ([UserID], [UserName], [Password], [Group_ID], [Description], [PartID], [Active], [Employee_ID]) VALUES (N'US000001', N'admin1', N'121', N'admin', NULL, NULL, 1, N'NV0000001 ')
INSERT [dbo].[SYS_USER] ([UserID], [UserName], [Password], [Group_ID], [Description], [PartID], [Active], [Employee_ID]) VALUES (N'US000002', N'admin2', N'122', N'admin', NULL, NULL, 1, NULL)
INSERT [dbo].[SYS_USER] ([UserID], [UserName], [Password], [Group_ID], [Description], [PartID], [Active], [Employee_ID]) VALUES (N'US000003', N'admin3', N'123', N'admin', NULL, NULL, 1, NULL)
INSERT [dbo].[SYS_USER] ([UserID], [UserName], [Password], [Group_ID], [Description], [PartID], [Active], [Employee_ID]) VALUES (N'US000004', N'admin4', N'124', N'admin', NULL, NULL, 1, NULL)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiAdjustment', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiBackup', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiChangepassword', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiCompanyInfo', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiCustomer', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiCustomerGroup', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiDepartment', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiEmployee', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiExchangeRate', N'view', 1, 1, 1, 0, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiExpire', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiFix', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiHistory', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiInitInventory', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiInventory', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiInventoryOrder', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiInventorySummary', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiInvoice', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiInward', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiItemGroup', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiLock', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiMaterial', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiOutward', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiPacket', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiPayment', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiPermission', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiPrintBarcode', N'view', 1, 1, 1, 0, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiProvider', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiPurchase', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiPurchaseReturn', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiReciept', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiReport', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiReportSale', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiRestore', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiSale', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiSaleReturn', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiStock', N'view', 1, 1, 1, 0, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiSysLog', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiTransfer', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiUnit', N'view', 1, 1, 1, 0, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiUnitConvert', N'view', 1, 1, 1, 0, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiUser', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiUserRule', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'bbiVoucherManager', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rbpDictionary', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rbpgClose', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rbpgDatabase', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rbpgDicStock', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rbpgInventory', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rbpgPartner', N'view', 1, 1, 1, 0, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rbpgSale', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rbpgSecurity', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rbpgStockOther', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rbpStock', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rbpSystem', N'view', 1, 1, 1, 0, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rpgDebt', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rpgDeparment', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rpgInvoice', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rpgReport', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'11aaaa', N'rpgTool', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiAdjustment', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiBackup', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiChangepassword', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiCompanyInfo', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiCustomer', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiCustomerGroup', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiDepartment', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiEmployee', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiExchangeRate', N'view', 1, 1, 1, 0, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiExpire', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiFix', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiHistory', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiInitInventory', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiInventory', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiInventoryOrder', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiInventorySummary', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiInvoice', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiInward', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiItemGroup', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiLock', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiMaterial', N'view', 1, 0, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiOutward', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiPacket', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiPayment', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiPermission', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiPrintBarcode', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiProvider', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiPurchase', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiPurchaseReturn', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiReciept', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiReport', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiReportSale', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiRestore', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiSale', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiSaleReturn', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiStock', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiSysLog', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiTransfer', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiUnit', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiUnitConvert', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiUser', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
GO
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiUserRule', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'bbiVoucherManager', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rbpDictionary', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rbpgClose', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rbpgDatabase', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rbpgDicStock', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rbpgInventory', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rbpgPartner', N'view', 1, 1, 1, 0, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rbpgSale', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rbpgSecurity', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rbpgStockOther', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rbpStock', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rbpSystem', N'view', 1, 1, 1, 0, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rpgDebt', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rpgDeparment', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rpgInvoice', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rpgReport', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'aaaa', N'rpgTool', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiAdjustment', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiBackup', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiChangepassword', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiCompanyInfo', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiCustomer', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiCustomerGroup', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiDepartment', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiEmployee', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiExchangeRate', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiExpire', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiFix', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiHistory', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiInitInventory', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiInventory', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiInventoryOrder', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiInventorySummary', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiInvoice', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiInward', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiItemGroup', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiLock', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiMaterial', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiOutward', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiPacket', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiPayment', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiPermission', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiPrintBarcode', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiProvider', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiPurchase', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiPurchaseReturn', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiReciept', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiReport', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiReportSale', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiRestore', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiSale', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiSaleReturn', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiStock', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiSysLog', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiTransfer', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiUnit', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiUnitConvert', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiUser', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiUserRule', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'bbiVoucherManager', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rbpDictionary', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rbpgClose', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rbpgDatabase', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rbpgDicStock', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rbpgInventory', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rbpgPartner', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rbpgSale', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rbpgSecurity', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rbpgStockOther', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rbpStock', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rbpSystem', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rpgDebt', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rpgDeparment', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rpgInvoice', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rpgReport', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'admin', N'rpgTool', N'view', 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiAdjustment', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiBackup', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiChangepassword', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiCompanyInfo', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiCustomer', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiCustomerGroup', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiDepartment', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiEmployee', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiExchangeRate', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiExpire', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiFix', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiHistory', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiInitInventory', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiInventory', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiInventoryOrder', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiInventorySummary', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiInvoice', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiInward', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiItemGroup', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiLock', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiMaterial', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiOutward', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiPacket', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
GO
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiPayment', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiPermission', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiPrintBarcode', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiProvider', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiPurchase', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiPurchaseReturn', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiReciept', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiReport', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiReportSale', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiRestore', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiSale', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiSaleReturn', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiStock', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiSysLog', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiTransfer', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiUnit', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiUnitConvert', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiUser', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiUserRule', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'bbiVoucherManager', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rbpDictionary', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rbpgClose', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rbpgDatabase', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rbpgDicStock', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rbpgInventory', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rbpgPartner', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rbpgSale', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rbpgSecurity', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rbpgStockOther', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rbpStock', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rbpSystem', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rpgDebt', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rpgDeparment', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rpgInvoice', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rpgReport', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[SYS_USER_RULE] ([Goup_ID], [Object_ID], [Rule_ID], [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport], [Active]) VALUES (N'bbb', N'rpgTool', N'view', 1, 1, 1, 1, 1, 1, 1, 0)
USE [master]
GO
ALTER DATABASE [UDQL1_DA] SET  READ_WRITE 
GO
