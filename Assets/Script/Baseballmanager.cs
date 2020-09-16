using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baseballmanager : MonoBehaviour
{
    public UIController m_Player = null;
    public AIController m_Random = null;
    public EffectController Effect = null;
    [SerializeField]
    private ResetButton resetbutton;
    private static List<int> PlayerList = new List<int>();
    private static List<int> RandomList = new List<int>();

    int count = 0;
    bool outofresult = false;

    public void PlayerInput(int _1)
    {
        if (count >= 3)
            return;

        else
        {
            PlayerList.Add(_1);
            count++;

            if (count >= 3)
            {
                PlayerList.Sort();
                m_Player.Sort();
            }
        }
    }

    void DoRandom()
    {
        for (int i = 0; i < 3; ++i)
        {
            int temp = Random.Range(1, 9);
            for (int j = 0; j < RandomList.Count; j++)
            {
                if (temp == RandomList[j])
                {
                    --i;
                    continue;
                }
            }

            if(RandomList.Count == i)
                RandomList.Add(temp);

            continue;
        }

        RandomList.Sort();

        m_Random.GetAINum(RandomList);

        m_Random.ManageAI();
    }

    void Compare(List<int> _1, List<int> _2)
    {
        if (_1.Count < 1 || _2.Count < 1)
        {
            Debug.Log("값을 입력받지 못했거나 AI 오류입니다.");
            return;
        }

        int same = 0;
        int locationsame = 0;

        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                if (PlayerList[i] == RandomList[j])
                {
                    if (PlayerList[i] == RandomList[i])
                    {
                        locationsame++;
                        break;
                    }

                    else
                    {
                        same++;
                        break;
                    }
                }
            }
        }

        switch (locationsame)
        {
        case 3:
            // 홈런
            Effect.HomeRun();
            Debug.Log("홈런");
            break;
        case 2:
            switch (same)
            {
                case 1:
                    // 2루타
                    Effect.SecondHit();
                    Debug.Log("2루타");
                    break;
                default:
                    // 안타
                    Effect.Hit();
                    Debug.Log("안타");
                    break;
            }
            break;
        case 1:
            switch (same)
            {
                case 2:
                    // 안타
                    Effect.Hit();
                    Debug.Log("안타");
                    break;
                case 1:
                    // 스트라이크
                    Effect.Strike();
                    Debug.Log("스트라이크");
                    break;
                default:
                    // 스트라이크
                    Effect.Strike();
                    Debug.Log("스트라이크");
                    break;
            }
            break;
        default:
            switch (same)
            {
                case 3:
                    // 볼
                    Effect.Ball();
                    Debug.Log("볼");
                    break;
                case 2:
                    // 스트라이크
                    Effect.Strike();
                    Debug.Log("스트라이크");
                    break;
                case 1:
                    // 스트라이크
                    Effect.Strike();
                    Debug.Log("스트라이크");
                    break;
                default:
                    // 아웃
                    Effect.Out();
                    Debug.Log("아웃");
                    break;
            }
            break;
        }
    }

    public void reset()
    {
        for (int i = 0; i < 3; i++)
        {
            PlayerList.RemoveAt(0);
        }
        for (int i = 0; i < 3; i++)
        {
            RandomList.RemoveAt(0);
        }

        count = 0;
        m_Random.reset();
        m_Player.reset();
        Effect.reset();
        outofresult = false;
    }

    void CheckIn()
    {
        if (outofresult)
            return;

        if (PlayerList.Count == 3)
        {
            DoRandom();
            Compare(PlayerList, RandomList);
            resetbutton.Active();
            outofresult = true;
        }
    }
    
    void Update()
    {
        CheckIn();
    }
}
