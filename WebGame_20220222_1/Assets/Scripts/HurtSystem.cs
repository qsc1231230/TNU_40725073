using UnityEngine;

namespace AZ
{
    public class HurtSystem : MonoBehaviour
    {
        [SerializeField, Header("血量"), Range(0, 10000)]
        protected float hp;

        public virtual void GetHurt(float damage)
        {
            if (hp <= 0) return;

            hp -= damage;
            print("<color=red>受到的傷害:" + damage + "</color>");

            if (hp <= 0) Dead();
        }

        protected virtual void Dead()
        {
            hp = 0;
            print("<colro=red>角色死亡:" + gameObject + "</color>");
        }
    }
}

