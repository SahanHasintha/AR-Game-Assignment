using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTree : MonoBehaviour
{
    public GameObject Tree01;
    public GameObject Tree02;
    public GameObject Tree03;
    public GameObject Tree04;
    private ARCursor arCursor;
    [HideInInspector]
    public GameObject xxx;
    public GameObject cs;
    public GameObject btn;

    void Start()
    {
        MenuButtonClose();
    }

    public void MenuButtonClose()
    {
        btn.SetActive(false);
    }

    public void MenuButtonOpen()
    {
        btn.SetActive(true);
    }

    public void Tree01ButtonClick()
    {
        cs.SetActive(false);
        xxx = Tree01;
    }
    public void Tree02ButtonClick()
    {
        cs.SetActive(false);
        xxx = Tree02;
    }
    public void Tree03ButtonClick()
    {
        cs.SetActive(false);
        xxx = Tree03;
    }
    public void Tree04ButtonClick()
    {
        cs.SetActive(false);
        xxx = Tree04;
    }

    public void OpenMenu()
    {
        cs.SetActive(true);
    }
}
