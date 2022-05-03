using UnityEngine;

namespace AZ 
{
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("敵人資料")]
        public DataEnemy data;
        [SerializeField, Header("玩家物件名稱")]
        public string namePlayer = "騎士";
        [SerializeField, Header("攻擊動畫參數")]
        private string parameterAttack = "蝙蝠攻擊";
        private Transform traPlayer;

        private float timerAttack;

        private Animator ani;
        private void Awake()
        {
            ani = GetComponent<Animator>();
            traPlayer = GameObject.Find(namePlayer).transform;

            //float result = Mathf.Lerp(0, 10, 0.5f);
            //print("0 與 10 的 0.5 插值:" + result);
        }
        private void Update()
        {
            MoveToPlayer();
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0.5f, 0, 0.6f);
            Gizmos.DrawSphere(transform.position, data.stopDistance);
        }
        private void MoveToPlayer()
        {
            Vector3 posEnemy = transform.position;
            Vector3 posPlayer = traPlayer.position;

            float dis = Vector3.Distance(posEnemy, posPlayer);
            //print("<color = yellow>距離:" + dis + "</color>");

            if (dis < data.stopDistance)
            {
                Attack();
            }
            else
            {
                transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

                float y = transform.position.x > traPlayer.position.x ? 180 : 0;
                transform.eulerAngles = new Vector3(0, y, 0);
            }

        }

        private void Attack()
        {
            if (timerAttack < data.cd)
            {
                timerAttack += Time.deltaTime;
                //print("<color=red>攻擊計時器 :" + timerAttack + "</color>");
            }
            else
            {
                ani.SetTrigger(parameterAttack);
                timerAttack = 0;
            }
        }
    }
}

