
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
            if (Input.anyKey)            
            {
                print("enter any key");
            }
            print("�A���F�h�[�F�G"+ Time.time);

            #endregion
        }


    }

}
