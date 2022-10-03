using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        for (int b = 4; b > 0; b--)
        {
            Debug.Log(array[b]);
        }
    }
        // Update is called once per frame
        void Update()
        {

        }
 }
