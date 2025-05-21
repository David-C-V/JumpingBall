using UnityEngine;

public class GoalContoller : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameManager.singleton.NextLevel();

    }
}
