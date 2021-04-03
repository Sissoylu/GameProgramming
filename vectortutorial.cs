using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vectortutorial : MonoBehaviour
{
    public Transform p1; //unity editorde görebilmek için public tanımlama yaptık
    public Transform p2;// bu game objelerin konum bilgileri gerekir bu yüzden transform olarak tanımlama yapabiliriz.
    public Transform origin;

    public Transform airplane;
    public Text info;
    private Transform turret; //tank upper side
    public Transform tank;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //private olmasına rağmen ve atama yapılmamasına rağmen(unity editorde) oyun içerisinde bu değişkeni bulabilecek bu atama sayesinde
        turret = GameObject.Find("turret").GetComponent<Transform>(); //.transform; da olur
        //rb.velocity = tank.forward*10; //ilk hız ataması.
    }


    // Update is called once per frame
    void Update()
    {
       //TestMethod();
       //DotProductTutorial();
       //PlaneDirectionCompute();
       //TankRotator();

      
    }

    private void FixedUpdate()
    {   
         //rb.AddForce(Vector3.forward*1000*Time.deltaTime);
         rb.AddForce(tank.forward*100*Time.deltaTime);
    }
    public float moveSpeed = 5;
    private void TankRotator()
    {
        Vector3 rotAxis = Vector3.Cross(turret.forward, Vector3.right);  //mavi eksen forwarddır, döndürmek istediğimiz eksen right (global eksende sağa doğru dönsün)
        turret.Rotate(rotAxis);
        //tank.position += tank.forward*Time.deltaTime*moveSpeed; //tankın yönünde gitmesini istiyoruz.
        tank.Translate(Vector3.forward * Time.deltaTime*moveSpeed); //yukarıdakinin aynısını yapar
        tank.localScale *= 2*Time.deltaTime; //her karede 2 katına çıkarır, büyütür
        //tank.localScale += Vector3.one*Time.deltaTime; //+ için bu şekilde yazmalıyız.


    }



    private void PlaneDirectionCompute()
    {
        float dotProduct = Vector3.Dot(airplane.forward, Vector3.up);

        if (dotProduct > 0)
        {
           info.text = "going up";

        }
        else
        {
            info.text = "going down";
        }
    }



    void DotProductTutorial()
    {
        //Vector3 a = Vector3.zero; // new Vector3(0,0,0)
        Vector3 a = new Vector3(0,3,0);
        Vector3 b = new Vector3(2,0,0);

        //noktasal çarpım hesaplaması
        //a.b = |a|x|b|xcos(teta) -> teta=radyan, dereceye çevirmeliyiz

        float dotProduct = a.x * b.x + a.y * b.y + a.z * b.z;

        float magA = Mathf.Sqrt(a.magnitude); //a.magnitude = a.x*a.x + a.y*a.y + a.z*a.z
        float magB = Mathf.Sqrt(b.magnitude);
        
        float cosTheta = dotProduct / (magA*magB);

        float theta = Mathf.Acos(dotProduct / (magA*magB))*Mathf.Rad2Deg; //değeri radyan cinsinden dereceye çevirdik.
        
        Debug.Log(theta);   
    }

    private void TestMethod()
    {
         //Debug.DrawLine(origin.position, p1.position, Color.red);
        //Debug.DrawLine(origin.position, p2.position, Color.gray);
        //Debug.DrawLine(origin.position, p1.position + p2.position, Color.yellow); //vektör toplamı
        //Debug.DrawLine(origin.position, p1.position - p2.position, Color.white); //vektör farkı

        Vector3 vector = new Vector3(3,4,5);

        Debug.DrawLine(origin.position, vector, Color.green);

        Debug.DrawLine(origin.position, vector.normalized, Color.red);

        Debug.Log(vector.magnitude); //7
        Vector3 normalized = vector.normalized; //vektörün 1 birimlik hali
        Debug.Log(normalized.magnitude); //1
    }
}
