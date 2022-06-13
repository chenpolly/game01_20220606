
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
            if (Input.anyKey)            
            {
                print("enter any key");
            }
            print("你玩了多久了："+ Time.time);

            #endregion
        }


    }

}
