using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeCamera : MonoBehaviour 
{
	private Camera MainCamera;

    private int cams = 1;

    public Text mytext;

    public GameObject camone;
    public GameObject camtwo;
    public GameObject camthree;

    private Vector3 camonepos;
    private Vector3 camtwopos;
    private Vector3 camthreepos;

    private Quaternion camonerot;
    private Quaternion camtworot;
    private Quaternion camthreerot;

    // Use this for initialization
    void Start () 
	{
		MainCamera = GameObject.Find ("Main Camera").GetComponent<Camera> ();

	}

    public void OnClick()
    {
        ++cams;
    }

    void Update()
    {

        if(Input.GetKeyDown("c"))
        {
            ++cams;
        }

        camonepos = camone.transform.position;
        camtwopos = camtwo.transform.position;
        camthreepos = camthree.transform.position;

        camonerot = camone.transform.rotation;
        camtworot = camtwo.transform.rotation;
        camthreerot = camthree.transform.rotation;


        switch (cams)
        {
            case 1:
                MainCamera.transform.position = camonepos;
                MainCamera.transform.rotation = camonerot;
                mytext.text = "Camera: " + cams;
                break;

            case 2:
                MainCamera.transform.position = camtwopos;
                MainCamera.transform.rotation = camtworot;
                mytext.text = "Camera: " + cams;
                break;

            case 3:
                MainCamera.transform.position = camthreepos;
                MainCamera.transform.rotation = camthreerot;
                mytext.text = "Camera: " + cams;
                break;
        }

        if(cams == 4)
        {
            cams = 1;
        }
    }

	//public void OnMouseDown ()
	//{
	//	TopDownOn = !TopDownOn;

	//	if (TopDownOn) 
	//	{
	//		// set position
	//		MainCamera.transform.position = new Vector3 (0, 10, 0);
	//		Debug.Log ("UP");
	//	}
	//	else
	//	{
	//		// set position
	//		MainCamera.transform.position = new Vector3 (0, 1, -10);
	//		Debug.Log("DOWN");
	//	}

	//	// set rotation
	//	MainCamera.transform.LookAt(Vector3.zero);
	//}
}
