
using UnityEngine;//�ޥ�unity���� �R�W�Ŷ�(API)
namespace Polly
{
    /// <summary>
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ��ơG�O�s�t�λݭn����� 
        //���Field�G�ΨӫO�s���
        //�y�k
        //�׹��� ��������� ���ۭq�W��(���w �w�]��)
        
        //�׹���
        //���}�Gpublic, ��ܦb���O�W�A���\��L���O�s��
        //�p�H�Gprivate, ����ܦb���O�W�A�����\��L���O�s��
        //serializeField�ΨӱNField��ܦb���O�W
        //header ���D
        //tooltip ����
        //range �d��G�ȭ��ƭ�������� int, float, byte, long
        [SerializeField, Header("�]�B�t��"), Tooltip("�o�O���⪺�]�B�t��"),Range(0,100)]
        private float speedRun = 3.5f;
        //[SerializeField,Header("���D����"), Range(0,1000)]
        //private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion
        #region �\��G��@�Өt�Ϊ�������k
        #endregion
        #region �\��G��@�Өt�Ϊ�������k
        // ��k method
        // �y�k
        // �׹��� �Ǧ^������� ��k�W��(�Ѽ�) {�{��}
        /// <summary>
        /// ���B�\��
        /// </summary>
        private void Run()
        {
            print("�]�B��~");
            rig.velocity = new Vector2(speedRun, rig.velocity.y);
        }
        #endregion

        #region �ƥ�G�{���J�f
        //����ƥ�G�}�l�ƥ�e����@���A���o���󵥵�
        private void Awake()
        {
            //ani ���w �D�����W��animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        //�}�l�ƥ�G����C���ɰ���@��
        //��l�Ƴ]�w�A�Ҧp�G�ͩR��l��3��
        private void Start()
        {
            //print("�A�n��~");
        }
        //��s�ƥ�G�C������60�� 60FPS (frame per second) 
        private void Update()
        {
            //print("<color=yellow>��s�ƥ���椤</color>");
            //�I�s��k�G��k�W��(�������޼�);
            Run();
            
        }
        //������Q�Ŀ�ɰ���@��
        private void OnEnable()
        {
            
        }
        //������Q�����ɰ���@��
        private void OnDisable()
        {
            //�[�t���k�s
            rig.velocity = Vector3.zero;
        }
        #endregion


    }
}

