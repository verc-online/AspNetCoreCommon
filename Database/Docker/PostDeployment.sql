if not exists (select * from dbo.Food)
   begin
       insert into dbo.Food(Title, Description, Price)
       values ('Cheesburger Meal', 'A cheeseburger, fries and drink', 5.95),
              ('Chili Dog Meal', 'Two Chili dogs, fries and drink', 4.15),
              ('Vegan Meal', 'A large salad and water', 1.95);
   end
