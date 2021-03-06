﻿using System;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

public class Axis : MonoBehaviour {

    private float meshLength = 2.0f;    // This is the initial length of the cylinder used for the axis.
    
	// Use this for initialization
	void Start () {

        //SetTitle("override");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetTitle(string title)
    {
        gameObject.GetComponentInChildren<TextMesh>().text = title;
    }

    internal void SetOrientation(string orient, string face)
    {
        if(orient == "bottom" && face == "front")
        {
            OrientAlongPositiveX();
        } else if(orient == "left" && face == "front")
        {
            OrientAlongPositiveY();
        } else if(orient == "bottom" && face == "left")
        {
            OrientAlongPositiveZ();
        }
    }  

    private void OrientAlongPositiveX()
    {

        OrientTitleAlongPositiveX();
        OrientAxisLineAlongPositiveX();
    }

    private void OrientAxisLineAlongPositiveX()
    {
        Transform lineTransform = gameObject.transform.Find("AxisLine");

        if (lineTransform != null)
        {
            lineTransform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
            lineTransform.Rotate(0.0f, 0.0f, -90.0f);

            Debug.Log("Move x axis by " + GetLength().ToString());
            lineTransform.localPosition = new Vector3(GetLength() / 2.0f, 0.0f, 0.0f);
        }
    }

    private void OrientTitleAlongPositiveX()
    {
        Transform titleTransform = gameObject.transform.Find("Title");

        // TODO: Figure out how to center
        float translateBy = 0.25f;
        float shiftBy = 0.015f;
        titleTransform.localPosition = new Vector3(translateBy, -shiftBy, 0);
    }

    private void OrientAlongPositiveY()
    {
        OrientTitleAlongPositiveY();
        OrientAxisLineAlongPositiveY();
    }

    private void OrientAxisLineAlongPositiveY()
    {
        Transform lineTransform = gameObject.transform.Find("AxisLine");

        if (lineTransform != null)
        {
            lineTransform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
            lineTransform.localPosition = new Vector3(0.0f, GetLength() / 2.0f, 0.0f);
        }
    }

    private void OrientTitleAlongPositiveY()
    {
        Transform titleTransform = gameObject.transform.Find("Title");
        //Transform textTransform = titleTransform.Find("Text");
        if (titleTransform != null)
        {
            //Vector3 curTextSize = textTransform.GetComponent<MeshRenderer>().bounds.size;
            titleTransform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
            titleTransform.Rotate(0.0f, 0.0f, 90.0f);

            // TODO: Figure out how to center
            float translateBy = 0.25f;
            float shiftBy = 0.015f;
            titleTransform.localPosition = new Vector3(-shiftBy, translateBy, 0);
        }
    }

    private void OrientAlongPositiveZ()
    {
        OrientTitleAlongPositiveZ();
        OrientAxisLineAlongPositiveZ();
    }

    private void OrientAxisLineAlongPositiveZ()
    {
        Transform lineTransform = gameObject.transform.Find("AxisLine");

        if (lineTransform != null)
        {
            lineTransform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
            lineTransform.Rotate(90.0f, 0.0f, 0.0f);
            lineTransform.localPosition = new Vector3(0.0f, 0.0f, GetLength() / 2.0f);
        }
    }

    private void OrientTitleAlongPositiveZ()
    {
        Transform titleTransform = gameObject.transform.Find("Title");
        if (titleTransform != null)
        {
            titleTransform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
            titleTransform.localRotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);

            float translateBy = 0.25f;
            float shiftBy = 0.015f;
            titleTransform.localPosition = new Vector3(0, -shiftBy, translateBy);
        }
    }

    internal void SetLength(float length)
    {
        length = length * DxR.SceneObject.SIZE_UNIT_SCALE_FACTOR;

        Transform lineTransform = gameObject.transform.Find("AxisLine");

        if(lineTransform != null)
        {
            float newLocalScale = length / GetMeshLength();
            lineTransform.localScale = new Vector3(lineTransform.localScale.x,
                newLocalScale, lineTransform.localScale.z);
        }
    }

    private float GetMeshLength()
    {
        return meshLength;
    }

    private float GetLength()
    {
        Transform lineTransform = gameObject.transform.Find("AxisLine");
        Vector3 renderSize = lineTransform.GetComponent<Renderer>().bounds.size;
        return Math.Max(renderSize.x, Math.Max(renderSize.y, renderSize.z));
    }

    internal void EnableAxisColorCoding(string channelType)
    {
        Transform lineTransform = gameObject.transform.Find("AxisLine");

        if (channelType == "x")
        {
            lineTransform.GetComponent<Renderer>().material.color = Color.red;
        } else if(channelType == "y")
        {
            lineTransform.GetComponent<Renderer>().material.color = Color.green;
        } else if(channelType == "z")
        {
            lineTransform.GetComponent<Renderer>().material.color = Color.blue;
        }
        
    }

    internal void UpdateSpecs(JSONNode axisSpecs)
    {
        throw new NotImplementedException();
    }
}
