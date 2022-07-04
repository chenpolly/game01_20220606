using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�ޥγ����޲z API
using TMPro;
namespace Polly
{
    /// <summary>
    /// �޲z�����e��
    /// �L���M����
    /// </summary>
    public class ManagerFinal : MonoBehaviour
    {
        #region
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;
        /// <summary>
        /// �C���������D����r���e
        /// </summary>
        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;
            //MonoBehaviour ���O API ���i�H�����ϥΦW�٩I�s
            InvokeRepeating("FadeIn", 0, 0.2f);
        }
        /// <summary>
        /// �H�J
        /// </summary>
        private void FadeIn()
        {
            //�z���׻��W
            groupFinal.alpha += 0.1f;
            print("�H�J");
            
            //�p�G �z���� >=1 �N�Ұʤ��ʻP�B�׮g�u
            if(groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
                CancelInvoke("FadeIn");
            }
            
        }
        //���s�P�{�����q�覡
        //1 �w�q���}�覡
        //2 button on click�]�w���}�������}��k
        public void Quite()
        {
            print("���}�C��");
            //�u�b�o�������� �q���P����˸m�W���@��
            Application.Quit();
        }
        /// <summary>
        /// ���s�C��
        /// </summary>
        public void Replay()
        {
            SceneManager.LoadScene("�C������");
        }


        #endregion
    }
    

}

