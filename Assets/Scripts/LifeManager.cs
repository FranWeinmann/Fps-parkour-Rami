using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{

    public float life;

    public void UpdateLife(float damage)
    {
        if (life - damage < 1)
        {
            SceneManager.LoadScene("Fps");
        }
    }
}