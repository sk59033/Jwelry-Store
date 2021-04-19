USE [master]
GO

/****** Object:  Database [JwelryStore]    Script Date: 19-04-2021 18:58:02 ******/
CREATE DATABASE [JwelryStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JwelryStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\JwelryStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JwelryStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\JwelryStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JwelryStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [JwelryStore] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [JwelryStore] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [JwelryStore] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [JwelryStore] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [JwelryStore] SET ARITHABORT OFF 
GO

ALTER DATABASE [JwelryStore] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [JwelryStore] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [JwelryStore] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [JwelryStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [JwelryStore] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [JwelryStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [JwelryStore] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [JwelryStore] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [JwelryStore] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [JwelryStore] SET  DISABLE_BROKER 
GO

ALTER DATABASE [JwelryStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [JwelryStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [JwelryStore] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [JwelryStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [JwelryStore] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [JwelryStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [JwelryStore] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [JwelryStore] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [JwelryStore] SET  MULTI_USER 
GO

ALTER DATABASE [JwelryStore] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [JwelryStore] SET DB_CHAINING OFF 
GO

ALTER DATABASE [JwelryStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [JwelryStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [JwelryStore] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [JwelryStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [JwelryStore] SET QUERY_STORE = OFF
GO

ALTER DATABASE [JwelryStore] SET  READ_WRITE 
GO

