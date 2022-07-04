using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Polly
{
    /// <summary>
    /// 管理過關
    /// </summary>
    public class MangerPass : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "忍者蛙";
        [SerializeField, Header("跑步系統")]
        private SystemRun systemRun;
        [SerializeField, Header("跳躍系統")]
        #region 其中一個物件有勾選is trigger
        private SystemJump systemJump;
        [SerializeField, Header("結束管理器")]
        private ManagerFinal managerFinal;

        //兩個物件碰撞時執行一次
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);
            //如果 碰撞物件的名稱 包含    (忍者蛙)
            if (collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false; //關閉跑步系統
                systemJump.enabled = false; //關閉跳躍系統
                managerFinal.enabled = true; //啟動結束管理器
                managerFinal.stringTitle = "恭喜過關~";
            }
        }
        //兩個物件碰撞時執行一次
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        //兩個物件碰撞重疊時持續執行
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion
        #region 兩物件都沒有勾選is trigger
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

