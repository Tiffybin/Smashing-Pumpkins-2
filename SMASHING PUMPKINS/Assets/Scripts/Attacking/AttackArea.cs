using UnityEngine;

public class AttackArea : MonoBehaviour
{

    private int damage = 3;

    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Health>() != null)
        {
            Health h = collider.GetComponent<Health>();
            h.Damage(damage);
        }
    }
   
}
