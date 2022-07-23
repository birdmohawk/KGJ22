using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour
{

    //The box's current health point total
    public Rigidbody2D rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.left * 125);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            Destroy(gameObject);
    }
}