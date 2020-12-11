using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Events;

public class VButton : MonoBehaviour
{
    VirtualButtonBehaviour[] virtualBtnBehaviours;

    // Start is called before the first frame update
    void Start()
    {
        virtualBtnBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualBtnBehaviours.Length; ++i)
        {
            virtualBtnBehaviours[i].RegisterOnButtonPressed(OnButtonPressed);
            virtualBtnBehaviours[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
        GetComponentInChildren<Animator>().SetBool("isAttack", true);
        //warning.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
        GetComponentInChildren<Animator>().SetBool("isAttack", false);
    }
}