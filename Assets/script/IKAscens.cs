using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IKAscens : MonoBehaviour
{
    public GameObject ikaout;

    // Start is called before the first frame update
    void Start()
    {
        Text pText = GetComponent<Text>();
        StartCoroutine(TEX());

    }

    IEnumerator TEX()
    {
        for (int t = 0; t < 1; t++)
        {
            Text pText = GetComponent<Text>();
            Debug.Log("小ルーチン" + t);
            yield return new WaitForSeconds(0.3f);
            pText.text = "こんとん　こんとん";
            yield return new WaitForSeconds(1.3f);
            pText.text = "こんとん";
            yield return new WaitForSeconds(0.8f);
            pText.text = "こんこん";
            yield return new WaitForSeconds(0.5f);
            Instantiate(ikaout, transform.position, transform.rotation);
            pText.text = "こんとん　こんとん";
            yield return new WaitForSeconds(1.3f);
            pText.text = "こんとん";
            yield return new WaitForSeconds(0.8f);
            pText.text = "とんとん";
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene("cat");
        };
        yield return null;

    }

}

