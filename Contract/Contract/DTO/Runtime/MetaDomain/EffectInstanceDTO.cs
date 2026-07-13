namespace Contract.DTO.Runtime.MetaDomain
{
    public class EffectInstanceDTO
    {
        public string DefinitionID { get; set; } = string.Empty;
        public float? RemainingTime { get; set; }
        public float? IntervalDuration { get; set; }
        public float IntervalAccumulator { get; set; }
    }
}