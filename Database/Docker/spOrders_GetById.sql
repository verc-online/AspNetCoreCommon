CREATE PROCEDURE [dbo].[spOrders_GetById] 
    @Id int
AS
begin
    set nocount on;

    SELECT Id, OrderName, OrderDate, FoodId, Quantity, Total
    FROM dbo.[Order]
    where Id = @Id;
end