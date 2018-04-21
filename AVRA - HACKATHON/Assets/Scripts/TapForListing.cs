﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class TapForListing : MonoBehaviour, IInputClickHandler {

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    private Vector3 but1;
    private Vector3 but2;
    private Vector3 but3;
    private Vector3 but4;
    private Vector3 but5;

    

    public void OnInputClicked(InputClickedEventData eventData)
    {
        GameObject gameObject = eventData.selectedObject.gameObject;
        this.resetButtons();
        gameObject.GetComponentInParent<Button>().transform.localPosition += new Vector3(0, 0, -20);

    }

    void resetButtons()
    {
        this.button1.transform.localPosition = this.but1;
        this.button2.transform.localPosition = this.but2;
        this.button3.transform.localPosition = this.but3;
        this.button4.transform.localPosition = this.but4;
        this.button5.transform.localPosition = this.but5;
    }

    // Use this for initialization
    void Start () {
		this.but1 = button1.transform.localPosition;
        this.but2 = button2.transform.localPosition;
        this.but3 = button3.transform.localPosition;
        this.but4 = button4.transform.localPosition;
        this.but5 = button5.transform.localPosition;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
