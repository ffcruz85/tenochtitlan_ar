using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class colorize : MonoBehaviour {
    public GameObject ColorizedMap;
    public GameObject Rivera;
    public float speed = 12f;

    // Use this for initialization
    void Start () {
        ColorizedMap.SetActive(false);
        Rivera.SetActive(false);
    }

    // Update is called once per frame
    
       void Update ()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }


        private void OnMouseDown()
        {
        if (ColorizedMap.activeSelf)
        {
            ColorizedMap.SetActive(false);
        }
        else
        {
            ColorizedMap.SetActive(true);
        }

        if (Rivera.activeSelf)
        {
            Rivera.SetActive(false);
        }
        else
        {
            Rivera.SetActive(true);
        }


    }
    }