


// image texture to use togheter: https://www.4shared.com/photo/f5qJ0iymda/ball09.html
// image texture to use togheter: https://www.4shared.com/photo/7JZSDHQwgm/ball13.html
// image texture to use togheter: https://www.4shared.com/photo/qpOo2VY8gm/table.html
// Use spheres and a cube or plane to build the table and the balls of the game 

// Video to reference of a 3D Billiards Game basic example  (in portuguese): https://www.youtube.com/watch?v=NG0J7z_FACQ
// Video to reference of a moving 3D BallGame basic example  (in english): https://www.youtube.com/watch?v=mckCK_2T9CQ

// Use this code to control white ball (ball number 0 of the game example)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallBilliards : MonoBehaviour 
{
	public float force = 5f;
	public Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			rb.AddRelativeForce(new Vector3(0,0,1)*(force/5f), ForceMode.Impulse);
		}

	}
}
