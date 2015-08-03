using UnityEngine;
using System.Collections;

public class PlayerHandler : MonoBehaviour 
{

    GameObject Player;
    NavMeshAgent agent;

    public void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        agent = Player.GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        Camera cam = Camera.main;

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                Vector3 pos = hit.point;
                pos.x = Mathf.FloorToInt(pos.x) + 0.5f;
                pos.y = Mathf.FloorToInt(pos.y) - 0.5f;
                pos.z = Mathf.FloorToInt(pos.z) + 0.5f;
                agent.SetDestination(pos);

                
            }

        }
    }

}
