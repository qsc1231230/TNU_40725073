using UnityEngine;
using UnityEngine.UI;

namespace AZ
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField, Header("經驗值")]
        private Image imgExp;
        [SerializeField, Header("等級")]
        private Text textLv;

        private int exp;
        private int expMax;
        private int lv = 1;

        [SerializeField]
        private int[] expNeed;

        [SerializeField, Header("要升級的武器資料")]
        private DataWeapon dataWaapon;

        [ContextMenu("Setting Exp Need")]
        private void SettibgExpNeed()
        {
            expNeed = new int[99];
            for (int i = 0; i < expNeed.Length; i++)
            {
                expNeed[i] = (i + 1) * 100;
            }
        }

        public void GetExp(int getExp)
        {
            exp += getExp;
            expMax = expNeed[lv - 1];
            while (exp >= expMax)
            {
                lv++;
                exp -= expMax;
                expMax = expNeed[lv - 1];

                LevelUp();
            }

            imgExp.fillAmount = (float)exp / (float)expMax;
            textLv.text = lv.ToString();
        }

        private void LevelUp()
        {
            dataWaapon.attack += 10;
            dataWaapon.interval -= 0.02f;
        }
    }
}
