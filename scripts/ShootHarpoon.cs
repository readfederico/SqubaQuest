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
			Debug.Log(transform.rotation.z + " " + Mathf.Cos(transform.rotation.z )+ " " + Mathf.Sin(transform.rotation.z ) );
			//harpInst.velocity = new Vector2(harpoonSpeed * (Mathf.Cos(transform.rotation.z)), harpoonSpeed * (Mathf.Sin(transform.rotation.z)));
			harpInst.velocity = new Vector2(harpoonSpeed,0);
		}
    }
}
