using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceDirection : MonoBehaviour
{
	private Rigidbody2D rigidbody;
	float someScale;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
		rigidbody.freezeRotation = true;
		someScale = transform.localScale.x; // assuming this is facing right
    }
 
 // replace transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y); by
 //transform.localScale = new Vector2(someScale, transform.localScale.y);
 // and...        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y); by
 //transform.localScale = new Vector2(-someScale, transform.localScale.y);


    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.LookRotation(rigidbody.velocity);
		float deltaX = Input.GetAxis("Horizontal");
        float deltaY = Input.GetAxis("Vertical");
        
		var angle = Mathf.Atan2(deltaY, deltaX) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
