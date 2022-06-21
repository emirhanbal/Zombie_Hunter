using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopButtonWork : MonoBehaviour
{
    public bool isStop = false;
    public void stoptheGame()
    {
        if(isStop == false)
        {
            Time.timeScale = 0f;
            isStop = true;
        }
        else
        {
            Time.timeScale = 1f;
            isStop = false;
        }
    }
}
