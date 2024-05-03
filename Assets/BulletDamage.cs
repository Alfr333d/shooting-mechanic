using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        EnemyHealth Hp = collision.gameObject.GetComponent<EnemyHealth>();

        if (Hp != null)
        {
            Hp.Hurt(10);
        }
        Destroy(gameObject);
    }
}
