using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectController : MonoBehaviour
{
    [SerializeField]
    private Image image = null;
    [SerializeField]
    public Sprite m_homerun = null;
    [SerializeField]
    public Sprite m_out = null;
    [SerializeField]
    public Sprite m_hit = null;
    [SerializeField]
    public Sprite m_secondhit = null;
    [SerializeField]
    public Sprite m_four = null;
    [SerializeField]
    public Sprite m_strike = null;
    [SerializeField]
    public Sprite m_ball = null;

    private void Start()
    {
        gameObject.active = false;
    }

    public void reset()
    {
        gameObject.active = false;
    }

    public void HomeRun()
    {
        gameObject.active = true;
        image.sprite = m_homerun;
    }

    public void Out()
    {
        gameObject.active = true;
        image.sprite = m_out;
    }

    public void Hit()
    {
        gameObject.active = true;
        image.sprite = m_hit;
    }

    public void SecondHit()
    {
        gameObject.active = true;
        image.sprite = m_secondhit;
    }

    public void Four()
    {
        gameObject.active = true;
        image.sprite = m_four;
    }

    public void Strike()
    {
        gameObject.active = true;
        image.sprite = m_strike;
    }

    public void Ball()
    {
        gameObject.active = true;
        image.sprite = m_ball;
    }
}
