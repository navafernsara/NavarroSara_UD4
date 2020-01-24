using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] UnityEngine.AI.NavMeshAgent agent;
    [SerializeField] float updateDelay = .3f;

    private void Reset()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Start()
    {
        InvokeRepeating("FollowTarget", 0f, updateDelay);
    }

    // Start is called before the first frame update    
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
