# Homework Chapter 05, ISTA-322
## ISTA-322, ASP.NET MVC
#### Readings
Read chapter 5, pages 95 { 118 in the Pro ASP.NET MVC 5 book.
#### Discussion Questions
Answer the discussion questions in writing for chapter 5.
##### 1. What is a view engine?
engine that processes ASP.NET content and looks for instructions, typically to insert dynamic content into output sent to the browser.
##### 2. What is Razor?
MVC Framework view engine
##### 3. What do views do? List two specic things in your answer to this question.
processes the contents of views and renders HTML
##### 4. How does Razor respond when it encounters statements that begin with the at character (@)? Be specic.
It interprets the following statement as Declaring the model to be used

##### 5. How does Razor respond when it encounters statements that begin with the at character followed by the colon (@:)? Be specic.
It prevents Razor from interpretting the following statement as code
##### 6. Describe how you implement a standard formatting for all pages in an ASP.NET application.
by using a view start (.ViewStart.cshtml file)
##### 7. What is the diference in using Razor to interpolate data values as stand-alone HTML elements and as attributes to HTML elements. What is the similarity?

##### 8. What is a view start and where is it located?
in the Views folder
##### 9. What is a Razor code block? What is the syntax of a Razor code block?
 a statement that allows inclusion of C# statements in a view, @{}
##### 10. Describe the diferent roles of action methods and views.
 Action method passes view model object to the view but doesn't pass formatted data to the view. The View presents content to the user and doesn't change any aspect of the view model object.

##### 11. Describe the use of the @using statement. Give an example of how you would use it.
declares the type of the model object that will be passed to the view from the action method.
```
@model Razor.Models.Product
```
