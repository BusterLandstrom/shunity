using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayScript : MonoBehaviour
{

    public void playScene()
    {
        SceneManager.LoadScene(1);
    }
}
