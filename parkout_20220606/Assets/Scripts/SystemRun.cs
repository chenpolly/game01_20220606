
using UnityEngine;//引用unity引擎 命名空間(API)
namespace Polly
{
    /// <summary>
    /// 跑步系統
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料：保存系統需要的資料 
        //欄位Field：用來保存資料
        //語法
        //修飾詞 欄位資料類型 欄位自訂名稱(指定 預設值)
        
        //修飾詞
        //公開：public, 顯示在面板上，允許其他類別存取
        //私人：private, 不顯示在面板上，不允許其他類別存取
        //serializeField用來將Field顯示在面板上
        //header 標題
        //tooltip 提示
        //range 範圍：僅限數值類型資料 int, float, byte, long
        [SerializeField, Header("跑步速度"), Tooltip("這是角色的跑步速度"),Range(0,100)]
        private float speedRun = 3.5f;
        [SerializeField,Header("跳躍高度"), Range(0,1000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion 
        #region 功能：實作該系統的複雜方法
        #endregion
        #region 事件：程式入口
        //開始事件：播放遊戲時執行一次
        //初始化設定，例如：生命初始化3條
        private void Start()
        {
            print("你好阿~");
        }
        #endregion


    }
}

