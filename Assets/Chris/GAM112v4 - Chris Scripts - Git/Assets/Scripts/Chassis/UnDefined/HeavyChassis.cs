﻿using UnityEngine;
using System.Collections;

public class HeavyChassis : MonoBehaviour
{

    public TankStatHeavy medfiredon;
    public TankStatHeavy hevfiredon;
    public TankStatHeavy tdfiredon;

    public HevFireMech select;

    public float delayDuration = 1.0f;
    private float timeOfShot = 1.0f;

    private bool attackable = false;

    private bool abletofire = false;

    public Color normcolor = Color.blue;

    public void ChangeColor()
    {
        GetComponent<Renderer>().material.color = normcolor;
        abletofire = false;
    }

    public void Firing()
    {
        //Debug.Log("Firing Active");
        abletofire = true;
    }
    // Use this for initialization
    void HitByRay()
    {
        if (Input.GetButtonDown("Fire1") && abletofire)
        {
            select.Fire();
            abletofire = false;
        }
    }

    public void Attacked()
    {
        attackable = true;
    }

    // Update is called once per frame
    public void Timer()
    {
        attackable = false;
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Cube Hit");
        if ((other.gameObject.tag == "Medium Round") && attackable)
        {
            medfiredon.MedFiredOn();
        }

        if ((other.gameObject.tag == "Heavy Round") && attackable)
        {
            hevfiredon.HevFiredOn();
        }

        if ((other.gameObject.tag == "TD Round") && attackable)
        {
            tdfiredon.TDFiredOn();
        }
    }
}