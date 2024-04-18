CREATE PROCEDURE [dbo].[spFood_All]
AS
    begin 
        set nocount on;

        SELECT Id, Title, Description, Price 
        FROM dbo.Food;
    end