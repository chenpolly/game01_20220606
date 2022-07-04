
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
        //[SerializeField,Header("跳躍高度"), Range(0,1000)]
        //private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion
        #region 功能：實作該系統的複雜方法
        #endregion
        #region 功能：實作該系統的複雜方法
        // 方法 method
        // 語法
        // 修飾詞 傳回資料類型 方法名稱(參數) {程式}
        /// <summary>
        /// 路步功能
        /// </summary>
        private void Run()
        {
            print("跑步中~");
            rig.velocity = new Vector2(speedRun, rig.velocity.y);
        }
        #endregion

        #region 事件：程式入口
        //喚醒事件：開始事件前執行一次，取得元件等等
        private void Awake()
        {
            //ani 指定 主角身上的animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        //開始事件：播放遊戲時執行一次
        //初始化設定，例如：生命初始化3條
        private void Start()
        {
            //print("你好阿~");
        }
        //更新事件：每秒執行約60次 60FPS (frame per second) 
        private void Update()
        {
            //print("<color=yellow>更新事件執行中</color>");
            //呼叫方法：方法名稱(對應的引數);
            Run();
            
        }
        //此元件被勾選時執行一次
        private void OnEnable()
        {
            
        }
        //此元件被取消時執行一次
        private void OnDisable()
        {
            //加速度歸零
            rig.velocity = Vector3.zero;
        }
        #endregion


    }
}

