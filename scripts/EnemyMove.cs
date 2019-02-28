using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
     public enum OccilationFuntion { Sine, Cosine }
	public int distance;

     public void Start ()
     {
         StartCoroutine (Oscillate (OccilationFuntion.Sine, 1f));
     }
 
     private IEnumerator Oscillate (OccilationFuntion method, float scalar)
     {
         while (true)
         {
             if (method == OccilationFuntion.Sine)
             {
                 transform.position = new Vector3 (Mathf.Sin (Time.time) * scalar, 0, 0);
             }
             else if (method == OccilationFuntion.Cosine)
             {
                 transform.position = new Vector3(Mathf.Cos(Time.time) * scalar, 0, 0);
             }
             yield return new WaitForEndOfFrame ();
         }
     }
}