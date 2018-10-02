# Homework 16, ISTA-220
## Chapter 16, C# Step by Step
July 28, 2018
#### Homework

Read chapter 16, pages 329 – 352 in the C# Step by Step book.
#### Discussion Questions
Answer the discussion questions in writing.
##### 1. Give ﬁve examples (using valid C# code) of the ﬁve bitwise operators listed in the text.
int a = 60;            /* 60 = 0011 1100 */
int b = 13;            /* 13 = 0000 1101 */
int c = 0;

c = a & b;             /* 12 = 0000 1100 */

c = a | b;             /* 61 = 0011 1101 */

c = a ^ b;             /* 49 = 0011 0001 */

c = ~a;                /*-61 = 1100 0011 */

c = a << 2;      /* 240 = 1111 0000 */

c = a >> 2;      /* 15 = 0000 1111 */

##### 2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valie C# code.
yes, opposite of the left/ c = a >> 2;

##### 3. Explain in detail this code: bits & (1 << index);.
shifts left by the value of index and checks to see if value is 1 in bits at same index. if not it returns zero

##### 4. Explain in detail this code: bits |= (1 << index);.
sets the value at index to 1 in bits

##### 5. Explain in detail this code: bits &= (1 << index);.
sets the value at index to 0

##### 6. How does C# interpret this? bool peek = bits[n];
Converts to a call to the get accessor of bits with the index argument set to n. So it returns the bool value at index n of bits

##### 7. How does C# interpret this? bits[n] = true;
calls the set accessor and sets the value at index n to true

##### 8. How does C# interpret this? bits[n] ^= true;
calls bot get accessor and checks value of bits at index n if not true then calls the set accessor and sets value at index of bits to true.

##### 9. Assume that users were assigned read, write, and execute permissions according to this scheme: read = 1, write = 2, execute = 4. How would you interpret the following user permissions:(a) permission = 0 (b) permission = 1 (c) permission = 2 (d) permission = 3 (e) permission = 4 (f) permission = 5 (g) permission = 6 (h) permission = 7
a: none
b: read access
c: write access
d: read/write access
e: execute access
f: read/execute access
g: write/execute access
h: read/write/execute access

##### 10. Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this shceme of permissions?

a: none   0000
b: read access 0001
c: write access 0010
d: read/write access 0011
e: execute access 0100
f: read/execute access 0101
g: write/execute access 0011
h: read/write/execute access 0111
