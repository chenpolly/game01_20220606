using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Polly
{
    public class SystemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Range(0, 1000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        #endregion

        #region �ƥ�
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();

        }
        // input API��ĳ�bupdate�I�s
        // �@��60��
        private void Update()
        {
            JumpKey();
        }
        //�@��50��
        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion

        #region �\��
        private void JumpKey()
        {
            //�p�G���a���U�ť��� �N���W ���D
            //if
            //switch
            //if �P�_���y�k�Gif(���L��){���L�� �� true ����{��}
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("jumping~");
                clickJump = true;
            }
        }
        private void JumpForce()
        {
            if (clickJump)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }

        #endregion
    }

}

