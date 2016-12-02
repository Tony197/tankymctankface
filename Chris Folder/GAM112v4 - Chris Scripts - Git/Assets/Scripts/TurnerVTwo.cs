using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TurnerVTwo : MonoBehaviour {

    public GameObject cam;

    private Dragger drag;
    public Dragger mover;

    public Text mytext;

    public USMediumChassis usmedfire;
    public USHeavyChassis ushevfire;
    public USTDChassis ustdfire;

    public GermanMediumChassis germedfire;
    public GermanHeavyChassis gerhevfire;
    public GermanTDChassis gertdfire;

    public USMedFireMech usmedmover;
    public USHevFireMech ushevmover;
    public USTDFireMech ustdmover;

    public GermanMedFireMech germedmover;
    public GermanHevFireMech gerhevmover;
    public GermanTDFireMech gertdmover;

    public USMediumChassis usmedfired;
    public USHeavyChassis ushevfired;
    public USTDChassis ustdfired;

    public GermanMediumChassis germedfired;
    public GermanHeavyChassis gerhevfired;
    public GermanTDChassis gertdfired;

    private int turns = 1;


    // Use this for initialization
    void Start ()
    {
        drag = cam.GetComponent<Dragger>();
        mytext.GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update ()
    {

        if(Input.GetKeyDown("v"))
        {
            ++turns;
        }

        switch (turns)
        {
            case 1:
                drag.enabled = true;
                mytext.text = "Move";
                mytext.color = Color.blue;
                usmedmover.Move();
                ushevmover.Move();
                ustdmover.Move();
                mover.USMove();

                germedfired.Fired();
                gerhevfired.Fired();
                gertdfired.Fired();
                break;
            case 2:
                drag.enabled = false;
                mytext.text = "Attack";
                mytext.color = Color.blue;
                usmedfire.Firing();
                ushevfire.Firing();
                ustdfire.Firing();
                break;
            case 3:
                drag.enabled = true;
                mytext.text = "Move";
                mytext.color = Color.red;
                germedmover.Move();
                gerhevmover.Move();
                gertdmover.Move();
                mover.GermanyMove();

                usmedfired.Fired();
                ushevfired.Fired();
                ustdfired.Fired();
                break;
            case 4:
                drag.enabled = false;
                mytext.text = "Attack";
                mytext.color = Color.red;
                germedfire.Firing();
                gerhevfire.Firing();
                gertdfire.Firing();
                break;
        }

        if (turns == 5)
        {
            turns = 1;
        }
    }

    public void OnClick()
    {
        ++turns;
    }
}
