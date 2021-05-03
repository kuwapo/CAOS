using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    static int c = 0;
    public static float timer;
    //public static TimeText.text;

    public Text TimeText;
    public bool DontDestroyEnabled = true;

    // Start is called before the first frame update
    void Start()
    {
        TimeText = GetComponent<Text>();
        timer = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (c <= 0)
        {
            timer += Time.deltaTime;
            TimeText.text = "TIME:" + timer.ToString("f2"); ;
        }

    }
    public void Count() { c++; }
    //public void ClearTime() { "TIME:" + timer.ToString("f2"); }

    public static float getTimer() { return timer; }
}
