using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9.Models
{
    public class Game
    {
        public readonly string _person;
        private int _damage;
        public int Hp;
        private int _heal;
        public Game(string Person, int Damage, int HP, int Heal)
        {
            _person = Person;
            _damage = Damage;
            Hp = HP;
            _heal = Heal;
        }

        public void Hit(Game enemy)
        {
            enemy.Hp = enemy.Hp - this._damage;
        }

        public void Healing(Game character)
        {
            character.Hp = character.Hp + this._heal;
        }
    }
}
