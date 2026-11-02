using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform ShotPos;
    public GameObject Bullet;
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(Bullet, ShotPos.transform.position, transform.rotation);
        }
    }
}