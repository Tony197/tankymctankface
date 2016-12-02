using UnityEngine;
using System.Collections;

public class MouseSelector : MonoBehaviour 
{

    private GameObject target;

	
	// Update is called once per frame
	void Update () 
	{
		// define a ray from the camera to the mouse cursor
		// beginning at the screen and extending to infinity
		Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

		// use hitInfo to store ray collision infomation
		RaycastHit hitInfo;

		// cast a ray and check what it collides with
		if (Physics.Raycast (ray, out hitInfo)) 
		{
            hitInfo.transform.SendMessage("HitByRay");
        } 
	}
}
