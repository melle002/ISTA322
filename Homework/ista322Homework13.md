# Homework 13, ISTA-220
## Chapter 13, C# Step by Step

#### Readings
Read chapter 13, pages 277 – 293 in the C# Step by Step book.
#### Discussion Questions
Answer the discussion questions in writing.
##### 1. What is an interface as the term is used on object-oriented programmoing?
Specifies functionality

##### 2. How do you deﬁne an interface?
Same as defining a class except using Interface insted of class

##### 3. Can an interface have variables, ﬁelds, or properties?
No

##### 4. How do you deﬁne a method in an interface?
return type, name, parameter list, and the method body is replaced by semicolon

##### 5. Can you instantiate an object through an interface? Why or why not?
yes but interace must be implemented

##### 6. Using the new keyword, can you declare a reference to an interface?
Yes see above

##### 7. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how can it do so?
Yes, yes

##### 8. What does it mean to explicitely implement an interface?
Using the full naming path (nameInterface.method)

##### 9. What are the restrictions on interfaces?
```
1. not allowed to define any fields
2. not allowed to define constructors
3. not allowed to define destructors
4. you cannot define an access modifier for any methods
5. You cannot nest any types within
6. Not allowed to inherit from a struct or class
```


##### 10. What is the diﬀerence between an abstract class and an interface?



##### 11. What is an abstract method?
A method that does not contain a body where a derived class must overide it


##### 12. What is a sealed class?
A class that has been prevented from becoming a base cloass

##### 13. What is a sealed method?
a method that cannot be overided by a derived class.
