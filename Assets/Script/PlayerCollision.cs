using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   public PlayerMovement movement;
   
    void OnCollisionEnter(Collision CollisionInfo) 
    {
       if (CollisionInfo.collider.tag == "obstacle")
       {
          movement.enabled = false ;         
          FindObjectOfType<GameManager>().EndGame();
       }
   }
}
