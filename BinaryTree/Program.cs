// See https://aka.ms/new-console-template for more information
using BinaryTree;

Console.WriteLine("Hello, World!");

bool flag = true;
while (flag)
{
    Console.WriteLine("\nEnter the program number which is to be executed \n 1.UC-1, \n 2.UC-2, \n 3.UC-3, \n 4.Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("BinarySearchTree");
            BinaryTree<int> bst = new BinaryTree<int>(56); //Create object and pass root value of tree
            bst.Insert(30); //Add Element
            bst.Insert(70);

            bst.Display(); //call Display Method
            Console.WriteLine("         56        ---> Root \n");
            Console.WriteLine("     30     70");

            Console.ReadLine();
            break;
        case 2:
            Console.WriteLine("BinarySearchTree");
            BinaryTree<int> bst1 = new BinaryTree<int>(56); //Create object and pass root value of tree
            bst1.Insert(30); //Add Element
            bst1.Insert(70);
            bst1.GetSize(); //call GetSize method to print size //UC2


            bst1.Display(); //call Display Method
            Console.WriteLine("         56        ---> Root \n");
            Console.WriteLine("     30     70");
            Console.WriteLine("          ");

            Console.ReadLine();
            break;
        case 3:
            Console.WriteLine("BinarySearchTree");
            BinaryTree<int> bst2 = new BinaryTree<int>(56); //Create object and pass root value of tree
            bst2.Insert(30); //Add Element
            bst2.Insert(70);
            bst2.Insert(22);
            bst2.Insert(40);
            bst2.Insert(60);
            bst2.Insert(95);
            bst2.Insert(11);
            bst2.Insert(65);
            bst2.Insert(3);
            bst2.Insert(16);
            bst2.Insert(63);
            bst2.Insert(67);
            bst2.GetSize(); //call GetSize method to print size //UC2

            bst2.Search(70, bst2);


            bst2.Display(); //call Display Method
            Console.WriteLine("                                           56                    ---> Root \n");
            Console.WriteLine("                                 30                    70                    ");
            Console.WriteLine("                          22           40         60             95            ");
            Console.WriteLine("                     11                                65                  ");
            Console.WriteLine("                3          16                   63           67           ");



            Console.ReadLine();
            break;
        case 4:
            flag = false;
            break;
    }
}