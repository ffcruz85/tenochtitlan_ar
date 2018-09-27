using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMaya : MonoBehaviour {

    public GameObject planeMaya = null;

    private void OnMouseDown()
    {
        if (planeMaya != null)
        {
            planeMaya.GetComponent<Renderer>().enabled = !planeMaya.GetComponent<Renderer>().enabled;
        }
    }
	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
