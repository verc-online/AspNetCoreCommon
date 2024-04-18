CREATE PROCEDURE [dbo].[spOrders_UpdateName] 
    @Id int
AS
begin
    set nocount on;
    
    delete
    from dbo.[Order]
    where Id = @Id;
end