using UnityEngine;

public class TeleportInteratble : MonoBehaviour {

    public Animator AnimatorControl;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name== "HeadCollider"&&GameManager.havekey)
        {
            AnimatorControl.SetBool("character_nearby", true);
        }
    }
}
