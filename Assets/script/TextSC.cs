using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextSC : MonoBehaviour
{
    
    //string T = "text";

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(TEX());
         
        
    }

    IEnumerator TEX()
    {
        for (int t = 0; t < 1; t++)
        {
            Text pText = GetComponent<Text>();
            Debug.Log("小ルーチン"+t)  ;
            yield return new WaitForSeconds(0.3f);
            pText.text = "こんばんは、初音ミクです";
            yield return new WaitForSeconds(1.3f);
            pText.text = "いやぁ〜今宵は混沌としておりますなぁ";
            yield return new WaitForSeconds(1.3f);
            pText.text = "そんな時にぴったりの新曲歌います";
            yield return new WaitForSeconds(1.3f);
            pText.text = "CAOS（混沌）";
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene("ika 1");
            yield return new WaitForSeconds(0.5f);
            pText.text = "こんとん　こんとん";
            yield return new WaitForSeconds(1.3f);
            pText.text = "こんとん";
            yield return new WaitForSeconds(1.3f);
        };
        yield return null;

    }

    }

