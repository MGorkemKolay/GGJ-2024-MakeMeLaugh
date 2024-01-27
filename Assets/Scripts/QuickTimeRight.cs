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
}

public class QuickTime : MonoBehaviour
{
    [SerializeField] int maxArrow = 6;
    [SerializeField] float time = 0.3f;
    int sayac = 0;

    public GameObject Up;
    public GameObject Down;
    public GameObject Right;
    public GameObject Left;

    Vector2 vector1;

    void Start()
    {


        vector1 = gameObject.transform.position;

            StartCoroutine(spawnBlock());
    }

    //Create Object 
    private void createObject()
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
    IEnumerator spawnBlock()
    {
        for(int i = 0;i < maxArrow; i++)
        {
            yield return new WaitForSeconds(time);
            createObject();
        }
    }
    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        int boxId = checkName();

        if (Input.GetKey(KeyCode.DownArrow) && boxId == (int)MyEnum.DOWN)
        {
            sayac++;
            Destroy(gameObject);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && boxId == (int)MyEnum.UP)
        {
            sayac++;
            Destroy(gameObject);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && boxId == (int)MyEnum.RIGHT)
        {
            sayac++;
            Destroy(gameObject);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && boxId == (int)MyEnum.LEFT)
        {
            sayac++;
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
        return rnd.Next(1, 4);
    }
}
