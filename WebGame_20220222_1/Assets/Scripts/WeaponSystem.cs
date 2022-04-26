using UnityEngine;



namespace AZ
{  
    /// <summary>
    /// 武器系統
    /// 1.儲存玩家有的武器資料
    /// 2.更具武器資料生成武器
    /// 3.賦予武器相關資料,飛行速度,攻擊力
    /// </summary>
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("武器刪除時間"), Range(0, 5)]
        private float weaponDestoryTime = 3.5f;

        [SerializeField, Header("武器資料")]
        private DataWeapon dataWeapon;
       

        private float timer;

        private void OnDrawGizmos()
           
        {
            Gizmos.color = new Color(1, 0, 0, 0.5f);
            for (int i = 0; i < dataWeapon.v2SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v2SpawnPoint[i], 0.1f);
            }
        }
        private void Start()
        {
            Physics2D.IgnoreLayerCollision(3, 6);
            Physics2D.IgnoreLayerCollision(6, 6);
        }

        private void Update()
        {
            spawnWeapon();
        }
        private void spawnWeapon()
        {
            print("經過時間:" + timer);

            if(timer >= dataWeapon.interval)
            {
                int random = Random.Range(0, dataWeapon.v2SpawnPoint.Length);

                Vector3 pos = transform.position + dataWeapon.v2SpawnPoint[random];

               GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.identity);

                temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon.v3Direction * dataWeapon.speedFly);

                timer = 3;

                Destroy(temp, weaponDestoryTime);
            }
            else
            {

                timer += Time.deltaTime;
            }
        }

    }
}