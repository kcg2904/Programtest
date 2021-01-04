using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class End : MonoBehaviour
{
    public int c;
    Text t;
    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        c = GameObject.Find("DD").GetComponent<Timer>().c;
        a = GameObject.Find("DD").GetComponent<Timer>().ao;
        t = GameObject.Find("Result").GetComponent<Text>();
        Destroy(GameObject.Find("DD"));
    }

    // Update is called once per frame
    void Update()
    {
        if (c == 0)
        {
            t.text = "게임 오버";
        }
        else if (c == 1)
        {
            t.text = "스테이지 클리어";
        }
    }
    public void MainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
