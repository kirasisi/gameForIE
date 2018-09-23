using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active : MonoBehaviour {
    public GameObject tree;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            Vector2 tree1 = new Vector2(-0.19f, 2.15f);

            if (touch.phase == TouchPhase.Began)
            {
                Instantiate(tree, tree1, Quaternion.identity);
            }



        }
    }
}
