using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
	[SerializeField] private SceneController controller;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log(collision.tag);
		Debug.Log(this.gameObject.tag);
		
		if (collision.tag == "Player" && this.gameObject.tag == "Coin")   // ran into a coin
		{	
			controller.updateCoins();
		}
		if (collision.tag == "Player" && this.gameObject.tag == "Enemy")   // ran into an enemy
		{
			controller.attackedPlayer();
		}
		if (collision.tag == "Harpoon" && this.gameObject.tag == "Enemy")   // harpoon hit an enemy
		{
			controller.updateCoins();
		}
		Destroy(this.gameObject);
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
