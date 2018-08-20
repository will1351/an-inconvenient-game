using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityScript : MonoBehaviour {
    public GameObject toolTip;
    
	// Use this for initialization
	void Start () {
        //GameObject.Find("ToolTipCanvas").SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnMouseDown()
    {

        //if (!GameObject.Find("ToolTipCanvas").activeSelf)
        //{
        //    GameObject.Find("ToolTipCanvas").SetActive(true);
        //Debug.Log("its true");

        //}
        //else
        //{
        //    GameObject.Find("ToolTipCanvas").SetActive(false);
        //    Debug.Log("its false");

        //}
        toolTip.GetComponent<ToolTipPanelScript>().showHidePanel();


        //GameObject.Find("ToolTipCanvas").SetActive(true);


    }
}
