using System;

class Program
{
    static void Main()
    {
        //Task01();
        //Task02();
        Task03();
    }
    static void Task01()
    {
        Train[] trains = new Train[5]
         {
            new Train("Москва", "Владивосток", "ПМВ15", 160),
            new Train("Санкт-Петербург", "Новосибирск", "ПСН42", 100) ,
            new Train ("Казань", "Екатеринбург", "ПКЕ78", 120) ,
            new Train ("Сочи", "Калининград", "ПСК05",  180) ,
            new Train ("Владивосток", "Москва", "ПВМ99",  160) 
         };
        TrainHelper helper = new TrainHelper();
        Train find;
        Train findBiggestSeats;

        Console.Write("Введите номер поезда: ");
        string input = Console.ReadLine();

        if ((find = helper.FindTrain(trains, input)) != null)
        {
            helper.PrintTrain(find);
        }
        else
        {
            Console.WriteLine("Введен не существующий поезд.");
        }
        Console.WriteLine();
        helper.PrintTrain(helper.FindBigNumberOfSeats(trains));
        Console.WriteLine();
        Console.WriteLine("SORT");
        helper.SortByNumber(trains);
        for (int i = 0;  i < trains.Length; i++)
        {
            helper.PrintTrain(trains[i]);
        }
    }
    static void Task02()
    {
        List<Product> list = new List<Product>
        {
            new Product("Молоко 'Домик в деревне'", "Молочные продукты", "Молоко коровье, нормализованное", 14),
            new Product("Хлеб 'Бородинский'", "Хлебобулочные изделия", "Мука ржаная, вода, соль, дрожжи, патока", 5),
            new Product("Йогурт 'Чудо' клубничный", "Молочные продукты", "Молоко, сахар, клубничное пюре, закваска", 30),
            new Product("Чипсы 'Lays' со вкусом сыра", "Снеки", "Картофель, растительное масло, сырный порошок, соль", 180),
            new Product("Сок 'Добрый' апельсиновый", "Соки", "Апельсиновый сок, вода, сахар", 365),
            new Product("Шоколад 'Alpen Gold' молочный", "Кондитерские изделия", "Какао-масло, сахар, сухое молоко, какао-порошок", 365),
            new Product("Колбаса 'Докторская'", "Мясные продукты", "Говядина, свинина, молоко, соль, специи", 30),
            new Product("Сыр 'Российский'", "Молочные продукты", "Молоко, закваска, соль, ферменты", 60),
            new Product("Пельмени 'Сибирские'", "Замороженные продукты", "Мука, говядина, свинина, лук, соль, перец", 180),
            new Product("Мороженое 'Магнат' пломбир", "Замороженные продукты", "Молоко, сливки, сахар, ванилин", 90)
        };
        ProductHelper helper = new ProductHelper();
        List<Product> findIngred = new List<Product>();
        List<Product> sortD = new List<Product>();
        Dictionary<string, int> findTypes = new Dictionary<string, int>();

        Console.Write("Введите ингридиент: ");
        findIngred = helper.CheckIngredients(list, Console.ReadLine());
        helper.PrintProducts(findIngred);

        Console.WriteLine("DICTIONARY");
        findTypes = helper.SearchProductTypesCategory(list);
        helper.PrintProductsSearchCategory(findTypes);

        Console.WriteLine("SORT");
        sortD = helper.SortShelLifeDescending(list);
        helper.PrintProducts(sortD);
    }
    static void Task03()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Иванов", "Иван", "Иванович", "ул. Ленина, 10", 2013, "Кибербезопасность"),
            new Employee("Петрова", "Анна", "Сергеевна", "пр. Мира, 25", 2018, "Кибербезопасность"),
            new Employee("Сидоров", "Алексей", "Петрович", "ул. Гагарина, 7", 2020, "Инженер-программист"),
            new Employee("Кузнецова", "Елена", "Дмитриевна", "ул. Садовая, 15", 2017, "HR-Кибербезопасность"),
            new Employee("Смирнов", "Дмитрий", "Алексеевич", "ул. Центральная, 3", 2019, "Кибербезопасность администратор"),
            new Employee("Васильева", "Ольга", "Игоревна", "пр. Победы, 12", 2016, "Инженер-программист"),
            new Employee("Федоров", "Михаил", "Сергеевич", "ул. Лесная, 8", 2021, "Инженер-программист"),
            new Employee("Николаева", "Лена", "Владимировна", "ул. Школьная, 22", 2013, "Инженер-программист"),
            new Employee("Козлов", "Артем", "Андреевич", "ул. Молодежная, 5", 2022, "Инженер-программист"),
            new Employee("Алексеева", "Светлана", "Павловна", "ул. Заречная, 17", 2013, "Инженер-программист")
        };
        List<Employee> findYear = new List<Employee>();
        List<Employee> findSort = new List<Employee>();
        List<Employee> findPost = new List<Employee>();

        EmployeeHelper helper  = new EmployeeHelper();

        findYear = helper.SearchGreatestExperience(employees);
        helper.PrintEmployees(findYear);

        Console.Write("Введите должность: ");
        findPost = helper.FindEmployeePost(employees, Console.ReadLine());
        helper.PrintEmployees(findPost);

        Console.WriteLine("SORT");
        findSort = helper.SortByValue(employees);
        helper.PrintEmployees(findSort);
    }
}