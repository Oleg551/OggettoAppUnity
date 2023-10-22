using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject PanelCl, PanelNotice, PanelLent, PanelMessage, PanelProfile, PanelReg, PanelBegin;
    // Start is called before the first frame update
    void Awake()
    {
        PanelBegin.SetActive(true);
        PanelProfile.SetActive(false);
        PanelReg.SetActive(false); 
        PanelCl.SetActive(false);
        PanelNotice.SetActive(false);
        PanelLent.SetActive(false);
        PanelMessage.SetActive(false);
    }

    public void BeginOnClick()
    {
        PanelBegin.SetActive(true);
        PanelProfile.SetActive(false);
        PanelReg.SetActive(false);
        PanelCl.SetActive(false);
        PanelNotice.SetActive(false);
        PanelLent.SetActive(false);
        PanelMessage.SetActive(false);
    }

    public void RegOnClick()
    {
        PanelBegin.SetActive(false);
        PanelProfile.SetActive(false);
        PanelReg.SetActive(true);
        PanelCl.SetActive(false);
        PanelNotice.SetActive(false);
        PanelLent.SetActive(false);
        PanelMessage.SetActive(false);
    }

    public void ProfileOnClick()
    {
        PanelBegin.SetActive(false);
        PanelProfile.SetActive(true);
        PanelReg.SetActive(false);
        PanelCl.SetActive(false);
        PanelNotice.SetActive(false);
        PanelLent.SetActive(false);
        PanelMessage.SetActive(false);
    }

    public void ClOnClick()
    {
        PanelBegin.SetActive(false);
        PanelProfile.SetActive(false);
        PanelReg.SetActive(false);
        PanelCl.SetActive(true);
        PanelNotice.SetActive(false);
        PanelLent.SetActive(false);
        PanelMessage.SetActive(false);
    }

    public void NoticeOnClick()
    {
        PanelBegin.SetActive(false);
        PanelProfile.SetActive(false);
        PanelReg.SetActive(false);
        PanelCl.SetActive(false);
        PanelNotice.SetActive(true);
        PanelLent.SetActive(false);
        PanelMessage.SetActive(false);
    }

    public void LentOnClick()
    {
        PanelBegin.SetActive(false);
        PanelProfile.SetActive(false);
        PanelReg.SetActive(false);
        PanelCl.SetActive(false);
        PanelNotice.SetActive(false);
        PanelLent.SetActive(true);
        PanelMessage.SetActive(false);
    }

    public void MessageOnClick()
    {
        PanelBegin.SetActive(false);
        PanelProfile.SetActive(false);
        PanelReg.SetActive(false);
        PanelCl.SetActive(false);
        PanelNotice.SetActive(false);
        PanelLent.SetActive(false);
        PanelMessage.SetActive(true);
    }
}
