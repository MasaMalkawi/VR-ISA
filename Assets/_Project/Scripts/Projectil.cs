using UnityEngine;

public class Projectil : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (rb != null)
        {
            rb.linearVelocity = transform.forward * speed * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
