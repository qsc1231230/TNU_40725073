using UnityEngine;

namespace AZ
{
    public class TopDownCon: MonoBehaviour
    {
        [SerializeField,Header("���ʳt��"), Range(0,500)]
        private float speed = 1.5f;
        private string parameterRun = "�}���]�B";
        private string parameterDead = "�}�����`";
        private Animator ani;
        private Rigidbody2D rig;
        private float h;
        private float v;

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            GetInput();
            Move();
            Rotate();
        }

        private void GetInput()
        {
            //float h = Input.GetAxis("Horizontal");

            //print("�����b�V��:" + h);
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
        }
        private void Move()
        {
            rig.velocity = new Vector2(h, v) * speed;
            ani.SetBool(parameterRun, h != 0 || v !=0);
        }

        private void Rotate()
        {
            transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0);
        }
    }
    
}

