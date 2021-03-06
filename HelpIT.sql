USE [master]
GO
/****** Object:  Database [HelpIT]    Script Date: 02.06.2022 2:27:22 ******/
CREATE DATABASE [HelpIT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KursBar', FILENAME = N'D:\SSMS\MSSQL15.SQLEXPRESS\MSSQL\DATA\KursBar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KursBar_log', FILENAME = N'D:\SSMS\MSSQL15.SQLEXPRESS\MSSQL\DATA\KursBar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HelpIT] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HelpIT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HelpIT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HelpIT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HelpIT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HelpIT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HelpIT] SET ARITHABORT OFF 
GO
ALTER DATABASE [HelpIT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HelpIT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HelpIT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HelpIT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HelpIT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HelpIT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HelpIT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HelpIT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HelpIT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HelpIT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HelpIT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HelpIT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HelpIT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HelpIT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HelpIT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HelpIT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HelpIT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HelpIT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HelpIT] SET  MULTI_USER 
GO
ALTER DATABASE [HelpIT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HelpIT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HelpIT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HelpIT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HelpIT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HelpIT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HelpIT] SET QUERY_STORE = OFF
GO
USE [HelpIT]
GO
/****** Object:  Table [dbo].[Criticality]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Criticality](
	[ID_Criticality] [int] IDENTITY(1,1) NOT NULL,
	[Описание] [nvarchar](50) NULL,
 CONSTRAINT [PK_Категоричность] PRIMARY KEY CLUSTERED 
(
	[ID_Criticality] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpPost]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpPost](
	[ID_Emp_Post] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](50) NULL,
 CONSTRAINT [PK_EmpPost] PRIMARY KEY CLUSTERED 
(
	[ID_Emp_Post] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[ID_Gender] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[ID_Gender] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hardware]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hardware](
	[ID_Hardware] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](150) NOT NULL,
	[ДатаУстановки] [date] NOT NULL,
	[ID_IT_Employees] [int] NOT NULL,
	[ID_Repair] [int] NOT NULL,
	[ДатаПоследнегоРемонта] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Оборудование] PRIMARY KEY CLUSTERED 
(
	[ID_Hardware] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IT_Employees]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IT_Employees](
	[ID_IT_Employees] [int] IDENTITY(1,1) NOT NULL,
	[Фамилия] [nvarchar](50) NULL,
	[Имя] [nvarchar](50) NULL,
	[Отчество] [nvarchar](50) NULL,
	[ID_Emp_Post] [int] NOT NULL,
 CONSTRAINT [PK_Сотрудники ИТ] PRIMARY KEY CLUSTERED 
(
	[ID_IT_Employees] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Office]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Office](
	[ID_Office] [int] IDENTITY(1,1) NOT NULL,
	[Адрес] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Одел] PRIMARY KEY CLUSTERED 
(
	[ID_Office] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quest]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quest](
	[ID_Quest] [int] IDENTITY(1,1) NOT NULL,
	[ID_User] [nvarchar](50) NULL,
	[Приоритет] [int] NULL,
	[НомерКабинета] [nvarchar](10) NULL,
	[ID_TypeOfProblem] [int] NULL,
	[ID_Office] [int] NULL,
	[ID_Hardware] [int] NULL,
	[СрочностьВыполнения] [int] NULL,
	[ОписаниеПроблемы] [nvarchar](350) NULL,
	[ДатаПодачи] [date] NULL,
	[ID_Criticality] [int] NULL,
	[ДатаПринятия] [date] NULL,
	[ДатаЗакрытия] [date] NULL,
	[СтатусЗаявкиID] [int] NULL,
 CONSTRAINT [PK_Quest] PRIMARY KEY CLUSTERED 
(
	[ID_Quest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repair]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repair](
	[ID_Repair] [int] IDENTITY(1,1) NOT NULL,
	[ПричинаРемонта] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Repair] PRIMARY KEY CLUSTERED 
(
	[ID_Repair] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Report]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report](
	[ID_Report] [int] IDENTITY(1,1) NOT NULL,
	[ID_Quest] [int] NULL,
	[Описание] [nvarchar](50) NULL,
	[ДатаНаписания] [date] NULL,
	[ID_IT_Employees] [int] NULL,
 CONSTRAINT [PK_Report] PRIMARY KEY CLUSTERED 
(
	[ID_Report] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID_Role] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID_Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[ID_Status] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](50) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[ID_Status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfProblem]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfProblem](
	[ID_TypeOfProblem] [int] IDENTITY(1,1) NOT NULL,
	[ТипПроблемы] [nvarchar](50) NULL,
 CONSTRAINT [PK_Тип проблемы] PRIMARY KEY CLUSTERED 
(
	[ID_TypeOfProblem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 02.06.2022 2:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID_User] [int] IDENTITY(1,1) NOT NULL,
	[Фамилия] [nvarchar](50) NULL,
	[Имя] [nvarchar](50) NULL,
	[Отчество] [nvarchar](50) NULL,
	[ID_Office] [int] NOT NULL,
	[ID_Role] [int] NOT NULL,
	[Дата_Рождения] [nvarchar](50) NULL,
	[Почта] [nvarchar](50) NULL,
	[ID_Gender] [int] NOT NULL,
	[Логин] [nvarchar](50) NOT NULL,
	[Пароль] [nvarchar](50) NOT NULL,
	[Телефон] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Логин] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Criticality] ON 

INSERT [dbo].[Criticality] ([ID_Criticality], [Описание]) VALUES (1, N'Вызывает незначительный дискомфорт')
INSERT [dbo].[Criticality] ([ID_Criticality], [Описание]) VALUES (2, N'Вызывает значительный дискомфорт')
INSERT [dbo].[Criticality] ([ID_Criticality], [Описание]) VALUES (3, N'Напрямую не влияет на основные процессы')
INSERT [dbo].[Criticality] ([ID_Criticality], [Описание]) VALUES (4, N'Возможны нарушения в работе')
INSERT [dbo].[Criticality] ([ID_Criticality], [Описание]) VALUES (5, N'Вызывает нарушение в работе')
SET IDENTITY_INSERT [dbo].[Criticality] OFF
GO
SET IDENTITY_INSERT [dbo].[EmpPost] ON 

INSERT [dbo].[EmpPost] ([ID_Emp_Post], [Наименование]) VALUES (1, N'Руководитель ИТ-отдела')
INSERT [dbo].[EmpPost] ([ID_Emp_Post], [Наименование]) VALUES (2, N'Системный администратор')
INSERT [dbo].[EmpPost] ([ID_Emp_Post], [Наименование]) VALUES (3, N'Специалист по поддержке пользователей')
INSERT [dbo].[EmpPost] ([ID_Emp_Post], [Наименование]) VALUES (4, N'Специалист по сетевому обеспечению')
SET IDENTITY_INSERT [dbo].[EmpPost] OFF
GO
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([ID_Gender], [Наименование]) VALUES (1, N'М')
INSERT [dbo].[Gender] ([ID_Gender], [Наименование]) VALUES (2, N'Ж')
SET IDENTITY_INSERT [dbo].[Gender] OFF
GO
SET IDENTITY_INSERT [dbo].[Hardware] ON 

INSERT [dbo].[Hardware] ([ID_Hardware], [Наименование], [ДатаУстановки], [ID_IT_Employees], [ID_Repair], [ДатаПоследнегоРемонта]) VALUES (1, N'Лазерное МФУ Pantum M6500', CAST(N'2020-10-25' AS Date), 1, 1, N'27.11.2021')
INSERT [dbo].[Hardware] ([ID_Hardware], [Наименование], [ДатаУстановки], [ID_IT_Employees], [ID_Repair], [ДатаПоследнегоРемонта]) VALUES (2, N'МФУ струйное Epson L3101', CAST(N'2021-07-24' AS Date), 2, 1, N'28.01.2022')
INSERT [dbo].[Hardware] ([ID_Hardware], [Наименование], [ДатаУстановки], [ID_IT_Employees], [ID_Repair], [ДатаПоследнегоРемонта]) VALUES (3, N'МФУ струйный HP DeskJet Ink Advantage Ultra 4828 (25R76A)', CAST(N'2019-11-21' AS Date), 3, 1, N'23.01.2021')
SET IDENTITY_INSERT [dbo].[Hardware] OFF
GO
SET IDENTITY_INSERT [dbo].[IT_Employees] ON 

INSERT [dbo].[IT_Employees] ([ID_IT_Employees], [Фамилия], [Имя], [Отчество], [ID_Emp_Post]) VALUES (1, N'Барциц', N'Максим', N'Вячеславович', 2)
INSERT [dbo].[IT_Employees] ([ID_IT_Employees], [Фамилия], [Имя], [Отчество], [ID_Emp_Post]) VALUES (2, N'Панфилов', N'Май', N'Евсеевич', 3)
INSERT [dbo].[IT_Employees] ([ID_IT_Employees], [Фамилия], [Имя], [Отчество], [ID_Emp_Post]) VALUES (3, N'Потапов', N'Юлий', N'Игнатьевич', 4)
INSERT [dbo].[IT_Employees] ([ID_IT_Employees], [Фамилия], [Имя], [Отчество], [ID_Emp_Post]) VALUES (4, N'Панфилов', N'Донат', N'Семенович', 3)
INSERT [dbo].[IT_Employees] ([ID_IT_Employees], [Фамилия], [Имя], [Отчество], [ID_Emp_Post]) VALUES (5, N'Терентьев', N'Власий', N'Артемович', 4)
INSERT [dbo].[IT_Employees] ([ID_IT_Employees], [Фамилия], [Имя], [Отчество], [ID_Emp_Post]) VALUES (6, N'Сергеев', N'Азарий', N'Эльдарович', 3)
INSERT [dbo].[IT_Employees] ([ID_IT_Employees], [Фамилия], [Имя], [Отчество], [ID_Emp_Post]) VALUES (7, N'Гусева', N'Маргарита', N'Аркадьевна', 3)
INSERT [dbo].[IT_Employees] ([ID_IT_Employees], [Фамилия], [Имя], [Отчество], [ID_Emp_Post]) VALUES (8, N'Журавлёва', N'Иоланта', N'Дмитриевна', 3)
INSERT [dbo].[IT_Employees] ([ID_IT_Employees], [Фамилия], [Имя], [Отчество], [ID_Emp_Post]) VALUES (9, N'Иванкова', N'Эжени', N'Рудольфовна', 4)
INSERT [dbo].[IT_Employees] ([ID_IT_Employees], [Фамилия], [Имя], [Отчество], [ID_Emp_Post]) VALUES (10, N'Дроздова', N'Винетта', N'Даниловна', 3)
INSERT [dbo].[IT_Employees] ([ID_IT_Employees], [Фамилия], [Имя], [Отчество], [ID_Emp_Post]) VALUES (11, N'Силина', N'Альжбета', N'Давидовна', 3)
SET IDENTITY_INSERT [dbo].[IT_Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Office] ON 

INSERT [dbo].[Office] ([ID_Office], [Адрес]) VALUES (1, N'Боровское ш., 20, Москва, Россия')
INSERT [dbo].[Office] ([ID_Office], [Адрес]) VALUES (2, N'Профсоюзная ул., 93А, Москва, Россия (этаж 1)')
INSERT [dbo].[Office] ([ID_Office], [Адрес]) VALUES (3, N'Каширское ш., 94, корп. 1, Москва, Россия (этаж 2)')
INSERT [dbo].[Office] ([ID_Office], [Адрес]) VALUES (4, N'Электролитный пр., 3, стр. 32, Москва, Россия')
INSERT [dbo].[Office] ([ID_Office], [Адрес]) VALUES (5, N'Нахимовский просп., 25А, Москва, Россия')
INSERT [dbo].[Office] ([ID_Office], [Адрес]) VALUES (6, N'Осенний бул., 16, корп. 1, Москва, Россия')
INSERT [dbo].[Office] ([ID_Office], [Адрес]) VALUES (7, N'ул. Маршала Малиновского, 6, корп. 1, Москва, Россия')
INSERT [dbo].[Office] ([ID_Office], [Адрес]) VALUES (8, N'Зубовский бул., 17, Москва, Россия')
INSERT [dbo].[Office] ([ID_Office], [Адрес]) VALUES (9, N'пр. Русанова, 2, стр. 1, Москва, Россия')
INSERT [dbo].[Office] ([ID_Office], [Адрес]) VALUES (10, N'9-я Парковая ул., 59, корп. 1, Москва, Россия')
SET IDENTITY_INSERT [dbo].[Office] OFF
GO
SET IDENTITY_INSERT [dbo].[Quest] ON 

INSERT [dbo].[Quest] ([ID_Quest], [ID_User], [Приоритет], [НомерКабинета], [ID_TypeOfProblem], [ID_Office], [ID_Hardware], [СрочностьВыполнения], [ОписаниеПроблемы], [ДатаПодачи], [ID_Criticality], [ДатаПринятия], [ДатаЗакрытия], [СтатусЗаявкиID]) VALUES (3, NULL, NULL, N'1', 1, 1, 1, NULL, N' dsf', CAST(N'2022-05-31' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Quest] ([ID_Quest], [ID_User], [Приоритет], [НомерКабинета], [ID_TypeOfProblem], [ID_Office], [ID_Hardware], [СрочностьВыполнения], [ОписаниеПроблемы], [ДатаПодачи], [ID_Criticality], [ДатаПринятия], [ДатаЗакрытия], [СтатусЗаявкиID]) VALUES (4, NULL, NULL, N'1', 1, 1, 1, NULL, N' dsf', CAST(N'2022-05-31' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Quest] ([ID_Quest], [ID_User], [Приоритет], [НомерКабинета], [ID_TypeOfProblem], [ID_Office], [ID_Hardware], [СрочностьВыполнения], [ОписаниеПроблемы], [ДатаПодачи], [ID_Criticality], [ДатаПринятия], [ДатаЗакрытия], [СтатусЗаявкиID]) VALUES (5, NULL, NULL, N'1', 1, 1, 1, NULL, N'sdfsdf', CAST(N'2022-05-31' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Quest] ([ID_Quest], [ID_User], [Приоритет], [НомерКабинета], [ID_TypeOfProblem], [ID_Office], [ID_Hardware], [СрочностьВыполнения], [ОписаниеПроблемы], [ДатаПодачи], [ID_Criticality], [ДатаПринятия], [ДатаЗакрытия], [СтатусЗаявкиID]) VALUES (6, NULL, NULL, N'', 1, 1, 1, NULL, N'', CAST(N'2022-06-02' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Quest] ([ID_Quest], [ID_User], [Приоритет], [НомерКабинета], [ID_TypeOfProblem], [ID_Office], [ID_Hardware], [СрочностьВыполнения], [ОписаниеПроблемы], [ДатаПодачи], [ID_Criticality], [ДатаПринятия], [ДатаЗакрытия], [СтатусЗаявкиID]) VALUES (7, NULL, NULL, N'', 1, 1, 1, NULL, N'', CAST(N'2022-06-02' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Quest] ([ID_Quest], [ID_User], [Приоритет], [НомерКабинета], [ID_TypeOfProblem], [ID_Office], [ID_Hardware], [СрочностьВыполнения], [ОписаниеПроблемы], [ДатаПодачи], [ID_Criticality], [ДатаПринятия], [ДатаЗакрытия], [СтатусЗаявкиID]) VALUES (8, NULL, NULL, N'', 1, 1, 1, NULL, N'', CAST(N'2022-06-02' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Quest] ([ID_Quest], [ID_User], [Приоритет], [НомерКабинета], [ID_TypeOfProblem], [ID_Office], [ID_Hardware], [СрочностьВыполнения], [ОписаниеПроблемы], [ДатаПодачи], [ID_Criticality], [ДатаПринятия], [ДатаЗакрытия], [СтатусЗаявкиID]) VALUES (9, NULL, NULL, N'', 1, 3, 2, NULL, N'', CAST(N'2022-06-02' AS Date), 4, NULL, NULL, NULL)
INSERT [dbo].[Quest] ([ID_Quest], [ID_User], [Приоритет], [НомерКабинета], [ID_TypeOfProblem], [ID_Office], [ID_Hardware], [СрочностьВыполнения], [ОписаниеПроблемы], [ДатаПодачи], [ID_Criticality], [ДатаПринятия], [ДатаЗакрытия], [СтатусЗаявкиID]) VALUES (10, NULL, NULL, N'', 1, 5, 1, NULL, N'', CAST(N'2022-06-02' AS Date), 1, NULL, NULL, NULL)
INSERT [dbo].[Quest] ([ID_Quest], [ID_User], [Приоритет], [НомерКабинета], [ID_TypeOfProblem], [ID_Office], [ID_Hardware], [СрочностьВыполнения], [ОписаниеПроблемы], [ДатаПодачи], [ID_Criticality], [ДатаПринятия], [ДатаЗакрытия], [СтатусЗаявкиID]) VALUES (11, NULL, NULL, N'', 1, 1, 1, NULL, N'', CAST(N'2022-06-02' AS Date), 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Quest] OFF
GO
SET IDENTITY_INSERT [dbo].[Repair] ON 

INSERT [dbo].[Repair] ([ID_Repair], [ПричинаРемонта]) VALUES (1, N'Проверка системы')
INSERT [dbo].[Repair] ([ID_Repair], [ПричинаРемонта]) VALUES (2, N'Замен картриджей')
SET IDENTITY_INSERT [dbo].[Repair] OFF
GO
SET IDENTITY_INSERT [dbo].[Report] ON 

INSERT [dbo].[Report] ([ID_Report], [ID_Quest], [Описание], [ДатаНаписания], [ID_IT_Employees]) VALUES (2, 3, N'Заявка выполнена без проблем', CAST(N'2022-06-01' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Report] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID_Role], [Наименование]) VALUES (1, N'1')
INSERT [dbo].[Role] ([ID_Role], [Наименование]) VALUES (2, N'Сотрудник ИТ-отдела')
INSERT [dbo].[Role] ([ID_Role], [Наименование]) VALUES (3, N'Пользователь')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([ID_Status], [Наименование]) VALUES (1, N'На рассмотрении')
INSERT [dbo].[Status] ([ID_Status], [Наименование]) VALUES (2, N'Исполняется')
INSERT [dbo].[Status] ([ID_Status], [Наименование]) VALUES (3, N'Закрыта')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeOfProblem] ON 

INSERT [dbo].[TypeOfProblem] ([ID_TypeOfProblem], [ТипПроблемы]) VALUES (1, N'Очень шумно работает вентилятор')
INSERT [dbo].[TypeOfProblem] ([ID_TypeOfProblem], [ТипПроблемы]) VALUES (2, N'На мониторе видны полоски')
INSERT [dbo].[TypeOfProblem] ([ID_TypeOfProblem], [ТипПроблемы]) VALUES (3, N'Периодически пропадает жесткий диск')
INSERT [dbo].[TypeOfProblem] ([ID_TypeOfProblem], [ТипПроблемы]) VALUES (4, N'Тормозит компьютер')
INSERT [dbo].[TypeOfProblem] ([ID_TypeOfProblem], [ТипПроблемы]) VALUES (5, N'Закончилась краска')
SET IDENTITY_INSERT [dbo].[TypeOfProblem] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID_User], [Фамилия], [Имя], [Отчество], [ID_Office], [ID_Role], [Дата_Рождения], [Почта], [ID_Gender], [Логин], [Пароль], [Телефон]) VALUES (4, N'Барциц ', N'Максим', N'Вячеславович', 4, 1, N'31 мая 2022 г.', N'megapochta650@gmail.com', 1, N'admin', N'admin', NULL)
INSERT [dbo].[User] ([ID_User], [Фамилия], [Имя], [Отчество], [ID_Office], [ID_Role], [Дата_Рождения], [Почта], [ID_Gender], [Логин], [Пароль], [Телефон]) VALUES (3, N'Барциц', N'sf', N'df', 4, 2, N'1 августа 1949 г.', N'megap', 2, N'dfs', N'12', N'+7 (977) 325 -12 -85  ')
INSERT [dbo].[User] ([ID_User], [Фамилия], [Имя], [Отчество], [ID_Office], [ID_Role], [Дата_Рождения], [Почта], [ID_Gender], [Логин], [Пароль], [Телефон]) VALUES (2, N'Барцис', N'Максим', N'Вячеславович', 1, 3, N'31 мая 2022 г.', N'megp', 1, N'Maksim', N'maksim', N'+7 (977) 325 -12 -85  ')
INSERT [dbo].[User] ([ID_User], [Фамилия], [Имя], [Отчество], [ID_Office], [ID_Role], [Дата_Рождения], [Почта], [ID_Gender], [Логин], [Пароль], [Телефон]) VALUES (0, N'Иванов', N'Ренат', N'Макарович', 1, 1, N'30 мая 2022 г.', N'reamak@mail.ru', 1, N'Ren', N'RenMak', NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Hardware]  WITH CHECK ADD  CONSTRAINT [FK_Hardware_IT_Employees] FOREIGN KEY([ID_IT_Employees])
REFERENCES [dbo].[IT_Employees] ([ID_IT_Employees])
GO
ALTER TABLE [dbo].[Hardware] CHECK CONSTRAINT [FK_Hardware_IT_Employees]
GO
ALTER TABLE [dbo].[Hardware]  WITH CHECK ADD  CONSTRAINT [FK_Hardware_Repair] FOREIGN KEY([ID_Repair])
REFERENCES [dbo].[Repair] ([ID_Repair])
GO
ALTER TABLE [dbo].[Hardware] CHECK CONSTRAINT [FK_Hardware_Repair]
GO
ALTER TABLE [dbo].[IT_Employees]  WITH CHECK ADD  CONSTRAINT [FK_IT_Employees_EmpPost] FOREIGN KEY([ID_Emp_Post])
REFERENCES [dbo].[EmpPost] ([ID_Emp_Post])
GO
ALTER TABLE [dbo].[IT_Employees] CHECK CONSTRAINT [FK_IT_Employees_EmpPost]
GO
ALTER TABLE [dbo].[Quest]  WITH CHECK ADD  CONSTRAINT [FK_Quest_Criticality1] FOREIGN KEY([ID_Criticality])
REFERENCES [dbo].[Criticality] ([ID_Criticality])
GO
ALTER TABLE [dbo].[Quest] CHECK CONSTRAINT [FK_Quest_Criticality1]
GO
ALTER TABLE [dbo].[Quest]  WITH CHECK ADD  CONSTRAINT [FK_Quest_Hardware] FOREIGN KEY([ID_Hardware])
REFERENCES [dbo].[Hardware] ([ID_Hardware])
GO
ALTER TABLE [dbo].[Quest] CHECK CONSTRAINT [FK_Quest_Hardware]
GO
ALTER TABLE [dbo].[Quest]  WITH CHECK ADD  CONSTRAINT [FK_Quest_Office] FOREIGN KEY([ID_Office])
REFERENCES [dbo].[Office] ([ID_Office])
GO
ALTER TABLE [dbo].[Quest] CHECK CONSTRAINT [FK_Quest_Office]
GO
ALTER TABLE [dbo].[Quest]  WITH CHECK ADD  CONSTRAINT [FK_Quest_Office1] FOREIGN KEY([ID_Office])
REFERENCES [dbo].[Office] ([ID_Office])
GO
ALTER TABLE [dbo].[Quest] CHECK CONSTRAINT [FK_Quest_Office1]
GO
ALTER TABLE [dbo].[Quest]  WITH CHECK ADD  CONSTRAINT [FK_Quest_Status] FOREIGN KEY([СтатусЗаявкиID])
REFERENCES [dbo].[Status] ([ID_Status])
GO
ALTER TABLE [dbo].[Quest] CHECK CONSTRAINT [FK_Quest_Status]
GO
ALTER TABLE [dbo].[Quest]  WITH CHECK ADD  CONSTRAINT [FK_Quest_TypeOfProblem] FOREIGN KEY([ID_TypeOfProblem])
REFERENCES [dbo].[TypeOfProblem] ([ID_TypeOfProblem])
GO
ALTER TABLE [dbo].[Quest] CHECK CONSTRAINT [FK_Quest_TypeOfProblem]
GO
ALTER TABLE [dbo].[Report]  WITH CHECK ADD  CONSTRAINT [FK_Report_IT_Employees] FOREIGN KEY([ID_IT_Employees])
REFERENCES [dbo].[IT_Employees] ([ID_IT_Employees])
GO
ALTER TABLE [dbo].[Report] CHECK CONSTRAINT [FK_Report_IT_Employees]
GO
ALTER TABLE [dbo].[Report]  WITH CHECK ADD  CONSTRAINT [FK_Report_Quest] FOREIGN KEY([ID_Quest])
REFERENCES [dbo].[Quest] ([ID_Quest])
GO
ALTER TABLE [dbo].[Report] CHECK CONSTRAINT [FK_Report_Quest]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Gender] FOREIGN KEY([ID_Gender])
REFERENCES [dbo].[Gender] ([ID_Gender])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Gender]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Office] FOREIGN KEY([ID_Office])
REFERENCES [dbo].[Office] ([ID_Office])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Office]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([ID_Role])
REFERENCES [dbo].[Role] ([ID_Role])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [HelpIT] SET  READ_WRITE 
GO
