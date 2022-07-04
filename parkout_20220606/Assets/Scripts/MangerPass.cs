using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Polly
{
    /// <summary>
    /// �޲z�L��
    /// </summary>
    public class MangerPass : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "�Ԫ̵�";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemRun;
        [SerializeField, Header("���D�t��")]
        #region �䤤�@�Ӫ��󦳤Ŀ�is trigger
        private SystemJump systemJump;
        [SerializeField, Header("�����޲z��")]
        private ManagerFinal managerFinal;

        //��Ӫ���I���ɰ���@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);
            //�p�G �I�����󪺦W�� �]�t    (�Ԫ̵�)
            if (collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false; //�����]�B�t��
                systemJump.enabled = false; //�������D�t��
                managerFinal.enabled = true; //�Ұʵ����޲z��
                managerFinal.stringTitle = "���߹L��~";
            }
        }
        //��Ӫ���I���ɰ���@��
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        //��Ӫ���I�����|�ɫ������
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion
        #region �⪫�󳣨S���Ŀ�is trigger
        private void OnCollisionEnter2D(Collision2D collision)
        {
            
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
        #endregion
    }

}

