using UnityEngine;
using System.Collections;

public class RangeFinder : MonoBehaviour {

    public float range = 100.0f;

    //Update is called once per frame

    void Update()
    {

        Ray rayforward = new Ray(transform.position, transform.forward);
        Ray rayright = new Ray(transform.position, transform.right);
        Ray raybackward = new Ray(transform.position, -transform.forward);
        Ray rayleft = new Ray(transform.position, -transform.right);

        RaycastHit forwardhitinfo;
        RaycastHit righthitinfo;
        RaycastHit backwardhitinfo;
        RaycastHit lefthitinfo;

        Debug.DrawRay(transform.position, range * transform.forward, Color.red);
        Debug.DrawRay(transform.position, range * transform.right, Color.red);
        Debug.DrawRay(transform.position, range * -transform.forward, Color.red);
        Debug.DrawRay(transform.position, range * -transform.right, Color.red);


        if (Physics.Raycast(rayforward, out forwardhitinfo, range))
        {
            Debug.Log("Ray Hit");
            forwardhitinfo.transform.SendMessage("Attack");
        }

        if (Physics.Raycast(rayright, out righthitinfo, range))
        {
            righthitinfo.transform.SendMessage("Attack");
        }

        if (Physics.Raycast(raybackward, out backwardhitinfo, range))
        {
            backwardhitinfo.transform.SendMessage("Attack");
        }

        if (Physics.Raycast(rayleft, out lefthitinfo, range))
        {
            lefthitinfo.transform.SendMessage("Attack");
        }
    }
}
