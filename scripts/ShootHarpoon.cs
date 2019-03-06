using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootHarpoon : MonoBehaviour
{
	public Rigidbody2D harpoon;
	public float harpoonSpeed = 4f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
		{
    		var harpInst = Instantiate(harpoon, transform.position, transform.rotation);
            float xspeed = harpoonSpeed * Mathf.Cos(transform.eulerAngles.z * Mathf.Deg2Rad);
            float yspeed = harpoonSpeed * Mathf.Sin(transform.eulerAngles.z * Mathf.Deg2Rad);
            harpInst.velocity = new Vector2(xspeed,yspeed);
		}
    }
}
