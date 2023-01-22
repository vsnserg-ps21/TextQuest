namespace TextQuest
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // Создаем три персонажа
            Character character1 = new Character("Геральт", 100, "меч");
            Character character2 = new Character("Трисс", 50, "волшебство");
            Character character3 = new Character("Йеннифэр", 75, "лук");

            // Даем каждому персонажу совершить действие
            character1.DoAction();
            character2.DoAction();
            character3.DoAction();
        }
    }
}