using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices.WindowsRuntime;

enum MyEnum
{
    UP = 1,
    DOWN = 2,
    RIGHT = 3,
    LEFT = 4
}/*
        }*/

public class QuickTime : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] Rigidbody2D rb;
    private bool x = false; 
    int maxArrow = 3;

    public GameObject Up;
    public GameObject Down;
    public GameObject Right;
    public GameObject Left;

    Vector2 vector1;

    //public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        vector1 = gameObject.transform.position;

            StartCoroutine(spawn());
    }
    private void Update()
    {
    }
    private void Naber()
    {
        int randomNumber = randomNumbers();

        if (randomNumber == (int)MyEnum.UP)
        {
            GameObject UpBox = Instantiate(Up);
            UpBox.name = "Up";
            UpBox.SetActive(true);
            UpBox.transform.position = vector1;
        }
        else if (randomNumber == (int)MyEnum.DOWN)
        {
            GameObject UpBox = Instantiate(Down);
            UpBox.name = "Down";
            UpBox.SetActive(true);
            UpBox.transform.position = vector1;
        }
        else if (randomNumber == (int)MyEnum.RIGHT)
        {
            GameObject UpBox = Instantiate(Right);
            UpBox.name = "Right";
            UpBox.SetActive(true);
            UpBox.transform.position = vector1;
        }
        else if (randomNumber == (int)MyEnum.LEFT)
        {
            GameObject UpBox = Instantiate(Left);
            UpBox.name = "Left";
            UpBox.SetActive(true);
            UpBox.transform.position = vector1;
        }
    }
    IEnumerator spawn()
    {
        for(int i = 0;i < 10; i++)
        {
            yield return new WaitForSeconds(2f);
            Naber();
        }

       

    }
    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        int boxId = checkName();

        if (Input.GetKey(KeyCode.DownArrow) && boxId == (int)MyEnum.DOWN)
        {
            Debug.Log("Down");
            Destroy(gameObject);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && boxId == (int)MyEnum.UP)
        {

            Debug.Log("Up");
            Destroy(gameObject);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && boxId == (int)MyEnum.RIGHT)
        {
            Debug.Log("Right");
            Destroy(gameObject);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && boxId == (int)MyEnum.LEFT)
        {
            Debug.Log("Left");
            Destroy(gameObject);
        }
    }
    private int checkName()
    {
        if (gameObject.name.Equals("Up"))
        {
            return (int)(MyEnum.UP);
        }
        else if (gameObject.name.Equals("Down"))
        {
            return (int)(MyEnum.DOWN);
        }
        else if (gameObject.name.Equals("Right"))
        {
            return (int)(MyEnum.RIGHT);
        }
        else if (gameObject.name.Equals("Left"))
        {
            return (int)(MyEnum.LEFT);
        }
        return 0;
    }
    private int randomNumbers()
    {

        System.Random rnd = new System.Random();

        return rnd.Next(1, 5);

    }
}
