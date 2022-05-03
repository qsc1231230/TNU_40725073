using UnityEngine;

namespace AZ
{
    public class HurtSystem : MonoBehaviour
    {
        [SerializeField, Header("��q"), Range(0, 10000)]
        protected float hp;

        public void GetHurt(float damage)
        {
            hp -= damage;
            print("<color=red>���쪺�ˮ`:" + damage + "</color>");
        }

        private void Dead()
        {
            hp = 0;
            print("<colro=red>���⦺�`:" + gameObject + "</color>");
        }
    }
}

