using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartScene(){
        print("Now RESTARTING...");
        SceneManager.LoadScene("SampleScene");
    }
}
