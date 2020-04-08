using UnityEngine;

public class EnemyManager : MonoBehaviour
{
     public Enemy enemy1;
     public Enemy enemy2;

    private void Start()
    {
        print("怪物一號的魔力:" + enemy1.MP + ",怪物二號的裝備名稱:" + enemy2.Equip+"");

        enemy1.HP = 100;
        enemy2.HP = 300;
        enemy1.Defense = 50;
        enemy1.Arms = "木棍";
        enemy2.Arms = "短刀";
        enemy1.Key = true;
        enemy2.Treasure = true;
    }
}
