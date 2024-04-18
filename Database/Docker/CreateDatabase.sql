create table Food
(
    Id          int identity
        constraint Food_pk
            primary key clustered,
    Title       nvarchar(50)  not null,
    Description nvarchar(250) not null,
    Price       money         not null
)
go

create table [Order]
(
    Id        int identity
        constraint Order_pk
            primary key clustered,
    OrderName nvarchar(50) not null,
    OrderDate datetime2    not null,
    FoodId    int          not null
        constraint Order_Food_Id_fk
            references Food (Id),
    Quantity  int          not null,
    Total     money        not null
)
go


