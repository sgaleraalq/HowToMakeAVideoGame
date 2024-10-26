using System.Numerics;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public UnityEngine.Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
