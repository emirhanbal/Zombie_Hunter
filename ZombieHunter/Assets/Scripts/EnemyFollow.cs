using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : MonoBehaviour
{   

    private GameObject enemy;
    private int enemyHeal = 3;
    private int enemyPoint = 1;
    private float distance;
    private GameControl gControl;
    void Start()
    {
        enemy = GameObject.Find("mainCharacter");
        gControl = GameObject.Find("_scripts").GetComponent<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = enemy.transform.position;
        distance = Vector3.Distance(transform.position, enemy.transform.position);
        {
            if (distance < 10f)
            {
                GetComponentInChildren<Animation>().Play("Zombie_Attack_01");
            }
        }
        
    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.gameObject.tag.Equals("bullet"))
        {
            Debug.Log("carpisma gerceklesti");
            enemyHeal --;
            if (enemyHeal == 0)
            {
                GetComponentInChildren<Animation>().Play("Zombie_Death_01");
                Destroy(this.gameObject, 1.667f);
                gControl.scoreLevel(enemyPoint);
            }
        }
    }
}
