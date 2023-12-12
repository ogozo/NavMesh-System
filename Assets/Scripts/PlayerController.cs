using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    Camera cam;
    public NavMeshAgent agent;

    private void Start()
    {
        cam = FindObjectOfType<Camera>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}