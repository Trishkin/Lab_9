using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9.Models
{
    delegate int Operation(int x, int y);
    public class Game
    {
        Operation operation = (x, y) => x - y;
        Operation operation2 = (x, y) => x + y;

        public delegate void GameHandler(string message);
        public event GameHandler Notify;

        public readonly string _person;
        private int _damage;
        public int Hp;
        private int _heal;
        public Game(string Person, int HP, int Damage, int Heal)
        {
            _person = Person;
            _damage = Damage;
            Hp = HP;
            _heal = Heal;
        }

        public void Hit(Game enemy)
        {
            enemy.Hp = operation(enemy.Hp , this._damage);
            Notify?.Invoke($"{this._person} нанес {this._damage} урона {enemy._person}");
        }

        public void Healing(Game character)
        {
            character.Hp = operation2(character.Hp , this._heal);
            Notify?.Invoke($"{this._person} полечил {character._person} на {this._heal}");
        }

        public void Status()
        {
            Console.WriteLine($"Name = {_person}, HP = {Hp}, damage = {_damage}, heal = {_heal}");
        }
    }
}
