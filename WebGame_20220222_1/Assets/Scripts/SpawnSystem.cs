using UnityEngine;

namespace AZ
{
    public class SpawnSystem : MonoBehaviour
    {
        [SerializeField, Header("�n�ͦ����ĤH����")]
        private GameObject goEnemy;
        [SerializeField, Header("�ĤH�ͦ��I")]
        private Transform[] traSpawn;
        [SerializeField, Header("�ͦ�����"), Range(0, 5)]
        private float delay = 1;
        [SerializeField, Header("�ͦ����j"), Range(0, 5)]
        private float interval = 2.5f;

        private void Awake()
        {
            InvokeRepeating("Spawn", delay, interval);
        }
        private void Spawn()
        {
            int ran = Random.Range(0, traSpawn.Length);
            Instantiate(goEnemy, traSpawn[ran].position, Quaternion.identity);
        }
    }
}
