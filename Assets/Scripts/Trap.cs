using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public int jump;
    List<IForcingJump> things = new List<IForcingJump>();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ForcingJump", 0, 0.1f);
    }

    void ForcingJump()
    {
        for (int i = 0; i < things.Count; i++)
        {
            things[i].ForcingJump(jump);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IForcingJump jump))
        {
            things.Add(jump);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out IForcingJump jump))
        {
            things.Remove(jump);
        }
    }
}
