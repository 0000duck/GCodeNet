namespace GCodeNet.Commands
{
    [Command(CommandType.G, 3)]
    public class ControlledArcMoveCounterClockwise : CommandMapping
    {
        [ParameterType("X")]
        public double? MoveX { get; set; }
        [ParameterType("Y")]
        public double? MoveY { get; set; }
        [ParameterType("I")]
        public double? CenterX { get; set; }
        [ParameterType("J")]
        public double? CenterY { get; set; }
        [ParameterType("E")]
        public double? Extrude { get; set; }
        [ParameterType("F")]
        public double? Feedrate { get; set; }
    }
}