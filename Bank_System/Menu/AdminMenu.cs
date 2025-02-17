namespace Bank_System;

public static class AminMenu
{
    public static void Menu()
    {
        Console.WriteLine("Меню администратора");
        Console.WriteLine("1) Изменить логин");
        Console.WriteLine("2) Изменить пароль");
        Console.WriteLine("3) Пользователи"); //Todo: Menu
        Console.WriteLine("4) Статистика"); //
        Console.WriteLine("0) Выйти");

        int action = MainMenu.GetActionMenu(4);
        
        switch (action)
        {
            case 1:
                Console.WriteLine("Изменить логин");
                //Todo: Изменить логин админ
                break;
            case 2:
                Console.WriteLine("Изменить пароль");
                //Todo: Изменить пароль админ
                break;
            case 3:
                MenuUsers();
                break;
            case 4:
                Console.WriteLine("Статистика");
                MenuStatistic();
                break;
            case 0:
                return;
        }

        Menu();
    }

    public static void MenuUsers()
    {
        // TODO: принтим всех пользователей
        // ФИО
        // дата рождения
        // id
        // номер телефона
        // Список карт - кроме PIN
        
        // -----Вынестив в отельный метод для поиска пользователя ----- //
        Console.WriteLine("Введите ФИО или ID пользователя, для получаения большей информации о нём. Enter - вернутся назад");
        string findUserData = Console.ReadLine();
        if (findUserData.Trim().Length == 0)
            return;
        // Todo: ищем пользователя
        // выводим инфу о найденом пользователе если нет запрашиваем еще раз 
        // ----- //
        
        // если есть заблокированные карты выводим вариант выбор вариант 1 и 0 если нет то только 0
        Console.WriteLine("1) Разблокировать карту");
        Console.WriteLine("0) Вернуться назад");
        int action = MainMenu.GetActionMenu(1);
        switch (action)
        {
            case 1:
                Console.WriteLine("1) Разблокировать карту");
                //Todo: разблокировать карту 
                break;
            case 2:
                Console.WriteLine("0) Вернуться назад");
                //Todo: Статистика
                break;
            case 0:
                return;
        }

        MenuUsers();
    }
    
    public static void MenuStatistic()
    {
        Console.WriteLine("Статистика");
        Console.WriteLine("1) Заработок на комиссиях по конкретному пользователю");
        Console.WriteLine("2) Заработок на комиссиях со всех пользователей");
        Console.WriteLine("0) Выйти");

        int action = MainMenu.GetActionMenu(2);
        
        switch (action)
        {
            case 1:
                Console.WriteLine("Заработок на комиссиях по конкретному пользователю");
                //Todo: Заработок на комиссиях по конкретному пользователю
                // предлагаем сохранить в текстовый файл
                break;
            case 2:
                Console.WriteLine("Заработок на комиссиях по всем пользователям");
                // ФИО: 1031.4 UAH
                // ФИО: 25.4 UAH
                // Сума: 1031.4 + 25.4 UAH
                //Todo: Заработок на комиссиях со всех пользователей - потом предлаем сохрнаить в текстовый файл
                break;
            case 0:
                return;
        }

        MenuStatistic();
    }
}