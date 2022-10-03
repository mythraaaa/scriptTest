using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss

{
    public int mp = 53; // MP
    
    // 魔法用の関数
    public void Magic()
    {
        if (mp >= 5)
        {
            // MPが5以上の場合
            Debug.Log("魔法攻撃をした。残りMPは〇〇");
            // 残りmpを減らす
            this.mp -= 5;
        }
        else
        {
            // MPが5未満の場合
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
        
    }

}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1.要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = { 5, 12, 59, 78, 199 };

        //2.for文を使い、配列の各要素の値を順番に表示してください
        for (int a = 0; a < 5; a++)
        {
            Debug.Log(array[a]);
        }
        //3.for文を使い、配列の各要素の値を逆番に表示してください
        for (int b = 4; b > -1; b--)
        {
            Debug.Log(array[b]);
        }
        //発展課題

            // Bossクラスの変数を宣言してインスタンスを代入
            Boss lastboss = new Boss();

            // 魔法用の関数を呼び出す
            lastboss.Magic();
        for(int mp = 53; mp < 10; mp = - 5)
        {

        }
    }
        // Update is called once per frame
        void Update()
        {

        }
 }
