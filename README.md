# GraphQLHobbyAPI
An example of implementing a GraphQL Server in the standard.NET framework

## Why another GraphQL repo?
Most GraphQL solutions showing usage of GraphQL on the client side. The ones on the server side are either using APOLLO servers with javascript frameworks or .NET Core. The project we wanted to use GraphQL in was using standard .NET framework with ADO.NET .
We played with various samples and demos and then build out a simple demo app showcasing the use of GraphQL and graphiql with .NET framework. 
**In some senses this is the simplest and most vanilla GraphQL server repo you will see which is what we were looking for.**

## Technology Stack
* GraphQL server with full .NET 4.5 framework
* Code First Entity Framework 6.0
* Graphiql

## Development Platform
* Windows Machine
* Visual Studio
* Visual Studio Code

## This example showcases
- [x]	Basic parameterized Queries 
- [x]	Nested Queries
- [x]	Basic parameterized Mutations
- [ ]	Does NOT use Dependency Injection


## References
*	https://fullstackmark.com/post/17/building-a-graphql-api-with-aspnet-core-2-and-entity-framework-core 
  ( This is for .NET Core but good to get started)
*	https://github.com/JacekKosciesza/StarWars 
  ( Again this is for .NET Core)
*	https://graphql-dotnet.github.io/
  (GraphQL for .NET repo)
*	https://github.com/graphql-dotnet/examples/tree/master/src/AspNetWebApi 
  *(Pretty much the only .NET framework example we got and most useful!)*

## Functioning
The api exposes a simple Person-Hobby system with the following relationship
![Database diagram](http://cennest.com/weblog/wp-content/uploads/2018/07/hobbyDB.png)

The Schema allows for the following operations
1. Query Person by ID ( allows nested queries to get person’s hobbies)
![Query Person](http://cennest.com/weblog/wp-content/uploads/2018/07/queryPerson.png)

2.	Query Hobby by ID ( Including get count of people interested in that hobby)
![Query Hobby](http://cennest.com/weblog/wp-content/uploads/2018/07/queryHobby.png)

3.	Create new Hobby  (Mutation)
![Create Hobby](http://cennest.com/weblog/wp-content/uploads/2018/07/createHobby.png)

## Using Graphiql
The nuget at  https://www.nuget.org/packages/graphiql/  is made for .NET Core and does not work with the standard .NET framework.
We tried using the Graphiql repo at https://github.com/graphql/graphiql   directly but it had some issues building on a windows machine.(https://github.com/graphql/graphiql/issues/318) .

We finally used the fork at https://github.com/mattferrin/graphiql to get this working on a Windows Machine. 
### Steps were as under
1.	Clone repo from https://github.com/mattferrin/graphiql
2.	Install Yarn from https://yarnpkg.com/en/docs/install#windows-stable
3.	Open Command Prompt and Navigate to main project
4.	Use **“Yarn Install”** to install all dependencies
5.	**“npm run build”** on the parent directory
6.	Navigate to Example directory
7.	**“npm install”**
8.	Update function graphQLFetcher in example/index.html to hit the HobbyAPIServer  

![update url](http://cennest.com/weblog/wp-content/uploads/2018/07/qraphiql.png)
9. **“npm start”**
10.  Navigate to localhost:8080 and explore the schema


## Tutorial
What is shown here is simply how to connect the various pieces. However if someone needs specific steps please ping me at anshulee@cennest.com and i'll write up a tutorial

