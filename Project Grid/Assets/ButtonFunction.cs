using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class ButtonFunction : MonoBehaviour
{
    public void playbutton() {
        MMSceneLoadingManager.LoadScene("Hospital", "LoadingScreen");
    }
    public void quitbutton() {
        Application.Quit();
        Debug.Log("Quit");
    }
}
