using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//引用場景管理 API
using TMPro;
namespace Polly
{
    /// <summary>
    /// 管理結束畫面
    /// 過關和失敗
    /// </summary>
    public class ManagerFinal : MonoBehaviour
    {
        #region
        [SerializeField, Header("畫布")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("遊戲結束標題")]
        private TextMeshProUGUI textFinal;
        /// <summary>
        /// 遊戲結束標題的文字內容
        /// </summary>
        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;
            //MonoBehaviour 類別 API 都可以直接使用名稱呼叫
            InvokeRepeating("FadeIn", 0, 0.2f);
        }
        /// <summary>
        /// 淡入
        /// </summary>
        private void FadeIn()
        {
            //透明度遞增
            groupFinal.alpha += 0.1f;
            print("淡入");
            
            //如果 透明度 >=1 就啟動互動與遮擋射線
            if(groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
                CancelInvoke("FadeIn");
            }
            
        }
        //按鈕與程式溝通方式
        //1 定義公開方式
        //2 button on click設定此腳本的公開方法
        public void Quite()
        {
            print("離開遊戲");
            //只在發布執行檔 電腦與手機裝置上有作用
            Application.Quit();
        }
        /// <summary>
        /// 重新遊戲
        /// </summary>
        public void Replay()
        {
            SceneManager.LoadScene("遊戲場景");
        }


        #endregion
    }
    

}

