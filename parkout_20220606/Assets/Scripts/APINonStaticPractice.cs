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
        //���o
        print("camera���`��" + Camera.main.depth);
        print("�y��I�����b�|" + Sphere01.GetComponent<SphereCollider>().radius);
        print("capsule���ؤo" + Capsule01.transform.localScale  );

        //�s��
        //��v�����I���C����w���H���C��
        Camera.main.backgroundColor = Random.ColorHSV(0f,1f,1f,1f,0.5f,1f);
        
        
    } 
    
    void Update()
    {
        //�Ϥؤo�j�p�ܦ�(3,2,1)
        Capsule01.transform.localScale = new Vector3(3, 2, 1);
        //��������¶�۲y�����
        Cube01.transform.RotateAround(Sphere01.transform.position,new Vector3(0,0,1), 36*Time.deltaTime);
        //���Uspace�Უ�ͦV�W�����O
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Capsule01.GetComponent<Rigidbody>().AddForce(0, 5, 0, ForceMode.Impulse);
        }
        
    }
}
