using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object of the class bNOde
            bNode b = new bNode();
            int a = 0;
            //do while loop helps in making a menu that will run untill user want to exit
            do
            {
                Console.WriteLine("\n\n\t\t1.Insert \n\t\t2.Display \n\t\t3.Exit");
                Console.Write("\n\tEnter your Choice:");
                int n = Convert.ToInt16(Console.ReadLine());
                if (n == 1 || n == 2 || n == 3)
                {
                    //n will tell the choice of user and switch case will work upon it
                    switch (n)
                    {

                        case 1:
                            //case 1 will ask value and then send it to insert function
                            Console.Write("\tEnter value:");
                            int i = Convert.ToInt16(Console.ReadLine());
                            b.insert1(i);

                            break;

                        case 2:
                            //call empty function to check whether the tree is empty or not
                            bool empty = b.isempty1();
                            if (empty == false)
                            {
                                Console.Write("\n\tTree:\t");
                                b.Displaytree1();
                            }
                            else
                                Console.WriteLine("TREE IS EMPTY");

                            break;

                        case 3:
                            //exit the program
                            a = 1;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You Entered an invalid value");
                }

            } while (a == 0);
        }
    }
    class bNode
    {
        int value;
        bNode leftnode;
        bNode rightnode;
        bNode root;
        //catch the value that user enetr and send it to another insert function along with the root
        public void insert1(int e)
        {
            root = insert(root, e);
        }
        //reviece the value and root
        public bNode insert(bNode root, int v)
        {
            //check whether tree is empty or not
            if (root == null)
            {
                root = new bNode();
                root.value = v;
            }
            //if value is greater than root then it is a left child
            else if (v < root.value)
                root.leftnode = insert(root.leftnode, v);
            //if value is less than root or eqaul to root then it is a right child
            else if(v>root.value || v==root.value)
                root.rightnode = insert(root.rightnode, v);
            return root;

        }
        //sends the root to and another empty function to check whether the tree is empty or not
        public bool isempty1()
        {
            bool empty = isempty(root);
            return empty;

        }
        //revieves the root and check the treee
        public bool isempty(bNode root)
        {
            bool empty;
            if (root == null)
            {
                empty = true;
            }
            else
            {
                empty = false;
            }
            return empty;
        }
        //sends root to the another display functuon
        public void Displaytree1()
        {
            Displaytree(root);
        }
        //revieces the root and use INORDER method to display the tree
        public void Displaytree(bNode root)
        {
            if (root != null)
            {
                Displaytree(root.leftnode);
                Console.Write(root.value + " -> ");
                Displaytree(root.rightnode);
            }
            else
                return;
        }
    }
}