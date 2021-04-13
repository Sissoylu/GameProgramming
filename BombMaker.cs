using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMaker : MonoBehaviour
{
    public Rigidbody bombPrefab;
    public Transform bombSpawn;
    public Transform bombDirection;
    string moveAxisName = "Vertical";
    public float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAxis = Input.GetAxis(moveAxisName);
        transform.position += transform.forward * moveAxis* moveSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Quaternion.identity kendi pozisyonu(yeni pozisyonu kendisiyle çarpılması)
            var bomb = Instantiate(bombPrefab,bombSpawn.position, Quaternion.identity);

            //forward yön z olduğu için bombalar aşağı düştü. Silindirin ileri yönü y olduğu için transform.up yapmalıyız
            bomb.AddForce(bombDirection.transform.up * 500); //bombanın kendi ileri yönü (mavi yön)

            //bombayı 2 sn sonra yok et
            //Destroy(bomb,2);
            //bu şekilde component yani rigidbody yok ediliyo ama biz objenin tamamını yok etsin istiyoruz

            Destroy(bomb.gameObject, 2);
        }
        
    }
}
