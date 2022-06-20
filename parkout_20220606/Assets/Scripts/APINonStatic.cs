using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Polly 
{
    //<summary>
    //�D�R�AAPI
    //�P�R�A���t�O�b��ݭn�@�ӡu���骫��v
    //�u���骫��v�@�Ӧs�b������W���C������ GAME OBJECT
    //</summary>
    public class APINonStatic : MonoBehaviour
    {
        // 1.�w�q���A������������O
        // 2.unity �ݩʭ��O�����T�w����줣�O�ŭ� none
        // 3.�ϥΫD�R�AAPI
        [SerializeField]
        private GameObject frog;
        // Start is called before the first frame update
        void Start()
        {
            // �D�R�A�ݩ�
            // 1.���o
            // �y�k�G
            // ���W��.�D�R�A�ݩ�
            print("�Ԫ̵쪺�Ұʪ��A�G" + frog.activeInHierarchy);
            print("�Ԫ̵쪺�w�]�ϼh�G" + frog.layer);
            
            // 2.�]�w
            // �y�k�G
            // ���W��.�D�R�A�ݩ� ���w ��
            // frog.activeInHierarchy = false; (��Ū�ݩʡA�x��S�g)
            frog.tag = "Player";
            frog.layer = 4;

            // 3. �ϥ� �D�R�A��k
            // �y�k�G���W��.�D�R�A��k(�������޼�);
            frog.SetActive(false);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
    
}

