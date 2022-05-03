using UnityEngine;

namespace AZ 
{
    public class Weapon : MonoBehaviour
    {
        [HideInInspector]
        public float attack;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.gameObject.tag =="�ĤH")
            {
                collision.gameObject.GetComponent<HurtSystem>().GetHurt(attack);
            }
        }
    }

}
