using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public Vector2 a;

    public GameObject b;
    public GameObject c;

    public bool cc;
    // Start is called before the first frame update
    void Start()
    {
        b = GameObject.Find(this.gameObject.name);
        c = GameObject.Find("Sphere");
        
    }
    

    // Update is called once per frame
    void Update()
    {
        cc = c.GetComponent<Cphere>().go;
        if (cc == false)
        {
            if (Input.GetMouseButton(0))
            {
                this.gameObject.GetComponent<BoxCollider>().isTrigger = false;
                a = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                b.transform.position = a;
            }
            if (Input.GetMouseButton(0) == false)
            {

                this.gameObject.GetComponent<BoxCollider>().isTrigger = true;
            }
        }
        else if (cc == true)
        {
            this.gameObject.GetComponent<BoxCollider>().isTrigger = true;
        }

    }

}

