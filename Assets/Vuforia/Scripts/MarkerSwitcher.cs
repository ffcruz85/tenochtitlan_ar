using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;


public class MarkerSwitcher : MonoBehaviour {

    public GameObject CanvasText;
    public Text TitleText = null;
    public Text StoryText = null;
    public GameObject ItemText = null;
    public GameObject ItemTitle = null;
    //public float speed = 12f;


    // Use this for initialization
    void Start()
    {
        //CanvasText.SetActive(false);  

    }

    //// Update is called once per frame
    //void Update()
    //{
    //    transform.Rotate(Vector3.up, speed * Time.deltaTime);
    //}



    private void OnMouseDown()
    {
        if (CanvasText != null && CanvasText.activeSelf==false)
        { 
                CanvasText.SetActive(true); //
                TitleText.text = ItemTitle.GetComponent<Text>().text;
                StoryText.text = ItemText.GetComponent<Text>().text;         

        }
        //int title = GetInstanceID();
        
       

    }
}
