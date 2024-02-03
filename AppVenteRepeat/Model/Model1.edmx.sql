    
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/27/2024 10:52:43
-- Generated from EDMX file: C:\Users\ibrab\Desktop\School\L3GL_ISI\C sharp\AppVente\AppVenteRepeat\AppVenteRepeat\Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [bdVente];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[categories];
GO
IF OBJECT_ID(N'[dbo].[Produit1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produit1];
GO
IF OBJECT_ID(N'[dbo].[Profils]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Profils];
GO
IF OBJECT_ID(N'[dbo].[Utilisateurs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Utilisateurs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'categories'
CREATE TABLE [dbo].[categories] (
    [idCategorie] int IDENTITY(1,1) NOT NULL,
    [codeCategorie] nvarchar(5)  NULL,
    [libelleCategorie] nvarchar(100)  NULL
);
GO

-- Creating table 'Produit1'
CREATE TABLE [dbo].[Produit1] (
    [idProduit] int IDENTITY(1,1) NOT NULL,
    [codeProduit] nvarchar(5)  NULL,
    [nomProduit] nvarchar(50)  NULL,
    [prixUnitaire] float  NULL,
    [qteMin] int  NULL,
    [qteCri] int  NULL,
    [codeCategorie] nvarchar(5)  NULL
);
GO

-- Creating table 'Profils'
CREATE TABLE [dbo].[Profils] (
    [idProfil] int IDENTITY(1,1) NOT NULL,
    [codeProfil] nvarchar(5)  NULL,
    [nomProfil] nvarchar(50)  NULL
);
GO

-- Creating table 'Utilisateurs'
CREATE TABLE [dbo].[Utilisateurs] (
    [idUtilisateur] int IDENTITY(1,1) NOT NULL,
    [codeUtilisateur] nvarchar(5)  NULL,
    [identifiant] nvarchar(50)  NULL,
    [motDePasse] nvarchar(50)  NULL,
    [codeProfil] nvarchar(5)  NULL,
    [email] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idCategorie] in table 'categories'
ALTER TABLE [dbo].[categories]
ADD CONSTRAINT [PK_categories]
    PRIMARY KEY CLUSTERED ([idCategorie] ASC);
GO

-- Creating primary key on [idProduit] in table 'Produit1'
ALTER TABLE [dbo].[Produit1]
ADD CONSTRAINT [PK_Produit1]
    PRIMARY KEY CLUSTERED ([idProduit] ASC);
GO

-- Creating primary key on [idProfil] in table 'Profils'
ALTER TABLE [dbo].[Profils]
ADD CONSTRAINT [PK_Profils]
    PRIMARY KEY CLUSTERED ([idProfil] ASC);
GO

-- Creating primary key on [idUtilisateur] in table 'Utilisateurs'
ALTER TABLE [dbo].[Utilisateurs]
ADD CONSTRAINT [PK_Utilisateurs]
    PRIMARY KEY CLUSTERED ([idUtilisateur] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------