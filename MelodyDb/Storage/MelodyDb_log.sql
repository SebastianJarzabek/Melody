ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [MelodyDb_log], FILENAME = 'C:\repos\MelodyDb\MelodyDb_log.ldf', SIZE = 73728 KB, MAXSIZE = 2097152 MB, FILEGROWTH = 65536 KB);

