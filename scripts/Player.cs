using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 150.0f;
    private Rigidbody2D _body;
    private Animator _anim;
    private BoxCollider2D _box;

    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _box = GetComponent<BoxCollider2D>();
		_body.freezeRotation = true;

    }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float deltaY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector2 movement = new Vector2(deltaX, deltaY);
        _body.velocity = movement;

		var angle = Mathf.Atan2(deltaY, deltaX) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }	

}
