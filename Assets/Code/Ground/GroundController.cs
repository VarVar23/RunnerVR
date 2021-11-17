using UnityEngine;

public class GroundController 
{
    private GroundView[] _groundView;
    private GroundSO _groundSO;

    private MoveGround[] _moveGround;
    private PullGround[] _pullGrounds;

    public GroundController(GroundView[] groundView, GroundSO groundSO)
    {
        _groundView = groundView;
        _groundSO = groundSO;


        _moveGround = new MoveGround[_groundView.Length + 1];
        _pullGrounds = new PullGround[_groundView.Length + 1];

        for (int i = 0; i < _groundView.Length; i++)
        {
            _moveGround[i] = new MoveGround(_groundView[i].GroundTransform, _groundSO.Speed);
            _pullGrounds[i] = new PullGround(_groundView[i].GroundTransform, _groundSO.MaxDistantion);
        }
    }

    public void Update()
    {
        for (int i = 0; i < _groundView.Length; i++)
        {
            _moveGround[i].Update();
        }
    }

    public void FixedUpdate()
    {
        for (int i = 0; i < _groundView.Length; i++)
        {
            if (i == 0)
            {
                _pullGrounds[i].FixedUpdate(_groundView[_groundView.Length - 1].GroundTransform);
            }
            else
            {
                _pullGrounds[i].FixedUpdate(_groundView[i - 1].GroundTransform);
            }
        }
    }
}
