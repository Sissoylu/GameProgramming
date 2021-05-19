using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoroutineTut : MonoBehaviour
{
    public Transform[] targets;
    private Vector3[] targetpositions;


    public Transform target;
    public Text messageText;
    string message = "It isn't like any sandwich I've tasted before";

    string[] words;
    // Start is called before the first frame update
    void Start()
    {
        targetpositions = new Vector3[targets.Length];

        for (int i = 0; i< targets.Length; i++)
        {
            targetpositions[i] = targets[i].position;
        }



        words = message.Split(' ');
        //StartCoroutine(showDialog());
        StartCoroutine(moveToTargetPositions(targetpositions, 5));
    }

    IEnumerator move(Vector3 targetPosition, float moveSpeed)
    {
        //kendi konumu hedef konuma eşit olmadığı sürece hedefe doğru ilerle
        while(transform.position != targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed*Time.deltaTime);
            yield return null;
        }
    }


    IEnumerator showDialog()
    {
        foreach (var word in words)
        {
            //Debug.Log(word); //consola yazdırdı

            messageText.text += " " + word;

            //enumerator içindeki her şey bir değere dönmelidir.
            yield return new WaitForSeconds(0.2f);
        }

    }

    IEnumerator Fade()
    {
        for(float ft = 1f; ft>=0; ft -= 0.1f)
        {
            Color c = GetComponent<Renderer>().material.color;
            c.a = ft;
            GetComponent<Renderer>().material.color = c;
            yield return null;
        }

    }

    IEnumerator moveToTargetPositions(Vector3[] targetPositions, float moveSpeed)
    {
        foreach (var target in targetPositions)
        {
            yield return move(target, moveSpeed);
            Debug.Log("arrived");
        }
        //işlemin tekrarlanması için bunu yazmalıyız.
        yield return moveToTargetPositions(targetPositions, moveSpeed);
    }

    IEnumerator current;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            StartCoroutine(Fade());

            //bir routine başlatıldıysa
            //bunu durdur(current olanı) 
            //if (current != null)
            //{
            //    StopCoroutine(current);
            //}



            //var x = UnityEngine.Random.insideUnitCircle.x;
            //var z = UnityEngine.Random.insideUnitCircle.y;
            //var targetPos = new Vector3(x, 0, z);
            //current = move(targetPos, 5);

            //StartCoroutine(current);

            //space'e bastığımızda bir routine başlatılıyor ve 
            //tekrar space'e bastığımızda önceki routine devam ederken üzerine eklenior
            //bu da bozulmaya sebep oluyor
            //StartCoroutine(move(targetPos,5));

        }

        
    }
}
