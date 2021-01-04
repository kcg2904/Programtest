using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    GameObject a;
    public bool ao;
    public int c;
    int dt = 2;
    float t = 0f;
    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void EndScene()
    {
        DontDestroyOnLoad(GameObject.Find("DD"));
       
        SceneManager.LoadScene("EndScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.Find("Sphere");    
    }
 
    // Update is called once per frame
    void Update()
    {
        ao  = a.GetComponent<Cphere>().go;
        if (ao)
        {
            c = a.GetComponent<Cphere>().cc;
            t += Time.deltaTime;
            if (dt < t) { 
                EndScene();
            }
        }

    }
}
