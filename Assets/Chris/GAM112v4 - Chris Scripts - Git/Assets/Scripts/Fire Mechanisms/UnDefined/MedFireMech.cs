using UnityEngine;
using System.Collections;

public class MedFireMech : MonoBehaviour {

    public GameObject forwardfire;
    public GameObject rightfire;
    public GameObject backwardfire;
    public GameObject leftfire;

    private Vector3 forwardposition;
    private Vector3 rightposition;
    private Vector3 backwardposition;
    private Vector3 leftposition;

    private Quaternion forwardrotation;
    private Quaternion rightrotation;
    private Quaternion backwardrotation;
    private Quaternion leftrotation;

    public GameObject shell;

    private bool fire = false;
    private bool firetwo = false;

    public MediumChassis colorchange;

    public Color highlightedcolor = new Color(255, 255, 255, 255);

    public GameObject chassis;

    public void Fire()
    {
        if(!fire && !firetwo)
        {
            fire = true;
            chassis.GetComponent<Renderer>().material.color = highlightedcolor;
        }

    }

    public void Move()
    {
        firetwo = false;
    }

	// Update is called once per frame
	void Update ()
    {

        forwardposition = forwardfire.transform.position;
        rightposition = rightfire.transform.position;
        backwardposition = backwardfire.transform.position;
        leftposition = leftfire.transform.position;

        forwardrotation = forwardfire.transform.rotation;
        rightrotation = rightfire.transform.rotation;
        backwardrotation = backwardfire.transform.rotation;
        leftrotation = leftfire.transform.rotation;


        if (Input.GetKeyDown("up") && fire)
        {
            Instantiate(shell, forwardposition, forwardrotation);
            fire = false;
            firetwo = true;
            colorchange.ChangeColor();
        }

        if (Input.GetKeyDown("right") && fire)
        {
            Instantiate(shell, rightposition, rightrotation);
            fire = false;
            firetwo = true;
            colorchange.ChangeColor();
        }

        if (Input.GetKeyDown("down") && fire)
        {
            Instantiate(shell, backwardposition, backwardrotation);
            fire = false;
            firetwo = true;
            colorchange.ChangeColor();
        }

        if (Input.GetKeyDown("left") && fire)
        {
            Instantiate(shell, leftposition, leftrotation);
            fire = false;
            firetwo = true;
            colorchange.ChangeColor();
        }
    }
}
