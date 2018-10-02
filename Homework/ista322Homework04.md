# Homework Chapter 04, ISTA-322
## ISTA-322, ASP.NET MVC
#### Readings
Read chapter 4, pages 67 - 94 in the Pro ASP.NET MVC 5 book.
#### Discussion Questions
Answer the discussion questions in writing for chapter 4.

##### 1. Using automatic properties is a shortcut that avoids several explicit steps. List the steps that the useof automatic properties avoids.
defining the field or specifying the code in the getter and setter
##### 2. Using the object initializer syntax is a shortcut that avoids several explicit steps. List the steps that the use of object initializers avoids.
create the object, set perameter values, and call the view method
##### 3. What is the purpose of creating extension methods?
to add methods to classes you do not own and cannot modify
##### 4. What is the one feature of extension methods that will always allow you to identify a method as an extension method?
this  keyword
##### 5. How do you create an extension method that alters the results returned by the method on a user specied criterion?
by using yeild return ______;
##### 6. Explain the syntax of a lambda expression. The term "lambda expression" originates in the lambda calculus developed by the mathematician Alonzo Church in the 1930's. There is a class of programming languages that are based on the fundamental ideas of lambda calculus.
The parameter is expressed without specifying a type, which will be inferred. The Char => is read aloud as " go to ". and links the parameter to the result of the expression.

##### 7. This will require some outside research. What is the distinction between an anonmously typed variable and a dynamically typed variable?
dynamic declarations are resolved at run-time, var declarations are resolved at compile-time.
##### 8. You are having a discussion about C# with a friend of yours that uses another language. You are tellig him about C#'s LINQ library. How would you describe to him the diference between LINQ's SQL-like notation and LINQ's dot notation?
LINQ's SQL-like syntax is simplistic but desn't support all corresponding C# keywords. if you are willing to forgo simplicity and harness all LINQ has to offer then use LINQ's .notation instead which is based on extension methods and allows for chaining together to perform complex querries.
##### 9. What, exactly, does the await keyword do?
await tells the compiler to wait for the result of the Task that the current method returns then carry on executing other statements in the same method
##### 10. What is the connection between await and the async keywords?
you must use the async keyword when you use the await keyword
