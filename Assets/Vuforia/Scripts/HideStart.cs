using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideStart : MonoBehaviour {

    public GameObject MainCanvas = null;

	// Use this for initialization
	void Start () {
        MainCanvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        MainCanvas.SetActive(false);
        //int title = GetInstanceID();



    }

}
