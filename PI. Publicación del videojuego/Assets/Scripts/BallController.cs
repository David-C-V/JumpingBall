using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb;
    public float impulsoForce = 3f;

    private bool ignoreNextcollision;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {

       
        if (ignoreNextcollision)
        {
            return;
        }

        DeathPart deathPart = collision.transform.GetComponent<DeathPart>();
        if (deathPart)
        {
            GameManager.singleton.Restartlevel();
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


    public void ResetBall()
    {
        transform.position = startPosition;
    }    

}
