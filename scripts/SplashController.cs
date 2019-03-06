using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{	
	[SerializeField] GameObject splashBG;
	[SerializeField] GameObject splashButton;
	
	public void OnGameEnd() {
		
	}

	public void ShowCredits() {
		
	}
	
	public void OnGameStart() {
		//splashBG.SetActive(false);
		//splashButton.SetActive(false);
		SceneManager.LoadScene("SampleScene");
	}
	
	public void ShowIntro() {
		
	}
	
	public void ShowConclusion() {
		
	}
	
	public void RestartGame() {
		splashBG.SetActive(true);
		splashButton.SetActive(true);
	}
	
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
