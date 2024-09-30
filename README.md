# WebAPI-Database-EnsureCreated

This example illustrates how, upon application startup, the database is checked for existence. If the database does not exist, it is automatically created. Additionally, if the associated table is found to be empty, it is seeded with initial data to ensure the application has the necessary starting records.

Entity Framework Core is used for database interactions. If you're not utilizing Entity Framework Migrations, but instead need your DbContext to reflect the current state of your model as defined in your context class on the first run, this approach ensures that your database schema is created as-is, without relying on migrations.
