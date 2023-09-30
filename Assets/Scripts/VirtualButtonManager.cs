using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonManager : MonoBehaviour
{
    public VirtualButtonBehaviour virtualButton;
    public GameObject Model;
    private bool isActive;

    void Start()
    {
        virtualButton.RegisterOnButtonPressed(OnButtonPressed);
        virtualButton.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (Model.activeInHierarchy == false)
        {
            Model.SetActive(true);
        }
        else
        {
            Model.SetActive(false);
        }
        
        Debug.Log("button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("button released");
    }
}