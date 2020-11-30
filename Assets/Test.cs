using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;　//体力
    private int power = 50;　//攻撃力
    private int mp = 53;

    public void Attack()
	{
        Debug.Log(this.power + "のダメージを与えた");
	}

    public void Damage (int damage)
	{
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
	}

    public void Magic ()
	{
        this.mp -= 5;
        Debug.Log("魔法攻撃をした。残りMPは" + mp);

        if (mp < 5)
		{
            Debug.Log("MP不足のため魔法は使えません、、");
		}
	}
}

public class Test : MonoBehaviour
{
    void Start ()
	{
        Boss myBoss = new Boss();
        myBoss.Attack(); //Attackを実行
        myBoss.Damage(30); //Damageに30を代入して実行
        myBoss.Magic();


        int[] array = {1, 2, 3, 4, 5};
        for (int junban = 0; junban < array.Length; junban++)
        {
            Debug.Log(array [junban]);
        }
        for (int gyaku = 4; gyaku < array.Length; gyaku--)
        {
            Debug.Log(array [gyaku]);
        }


    } 
}
