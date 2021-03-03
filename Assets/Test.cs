using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
        //配列を初期化する
        int[] array = { 1,2,3,4,5 };

        //配列の各要素の値を順番に表示する
        for (int i = 0; i < array.Length; i++)
        {
            //配列の要素を表示する
            Debug.Log(array[i]);


        }

        //配列の各要素を逆順に表示する
        for (int a = array.Length - 1; 0 <= a; a--)

        {
            
          
          //配列の要素を表示する
          Debug.Log(array[a]);

            }
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
