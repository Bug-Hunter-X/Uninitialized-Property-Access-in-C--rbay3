# Uninitialized Property Access in C#

This example demonstrates a common, subtle error in C#: accessing properties before they've been explicitly assigned a value.  Uninitialized properties will have default values (e.g., 0 for integers, null for reference types), which may lead to unexpected behavior if not handled properly. 

The `bug.cs` file shows an example of this problem.  The `bugSolution.cs` file presents a corrected version that demonstrates proper handling of the uninitialized property.