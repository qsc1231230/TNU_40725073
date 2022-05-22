using UnityEngine;

namespace AZ
{
    public class HurtSystem : MonoBehaviour
    {
        [SerializeField, Header("��q"), Range(0, 10000)]
        protected float hp;

        public virtual void GetHurt(float damage)
        {
            if (hp <= 0) return;

            hp -= damage;
            print("<color=red>���쪺�ˮ`:" + damage + "</color>");

            if (hp <= 0) Dead();
        }

        protected virtual void Dead()
        {
            hp = 0;
            print("<colro=red>���⦺�`:" + gameObject + "</color>");
        }
    }
}

