
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/03/2017 09:44:36
-- Generated from EDMX file: C:\Users\Damian\Source\Repos\SE24\MUE\MUE\Models\MARCOModels.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db562cddb93b5540c7ac57a71600deabc4];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__COLLABORA__Proje__5629CD9C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[COLLABORATOR] DROP CONSTRAINT [FK__COLLABORA__Proje__5629CD9C];
GO
IF OBJECT_ID(N'[dbo].[FK__COLLABORA__UserI__5535A963]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[COLLABORATOR] DROP CONSTRAINT [FK__COLLABORA__UserI__5535A963];
GO
IF OBJECT_ID(N'[dbo].[FK__CONVERSAT__Messa__09A971A2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CONVERSATION] DROP CONSTRAINT [FK__CONVERSAT__Messa__09A971A2];
GO
IF OBJECT_ID(N'[dbo].[FK__CONVERSAT__USERI__08B54D69]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CONVERSATION] DROP CONSTRAINT [FK__CONVERSAT__USERI__08B54D69];
GO
IF OBJECT_ID(N'[dbo].[FK__Message__USERID__7C4F7684]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Message] DROP CONSTRAINT [FK__Message__USERID__7C4F7684];
GO
IF OBJECT_ID(N'[dbo].[FK__POST__USERID__38996AB5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[POST] DROP CONSTRAINT [FK__POST__USERID__38996AB5];
GO
IF OBJECT_ID(N'[dbo].[FK__PROJECTTY__CATAG__5EBF139D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PROJECTTYPE] DROP CONSTRAINT [FK__PROJECTTY__CATAG__5EBF139D];
GO
IF OBJECT_ID(N'[dbo].[FK__PROJECTTY__PROJE__5FB337D6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PROJECTTYPE] DROP CONSTRAINT [FK__PROJECTTY__PROJE__5FB337D6];
GO
IF OBJECT_ID(N'[dbo].[FK__REPLY__ID__403A8C7D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REPLY] DROP CONSTRAINT [FK__REPLY__ID__403A8C7D];
GO
IF OBJECT_ID(N'[dbo].[FK__REPLY__REPLIED_T__412EB0B6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[REPLY] DROP CONSTRAINT [FK__REPLY__REPLIED_T__412EB0B6];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[fk_expertID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SPECIALTY] DROP CONSTRAINT [fk_expertID];
GO
IF OBJECT_ID(N'[dbo].[FK_PARENTID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EXPERT] DROP CONSTRAINT [FK_PARENTID];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AspNetRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserClaims];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserLogins];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[CATAGORY]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CATAGORY];
GO
IF OBJECT_ID(N'[dbo].[COLLABORATOR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[COLLABORATOR];
GO
IF OBJECT_ID(N'[dbo].[CONVERSATION]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CONVERSATION];
GO
IF OBJECT_ID(N'[dbo].[EXPERT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EXPERT];
GO
IF OBJECT_ID(N'[dbo].[Message]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Message];
GO
IF OBJECT_ID(N'[dbo].[POST]', 'U') IS NOT NULL
    DROP TABLE [dbo].[POST];
GO
IF OBJECT_ID(N'[dbo].[PROJECT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PROJECT];
GO
IF OBJECT_ID(N'[dbo].[PROJECTTYPE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PROJECTTYPE];
GO
IF OBJECT_ID(N'[dbo].[REPLY]', 'U') IS NOT NULL
    DROP TABLE [dbo].[REPLY];
GO
IF OBJECT_ID(N'[dbo].[SPECIALTY]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SPECIALTY];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AspNetRoles'
CREATE TABLE [dbo].[AspNetRoles] (
    [Id] nvarchar(128)  NOT NULL,
    [Name] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'AspNetUserClaims'
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(128)  NOT NULL,
    [ClaimType] nvarchar(max)  NULL,
    [ClaimValue] nvarchar(max)  NULL
);
GO

-- Creating table 'AspNetUserLogins'
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] nvarchar(128)  NOT NULL,
    [ProviderKey] nvarchar(128)  NOT NULL,
    [UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'AspNetUsers'
CREATE TABLE [dbo].[AspNetUsers] (
    [Id] nvarchar(128)  NOT NULL,
    [disabled] bit  NOT NULL,
    [FirstName] nvarchar(max)  NULL,
    [LastName] nvarchar(max)  NULL,
    [Email] nvarchar(256)  NULL,
    [EmailConfirmed] bit  NOT NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [PhoneNumberConfirmed] bit  NOT NULL,
    [TwoFactorEnabled] bit  NOT NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [LockoutEnabled] bit  NOT NULL,
    [AccessFailedCount] int  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL,
    [Discriminator] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'CATAGORies'
CREATE TABLE [dbo].[CATAGORies] (
    [ID] int  NOT NULL,
    [NAME] nvarchar(64)  NOT NULL,
    [DESCRIPTION] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CONVERSATIONs'
CREATE TABLE [dbo].[CONVERSATIONs] (
    [ID] int  NOT NULL,
    [LASTSEEN] datetime  NULL,
    [STARTED] datetime  NULL,
    [SUBJECT] nvarchar(128)  NULL,
    [USERIDs] nvarchar(128)  NULL,
    [MessageIDs] int  NULL
);
GO

-- Creating table 'EXPERTs'
CREATE TABLE [dbo].[EXPERTs] (
    [ID] nvarchar(128)  NOT NULL,
    [VALIDATED] bit  NULL,
    [PARENTID] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'Messages'
CREATE TABLE [dbo].[Messages] (
    [ID] int  NOT NULL,
    [USERID] nvarchar(128)  NOT NULL,
    [DATETIMEMADE] datetime  NOT NULL,
    [TEXT] nvarchar(max)  NULL
);
GO

-- Creating table 'POSTs'
CREATE TABLE [dbo].[POSTs] (
    [ID] int  NOT NULL,
    [USERID] nvarchar(128)  NOT NULL,
    [SUBJECT] nvarchar(20)  NOT NULL,
    [TITLE] nvarchar(20)  NOT NULL,
    [DATETIMEPOSTED] datetime  NOT NULL,
    [REPLY_POST_ID] int  NULL
);
GO

-- Creating table 'PROJECTs'
CREATE TABLE [dbo].[PROJECTs] (
    [ID] int  NOT NULL,
    [COMPLETED] bit  NOT NULL,
    [DATCOMPLETED] datetime  NULL,
    [TITLE] nvarchar(40)  NOT NULL,
    [STARTDATE] datetime  NULL,
    [DESCRIPTION] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SPECIALTies'
CREATE TABLE [dbo].[SPECIALTies] (
    [ID] nvarchar(max)  NOT NULL,
    [NAME] nvarchar(64)  NOT NULL,
    [DESCRIPTION] nvarchar(max)  NOT NULL,
    [expertID] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'AspNetUserRoles'
CREATE TABLE [dbo].[AspNetUserRoles] (
    [AspNetRoles_Id] nvarchar(128)  NOT NULL,
    [AspNetUsers_Id] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'COLLABORATOR'
CREATE TABLE [dbo].[COLLABORATOR] (
    [PROJECTs_ID] int  NOT NULL,
    [AspNetUsers_Id] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'PROJECTTYPE'
CREATE TABLE [dbo].[PROJECTTYPE] (
    [CATAGORies_ID] int  NOT NULL,
    [PROJECTs_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AspNetRoles'
ALTER TABLE [dbo].[AspNetRoles]
ADD CONSTRAINT [PK_AspNetRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [PK_AspNetUserClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [LoginProvider], [ProviderKey], [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [PK_AspNetUserLogins]
    PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey], [UserId] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUsers'
ALTER TABLE [dbo].[AspNetUsers]
ADD CONSTRAINT [PK_AspNetUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ID] in table 'CATAGORies'
ALTER TABLE [dbo].[CATAGORies]
ADD CONSTRAINT [PK_CATAGORies]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CONVERSATIONs'
ALTER TABLE [dbo].[CONVERSATIONs]
ADD CONSTRAINT [PK_CONVERSATIONs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'EXPERTs'
ALTER TABLE [dbo].[EXPERTs]
ADD CONSTRAINT [PK_EXPERTs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [PK_Messages]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'POSTs'
ALTER TABLE [dbo].[POSTs]
ADD CONSTRAINT [PK_POSTs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PROJECTs'
ALTER TABLE [dbo].[PROJECTs]
ADD CONSTRAINT [PK_PROJECTs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID], [NAME] in table 'SPECIALTies'
ALTER TABLE [dbo].[SPECIALTies]
ADD CONSTRAINT [PK_SPECIALTies]
    PRIMARY KEY CLUSTERED ([ID], [NAME] ASC);
GO

-- Creating primary key on [AspNetRoles_Id], [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [PK_AspNetUserRoles]
    PRIMARY KEY CLUSTERED ([AspNetRoles_Id], [AspNetUsers_Id] ASC);
GO

-- Creating primary key on [PROJECTs_ID], [AspNetUsers_Id] in table 'COLLABORATOR'
ALTER TABLE [dbo].[COLLABORATOR]
ADD CONSTRAINT [PK_COLLABORATOR]
    PRIMARY KEY CLUSTERED ([PROJECTs_ID], [AspNetUsers_Id] ASC);
GO

-- Creating primary key on [CATAGORies_ID], [PROJECTs_ID] in table 'PROJECTTYPE'
ALTER TABLE [dbo].[PROJECTTYPE]
ADD CONSTRAINT [PK_PROJECTTYPE]
    PRIMARY KEY CLUSTERED ([CATAGORies_ID], [PROJECTs_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserClaims]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserLogins]
    ([UserId]);
GO

-- Creating foreign key on [USERIDs] in table 'CONVERSATIONs'
ALTER TABLE [dbo].[CONVERSATIONs]
ADD CONSTRAINT [FK__CONVERSAT__USERI__08B54D69]
    FOREIGN KEY ([USERIDs])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CONVERSAT__USERI__08B54D69'
CREATE INDEX [IX_FK__CONVERSAT__USERI__08B54D69]
ON [dbo].[CONVERSATIONs]
    ([USERIDs]);
GO

-- Creating foreign key on [USERID] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [FK__Message__USERID__7C4F7684]
    FOREIGN KEY ([USERID])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Message__USERID__7C4F7684'
CREATE INDEX [IX_FK__Message__USERID__7C4F7684]
ON [dbo].[Messages]
    ([USERID]);
GO

-- Creating foreign key on [USERID] in table 'POSTs'
ALTER TABLE [dbo].[POSTs]
ADD CONSTRAINT [FK__POST__USERID__38996AB5]
    FOREIGN KEY ([USERID])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__POST__USERID__38996AB5'
CREATE INDEX [IX_FK__POST__USERID__38996AB5]
ON [dbo].[POSTs]
    ([USERID]);
GO

-- Creating foreign key on [MessageIDs] in table 'CONVERSATIONs'
ALTER TABLE [dbo].[CONVERSATIONs]
ADD CONSTRAINT [FK__CONVERSAT__Messa__09A971A2]
    FOREIGN KEY ([MessageIDs])
    REFERENCES [dbo].[Messages]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__CONVERSAT__Messa__09A971A2'
CREATE INDEX [IX_FK__CONVERSAT__Messa__09A971A2]
ON [dbo].[CONVERSATIONs]
    ([MessageIDs]);
GO

-- Creating foreign key on [AspNetRoles_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetRoles]
    FOREIGN KEY ([AspNetRoles_Id])
    REFERENCES [dbo].[AspNetRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUsers]
    FOREIGN KEY ([AspNetUsers_Id])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AspNetUserRoles_AspNetUsers'
CREATE INDEX [IX_FK_AspNetUserRoles_AspNetUsers]
ON [dbo].[AspNetUserRoles]
    ([AspNetUsers_Id]);
GO

-- Creating foreign key on [PROJECTs_ID] in table 'COLLABORATOR'
ALTER TABLE [dbo].[COLLABORATOR]
ADD CONSTRAINT [FK_COLLABORATOR_PROJECT]
    FOREIGN KEY ([PROJECTs_ID])
    REFERENCES [dbo].[PROJECTs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AspNetUsers_Id] in table 'COLLABORATOR'
ALTER TABLE [dbo].[COLLABORATOR]
ADD CONSTRAINT [FK_COLLABORATOR_AspNetUsers]
    FOREIGN KEY ([AspNetUsers_Id])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_COLLABORATOR_AspNetUsers'
CREATE INDEX [IX_FK_COLLABORATOR_AspNetUsers]
ON [dbo].[COLLABORATOR]
    ([AspNetUsers_Id]);
GO

-- Creating foreign key on [CATAGORies_ID] in table 'PROJECTTYPE'
ALTER TABLE [dbo].[PROJECTTYPE]
ADD CONSTRAINT [FK_PROJECTTYPE_CATAGORY]
    FOREIGN KEY ([CATAGORies_ID])
    REFERENCES [dbo].[CATAGORies]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PROJECTs_ID] in table 'PROJECTTYPE'
ALTER TABLE [dbo].[PROJECTTYPE]
ADD CONSTRAINT [FK_PROJECTTYPE_PROJECT]
    FOREIGN KEY ([PROJECTs_ID])
    REFERENCES [dbo].[PROJECTs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PROJECTTYPE_PROJECT'
CREATE INDEX [IX_FK_PROJECTTYPE_PROJECT]
ON [dbo].[PROJECTTYPE]
    ([PROJECTs_ID]);
GO

-- Creating foreign key on [REPLY_POST_ID] in table 'POSTs'
ALTER TABLE [dbo].[POSTs]
ADD CONSTRAINT [FK_REPLY]
    FOREIGN KEY ([REPLY_POST_ID])
    REFERENCES [dbo].[POSTs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_REPLY'
CREATE INDEX [IX_FK_REPLY]
ON [dbo].[POSTs]
    ([REPLY_POST_ID]);
GO

-- Creating foreign key on [PARENTID] in table 'EXPERTs'
ALTER TABLE [dbo].[EXPERTs]
ADD CONSTRAINT [FK_PARENTID]
    FOREIGN KEY ([PARENTID])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PARENTID'
CREATE INDEX [IX_FK_PARENTID]
ON [dbo].[EXPERTs]
    ([PARENTID]);
GO

-- Creating foreign key on [expertID] in table 'SPECIALTies'
ALTER TABLE [dbo].[SPECIALTies]
ADD CONSTRAINT [fk_expertID]
    FOREIGN KEY ([expertID])
    REFERENCES [dbo].[EXPERTs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'fk_expertID'
CREATE INDEX [IX_fk_expertID]
ON [dbo].[SPECIALTies]
    ([expertID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------