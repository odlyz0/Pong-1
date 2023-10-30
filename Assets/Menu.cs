using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnePlayer()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void TwoPlayer()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void LastPlayer()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
    
    
