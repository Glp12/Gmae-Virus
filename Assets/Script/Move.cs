using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Click_move))]
public class Move : MonoBehaviour {
    private Click_move pc;
    void Start () {
        pc = GetComponent<Click_move>();
	}
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            pc.Jump();
        }
        pc.Move(Input.GetAxis("Horizontal"));
	}
}
