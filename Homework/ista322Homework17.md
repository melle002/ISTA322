# Homework 17, ISTA-220
## Chapter 17, C# Step by Step

#### Homework
Read chapter 17, pages 369 – 398 in the C# Step by Step book.
#### Discussion Questions
Answer the discussion questions in writing.
##### 1. What is a type parameter?
parameters that specify the types of objects on which they operate
##### 2. What does a type parameter do?
acts as a placeholder for a real type at compile time. alleviates the need for boxing
##### 3. How many type parameters can a generic class have?
multiple. depends on the class
##### 4. What is the diﬀerence between a generic class and a generalized class?
A generalized class has parameters that are specified and must be cast when passed and returned if they are of different type. A generic class is a template that allows the compiler to create new tpe specific classes.
##### 5. What is a constraint? How do you specify a constraint?
a conditional statement that ensures a generic class identifies a type that provides certain methods.
##### 6. What is a generic method? How do you deﬁne a generic method?
methods that are type safe and avoid the overhead of casting
##### 7. What do we mean when we say that a generic type interface is invariant?
It won't allow you to assign an object to an object of different reference type
##### 8. What do we mean when we cay that a generic type interface is covariant?
It allows you to assign an object of to a reference of different typ as long as there is a valid conversion of the object or it derives from the other.
##### 9. Does covariance work with value types? Does it work with reference types?
Only works with reference types
##### 10. What do we mean when we say that a generic type interface is contravariant?
Similar to covariant except that it works in the opposite direction by allowing you to reference an object of type B through a reference to type A as long as B derives from A
