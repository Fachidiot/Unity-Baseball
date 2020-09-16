using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private Baseballmanager Manager = new Baseballmanager();
    [SerializeField]
    Text First = null;
    [SerializeField]
    Text Second = null;
    [SerializeField]
    Text Third = null;

    List<int> list = new List<int>();

    int count = 0;

    public void reset()
    {
        for (int i = 0; i < 3; i++)
        {
            list.RemoveAt(0);
        }

        First.text = 0.ToString();
        Second.text = 0.ToString();
        Third.text = 0.ToString();
        count = 0;
    }

    public void GetNumber(int _1)
    {
        list.Add(_1);
        ShowNum();
    }

    public void ShowNum()
    {
        switch (list.Count)
        {
            case 1:
                First.text = list[0].ToString();
                break;
            case 2:
                Second.text = list[1].ToString();
                break;
            case 3:
                Third.text = list[2].ToString();
                break;
        }
    }

    public void Sort()
    {
        list.Sort();
        First.text = list[0].ToString();
        Second.text = list[1].ToString();
        Third.text = list[2].ToString();
    }

    public void DeleteNumber(int _1)
    {
        list.Remove(_1);
        switch(list.Count)
        {
            case 0:
                First.text = 0.ToString();
                break;
            case 1:
                Second.text = 0.ToString();
                break;
            case 2:
                Third.text = 0.ToString();
                break;
        }
    }

    public void ClickCount()
    {
        count++;
    }

    public void DisCount()
    {
        count--;
    }

    public bool ButtonManage()
    {
        if (count >= 3)
            return false;

        else
            return true;
    }

    public void SendNum()
    {
        Manager.PlayerInput(list[0]);
        Manager.PlayerInput(list[1]);
        Manager.PlayerInput(list[2]);
    }
}
