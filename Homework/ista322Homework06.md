# Homework Chapter 06, ISTA-322
## ISTA-322, ASP.NET MVC
#### Readings
Read chapter 6, pages 119 { 154 in the Pro ASP.NET MVC 5 book.
#### Discussion Questions
Answer the discussion questions in writing for chapter 6.
##### 1. What is the primary idea that underlies Dependency Injection?
decouple the components in an MVC application, with a combination of interfaces and DI container that creates instances of objects by creating implementations of the interfaces they depend on and injecting them into the constructor
##### 2. Describe the role of interfaces in implementing a dependency injection container.
The interface allows you to break the tight coupling
##### 3. List the three stages of building basic Ninject functionality, and briefly define each stage.
1. prepare Ninject for use- create an instance of a Ninject kernel, which is the object that is responsible for resolving dependencies and creating new objects
2. create an implementation of the Ninject.IKernel interface- creating a new instance of the StandardKernel class
3. Use Ninject to create an objec- through the kernel Get method
##### 4. What is the purpose of a custom dependency resolver?
create instances of the classes it needs to service requests
##### 5. What is the purpose of conditional binding? Describe how it works.
specify which classes the kernel should use to respond to requests for particular interfaces.
##### 6. Why is setting the object scope important when using dependency injection?
helps tailor the lifecycle of the objects that Ninject creates to match the needs of your application
##### 7. Briefly describe the Test Driven Deelopment approach in developing an application.
1. create the unit test project
2. Creating the Unit Tests
3. Running the Unit Tests (and Failing)
4. Implementing the Feature
5. Testing and Fixing the Code
##### 8. Consider the Assert class. How do you access the methods of that class?
by calling it by th class: Assert.method
##### 9. Why is it useful to mock objects when developing software?
when you need to test objects that cannot function in isolation
##### 10. Briefly describe the two main issues that arise when attempting to do Unit Tests without the aid of some sort of mocking library.
unit test will become complex and brittle.
you have extend the scope of my unit test so you will not know where the problem is
