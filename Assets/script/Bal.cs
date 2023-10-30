 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bal : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed;
    public float ySpeed;
    public TMP_Text scoreField;
    private int leftScore = 0;
    private int rightScore = 0;
    public int topScore = 10;
    private void resetBall(string leftOrRight)
    {
        Xposition = 0f;
        Yposition = 0f;
        if (leftOrRight == "left")
        {

            xSpeed = 4f;
            ySpeed = 4f;
        }
        else if (leftOrRight=="right")
        {

            xSpeed = -4f;
            ySpeed = 4f;
        }
        scoreField.text = leftScore + " - " + rightScore;
    }

    // Start is called before the first frame update
    void Start()
    {

        xSpeed = 4f;
        ySpeed = 4f;
        scoreField.text = " 0  -  0";

    }

    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
        if (leftScore >= topScore)
        {
            scoreField.text = "left player has won!";
            xSpeed = 0f;
            ySpeed = 0f;
            Xposition = 0f;
            Yposition = 0f;
        }
        else if (rightScore>= topScore)
        {
            scoreField.text = "Right player has won!";
            xSpeed = 0f;
            ySpeed = 0f;
            Xposition = 0f;
            Yposition = 0f;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Horizantal"))
        {
            ySpeed = ySpeed * -1;
        }
       
        else if (collision.gameObject.CompareTag("rightWall"))
        {
            rightScore++;
            resetBall("left");
        }
        else if (collision.gameObject.CompareTag("leftWall"))
        {
            leftScore++;
            resetBall("right");
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1;
        }
    }
}
