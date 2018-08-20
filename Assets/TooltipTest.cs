using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnMouseEnter()
    {
        
      //  Debug.Log("Entering");
    }

    void OnMouseExit()
    {
      //  Debug.Log("Exiting");
    }

    void OnGUI()
    {
        // Make a button using a custom GUIContent parameter to pass in the tooltip.
        GUI.Button(new Rect(10, 10, 100, 20), new GUIContent("Hover over me", "This is the tooltip"));

        // Display the tooltip from the element that has mouseover or keyboard focus
        GUI.Label(new Rect(10, 40, 100, 40), GUI.tooltip);
    }
}
