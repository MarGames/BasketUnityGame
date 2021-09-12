using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CNTRL : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject goal1;
    public GameObject goal2;
    bool check = false;
    //public Text scoretxt;
    public int score = 0;
    void Start()
    {
        //scoretxt.GetComponent<Text>().text = "" + score;
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (check) transform.position = Vector3.MoveTowards(transform.position, goal1.transform.position, 2f * Time.deltaTime);
        if (!check) transform.position = Vector3.MoveTowards(transform.position, goal2.transform.position, 2f * Time.deltaTime);
        
    }
    public void Jump()
    {
        rb.AddForce(0, 20000f, 0, ForceMode.Force);
        check = !check;
    }
}
