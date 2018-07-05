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

