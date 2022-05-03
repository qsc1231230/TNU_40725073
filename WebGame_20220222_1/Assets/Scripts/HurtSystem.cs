using UnityEngine;

namespace AZ
{
    public class HurtSystem : MonoBehaviour
    {
        [SerializeField, Header("血量"), Range(0, 10000)]
        protected float hp;

        public void GetHurt(float damage)
        {
            hp -= damage;
            print("<color=red>受到的傷害:" + damage + "</color>");
        }

        private void Dead()
        {
            hp = 0;
            print("<colro=red>角色死亡:" + gameObject + "</color>");
        }
    }
}

