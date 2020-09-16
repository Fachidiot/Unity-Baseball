using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIController : MonoBehaviour
{
    [SerializeField]
    Text First = null;
    [SerializeField]
    Text Second = null;
    [SerializeField]
    Text Third = null;

    List<int> list = new List<int>();

    public void reset()
    {
        for (int i = 0; i < 3; i++)
        {
            list.RemoveAt(0);
        }

        First.text = 0.ToString();
        Second.text = 0.ToString();
        Third.text = 0.ToString();
    }

    public void ManageAI()
    {
        if (list.Count <= 3)
        {
            First.text = list[0].ToString();
            Second.text = list[1].ToString();
            Third.text = list[2].ToString();
        }
    }

    public void GetAINum(List<int> _list)
    {
        for (int i = 0; i < _list.Count; i++)
        {
            list.Add(_list[i]);
        }
    }
}
