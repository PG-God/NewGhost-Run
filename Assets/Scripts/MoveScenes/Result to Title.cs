using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResulttoTitle : MonoBehaviour
{
    public void ReturnTitle()
    {
        SceneManager.LoadScene("titleScenes");
    }
}
