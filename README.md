# BINARY TREE SORT:
A tree is a set of nodes connected by edges. Unlike arrays, linked list, stack and queues, which are linear data structure, tree are hierarchical data structure. A tree can have maximum of two braches (Childs) known as LEFT CHILD and RIGHT CHILD.
Each node consist of data entered by user. It first creates a tree of provided elements and then display by using in-order traversal.
Binary tree sort is used for sorting of input numbers based on binary search tree. When we need to sort data we can use binary tree sort. 
How it works?
## INSERTION:
In the start our tree would be empty, so whatever value our user will enter, that would be considered as the root of the tree. Suppose that we enter the value 8, first our program will check that whether our tree is emp0ty or not. If it is empty than 8 will be consider as the root of our tree.

                                          8

Let suppose if we have a node containing a value 8, and we added another value 4,first the Insert function will check if the new element is greater or less than the  root, as 8 is root then 4 is less than root so this will be placed in left sub tree, and our tree would look like this:

                                          8
                                          
                                       /
                                       
                                    4

Further if we want to add another value and let’s suppose it is 11, then its placement will be decided based on the condition that whether it’s greater or less than root, so in this case 11 will be placed in right sub tree.

                                            8 
                                            
                                         /     \
                                         
                                       4         11

Then if we then add 5, *based on previously mentioned criteria* its placement would look like this

                                        8
                                        
                                    /       \
                                    
                                  4          11
                                  
                                   \
                                  
                                     5

And if we then added 1,12,9, tree will look like this

                                        8

                                   /         \

                                4               11

                            /      \          /      \

                          1           5     9          12

## DISPLAY:
There are three methods of displaying Binary Tree.
1.	In-Order (Left, Root, Right)
2.	Pre-Order (Root, Left, Right)
3.	Post-Order (Left, Right, Root)

As we have to display our tree in a sorted form i.e. ascending order, so we will user In-Order method of display. By using this method, our above mentioned tree will look like this:

                1  4   5   8   9   11  12

 
## ABOUT THE CODE
The “program.cs” given in the folder can be opened in Visual Studio2013. This file contains the source code of the programme which has been written and compiled in C#. 
The code contains following 

•	Variable LEFTNODE is a sub-tree on left of root or left child

•	Variable RIGHTNODE is a sub-tree on right of root or right child.

•	Variable VALUE is data input by user.

•	Variable ROOT is a parent node.

•	bool isempty(bNode root), it will check the condition whether the tree is empty or not. If tree is empty it will return TRUE otherwise FALSE.

•	insert(bNode root, int v), this function will get the input VALUE inserted by user in tree. When user enters any data first this function will check whether the tree is empty or not, in case of empty tree value data will be inserted at ROOT and if tree is not empty then it will further check whether given value is greater than ROOT it will be inserted in right sub-tree and if value is less than ROOT then it will be entered at left sub-tree.

•	Displaytree(bNode root) is a function which performs in-order traversal to get elements in sorted order. This will print left child first then root and right child. In this way we will get data in sorted order.

## How to Run:
This programme is a menu driven programme

On the interface, there are 3 options for user,
1.	Insert 		(to insert any value in tree)
2.	Display		(display the tree)
3.	Exit		(exit the program)

User will have to choose anyone option from the given menu.

If user enters 1 then he will be asked to insert the value in tree .After the value is entered, that value will be checked and added to the tree it will be asked for operation he wants to perform.

If user enter 2, then all the elements of tree will display in sorted order

If option 3 is chosen, then program will be terminated.

After every operation user will be asked again and again to select any option from the menu until the user select the exit option and terminate the programme.


## Group members:

•	MUHAMMAD UMAID 				17B-073-SE

•	MUGHIRA ZAKIR 					17B-111-SE

•	ARABISH GUL 					17B-069-SE
