using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("敵人資料")]
    public DataEnemy data;
    [SerializeField, Header("玩家物件名稱")]
    public string namePlayer = "騎士";

    private Transform traPlayer;

    private void Awake()
    {
        traPlayer = GameObject.Find(namePlayer).transform;

        //float result = Mathf.Lerp(0, 10, 0.5f);
        //print("0 與 10 的 0.5 插值:" + result);
    }
    private void Update()
    {
        MoveToPlayer();
    }
    private void MoveToPlayer()
    {
        Vector3 posEnemy = transform.position;
        Vector3 posPlayer = traPlayer.position;

        transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

        float y = transform.position.x > traPlayer.position.x ? 180 : 0;
        transform.eulerAngles = new Vector3(0,y,0);
    }
}
