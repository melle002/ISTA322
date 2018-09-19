# Homework 14, ISTA-220
## Chapter 14, C# Step by Step

#### Readings
Read chapter 14, pages 305 – 328 in the C# Step by Step book.
#### Discussion Questions
Answer the discussion questions in writing.
##### 1. What is the diﬀerence between a managed resource and an unmanaged resource?
unmanaged resources are scarce and must be managed by user

##### 2. When is memory for an object (reference type) allocated? When is the memory deallocated?
When the new operator is used/ When it goes out of scope or no longer being actively referenced

##### 3. What is a destructor?
a method that like is a constructor but its called after the reference to an object has disappeared

##### 4. What is the diﬀerence in syntax between a constructor and a destructor?
~ is placed before it

##### 5. Give some examples of scarce resources. Why would you want to manage scarce resources?
file streams, database connections, and network connections. because there are only so many available. If they are all busy then thy cannot be used until released.
##### 6. What is exception-safe disposal?
Ensuring that the disposal method executes regardless of exception by using the finally block


##### 7. How do you think that the using statement works for resource management? Give an informal, English language, explanation of how it works.
it creates its own block which the system uses to know once something falls out of scope so it can be disposed of automatically.

##### 8. What ill eﬀects could result from attempting to dispose of a resource more than once?
A Waste of processing, loss of data

##### 9. We will look at threads later in the term. For now, what is your understanding of how threads interact with resource management? A good guess is a siuﬃcient answer to this question.
Syncronous operations

##### 10. Why does the book recommend not attempting to force the garbage collector? Are their any exceptions to this recommendation?
because the order of finalization is not guaranteed
