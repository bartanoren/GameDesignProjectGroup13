using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class ButtonFunction : MonoBehaviour
{
    public void NormalButton() {
        MMSceneLoadingManager.LoadScene("Hospital", "LoadingScreen");
    }
    public void HardButton() {
        MMSceneLoadingManager.LoadScene("Hospital_hard", "LoadingScreen");
    }
    public void quitbutton() {
        Application.Quit();
        Debug.Log("Quit");
    }
}
