BEGIN TRANSACTION;
GO

ALTER TABLE [Products] ADD [DiscountPercentage] float NOT NULL DEFAULT 0.0E0;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240814113015_AddDiscountPercToProductsTable', N'8.0.8');
GO

COMMIT;
GO

