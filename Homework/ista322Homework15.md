# Homework 15, ISTA-220
## Chapter 15, C# Step by Step


#### Readings
Read chapter 15, pages 329 – 352 in the C# Step by Step book.
#### Discussion Questions
Answer the discussion questions in writing.
##### 1. What is the diﬀerence between a property and a ﬁeld?
A property acts like a method
##### 2. What is the diﬀerence between a property and a method?
A property can only contain two blocks of code
##### 3. What is your understanding of encapsulation?
Keeping data private within the class
##### 4. Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter. C# is case sensitive. What implications does this have regarding the naming of variables, methods, and other identiﬁers? Do you think that the diﬀerence in case in the initial character of two diﬀerent identiﬁers is suﬃcient to distinguish them?
it depends. It is not a good idea worrying about interoperability because other languages do not distinguish in this way and interoperability would be non-existent
##### 5. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use s write-only property.
read only property would be useful when it doesn't need to change as in a camparable value for testing purposes, Write only would be valuable for pin numbers or acct #s
##### 6. Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.
When dealing with passwords
##### 7. What are restrictions on the use of properties?
* You can assign a value through a property of a structure or class only after the structure or class has been initialized
* You can’t use a property as a ref or an out argument to a method
* A property can contain at most one get accessor and one set accessor.
* The get and set accessors cannot take any parameters.
* You can’t declare properties by using const

##### 8. What is an object initializer? What is the syntax for an object initializer?

When you create an instance of a class, you can initialize it by specifying the names and values for any public properties that have set accessors.
```
Triangle tri4 = new Triangle { Side1Length = 9, Side2Length = 12, Side3Length = 15 };
```
