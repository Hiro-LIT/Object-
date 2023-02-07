using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Friendly
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddHp()
    {
        hp = hp + 10;
        DisplayHpValue();
    }

    public override void AddDamage()
    {
        int d = Random.RandomRange(1, 11);
        hp = hp - d;
        DisplayHpValue();
    }

    public override void OnAttack()
    {
        Debug.Log("Player�e�N�q�̂��������I");
        gameManager.EnemyDamage(attackPower);
        DisplayHpValue();
    }
    public override void OnSpSkill()
    {
        Debug.Log("Player�̃X�L�������IEnemy�֓�{��������!");
        gameManager.EnemyDamage(attackPower * 2);
        DisplayHpValue();
    }
}
