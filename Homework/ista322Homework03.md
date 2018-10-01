# Homework Chapter 03, ISTA-322
## ISTA-322, ASP.NET MVC
#### Readings
Read chapter 3, pages 51 { 66 in the Pro ASP.NET MVC 5 book.
#### Discussion Questions
Answer the discussion questions in writing for chapter 3.

##### 1. The book states, Interactions with an MVC application follow a natural cycle of user actions and view updates, where the view is assumed to be stateless." What does it mean for the view to be stateless?
That it shouldn't contain any logic other than that required to present the data to the user

##### 2. The book identies two kinds of models. Briefy desdribe each of them.
Model-View-Presenter
Model-View-View-Model
##### 3. Give an example of separation of concerns from your own life experience. This should be a simple, everyday example.

When CSM has access to the Soldiers at the processing level and trries to execute processing tasks without understanding the controls in plcae for that specific line(which individuals need to complete a specific task a specific way or if a specific Soldier has another appt with higher priority)
##### 4. What is a view engine?
an engine with the logic to process a veiw.
##### 5. The book notes that the three-tier structure, or n-tier model, is the most widely used pattern for business applications." Why do you think that this is true? An answer like, Because it works well," is not a suficient answer to this question.
Because unit testing is easy

##### 6. This question requires some outside research. When we study UWP, you will see that the UWP design pattern is the Model-View-ViewModel (MVVM). What is the diference between MVC and MVVM that makes the first good for ASP.NET MVC and the second good for UWP?
bi-drectional binding

##### 7. Describe the two parts of the dependency injection (DI) design pattern.
remove any dependencies on concrete classes by creating a class constructor that accepts an interface
inject the dependencies by creating instances of it
##### 8. Give an example of loose coupling from your own life experience. This should be a simple, everyday example.
It would be my job when executing critical tasks as a batery. The FO calls for fire, The FDC computes data, and the gunline fires. We are losely coupled with a radio
##### 9. What are the two types of testing discussed in the book?
unit testing and integration testing
##### 10. What are the seven steps of the test driven development (TDD) work flow, as stated in the book?
1. Determine need for new feature
2. write test that will validate behavior of said feature
3. run test and get red light
4. write code that implements new feature
5. run test again and correct code until green light refactor code as required
6. run test to confirm changes are g2g
