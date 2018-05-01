using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour 
{
	public float torque = 10f;
	public float force = 50f;
	public Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			rb.AddTorque(force*torque);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			rb.AddTorque(-force*torque);
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			rb.AddRelativeForce(Vector3.up*(force/100), ForceMode2D.Impulse);
		}

	}
}
