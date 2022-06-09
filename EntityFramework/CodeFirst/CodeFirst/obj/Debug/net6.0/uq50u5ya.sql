IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Cars] (
    [Id] int NOT NULL IDENTITY,
    [Make] nvarchar(15) NOT NULL DEFAULT N'Mercedes',
    [Model] nvarchar(15) NOT NULL,
    [CarId] int NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Cars_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([Id])
);
GO

CREATE TABLE [Rooms] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [CarId] int NOT NULL,
    CONSTRAINT [PK_Rooms] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Rooms_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Cars_CarId] ON [Cars] ([CarId]);
GO

CREATE INDEX [IX_Rooms_CarId] ON [Rooms] ([CarId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220607060414_FirstMigration', N'6.0.5');
GO

COMMIT;
GO

