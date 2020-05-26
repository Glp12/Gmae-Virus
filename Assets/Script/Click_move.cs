using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Click_move : MonoBehaviour {
    public float runSpeed = 3f;
    public Rigidbody2D rb;
    public float jumpForce= 5f;
    public Transform Crtr;
    public float Crr;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    bool IsGround()
    {
        Collider2D[] gh= Physics2D.OverlapCircleAll(Crtr.position,Crr);
        int j = 0;
        for(int i = 0; i < gh.Length; i++)
        {
            if (gh[i].gameObject != gameObject)
            {
                j++;
            }
        }
        return j > 0;
    }
    public void Jump()
    {
        if(IsGround())
            rb.AddForce(transform.up*jumpForce, ForceMode2D.Impulse);
    }
    public void Move(float ax)
    {
        Vector3 direction = transform.right * ax;
        transform.position = Vector3.Lerp(transform.position, transform.position + direction, runSpeed * Time.deltaTime);
        if ((ax > 0 && transform.localScale.x < 0) || (ax < 0 && transform.localScale.x > 0)){
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }
}
