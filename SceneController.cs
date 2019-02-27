using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    private float timer;
    private void Start()
    {
        timer = 18000.0f;
    }
    

    private void Update()
    {
        timer--;
        if (timer == 0){
            SceneManager.LoadScene("EndLevelScene");
        }
    }
}
