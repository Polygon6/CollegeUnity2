using UnityEngine;

public class jumpScript : MonoBehaviour
{
    private float force = 4000;
    private int speed = 12;
    private int push = 6;
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
            s.AddForce(Vector3.up * force * Time.deltaTime);
            print(Vector3.up * force * Time.deltaTime);
            print(Vector3.up);
            print(force);
            print(Time.deltaTime);
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

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position += Vector3.down * Time.deltaTime * push;
    }
}
