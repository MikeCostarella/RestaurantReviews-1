RestaurantReviews
=================

The Problem
--------------
We are in the midst of building a mobile application that will let restaurant patrons rate the restaurant in which they are eating. As part of the build, we need to develop a web API that will accept and store the ratings and other sundry data from a publicly accessible interface. 

For this project, we would like you to build this API. Feel free to add your own twists and ideas to what type of data we should collect and return, but at a minimum your API should be able to:

1. Get a list of restaurants by city
2. Post a restaurant that is not in the database
3. Post a review for a restaurant
4. Get of a list of reviews by user
5. Delete a review

The Fine Print
--------------
Please use whatever techniques you feel are applicable to solve the problem. We suggest that you approach this exercise as if this code was part of a larger system. The end result should be representative of your abilities and style.  We prefer that you submit your solution in a language targeting the .NET Framework to help us better evaluate your code.

Please fork this repository. If your solution involves code auto generated by a development  tool, please commit it separately from your own work.  When you have completed your solution, please issue a pull request to notify us that you are ready.

Have fun.

# Mike's Solution

The RestaurantReviews project is a .net core web API 2 solution built upon EF Core.

* The web services supports a small domain model that is based on Restaurants, Users, and Reviews.

* Currently, this project is more focused on the architecture of .net core and ef core, than the depth of the domain.

## Discussion

This project was developed in my spare time over the course of a week. I had a few questions about what is meant to capture sundry data, so for now I have not added anything to the model and controllers to support that functionality.  If desired, I can add that later.  I have reached a point with this solution where it reveals my strategy for product development.  Please feel free to ask for more specific programming if desired.

In addition, I would address the following known deficiencies in this solution:

* Add foregin constraint(s) on the model entities in the database context.
* Add cascading deletes perhaps.  (Needs discussion)
* Add more controller action method unit tests.
* Add automated and self hosted controller action integration tests.
* Add more coverage on the data repository integration tests project.
* Add a secret for the database conneciton string, or at least factor it into the appsettings.json file.
* Remove a hard file references inside of RestaurantReviews.API nlog.config.
* Remove 4 warnings in the repository layer because of asynchronous development issues.  (Need more research there.)
* Toughen up the TestInitialize method of the repository data integration tests
* Add CORS restricitons perhaps to the controllers
* Add user authenitcation and authorization to the controller actions


## Tools  

* Visual Stuido 2017 - Community Edition
* .Net Core 2.2
* EF Core 2+
* IIS Express
* NLog
* Swashbuckle/Swagger
* PostgresSQL (MSSQL is also included but not activated)
* AutoMapper
* MSTest

## Setup

* Install Postgres SQL
  * set db passwords to trust mode for ease
* Check out the DataSeeder class to understand what data is applied upon the build of the database.
  * This seed data must be in place for the repository data integration tests to pass.
* Run the RestaurantReviews.API project to bring up the Swagger Open API document.

## Services

* Domain Level Services
  * RestaurantReviews
    * This is the controller that contains the public facing services

* CRUD Services
  * Restaurant
  * Review
  * User