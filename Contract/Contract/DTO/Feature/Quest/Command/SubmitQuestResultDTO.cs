namespace Contract.DTO.Feature.Quest.Command
{
    public class SubmitQuestResultDTO
    {
        public string QuestInstanceId { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
    }
}