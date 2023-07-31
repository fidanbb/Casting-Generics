
//unboxing-boxing

//int num = 5;
//object t = num;
//num = 100;

//Console.WriteLine(t);
//Console.WriteLine(num);


//int num = 5;
//object t = num;

//int j = (int)t;


//upcasting-downcasting

using ClassWorkCastingGenererics;

//Animal animal1 = new Animal();

//Fish fish1 = new Fish();
//Animal animal3 = fish1;

//Animal animal2 = new Fish();

//Fish fish3 = (Fish)animal2;

//Book book = new Book();

//object[] animals = { book, 1, "Salam", animal1, fish1, animal3, animal2, fish3 };

//foreach (var item in animals)
//{
//    Animal animal = item as Animal;

//    if (animal != null)
//    {
//        animal.Name = "canavar";
//        Console.WriteLine(animal.Name);
//    }

//    //if (item is Animal a)
//    //{
//    //    a.Name = "Tulku";
//    //    Console.WriteLine(a.Name);
//    //}

//    //if (item is Animal)
//    //{
//    //    ((Animal)item).Name = "Tulku";
//    //    Console.WriteLine(((Animal)item).Name);
//    //}

//}

//byte num1 = 5;
//int num2 = num1;

//int num1 = 500;

//byte num2 = (byte)num1;

//Console.WriteLine(num2);
//byte age = 50;
//int age2 = age;

//Test();

//static void Test(int? a=5)
//{
//    Test2((int)a);
//}


//static void Test2(int m)
//{

//}


//IntList intList = new IntList();

//intList.Add(5);
//intList.Add(15);
//intList.Add(5);
//intList.Add(15); 
//intList.Add(15);
//intList.Add(5);
//intList.Add(15);
//intList.Add(5);
//intList.Add(15);
//intList.Add(5);
//intList.Add(15);
//intList.Add(5);
//intList.Add(15);

//var result = intList.GetAll();

//foreach (var item in result )
//{
//    Console.WriteLine(item);
//}

//StringList stringList = new();

//stringList.Add("salam");

//stringList.Add("salamlar");

//var res = stringList.GetAll();

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}


//DataList<int> datas = new();

//datas.Add(1);
//datas.Add(2);
//datas.Add(3);
//datas.Add(4);

//var result = datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//DataList<string> words = new();

//words.Add("salam");
//words.Add("salam2");
//words.Add("salam3");
//words.Add("salam4");

//var list = words.GetAll();

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//DataList<bool> statuses = new();

//statuses.Add(true);
//statuses.Add(false);


//var listBool = statuses.GetAll();

//foreach (var item in listBool)
//{
//    Console.WriteLine(item);
//}

//DataList < Book > books= new();

//books.Add(new Book { Id=1,Name="Xosrov ve Shirin"});
//books.Add(new Book { Id = 2, Name = "Isgendername" });

//var result = books.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}

//Repository<string>data1 = new();

//Repository<Book> data2 = new Repository<Book>();
//Repository<bool> data3 = new Repository<bool>();

//Repository<Bird, Animal> animal = new Repository<Bird, Animal>();


//DataList<Book> books = new DataList<Book>();

//books.Add(new Book { Id = 1, Name = "Xosrov ve Shirin" });
//books.Add(new Book { Id = 2, Name = "Isgendername" });


//var result = books.GetById(1);

//Console.WriteLine(result.Name);