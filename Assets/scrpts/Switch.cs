using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Switch : MonoBehaviour
{
    public int numbScene;
    public void Transition()
    {
        SceneManager.LoadScene(numbScene);
    }
}
