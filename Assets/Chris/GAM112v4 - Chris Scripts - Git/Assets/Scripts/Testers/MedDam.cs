using UnityEngine;
using System.Collections;

public class MedDam : MonoBehaviour {

    public GameObject myPrefab;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            Instantiate(myPrefab,
                transform.position,
                transform.rotation);
        }
    }
}
