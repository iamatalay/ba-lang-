using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int moveSpeed;
    [SerializeField] private int jumpForce;
    [SerializeField] private float radius;
    [SerializeField] private Transform feetPos;
    [SerializeField] LayerMask LayerMask;

    [SerializeField] private float gravityScale;
    [SerializeField] private float fallGravityScale;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizantalMove = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(horizantalMove * moveSpeed, rb.linearVelocityY);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {

            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        { 
            if (rb.linearVelocityY >= 0)
            {
                rb.gravityScale = gravityScale;
            }
            else if (rb.linearVelocityY <= 0)
            {
                rb.gravityScale = fallGravityScale;
            }
        }

    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(feetPos.position, radius, LayerMask);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(feetPos.position, radius);

    }

    


}
