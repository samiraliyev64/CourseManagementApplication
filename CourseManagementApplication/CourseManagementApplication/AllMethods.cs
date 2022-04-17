using System;
using System.Collections.Generic;
using System.Text;
using static CourseManagementApplication.Group;

namespace CourseManagementApplication
{
    class AllMethods
    {
            //Methods

            //Creates new group
            public static void CreateGroup()
            {
                string metn = String.Empty;
                bool isOnline = false;
                Category category = 0;
                try
                {
                    Console.Write("Category : 1.Programming  2.Design  3.System Adminstration\n\nChoose your category : "); //Category
                    category = (Category)Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception)
                {
                    throw new FormatException("null or wrong format");
                }

                if ((int)category < 1 || (int)category > 3)
                {
                    metn = "daxil etdiyiniz input secimlerde yoxdur";
                    Console.WriteLine(metn);
                    return;
                }
                else
                {
                    try
                    {
                        Console.Write("Is online : "); //isOnline
                        isOnline = Convert.ToBoolean(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        throw new FormatException("yalniz true ve ya false inputlarini daxil ede bilersiniz");
                    }
                }
                Group newGroup = new Group(category, isOnline);
                groupsList.Add(newGroup);

            }

            //Shows all groups
            public static void ShowGroups()
            {
                if (groupsList.Count == 0)
                {
                    Console.WriteLine("Qrup listi boshdur");
                    return;
                }
                foreach (var item in groupsList)
                {
                    Console.WriteLine($"No : {item.No}, Category : {item.category}, Student count : {item.StuCount}");
                }
            }

            //Edit group
            public static void EditGroup()
            {
                EditMethod();
            }

            //Show students in groups
            public static void ShowGroupStudents()
            {
                Console.Write("Qrupun nomresini daxil edin : ");
                string groupName = Console.ReadLine();
                bool isExist = false;

                if (studentsList.Count == 0)
                {
                    Console.WriteLine("umumiyyetle telebe yoxdur");
                    return;
                }
                else
                {
                    for (int i = 0; i < studentsList.Count; i++)
                    {
                        if (groupName == studentsList[i].GroupNo)
                        {
                            isExist = true;
                            Console.WriteLine($"Fullname : {studentsList[i].FullName}, Group No : {studentsList[i].GroupNo}, Type : {studentsList[i].Type}\n");
                        }
                    }
                }
                if (isExist == false)
                {
                    Console.WriteLine("bele qrup yoxdur");
                }
            }

            //Shows all students
            public static void ShowAllStudents()
            {
                if (studentsList.Count == 0)
                {
                    Console.WriteLine("Student listi boshdur");
                }
                foreach (var item in studentsList)
                {
                    Console.WriteLine($"Fullname : {item.FullName}, Group No : {item.GroupNo},  isOnline : {item.Type}\n");
                }
            }

            //Creates student
            public static void CreateStudent()
            {
                Console.Write("\nFullname : "); //FullName
                string userFullName = Console.ReadLine();

                Console.Write("Type : "); //Type
                bool userType = Convert.ToBoolean(Console.ReadLine());

                Console.Write("1.Programming  2.Design  3.System Adminstration\n\nGroup No : "); //Group No
                Category userGroupNo = (Category)Convert.ToInt32(Console.ReadLine());
                if ((int)userGroupNo < 1 || (int)userGroupNo > 3)
                {
                    string metn = "daxil etdiyiniz input secimlerde yoxdur";
                    Console.WriteLine(metn);
                    return;
                }

                Student newStudent = new Student(userFullName, userGroupNo, userType);

                Console.Write("Which group : ");
                string groupName = Console.ReadLine();
                bool isExist = false;
                switch (userGroupNo)
                {
                    case Category.Programming:
                        foreach (var item in groupsList)
                        {
                            if (groupName == item.No)
                            {
                                newStudent.GroupNo = groupName;
                                item.StuCount++;
                                programmingStudentsList.Add(newStudent);
                                isExist = true;
                            }
                        }
                        break;
                    case Category.Design:
                        foreach (var item in groupsList)
                        {
                            if (groupName == item.No)
                            {
                                newStudent.GroupNo = groupName;
                                item.StuCount++;
                                designStudentsList.Add(newStudent);
                                isExist = true;
                            }
                        }
                        break;
                    case Category.SysAdmin:
                        foreach (var item in groupsList)
                        {
                            if (groupName == item.No)
                            {
                                newStudent.GroupNo = groupName;
                                item.StuCount++;
                                sysadminStudentsList.Add(newStudent);
                                isExist = true;
                            }
                        }
                        break;
                    default:
                        break;
                }
                if (isExist == true)
                {
                    studentsList.Add(newStudent);
                }
                else
                {
                    Console.WriteLine("Olmayan qrupa telebe elave ede bilmezsen");
                }

            }

            //Edit method
            public static void EditMethod()
            {
                Console.Write("Category : 1.Programming  2.Design  3.System Adminstration\n\nChoose your category : "); //Category
                Category category = (Category)Convert.ToInt32(Console.ReadLine());
                switch (category)
                {
                    case Category.Programming:
                        Console.Write("Hansi qrupun nomresin deyiwmek isteyirsiniz : ");
                        string noInput = Console.ReadLine();
                        bool isExist = false;
                        bool isExist2 = false;
                        foreach (var item in groupsList)
                        {
                            if (item.No == noInput)
                            {
                                Console.Write("Qrupun yeni nomresi : ");
                                Bp = Convert.ToInt32(Console.ReadLine());

                                foreach (var group in groupsList)
                                {
                                    if (group.No == $"BP{Bp}")
                                    {
                                        isExist2 = true;
                                    }
                                }
                                if (isExist2 == true)
                                {
                                    Console.WriteLine("bele bir qrup artiq var");
                                    break;
                                }
                                else
                                {
                                    item.No = $"BP{Bp}";
                                }

                                isExist = true;
                                break;
                            }
                        }
                        if (isExist2 == true)
                        {
                            break;
                        }
                        if (isExist == false)
                        {
                            Console.WriteLine("daxil etdiyiniz input qrup listinde yoxdur ");
                        }
                        break;

                    case Category.Design:
                        Console.Write("Hansi qrupun nomresin deyiwmek isteyirsiniz : ");
                        noInput = Console.ReadLine();
                        isExist = false;
                        isExist2 = false;
                        foreach (var item in groupsList)
                        {
                            if (item.No == noInput)
                            {
                                Console.Write("Qrupun yeni nomresi : ");
                                Dn = Convert.ToInt32(Console.ReadLine());

                                foreach (var group in groupsList)
                                {
                                    if (group.No == $"DN{Dn}")
                                    {
                                        isExist2 = true;
                                    }
                                }
                                if (isExist2 == true)
                                {
                                    Console.WriteLine("bele bir qrup artiq var");
                                    break;
                                }
                                else
                                {
                                    item.No = $"DN{Dn}";
                                }

                                isExist = true;
                                break;
                            }
                        }
                        if (isExist2 == true)
                        {
                            break;
                        }
                        if (isExist == false)
                        {
                            Console.WriteLine("daxil etdiyiniz input qrup listinde yoxdur ");
                        }
                        break;
                    case Category.SysAdmin:
                        Console.Write("Hansi qrupun nomresin deyiwmek isteyirsiniz : ");
                        noInput = Console.ReadLine();
                        isExist = false;
                        isExist2 = false;
                        foreach (var item in groupsList)
                        {
                            if (item.No == noInput)
                            {
                                Console.Write("Qrupun yeni nomresi : ");
                                Sys = Convert.ToInt32(Console.ReadLine());

                                foreach (var group in groupsList)
                                {
                                    if (group.No == $"Sys{Sys}")
                                    {
                                        isExist2 = true;
                                    }
                                }
                                if (isExist2 == true)
                                {
                                    Console.WriteLine("bele bir qrup artiq var");
                                    break;
                                }
                                else
                                {
                                    item.No = $"Sys{Sys}";
                                }

                                isExist = true;
                                break;
                            }
                        }
                        if (isExist2 == true)
                        {
                            break;
                        }
                        if (isExist == false)
                        {
                            Console.WriteLine("daxil etdiyiniz input qrup listinde yoxdur ");
                        }
                        break;
                    default:
                        Console.WriteLine("bele bir kateqoriya yoxdur");
                        break;
                }
            }
        }
    }

