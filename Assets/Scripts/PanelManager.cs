using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject PanelEvents, PanelProfile, PanelReg, PanelBegin;
    // Start is called before the first frame update
    void Start()
    {
        PanelBegin.SetActive(true);
        PanelProfile.SetActive(false);
        PanelReg.SetActive(false); 
        PanelEvents.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BeginOnClick()
    {
        PanelBegin.SetActive(true);
        PanelProfile.SetActive(false);
        PanelReg.SetActive(false);
        PanelEvents.SetActive(false);
    }

    public void RegOnClick()
    {
        PanelBegin.SetActive(false);
        PanelProfile.SetActive(false);
        PanelReg.SetActive(true);
        PanelEvents.SetActive(false);
    }

    public void EventOnClick()
    {
        PanelBegin.SetActive(false);
        PanelProfile.SetActive(false);
        PanelReg.SetActive(false);
        PanelEvents.SetActive(true);
    }

    public void ProfileOnClick()
    {
        PanelBegin.SetActive(false);
        PanelProfile.SetActive(true);
        PanelReg.SetActive(false);
        PanelEvents.SetActive(false);
    }
}
