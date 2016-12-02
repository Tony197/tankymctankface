using UnityEngine;
using System.Collections;

public class TDDam : MonoBehaviour {

    public GameObject myPrefab;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {

            Instantiate(myPrefab,
                transform.position,
                transform.rotation);
        }
    }
}
