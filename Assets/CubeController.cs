using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CubeController : MonoBehaviour {
    
    public void disable()
    {
        gameObject.SetActive(false);
    }

    public void enable()
    {
        gameObject.SetActive(true);
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * 300);
            rb.useGravity = true;
        }
        if(gameObject.transform.position.y < 0)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = false;
            rb.velocity = Vector3.zero;

            Vector3 pos = gameObject.transform.position;
            pos.y = 0;
            gameObject.transform.position = pos;

        }
	}

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
