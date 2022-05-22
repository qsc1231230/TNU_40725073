using UnityEngine;

namespace AZ
{
    public class EnemyHurt : HurtSystem
    {
        [SerializeField, Header("敵人資料")]
        private DataEnemy data;
        [SerializeField, Header("畫布傷害")]
        private GameObject goCanvasHurt;
        [SerializeField, Header("經驗值道具")]
        private GameObject goExp;

        private string parameterDead = "蝙蝠死亡";
        private Animator ani;
        private EnemySystem enemySystem;
        private void Awake()
        {
            ani = GetComponent<Animator>();
            enemySystem = GetComponent<EnemySystem>();

            hp = data.hp;
        }

        public override void GetHurt(float damage)
        {
            base.GetHurt(damage);

          GameObject temp = Instantiate(goCanvasHurt, transform.position, Quaternion.identity);
          temp.GetComponent<HurtNumberEffect>().UpdateDamage(damage);
        }

        protected override void Dead()
        {
            base.Dead();
            ani.SetTrigger(parameterDead);

            enemySystem.enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 1.5f);

            DropExp();
        }

        private void DropExp()
        {
            float random = Random.value;
            
            if (random <= data.expDropProbability)
            {
             GameObject tempExp = Instantiate(goExp, transform.position, Quaternion.identity);
                tempExp.AddComponent<Exp>().typeExp = data.typeExp;
            }
        }
    }
}

