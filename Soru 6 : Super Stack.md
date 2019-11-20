# 6. Super Stack
### implement a stack that accept the following commands and perform the operations described:

- *push v*: push integer v onto the top of the stack.
- *pop*: pop the top element from the stack.
- *inc i v*: add v to each of the bottom i elements of the stack


After each operation, print the value at the top of the stack. if the is empty, print the string "EMPTY". for example:

| operation |    stack   |    top (print this) |
|   ---     |    ---     |    ---    |
| push 4    |    [4]     |     4     |
| push 5    |    [4,5]   |     5     |
| inc 2 1   |    [5,6]   |     6     |
| pop       |    [5]     |     5     |
| pop       |    []      |   EMPTY   |

### Constraint:
- 1 <= n <= 2 x 10^5

- -10^9 <= v <= 10^9

- 1 <= i <= |S|, where |S| is the size of the stack at the time of the operation

- it is guaranteed that pop is never called on an empty stack
----------------------------------------------------------------------------------
### Sample Case:
#### Sample input:
- 12
- push 4
- pop 
- push 3
- push 5
- push 2
- inc 3 1
- pop
- push 1
- inc 2 2
- push 4 
- pop
- pop
#### Sample output:
- 4
- EMPTY
- 3
- 5
- 2
- 3
- 6
- 1
- 1
- 4
- 1
- 8
------------------------------------------------------------------------------
### End of question
------------------------------------------------------------------------------
