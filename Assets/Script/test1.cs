using UnityEngine;
using System.Collections;

public class test1 : MonoBehaviour {

   public int floatSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(Vector3.up * floatSpeed);
            Debug.Log("floatSpeed");
        }
	
	}
}
