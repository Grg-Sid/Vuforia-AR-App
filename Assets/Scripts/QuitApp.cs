using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApp : MonoBehaviour
{
    public void ExitApp()
    {
        Debug.Log("has quit the app!!!");
        Application.Quit();
    }
}
