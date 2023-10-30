using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text text;
    public int scoreOne;
    public int scoreTwo;
  

    void Start()
    {
    }


    void Update()
    { }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("leftWall"))
        {
            scoreOne++;
            
            

        }
        if (collision.gameObject.CompareTag("Vertical"))
        {
            scoreTwo++;
            text.text = scoreOne+ " - " + scoreTwo;
        }
    }
}