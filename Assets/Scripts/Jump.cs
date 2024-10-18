using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rigit2D;
    public float jumpForce = 680.0f;
    private bool isGrounded = false;
    
    void Start()
    {
       rigit2D = GetComponent<Rigidbody2D>();
    }

    public void JumpFunction()
    {
        if (isGrounded)
        {
            rigit2D.AddForce(transform.up * jumpForce);
            isGrounded = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

}
