using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb;
    public float impulsoForce = 3f;

    private bool ignoreNextcollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (ignoreNextcollision)
        {
            return;
        }

        rb.angularVelocity = Vector3.zero;
        rb.AddForce(Vector3.up * impulsoForce, ForceMode.Impulse);

        ignoreNextcollision = true;
        Invoke("AllowNextCollision", 0.2f);
    }

    private void AllowNextCollision()
    {
        ignoreNextcollision = false;
    }


}
