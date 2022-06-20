
using UnityEngine;
 namespace Polly 
{
    public class APIStatic : MonoBehaviour
    {

        
        private void Start()
        {
            //學習
            #region
            //取得靜態屬性 get
            //語法
            //類別.靜態屬性名稱
            print("隨機值：" + Random.value);
            print("PI:" + Mathf.PI);
            
            //取得靜態屬性 set
            //語法
            //類別.靜態屬性名稱 指定值
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0,-4.8f);
            Time.timeScale = 1.0f;

            //使用靜態方法
            //語法
            //類別.靜態方法名稱(對應引數)
            float range = Random.Range(20.5f, 100.5f);
            print("隨機範圍：" + range);

            #endregion
            //練習
            #region
            print("攝影機的數量"+ Camera.allCamerasCount);
            print("使用的應用平台:"+Application.platform);
            Physics.sleepThreshold = 10;
            print("睡眠臨界值：" + Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print("時間大小 :" + Time.timeScale);
            //靜態方法，類別名稱.靜態方法(對應的引數)
            int num = (int)Mathf.Round(9.999f);
            print("9.999去除小數點四捨五入: " + num);
            
            
            Vector3 myVector1;
            Vector3 myVector2;
            myVector1 = new Vector3(1, 1, 1);
            myVector2 = new Vector3(22, 22, 22);
            float dist = Vector3.Distance(myVector1, myVector2);
            print("<color=yellow>兩點相距:"+dist+"</color>");

            //開啟連結
            Application.OpenURL("https://unity.com/");

            #endregion
        }
        private void Update()
        {
            //學習
            #region
            int range = Random.Range(1, 3);
            print("隨機範圍：" + range);
            #endregion
            
            //練習
            #region
            //print("是否按下任意鍵："+ Input.anyKeyDown);
            //print("遊戲經過時間："+ Time.timeSinceLevelLoad);

            //靜態方法
            print("<color=red>是否按下空白鍵：" + Input.GetKeyDown(KeyCode.Space) + "</color>");
            
       
            
            
            #endregion
        }


    }

}
