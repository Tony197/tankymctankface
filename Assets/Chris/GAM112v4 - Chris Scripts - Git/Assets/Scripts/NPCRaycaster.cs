using UnityEngine;
using System.Collections;

public class NPCRaycaster : MonoBehaviour {

	public float speed = 0.05f;

	// Update is called once per frame
	void Update ()
	{

		Ray rayForward = new Ray (transform.position, transform.forward);
		Ray rayForwardLeft = new Ray (transform.position, transform.forward-transform.right);
		Ray rayForwardRight = new Ray (transform.position, transform.forward+transform.right);

		if(Physics.Raycast(rayForward, 1.0f))
		{
			// move back and rotate randomly
			transform.Translate (-transform.forward * Time.deltaTime * speed);
			transform.Rotate(0, Random.Range(-45, 45), 0);
		}
		else if(Physics.Raycast(rayForwardLeft, 0.8f))
		{
			// rotate Right
			transform.Rotate(0, 1, 0);
		}
		else if(Physics.Raycast(rayForwardRight, 0.8f))
		{
			// rotate left
			transform.Rotate(0, -1, 0);
		}

		transform.Translate (transform.forward * Time.deltaTime * speed);
		Debug.DrawRay (transform.position, transform.forward, Color.red);
		Debug.DrawRay (transform.position, 0.8f*(transform.forward-transform.right), Color.red);
		Debug.DrawRay (transform.position, -transform.right, Color.red);
		Debug.DrawRay (transform.position, 0.8f*(-transform.forward-transform.right), Color.red);
		Debug.DrawRay (transform.position, -transform.forward, Color.red);
		Debug.DrawRay (transform.position, 0.8f*(-transform.forward+transform.right), Color.red);
		Debug.DrawRay (transform.position, transform.right, Color.red);
		Debug.DrawRay (transform.position, 0.8f*(transform.forward+transform.right), Color.red);


	}
}
