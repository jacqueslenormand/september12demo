using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    public CubeController right;
    public CubeController middle;
    enum Position  {left, middle, right };
    Position loc = Position.right;
	// Use this for initialization
	void Start () {
	
	}



    // Update is called once per frame
    void Update () {
        Vector3 pos = gameObject.transform.position;
        pos.z = pos.z + 0.1f;
        gameObject.transform.position = pos;

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(loc == Position.right)
            {
                loc = Position.middle;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (loc == Position.middle)
            {
                loc = Position.right;
            }
        }



        if (loc != Position.right)
        {
            right.disable();
        }
        if (loc != Position.middle)
        {
            middle.disable();
        }

     
        if (loc == Position.right)
        {
            right.enable();
        }
        if (loc == Position.middle)
        {
            middle.enable();
        }

    }
}
