using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTipPanelScript : MonoBehaviour {
    public GameObject Panel;
    int counter;
	// Use this for initialization
	void Start () {
        Panel.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showHidePanel()
    {
        counter++;
        if(counter % 2 == 1)
        {
            Panel.gameObject.SetActive(true);
        }
        else
        {
            Panel.gameObject.SetActive(false);
        }
    }
}
