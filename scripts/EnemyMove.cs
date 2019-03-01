using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
	public int routine;
     public enum OccilationFuntion { Sine, Cosine };
	public float distance;
	private float x;
	private float y;
	private SpriteRenderer sharkSprite;
	private bool direction = false; //left

     public void Start ()
     {
		 x = transform.position.x;
		 y = transform.position.y;
		if (routine == 0) {
			StartCoroutine (Oscillate (OccilationFuntion.Sine, distance));
		 }
		 else{
			StartCoroutine (Oscillate (OccilationFuntion.Cosine, distance));
		 }
	 }
 
     private IEnumerator Oscillate (OccilationFuntion method, float scalar)
     {
         while (true)
         {
             if (method == OccilationFuntion.Sine)
             {
				
				 //Debug.Log((Mathf.Sin (Time.time) * scalar));
				 if ((Mathf.Sin (Time.time) * scalar) > (scalar-.01) && !direction)
				 {
					 sharkSprite = GetComponent<SpriteRenderer>();
					 sharkSprite.flipX = !sharkSprite.flipX;
					 direction = true;
				 }
				 if ((Mathf.Sin (Time.time) * scalar) < (-scalar+.01) && direction)
				 {
					 sharkSprite = GetComponent<SpriteRenderer>();
					 sharkSprite.flipX = !sharkSprite.flipX;
					 direction = false;
				 }
                 transform.position = new Vector3 (x+(Mathf.Sin (Time.time) * scalar), y, 0);
             }
             else if (method == OccilationFuntion.Cosine)
             {
				 if ((Mathf.Cos (Time.time) * scalar) > (scalar-.01) && direction)
				 {
					 sharkSprite = GetComponent<SpriteRenderer>();
					 sharkSprite.flipX = !sharkSprite.flipX;
					 direction = false;
				 }
				 if ((Mathf.Cos (Time.time) * scalar) < (-scalar+.01) && !direction)
				 {
					 sharkSprite = GetComponent<SpriteRenderer>();
					 sharkSprite.flipX = !sharkSprite.flipX;
					 direction = true;
				 }
                 transform.position = new Vector3(x+(Mathf.Cos(Time.time) * scalar), y, 0);
             }
             yield return new WaitForEndOfFrame ();
         }
     }
}