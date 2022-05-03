using UnityEngine;

namespace AZ 
{
    [CreateAssetMenu(menuName = "AZ/Data Enemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject
    {
        [Header("移動速度"), Range(0, 3500)]
        public float speed = 30;
        [Header("攻擊力"), Range(0, 500)]
        public float attack = 10;
        [Header("攻擊冷卻"), Range(0, 3500)]
        public float cd = 3.5f;
        [Header("血量"), Range(0, 3500)]
        public float hp = 100;
        [Header("經驗掉落倍率"), Range(0, 1)]
        public float expDropProbability = 100;
        [Header("經驗掉落類型")]
        public TypeExp typeExp;
        [Header("靠近目標後停止距離")]
        public float stopDistance = 3;
        public enum TypeExp
        {
            small, middle, big
        }
    }
}
