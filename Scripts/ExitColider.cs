using UnityEngine;

public class ExitColider : MonoBehaviour
{
    public RestartLevel RL;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("����");
        if(collision.gameObject.tag == "Player")
        {

            RL.Restart();
        }
    }

}
