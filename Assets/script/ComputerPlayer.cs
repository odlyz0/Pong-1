using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPlayer : MonoBehaviour
{
    public float ySpeed = 3f;
    private float yPosition = 0;
    public GameObject ball;

  
    void Start()
    {

    }
    void Update()
    {

        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
        if (yPosition >= 3.6f)
        {
            ySpeed = ySpeed * -1f;
        }
        else if (yPosition <= -3.6f)
        {
            ySpeed = ySpeed * -1f;
        }
        transform.position = new Vector3(transform.position.x, ball.transform.position.y/ ySpeed, transform.position.z);
    }
}
