CREATE TABLE [dbo].[Table] (
    [LAST NAME]   NCHAR (10) NOT NULL,
    [FIRST NAME]  NCHAR (10) NOT NULL,
    [EMPLOYEE ID] INT        NOT NULL,
    [PHOTO]       IMAGE      NOT NULL,
    [DEPARTMENT]  NCHAR (10) NOT NULL,
    [DIVISION]    NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([LAST NAME] ASC)
);


GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Employee',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Table',
    @level2type = NULL,
    @level2name = NULL