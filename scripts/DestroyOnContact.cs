using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
	[SerializeField] private SceneController controller;
	
	private void OnCollisionEnter2D(Collider2D collision) 
	{
		Debug.Log("collision!");
		if (collision.tag == "Harpoon" && this.gameObject.tag == "Clam") {
			Destroy(this.gameObject);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log(collision.tag);
		Debug.Log(this.gameObject.tag);
		
		if (collision.tag == "Player" && this.gameObject.tag == "Coin")   // ran into a coin
		{	
			controller.updateCoins();
			Destroy(this.gameObject);
		}
		if (collision.tag == "Harpoon" && this.gameObject.tag == "Clam") {
			Destroy(this.gameObject);
		}
		//if (collision.tag == "Clam" && this.gameObject.tag == "Harpoon")   // harpoon hit a clam
		//{
		//	Destroy(collision);
		//}
		if (collision.tag == "Player" && this.gameObject.tag == "Enemy")   // ran into an enemy
		{
			controller.attackedPlayer();
			Destroy(this.gameObject);
		}
		if (collision.tag == "Harpoon" && this.gameObject.tag == "Enemy")   // harpoon hit an enemy
		{
			controller.updateCoins();
			Destroy(this.gameObject);
		}
		if (this.gameObject.tag == "Harpoon")   // destroy harpoons
		{
			Destroy(this.gameObject);
		}
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
