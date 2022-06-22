using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APINonStaticPractice : MonoBehaviour
{
    
    [SerializeField]
    private GameObject Cube01;
    [SerializeField]
    private GameObject Sphere01;
    [SerializeField]
    private GameObject Capsule01;
    

    void Start()
    {
        //取得
        print("camera的深度" + Camera.main.depth);
        print("球體碰撞器半徑" + Sphere01.GetComponent<SphereCollider>().radius);
        print("capsule的尺寸" + Capsule01.transform.localScale  );

        //存放
        //攝影機的背景顏色指定為隨機顏色
        Camera.main.backgroundColor = Random.ColorHSV(0f,1f,1f,1f,0.5f,1f);
        
        
    } 
    
    void Update()
    {
        //使尺寸大小變成(3,2,1)
        Capsule01.transform.localScale = new Vector3(3, 2, 1);
        //讓正方體繞著球體轉動
        Cube01.transform.RotateAround(Sphere01.transform.position,new Vector3(0,0,1), 36*Time.deltaTime);
        //按下space後產生向上的推力
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Capsule01.GetComponent<Rigidbody>().AddForce(0, 5, 0, ForceMode.Impulse);
        }
        
    }
}
