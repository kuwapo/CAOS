using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Presenter : MonoBehaviour
{
    static int a = 1;
    
    public AudioClip sound01;
    AudioSource audioSource;
    string S = "scene";
    void SC()
    { SceneManager.LoadScene(S); }
    

   

    public void OnClickButton()
    {
        audioSource.PlayOneShot(sound01);
        
        
        
        
        
        
        if (a ==1)
        {
            Debug.Log("ボタン押下1");
            S = "Loading";
            a++;
            Invoke("SC", 0.08f);
            //GetComponent<Button>().interactable = false;

        }
        else if(a==2)
        {
            Debug.Log("ボタン押下2");
            S = "konton";
            a++;
            Invoke("SC", 0.08f);
            
        }
        else if (a == 3)
        {
            Debug.Log("ボタン押下3");
            S = "miku01";
            
            Invoke("SC", 0.08f);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
