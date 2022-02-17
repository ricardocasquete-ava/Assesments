using App.AbstractFactory.Parts;

namespace App.AbstractFactory.Manufacturers;

public class AssembledCar: ICar
{
    private readonly IBody _body;
    private readonly IEngine _engine;
    private readonly ISeat _seat;
    private readonly IAddon[] _addons;

    public AssembledCar(IBody body, IEngine engine, ISeat seat, params IAddon[] addons)
    {
        _body = body;
        _engine = engine;
        _seat = seat;
        _addons = addons;
    }

    public string Body => _body.BodyType;
    public string Engine => _engine.EngineType;
    public string Seat => _seat.UpholsteryType;
    public string[] Addons => _addons.Select(a => a.Value).ToArray();
}