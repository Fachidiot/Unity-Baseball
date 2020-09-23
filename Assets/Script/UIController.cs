using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Baseballmanager Manager;
    public Text First;
    public Text Second;
    public Text Third;

    private List<int> m_List = new List<int>();
    private int m_iCount = 0;

    public void reset()
    {
        for (int i = 0; i < 3; i++)
        {
            m_List.RemoveAt(0);
        }

        First.text = 0.ToString();
        Second.text = 0.ToString();
        Third.text = 0.ToString();
        m_iCount = 0;
    }

    public void GetNumber(int _1)
    {
        m_List.Add(_1);
        ShowNum();
    }

    public void ShowNum()
    {
        switch (m_List.Count)
        {
            case 1:
                First.text = m_List[0].ToString();
                break;
            case 2:
                Second.text = m_List[1].ToString();
                break;
            case 3:
                Third.text = m_List[2].ToString();
                break;
        }
    }

    public void Sort()
    {
        m_List.Sort();
        First.text = m_List[0].ToString();
        Second.text = m_List[1].ToString();
        Third.text = m_List[2].ToString();
    }

    public void DeleteNumber(int _1)
    {
        m_List.Remove(_1);
        switch(m_List.Count)
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
        m_iCount++;
    }

    public void DisCount()
    {
        m_iCount--;
    }

    public bool ButtonManage()
    {
        if (m_iCount >= 3)
            return false;

        else
            return true;
    }

    public void SendNum()
    {
        Manager.PlayerInput(m_List[0]);
        Manager.PlayerInput(m_List[1]);
        Manager.PlayerInput(m_List[2]);
    }
}
