using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1.�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ��������Ă�������
        int[] array = { 5, 12, 59, 78, 199 };

        //2.for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\�����Ă�������
        for (int a = 0; a < 5; a++)
        {
            Debug.Log(array[a]);
        }
        //3.for�����g���A�z��̊e�v�f�̒l���t�Ԃɕ\�����Ă�������
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
