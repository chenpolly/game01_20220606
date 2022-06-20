using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Polly
{
    public class SystemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Range(0, 1000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        private bool clickJump;
        #endregion

        #region 事件
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();

        }
        // input API建議在update呼叫
        // 一秒60次
        private void Update()
        {
            JumpKey();
        }
        //一秒50次
        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion

        #region 功能
        private void JumpKey()
        {
            //如果玩家按下空白鍵 就往上 跳躍
            //if
            //switch
            //if 判斷式語法：if(布林值){布林值 為 true 執行程式}
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

