using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    int jumpForce = 500;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        if (vertical != 0 || horizontal != 0)
        {
            transform.Translate(new Vector3(horizontal, 0, vertical) * Time.deltaTime * 2f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Force);
        }
    }
}
