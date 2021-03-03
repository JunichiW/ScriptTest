﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //魔力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //魔法攻撃用の関数
    public void Magic()
    {
       
        if ( this.mp >= 5 )
        {
            //残りMPを減らす
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
            
        }

        else

        {
            //mpの値が5未満の場合
            Debug.Log("MPが足りないため魔法が使えない");
        }

    }
}

public class TEST_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法攻撃用の関数を呼び出す
        lastboss.Magic();

        //魔法攻撃の処理を10回繰り返す
        for(int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
