using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Polly 
{
    //<summary>
    //非靜態API
    //與靜態的差別在於需要一個「實體物件」
    //「實體物件」一個存在於場景上的遊戲物件 GAME OBJECT
    //</summary>
    public class APINonStatic : MonoBehaviour
    {
        // 1.定義欄位，資料類型為類別
        // 2.unity 屬性面板必須確定該欄位不是空值 none
        // 3.使用非靜態API
        [SerializeField]
        private GameObject frog;
        [SerializeField]
        private Transform startPoint;

        // Start is called before the first frame update
        void Start()
        {
            // 非靜態屬性
            
            // 1.取得
            // 語法：
            // 欄位名稱.非靜態屬性
            print("忍者蛙的啟動狀態：" + frog.activeInHierarchy);
            print("忍者蛙的預設圖層：" + frog.layer);
            print("起點的座標：" + startPoint.position);
            
            // 2.設定
            // 語法：
            // 欄位名稱.非靜態屬性 指定 值
            // frog.activeInHierarchy = false; (唯讀屬性，官方沒寫)
            frog.tag = "Player";
            frog.layer = 4;
            startPoint.position = new Vector3(0, 2, 0);
            
            // 3. 使用 非靜態方法
            // 語法：欄位名稱.非靜態方法(對應的引數);
            frog.SetActive(false);

        }

        // Update is called once per frame
        void Update()
        {
            startPoint.Translate(0.2f,0,0);
            startPoint.Rotate(0,0,1);
        }
    }
    
}

