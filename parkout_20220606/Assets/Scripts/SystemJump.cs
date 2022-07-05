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
        
        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGround;
        [SerializeField, Header("���D�ʵe�Ѽ�")]
        private string nameJump = "���D�}��";
        [SerializeField, Header("���D����")]
        private AudioClip soundJump;

        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        private bool isGround;
        private AudioSource aud;
        #endregion

        #region �ƥ�
        //ø�s�ϥ�
        //�b�s�边��ø�s���U�Ϊ��u���A�Ϊ��ιϤ��G�C�������|�X�{
        private void OnDrawGizmos()
        {
            //1.�M�w�C��
            Gizmos.color = colorCheckGround;
            //2.ø�s�ϥ�
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset,v3CheckGroundSize);
        }
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();

        }
        // input API��ĳ�bupdate�I�s
        // �@��60��
        private void Update()
        {
            JumpKey();
            CheckGroud();
            UpdateAnimator();
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
                //print("jumping~");
                clickJump = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }
        private void JumpForce()
        {
            //�p�G �I�����D �åB �b�a�O�W
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));
                aud.PlayOneShot(soundJump, Random.Range(0.7f, 1.5f));
                clickJump = false;
                
            }
        }
        /// <summary>
        /// �ˬd�O�_�I��a�O
        /// </summary>
        private void CheckGroud()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize,0,layerCheckGround);
            //print("�I�쪺����G"+hit.name);
            isGround = hit;
            
        }
        /// <summary>
        /// ��s�ʵe
        /// </summary>
        private void UpdateAnimator()
        {
            ani.SetBool(nameJump, !isGround);
        }
        #endregion
    }

}

