using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Cphere : MonoBehaviour
{
    GameObject a;
    GameObject b;

    public int cc;
    bool ac = true;
    public bool go = false;
    bool t = false;
    Text text;
    float timer = 30;
    

    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.Find(this.gameObject.name);
        b = GameObject.Find("Cube");
        text = GameObject.Find("Text").GetComponent<Text>();
        text.text = timer.ToString();

    }

    // Update is called once per frame
    void Update()
    {
       
        if ((Mathf.Abs(a.GetComponent<Transform>().rotation.z)) >= 0.5f)
        {
            this.gameObject.GetComponent<HingeJoint>().breakForce = 1;
            print("게임오버");
            t = false;
            go = true;
        }
        if (t == true)
        {
            timer -= Time.deltaTime;
            text.text = ((int)timer).ToString();
        }
        if((int)timer <= 0)
        {
            go = true;  
        }
        if (go) { 
            if ((int)timer > 0)
            {
             cc = 0;
            }else if ((int)timer <= 0)
            {
                cc = 1;
            }
        }
    }
    
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "Cube")
        {
            t = true;

            if (ac == true) { 
            this.gameObject.AddComponent<HingeJoint>();
                ac = false;
            }
            this.gameObject.GetComponent<HingeJoint>().connectedBody = b.GetComponent<Rigidbody>();
            b.GetComponent<Rigidbody>().isKinematic = false;
            a.GetComponent<HingeJoint>().anchor = Vector3.down;
            //a.transform.SetParent(b.transform);


        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Over")
        {
            go = true;
        }
    }


}
