using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss

{
    public int mp = 53; // MP
    
    // ���@�p�̊֐�
    public void Magic()
    {
        if (mp >= 5)
        {
            // MP��5�ȏ�̏ꍇ
            Debug.Log("���@�U���������B�c��MP�́Z�Z");
            // �c��mp�����炷
            this.mp -= 5;
        }
        else
        {
            // MP��5�����̏ꍇ
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
        
    }

}

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
        for (int b = 4; b > -1; b--)
        {
            Debug.Log(array[b]);
        }
        //���W�ۑ�

            // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
            Boss lastboss = new Boss();

            // ���@�p�̊֐����Ăяo��
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
