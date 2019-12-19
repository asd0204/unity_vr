using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool havekey;

    public void ThrowPickUP(GameObject obj)
    {
        print("撿起物件");
        havekey = true;
        Destroy(obj);
    }
    public void ThrowDetach()
    {
        print("放開物件");
    }
    public void ThrowHeld()
    {
        print("拿著物件");
    }
}
