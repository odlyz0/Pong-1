 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bal : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed;
    public float ySpeed;

    // Start is called before the first frame update
    void Start()
    {

        xSpeed = 1f;
        ySpeed = 1f;    

    }

    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Horizantal"))
        {
            ySpeed = ySpeed * -1;
        }
        if (collision.gameObject.CompareTag("Vertical"))
        {
           xSpeed = xSpeed * -1;
        }
    }
}
