
using UnityEngine;
 namespace Polly 
{
    public class APIStatic : MonoBehaviour
    {

        
        private void Start()
        {
            //�ǲ�
            #region
            //���o�R�A�ݩ� get
            //�y�k
            //���O.�R�A�ݩʦW��
            print("�H���ȡG" + Random.value);
            print("PI:" + Mathf.PI);
            
            //���o�R�A�ݩ� set
            //�y�k
            //���O.�R�A�ݩʦW�� ���w��
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0,-4.8f);
            Time.timeScale = 1.0f;

            //�ϥ��R�A��k
            //�y�k
            //���O.�R�A��k�W��(�����޼�)
            float range = Random.Range(20.5f, 100.5f);
            print("�H���d��G" + range);

            #endregion
            //�m��
            #region
            print("��v�����ƶq"+ Camera.allCamerasCount);
            print("�ϥΪ����Υ��x:"+Application.platform);
            Physics.sleepThreshold = 10;
            print("�ίv�{�ɭȡG" + Physics.sleepThreshold);
            Time.timeScale = 0.5f;
            print("�ɶ��j�p :" + Time.timeScale);
            //�R�A��k�A���O�W��.�R�A��k(�������޼�)
            int num = (int)Mathf.Round(9.999f);
            print("9.999�h���p���I�|�ˤ��J: " + num);
            
            
            Vector3 myVector1;
            Vector3 myVector2;
            myVector1 = new Vector3(1, 1, 1);
            myVector2 = new Vector3(22, 22, 22);
            float dist = Vector3.Distance(myVector1, myVector2);
            print("<color=yellow>���I�۶Z:"+dist+"</color>");

            //�}�ҳs��
            Application.OpenURL("https://unity.com/");

            #endregion
        }
        private void Update()
        {
            //�ǲ�
            #region
            int range = Random.Range(1, 3);
            print("�H���d��G" + range);
            #endregion
            
            //�m��
            #region
            //print("�O�_���U���N��G"+ Input.anyKeyDown);
            //print("�C���g�L�ɶ��G"+ Time.timeSinceLevelLoad);

            //�R�A��k
            print("<color=red>�O�_���U�ť���G" + Input.GetKeyDown(KeyCode.Space) + "</color>");
            
       
            
            
            #endregion
        }


    }

}
