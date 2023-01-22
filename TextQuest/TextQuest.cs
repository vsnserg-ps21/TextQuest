using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextQuest
{
    // Класс персонажа
    class Character
    {
        // Имя персонажа
        public string Name { get; set; }

        // Количество жизней персонажа
        public int Health { get; set; }

        // Навык персонажа (волшебство, оружие и т.д.)
        public string Skill { get; set; }

        // Конструктор по умолчанию
        public Character()
        {
        }

        // Конструктор с параметрами
        public Character(string name, int health, string skill)
        {
            Name = name;
            Health = health;
            Skill = skill;
        }

        // Метод, описывающий действие персонажа
        public void DoAction()
        {
            Console.WriteLine($"{Name} использует свой навык {Skill}");
        }
    }
