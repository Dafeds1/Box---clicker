using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        MovementObstacle();   
    }

    public void MovementObstacle()
    {
        transform.position += Vector3.right * Time.deltaTime *2;
        transform.rotation *= Quaternion.Euler(0f,0f,0.5f);
    }
}
