## .NET CORE Entity Framework Example Application

While toying around with Reverse Engineered Databases in Entity Framework
the thought came up of handling data joined from two tables by way of a stored procedure.

Not saying this is the right or wrong way to handle the situation, but it is one way.

The database was created for this project (which is why I'm doing the horrible horrible thing of leaving credentials in my repo)

The following command was used to Scaffold the Database for EF
> dotnet ef dbcontext scaffold "Server=localhost;Database=SillySample;User Id=sa;Password=L4m3P4ssw0rd1!;" Microsoft.EntityFrameworkCore.SqlServer -o Models


if you actually want to run this to see it work, change the connection string to something that will work on your sql server
and run the included Setup Database.sql file