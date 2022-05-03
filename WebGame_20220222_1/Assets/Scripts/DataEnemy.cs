using UnityEngine;

namespace AZ 
{
    [CreateAssetMenu(menuName = "AZ/Data Enemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject
    {
        [Header("���ʳt��"), Range(0, 3500)]
        public float speed = 30;
        [Header("�����O"), Range(0, 500)]
        public float attack = 10;
        [Header("�����N�o"), Range(0, 3500)]
        public float cd = 3.5f;
        [Header("��q"), Range(0, 3500)]
        public float hp = 100;
        [Header("�g�籼�����v"), Range(0, 1)]
        public float expDropProbability = 100;
        [Header("�g�籼������")]
        public TypeExp typeExp;
        [Header("�a��ؼЫᰱ��Z��")]
        public float stopDistance = 3;
        public enum TypeExp
        {
            small, middle, big
        }
    }
}
