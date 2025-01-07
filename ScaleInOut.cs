using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleInOut : MonoBehaviour
{
    public GameObject Object;

    private bool ZoomIn;
    private bool ZoomOut;

    //object scale speeding making sure that the transition is smooth
    public float Scale = 0.1f;

    // Update method is called once per frame so that whenever particular ZoomIn and ZoomOut is used it updates Accordingly
    void Update()
    {
        if (ZoomIn)
        {
            //makes a bigger object
            Object.transform.localScale += new Vector3(Scale, Scale, Scale);
        }

        if (ZoomOut)
        {
            //makes a small object
            Object.transform.localScale -= new Vector3(Scale, Scale, Scale);
        }
    }

    //Make the object scaled big using the boolean values
    public void OnPressZoomIn()
    {
        ZoomIn = true;
    }

    public void OnReleaseZoomIn()
    {
        ZoomIn = false;
    }

    //Make the object scaled small using the boolean values
    public void OnPressZoomOut()
    {
        ZoomOut = true;
    }

    public void OnReleaseZoomOut()
    {
        ZoomOut = false;
    }
}