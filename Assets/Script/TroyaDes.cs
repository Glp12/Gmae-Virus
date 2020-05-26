using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroyaDes : MonoBehaviour {
    public GameObject D;
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Emo")
        {
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
