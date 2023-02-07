using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : Friendly
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void AddDamage()
    {
        int d = Random.RandomRange(1, 21);
        hp = hp - d;
        DisplayHpValue();
    }

    public override void OnAttack()
    {
        Debug.Log("Healer�E�[�m�̂��������I");
        gameManager.EnemyDamage(attackPower);
        DisplayHpValue();
    }
    public override void OnSpSkill()
    {
        Debug.Log("Healer�̃X�L�������IPlayer�������ӂ�����!");
        gameManager.OnPlayerHeal();
        DisplayHpValue();
    }
}
