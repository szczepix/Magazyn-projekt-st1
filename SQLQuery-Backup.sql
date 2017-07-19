DECLARE 
      @SQL NVARCHAR(1000)
    , @DB_NAME NVARCHAR(100) = 'Magazyn.Model1'

SELECT TOP 1 @SQL = '
    BACKUP DATABASE [' + @DB_NAME + '] 
    TO DISK = ''' + REPLACE(mf.physical_name, '.mdf', '.bak') + ''''
FROM sys.master_files mf
WHERE mf.[type] = 0
    AND mf.database_id = DB_ID(@DB_NAME)

PRINT @SQL
EXEC sys.sp_executesql @SQL