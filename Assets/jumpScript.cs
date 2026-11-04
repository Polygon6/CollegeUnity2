using UnityEngine;

public class jumpScript : MonoBehaviour
{
    private float force = 0.4f;
    private int speed = 12;
    private Rigidbody s;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        s = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            s.AddForce(Vector3.up * force);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
    }
}
