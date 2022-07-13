using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour
{

    public NavMeshAgent agent;
    public GameObject target;
    public Transform BulletPoint;
    public GameObject Bullet;
    public float BulletSpeed;
    [SerializeField] Transform targetPos;
    [SerializeField] float PlayerRange=10f;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        BulletSpeed = 10;
        
       
    }
 

    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(targetPos.position, transform.position);

        if (distance > PlayerRange)


            agent.SetDestination(targetPos.position);

        else if (distance < PlayerRange)

            BulletSpawner();


       


    }

    void BulletSpawner()
    {

        var bullet = Instantiate(Bullet, BulletPoint.position, BulletPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = BulletPoint.forward * BulletSpeed;
        

    }

    
}
