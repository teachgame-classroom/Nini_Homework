using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloTest : MonoBehaviour
{
    public int myInt = 255;

    private string myStr;

    public Vector3 myVec;

    private int[] myArray = new int[100];


    public Color trackColor = Color.red;
    private List<Vector3> tracks = new List<Vector3>();

    private GameObject test;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
           // Sum1to100();
            Debug.Log("");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = trackColor;

        Gizmos.DrawSphere(transform.position,0.5f);

        Gizmos.color = Color.yellow;
       // Gizmos.DrawLine(transform.position +(test.transform.position));



    }

    //private int Sum1to100()
    //{

    //}
}
