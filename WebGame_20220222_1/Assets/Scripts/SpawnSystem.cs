using UnityEngine;

namespace AZ
{
    public class SpawnSystem : MonoBehaviour
    {
        [SerializeField, Header("要生成的敵人物件")]
        private GameObject goEnemy;
        [SerializeField, Header("敵人生成點")]
        private Transform[] traSpawn;
        [SerializeField, Header("生成延遲"), Range(0, 5)]
        private float delay = 1;
        [SerializeField, Header("生成間隔"), Range(0, 5)]
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
