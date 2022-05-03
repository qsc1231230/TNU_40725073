using UnityEngine;

namespace AZ
{
    public class EnemyHurt : HurtSystem
    {
        [SerializeField, Header("¼Ä¤H¸ê®Æ")]
        private DataEnemy data;

        private void Awake()
        {
            hp = data.hp;
        }
    }
}

