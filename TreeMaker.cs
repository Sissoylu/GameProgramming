using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMaker : MonoBehaviour
{
    public GameObject treePrefab;
    float randx, randz;
    // Start is called before the first frame update
    void Start()
    {
        //metot çağrıldıktan 2 saniye sonra oluşturacak.
        Invoke("CreateTrees",2);
        
        //Tekrarlı (saniyede 2 tane yapacak)
        InvokeRepeating("CreateTrees", 2f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //Space'e basıldığında instantiate et.
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CreateTrees();
        }
    }

    private void CreateTrees()
    {
        //transform eklediğimiz için oluşturulan ağaçlar treemaker'ın altına child olarak gidecek
        GameObject tree = Instantiate(treePrefab, transform);

        //her ağacın ömrü 2 saniye
        Destroy(tree,2f);

        //oluşturulan objenin konumunu değiştirir. çünkü diğerinde klonlar hep aynı yerde oluşuyordu.
        randx = Random.Range(-5f,+5f);
        randz = Random.Range(-5f, +5f);
        tree.transform.position = new Vector3(randx,0,randz);
    }
}
