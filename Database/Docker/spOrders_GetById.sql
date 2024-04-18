CREATE PROCEDURE [dbo].[spFood_All] 
    @Id int
AS
begin
    set nocount on;

    SELECT Id, OrderName, OrderDate, FoodId, Quantity, Total
    FROM dbo.[Order]
    where Id = @Id;
end