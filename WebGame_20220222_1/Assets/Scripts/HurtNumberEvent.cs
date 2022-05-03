using UnityEngine;
using System.Collections;

namespace AZ
{
    public class HurtNumberEvent : MonoBehaviour
    {
        private CanvasGroup group;

        private void Start()
        {
            StartCoroutine(Test());
        }
        private IEnumerator Test()
        {
            print("123");
            yield return new WaitForSeconds(2);
            print("321");

        }
            
    }
}
