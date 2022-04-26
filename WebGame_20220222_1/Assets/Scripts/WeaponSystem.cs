using UnityEngine;



namespace AZ
{  
    /// <summary>
    /// �Z���t��
    /// 1.�x�s���a�����Z�����
    /// 2.���Z����ƥͦ��Z��
    /// 3.�ᤩ�Z���������,����t��,�����O
    /// </summary>
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("�Z���R���ɶ�"), Range(0, 5)]
        private float weaponDestoryTime = 3.5f;

        [SerializeField, Header("�Z�����")]
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
            print("�g�L�ɶ�:" + timer);

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