namespace SessionOneLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Implecitly type

            //dynamic sum(dynamic x , dynamic y)
            //{
            //    return x + y;
            //}

            #endregion

            #region 1] implicitely typed local variable [var , dynamic]

            //****** var *********

            //var name = "Mariam";
            //name = "Joe";
            //name = null;// chage value
            //Console.WriteLine($"{name.GetType()}");

            //List<int> list = new List<int>();
            ////for (var i = 0 ; i < 10; i++) { };
            //foreach (var item in list)
            //{

            //}

            // Var ==>detegete the data type based on ontial value
            // var name01 = null;//Invaild
            // name = 10; // invalid (change datatype after intialization
            // can detegt the datatype baced on intiale value[complie time]

            //var name01; //invalid



            //********* dynamic *********

            //dynamic x = 10;
            //Console.WriteLine($"{x.GetType()}");
            //x = "Joe";
            //Console.WriteLine($"{x.GetType()}");

            ////dynamic ==> detect the data type based on last assigned value[RunTime - CLR]

            ////dynamic y;
            ////dynamic y = null;
            ////Console.WriteLine($"{y.GetType()}");
            //x = true;


            //var z = "Mariam";
            //z = 10;//invaild




            // ******** Var vs dynamic [scope & comparision] ********

            //var fun01()
            //{
            //    return 10
            //}

            //void fun01(var x)
            //{
            //    return x;
            //}

            //class test
            //{
            //    var x;
            //dynamic x;
            //}


            #endregion


            #region 2] Extention methodes

            // int x = 12345;
            // int reesult = IntExtentions.ReverseNum(x);
            // Console.WriteLine(reesult);

            //int result =  x.ReverseNum();
            // Console.WriteLine(reesult);



            //long x = 1235;
            //long res = IntExtentions.ReverseNum(x);
            //Console.WriteLine(res);



            //Console.WriteLine(x.ToString());
            //IntExtentions.ToString(x);

            #endregion


            #region 3] Anonymous type [Empolyee]
            //Employee employee = new Employee() { id = 1, name = "MAriam", salary = 1000 };
            //Console.WriteLine(employee.id);

            //object employee01 = new{ id = 1, name = "MAriam", salary = 1000 };
            ////Console.WriteLine(employee01.id);



            //**************Anonymous type**************
            // class : Object  ==> override tostring , print data
            //var emp = new { id = 1, name = "MAriam", salary = 1000F};
            //Console.WriteLine(emp.id);
            //Console.WriteLine(emp.name);
            //Console.WriteLine(emp.salary);
            //Console.WriteLine(emp.GetType().Name);


            //1] order of prop
            // 2] number of prop
            //3] name of prop

            //var emp02 = new { id = 2, name = "samy", salary = 2000F };
            //Console.WriteLine(emp02.id);
            //Console.WriteLine(emp02.name);
            //Console.WriteLine(emp02.salary);
            //Console.WriteLine(emp02.GetType().Name);


            //var emp03 = new { id = 3, Name = "Mariam", salary = 1000F };
            //Console.WriteLine(emp03.id);
            //Console.WriteLine(emp03.Name);
            //Console.WriteLine(emp03.salary);
            //Console.WriteLine(emp03.GetType().Name);


            //var emp04 = new { name = "joe", id = 5, salary = 1000F };
            //Console.WriteLine(emp04.id);
            //Console.WriteLine(emp04.name);
            //Console.WriteLine(emp04.salary);
            //Console.WriteLine(emp04.GetType().Name);



            //var emp05 = new { name = "joe", id = 5};
            //Console.WriteLine(emp05.id);
            //Console.WriteLine(emp05.name);
            //Console.WriteLine(emp05.GetType().Name);


            // ************ Array , ArrayList of anonymous type ****************
            //var studnts = new[]
            //{
            //new { name = "joe", id = 5, age = 20 },
            //new { name = "mohamed", id = 6, age = 21 }
            //};
            //foreach (var item in studnts)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            //var studnts = new ArrayList
            //{
            //  new { name = "joe", id = 5, age = 20 },
            //  new { name = "mohamed", id = 6},
            //  new { id = 1}

            //};

            //foreach (var item in studnts)
            //{
            //    Console.WriteLine($"{item} ");
            //}






            //string country = "Egypt", street = "Agoza";
            //var place = new
            //{
            //    country,
            //    street

            //};
            //Console.WriteLine(place);



            //******** Nested Anonymous Type **********
            // Empolyee [id , name] ==> Departement ==> DepID , DepNAme
            //var employee = new
            //{
            //    id = 1,
            //    nameof = "joe",
            //    departement = new { DepId = 1, DepName = "Cs" }
            //};
            //Console.WriteLine(employee);
            //Console.WriteLine(employee.departement.DepId);



            ////******** anonymous type inside array of anonymous type ***********
            //var order = new
            //{
            //    Id = 1,
            //    Name = "Order1",
            //    OrderItem = new[]
            //    {
            //        new { Id = 1 , ProductName = "Product1"},
            //        new { Id = 2, ProductName = "Product2"}
            //    }
            //};


            //Console.WriteLine(order.OrderItem);

            //foreach (var item in order.OrderItem)
            //{
            //    Console.WriteLine($"{item} ");
            //}
            #endregion



            #region with keyword
            //var emp = new { id = 1, name = "Joe", Salary = 1000 };
            //////emp.id = 5;//invaild

            ////var emp02 = new { id = 100,emp.name, emp.Salary };
            ////Console.WriteLine(emp02);

            //var emp02 = emp with { id = 100 };
            //Console.WriteLine(emp02); 
            #endregion

            #region LINQ [Language Integrated Query]


            // Use linq operators against sequance

            // //****** L2Object ********
            // List<int> number = [2, 12, 3, 4, 5, 6]; // static sequance
            //var evenNumbers = number.Where(p => p % 2 == 0);//call as extention method [list]
            // var evenNumbers02 = Enumerable.Where(number , p => p % 2 == 0);//call as extention method [list]
            // foreach (var num in evenNumbers)
            // {
            //     Console.WriteLine(num);
            // }
            // Console.WriteLine("****************");
            // foreach (var num in evenNumbers02)
            // {
            //     Console.WriteLine(num);
            // }
            #endregion


            #region LINQ synax

            //************* Flunet /method syntax ********
            // List<int> num = [1,2,3,4,5,6,7];
            ////*******  1. call linq operator as staitic method *******
            //var evenNum = Enumerable.Where(num, x => x % 2 == 0);
            ////********* 2. call linq operator as sextantion methodss **********
            //evenNum = num.Where(num => num % 2 == 0);
            //foreach (var i in evenNum)
            //{
            //    Console.WriteLine(i);
            //}


            //********** Quary syntax - [Like sql server style] *********
            /* 
             
             select *
            from numbers n
            where n%2 ==0
             */
            // execution order ==> 1} from , 2} where , 3} select
            // quary syntax ==> must start from , must end with select or groupby
            //var evenNum = from n in num
            //              where n%2 ==0
            //              select n;
            //foreach (var i in evenNum)
            //{
            //    Console.WriteLine(i);
            //}




            #endregion


            #region LINQ Exection way

            //1]******** execution deffered or lazy execution
            //[latest version of data] *********
            //where ==> deffered [LAzy linq operators]

            //List<int> numbers = [1,2,3,4,5,6,7,8,9];
            //var oddNum = numbers.Where(p => p % 2 == 1);
            //numbers.AddRange([12, 12, 11, 13, 14]);
            //foreach (var i in oddNum)
            //{
            //    Console.WriteLine(i);
            //}


            //2}***** execution immetidate or greedy execution
            //[current version of data] ************
            ////1} Aggregate Operators , 2} Element Operators , 3} casting Operators
            //List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            //var oddNum = numbers.Where(p => p % 2 == 1).ToList();// immediate
            //numbers.AddRange([12, 12, 11, 13, 14]);
            //foreach (var i in oddNum)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion


        }
    }
}
