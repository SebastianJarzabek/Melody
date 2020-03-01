ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [MelodyDb], FILENAME = 'C:\repos\MelodyDb\MelodyDb.mdf', SIZE = 8192 KB, FILEGROWTH = 65536 KB) TO FILEGROUP [PRIMARY];

