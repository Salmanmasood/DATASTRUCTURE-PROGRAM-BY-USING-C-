using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        public static int mysum = 0;
        public static int mysum2 = 0;

        public static int[] a = new int[101];
        public static int[] b = new int[101];
        public static int[] c = new int[202];
        static void Main(string[] args)
        {
            char selectionofarray = 'a';
            int input, arrayselection, arraysizeofA = 0, flaga = 0, flagB = 0, arraysizeofB = 0, tempnofelement, temp = 0, temp2 = 0, memoryflag = 0, memoryflag2 = 0;
            int A=0, B=0,menu=1;
        Main:

            if (flaga == 1 && selectionofarray == 'a')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("(Array A of size {0} has been created and its logical size is {1})", arraysizeofA, mysum);

            }
            if (flagB == 1 && selectionofarray == 'b')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("(Array B of size {0} has been created and its logical size is {1})", arraysizeofB, mysum);

            }
            //if (menu==0)
            //{
            //    fst:
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("============================CREATING AN ARRAY A============================");
            //    Console.ForegroundColor = ConsoleColor.White;
            //    if (flaga == 0)
            //    {

            //        Console.Write("\nwhat physical size you want to allocate: ");
            //        arraysizeofA = int.Parse(Console.ReadLine());
            //        flaga = 1;

            //        for (int i = 1; i <= arraysizeofA; i++) //error ha yhn exception lgani ha
            //        {
            //            a[i] = -12345678;
            //        }
            //        a[0] = arraysizeofA;
            //        if (arraysizeofA <= 0 || arraysizeofA > 100)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("\nLogical Error!!!\nphysical memory cannot exceed the input value!!");
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.WriteLine("press any key to continue....");
            //            Console.ReadKey();
            //            goto fst;
            //        }
            //        Console.WriteLine("\nThe array of size " + arraysizeofA + " has been created!!! ");
            //        selectionofarray = 'a';
            //    }


            //    menu = 1;
                
            //}
            //Console.WriteLine("Press any key to go in the main menu...");
            //Console.ReadKey();
            //Console.Clear();
            if (menu == 1)
            {
                mainclass obm = new mainclass();
                obm.mainmenu(flaga,flagB);
                try
                {
                    input = int.Parse(Console.ReadLine());

                    Console.Clear();
                    switch (input)
                    {
                        case 1:
                        //THIS IS STARTING OF CREATING ARRAYS..................................................
                        c1:
                            mainclass ob2 = new mainclass();
                            try
                            {
                                arrayselection = ob2.createarray();
                            }
                            catch (Exception)
                            {
                                mainclass ex = new mainclass();
                                ex.invalidinput();
                                Console.WriteLine("press any key to go back.....");
                                Console.ReadKey(); 
                                Console.Clear();
                                goto c1;
                            }
                            if (arrayselection == 1)
                            {
                            labelofarrayA:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("============================CREATING AN ARRAY A============================");
                                Console.ForegroundColor = ConsoleColor.White;
                                if (flaga == 0)
                                {

                                    Console.Write("\nwhat physical size you want to allocate: ");
                                    arraysizeofA = int.Parse(Console.ReadLine());
                                    flaga = 1;

                                    for (int i = 1; i <= arraysizeofA; i++) //error ha yhn exception lgani ha
                                    {
                                        a[i] = -12345678;
                                    }
                                    a[0] = arraysizeofA;
                                    if (arraysizeofA <= 0 || arraysizeofA > 100)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nLogical Error!!!\nphysical memory cannot exceed the input value!!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("press any key to continue....");
                                        Console.ReadKey();
                                        goto labelofarrayA;
                                    }
                                    Console.WriteLine("\nThe array of size " + arraysizeofA + " has been created!!! ");
                                    selectionofarray = 'a';
                                }

                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nYou have created the Array A....You cannot recreate it again...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("press any key to continue....");
                                    Console.ReadKey();

                                }
                            }

                            else if (arrayselection == 2)
                            {

                            labelofarrayB:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("============================CREATING AN ARRAY B============================");
                                Console.ForegroundColor = ConsoleColor.White;
                                if (flagB == 0)
                                {

                                    Console.Write("\nwhat physical size you want to allocate: ");
                                    arraysizeofB = int.Parse(Console.ReadLine());
                                    flagB = 1;

                                    for (int i = 1; i <= arraysizeofB; i++) //error ha yhn exception lgani ha
                                    {
                                        b[i] = -12345678;
                                    }
                                    b[0] = arraysizeofB;
                                    if (arraysizeofB <= 0 || arraysizeofB > 100)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nLogical Error!!!\nphysical memory cannot exceed the input value!!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("press any key to continue....");
                                        Console.ReadKey();
                                        goto labelofarrayB;
                                    }
                                    Console.WriteLine("\nThe array of size " + arraysizeofB + " has been created!!! ");
                                    selectionofarray = 'b';
                                }

                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nYou have created the Array B....You cannot recreate it again...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("press any key to continue....");
                                    Console.ReadKey();

                                }
                            }
                            else
                            {
                                mainclass ob3 = new mainclass();
                                ob3.invalidinput();
                                Console.WriteLine("press any key to go back.....");
                                Console.ReadKey();
                                Console.Clear();
                                goto c1;
                            }

                            break;
                        //THIS IS ENDNG OF CREATING ARRAYS..................................................
                        case 2:
                        LABELOFCASE2:

                            //THIS IS STARTING OF INSERTING ARRAYS..................................................
                            int arraychoice = 0;
                            mainclass c2 = new mainclass();
                            try
                            {
                                arraychoice = c2.insertarray();
                            }
                            catch (Exception)
                            {
                                mainclass ex = new mainclass();
                                ex.invalidinput();
                                Console.WriteLine("press any key to go back.....");
                                Console.ReadKey();
                                Console.Clear();
                                goto LABELOFCASE2;
                            }

                            if (arraychoice == 1)
                            {
                                if (selectionofarray == 'a')
                                {
                                    if (memoryflag == 1)
                                    {
                                        Console.WriteLine("space not available.....");
                                        break;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("you are standing on Array A");
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("----------INSERTIION BY LAST AVAILABLE SPACE----------");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT!!", arraysizeofA, mysum, a[0]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write("\nHow many elements you want to insert: ");
                                        tempnofelement = int.Parse(Console.ReadLine());

                                        if (tempnofelement > arraysizeofA || tempnofelement <= 0 || mysum > arraysizeofA || a[0] < tempnofelement)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\nLogical Error!!!\nThe input logical size is not possible !!! ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            goto LABELOFCASE2;
                                        }
                                        if (temp == 0)
                                        {
                                            for (int i = 1; i <= tempnofelement; i++)
                                            {
                                                Console.Write("enter the element # " + (i) + " : ");
                                                a[i] = int.Parse(Console.ReadLine());
                                            }
                                            temp = tempnofelement;
                                            mysum = mysum + tempnofelement;
                                            //bool insertedA = true;
                                            A = 1;
                                            if (mysum >= arraysizeofA)
                                            {
                                                memoryflag = 1;
                                            }
                                        }
                                        else
                                        {
                                            for (int i = temp + 1; i <= (tempnofelement + temp); i++)
                                            {
                                                Console.Write("enter the element # " + (i) + " : ");
                                                a[i] = int.Parse(Console.ReadLine());
                                            }
                                            mysum = mysum + tempnofelement;
                                            if (mysum >= arraysizeofA)
                                            {
                                                memoryflag = 1;
                                            }
                                        } a[0] = arraysizeofA - mysum;

                                    }
                                }
                                //ending of arraysizeofA 1 method
                                else
                                {
                                    if (memoryflag2 == 1)
                                    {
                                        Console.WriteLine("space not available.....");
                                        break;
                                    }

                                    else if (selectionofarray == 'b')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("you are standing on Array B");

                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("----------INSERTIION BY LAST AVAILABLE SPACE----------");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT!!", arraysizeofB, mysum2, b[0]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write("\nHow many elements you want to insert: ");
                                        tempnofelement = int.Parse(Console.ReadLine());
                                        if (tempnofelement > arraysizeofB || tempnofelement <= 0 || mysum2 > arraysizeofB || b[0] < tempnofelement)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\nLogical Error!!!\nThe input logical size is not possible !!! ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            goto LABELOFCASE2;
                                        }

                                        if (temp2 == 0)
                                        {
                                            for (int i = 1; i <= tempnofelement; i++)
                                            {
                                                Console.Write("enter the element # " + (i) + " : ");
                                                b[i] = int.Parse(Console.ReadLine());
                                            }
                                            temp2 = tempnofelement;
                                            mysum2 = mysum2 + tempnofelement;
                                            //bool insertedB = true;
                                            B = 1;
                                            if (mysum2 >= arraysizeofB)
                                            {
                                                memoryflag2 = 1;
                                            }
                                        }
                                        else
                                        {
                                            for (int i = temp2 + 1; i <= (tempnofelement + temp2); i++)
                                            {
                                                Console.Write("enter the element # " + (i) + " : ");
                                                b[i] = int.Parse(Console.ReadLine());
                                            }
                                            mysum2 = mysum2 + tempnofelement;
                                            if (mysum2 >= arraysizeofB)
                                            {
                                                memoryflag2 = 1;
                                            }
                                        }
                                        b[0] = arraysizeofB - mysum2;

                                    }
                                }

                            }//ending of arraysizeofB 1 method

                            else if (arraychoice == 2)
                            { //starting of arraysizeofA 2 method
                                if (selectionofarray == 'a')
                                {
                                    Console.WriteLine("Your are standing on Array A");
                                    Console.WriteLine("----------INSERTIION BY LAST DESIRED INDEX----------");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT!!", arraysizeofA, mysum, a[0]);
                                    Console.ForegroundColor = ConsoleColor.White;


                                    Console.Write("Enter the index no on which you want to insert: ");
                                    int index = int.Parse(Console.ReadLine());
                                    Program.insertbyindex(index);
                                    if (index == (mysum + 1))
                                    {
                                        Console.Write("Enter the element that you want to insert on index {0}: ", index);
                                        int element = int.Parse(Console.ReadLine());
                                        a[index] = element;
                                        mysum++;
                                    }

                                    else if (index > mysum)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Error!!!!!!\nyou cannot access the desired memory");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("press any key to go back......");
                                        Console.ReadKey();
                                        goto LABELOFCASE2;
                                    }

                                    a[0] = arraysizeofA - mysum;




                                }//ending of arraysizeofA 2 method
                                else if (selectionofarray == 'b')
                                {
                                    Console.WriteLine("Your are standing on Array B");
                                    Console.WriteLine("----------INSERTIION BY LAST DESIRED INDEX----------");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT!!", arraysizeofA, mysum, a[0]);
                                    Console.ForegroundColor = ConsoleColor.White;


                                    Console.Write("Enter the index no on which you want to insert: ");
                                    int index = int.Parse(Console.ReadLine());
                                    Program.insertbyindex(index);
                                    if (index == (mysum2 + 1))
                                    {
                                        Console.Write("Enter the element that you want to insert on index {0}: ", index);
                                        int element = int.Parse(Console.ReadLine());
                                        b[index] = element;
                                        mysum2++;
                                    }


                                    else if (index > mysum2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Error!!!!!!\nyou cannot access the desired memory");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("press any key to go back......");
                                        Console.ReadKey();
                                        goto LABELOFCASE2;
                                    }

                                    b[0] = arraysizeofB - mysum2;





                                }//ending of arraysizeofB 2 method


                            }

                            break;


                        //THIS IS ENDNG OF INSERTING ARRAYS..................................................
                        case 3:
                            int replace = 0;
                            //THIS IS STARTING OF replacing ARRAYS.................
                            mainclass c3 = new mainclass();
                        replacecase3:
                            try
                            {
                                replace = c3.replacearray();
                            }
                            catch (Exception)
                            {
                                mainclass ex = new mainclass();
                                ex.invalidinput();
                                Console.WriteLine("press any key to go back.....");
                                Console.ReadKey();
                                Console.Clear();
                                goto replacecase3;
                            }

                            if (replace == 1)
                            {
                                if (selectionofarray == 'a')
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;

                                    Console.WriteLine("----------REPLACEMENT BY ELEMENT----------");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT AND YOU CAN ONLY REPLACE UPTO INDEX #{3} ", arraysizeofA, mysum, a[0], mysum);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("\nWhich element you want to Replace: ");
                                    tempnofelement = int.Parse(Console.ReadLine());
                                    bool x = Program.search(tempnofelement);
                                    if (x == false)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nLogical Error!!!\nThe input Element is not present in the array!!! ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto replacecase3;
                                    }
                                    else
                                    {
                                        Console.Write("Enter the element that you want to Replace on in the replacement of element {0}: ", tempnofelement);
                                        int element = int.Parse(Console.ReadLine());
                                        a[tempnofelement] = element;

                                    }

                                } //replace case 3 method1 arrayA
                                else if (selectionofarray == 'b')
                                {

                                    Console.ForegroundColor = ConsoleColor.Magenta;

                                    Console.WriteLine("----------REPLACEMENT BY ELEMENT----------");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT AND YOU CAN ONLY REPLACE UPTO INDEX #{3} ", arraysizeofB, mysum2, b[0], mysum2);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("\nWhich element you want to Replace: ");
                                    tempnofelement = int.Parse(Console.ReadLine());
                                    bool x = Program.search2(tempnofelement);
                                    if (x == false)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nLogical Error!!!\nThe input Element is not present in the array!!! ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto replacecase3;
                                    }
                                    else
                                    {
                                        Console.Write("Enter the element that you want to Replace on in the replacement of element {0}: ", tempnofelement);
                                        int element = int.Parse(Console.ReadLine());
                                        b[tempnofelement] = element;

                                    }
                                }
                            } //replace case 3 METHOD1 arrayB


                            else if (replace == 2)
                            {
                                if (selectionofarray == 'a')
                                {
                                    Console.WriteLine("----------REPLACEMENT BY LAST DESIRED INDEX----------");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT AND YOU CAN ONLY REPLACE UPTO INDEX #{3}", arraysizeofA, mysum, a[0], mysum);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Enter the index no on which you want to Replace: ");
                                    int index = int.Parse(Console.ReadLine());
                                    bool y = Program.replace(index);
                                    if (y == false)
                                    {
                                        goto replacecase3;
                                    }


                                }
                                else if (selectionofarray == 'b')
                                {

                                    Console.WriteLine("----------REPLACEMENT BY LAST DESIRED INDEX----------");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT AND YOU CAN ONLY REPLACE UPTO INDEX #{3}", arraysizeofB, mysum2, b[0], mysum2);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Enter the index no on which you want to Replace: ");
                                    int index = int.Parse(Console.ReadLine());
                                    bool y = Program.replace2(index);
                                    if (y == false)
                                    {
                                        goto replacecase3;
                                    }


                                }


                            }





                            break;

                        //THIS IS ENDNG OF REPLACING ARRAYS.....................

                        case 4:
                            int delete = 0;
                            mainclass c4 = new mainclass();
                        CASE4DELETE:
                            try
                            {
                                delete = c4.DELETEARRAY();
                            }
                            catch (Exception)
                            {
                                mainclass ex = new mainclass();
                                ex.invalidinput();
                                Console.WriteLine("press any key to go back.....");
                                Console.ReadKey();
                                Console.Clear();
                                goto CASE4DELETE;
                            }

                            if (delete == 1)
                            {
                                if (selectionofarray == 'a')
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("----------REPLACEMENT BY ELEMENT----------");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT AND YOU CAN ONLY REPLACE UPTO INDEX #{3} ", arraysizeofA, mysum, a[0], mysum);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("\nWhich element you want to Delete: ");
                                    tempnofelement = int.Parse(Console.ReadLine());
                                    bool x = Program.delete(tempnofelement);
                                    if (x == false)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nLogical Error!!!\nThe input Element is not present in the array!!! ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto CASE4DELETE;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The element {0} has been deleted successfully!!!", tempnofelement);
                                    }


                                }

                                else if (selectionofarray == 'b')
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("----------REPLACEMENT BY ELEMENT----------");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT AND YOU CAN ONLY REPLACE UPTO INDEX #{3} ", arraysizeofB, mysum2, b[0], mysum2);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("\nWhich element you want to Delete: ");
                                    tempnofelement = int.Parse(Console.ReadLine());
                                    bool x = Program.delete2(tempnofelement);
                                    if (x == false)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nLogical Error!!!\nThe input Element is not present in the array!!! ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto CASE4DELETE;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The element {0} has been deleted successfully!!!", tempnofelement);
                                    }


                                }



                            }

                            else if (delete == 2)
                            {
                                if (selectionofarray == 'a')
                                {
                                    Console.WriteLine("----------DELETION BY LAST DESIRED INDEX----------");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT AND YOU CAN ONLY REPLACE UPTO INDEX #{3}", arraysizeofA, mysum, a[0], mysum);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Enter the index no on which you want to Replace: ");
                                    int index = int.Parse(Console.ReadLine());
                                    bool y = Program.deletebyindex(index);
                                    if (y == false)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nLogical Error!!!\nThe input Element is not present in the array!!! ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto CASE4DELETE;
                                    }



                                }

                                else if (selectionofarray == 'b')
                                {

                                    Console.WriteLine("----------DELETION BY LAST DESIRED INDEX----------");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT AND YOU CAN ONLY REPLACE UPTO INDEX #{3}", arraysizeofB, mysum2, b[0], mysum2);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("Enter the index no on which you want to Replace: ");
                                    int index = int.Parse(Console.ReadLine());
                                    bool y = Program.deletebyindex2(index);
                                    if (y == false)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nLogical Error!!!\nThe input Element is not present in the array!!! ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto CASE4DELETE;
                                    }


                                }


                            }

                            break;
                        //THIS IS ENDNG OF deleting ARRAYS.....................


                        case 5:
                            int search = 0;

                        c55:

                            mainclass c5 = new mainclass();
                            try
                            {
                                search = c5.search();
                            }
                            catch (Exception)
                            {
                                mainclass ex = new mainclass();
                                ex.invalidinput();
                                Console.WriteLine("press any key to go back.....");
                                Console.ReadKey();
                                Console.Clear();
                                goto c55;
                            }

                            if (search == 1)
                            {
                                if (selectionofarray == 'a')
                                {

                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("----------SEARCH  BY ELEMENT----------");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT AND YOU CAN ONLY REPLACE UPTO INDEX #{3} ", arraysizeofA, mysum, a[0], mysum);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("\nWhich element you want to Search: ");
                                    tempnofelement = int.Parse(Console.ReadLine());
                                    int x = Program.searchbyelements(tempnofelement);
                                    if (x == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nLogical Error!!!\nThe input Element is not present in the array!!! ");
                                        Console.ForegroundColor = ConsoleColor.White;

                                    }
                                    else
                                    {
                                        Console.WriteLine("The element {0} is present on index# {1}", tempnofelement, x);

                                    }

                                }

                                else if (selectionofarray == 'b')
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("----------SEARCH  BY ELEMENT----------");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT AND YOU CAN ONLY REPLACE UPTO INDEX #{3} ", arraysizeofB, mysum2, b[0], mysum2);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("\nWhich element you want to Search: ");
                                    tempnofelement = int.Parse(Console.ReadLine());
                                    int x = Program.searchbyelements2(tempnofelement);
                                    if (x == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nLogical Error!!!\nThe input Element is not present in the array!!! ");
                                        Console.ForegroundColor = ConsoleColor.White;

                                    }
                                    else
                                    {
                                        Console.WriteLine("The element {0} is present on index# {1}", tempnofelement, x);

                                    }

                                }

                                else if (search == 2)
                                {
                                    if (selectionofarray == 'a')
                                    {
                                        Console.WriteLine("----------SEARCH BY LAST DESIRED INDEX----------");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT AND YOU CAN ONLY REPLACE UPTO INDEX #{3}", arraysizeofA, mysum, a[0], mysum);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write("Enter the index no on which you want to Replace: ");
                                        int index = int.Parse(Console.ReadLine());
                                        int y = Program.searchbyindex(index);
                                        if (y == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\nLogical Error!!!\nThe input Element is not present in the array!!! ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }

                                        else
                                        {
                                            Console.WriteLine("The element {0} is present on index# {1}", y, index);
                                        }


                                    }
                                    else if (selectionofarray == 'b')
                                    {
                                        Console.WriteLine("----------SEARCH BY LAST DESIRED INDEX----------");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nPHYSICALLY YOUR ARRAY SIZE IS {0} AND LOGICAL SIZE IS {1}\nYOU HAVE {2} AVAILABLE SPACE LEFT AND YOU CAN ONLY REPLACE UPTO INDEX #{3}", arraysizeofB, mysum2, b[0], mysum2);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write("Enter the index no on which you want to Replace: ");
                                        int index = int.Parse(Console.ReadLine());
                                        int y = Program.searchbyindex2(index);
                                        if (y == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\nLogical Error!!!\nThe input Element is not present in the array!!! ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }

                                        else
                                        {
                                            Console.WriteLine("The element {0} is present on index# {1}", y, index);
                                        }

                                    }

                                }

                            }


                            break;
                        //ending of case 5........................................
                        case 6:
                            int sort = 0;
                        c66:

                            //starting of case 6 sorting the algorithm........................................
                            mainclass c6 = new mainclass();
                            try
                            {
                                sort = c6.sort();
                            }
                            catch (Exception)
                            {
                                mainclass ex = new mainclass();
                                ex.invalidinput();
                                Console.WriteLine("press any key to go back.....");
                                Console.ReadKey();
                                Console.Clear();
                                goto c66;
                            }

                            switch (sort)
                            {
                                case 1:
                                    if (selectionofarray == 'a')
                                    {
                                        Program.insertion(a, mysum);
                                    }
                                    else
                                        if (selectionofarray == 'b')
                                        {
                                            Program.insertion(b, mysum2);

                                        }
                                    Console.WriteLine("Insertion Sort has been Applied!!!!!");
                                    break;
                                //end of insertion sort............

                                case 2:
                                    if (flaga == 1 && flagB == 1)
                                    {
                                        Program.mergedsort(c, mysum, mysum2);
                                        Console.WriteLine("Merge Sort has been Applied!!!!!");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Warning!!!!\nThere is no other Array to merged....\ncreate both arrays 1st!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }


                                    break;
                                //end of insertion sort............

                                case 3:

                                    if (selectionofarray == 'a')
                                    {
                                        Program.bubblesort(a);
                                    }
                                    else if (selectionofarray == 'b')
                                    {
                                        Program.bubblesort(b);
                                    }
                                    Console.WriteLine("Bubble Sort has been Applied!!!!!");


                                    break;



                                default:
                                    mainclass d = new mainclass();
                                    d.invalidinput();
                                    break;
                            }



                            break;

                        //ending of case 6........................................

                        case 7:
                        c77:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("----------------------------DISPLAYING THE ARRAY----------------------------");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n1-Display Array A");
                            Console.WriteLine("\n2-Display Array B");
                            Console.WriteLine("\n3-Display Array C");
                            Console.WriteLine("\n4-Display Array A and B");
                            int dis = 0;
                            Console.Write("Which array you want to display:");
                            try
                            {
                                dis = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                mainclass ex = new mainclass();
                                ex.invalidinput();
                                Console.WriteLine("press any key to go back.....");
                                Console.ReadKey();
                                Console.Clear();
                                goto c77;
                            }

                            if (dis == 1)
                            {

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                                Console.Write("Array A: ");

                                if (A == 1)
                                {
                                    Program.display(mysum);

                                }

                                else
                                {

                                    mainclass ob1 = new mainclass();
                                    ob1.emptyarray();
                                }
                            }
                            else if (dis == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                                Console.Write("Array B: ");
                                if (B == 1)
                                {
                                    Program.display2(mysum2);
                                }

                                else
                                {
                                    mainclass ob1 = new mainclass();
                                    ob1.emptyarray();

                                }

                            }
                            else if (dis == 3)
                            {
                                if (A == 1 && B == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("\n\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                                    Console.Write("Array C: ");
                                    Program.displayArrayC();

                                }

                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Array A or Array B is empty....\nInsert elements in Array A And B ");

                                }

                            }
                            else if (dis == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                                Console.Write("ARRAY A: ");

                                if (A == 1)
                                {
                                    Program.display(mysum);

                                }
                                else
                                {
                                    mainclass ob1 = new mainclass();
                                    ob1.emptyarray();

                                }
                                Console.WriteLine("\n\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                                Console.Write("ARRAY B: ");
                                if (B == 1)
                                {
                                    Program.display2(mysum2);
                                }
                                else
                                {
                                    mainclass ob1 = new mainclass();
                                    ob1.emptyarray();

                                }


                            }

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

                            Console.WriteLine();

                            break;

                        case 8:
                            int switching = 0;
                        c88:
                            mainclass C8 = new mainclass();
                            try
                            {
                                switching = C8.switchingarray();
                            }
                            catch (Exception)
                            {
                                mainclass ex = new mainclass();
                                ex.invalidinput();
                                Console.WriteLine("press any key to go back.....");
                                Console.ReadKey();
                                Console.Clear();
                                goto c88;
                            }


                            if (switching == 1)
                            {
                                if (selectionofarray == 'a')
                                {
                                    Console.WriteLine("You Are Already standing at Array A!");
                                }
                                else
                                {
                                    if (flaga == 1)
                                    {
                                        selectionofarray = 'a';
                                        Console.WriteLine("You have been swtiched to Array A");

                                    }
                                    else
                                    {
                                        Console.WriteLine("You Have not created Array A yet....");
                                        Console.WriteLine("press any key to create array A");
                                        Console.ReadKey();
                                        goto l1;

                                    }

                                }

                            }
                            else if (switching == 2)
                            {
                                if (selectionofarray == 'b')
                                {
                                    Console.WriteLine("You Are Already standing at Array B!");
                                }
                                else
                                {
                                    if (flagB == 1)
                                    {
                                        selectionofarray = 'b';
                                        Console.WriteLine("You have been swtiched to Array B");

                                    }
                                    else
                                    {
                                        Console.WriteLine("You Have not created Array B yet....");
                                        Console.WriteLine("press any key to create array B");
                                        Console.ReadKey();
                                        goto l2;

                                    }

                                }

                            }


                            break;

                        case 9:
                             Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("----------------------------APPENDING THE ARRAY A AND B----------------------------");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                            Program.append(mysum, mysum2);

                            break;

                        default:
                            mainclass d2 = new mainclass();
                            d2.invalidinput();
                            break;
                    }


                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\npress 'm' or 'M' to go in the Main Menu");
                    Console.ReadKey();
                    Console.Clear();
                    goto Main;
                }
                catch (Exception)
                {
                    mainclass ex = new mainclass();
                    ex.invalidinput();
                    Console.WriteLine("press any key to go back.....");
                    Console.ReadKey();
                    Console.Clear();
                    goto Main;
                }
            //------------------------------------------------------------------------------------
            //unreachablecode.
            l1:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("============================CREATING AN ARRAY A============================");
                Console.ForegroundColor = ConsoleColor.White;

                if (flaga == 0)
                {

                    Console.Write("\nwhat physical size you want to allocate: ");
                    arraysizeofA = int.Parse(Console.ReadLine());
                    flaga = 1;

                    for (int i = 1; i <= arraysizeofA; i++) //error ha yhn exception lgani ha
                    {
                        a[i] = -12345678;
                    }
                    a[0] = arraysizeofA;
                    if (arraysizeofA <= 0 || arraysizeofA > 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nLogical Error!!!\nphysical memory cannot exceed the input value!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("press any key to continue....");
                        Console.ReadKey();
                        goto l1;
                    }

                    Console.WriteLine("\nThe array of size " + arraysizeofA + " has been created!!! ");
                    Console.WriteLine("You have been swtiched to Array A");
                    selectionofarray = 'a';
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\npress 'm' or 'M' to go in the Main Menu");
                Console.ReadKey();
                Console.Clear();
                goto Main;

            l2:

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("============================CREATING AN ARRAY B============================");
                Console.ForegroundColor = ConsoleColor.White;
                if (flagB == 0)
                {

                    Console.Write("\nwhat physical size you want to allocate: ");
                    arraysizeofB = int.Parse(Console.ReadLine());
                    flagB = 1;

                    for (int i = 1; i <= arraysizeofB; i++) //error ha yhn exception lgani ha
                    {
                        b[i] = -12345678;
                    }
                    b[0] = arraysizeofB;
                    if (arraysizeofB <= 0 || arraysizeofB > 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nLogical Error!!!\nphysical memory cannot exceed the input value!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("press any key to continue....");
                        Console.ReadKey();
                        goto l2;
                    }
                    Console.WriteLine("\nThe array of size " + arraysizeofB + " has been created!!! ");
                    selectionofarray = 'b';
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\npress 'm' or 'M' to go in the Main Menu");
                Console.ReadKey();
                Console.Clear();
                goto Main;








            }
        }



        //insert method
        public static void insertbyindex(int index)
        {

            if (index >= mysum)
            {

                return;
            }
            else
            {
                Console.Write("Enter the element that you want to insert on index {0}: ", index);
                int element = int.Parse(Console.ReadLine());
                for (int i = (mysum + 1); i >= index; i--)
                {

                    if (i == index)
                    {
                        a[i] = element;
                        break;
                    }

                    a[i] = a[i - 1];

                }
                mysum++;
            }


        }
        //end of method insertbyindex....

        public static void display(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.Write(a[i]);
                }
                else
                {
                    Console.Write(a[i] + " , ");
                }
            }

        }




        public static void display2(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.Write(b[i]);
                }
                else
                {
                    Console.Write(b[i] + " , ");
                }
            }

        } //DISPLAY METHOD END.....


        //search method
        public static bool search(int element)
        {
            bool x = false;
            for (int i = 1; i <= mysum; i++)
            {
                if (a[i] == element)
                {
                    a[i] = element;
                    x = true;
                }
            }
            return x;
        }//end of method
        public static bool search2(int element)
        {
            bool x = false;
            for (int i = 1; i <= mysum2; i++)
            {
                if (b[i] == element)
                {
                    b[i] = element;
                    x = true;
                }
            }
            return x;
        }//end of method


        public static bool replace(int index)
        {
            bool x;
            if (index > mysum)
            {

                x = false;
            }
            else
            {
                Console.WriteLine("Enter the element that you want to Replace on index {0}: ", index);
                int element = int.Parse(Console.ReadLine());
                a[index] = element;

                x = true;
            }
            return x;

        }//end of method

        public static bool replace2(int index)
        {
            bool x;
            if (index > mysum2)
            {

                x = false;
            }
            else
            {
                Console.WriteLine("Enter the element that you want to Replace on index {0}: ", index);
                int element = int.Parse(Console.ReadLine());
                b[index] = element;

                x = true;
            }
            return x;

        }//end of method



        public static bool delete(int element)
        {
            bool x = false;
            for (int i = 1; i <= mysum; i++)
            {
                if (a[i] == element)
                {
                    a[i] = a[i + 1];
                    mysum--;
                    x = true;
                }


            }

            return x;

        }//end of method
        public static bool delete2(int element)
        {
            bool x = false;
            for (int i = 1; i <= mysum2; i++)
            {
                if (b[i] == element)
                {
                    b[i] = b[i + 1];
                    mysum2--;
                    x = true;
                }


            }

            return x;

        }//end of method
        public static bool deletebyindex(int index)
        {
            bool x = false;
            for (int i = 1; i <= mysum; i++)
            {
                if (a[i] == index)
                {
                    a[i] = a[i + 1];
                    mysum--;
                    x = true;
                }
            }


            return x;
        } //end of method

        public static bool deletebyindex2(int index)
        {
            bool x = false;
            for (int i = 1; i <= mysum2; i++)
            {
                if (b[i] == index)
                {
                    b[i] = b[i + 1];
                    mysum2--;
                    x = true;
                }
            }


            return x;
        } //end of method


        public static int searchbyelements(int element)
        {
            int index = 0;
            for (int i = 1; i <= mysum; i++)
            {
                if (a[i] == element)
                {
                    index = i;
                }

            }
            return index;

        }  //end of method

        public static int searchbyelements2(int element)
        {
            int index = 0;
            for (int i = 1; i <= mysum2; i++)
            {
                if (b[i] == element)
                {
                    index = i;
                }

            }
            return index;

        }  //end of method
        public static int searchbyindex(int index)
        {
            int element = 0;
            for (int i = 1; i <= mysum; i++)
            {
                if (i == index)
                {
                    element = a[i];
                }


            }

            return element;
        }//end of method
        public static int searchbyindex2(int index)
        {
            int element = 0;
            for (int i = 1; i <= mysum2; i++)
            {
                if (i == index)
                {
                    element = b[i];
                }


            }

            return element;
        }//end of method

        public static int[] insertion(int[] x,int sizeofarray)
        {
            for (int i = 1; i <= sizeofarray; i++)
            {
                int j = i;
                while (j > 1)
                {
                    if (x[j - 1] > x[j])
                    {


                        int temp = x[j - 1];
                        x[j - 1] = x[j];
                        x[j] = temp;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            return x;

        } //end of method

        public static int[] bubblesort(int[] a)
        {
            int temp;
            //, n = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    if (a[i] >= a[j])
                    {
                        //  n = n + 2;
                        temp = a[i];
                        // n = n + 2;
                        a[i] = a[j];
                        // n = n + 2;
                        a[j] = temp;
                        //   n = n + 2;

                    }

                }

            }
            return a;
        }

        //end of bubble sort
        public static int[] mergedsort(int[] c, int sizeofarrayA, int sizeofarrayB)
        {

            int p = 1, q = 1;
            for (int i = 1; i <= (sizeofarrayA + sizeofarrayB); i++)
            {

                if (p > sizeofarrayA)
                {
                    c[i] = b[q];
                    if (q < sizeofarrayB)
                    {
                        q++;
                    }

                }


                else if (q > sizeofarrayB)
                {
                    c[i] = a[p];

                    if (p < sizeofarrayA)
                    {
                        p++;
                    }
                }

                else
                {
                    if (a[p] <= b[q])
                    {
                        c[i] = a[p];
                        p++;
                    }
                    else
                    {
                        c[i] = b[q];
                        q++;
                    }
                }
            }
            return c;
        }

        //end of merged sort

        public static void displayArrayC()
        {

            for (int i = 1; i <= (mysum + mysum2); i++)
            {
                if (i == (mysum + mysum2))
                {
                    Console.WriteLine(c[i]);
                }
                else
                {
                    Console.Write(c[i] + " , ");
                }
            }
           
            
        }
        //end of displaying c
public static void append(int sizeoA,int sizeoB)
        {
            int x = 0;
            for (int i = 1; i <=(sizeoA+sizeoB) ; i++)
            {

                if (i<=sizeoA)
                {
                    Console.Write(a[i]+", ");
                    x++;
                }
                else
                {
                    Console.Write(b[i-x] + ", ");

                }


            }



        }

    }
}
