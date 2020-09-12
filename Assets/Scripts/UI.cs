using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject db;
    public string scenename;

    public void exit()
    {
        Application.Quit();
    }
    public void menu_enable()
    {
        db.SetActive(true);
    }
    public void menu_disable()
    {
        db.SetActive(false);
    }
    
    public void open_scene()
    {
        Application.LoadLevel(scenename);
    }
}
