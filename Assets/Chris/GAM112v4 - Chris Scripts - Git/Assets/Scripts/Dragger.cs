using UnityEngine;
using System.Collections;

public class Dragger : MonoBehaviour
{

    // the distance from the camera to the selected game object
    private float distance;

    // the transform of the selected game object
    private Transform toDrag;

    // allow only one object to be dragged
    private bool dragging = false;

    private Vector3 v3;
    private Vector3 offset;

    private GameObject hitObject;

    private bool us = true;
    private bool germany = true;

    public void USMove()
    {
        us = true;
        germany = false;
    }

    public void GermanyMove()
    {
        us = false;
        germany = true;
    }

    void Update()
    {
        // left mouse button down
        if (Input.GetButtonDown("Fire1"))
        {

            // specify a ray from the camera to infinity
            // through the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // store information about ray intersection
            RaycastHit hit;

            // cast the ray
            if (Physics.Raycast(ray, out hit))
            {
                hitObject = hit.collider.gameObject;

                dragging = true;

                // the transform of the selected game object
                toDrag = hit.transform;

                // the distance from the camer to the selected game oject
                // distance = hit.transform.position.z - Camera.main.transofrm.position;
                distance = hit.distance;

                // screen coordinates, with the distance in front of camera
                v3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);

                // world coordinates
                v3 = Camera.main.ScreenToWorldPoint(v3);

                // the vector from the serlected position to center of game object
                offset = toDrag.position - v3;
            }

        }

        // left mouse button drag
        if (Input.GetButton("Fire1"))
        {
            if(hitObject.CompareTag("U.S Tank") && us)
            {
                if (dragging)
                {
                    // screen coordinates, with distance in front of camera
                    v3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);

                    // world coordinates
                    v3 = Camera.main.ScreenToWorldPoint(v3);

                    // position of the center of the game object
                    toDrag.position = v3 + offset;
                }


            }

            if (hitObject.CompareTag("Germany Tank") && germany)
            {
                if (dragging)
                {
                    // screen coordinates, with distance in front of camera
                    v3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);

                    // world coordinates
                    v3 = Camera.main.ScreenToWorldPoint(v3);

                    // position of the center of the game object
                    toDrag.position = v3 + offset;
                }


            }

        }

        // left mouse button up
        if (Input.GetButtonUp("Fire1"))
        {
            // nothing selected
            dragging = false;
        }

    }
}