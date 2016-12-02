using UnityEngine;
using System.Collections;

public class PlaneSelect : MonoBehaviour {

    public Color staticcolor = Color.white;
    public Color highlightedcolor = Color.red;
    public Color triggeredcolor = Color.green;

    public GameObject square;

    private GameObject tank;

    public GameObject snapper;

    private Vector3 pSnap;

    void Start()
    {
        pSnap = snapper.transform.position;
    }

    void HitByRay()
    {
        square.GetComponent<Renderer>().material.color = highlightedcolor;
    }

    void OnTriggerStay(Collider other)
    {
        square.GetComponent<Renderer>().material.color = triggeredcolor;
        tank = other.gameObject;

        tank.transform.position = pSnap;
    }

    void FixedUpdate()
    {
        square.GetComponent<Renderer>().material.color = staticcolor;
    }
}