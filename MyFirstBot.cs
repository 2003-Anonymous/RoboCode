using System;
using System.Collections.Generic;
using Robocode.TankRoyale.BotApi;
using Robocode.TankRoyale.BotApi.Events;

public class MyFirstBot : Bot
{
    static void Main(string[] args) => new MyFirstBot().Start();

    int moveDirection = 1;

    public MyFirstBot() : base(new BotInfo(
        "MyFirstBot", "1.0",
        new List<string> { "Joshua" },
        "My first bot", null,
        new List<string> { "ch" },
        new HashSet<string> { "classic" },
        ".Net 8", "C# 8", null
    )) { }

    public override void Run()
    {
        AdjustGunForBodyTurn = true;
        AdjustRadarForBodyTurn = true;
        AdjustRadarForGunTurn = true;

        while (IsRunning)
            TurnRadarRight(360);
    }

    public override void OnScannedBot(ScannedBotEvent evt)
    {
        double distance = DistanceTo(evt.X, evt.Y);
        double firePower = Math.Clamp(400.0 / distance, 1.0, 3.0);
        double travelTime = distance / CalcBulletSpeed(firePower);

        double predictedX = Math.Clamp(
            evt.X + Math.Sin(evt.Direction * Math.PI / 180) * evt.Speed * travelTime,
            18, ArenaWidth - 18);
        double predictedY = Math.Clamp(
            evt.Y + Math.Cos(evt.Direction * Math.PI / 180) * evt.Speed * travelTime,
            18, ArenaHeight - 18);

        double radarBearing = RadarBearingTo(evt.X, evt.Y);
        TurnRadarRight(radarBearing + Math.Sign(radarBearing) * 20);

        TurnGunRight(GunBearingTo(predictedX, predictedY));
        Fire(firePower);

        if (X < 80 || X > ArenaWidth - 80 || Y < 80 || Y > ArenaHeight - 80)
            moveDirection *= -1;

        TurnRight(NormalizeRelativeAngle(BearingTo(evt.X, evt.Y) + 90 * moveDirection));
        Forward(150 * moveDirection);
    }

    public override void OnHitByBullet(HitByBulletEvent evt) => moveDirection *= -1;

    public override void OnHitWall(HitWallEvent evt) => moveDirection *= -1;

    public override void OnHitBot(HitBotEvent evt)
    {
        Fire(3);
        moveDirection *= -1;
    }
}
