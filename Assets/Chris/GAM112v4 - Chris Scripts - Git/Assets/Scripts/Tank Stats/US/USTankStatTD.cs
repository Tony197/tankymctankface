using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class USTankStatTD : MonoBehaviour
{

    public USTDChassis tdcas;
    public USTDChassis timer;

    public float health = 100.0f;

    public float mDamage = 20.0f;
    public float hDamage = 25.0f;
    public float tdDamage = 50.0f;

    public float range = 50.0f;

    public float distnace = 50.0f;

    private bool attackable = false;

    public float delayDuration = 1.0f;
    private float timeOfShot = 1.0f;

    public GameObject chassis;


    // Use this for initialization
    void Start()
    {

    }

    void Attack()
    {
        attackable = true;
        tdcas.Attacked();
    }
    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Debug.Log("He Dead");
            gameObject.SetActive(false);
            chassis.gameObject.SetActive(false);
        }

        //Debug.Log("attack status = " + attackable);

        if (Time.time > timeOfShot + delayDuration)
        {
            attackable = false;
            timeOfShot = Time.time;
            timer.Timer();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //Debug.Log("Cube Hit");
        if ((other.gameObject.tag == "Germany Medium Round") && attackable)
        {
            Debug.Log("Med Hit");
            health -= mDamage;
        }

        if ((other.gameObject.tag == "Germany Heavy Round") && attackable)
        {
            Debug.Log("Hev Hit");
            health -= hDamage;
        }

        if ((other.gameObject.tag == "Germany TD Round") && attackable)
        {
            Debug.Log("TD Hit");
            health -= tdDamage;
        }
    }

    public void MedFiredOn()
    {
        health -= mDamage;
    }

    public void HevFiredOn()
    {
        health -= hDamage;
    }

    public void TDFiredOn()
    {
        health -= tdDamage;
    }
}
