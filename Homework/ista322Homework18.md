# Homework 18, ISTA-220
## Chapter 18, C# Step by Step
#### Homework
Read chapter 18, pages 399 { 422 in the C# Step by Step book.
#### Discussion Questions
Answer the discussion questions in writing.

##### 1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will be handled by the team. For example, a ticket submitted a week ago has a higher priority than a ticked just submitted. What kind of data structure would you use, and why?
Queue<T> because it implements a first in first out data structure
##### 2. You are building a tracking system for seasonal agricultural farm labor. Te labor requirements vary widely, depending on the season. Your requirement is that the newest hires are terminated first, and that our more experienced hires are kept longer. What kind of data structure would you use, and why?
Stack<T> because it implements a first in first out data structure
##### 3. You are building a transaction database. Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently. In other words, data is typically added in the order in which the transaction occurs. What kind of data structure would you use, and why?
List<T>
##### 4. You are building an analytical database. YOur requirement is that the database handle queries very quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind of data structure would you use, and why?
HashSet<T>
##### 5. You are building a personnel directory, where searches are performed by last name,first name, middle name. What kind of data structure would you use, and why?
Dictionary<T>
##### 6. You are building a username/password database. Your requirement is that updates happen frequently (when users change their passwords) and that searches (to authenticate users) happenb extremely quickly. What kind of data structure would you use, and why?
LinkedList<T>
##### 7. What is a lambda expression? Give an example. Why would we use a lambda expression?
An expression that returns a method. Returns an anonymous method. (Person p) => {return p.ID == 3} To call a method when when needed
##### 8. What is the difference between lambda expressions and anonymous methods? What are the advantages of each?
Syntax. Lamda expressions provide a more natural syntax and they pervade many of the more advanced aspects of C#. Generally the same thing
