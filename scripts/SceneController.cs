using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
	
	[SerializeField] private TextMesh coinLabel;
	[SerializeField] private TextMesh healthLabel;
	private int _score = 0;   // coins
	private int _health = 5;  // health bar

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
	
	public void attackedPlayer()
	{
		_health--;
		healthLabel.text = "Health: " + _health;
		if (_health == 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}

	public void updateCoins()
	{
		_score++;
		coinLabel.text = "Coins: " + _score;
	}
}
