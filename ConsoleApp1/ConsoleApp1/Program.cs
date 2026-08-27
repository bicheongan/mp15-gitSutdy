using System;
class Program
{
    static void Main(string[] args)
    {
        Monster monster = new Monster();

        monster.Name = "몬스터";
        monster.Health = 100;
        monster.Damage = 30;
        monster.Attack();
    }

}