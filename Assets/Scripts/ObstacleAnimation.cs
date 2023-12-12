using UnityEngine;

public class ObstacleAnimation : MonoBehaviour
{

    public float speed = .2f;
    public float strength = 9f;

    private float randomOffset;

    // Use this for initialization
    void Start()
    {
        randomOffset = Random.Range(-.5f, .5f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Sin(Time.time * speed + randomOffset) * strength;
        transform.position = pos;
    }
}